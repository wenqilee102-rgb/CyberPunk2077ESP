using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeSetEditorUIController : inkWidgetLogicController
	{
		private inkWidgetReference _itemsGridWidget;
		private inkTextWidgetReference _itemGridText;
		private inkWidgetReference _sortingDropdown;
		private inkWidgetReference _sortingButton;
		private inkWidgetReference _hideFaceButton;
		private inkWidgetReference _hideHeadButton;
		private inkWidgetReference _emptyGridText;
		private inkWidgetReference _wearButton;
		private inkWidgetReference _takeOffButton;
		private inkWidgetReference _resetButton;
		private CHandle<ItemModeGridClassifier> _itemGridClassifier;
		private CHandle<WardrobeItemGridView> _itemGridDataView;
		private CHandle<inkScriptableDataSourceWrapper> _itemGridDataSource;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private wCHandle<gameWardrobeSystem> _wardrobeSystem;
		private CArray<CHandle<EquipmentAreaCategoryCreated>> _equipmentAreaCategoryEventQueue;
		private CArray<CHandle<EquipmentAreaCategory>> _equipmentAreaCategories;
		private CHandle<ItemPositionProvider> _itemsPositionProvider;
		private CHandle<ItemPreferredComparisonResolver> _comparisonResolver;
		private wCHandle<WardrobeUIGameController> _wardrobeGameController;
		private CArray<wCHandle<InventoryItemDisplayController>> _areaSlotControllers;
		private CArray<CEnum<gamedataEquipmentArea>> _hiddenEquipmentAreas;
		private CEnum<gamedataEquipmentArea> _currentEquipmentArea;
		private CHandle<gameClothingSet> _currentSet;
		private wCHandle<ClothingSetController> _setButtonController;
		private wCHandle<gameuiWardrobeSetPreviewGameController> _previewController;
		private wCHandle<gameDelaySystem> _delaySystem;
		private gameDelayID _delayedTimeoutCallbackId;
		private CFloat _timeoutPeroid;
		private CHandle<ItemDisplayContextData> _displayContextData;

		[Ordinal(1)] 
		[RED("itemsGridWidget")] 
		public inkWidgetReference ItemsGridWidget
		{
			get => GetProperty(ref _itemsGridWidget);
			set => SetProperty(ref _itemsGridWidget, value);
		}

		[Ordinal(2)] 
		[RED("itemGridText")] 
		public inkTextWidgetReference ItemGridText
		{
			get => GetProperty(ref _itemGridText);
			set => SetProperty(ref _itemGridText, value);
		}

		[Ordinal(3)] 
		[RED("sortingDropdown")] 
		public inkWidgetReference SortingDropdown
		{
			get => GetProperty(ref _sortingDropdown);
			set => SetProperty(ref _sortingDropdown, value);
		}

		[Ordinal(4)] 
		[RED("sortingButton")] 
		public inkWidgetReference SortingButton
		{
			get => GetProperty(ref _sortingButton);
			set => SetProperty(ref _sortingButton, value);
		}

		[Ordinal(5)] 
		[RED("hideFaceButton")] 
		public inkWidgetReference HideFaceButton
		{
			get => GetProperty(ref _hideFaceButton);
			set => SetProperty(ref _hideFaceButton, value);
		}

		[Ordinal(6)] 
		[RED("hideHeadButton")] 
		public inkWidgetReference HideHeadButton
		{
			get => GetProperty(ref _hideHeadButton);
			set => SetProperty(ref _hideHeadButton, value);
		}

		[Ordinal(7)] 
		[RED("emptyGridText")] 
		public inkWidgetReference EmptyGridText
		{
			get => GetProperty(ref _emptyGridText);
			set => SetProperty(ref _emptyGridText, value);
		}

		[Ordinal(8)] 
		[RED("wearButton")] 
		public inkWidgetReference WearButton
		{
			get => GetProperty(ref _wearButton);
			set => SetProperty(ref _wearButton, value);
		}

		[Ordinal(9)] 
		[RED("takeOffButton")] 
		public inkWidgetReference TakeOffButton
		{
			get => GetProperty(ref _takeOffButton);
			set => SetProperty(ref _takeOffButton, value);
		}

		[Ordinal(10)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetProperty(ref _resetButton);
			set => SetProperty(ref _resetButton, value);
		}

		[Ordinal(11)] 
		[RED("itemGridClassifier")] 
		public CHandle<ItemModeGridClassifier> ItemGridClassifier
		{
			get => GetProperty(ref _itemGridClassifier);
			set => SetProperty(ref _itemGridClassifier, value);
		}

		[Ordinal(12)] 
		[RED("itemGridDataView")] 
		public CHandle<WardrobeItemGridView> ItemGridDataView
		{
			get => GetProperty(ref _itemGridDataView);
			set => SetProperty(ref _itemGridDataView, value);
		}

		[Ordinal(13)] 
		[RED("itemGridDataSource")] 
		public CHandle<inkScriptableDataSourceWrapper> ItemGridDataSource
		{
			get => GetProperty(ref _itemGridDataSource);
			set => SetProperty(ref _itemGridDataSource, value);
		}

		[Ordinal(14)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(15)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(17)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(18)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(19)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(20)] 
		[RED("wardrobeSystem")] 
		public wCHandle<gameWardrobeSystem> WardrobeSystem
		{
			get => GetProperty(ref _wardrobeSystem);
			set => SetProperty(ref _wardrobeSystem, value);
		}

		[Ordinal(21)] 
		[RED("equipmentAreaCategoryEventQueue")] 
		public CArray<CHandle<EquipmentAreaCategoryCreated>> EquipmentAreaCategoryEventQueue
		{
			get => GetProperty(ref _equipmentAreaCategoryEventQueue);
			set => SetProperty(ref _equipmentAreaCategoryEventQueue, value);
		}

		[Ordinal(22)] 
		[RED("equipmentAreaCategories")] 
		public CArray<CHandle<EquipmentAreaCategory>> EquipmentAreaCategories
		{
			get => GetProperty(ref _equipmentAreaCategories);
			set => SetProperty(ref _equipmentAreaCategories, value);
		}

		[Ordinal(23)] 
		[RED("itemsPositionProvider")] 
		public CHandle<ItemPositionProvider> ItemsPositionProvider
		{
			get => GetProperty(ref _itemsPositionProvider);
			set => SetProperty(ref _itemsPositionProvider, value);
		}

		[Ordinal(24)] 
		[RED("comparisonResolver")] 
		public CHandle<ItemPreferredComparisonResolver> ComparisonResolver
		{
			get => GetProperty(ref _comparisonResolver);
			set => SetProperty(ref _comparisonResolver, value);
		}

		[Ordinal(25)] 
		[RED("wardrobeGameController")] 
		public wCHandle<WardrobeUIGameController> WardrobeGameController
		{
			get => GetProperty(ref _wardrobeGameController);
			set => SetProperty(ref _wardrobeGameController, value);
		}

		[Ordinal(26)] 
		[RED("areaSlotControllers")] 
		public CArray<wCHandle<InventoryItemDisplayController>> AreaSlotControllers
		{
			get => GetProperty(ref _areaSlotControllers);
			set => SetProperty(ref _areaSlotControllers, value);
		}

		[Ordinal(27)] 
		[RED("hiddenEquipmentAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> HiddenEquipmentAreas
		{
			get => GetProperty(ref _hiddenEquipmentAreas);
			set => SetProperty(ref _hiddenEquipmentAreas, value);
		}

		[Ordinal(28)] 
		[RED("currentEquipmentArea")] 
		public CEnum<gamedataEquipmentArea> CurrentEquipmentArea
		{
			get => GetProperty(ref _currentEquipmentArea);
			set => SetProperty(ref _currentEquipmentArea, value);
		}

		[Ordinal(29)] 
		[RED("currentSet")] 
		public CHandle<gameClothingSet> CurrentSet
		{
			get => GetProperty(ref _currentSet);
			set => SetProperty(ref _currentSet, value);
		}

		[Ordinal(30)] 
		[RED("setButtonController")] 
		public wCHandle<ClothingSetController> SetButtonController
		{
			get => GetProperty(ref _setButtonController);
			set => SetProperty(ref _setButtonController, value);
		}

		[Ordinal(31)] 
		[RED("previewController")] 
		public wCHandle<gameuiWardrobeSetPreviewGameController> PreviewController
		{
			get => GetProperty(ref _previewController);
			set => SetProperty(ref _previewController, value);
		}

		[Ordinal(32)] 
		[RED("delaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(33)] 
		[RED("delayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetProperty(ref _delayedTimeoutCallbackId);
			set => SetProperty(ref _delayedTimeoutCallbackId, value);
		}

		[Ordinal(34)] 
		[RED("timeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetProperty(ref _timeoutPeroid);
			set => SetProperty(ref _timeoutPeroid, value);
		}

		[Ordinal(35)] 
		[RED("displayContextData")] 
		public CHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		public WardrobeSetEditorUIController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
