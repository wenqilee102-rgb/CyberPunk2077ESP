using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemModeLogicController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _itemCategoryList;
		private inkTextWidgetReference _itemCategoryHeader;
		private inkCompoundWidgetReference _mainWrapper;
		private inkTextWidgetReference _emptyInventoryText;
		private inkCompoundWidgetReference _filterButtonsGrid;
		private inkTextWidgetReference _outfitsFilterInfoText;
		private inkWidgetReference _prevFilterHint;
		private inkWidgetReference _nextFilterHint;
		private inkWidgetReference _itemGridContainer;
		private inkWidgetReference _itemGridScrollControllerWidget;
		private inkWidgetReference _wardrobeSlotsContainer;
		private inkTextWidgetReference _wardrobeSlotsLabel;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private wCHandle<gameTransactionSystem> _transactionSystem;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<gameWardrobeSystem> _wardrobeSystem;
		private wCHandle<InventoryGenericItemChooser> _itemChooser;
		private CArray<CEnum<gamedataEquipmentArea>> _lastEquipmentAreas;
		private CEnum<gameEHotkey> _currentHotkey;
		private wCHandle<gameuiInventoryGameController> _inventoryController;
		private CHandle<ItemPositionProvider> _itemsPositionProvider;
		private wCHandle<gameIBlackboard> _equipmentBlackboard;
		private wCHandle<gameIBlackboard> _itemModsBlackboard;
		private wCHandle<gameIBlackboard> _disassembleBlackboard;
		private CHandle<redCallbackObject> _equipmentBlackboardCallback;
		private CHandle<redCallbackObject> _itemModsBlackboardCallback;
		private CHandle<redCallbackObject> _itemModsUpgradeBlackboardCallback;
		private CHandle<redCallbackObject> _disassembleBlackboardCallback;
		private CHandle<redCallbackObject> _equipmentInProgressCallback;
		private CEnum<gamePSMVehicle> _playerState;
		private CHandle<ItemModeGridClassifier> _itemGridClassifier;
		private CHandle<ItemModeGridView> _itemGridDataView;
		private CHandle<inkScriptableDataSourceWrapper> _itemGridDataSource;
		private wCHandle<BackpackFilterButtonController> _activeFilter;
		private CArray<wCHandle<BackpackFilterButtonController>> _filters;
		private CHandle<ItemCategoryFliterManager> _filterManager;
		private CInt32 _currentFilterIndex;
		private CEnum<ItemFilterCategory> _savedFilter;
		private wCHandle<InventoryItemDisplayController> _lastSelectedDisplay;
		private CHandle<ItemModeInventoryListenerCallback> _itemModeInventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _itemModeInventoryListener;
		private CBool _itemModeInventoryListenerRegistered;
		private wCHandle<ItemModeGridContainer> _itemGridContainerController;
		private wCHandle<ItemModeGridContainer> _cyberwareGridContainerController;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private CBool _isE3Demo;
		private CBool _isShown;
		private CArray<gameItemModParams> _itemDropQueue;
		private CHandle<inkGameNotificationToken> _confirmationPopupToken;
		private CHandle<inkGameNotificationToken> _itemPreviewPopupToken;
		private CHandle<ItemDisplayHoverOverEvent> _lastItemHoverOverEvent;
		private CBool _isComparisionDisabled;
		private CHandle<inGameMenuAnimContainer> _animContainer;
		private CEnum<UIMenuNotificationType> _lastNotificationType;
		private CBool _outfitWardrobeSpawned;
		private CArray<wCHandle<WardrobeOutfitSlotController>> _wardrobeOutfitSlotControllers;
		private CBool _delayedItemEquippedRequested;
		private wCHandle<gameDelaySystem> _delaySystem;
		private gameDelayID _delayedTimeoutCallbackId;
		private gameDelayID _delayedOutfitCooldownResetCallbackId;
		private CFloat _timeoutPeroid;
		private CBool _outfitInCooldown;
		private CFloat _outfitCooldownPeroid;
		private CHandle<inkGameNotificationToken> _tokenPopup;
		private CBool _refreshRequested;
		private CEnum<ItemFilterCategory> _currentFilter;
		private CEnum<ItemViewModes> _viewMode;
		private CArray<wCHandle<WrappedInventoryItemData>> _currentItems;
		private wCHandle<InventoryItemDisplayController> _previousSelectedItem;
		private CHandle<MenuCursorUserData> _cursorData;
		private wCHandle<InventoryItemDisplayController> _pressedItemDisplay;
		private CBool _virtualGridInitialized;
		private CHandle<inkGameNotificationToken> _replaceModNotification;
		private CHandle<InstallModConfirmationData> _installModData;
		private CHandle<ItemDisplayClickEvent> _hACK_lastItemDisplayEvent;

		[Ordinal(1)] 
		[RED("itemCategoryList")] 
		public inkCompoundWidgetReference ItemCategoryList
		{
			get => GetProperty(ref _itemCategoryList);
			set => SetProperty(ref _itemCategoryList, value);
		}

		[Ordinal(2)] 
		[RED("itemCategoryHeader")] 
		public inkTextWidgetReference ItemCategoryHeader
		{
			get => GetProperty(ref _itemCategoryHeader);
			set => SetProperty(ref _itemCategoryHeader, value);
		}

		[Ordinal(3)] 
		[RED("mainWrapper")] 
		public inkCompoundWidgetReference MainWrapper
		{
			get => GetProperty(ref _mainWrapper);
			set => SetProperty(ref _mainWrapper, value);
		}

		[Ordinal(4)] 
		[RED("emptyInventoryText")] 
		public inkTextWidgetReference EmptyInventoryText
		{
			get => GetProperty(ref _emptyInventoryText);
			set => SetProperty(ref _emptyInventoryText, value);
		}

		[Ordinal(5)] 
		[RED("filterButtonsGrid")] 
		public inkCompoundWidgetReference FilterButtonsGrid
		{
			get => GetProperty(ref _filterButtonsGrid);
			set => SetProperty(ref _filterButtonsGrid, value);
		}

		[Ordinal(6)] 
		[RED("outfitsFilterInfoText")] 
		public inkTextWidgetReference OutfitsFilterInfoText
		{
			get => GetProperty(ref _outfitsFilterInfoText);
			set => SetProperty(ref _outfitsFilterInfoText, value);
		}

		[Ordinal(7)] 
		[RED("prevFilterHint")] 
		public inkWidgetReference PrevFilterHint
		{
			get => GetProperty(ref _prevFilterHint);
			set => SetProperty(ref _prevFilterHint, value);
		}

		[Ordinal(8)] 
		[RED("nextFilterHint")] 
		public inkWidgetReference NextFilterHint
		{
			get => GetProperty(ref _nextFilterHint);
			set => SetProperty(ref _nextFilterHint, value);
		}

		[Ordinal(9)] 
		[RED("itemGridContainer")] 
		public inkWidgetReference ItemGridContainer
		{
			get => GetProperty(ref _itemGridContainer);
			set => SetProperty(ref _itemGridContainer, value);
		}

		[Ordinal(10)] 
		[RED("itemGridScrollControllerWidget")] 
		public inkWidgetReference ItemGridScrollControllerWidget
		{
			get => GetProperty(ref _itemGridScrollControllerWidget);
			set => SetProperty(ref _itemGridScrollControllerWidget, value);
		}

		[Ordinal(11)] 
		[RED("wardrobeSlotsContainer")] 
		public inkWidgetReference WardrobeSlotsContainer
		{
			get => GetProperty(ref _wardrobeSlotsContainer);
			set => SetProperty(ref _wardrobeSlotsContainer, value);
		}

		[Ordinal(12)] 
		[RED("wardrobeSlotsLabel")] 
		public inkTextWidgetReference WardrobeSlotsLabel
		{
			get => GetProperty(ref _wardrobeSlotsLabel);
			set => SetProperty(ref _wardrobeSlotsLabel, value);
		}

		[Ordinal(13)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(14)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(15)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(17)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(18)] 
		[RED("transactionSystem")] 
		public wCHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(19)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(20)] 
		[RED("wardrobeSystem")] 
		public wCHandle<gameWardrobeSystem> WardrobeSystem
		{
			get => GetProperty(ref _wardrobeSystem);
			set => SetProperty(ref _wardrobeSystem, value);
		}

		[Ordinal(21)] 
		[RED("itemChooser")] 
		public wCHandle<InventoryGenericItemChooser> ItemChooser
		{
			get => GetProperty(ref _itemChooser);
			set => SetProperty(ref _itemChooser, value);
		}

		[Ordinal(22)] 
		[RED("lastEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> LastEquipmentAreas
		{
			get => GetProperty(ref _lastEquipmentAreas);
			set => SetProperty(ref _lastEquipmentAreas, value);
		}

		[Ordinal(23)] 
		[RED("currentHotkey")] 
		public CEnum<gameEHotkey> CurrentHotkey
		{
			get => GetProperty(ref _currentHotkey);
			set => SetProperty(ref _currentHotkey, value);
		}

		[Ordinal(24)] 
		[RED("inventoryController")] 
		public wCHandle<gameuiInventoryGameController> InventoryController
		{
			get => GetProperty(ref _inventoryController);
			set => SetProperty(ref _inventoryController, value);
		}

		[Ordinal(25)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetProperty(ref _itemsPositionProvider);
			set => SetProperty(ref _itemsPositionProvider, value);
		}

		[Ordinal(26)] 
		[RED("equipmentBlackboard")] 
		public wCHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetProperty(ref _equipmentBlackboard);
			set => SetProperty(ref _equipmentBlackboard, value);
		}

		[Ordinal(27)] 
		[RED("itemModsBlackboard")] 
		public wCHandle<gameIBlackboard> ItemModsBlackboard
		{
			get => GetProperty(ref _itemModsBlackboard);
			set => SetProperty(ref _itemModsBlackboard, value);
		}

		[Ordinal(28)] 
		[RED("disassembleBlackboard")] 
		public wCHandle<gameIBlackboard> DisassembleBlackboard
		{
			get => GetProperty(ref _disassembleBlackboard);
			set => SetProperty(ref _disassembleBlackboard, value);
		}

		[Ordinal(29)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetProperty(ref _equipmentBlackboardCallback);
			set => SetProperty(ref _equipmentBlackboardCallback, value);
		}

		[Ordinal(30)] 
		[RED("itemModsBlackboardCallback")] 
		public CHandle<redCallbackObject> ItemModsBlackboardCallback
		{
			get => GetProperty(ref _itemModsBlackboardCallback);
			set => SetProperty(ref _itemModsBlackboardCallback, value);
		}

		[Ordinal(31)] 
		[RED("itemModsUpgradeBlackboardCallback")] 
		public CHandle<redCallbackObject> ItemModsUpgradeBlackboardCallback
		{
			get => GetProperty(ref _itemModsUpgradeBlackboardCallback);
			set => SetProperty(ref _itemModsUpgradeBlackboardCallback, value);
		}

		[Ordinal(32)] 
		[RED("disassembleBlackboardCallback")] 
		public CHandle<redCallbackObject> DisassembleBlackboardCallback
		{
			get => GetProperty(ref _disassembleBlackboardCallback);
			set => SetProperty(ref _disassembleBlackboardCallback, value);
		}

		[Ordinal(33)] 
		[RED("equipmentInProgressCallback")] 
		public CHandle<redCallbackObject> EquipmentInProgressCallback
		{
			get => GetProperty(ref _equipmentInProgressCallback);
			set => SetProperty(ref _equipmentInProgressCallback, value);
		}

		[Ordinal(34)] 
		[RED("playerState")] 
		public CEnum<gamePSMVehicle> PlayerState
		{
			get => GetProperty(ref _playerState);
			set => SetProperty(ref _playerState, value);
		}

		[Ordinal(35)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetProperty(ref _itemGridClassifier);
			set => SetProperty(ref _itemGridClassifier, value);
		}

		[Ordinal(36)] 
		[RED("itemGridDataView")] 
		public CHandle<ItemModeGridView> ItemGridDataView
		{
			get => GetProperty(ref _itemGridDataView);
			set => SetProperty(ref _itemGridDataView, value);
		}

		[Ordinal(37)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetProperty(ref _itemGridDataSource);
			set => SetProperty(ref _itemGridDataSource, value);
		}

		[Ordinal(38)] 
		[RED("activeFilter")] 
		public wCHandle<BackpackFilterButtonController> ActiveFilter
		{
			get => GetProperty(ref _activeFilter);
			set => SetProperty(ref _activeFilter, value);
		}

		[Ordinal(39)] 
		[RED("filters")] 
		public CArray<wCHandle<BackpackFilterButtonController>> Filters
		{
			get => GetProperty(ref _filters);
			set => SetProperty(ref _filters, value);
		}

		[Ordinal(40)] 
		[RED("filterManager")] 
		public CHandle<ItemCategoryFliterManager> FilterManager
		{
			get => GetProperty(ref _filterManager);
			set => SetProperty(ref _filterManager, value);
		}

		[Ordinal(41)] 
		[RED("currentFilterIndex")] 
		public CInt32 CurrentFilterIndex
		{
			get => GetProperty(ref _currentFilterIndex);
			set => SetProperty(ref _currentFilterIndex, value);
		}

		[Ordinal(42)] 
		[RED("savedFilter")] 
		public CEnum<ItemFilterCategory> SavedFilter
		{
			get => GetProperty(ref _savedFilter);
			set => SetProperty(ref _savedFilter, value);
		}

		[Ordinal(43)] 
		[RED("lastSelectedDisplay")] 
		public wCHandle<InventoryItemDisplayController> LastSelectedDisplay
		{
			get => GetProperty(ref _lastSelectedDisplay);
			set => SetProperty(ref _lastSelectedDisplay, value);
		}

		[Ordinal(44)] 
		[RED("itemModeInventoryListenerCallback")] 
		public CHandle<ItemModeInventoryListenerCallback> ItemModeInventoryListenerCallback
		{
			get => GetProperty(ref _itemModeInventoryListenerCallback);
			set => SetProperty(ref _itemModeInventoryListenerCallback, value);
		}

		[Ordinal(45)] 
		[RED("itemModeInventoryListener")] 
		public CHandle<gameInventoryScriptListener> ItemModeInventoryListener
		{
			get => GetProperty(ref _itemModeInventoryListener);
			set => SetProperty(ref _itemModeInventoryListener, value);
		}

		[Ordinal(46)] 
		[RED("itemModeInventoryListenerRegistered")] 
		public CBool ItemModeInventoryListenerRegistered
		{
			get => GetProperty(ref _itemModeInventoryListenerRegistered);
			set => SetProperty(ref _itemModeInventoryListenerRegistered, value);
		}

		[Ordinal(47)] 
		[RED("itemGridContainerController")] 
		public wCHandle<ItemModeGridContainer> ItemGridContainerController
		{
			get => GetProperty(ref _itemGridContainerController);
			set => SetProperty(ref _itemGridContainerController, value);
		}

		[Ordinal(48)] 
		[RED("cyberwareGridContainerController")] 
		public wCHandle<ItemModeGridContainer> CyberwareGridContainerController
		{
			get => GetProperty(ref _cyberwareGridContainerController);
			set => SetProperty(ref _cyberwareGridContainerController, value);
		}

		[Ordinal(49)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(50)] 
		[RED("isE3Demo")] 
		public CBool IsE3Demo
		{
			get => GetProperty(ref _isE3Demo);
			set => SetProperty(ref _isE3Demo, value);
		}

		[Ordinal(51)] 
		[RED("isShown")] 
		public CBool IsShown
		{
			get => GetProperty(ref _isShown);
			set => SetProperty(ref _isShown, value);
		}

		[Ordinal(52)] 
		[RED("itemDropQueue")] 
		public CArray<gameItemModParams> ItemDropQueue
		{
			get => GetProperty(ref _itemDropQueue);
			set => SetProperty(ref _itemDropQueue, value);
		}

		[Ordinal(53)] 
		[RED("confirmationPopupToken")] 
		public CHandle<inkGameNotificationToken> ConfirmationPopupToken
		{
			get => GetProperty(ref _confirmationPopupToken);
			set => SetProperty(ref _confirmationPopupToken, value);
		}

		[Ordinal(54)] 
		[RED("itemPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ItemPreviewPopupToken
		{
			get => GetProperty(ref _itemPreviewPopupToken);
			set => SetProperty(ref _itemPreviewPopupToken, value);
		}

		[Ordinal(55)] 
		[RED("lastItemHoverOverEvent")] 
		public CHandle<ItemDisplayHoverOverEvent> LastItemHoverOverEvent
		{
			get => GetProperty(ref _lastItemHoverOverEvent);
			set => SetProperty(ref _lastItemHoverOverEvent, value);
		}

		[Ordinal(56)] 
		[RED("isComparisionDisabled")] 
		public CBool IsComparisionDisabled
		{
			get => GetProperty(ref _isComparisionDisabled);
			set => SetProperty(ref _isComparisionDisabled, value);
		}

		[Ordinal(57)] 
		[RED("animContainer")] 
		public CHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetProperty(ref _animContainer);
			set => SetProperty(ref _animContainer, value);
		}

		[Ordinal(58)] 
		[RED("lastNotificationType")] 
		public CEnum<UIMenuNotificationType> LastNotificationType
		{
			get => GetProperty(ref _lastNotificationType);
			set => SetProperty(ref _lastNotificationType, value);
		}

		[Ordinal(59)] 
		[RED("outfitWardrobeSpawned")] 
		public CBool OutfitWardrobeSpawned
		{
			get => GetProperty(ref _outfitWardrobeSpawned);
			set => SetProperty(ref _outfitWardrobeSpawned, value);
		}

		[Ordinal(60)] 
		[RED("wardrobeOutfitSlotControllers")] 
		public CArray<wCHandle<WardrobeOutfitSlotController>> WardrobeOutfitSlotControllers
		{
			get => GetProperty(ref _wardrobeOutfitSlotControllers);
			set => SetProperty(ref _wardrobeOutfitSlotControllers, value);
		}

		[Ordinal(61)] 
		[RED("delayedItemEquippedRequested")] 
		public CBool DelayedItemEquippedRequested
		{
			get => GetProperty(ref _delayedItemEquippedRequested);
			set => SetProperty(ref _delayedItemEquippedRequested, value);
		}

		[Ordinal(62)] 
		[RED("delaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(63)] 
		[RED("delayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetProperty(ref _delayedTimeoutCallbackId);
			set => SetProperty(ref _delayedTimeoutCallbackId, value);
		}

		[Ordinal(64)] 
		[RED("delayedOutfitCooldownResetCallbackId")] 
		public gameDelayID DelayedOutfitCooldownResetCallbackId
		{
			get => GetProperty(ref _delayedOutfitCooldownResetCallbackId);
			set => SetProperty(ref _delayedOutfitCooldownResetCallbackId, value);
		}

		[Ordinal(65)] 
		[RED("timeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetProperty(ref _timeoutPeroid);
			set => SetProperty(ref _timeoutPeroid, value);
		}

		[Ordinal(66)] 
		[RED("outfitInCooldown")] 
		public CBool OutfitInCooldown
		{
			get => GetProperty(ref _outfitInCooldown);
			set => SetProperty(ref _outfitInCooldown, value);
		}

		[Ordinal(67)] 
		[RED("outfitCooldownPeroid")] 
		public CFloat OutfitCooldownPeroid
		{
			get => GetProperty(ref _outfitCooldownPeroid);
			set => SetProperty(ref _outfitCooldownPeroid, value);
		}

		[Ordinal(68)] 
		[RED("tokenPopup")] 
		public CHandle<inkGameNotificationToken> TokenPopup
		{
			get => GetProperty(ref _tokenPopup);
			set => SetProperty(ref _tokenPopup, value);
		}

		[Ordinal(69)] 
		[RED("refreshRequested")] 
		public CBool RefreshRequested
		{
			get => GetProperty(ref _refreshRequested);
			set => SetProperty(ref _refreshRequested, value);
		}

		[Ordinal(70)] 
		[RED("currentFilter")] 
		public CEnum<ItemFilterCategory> CurrentFilter
		{
			get => GetProperty(ref _currentFilter);
			set => SetProperty(ref _currentFilter, value);
		}

		[Ordinal(71)] 
		[RED("viewMode")] 
		public CEnum<ItemViewModes> ViewMode
		{
			get => GetProperty(ref _viewMode);
			set => SetProperty(ref _viewMode, value);
		}

		[Ordinal(72)] 
		[RED("currentItems")] 
		public CArray<wCHandle<WrappedInventoryItemData>> CurrentItems
		{
			get => GetProperty(ref _currentItems);
			set => SetProperty(ref _currentItems, value);
		}

		[Ordinal(73)] 
		[RED("previousSelectedItem")] 
		public wCHandle<InventoryItemDisplayController> PreviousSelectedItem
		{
			get => GetProperty(ref _previousSelectedItem);
			set => SetProperty(ref _previousSelectedItem, value);
		}

		[Ordinal(74)] 
		[RED("cursorData")] 
		public CHandle<MenuCursorUserData> CursorData
		{
			get => GetProperty(ref _cursorData);
			set => SetProperty(ref _cursorData, value);
		}

		[Ordinal(75)] 
		[RED("pressedItemDisplay")] 
		public wCHandle<InventoryItemDisplayController> PressedItemDisplay
		{
			get => GetProperty(ref _pressedItemDisplay);
			set => SetProperty(ref _pressedItemDisplay, value);
		}

		[Ordinal(76)] 
		[RED("virtualGridInitialized")] 
		public CBool VirtualGridInitialized
		{
			get => GetProperty(ref _virtualGridInitialized);
			set => SetProperty(ref _virtualGridInitialized, value);
		}

		[Ordinal(77)] 
		[RED("replaceModNotification")] 
		public CHandle<inkGameNotificationToken> ReplaceModNotification
		{
			get => GetProperty(ref _replaceModNotification);
			set => SetProperty(ref _replaceModNotification, value);
		}

		[Ordinal(78)] 
		[RED("installModData")] 
		public CHandle<InstallModConfirmationData> InstallModData
		{
			get => GetProperty(ref _installModData);
			set => SetProperty(ref _installModData, value);
		}

		[Ordinal(79)] 
		[RED("HACK_lastItemDisplayEvent")] 
		public CHandle<ItemDisplayClickEvent> HACK_lastItemDisplayEvent
		{
			get => GetProperty(ref _hACK_lastItemDisplayEvent);
			set => SetProperty(ref _hACK_lastItemDisplayEvent, value);
		}

		public InventoryItemModeLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
