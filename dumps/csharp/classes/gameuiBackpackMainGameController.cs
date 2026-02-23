using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBackpackMainGameController : gameuiMenuGameController
	{
		private inkCompoundWidgetReference _commonCraftingMaterialsGrid;
		private inkCompoundWidgetReference _hackingCraftingMaterialsGrid;
		private inkCompoundWidgetReference _filterButtonsGrid;
		private inkVirtualCompoundWidgetReference _virtualItemsGrid;
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _itemsListScrollAreaContainer;
		private inkWidgetReference _itemNotificationRoot;
		private inkWidgetReference _disassembleJunkButton;
		private wCHandle<inkGridController> _virtualBackpackItemsListController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CArray<CEnum<gamedataItemType>> _itemTypeSorting;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private CArray<gameItemID> _itemDropQueueItems;
		private CArray<gameItemModParams> _itemDropQueue;
		private CArray<CHandle<UIInventoryItem>> _junkItems;
		private CBool _isRefreshUIScheduled;
		private CArray<wCHandle<CrafringMaterialItemController>> _craftingMaterialsListItems;
		private CHandle<UI_CraftingDef> _disassembleCallback;
		private wCHandle<gameIBlackboard> _disassembleBlackboard;
		private CHandle<redCallbackObject> _disassembleBBID;
		private CHandle<UI_EquipmentDef> _equippedCallback;
		private wCHandle<gameIBlackboard> _equippedBlackboard;
		private CHandle<redCallbackObject> _equippedBBID;
		private CHandle<UI_InventoryDef> _inventoryCallback;
		private wCHandle<gameIBlackboard> _inventoryBlackboard;
		private CHandle<redCallbackObject> _inventoryItemAddedBBID;
		private CHandle<redCallbackObject> _inventoryItemRemvoedBBID;
		private CHandle<redCallbackObject> _inventoryItemQuantityChangedBBID;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<BackpackFilterButtonController> _activeFilter;
		private CArray<wCHandle<inkAsyncSpawnRequest>> _filterSpawnRequests;
		private CHandle<inkScriptableDataSourceWrapper> _backpackItemsDataSource;
		private CHandle<BackpackDataView> _backpackItemsDataView;
		private CHandle<InventoryItemPreferredComparisonResolver> _comparisonResolver;
		private CHandle<BackpackInventoryListenerCallback> _backpackInventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _backpackInventoryListener;
		private CHandle<ItemDisplayTemplateClassifier> _backpackItemsClassifier;
		private CHandle<ItemPositionProvider> _backpackItemsPositionProvider;
		private CHandle<inkGameNotificationToken> _equipSlotChooserPopupToken;
		private CHandle<inkGameNotificationToken> _quantityPickerPopupToken;
		private CHandle<inkGameNotificationToken> _disassembleJunkPopupToken;
		private CBool _equipRequested;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CEnum<gamePSMVehicle> _playerState;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<UIInventoryScriptableSystem> _uiInventorySystem;
		private CHandle<ItemDisplayContextData> _itemDisplayContext;
		private CHandle<ItemDisplayContextData> _comparedItemDisplayContext;
		private CHandle<inkGameNotificationToken> _confirmationPopupToken;
		private CHandle<ItemDisplayHoverOverEvent> _lastItemHoverOverEvent;
		private CBool _isComparisonDisabled;
		private CHandle<BakcpackImmediateNotificationListener> _immediateNotificationListener;
		private wCHandle<InventoryItemDisplayController> _lastDisassembledWidget;
		private CHandle<MenuCursorUserData> _cursorData;
		private wCHandle<InventoryItemDisplayController> _pressedItemDisplay;
		private gameDelayID _delayedOutfitCooldownResetCallbackId;
		private CBool _outfitInCooldown;
		private CFloat _outfitCooldownPeroid;
		private CHandle<inkScriptWeakHashMap> _virtualWidgets;
		private CHandle<inkScriptWeakHashMap> _allWidgets;
		private CHandle<inkGameNotificationToken> _itemPreviewPopupToken;
		private CBool _afterCloseRequest;

		[Ordinal(3)] 
		[RED("commonCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference CommonCraftingMaterialsGrid
		{
			get => GetProperty(ref _commonCraftingMaterialsGrid);
			set => SetProperty(ref _commonCraftingMaterialsGrid, value);
		}

		[Ordinal(4)] 
		[RED("hackingCraftingMaterialsGrid")] 
		public inkCompoundWidgetReference HackingCraftingMaterialsGrid
		{
			get => GetProperty(ref _hackingCraftingMaterialsGrid);
			set => SetProperty(ref _hackingCraftingMaterialsGrid, value);
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get => GetProperty(ref _filterButtonsGrid);
			set => SetProperty(ref _filterButtonsGrid, value);
		}

		[Ordinal(6)] 
		[RED("virtualItemsGrid")] 
		public inkVirtualCompoundWidgetReference VirtualItemsGrid
		{
			get => GetProperty(ref _virtualItemsGrid);
			set => SetProperty(ref _virtualItemsGrid, value);
		}

		[Ordinal(7)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(8)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(9)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetProperty(ref _sortingButton);
			set => SetProperty(ref _sortingButton, value);
		}

		[Ordinal(10)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(11)] 
		[RED("itemsListScrollAreaContainer")] 
		public inkWidgetReference ItemsListScrollAreaContainer
		{
			get => GetProperty(ref _itemsListScrollAreaContainer);
			set => SetProperty(ref _itemsListScrollAreaContainer, value);
		}

		[Ordinal(12)] 
		[RED("itemNotificationRoot")] 
		public inkWidgetReference ItemNotificationRoot
		{
			get => GetProperty(ref _itemNotificationRoot);
			set => SetProperty(ref _itemNotificationRoot, value);
		}

		[Ordinal(13)] 
		[RED("disassembleJunkButton")] 
		public inkWidgetReference DisassembleJunkButton
		{
			get => GetProperty(ref _disassembleJunkButton);
			set => SetProperty(ref _disassembleJunkButton, value);
		}

		[Ordinal(14)] 
		[RED("virtualBackpackItemsListController")] 
		public wCHandle<inkGridController> VirtualBackpackItemsListController
		{
			get => GetProperty(ref _virtualBackpackItemsListController);
			set => SetProperty(ref _virtualBackpackItemsListController, value);
		}

		[Ordinal(15)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(17)] 
		[RED("itemTypeSorting")] 
		public CArray<CEnum<gamedataItemType>> ItemTypeSorting
		{
			get => GetProperty(ref _itemTypeSorting);
			set => SetProperty(ref _itemTypeSorting, value);
		}

		[Ordinal(18)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(19)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(20)] 
		[RED("itemDropQueueItems")] 
		public CArray<gameItemID> ItemDropQueueItems
		{
			get => GetProperty(ref _itemDropQueueItems);
			set => SetProperty(ref _itemDropQueueItems, value);
		}

		[Ordinal(21)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetProperty(ref _itemDropQueue);
			set => SetProperty(ref _itemDropQueue, value);
		}

		[Ordinal(22)] 
		[RED("junkItems")] 
		public CArray<CHandle<UIInventoryItem>> JunkItems
		{
			get => GetProperty(ref _junkItems);
			set => SetProperty(ref _junkItems, value);
		}

		[Ordinal(23)] 
		[RED("isRefreshUIScheduled")] 
		public CBool IsRefreshUIScheduled
		{
			get => GetProperty(ref _isRefreshUIScheduled);
			set => SetProperty(ref _isRefreshUIScheduled, value);
		}

		[Ordinal(24)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<wCHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get => GetProperty(ref _craftingMaterialsListItems);
			set => SetProperty(ref _craftingMaterialsListItems, value);
		}

		[Ordinal(25)] 
		[RED("DisassembleCallback")] 
		public CHandle<UI_CraftingDef> DisassembleCallback
		{
			get => GetProperty(ref _disassembleCallback);
			set => SetProperty(ref _disassembleCallback, value);
		}

		[Ordinal(26)] 
		[RED("DisassembleBlackboard")] 
		public wCHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetProperty(ref _disassembleBlackboard);
			set => SetProperty(ref _disassembleBlackboard, value);
		}

		[Ordinal(27)] 
		[RED("DisassembleBBID")] 
		public CHandle<redCallbackObject> DisassembleBBID
		{
			get => GetProperty(ref _disassembleBBID);
			set => SetProperty(ref _disassembleBBID, value);
		}

		[Ordinal(28)] 
		[RED("EquippedCallback")] 
		public CHandle<UI_EquipmentDef> EquippedCallback
		{
			get => GetProperty(ref _equippedCallback);
			set => SetProperty(ref _equippedCallback, value);
		}

		[Ordinal(29)] 
		[RED("EquippedBlackboard")] 
		public wCHandle<gameIBlackboard> EquippedBlackboard
		{
			get => GetProperty(ref _equippedBlackboard);
			set => SetProperty(ref _equippedBlackboard, value);
		}

		[Ordinal(30)] 
		[RED("EquippedBBID")] 
		public CHandle<redCallbackObject> EquippedBBID
		{
			get => GetProperty(ref _equippedBBID);
			set => SetProperty(ref _equippedBBID, value);
		}

		[Ordinal(31)] 
		[RED("InventoryCallback")] 
		public CHandle<UI_InventoryDef> InventoryCallback
		{
			get => GetProperty(ref _inventoryCallback);
			set => SetProperty(ref _inventoryCallback, value);
		}

		[Ordinal(32)] 
		[RED("InventoryBlackboard")] 
		public wCHandle<gameIBlackboard> InventoryBlackboard
		{
			get => GetProperty(ref _inventoryBlackboard);
			set => SetProperty(ref _inventoryBlackboard, value);
		}

		[Ordinal(33)] 
		[RED("InventoryItemAddedBBID")] 
		public CHandle<redCallbackObject> InventoryItemAddedBBID
		{
			get => GetProperty(ref _inventoryItemAddedBBID);
			set => SetProperty(ref _inventoryItemAddedBBID, value);
		}

		[Ordinal(34)] 
		[RED("InventoryItemRemvoedBBID")] 
		public CHandle<redCallbackObject> InventoryItemRemvoedBBID
		{
			get => GetProperty(ref _inventoryItemRemvoedBBID);
			set => SetProperty(ref _inventoryItemRemvoedBBID, value);
		}

		[Ordinal(35)] 
		[RED("InventoryItemQuantityChangedBBID")] 
		public CHandle<redCallbackObject> InventoryItemQuantityChangedBBID
		{
			get => GetProperty(ref _inventoryItemQuantityChangedBBID);
			set => SetProperty(ref _inventoryItemQuantityChangedBBID, value);
		}

		[Ordinal(36)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(37)] 
		[RED("activeFilter")] 
		public wCHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetProperty(ref _activeFilter);
			set => SetProperty(ref _activeFilter, value);
		}

		[Ordinal(38)] 
		[RED("filterSpawnRequests")] 
		public CArray<wCHandle<inkAsyncSpawnRequest>> FilterSpawnRequests
		{
			get => GetProperty(ref _filterSpawnRequests);
			set => SetProperty(ref _filterSpawnRequests, value);
		}

		[Ordinal(39)] 
		[RED("backpackItemsDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> BackpackItemsDataSource
		{
			get => GetProperty(ref _backpackItemsDataSource);
			set => SetProperty(ref _backpackItemsDataSource, value);
		}

		[Ordinal(40)] 
		[RED("backpackItemsDataView")] 
		public CHandle<BackpackDataView> BackpackItemsDataView
		{
			get => GetProperty(ref _backpackItemsDataView);
			set => SetProperty(ref _backpackItemsDataView, value);
		}

		[Ordinal(41)] 
		[RED("comparisonResolver")] 
		public CHandle<InventoryItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(42)] 
		[RED("backpackInventoryListenerCallback")] 
		public CHandle<BackpackInventoryListenerCallback> BackpackInventoryListenerCallback
		{
			get => GetProperty(ref _backpackInventoryListenerCallback);
			set => SetProperty(ref _backpackInventoryListenerCallback, value);
		}

		[Ordinal(43)] 
		[RED("backpackInventoryListener")] 
		public CHandle<gameInventoryScriptListener> BackpackInventoryListener
		{
			get => GetProperty(ref _backpackInventoryListener);
			set => SetProperty(ref _backpackInventoryListener, value);
		}

		[Ordinal(44)] 
		[RED("backpackItemsClassifier")] 
		public CHandle<ItemDisplayTemplateClassifier> BackpackItemsClassifier
		{
			get => GetProperty(ref _backpackItemsClassifier);
			set => SetProperty(ref _backpackItemsClassifier, value);
		}

		[Ordinal(45)] 
		[RED("backpackItemsPositionProvider")] 
		public CHandle<ItemPositionProvider> BackpackItemsPositionProvider
		{
			get => GetProperty(ref _backpackItemsPositionProvider);
			set => SetProperty(ref _backpackItemsPositionProvider, value);
		}

		[Ordinal(46)] 
		[RED("equipSlotChooserPopupToken")] 
		public CHandle<inkGameNotificationToken> EquipSlotChooserPopupToken
		{
			get => GetProperty(ref _equipSlotChooserPopupToken);
			set => SetProperty(ref _equipSlotChooserPopupToken, value);
		}

		[Ordinal(47)] 
		[RED("quantityPickerPopupToken")] 
		public CHandle<inkGameNotificationToken> QuantityPickerPopupToken
		{
			get => GetProperty(ref _quantityPickerPopupToken);
			set => SetProperty(ref _quantityPickerPopupToken, value);
		}

		[Ordinal(48)] 
		[RED("disassembleJunkPopupToken")] 
		public CHandle<inkGameNotificationToken> DisassembleJunkPopupToken
		{
			get => GetProperty(ref _disassembleJunkPopupToken);
			set => SetProperty(ref _disassembleJunkPopupToken, value);
		}

		[Ordinal(49)] 
		[RED("equipRequested")] 
		public CBool EquipRequested
		{
			get => GetProperty(ref _equipRequested);
			set => SetProperty(ref _equipRequested, value);
		}

		[Ordinal(50)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(51)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetProperty(ref _playerState);
			set => SetProperty(ref _playerState, value);
		}

		[Ordinal(52)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(53)] 
		[RED("uiInventorySystem")] 
		public wCHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetProperty(ref _uiInventorySystem);
			set => SetProperty(ref _uiInventorySystem, value);
		}

		[Ordinal(54)] 
		[RED("itemDisplayContext")] 
		public CHandle<ItemDisplayContextData> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(55)] 
		[RED("comparedItemDisplayContext")] 
		public CHandle<ItemDisplayContextData> ComparedItemDisplayContext
		{
			get => GetProperty(ref _comparedItemDisplayContext);
			set => SetProperty(ref _comparedItemDisplayContext, value);
		}

		[Ordinal(56)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetProperty(ref _confirmationPopupToken);
			set => SetProperty(ref _confirmationPopupToken, value);
		}

		[Ordinal(57)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetProperty(ref _lastItemHoverOverEvent);
			set => SetProperty(ref _lastItemHoverOverEvent, value);
		}

		[Ordinal(58)] 
		[RED("isComparisonDisabled")] 
		public CBool IsComparisonDisabled
		{
			get => GetProperty(ref _isComparisonDisabled);
			set => SetProperty(ref _isComparisonDisabled, value);
		}

		[Ordinal(59)] 
		[RED("immediateNotificationListener")] 
		public CHandle<BakcpackImmediateNotificationListener> ImmediateNotificationListener
		{
			get => GetProperty(ref _immediateNotificationListener);
			set => SetProperty(ref _immediateNotificationListener, value);
		}

		[Ordinal(60)] 
		[RED("lastDisassembledWidget")] 
		public wCHandle<InventoryItemDisplayController> LastDisassembledWidget
		{
			get => GetProperty(ref _lastDisassembledWidget);
			set => SetProperty(ref _lastDisassembledWidget, value);
		}

		[Ordinal(61)] 
		[RED("cursorData")] 
		public CHandle<MenuCursorUserData> CursorData
		{
			get => GetProperty(ref _cursorData);
			set => SetProperty(ref _cursorData, value);
		}

		[Ordinal(62)] 
		[RED("pressedItemDisplay")] 
		public wCHandle<InventoryItemDisplayController> PressedItemDisplay
		{
			get => GetProperty(ref _pressedItemDisplay);
			set => SetProperty(ref _pressedItemDisplay, value);
		}

		[Ordinal(63)] 
		[RED("delayedOutfitCooldownResetCallbackId")] 
		public gameDelayID DelayedOutfitCooldownResetCallbackId
		{
			get => GetProperty(ref _delayedOutfitCooldownResetCallbackId);
			set => SetProperty(ref _delayedOutfitCooldownResetCallbackId, value);
		}

		[Ordinal(64)] 
		[RED("outfitInCooldown")] 
		public CBool OutfitInCooldown
		{
			get => GetProperty(ref _outfitInCooldown);
			set => SetProperty(ref _outfitInCooldown, value);
		}

		[Ordinal(65)] 
		[RED("outfitCooldownPeroid")] 
		public CFloat OutfitCooldownPeroid
		{
			get => GetProperty(ref _outfitCooldownPeroid);
			set => SetProperty(ref _outfitCooldownPeroid, value);
		}

		[Ordinal(66)] 
		[RED("virtualWidgets")] 
		public CHandle<inkScriptWeakHashMap> VirtualWidgets
		{
			get => GetProperty(ref _virtualWidgets);
			set => SetProperty(ref _virtualWidgets, value);
		}

		[Ordinal(67)] 
		[RED("allWidgets")] 
		public CHandle<inkScriptWeakHashMap> AllWidgets
		{
			get => GetProperty(ref _allWidgets);
			set => SetProperty(ref _allWidgets, value);
		}

		[Ordinal(68)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetProperty(ref _itemPreviewPopupToken);
			set => SetProperty(ref _itemPreviewPopupToken, value);
		}

		[Ordinal(69)] 
		[RED("afterCloseRequest")] 
		public CBool AfterCloseRequest
		{
			get => GetProperty(ref _afterCloseRequest);
			set => SetProperty(ref _afterCloseRequest, value);
		}

		public gameuiBackpackMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
