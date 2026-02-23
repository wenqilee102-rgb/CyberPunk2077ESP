using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryScriptableSystem : gameScriptableSystem
	{
		private wCHandle<PlayerPuppet> _attachedPlayer;
		private CHandle<UIInventoryScriptableInventoryListenerCallback> _inventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CHandle<UIInventoryScriptableEquipmentListener> _equipmentListener;
		private CHandle<UIInventoryScriptableStatsListener> _playerStatsListener;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CHandle<inkScriptHashMap> _playerItems;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<UIScriptableSystem> _uiScriptableSystem;
		private CHandle<UIInventoryItemsManager> _inventoryItemsManager;
		private CArray<CName> _blacklistedTags;
		private CHandle<inkScriptHashMap> _cachedNonInventoryItems;
		private CHandle<inkScriptWeakHashMap> _statsDependantItems;
		private wCHandle<gameIBlackboard> _inventoryBlackboard;
		private CHandle<UI_CraftingDef> _craftingBlackboardDefinition;
		private CHandle<UI_LevelUpDef> _levelUpDef;
		private CHandle<UI_AttributeBoughtDef> _attributeBoughtDef;
		private wCHandle<gameIBlackboard> _blackboard;
		private wCHandle<gameIBlackboard> _blackboardAttributeBought;
		private wCHandle<gameIBlackboard> _blackboardLevelUp;
		private CHandle<redCallbackObject> _upgradeBlackboardCallback;
		private CHandle<redCallbackObject> _characterLevelBlackboardCallback;
		private CHandle<redCallbackObject> _onAttributesChangeCallback;
		private CHandle<questQuestsSystem> _tEMP_questSystem;
		private CUInt32 _tEMP_cuverBarsListener;
		private CUInt32 _tEMP_separatorBarsListener;
		private CBool _itemsRestored;

		[Ordinal(0)] 
		[RED("attachedPlayer")] 
		public wCHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetProperty(ref _attachedPlayer);
			set => SetProperty(ref _attachedPlayer, value);
		}

		[Ordinal(1)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIInventoryScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetProperty(ref _inventoryListenerCallback);
			set => SetProperty(ref _inventoryListenerCallback, value);
		}

		[Ordinal(2)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(3)] 
		[RED("equipmentListener")] 
		public CHandle<UIInventoryScriptableEquipmentListener> EquipmentListener
		{
			get => GetProperty(ref _equipmentListener);
			set => SetProperty(ref _equipmentListener, value);
		}

		[Ordinal(4)] 
		[RED("playerStatsListener")] 
		public CHandle<UIInventoryScriptableStatsListener> PlayerStatsListener
		{
			get => GetProperty(ref _playerStatsListener);
			set => SetProperty(ref _playerStatsListener, value);
		}

		[Ordinal(5)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(6)] 
		[RED("playerItems")] 
		public CHandle<inkScriptHashMap> PlayerItems
		{
			get => GetProperty(ref _playerItems);
			set => SetProperty(ref _playerItems, value);
		}

		[Ordinal(7)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(8)] 
		[RED("uiScriptableSystem")] 
		public CHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(9)] 
		[RED("inventoryItemsManager")] 
		public CHandle<UIInventoryItemsManager> InventoryItemsManager
		{
			get => GetProperty(ref _inventoryItemsManager);
			set => SetProperty(ref _inventoryItemsManager, value);
		}

		[Ordinal(10)] 
		[RED("blacklistedTags")] 
		public CArray<CName> BlacklistedTags
		{
			get => GetProperty(ref _blacklistedTags);
			set => SetProperty(ref _blacklistedTags, value);
		}

		[Ordinal(11)] 
		[RED("cachedNonInventoryItems")] 
		public CHandle<inkScriptHashMap> CachedNonInventoryItems
		{
			get => GetProperty(ref _cachedNonInventoryItems);
			set => SetProperty(ref _cachedNonInventoryItems, value);
		}

		[Ordinal(12)] 
		[RED("statsDependantItems")] 
		public CHandle<inkScriptWeakHashMap> StatsDependantItems
		{
			get => GetProperty(ref _statsDependantItems);
			set => SetProperty(ref _statsDependantItems, value);
		}

		[Ordinal(13)] 
		[RED("InventoryBlackboard")] 
		public wCHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetProperty(ref _inventoryBlackboard);
			set => SetProperty(ref _inventoryBlackboard, value);
		}

		[Ordinal(14)] 
		[RED("CraftingBlackboardDefinition")] 
		public CHandle<UI_CraftingDef> CraftingBlackboardDefinition
		{
			get => GetProperty(ref _craftingBlackboardDefinition);
			set => SetProperty(ref _craftingBlackboardDefinition, value);
		}

		[Ordinal(15)] 
		[RED("LevelUpDef")] 
		public CHandle<UI_LevelUpDef> LevelUpDef
		{
			get => GetProperty(ref _levelUpDef);
			set => SetProperty(ref _levelUpDef, value);
		}

		[Ordinal(16)] 
		[RED("AttributeBoughtDef")] 
		public CHandle<UI_AttributeBoughtDef> AttributeBoughtDef
		{
			get => GetProperty(ref _attributeBoughtDef);
			set => SetProperty(ref _attributeBoughtDef, value);
		}

		[Ordinal(17)] 
		[RED("Blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(18)] 
		[RED("BlackboardAttributeBought")] 
		public wCHandle<gameIBlackboard> BlackboardAttributeBought
		{
			get => GetProperty(ref _blackboardAttributeBought);
			set => SetProperty(ref _blackboardAttributeBought, value);
		}

		[Ordinal(19)] 
		[RED("BlackboardLevelUp")] 
		public wCHandle<gameIBlackboard> BlackboardLevelUp
		{
			get => GetProperty(ref _blackboardLevelUp);
			set => SetProperty(ref _blackboardLevelUp, value);
		}

		[Ordinal(20)] 
		[RED("UpgradeBlackboardCallback")] 
		public CHandle<redCallbackObject> UpgradeBlackboardCallback
		{
			get => GetProperty(ref _upgradeBlackboardCallback);
			set => SetProperty(ref _upgradeBlackboardCallback, value);
		}

		[Ordinal(21)] 
		[RED("CharacterLevelBlackboardCallback")] 
		public CHandle<redCallbackObject> CharacterLevelBlackboardCallback
		{
			get => GetProperty(ref _characterLevelBlackboardCallback);
			set => SetProperty(ref _characterLevelBlackboardCallback, value);
		}

		[Ordinal(22)] 
		[RED("OnAttributesChangeCallback")] 
		public CHandle<redCallbackObject> OnAttributesChangeCallback
		{
			get => GetProperty(ref _onAttributesChangeCallback);
			set => SetProperty(ref _onAttributesChangeCallback, value);
		}

		[Ordinal(23)] 
		[RED("TEMP_questSystem")] 
		public CHandle<questQuestsSystem> TEMP_questSystem
		{
			get => GetProperty(ref _tEMP_questSystem);
			set => SetProperty(ref _tEMP_questSystem, value);
		}

		[Ordinal(24)] 
		[RED("TEMP_cuverBarsListener")] 
		public CUInt32 TEMP_cuverBarsListener
		{
			get => GetProperty(ref _tEMP_cuverBarsListener);
			set => SetProperty(ref _tEMP_cuverBarsListener, value);
		}

		[Ordinal(25)] 
		[RED("TEMP_separatorBarsListener")] 
		public CUInt32 TEMP_separatorBarsListener
		{
			get => GetProperty(ref _tEMP_separatorBarsListener);
			set => SetProperty(ref _tEMP_separatorBarsListener, value);
		}

		[Ordinal(26)] 
		[RED("itemsRestored")] 
		public CBool ItemsRestored
		{
			get => GetProperty(ref _itemsRestored);
			set => SetProperty(ref _itemsRestored, value);
		}

		public UIInventoryScriptableSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
