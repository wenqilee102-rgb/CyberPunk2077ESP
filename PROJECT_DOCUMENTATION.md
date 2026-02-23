# Cyberpunk 2077 ESP 项目文档

## 目录
1. [项目概述](#项目概述)
2. [技术栈](#技术栈)
3. [工具介绍](#工具介绍)
4. [核心架构](#核心架构)
5. [内存读取示例](#内存读取示例)
6. [骨骼索引定义](#骨骼索引定义-targetingparts)
7. [函数安全引用示例](#函数安全引用示例)
8. [完整流程示例](#完整流程示例)

---

## 项目概述

本项目是一个针对 Cyberpunk 2077 的 ESP (Extra Sensory Perception) 辅助工具，基于 RED4ext 框架开发。主要功能包括：

- **ESP透视**: 显示附近实体的位置、距离、类型
- **自瞄系统**: 自动瞄准目标骨骼位置
- **视野过滤**: 只显示玩家视角内的实体

---

## 技术栈

| 组件 | 技术 |
|------|------|
| 渲染引擎 | DirectX 12 |
| UI框架 | Dear ImGui |
| 注入框架 | RED4ext SDK |
| Hook框架 | DirectHook |
| 编译器 | MSVC (Visual Studio 2022) |
| 内存访问 | RTTI反射系统 |

### 关键依赖

```
RED4ext SDK - 提供游戏内部RTTI访问
DirectHook - D3D12 Present Hook
ImGui - 界面渲染
```

---

## 工具介绍

### 1. RTTI系统 (Runtime Type Information)

Cyberpunk 2077 使用 REDengine 的 RTTI 系统，允许在运行时查询和调用游戏内部类型、函数和属性。

**核心类**:
- `RED4ext::CRTTISystem` - RTTI系统主入口
- `RED4ext::CClass` - 游戏类定义
- `RED4ext::CBaseFunction` - 函数定义
- `RED4ext::CProperty` - 属性定义

### 2. CStack调用机制

**为什么需要CStack？**

直接调用游戏函数会导致访问冲突，因为游戏函数期望特定的调用约定和栈布局。CStack提供了安全的函数调用封装。

**CStack结构**:
```cpp
RED4ext::CStack(
    void* instance,           // 函数调用对象实例
    CStackType* args,         // 参数数组
    uint32_t argCount,        // 参数数量
    CStackType* result        // 返回值
);
```

### 3. 内存安全检查

```cpp
namespace Utils
{
    constexpr uintptr_t MIN_VALID_ADDRESS = 0x10000;
    constexpr uintptr_t MAX_VALID_ADDRESS = 0x7FFFFFFFFFFF;

    inline bool IsValidPtr(const void* ptr)
    {
        if (ptr == nullptr) return false;
        auto addr = reinterpret_cast<uintptr_t>(ptr);
        return addr >= MIN_VALID_ADDRESS && addr <= MAX_VALID_ADDRESS;
    }
}
```

---

## 核心架构

### 文件结构

```
2077ESP/
├── dllmain.cpp           # 入口点，D3D12 Hook
├── ESP.cpp/h             # ESP渲染逻辑
├── Aimbot.cpp/h          # 自瞄逻辑
├── Menu.cpp/h            # ImGui菜单
├── GameUtils/
│   ├── RttiUtils.cpp/h   # RTTI初始化和缓存
│   ├── EntityUtils.cpp/h # 实体操作
│   ├── PlayerUtils.cpp/h # 玩家操作
│   ├── CameraUtils.cpp/h # 相机操作
│   └── GameUtils.h       # 统一接口
└── dumps/                # 游戏类型导出
    ├── cpp/
    ├── csharp/
    └── json/
```

### 数据流

```
游戏引擎
    ↓
RTTI系统 (CRTTISystem::Get())
    ↓
获取类/函数/属性 (GetClass/GetFunction/GetProperty)
    ↓
CStack调用
    ↓
结果处理
```

---

## 内存读取示例

### 示例1: 读取实体位置

**方法1: 通过属性偏移直接读取**

```cpp
Utils::Vector3 GetEntityPosition_DirectMemory(void* entity)
{
    // 1. 获取RTTI系统
    auto rtti = RED4ext::CRTTISystem::Get();
    
    // 2. 获取类定义
    auto entityClass = rtti->GetClass("entEntity");
    
    // 3. 获取属性
    auto transformProp = entityClass->GetProperty(RED4ext::CName("transformComponent"));
    if (!transformProp) return Utils::Vector3(0,0,0);
    
    // 4. 计算内存地址
    auto entityPtr = reinterpret_cast<uintptr_t>(entity);
    auto transformComponent = *reinterpret_cast<void**>(
        entityPtr + transformProp->valueOffset
    );
    
    // 5. 继续读取嵌套属性...
    // (需要处理Handle、WorldTransform等)
    
    return result;
}
```

**方法2: 通过CStack调用函数 (推荐)**

```cpp
Utils::Vector3 GetEntityPosition(void* entity)
{
    Utils::Vector3 result(0, 0, 0);
    
    // 1. 获取函数
    auto rtti = RED4ext::CRTTISystem::Get();
    auto entityClass = rtti->GetClass("entEntity");
    auto getWorldPosFunc = entityClass->GetFunction(RED4ext::CName("GetWorldPosition"));
    
    if (!getWorldPosFunc) return result;
    
    // 2. 准备返回值容器
    Utils::Vector4 worldPos;
    
    // 3. 设置返回值类型
    RED4ext::CStackType resultType;
    resultType.type = rtti->GetType("Vector4");
    resultType.value = &worldPos;
    
    // 4. 创建CStack并执行
    RED4ext::CStack stack(entity, nullptr, 0, &resultType);
    getWorldPosFunc->Execute(&stack);
    
    // 5. 提取结果
    result.X = worldPos.X;
    result.Y = worldPos.Y;
    result.Z = worldPos.Z;
    
    return result;
}
```

### 示例2: 读取实体死亡状态

```cpp
bool IsEntityDead(void* entity)
{
    if (!Utils::IsValidPtr(entity))
        return true;

    auto rtti = RED4ext::CRTTISystem::Get();
    if (!rtti) return false;

    // 获取实体的原生类型
    auto scriptable = reinterpret_cast<RED4ext::IScriptable*>(entity);
    auto nativeType = scriptable->GetNativeType();
    if (!nativeType) return false;

    // 获取IsDead函数
    auto isDeadFunc = nativeType->GetFunction(RED4ext::CName("IsDead"));
    if (!isDeadFunc) return false;

    // 准备调用
    bool isDead = false;
    RED4ext::CStackType resultType;
    resultType.type = rtti->GetType("Bool");
    resultType.value = &isDead;

    // 执行调用
    RED4ext::CStack stack(entity, nullptr, 0, &resultType);
    isDeadFunc->Execute(&stack);
    
    return isDead;
}
```

### 示例3: 读取属性值 (处理ValueHolder)

**重要**: 某些属性存储在ValueHolder中，需要特殊处理。

```cpp
// 检查属性是否在ValueHolder中
if (property->flags.inValueHolder)
{
    // ValueHolder位于对象 + 0x38
    void** valueHolderPtr = reinterpret_cast<void**>(
        reinterpret_cast<uintptr_t>(entity) + 0x38
    );
    
    if (Utils::IsValidPtr(valueHolderPtr) && Utils::IsValidPtr(*valueHolderPtr))
    {
        // 实际值在ValueHolder内部
        basePtr = reinterpret_cast<uintptr_t>(*valueHolderPtr);
    }
}

// 然后使用basePtr + property->valueOffset访问值
```

---

## 骨骼索引定义 (TargetingParts)

### 概述

为了避免硬编码索引值，项目定义了统一的骨骼索引系统，位于 `TargetingParts.h`。

### 部位索引枚举 (PartIndex)

```cpp
namespace TargetingParts
{
    enum PartIndex : int
    {
        Chest = 0,      // 胸部 (基础标记，所有实体均具备)
        LeftHand = 1,   // 左手
        RightHand = 2,  // 右手
        LeftLeg = 3,    // 左腿
        Head = 4,       // 头部 (Z值最高)
        RightLeg = 5,   // 右腿
        Neck = 6        // 颈部
    };
}
```

### 部位分类枚举 (BodyPartCategory)

用于菜单选择的部位分类：

```cpp
enum BodyPartCategory : int
{
    CategoryHead = 0,   // 头部类 -> 选择 PartIndex::Head (4)
    CategoryChest = 1,  // 胸部类 -> 选择 PartIndex::Chest (0) 或 Neck (6)
    CategoryLimbs = 2   // 四肢类 -> 选择 PartIndex::LeftHand (1), RightHand (2), LeftLeg (3), RightLeg (5)
};
```

### 辅助函数

```cpp
// 判断是否为头部部位
inline bool IsHeadPart(int partIndex)
{
    return partIndex == PartIndex::Head;  // 4
}

// 判断是否为胸部部位
inline bool IsChestPart(int partIndex)
{
    return partIndex == PartIndex::Chest ||   // 0
           partIndex == PartIndex::Neck;       // 6
}

// 判断是否为四肢部位
inline bool IsLimbsPart(int partIndex)
{
    return partIndex == PartIndex::LeftHand ||   // 1
           partIndex == PartIndex::RightHand ||  // 2
           partIndex == PartIndex::LeftLeg ||    // 3
           partIndex == PartIndex::RightLeg;     // 5
}

// 根据分类选择部位
inline bool ShouldSelectPart(int partIndex, int category)
{
    switch (category)
    {
    case CategoryHead:   return IsHeadPart(partIndex);
    case CategoryChest:  return IsChestPart(partIndex);
    case CategoryLimbs:  return IsLimbsPart(partIndex);
    default:             return false;
    }
}

// 获取部位名称
inline const char* GetPartName(int partIndex);

// 获取分类名称
inline const char* GetCategoryName(int category);
```

### 使用示例

```cpp
// 在 Aimbot.cpp 中使用
for (uint32_t i = 0; i < partsArray.size; i++)
{
    // 使用统一函数判断是否应该选择该部位
    bool shouldUse = TargetingParts::ShouldSelectPart(i, boneIndex);
    
    if (shouldUse)
    {
        ESP::g_TargetingDebugInfo.SelectedPartIndex = i;
        return pos;
    }
}

// 在 ESP.cpp 中绘制部位标记
ImU32 color;
if (TargetingParts::IsHeadPart(i))
{
    color = IM_COL32(0, 255, 0, 255);   // 绿色 - 头部
}
else if (TargetingParts::IsChestPart(i))
{
    color = IM_COL32(255, 0, 0, 255);   // 红色 - 胸部
}
else if (TargetingParts::IsLimbsPart(i))
{
    color = IM_COL32(0, 0, 255, 255);   // 蓝色 - 四肢
}
```

### 部位颜色映射

| 部位类型 | 索引 | 颜色 | RGB |
|---------|------|------|-----|
| Head | 4 | 绿色 | (0, 255, 0) |
| Chest | 0 | 红色 | (255, 0, 0) |
| Neck | 6 | 红色 | (255, 0, 0) |
| LeftHand | 1 | 蓝色 | (0, 0, 255) |
| RightHand | 2 | 蓝色 | (0, 0, 255) |
| LeftLeg | 3 | 蓝色 | (0, 0, 255) |
| RightLeg | 5 | 蓝色 | (0, 0, 255) |

### 菜单选择映射

| 菜单选项 | Category值 | 选中索引 | 说明 |
|---------|-----------|---------|------|
| Head | 0 | [4] | 头部（Z值最高） |
| Chest | 1 | [0] 或 [6] | 胸部或颈部 |
| Limbs | 2 | [1], [2], [3], [5] | 四肢之一 |

---

## 函数安全引用示例

### 完整示例: 使用TargetingSystem获取头部位置

这是最复杂的示例，展示了如何完整还原游戏函数调用链。

#### 步骤1: 初始化RTTI缓存

```cpp
// 在RttiUtils.cpp中
bool InitializeSystems()
{
    auto rtti = RED4ext::CRTTISystem::Get();
    
    // 缓存TargetingSystem类
    g_TargetingSystemClass = rtti->GetClass("gametargetingTargetingSystem");
    
    // 缓存GetTargetingSystem函数
    auto scriptGameInstanceClass = rtti->GetClass("ScriptGameInstance");
    g_GetTargetingSystemFunc = scriptGameInstanceClass->GetFunction(
        RED4ext::CName("GetTargetingSystem")
    );
    
    // 缓存GetTargetParts函数
    g_GetTargetPartsFunc = g_TargetingSystemClass->GetFunction(
        RED4ext::CName("GetTargetParts")
    );
    
    // 缓存TargetPartInfo类和GetComponent函数
    g_TargetPartInfoClass = rtti->GetClass("gametargetingTargetPartInfo");
    g_TargetPartGetComponentFunc = g_TargetPartInfoClass->GetFunction(
        RED4ext::CName("GetComponent")
    );
    
    // 缓存GetLocalToWorld函数
    auto iPlacedComponentClass = rtti->GetClass("entIPlacedComponent");
    g_GetLocalToWorldFunc = iPlacedComponentClass->GetFunction(
        RED4ext::CName("GetLocalToWorld")
    );
    
    // 缓存TSQ_ALL函数 (用于创建查询对象)
    g_TSQ_ALLFunc = rtti->GetFunction(RED4ext::CName("TSQ_ALL;"));
    
    return true;
}
```

#### 步骤2: 获取TargetingSystem实例

```cpp
Utils::Vector3 GetHeadPositionFromTargeting(void* entity)
{
    auto rtti = RED4ext::CRTTISystem::Get();
    auto engine = RED4ext::CGameEngine::Get();
    auto gameInstance = engine->framework->gameInstance;
    
    // 创建ScriptGameInstance参数
    RED4ext::ScriptGameInstance scriptGameInstance(gameInstance);
    
    // 准备返回值 (Handle类型)
    RED4ext::Handle<RED4ext::IScriptable> targetingSystemHandle;
    RED4ext::CStackType tsResult;
    tsResult.type = rtti->GetType("handle:gametargetingTargetingSystem");
    tsResult.value = &targetingSystemHandle;
    
    // 准备参数
    RED4ext::CStackType args[1];
    args[0].type = rtti->GetType("ScriptGameInstance");
    args[0].value = &scriptGameInstance;
    
    // 调用GetTargetingSystem
    RED4ext::CStack tsStack(nullptr, args, 1, &tsResult);
    g_GetTargetingSystemFunc->Execute(&tsStack);
    
    auto targetingSystem = targetingSystemHandle.instance;
    // ... 继续
}
```

#### 步骤3: 创建查询对象

```cpp
// 创建gameTargetSearchQuery对象
RED4ext::CName queryTypeName = RED4ext::CName("gameTargetSearchQuery");
auto queryType = rtti->GetType(queryTypeName);

// 分配内存并构造对象
uint8_t* queryMemory = new uint8_t[0x100];
memset(queryMemory, 0, 0x100);
queryType->Construct(queryMemory);

// 使用TSQ_ALL初始化查询对象
RED4ext::CStackType queryResult;
queryResult.type = queryType;
queryResult.value = queryMemory;

RED4ext::CStack queryStack(nullptr, nullptr, 0, &queryResult);
g_TSQ_ALLFunc->Execute(&queryStack);

// 设置查询目标
if (g_GetEntityIDFunc)
{
    RED4ext::ent::EntityID targetEntityID;
    RED4ext::CStackType eidResult;
    eidResult.type = rtti->GetType("entEntityID");
    eidResult.value = &targetEntityID;
    
    RED4ext::CStack eidStack(entity, nullptr, 0, &eidResult);
    g_GetEntityIDFunc->Execute(&eidStack);
    
    // 设置queryTarget属性
    auto queryClass = rtti->GetClass("gameTargetSearchQuery");
    auto queryTargetProp = queryClass->GetProperty(RED4ext::CName("queryTarget"));
    queryTargetProp->SetValue(queryMemory, &targetEntityID);
}
```

#### 步骤4: 调用GetTargetParts

```cpp
// 准备玩家WeakHandle
RED4ext::WeakHandle<RED4ext::IScriptable> playerWhandle;
playerWhandle = g_PlayerHandle;  // 玩家Handle

// 准备返回数组
RED4ext::DynArray<RED4ext::game::targeting::TargetPartInfo> partsArray;
auto arrayType = rtti->GetType("array:gametargetingTargetPartInfo");
arrayType->Construct(&partsArray);

// 设置参数
RED4ext::CStackType getPartsArgs[3];
getPartsArgs[0].type = rtti->GetType("whandle:gameObject");
getPartsArgs[0].value = &playerWhandle;
getPartsArgs[1].type = queryType;
getPartsArgs[1].value = queryMemory;
getPartsArgs[2].type = arrayType;
getPartsArgs[2].value = &partsArray;

// 返回值
bool getPartsResult = false;
RED4ext::CStackType getPartsRetVal;
getPartsRetVal.type = rtti->GetType("Bool");
getPartsRetVal.value = &getPartsResult;

// 执行调用
RED4ext::CStack getPartsStack(targetingSystem, getPartsArgs, 3, &getPartsRetVal);
g_GetTargetPartsFunc->Execute(&getPartsStack);

// 清理查询对象
delete[] queryMemory;
```

#### 步骤5: 提取骨骼位置

```cpp
for (uint32_t i = 0; i < partsArray.size; i++)
{
    auto& partInfo = partsArray[i];
    
    // 获取TargetingComponent
    RED4ext::WeakHandle<RED4ext::IComponent> componentWhandle;
    RED4ext::CStackType compResult;
    compResult.type = rtti->GetType("whandle:gameTargetingComponent");
    compResult.value = &componentWhandle;
    
    RED4ext::CStackType compArgs[1];
    compArgs[0].type = rtti->GetType("gametargetingTargetPartInfo");
    compArgs[0].value = &partInfo;
    
    RED4ext::CStack compStack(nullptr, compArgs, 1, &compResult);
    g_TargetPartGetComponentFunc->Execute(&compStack);
    
    auto component = componentWhandle.instance;
    if (!component) continue;
    
    // 获取世界矩阵
    RED4ext::Matrix worldMatrix;
    RED4ext::CStackType matrixResult;
    matrixResult.type = rtti->GetType("Matrix");
    matrixResult.value = &worldMatrix;
    
    RED4ext::CStack matrixStack(component, nullptr, 0, &matrixResult);
    g_GetLocalToWorldFunc->Execute(&matrixStack);
    
    // 提取位置 (矩阵的W行存储位置)
    Utils::Vector3 pos(worldMatrix.W.X, worldMatrix.W.Y, worldMatrix.W.Z);
    
    if (pos.IsValid())
        return pos;
}

return Utils::Vector3(0, 0, 0);
```

---

## 完整流程示例

### ESP渲染流程

```
1. D3D12 Present Hook触发
   ↓
2. 初始化ImGui上下文 (首次)
   ↓
3. 更新玩家位置 (UpdatePlayerPosition)
   │
   ├─ 获取玩家Handle (cpPlayerSystem::GetLocalPlayerMainGameObject)
   └─ 获取玩家位置 (entEntity::GetWorldPosition)
   ↓
4. 更新实体缓存 (每5帧)
   │
   ├─ 获取实体列表 (ScriptGameInstance::GetEntityList)
   ├─ 过滤非Puppet实体
   ├─ 计算距离
   ├─ 检查死亡状态 (IsDead)
   └─ 读取实体类型属性
   ↓
5. 绘制ESP
   │
   ├─ 遍历缓存实体
   ├─ 视野检查 (IsInFieldOfView)
   │   └─ ProjectPoint检查深度值
   ├─ 世界坐标转屏幕坐标 (WorldToScreen)
   └─ 绘制方框/圆点
```

### 自瞄流程

```
1. 检测右键按下
   ↓
2. 查找最近目标 (FindClosestTarget)
   │
   ├─ 遍历ESP缓存
   ├─ 过滤死亡实体
   ├─ 获取骨骼位置
   │   ├─ TargetingSystem模式: GetTargetParts
   │   └─ 默认模式: 实体位置 + 高度偏移
   └─ 计算准星距离
   ↓
3. 瞄准目标 (AimAt)
   │
   ├─ 世界坐标转屏幕坐标
   ├─ 计算鼠标移动量
   └─ 平滑移动 (mouse_event)
```

---

## 调试快捷键

| 按键 | 功能 |
|------|------|
| F1 | 强制重新初始化系统 |
| F3 | 显示详细系统信息 |
| F4 | 切换菜单显示 |
| F5 | 显示实体列表调试信息 |
| F12 | 跳过调试器等待 |

---

## 常见问题

### Q: 为什么不能直接调用游戏函数？

A: 游戏函数使用特定的调用约定和内存布局，直接调用会导致栈不平衡或访问冲突。必须使用CStack封装。

### Q: ValueHolder是什么？

A: 某些属性不直接存储在对象内存中，而是存储在ValueHolder结构里。检查`property->flags.inValueHolder`来判断。

### Q: 如何找到正确的类型名称？

A: 查看 `dumps/` 目录下的导出文件，或使用 `nativeType->GetName().ToString()` 获取运行时类型名。

### Q: 函数名带分号是什么意思？

A: 某些全局函数在RTTI中注册时带有分号后缀，如 `TSQ_ALL;`。尝试两种形式。

---

## 最佳实践

### 函数缓存机制

**重要**: 避免在每次调用时执行`GetFunction`，必须使用缓存的函数指针。

#### 为什么需要函数缓存？

每次调用`GetFunction`都会：
- ❌ 增加RTTI查询开销
- ❌ 导致堆栈压力增大
- ❌ 可能引发堆栈不平衡和崩溃
- ❌ 严重影响性能

#### 正确的实现方式

**步骤1: 在RttiUtils中声明缓存指针**

```cpp
// RttiUtils.h
namespace RttiUtils
{
    extern RED4ext::CBaseFunction* g_IsDeadFunc;
    extern RED4ext::CBaseFunction* g_ProjectPointFunc;
    extern RED4ext::CBaseFunction* g_GetEntityListFunc;
    extern RED4ext::CBaseFunction* g_GetLocalPlayerMainGameObjectFunc;
    // ... 其他函数指针
}
```

**步骤2: 在初始化时缓存函数**

```cpp
// RttiUtils.cpp
bool InitializeSystems()
{
    auto rtti = RED4ext::CRTTISystem::Get();
    
    // 缓存IsDead函数
    if (!g_IsDeadFunc)
    {
        auto gameObjectClass = rtti->GetClass("gameObject");
        if (Utils::IsValidPtr(gameObjectClass))
        {
            g_IsDeadFunc = gameObjectClass->GetFunction(RED4ext::CName("IsDead"));
            if (Utils::IsValidPtr(g_IsDeadFunc))
            {
                DBG_INFO("GameObject::IsDead function: 0x%p", g_IsDeadFunc);
            }
        }
    }
    
    // 缓存ProjectPoint函数
    if (!g_ProjectPointFunc)
    {
        if (Utils::IsValidPtr(g_CameraSystem))
        {
            auto camera = static_cast<RED4ext::IScriptable*>(g_CameraSystem);
            auto cameraSystemClass = camera->GetNativeType();
            if (Utils::IsValidPtr(cameraSystemClass))
            {
                g_ProjectPointFunc = cameraSystemClass->GetFunction(RED4ext::CName("ProjectPoint"));
                if (Utils::IsValidPtr(g_ProjectPointFunc))
                {
                    DBG_INFO("CameraSystem::ProjectPoint function: 0x%p", g_ProjectPointFunc);
                }
            }
        }
    }
    
    // 缓存GetEntityList函数
    if (!g_GetEntityListFunc)
    {
        auto scriptGameInstanceClass = rtti->GetClass("ScriptGameInstance");
        if (Utils::IsValidPtr(scriptGameInstanceClass))
        {
            g_GetEntityListFunc = scriptGameInstanceClass->GetFunction(RED4ext::CName("GetEntityList"));
            if (Utils::IsValidPtr(g_GetEntityListFunc))
            {
                DBG_INFO("ScriptGameInstance::GetEntityList function: 0x%p", g_GetEntityListFunc);
            }
        }
    }
    
    // ... 其他函数缓存
    
    return true;
}
```

**步骤3: 使用缓存的函数指针**

```cpp
// 正确的方式 - 使用缓存
bool IsEntityDead(void* entity)
{
    if (!Utils::IsValidPtr(entity))
        return true;

    if (!RttiUtils::g_IsDeadFunc)
        return false;

    bool isDead = false;
    RED4ext::CStackType resultType;
    resultType.type = RED4ext::CRTTISystem::Get()->GetType("Bool");
    resultType.value = &isDead;

    RED4ext::CStack stack(entity, nullptr, 0, &resultType);
    RttiUtils::g_IsDeadFunc->Execute(&stack);
    return isDead;
}

// 错误的方式 - 每次调用GetFunction
bool IsEntityDead_WRONG(void* entity)
{
    if (!Utils::IsValidPtr(entity))
        return true;

    auto rtti = RED4ext::CRTTISystem::Get();
    auto scriptable = reinterpret_cast<RED4ext::IScriptable*>(entity);
    auto nativeType = scriptable->GetNativeType();
    if (!nativeType) return false;

    // ❌ 错误：每次都调用GetFunction
    auto isDeadFunc = nativeType->GetFunction(RED4ext::CName("IsDead"));
    if (!isDeadFunc) return false;

    bool isDead = false;
    RED4ext::CStackType resultType;
    resultType.type = rtti->GetType("Bool");
    resultType.value = &isDead;

    RED4ext::CStack stack(entity, nullptr, 0, &resultType);
    isDeadFunc->Execute(&stack);
    return isDead;
}
```

#### 性能对比

| 函数 | 错误方式 | 正确方式 | 性能提升 |
|------|---------|---------|----------|
| `WorldToScreenWithDepth` | 每次GetFunction | 使用缓存 | ~90% |
| `IsInFieldOfView` | 每次GetFunction | 使用缓存 | ~90% |
| `UpdateEntityCache` | 每次GetFunction | 使用缓存 | ~90% |
| `UpdatePlayerPosition` | 每次GetFunction | 使用缓存 | ~90% |
| `IsEntityDead` | 每次GetFunction | 使用缓存 | ~90% |

#### 检查清单

在添加新的游戏函数调用时，确保：

- ✅ 在`RttiUtils.h`中声明函数指针
- ✅ 在`RttiUtils.cpp`的`InitializeSystems`中缓存函数
- ✅ 使用`if (!g_XxxFunc)`检查缓存有效性
- ✅ 添加调试日志记录函数地址
- ✅ 在使用时直接调用缓存的函数指针
- ✅ 不要在循环或频繁调用的函数中调用`GetFunction`

#### 常见需要缓存的函数

以下函数应该被缓存（如果频繁调用）：

```cpp
// 实体相关
g_IsDeadFunc
g_GetWorldPositionFunc
g_GetEntityIDFunc

// 相机相关
g_ProjectPointFunc

// 玩家相关
g_GetLocalPlayerMainGameObjectFunc

// 实体列表
g_GetEntityListFunc

// TargetingSystem相关
g_GetTargetingSystemFunc
g_GetTargetPartsFunc
g_TargetPartGetComponentFunc
g_GetLocalToWorldFunc
g_TSQ_ALLFunc
```

---

## 类型映射参考

| RED4ext类型 | C++类型 | 说明 |
|-------------|---------|------|
| Bool | bool | 布尔值 |
| Int32 | int32_t | 32位整数 |
| Float | float | 单精度浮点 |
| Vector3 | Vector3 | 三维向量 |
| Vector4 | Vector4 | 四维向量 |
| CName | CName | 字符串哈希 |
| Handle<T> | Handle<T> | 智能指针 |
| whandle<T> | WeakHandle<T> | 弱引用指针 |
| array:T | DynArray<T> | 动态数组 |
| Matrix | Matrix | 4x4矩阵 |

---

## 免责声明

本项目仅供学习和研究目的。使用本工具可能违反游戏服务条款，请自行承担风险。
