# 2077ESP - Cyberpunk 2077 ESP & Aimbot

> **⚠️ 免责声明：本项目仅供学习和研究目的，不得用于任何商业用途或在线游戏中。使用本工具产生的任何后果由使用者自行承担。开发者不对使用本工具造成的任何损失或法律责任负责。**

## 项目概述

本项目是一个针对 Cyberpunk 2077 的 ESP (Extra Sensory Perception) 辅助工具，基于 RED4ext 框架开发。主要功能包括：

- **ESP透视**: 显示附近实体的位置、距离、类型
- **自瞄系统**: 自动瞄准目标骨骼位置，支持多种瞄准模式
- **视野过滤**: 只显示玩家视角内的实体
- **骨骼瞄准**: 支持TargetingSystem模式，精确瞄准特定身体部位
- **调试信息**: 实时显示瞄准系统调试数据

## 技术栈

| 组件 | 技术 |
|------|------|
| 渲染引擎 | DirectX 12 |
| UI框架 | Dear ImGui |
| 注入框架 | RED4ext SDK |
| Hook框架 | DirectHook |
| 编译器 | MSVC (Visual Studio 2022) |
| 内存访问 | RTTI反射系统 |
| 内存管理 | Job Scope Allocator (JSA) |

### 关键依赖

```
RED4ext SDK - 提供游戏内部RTTI访问
DirectHook - D3D12 Present Hook
ImGui - 界面渲染
```

## 核心架构

### 模块结构

```
2077ESP/
├── dllmain.cpp          # DLL入口点，初始化和清理
├── Aimbot.cpp/h         # 自瞄系统实现
├── ESP.cpp/h            # ESP透视系统实现
├── Menu.cpp/h           # ImGui菜单界面
├── GameUtils/           # 游戏工具类
│   ├── EntityUtils.cpp   # 实体相关操作
│   ├── CameraUtils.cpp   # 相机相关操作
│   ├── PlayerUtils.cpp   # 玩家相关操作
│   ├── RttiUtils.cpp    # RTTI函数和属性缓存
│   └── MemoryUtils.h    # JSA内存管理
├── TargetingParts.h      # 骨骼索引统一定义
└── include/             # RED4ext SDK头文件
```

### 内存管理规范

本项目严格遵循 **Job Scope Allocator (JSA)** 规范：

1. **核心绑定**: 模块生命周期与作业对齐，使用游戏提供的ScriptAllocator
2. **内存归一**: 所有动态内存通过JSA分配，不使用系统new/delete
3. **边界清晰**: 模块负责业务逻辑，JSA负责内存管理，职责分明

**内存分配示例：**
```cpp
auto scriptAllocator = RED4ext::Memory::ScriptAllocator::Get();
auto allocResult = scriptAllocator->Alloc(0x100);
uint8_t* queryMemory = static_cast<uint8_t*>(allocResult.memory);
scriptAllocator->Free(allocResult);
```

## 功能特性

### ESP系统
- 实体位置显示（方框/点）
- 距离计算和显示
- 实体类型识别（NPC、警察、帮派成员等）
- 视野过滤（只显示视角内实体）
- 死亡实体过滤

### 自瞄系统
- **API模式**: 通过游戏API获取骨骼位置
- **TargetingSystem模式**: 使用游戏内置瞄准系统，支持精确部位选择
- 部位选择支持:
  - 头部 (Head)
  - 胸部 (Chest)
  - 四肢 (Limbs)
- 平滑瞄准
- FOV限制

### 调试功能
- 实时显示锁定目标信息
- TargetingSystem部位可视化
- 骨骼位置调试输出
- 屏幕水印显示调试数据

## 骨骼索引定义

项目使用统一的骨骼索引定义（见 [TargetingParts.h](TargetingParts.h)）：

```cpp
enum PartIndex : int
{
    Chest = 0,      // 胸部 (基础标记)
    LeftHand = 1,   // 左手
    RightHand = 2,  // 右手
    LeftLeg = 3,    // 左腿
    Head = 4,       // 头部 (Z值最高)
    RightLeg = 5,    // 右腿
    Neck = 6         // 颈部
};

enum BodyPartCategory : int
{
    CategoryHead = 0,   // 头部类
    CategoryChest = 1,  // 胸部类
    CategoryLimbs = 2   // 四肢类
};
```

## 编译说明

### 环境要求
- Visual Studio 2022
- Windows SDK 10.0
- DirectX 12 SDK
- C++17 或更高版本

### 编译步骤
1. 克隆或下载项目
2. 使用 Visual Studio 打开 `2077ESP.sln`
3. 选择 Release 配置和 x64 平台
4. 生成解决方案

### 输出文件
- `x64/Release/2077ESP.dll` - 主DLL文件
- `x64/Release/2077ESP.lib` - 导入库

## 使用说明

### 安装
1. 将 `2077ESP.dll` 放置在 Cyberpunk 2077 \red4ext\plugins
2. 确保已安装 RED4ext 模块加载器
3. 启动游戏

### 控制台命令

- `F4` - 打开/关闭菜单
- `右键` - 锁定目标（自瞄开启时）

### 菜单选项
- **ESP设置**
  - 最大距离
  - 显示死亡实体
  - 显示方框/点
- **自瞄设置**
  - 启用/禁用
  - 瞄准模式（API/TargetingSystem）
  - 部位选择
  - 平滑度
  - FOV范围

## 技术文档

详细的技术文档请参考 [PROJECT_DOCUMENTATION.md](PROJECT_DOCUMENTATION.md)，包含：
- RTTI系统使用说明
- 函数安全引用示例
- 内存读取示例
- 完整流程说明

## 贡献

本项目仅供学习研究使用，不接受功能请求或商业合作。

## 许可证

本项目仅供学习和研究目的。使用者应遵守当地法律法规和游戏服务条款。

## 免责声明

**重要提示：**

1. 本项目仅供学习和研究目的，不得用于任何商业用途或在线游戏中。
2. 使用本工具产生的任何后果由使用者自行承担。
3. 开发者不对使用本工具造成的任何损失或法律责任负责。
4. 请遵守游戏服务条款和当地法律法规。
5. 本工具可能违反游戏公平性原则，使用时请谨慎考虑。
6. 开发者不对游戏封号、账号封禁或其他任何后果负责。

---


