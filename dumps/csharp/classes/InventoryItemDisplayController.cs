using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemDisplayController : BaseButtonView
	{
		private inkWidgetReference _widgetWrapper;
		private inkTextWidgetReference _itemName;
		private inkTextWidgetReference _itemPrice;
		private inkWidgetReference _itemRarity;
		private inkCompoundWidgetReference _commonModsRoot;
		private inkImageWidgetReference _itemImage;
		private inkImageWidgetReference _itemFallbackImage;
		private inkImageWidgetReference _itemEmptyImage;
		private inkImageWidgetReference _itemEmptyIcon;
		private inkImageWidgetReference _cyberwareEmptyImage;
		private inkWidgetReference _itemSelectedArrow;
		private inkWidgetReference _quantintyAmmoIcon;
		private inkCompoundWidgetReference _quantityWrapper;
		private inkTextWidgetReference _quantityText;
		private inkTextWidgetReference _weaponType;
		private CArray<inkWidgetReference> _highlightFrames;
		private CArray<inkWidgetReference> _equippedWidgets;
		private CArray<inkWidgetReference> _hideWhenEquippedWidgets;
		private CArray<inkWidgetReference> _hideWhenCyberwareInInventory;
		private CArray<inkWidgetReference> _showWhenCyberwareInInventory;
		private CArray<inkWidgetReference> _showInEmptyWidgets;
		private CArray<inkWidgetReference> _hideInEmptyWidgets;
		private CArray<inkWidgetReference> _backgroundFrames;
		private inkWidgetReference _equippedMarker;
		private inkWidgetReference _requirementsWrapper;
		private inkWidgetReference _iconicTint;
		private inkCompoundWidgetReference _transmogContainer;
		private inkWidgetReference _rarityWrapper;
		private inkWidgetReference _rarityCommonWrapper;
		private inkImageWidgetReference _weaponTypeImage;
		private inkWidgetReference _questItemMaker;
		private inkCompoundWidgetReference _labelsContainer;
		private inkWidgetReference _backgroundBlueprint;
		private inkWidgetReference _iconBlueprint;
		private inkImageWidgetReference _fluffBlueprint;
		private inkWidgetReference _lootitemflufficon;
		private inkImageWidgetReference _lootitemtypeicon;
		private inkWidgetReference _slotItemsCountWrapper;
		private inkTextWidgetReference _slotItemsCount;
		private inkWidgetReference _iconErrorIndicator;
		private inkWidgetReference _newItemsWrapper;
		private inkTextWidgetReference _newItemsCounter;
		private inkWidgetReference _lockIcon;
		private inkWidgetReference _transmogedIcon;
		private inkWidgetReference _iconWardrobeDisabled;
		private inkWidgetReference _comparisionArrow;
		private inkWidgetReference _iconTransmog;
		private inkWidgetReference _wardrobeInfoContainer;
		private inkTextWidgetReference _wardrobeInfoText;
		private inkWidgetReference _perkWrapper;
		private inkImageWidgetReference _perkIcon;
		private inkWidgetReference _playerFavouriteWidget;
		private CHandle<InventoryDataManagerV2> _inventoryDataManager;
		private CHandle<UIInventoryScriptableSystem> _inventoryScriptableSystem;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private gameItemID _itemID;
		private gameInventoryItemData _itemData;
		private CHandle<RecipeData> _recipeData;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataItemType> _itemType;
		private CName _emptySlotImage;
		private CString _slotName;
		private CInt32 _slotIndex;
		private CArray<wCHandle<InventoryItemModSlotDisplay>> _attachmentsDisplay;
		private gameItemID _transmogItem;
		private TweakDBID _slotID;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;
		private wCHandle<ItemLabelContainerController> _labelsContainerController;
		private CName _defaultFallbackImage;
		private CName _defaultEmptyImage;
		private CString _defaultEmptyImageAtlas;
		private CName _emptyImage;
		private CString _emptyImageAtlas;
		private CBool _isEnoughMoney;
		private CBool _owned;
		private CBool _requirementsMet;
		private CHandle<InventoryTooltipData> _tooltipData;
		private CBool _isNew;
		private CBool _isNewOverriden;
		private CBool _isPlayerFavourite;
		private CBool _isQuestBought;
		private CArray<gameItemID> _newItemsIDs;
		private CBool _newItemsFetched;
		private CBool _isBuybackStack;
		private CBool _isDLCNewItem;
		private wCHandle<gameItemData> _parentItemData;
		private CBool _isLocked;
		private CBool _visibleWhenLocked;
		private CBool _isTransmoged;
		private CBool _isWardrobeDisabled;
		private CBool _isUpgradable;
		private CInt32 _overrideQuantity;
		private CBool _hasAvailableItems;
		private CBool _isSlotTransmogged;
		private CInt32 _wardrobeOutfitIndex;
		private CHandle<IScriptable> _additionalData;
		private CBool _isBound;
		private CBool _disableItemCounter;
		private CBool _isCyberwarePreviewInInventory;
		private CBool _isPerkRequiredCyberware;
		private CHandle<inkanimProxy> _delayProxy;
		private CHandle<inkanimDefinition> _delayAnimation;
		private wCHandle<inkWidget> _hoverTarget;
		private CHandle<inkanimProxy> _upgradeProxy;
		private CHandle<inkanimProxy> _selectedCWProxy;
		private CBool _dEBUG_isIconError;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;
		private CString _dEBUG_resolvedIconName;
		private CString _dEBUG_recordItemName;
		private CString _dEBUG_innerItemName;
		private CBool _dEBUG_isIconManuallySet;
		private CBool _dEBUG_iconsNameResolverIsDebug;
		private wCHandle<UIInventoryItem> _uiInventoryItem;
		private wCHandle<ItemDisplayContextData> _displayContextData;
		private wCHandle<WrappedInventoryItemData> _parrentWrappedDataObject;

		[Ordinal(5)] 
		[RED("widgetWrapper")] 
		public inkWidgetReference WidgetWrapper
		{
			get => GetProperty(ref _widgetWrapper);
			set => SetProperty(ref _widgetWrapper, value);
		}

		[Ordinal(6)] 
		[RED("itemName")] 
		public inkTextWidgetReference ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(7)] 
		[RED("itemPrice")] 
		public inkTextWidgetReference ItemPrice
		{
			get => GetProperty(ref _itemPrice);
			set => SetProperty(ref _itemPrice, value);
		}

		[Ordinal(8)] 
		[RED("itemRarity")] 
		public inkWidgetReference ItemRarity
		{
			get => GetProperty(ref _itemRarity);
			set => SetProperty(ref _itemRarity, value);
		}

		[Ordinal(9)] 
		[RED("commonModsRoot")] 
		public inkCompoundWidgetReference CommonModsRoot
		{
			get => GetProperty(ref _commonModsRoot);
			set => SetProperty(ref _commonModsRoot, value);
		}

		[Ordinal(10)] 
		[RED("itemImage")] 
		public inkImageWidgetReference ItemImage
		{
			get => GetProperty(ref _itemImage);
			set => SetProperty(ref _itemImage, value);
		}

		[Ordinal(11)] 
		[RED("itemFallbackImage")] 
		public inkImageWidgetReference ItemFallbackImage
		{
			get => GetProperty(ref _itemFallbackImage);
			set => SetProperty(ref _itemFallbackImage, value);
		}

		[Ordinal(12)] 
		[RED("itemEmptyImage")] 
		public inkImageWidgetReference ItemEmptyImage
		{
			get => GetProperty(ref _itemEmptyImage);
			set => SetProperty(ref _itemEmptyImage, value);
		}

		[Ordinal(13)] 
		[RED("itemEmptyIcon")] 
		public inkImageWidgetReference ItemEmptyIcon
		{
			get => GetProperty(ref _itemEmptyIcon);
			set => SetProperty(ref _itemEmptyIcon, value);
		}

		[Ordinal(14)] 
		[RED("cyberwareEmptyImage")] 
		public inkImageWidgetReference CyberwareEmptyImage
		{
			get => GetProperty(ref _cyberwareEmptyImage);
			set => SetProperty(ref _cyberwareEmptyImage, value);
		}

		[Ordinal(15)] 
		[RED("itemSelectedArrow")] 
		public inkWidgetReference ItemSelectedArrow
		{
			get => GetProperty(ref _itemSelectedArrow);
			set => SetProperty(ref _itemSelectedArrow, value);
		}

		[Ordinal(16)] 
		[RED("quantintyAmmoIcon")] 
		public inkWidgetReference QuantintyAmmoIcon
		{
			get => GetProperty(ref _quantintyAmmoIcon);
			set => SetProperty(ref _quantintyAmmoIcon, value);
		}

		[Ordinal(17)] 
		[RED("quantityWrapper")] 
		public inkCompoundWidgetReference QuantityWrapper
		{
			get => GetProperty(ref _quantityWrapper);
			set => SetProperty(ref _quantityWrapper, value);
		}

		[Ordinal(18)] 
		[RED("quantityText")] 
		public inkTextWidgetReference QuantityText
		{
			get => GetProperty(ref _quantityText);
			set => SetProperty(ref _quantityText, value);
		}

		[Ordinal(19)] 
		[RED("weaponType")] 
		public inkTextWidgetReference WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		[Ordinal(20)] 
		[RED("highlightFrames")] 
		public CArray<inkWidgetReference> HighlightFrames
		{
			get => GetProperty(ref _highlightFrames);
			set => SetProperty(ref _highlightFrames, value);
		}

		[Ordinal(21)] 
		[RED("equippedWidgets")] 
		public CArray<inkWidgetReference> EquippedWidgets
		{
			get => GetProperty(ref _equippedWidgets);
			set => SetProperty(ref _equippedWidgets, value);
		}

		[Ordinal(22)] 
		[RED("hideWhenEquippedWidgets")] 
		public CArray<inkWidgetReference> HideWhenEquippedWidgets
		{
			get => GetProperty(ref _hideWhenEquippedWidgets);
			set => SetProperty(ref _hideWhenEquippedWidgets, value);
		}

		[Ordinal(23)] 
		[RED("hideWhenCyberwareInInventory")] 
		public CArray<inkWidgetReference> HideWhenCyberwareInInventory
		{
			get => GetProperty(ref _hideWhenCyberwareInInventory);
			set => SetProperty(ref _hideWhenCyberwareInInventory, value);
		}

		[Ordinal(24)] 
		[RED("showWhenCyberwareInInventory")] 
		public CArray<inkWidgetReference> ShowWhenCyberwareInInventory
		{
			get => GetProperty(ref _showWhenCyberwareInInventory);
			set => SetProperty(ref _showWhenCyberwareInInventory, value);
		}

		[Ordinal(25)] 
		[RED("showInEmptyWidgets")] 
		public CArray<inkWidgetReference> ShowInEmptyWidgets
		{
			get => GetProperty(ref _showInEmptyWidgets);
			set => SetProperty(ref _showInEmptyWidgets, value);
		}

		[Ordinal(26)] 
		[RED("hideInEmptyWidgets")] 
		public CArray<inkWidgetReference> HideInEmptyWidgets
		{
			get => GetProperty(ref _hideInEmptyWidgets);
			set => SetProperty(ref _hideInEmptyWidgets, value);
		}

		[Ordinal(27)] 
		[RED("backgroundFrames")] 
		public CArray<inkWidgetReference> BackgroundFrames
		{
			get => GetProperty(ref _backgroundFrames);
			set => SetProperty(ref _backgroundFrames, value);
		}

		[Ordinal(28)] 
		[RED("equippedMarker")] 
		public inkWidgetReference EquippedMarker
		{
			get => GetProperty(ref _equippedMarker);
			set => SetProperty(ref _equippedMarker, value);
		}

		[Ordinal(29)] 
		[RED("requirementsWrapper")] 
		public inkWidgetReference RequirementsWrapper
		{
			get => GetProperty(ref _requirementsWrapper);
			set => SetProperty(ref _requirementsWrapper, value);
		}

		[Ordinal(30)] 
		[RED("iconicTint")] 
		public inkWidgetReference IconicTint
		{
			get => GetProperty(ref _iconicTint);
			set => SetProperty(ref _iconicTint, value);
		}

		[Ordinal(31)] 
		[RED("transmogContainer")] 
		public inkCompoundWidgetReference TransmogContainer
		{
			get => GetProperty(ref _transmogContainer);
			set => SetProperty(ref _transmogContainer, value);
		}

		[Ordinal(32)] 
		[RED("rarityWrapper")] 
		public inkWidgetReference RarityWrapper
		{
			get => GetProperty(ref _rarityWrapper);
			set => SetProperty(ref _rarityWrapper, value);
		}

		[Ordinal(33)] 
		[RED("rarityCommonWrapper")] 
		public inkWidgetReference RarityCommonWrapper
		{
			get => GetProperty(ref _rarityCommonWrapper);
			set => SetProperty(ref _rarityCommonWrapper, value);
		}

		[Ordinal(34)] 
		[RED("weaponTypeImage")] 
		public inkImageWidgetReference WeaponTypeImage
		{
			get => GetProperty(ref _weaponTypeImage);
			set => SetProperty(ref _weaponTypeImage, value);
		}

		[Ordinal(35)] 
		[RED("questItemMaker")] 
		public inkWidgetReference QuestItemMaker
		{
			get => GetProperty(ref _questItemMaker);
			set => SetProperty(ref _questItemMaker, value);
		}

		[Ordinal(36)] 
		[RED("labelsContainer")] 
		public inkCompoundWidgetReference LabelsContainer
		{
			get => GetProperty(ref _labelsContainer);
			set => SetProperty(ref _labelsContainer, value);
		}

		[Ordinal(37)] 
		[RED("backgroundBlueprint")] 
		public inkWidgetReference BackgroundBlueprint
		{
			get => GetProperty(ref _backgroundBlueprint);
			set => SetProperty(ref _backgroundBlueprint, value);
		}

		[Ordinal(38)] 
		[RED("iconBlueprint")] 
		public inkWidgetReference IconBlueprint
		{
			get => GetProperty(ref _iconBlueprint);
			set => SetProperty(ref _iconBlueprint, value);
		}

		[Ordinal(39)] 
		[RED("fluffBlueprint")] 
		public inkImageWidgetReference FluffBlueprint
		{
			get => GetProperty(ref _fluffBlueprint);
			set => SetProperty(ref _fluffBlueprint, value);
		}

		[Ordinal(40)] 
		[RED("lootitemflufficon")] 
		public inkWidgetReference Lootitemflufficon
		{
			get => GetProperty(ref _lootitemflufficon);
			set => SetProperty(ref _lootitemflufficon, value);
		}

		[Ordinal(41)] 
		[RED("lootitemtypeicon")] 
		public inkImageWidgetReference Lootitemtypeicon
		{
			get => GetProperty(ref _lootitemtypeicon);
			set => SetProperty(ref _lootitemtypeicon, value);
		}

		[Ordinal(42)] 
		[RED("slotItemsCountWrapper")] 
		public inkWidgetReference SlotItemsCountWrapper
		{
			get => GetProperty(ref _slotItemsCountWrapper);
			set => SetProperty(ref _slotItemsCountWrapper, value);
		}

		[Ordinal(43)] 
		[RED("slotItemsCount")] 
		public inkTextWidgetReference SlotItemsCount
		{
			get => GetProperty(ref _slotItemsCount);
			set => SetProperty(ref _slotItemsCount, value);
		}

		[Ordinal(44)] 
		[RED("iconErrorIndicator")] 
		public inkWidgetReference IconErrorIndicator
		{
			get => GetProperty(ref _iconErrorIndicator);
			set => SetProperty(ref _iconErrorIndicator, value);
		}

		[Ordinal(45)] 
		[RED("newItemsWrapper")] 
		public inkWidgetReference NewItemsWrapper
		{
			get => GetProperty(ref _newItemsWrapper);
			set => SetProperty(ref _newItemsWrapper, value);
		}

		[Ordinal(46)] 
		[RED("newItemsCounter")] 
		public inkTextWidgetReference NewItemsCounter
		{
			get => GetProperty(ref _newItemsCounter);
			set => SetProperty(ref _newItemsCounter, value);
		}

		[Ordinal(47)] 
		[RED("lockIcon")] 
		public inkWidgetReference LockIcon
		{
			get => GetProperty(ref _lockIcon);
			set => SetProperty(ref _lockIcon, value);
		}

		[Ordinal(48)] 
		[RED("transmogedIcon")] 
		public inkWidgetReference TransmogedIcon
		{
			get => GetProperty(ref _transmogedIcon);
			set => SetProperty(ref _transmogedIcon, value);
		}

		[Ordinal(49)] 
		[RED("iconWardrobeDisabled")] 
		public inkWidgetReference IconWardrobeDisabled
		{
			get => GetProperty(ref _iconWardrobeDisabled);
			set => SetProperty(ref _iconWardrobeDisabled, value);
		}

		[Ordinal(50)] 
		[RED("comparisionArrow")] 
		public inkWidgetReference ComparisionArrow
		{
			get => GetProperty(ref _comparisionArrow);
			set => SetProperty(ref _comparisionArrow, value);
		}

		[Ordinal(51)] 
		[RED("iconTransmog")] 
		public inkWidgetReference IconTransmog
		{
			get => GetProperty(ref _iconTransmog);
			set => SetProperty(ref _iconTransmog, value);
		}

		[Ordinal(52)] 
		[RED("wardrobeInfoContainer")] 
		public inkWidgetReference WardrobeInfoContainer
		{
			get => GetProperty(ref _wardrobeInfoContainer);
			set => SetProperty(ref _wardrobeInfoContainer, value);
		}

		[Ordinal(53)] 
		[RED("wardrobeInfoText")] 
		public inkTextWidgetReference WardrobeInfoText
		{
			get => GetProperty(ref _wardrobeInfoText);
			set => SetProperty(ref _wardrobeInfoText, value);
		}

		[Ordinal(54)] 
		[RED("perkWrapper")] 
		public inkWidgetReference PerkWrapper
		{
			get => GetProperty(ref _perkWrapper);
			set => SetProperty(ref _perkWrapper, value);
		}

		[Ordinal(55)] 
		[RED("perkIcon")] 
		public inkImageWidgetReference PerkIcon
		{
			get => GetProperty(ref _perkIcon);
			set => SetProperty(ref _perkIcon, value);
		}

		[Ordinal(56)] 
		[RED("playerFavouriteWidget")] 
		public inkWidgetReference PlayerFavouriteWidget
		{
			get => GetProperty(ref _playerFavouriteWidget);
			set => SetProperty(ref _playerFavouriteWidget, value);
		}

		[Ordinal(57)] 
		[RED("inventoryDataManager")] 
		public CHandle<InventoryDataManagerV2> InventoryDataManager
		{
			get => GetProperty(ref _inventoryDataManager);
			set => SetProperty(ref _inventoryDataManager, value);
		}

		[Ordinal(58)] 
		[RED("inventoryScriptableSystem")] 
		public CHandle<UIInventoryScriptableSystem> InventoryScriptableSystem
		{
			get => GetProperty(ref _inventoryScriptableSystem);
			set => SetProperty(ref _inventoryScriptableSystem, value);
		}

		[Ordinal(59)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(60)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(61)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(62)] 
		[RED("recipeData")] 
		public CHandle<RecipeData> RecipeData
		{
			get => GetProperty(ref _recipeData);
			set => SetProperty(ref _recipeData, value);
		}

		[Ordinal(63)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(64)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(65)] 
		[RED("emptySlotImage")] 
		public CName EmptySlotImage
		{
			get => GetProperty(ref _emptySlotImage);
			set => SetProperty(ref _emptySlotImage, value);
		}

		[Ordinal(66)] 
		[RED("slotName")] 
		public CString SlotName
		{
			get => GetProperty(ref _slotName);
			set => SetProperty(ref _slotName, value);
		}

		[Ordinal(67)] 
		[RED("slotIndex")] 
		public CInt32 SlotIndex
		{
			get => GetProperty(ref _slotIndex);
			set => SetProperty(ref _slotIndex, value);
		}

		[Ordinal(68)] 
		[RED("attachmentsDisplay")] 
		public CArray<wCHandle<InventoryItemModSlotDisplay>> AttachmentsDisplay
		{
			get => GetProperty(ref _attachmentsDisplay);
			set => SetProperty(ref _attachmentsDisplay, value);
		}

		[Ordinal(69)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetProperty(ref _transmogItem);
			set => SetProperty(ref _transmogItem, value);
		}

		[Ordinal(70)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(71)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(72)] 
		[RED("labelsContainerController")] 
		public wCHandle<ItemLabelContainerController> LabelsContainerController
		{
			get => GetProperty(ref _labelsContainerController);
			set => SetProperty(ref _labelsContainerController, value);
		}

		[Ordinal(73)] 
		[RED("defaultFallbackImage")] 
		public CName DefaultFallbackImage
		{
			get => GetProperty(ref _defaultFallbackImage);
			set => SetProperty(ref _defaultFallbackImage, value);
		}

		[Ordinal(74)] 
		[RED("defaultEmptyImage")] 
		public CName DefaultEmptyImage
		{
			get => GetProperty(ref _defaultEmptyImage);
			set => SetProperty(ref _defaultEmptyImage, value);
		}

		[Ordinal(75)] 
		[RED("defaultEmptyImageAtlas")] 
		public CString DefaultEmptyImageAtlas
		{
			get => GetProperty(ref _defaultEmptyImageAtlas);
			set => SetProperty(ref _defaultEmptyImageAtlas, value);
		}

		[Ordinal(76)] 
		[RED("emptyImage")] 
		public CName EmptyImage
		{
			get => GetProperty(ref _emptyImage);
			set => SetProperty(ref _emptyImage, value);
		}

		[Ordinal(77)] 
		[RED("emptyImageAtlas")] 
		public CString EmptyImageAtlas
		{
			get => GetProperty(ref _emptyImageAtlas);
			set => SetProperty(ref _emptyImageAtlas, value);
		}

		[Ordinal(78)] 
		[RED("isEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetProperty(ref _isEnoughMoney);
			set => SetProperty(ref _isEnoughMoney, value);
		}

		[Ordinal(79)] 
		[RED("owned")] 
		public CBool Owned
		{
			get => GetProperty(ref _owned);
			set => SetProperty(ref _owned, value);
		}

		[Ordinal(80)] 
		[RED("requirementsMet")] 
		public CBool RequirementsMet
		{
			get => GetProperty(ref _requirementsMet);
			set => SetProperty(ref _requirementsMet, value);
		}

		[Ordinal(81)] 
		[RED("tooltipData")] 
		public CHandle<InventoryTooltipData> TooltipData
		{
			get => GetProperty(ref _tooltipData);
			set => SetProperty(ref _tooltipData, value);
		}

		[Ordinal(82)] 
		[RED("isNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(83)] 
		[RED("isNewOverriden")] 
		public CBool IsNewOverriden
		{
			get => GetProperty(ref _isNewOverriden);
			set => SetProperty(ref _isNewOverriden, value);
		}

		[Ordinal(84)] 
		[RED("isPlayerFavourite")] 
		public CBool IsPlayerFavourite
		{
			get => GetProperty(ref _isPlayerFavourite);
			set => SetProperty(ref _isPlayerFavourite, value);
		}

		[Ordinal(85)] 
		[RED("isQuestBought")] 
		public CBool IsQuestBought
		{
			get => GetProperty(ref _isQuestBought);
			set => SetProperty(ref _isQuestBought, value);
		}

		[Ordinal(86)] 
		[RED("newItemsIDs")] 
		public CArray<gameItemID> NewItemsIDs
		{
			get => GetProperty(ref _newItemsIDs);
			set => SetProperty(ref _newItemsIDs, value);
		}

		[Ordinal(87)] 
		[RED("newItemsFetched")] 
		public CBool NewItemsFetched
		{
			get => GetProperty(ref _newItemsFetched);
			set => SetProperty(ref _newItemsFetched, value);
		}

		[Ordinal(88)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		[Ordinal(89)] 
		[RED("isDLCNewItem")] 
		public CBool IsDLCNewItem
		{
			get => GetProperty(ref _isDLCNewItem);
			set => SetProperty(ref _isDLCNewItem, value);
		}

		[Ordinal(90)] 
		[RED("parentItemData")] 
		public wCHandle<gameItemData> ParentItemData
		{
			get => GetProperty(ref _parentItemData);
			set => SetProperty(ref _parentItemData, value);
		}

		[Ordinal(91)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(92)] 
		[RED("visibleWhenLocked")] 
		public CBool VisibleWhenLocked
		{
			get => GetProperty(ref _visibleWhenLocked);
			set => SetProperty(ref _visibleWhenLocked, value);
		}

		[Ordinal(93)] 
		[RED("isTransmoged")] 
		public CBool IsTransmoged
		{
			get => GetProperty(ref _isTransmoged);
			set => SetProperty(ref _isTransmoged, value);
		}

		[Ordinal(94)] 
		[RED("isWardrobeDisabled")] 
		public CBool IsWardrobeDisabled
		{
			get => GetProperty(ref _isWardrobeDisabled);
			set => SetProperty(ref _isWardrobeDisabled, value);
		}

		[Ordinal(95)] 
		[RED("isUpgradable")] 
		public CBool IsUpgradable
		{
			get => GetProperty(ref _isUpgradable);
			set => SetProperty(ref _isUpgradable, value);
		}

		[Ordinal(96)] 
		[RED("overrideQuantity")] 
		public CInt32 OverrideQuantity
		{
			get => GetProperty(ref _overrideQuantity);
			set => SetProperty(ref _overrideQuantity, value);
		}

		[Ordinal(97)] 
		[RED("hasAvailableItems")] 
		public CBool HasAvailableItems
		{
			get => GetProperty(ref _hasAvailableItems);
			set => SetProperty(ref _hasAvailableItems, value);
		}

		[Ordinal(98)] 
		[RED("isSlotTransmogged")] 
		public CBool IsSlotTransmogged
		{
			get => GetProperty(ref _isSlotTransmogged);
			set => SetProperty(ref _isSlotTransmogged, value);
		}

		[Ordinal(99)] 
		[RED("wardrobeOutfitIndex")] 
		public CInt32 WardrobeOutfitIndex
		{
			get => GetProperty(ref _wardrobeOutfitIndex);
			set => SetProperty(ref _wardrobeOutfitIndex, value);
		}

		[Ordinal(100)] 
		[RED("additionalData")] 
		public CHandle<IScriptable> AdditionalData
		{
			get => GetProperty(ref _additionalData);
			set => SetProperty(ref _additionalData, value);
		}

		[Ordinal(101)] 
		[RED("isBound")] 
		public CBool IsBound
		{
			get => GetProperty(ref _isBound);
			set => SetProperty(ref _isBound, value);
		}

		[Ordinal(102)] 
		[RED("disableItemCounter")] 
		public CBool DisableItemCounter
		{
			get => GetProperty(ref _disableItemCounter);
			set => SetProperty(ref _disableItemCounter, value);
		}

		[Ordinal(103)] 
		[RED("isCyberwarePreviewInInventory")] 
		public CBool IsCyberwarePreviewInInventory
		{
			get => GetProperty(ref _isCyberwarePreviewInInventory);
			set => SetProperty(ref _isCyberwarePreviewInInventory, value);
		}

		[Ordinal(104)] 
		[RED("isPerkRequiredCyberware")] 
		public CBool IsPerkRequiredCyberware
		{
			get => GetProperty(ref _isPerkRequiredCyberware);
			set => SetProperty(ref _isPerkRequiredCyberware, value);
		}

		[Ordinal(105)] 
		[RED("delayProxy")] 
		public CHandle<inkanimProxy> DelayProxy
		{
			get => GetProperty(ref _delayProxy);
			set => SetProperty(ref _delayProxy, value);
		}

		[Ordinal(106)] 
		[RED("delayAnimation")] 
		public CHandle<inkanimDefinition> DelayAnimation
		{
			get => GetProperty(ref _delayAnimation);
			set => SetProperty(ref _delayAnimation, value);
		}

		[Ordinal(107)] 
		[RED("hoverTarget")] 
		public wCHandle<inkWidget> HoverTarget
		{
			get => GetProperty(ref _hoverTarget);
			set => SetProperty(ref _hoverTarget, value);
		}

		[Ordinal(108)] 
		[RED("upgradeProxy")] 
		public CHandle<inkanimProxy> UpgradeProxy
		{
			get => GetProperty(ref _upgradeProxy);
			set => SetProperty(ref _upgradeProxy, value);
		}

		[Ordinal(109)] 
		[RED("selectedCWProxy")] 
		public CHandle<inkanimProxy> SelectedCWProxy
		{
			get => GetProperty(ref _selectedCWProxy);
			set => SetProperty(ref _selectedCWProxy, value);
		}

		[Ordinal(110)] 
		[RED("DEBUG_isIconError")] 
		public CBool DEBUG_isIconError
		{
			get => GetProperty(ref _dEBUG_isIconError);
			set => SetProperty(ref _dEBUG_isIconError, value);
		}

		[Ordinal(111)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetProperty(ref _dEBUG_iconErrorInfo);
			set => SetProperty(ref _dEBUG_iconErrorInfo, value);
		}

		[Ordinal(112)] 
		[RED("DEBUG_resolvedIconName")] 
		public CString DEBUG_resolvedIconName
		{
			get => GetProperty(ref _dEBUG_resolvedIconName);
			set => SetProperty(ref _dEBUG_resolvedIconName, value);
		}

		[Ordinal(113)] 
		[RED("DEBUG_recordItemName")] 
		public CString DEBUG_recordItemName
		{
			get => GetProperty(ref _dEBUG_recordItemName);
			set => SetProperty(ref _dEBUG_recordItemName, value);
		}

		[Ordinal(114)] 
		[RED("DEBUG_innerItemName")] 
		public CString DEBUG_innerItemName
		{
			get => GetProperty(ref _dEBUG_innerItemName);
			set => SetProperty(ref _dEBUG_innerItemName, value);
		}

		[Ordinal(115)] 
		[RED("DEBUG_isIconManuallySet")] 
		public CBool DEBUG_isIconManuallySet
		{
			get => GetProperty(ref _dEBUG_isIconManuallySet);
			set => SetProperty(ref _dEBUG_isIconManuallySet, value);
		}

		[Ordinal(116)] 
		[RED("DEBUG_iconsNameResolverIsDebug")] 
		public CBool DEBUG_iconsNameResolverIsDebug
		{
			get => GetProperty(ref _dEBUG_iconsNameResolverIsDebug);
			set => SetProperty(ref _dEBUG_iconsNameResolverIsDebug, value);
		}

		[Ordinal(117)] 
		[RED("uiInventoryItem")] 
		public wCHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetProperty(ref _uiInventoryItem);
			set => SetProperty(ref _uiInventoryItem, value);
		}

		[Ordinal(118)] 
		[RED("displayContextData")] 
		public wCHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		[Ordinal(119)] 
		[RED("parrentWrappedDataObject")] 
		public wCHandle<WrappedInventoryItemData> ParrentWrappedDataObject
		{
			get => GetProperty(ref _parrentWrappedDataObject);
			set => SetProperty(ref _parrentWrappedDataObject, value);
		}

		public InventoryItemDisplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
