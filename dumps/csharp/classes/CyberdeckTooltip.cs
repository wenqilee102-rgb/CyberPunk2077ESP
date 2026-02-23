using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckTooltip : AGenericTooltipController
	{
		private inkTextWidgetReference _itemNameText;
		private inkWidgetReference _nameTextContainer;
		private inkTextWidgetReference _nameForRecipeText;
		private inkTextWidgetReference _itemRarityText;
		private inkWidgetReference _rarityBars;
		private inkCompoundWidgetReference _categoriesWrapper;
		private inkCompoundWidgetReference _topContainer;
		private inkCompoundWidgetReference _headerContainer;
		private inkCompoundWidgetReference _statsContainer;
		private inkCompoundWidgetReference _hacksContainer;
		private inkCompoundWidgetReference _descriptionContainer;
		private inkCompoundWidgetReference _bottomContainer;
		private inkCompoundWidgetReference _statsList;
		private inkCompoundWidgetReference _priceContainer;
		private inkTextWidgetReference _descriptionText;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _equipedWrapper;
		private inkTextWidgetReference _itemTypeText;
		private inkWidgetReference _itemWeightWrapper;
		private inkTextWidgetReference _itemWeightText;
		private inkTextWidgetReference _cybderdeckBaseMemoryValue;
		private inkTextWidgetReference _cybderdeckBufferValue;
		private inkTextWidgetReference _cybderdeckSlotsValue;
		private inkCompoundWidgetReference _deviceHacksGrid;
		private inkTextWidgetReference _deviceHackHeader;
		private inkWidgetReference _namesTextContainer;
		private inkTextWidgetReference _deviceHackNamesText;
		private inkWidgetReference _textBG;
		private inkWidgetReference _namesTextContainer2;
		private inkTextWidgetReference _deviceHackNamesText2;
		private inkWidgetReference _textBG2;
		private inkWidgetReference _namesTextContainer3;
		private inkTextWidgetReference _deviceHackNamesText3;
		private inkWidgetReference _textBG3;
		private inkWidgetReference _namesTextContainer4;
		private inkTextWidgetReference _deviceHackNamesText4;
		private inkWidgetReference _textBG4;
		private inkImageWidgetReference _itemIconImage;
		private inkWidgetReference _itemAttributeRequirementsWrapper;
		private inkWidgetReference _itemAttributeRequirements;
		private inkTextWidgetReference _itemAttributeRequirementsText;
		private inkCompoundWidgetReference _allocationCostsWrapper;
		private inkImageWidgetReference _iconicLines;
		private inkWidgetReference _equipedCorner;
		private inkWidgetReference _root_1072;
		private inkWidgetReference _iconicBG;
		private inkWidgetReference _recipeWrapper;
		private inkWidgetReference _recipeBG;
		private inkWidgetReference _illegalBG;
		private inkWidgetReference _cyberwareUpgradeContainer;
		private inkWidgetReference _itemCWQuickHackMenuLinkContainer;
		private redResourceReferenceScriptToken _additionalModulesLibraryRes;
		private CName _cyberwareUpgradeModuleName;
		private wCHandle<LevelBarsController> _rarityBarsController;
		private CHandle<InventoryTooltipData> _data;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<ItemTooltipCyberwareUpgradeController> _cyberwareUpgradeController;
		private CBool _hasVehiclePerk;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<CyberdeckTooltipSettingsListener> _settingsListener;
		private CName _groupPath;
		private inkWidgetReference _minWidth;
		private CBool _bigFontEnabled;
		private wCHandle<UIInventoryItem> _itemData;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CHandle<UIInventoryItemComparisonManager> _comparisonData;
		private CEnum<InventoryTooltipDisplayContext> _tooltipDisplayContext;

		[Ordinal(2)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(3)] 
		[RED("nameTextContainer")] 
		public inkWidgetReference NameTextContainer
		{
			get => GetProperty(ref _nameTextContainer);
			set => SetProperty(ref _nameTextContainer, value);
		}

		[Ordinal(4)] 
		[RED("nameForRecipeText")] 
		public inkTextWidgetReference NameForRecipeText
		{
			get => GetProperty(ref _nameForRecipeText);
			set => SetProperty(ref _nameForRecipeText, value);
		}

		[Ordinal(5)] 
		[RED("itemRarityText")] 
		public inkTextWidgetReference ItemRarityText
		{
			get => GetProperty(ref _itemRarityText);
			set => SetProperty(ref _itemRarityText, value);
		}

		[Ordinal(6)] 
		[RED("rarityBars")] 
		public inkWidgetReference RarityBars
		{
			get => GetProperty(ref _rarityBars);
			set => SetProperty(ref _rarityBars, value);
		}

		[Ordinal(7)] 
		[RED("categoriesWrapper")] 
		public inkCompoundWidgetReference CategoriesWrapper
		{
			get => GetProperty(ref _categoriesWrapper);
			set => SetProperty(ref _categoriesWrapper, value);
		}

		[Ordinal(8)] 
		[RED("topContainer")] 
		public inkCompoundWidgetReference TopContainer
		{
			get => GetProperty(ref _topContainer);
			set => SetProperty(ref _topContainer, value);
		}

		[Ordinal(9)] 
		[RED("headerContainer")] 
		public inkCompoundWidgetReference HeaderContainer
		{
			get => GetProperty(ref _headerContainer);
			set => SetProperty(ref _headerContainer, value);
		}

		[Ordinal(10)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(11)] 
		[RED("hacksContainer")] 
		public inkCompoundWidgetReference HacksContainer
		{
			get => GetProperty(ref _hacksContainer);
			set => SetProperty(ref _hacksContainer, value);
		}

		[Ordinal(12)] 
		[RED("descriptionContainer")] 
		public inkCompoundWidgetReference DescriptionContainer
		{
			get => GetProperty(ref _descriptionContainer);
			set => SetProperty(ref _descriptionContainer, value);
		}

		[Ordinal(13)] 
		[RED("bottomContainer")] 
		public inkCompoundWidgetReference BottomContainer
		{
			get => GetProperty(ref _bottomContainer);
			set => SetProperty(ref _bottomContainer, value);
		}

		[Ordinal(14)] 
		[RED("statsList")] 
		public inkCompoundWidgetReference StatsList
		{
			get => GetProperty(ref _statsList);
			set => SetProperty(ref _statsList, value);
		}

		[Ordinal(15)] 
		[RED("priceContainer")] 
		public inkCompoundWidgetReference PriceContainer
		{
			get => GetProperty(ref _priceContainer);
			set => SetProperty(ref _priceContainer, value);
		}

		[Ordinal(16)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(17)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(18)] 
		[RED("equipedWrapper")] 
		public inkWidgetReference EquipedWrapper
		{
			get => GetProperty(ref _equipedWrapper);
			set => SetProperty(ref _equipedWrapper, value);
		}

		[Ordinal(19)] 
		[RED("itemTypeText")] 
		public inkTextWidgetReference ItemTypeText
		{
			get => GetProperty(ref _itemTypeText);
			set => SetProperty(ref _itemTypeText, value);
		}

		[Ordinal(20)] 
		[RED("itemWeightWrapper")] 
		public inkWidgetReference ItemWeightWrapper
		{
			get => GetProperty(ref _itemWeightWrapper);
			set => SetProperty(ref _itemWeightWrapper, value);
		}

		[Ordinal(21)] 
		[RED("itemWeightText")] 
		public inkTextWidgetReference ItemWeightText
		{
			get => GetProperty(ref _itemWeightText);
			set => SetProperty(ref _itemWeightText, value);
		}

		[Ordinal(22)] 
		[RED("cybderdeckBaseMemoryValue")] 
		public inkTextWidgetReference CybderdeckBaseMemoryValue
		{
			get => GetProperty(ref _cybderdeckBaseMemoryValue);
			set => SetProperty(ref _cybderdeckBaseMemoryValue, value);
		}

		[Ordinal(23)] 
		[RED("cybderdeckBufferValue")] 
		public inkTextWidgetReference CybderdeckBufferValue
		{
			get => GetProperty(ref _cybderdeckBufferValue);
			set => SetProperty(ref _cybderdeckBufferValue, value);
		}

		[Ordinal(24)] 
		[RED("cybderdeckSlotsValue")] 
		public inkTextWidgetReference CybderdeckSlotsValue
		{
			get => GetProperty(ref _cybderdeckSlotsValue);
			set => SetProperty(ref _cybderdeckSlotsValue, value);
		}

		[Ordinal(25)] 
		[RED("deviceHacksGrid")] 
		public inkCompoundWidgetReference DeviceHacksGrid
		{
			get => GetProperty(ref _deviceHacksGrid);
			set => SetProperty(ref _deviceHacksGrid, value);
		}

		[Ordinal(26)] 
		[RED("deviceHackHeader")] 
		public inkTextWidgetReference DeviceHackHeader
		{
			get => GetProperty(ref _deviceHackHeader);
			set => SetProperty(ref _deviceHackHeader, value);
		}

		[Ordinal(27)] 
		[RED("namesTextContainer")] 
		public inkWidgetReference NamesTextContainer
		{
			get => GetProperty(ref _namesTextContainer);
			set => SetProperty(ref _namesTextContainer, value);
		}

		[Ordinal(28)] 
		[RED("deviceHackNamesText")] 
		public inkTextWidgetReference DeviceHackNamesText
		{
			get => GetProperty(ref _deviceHackNamesText);
			set => SetProperty(ref _deviceHackNamesText, value);
		}

		[Ordinal(29)] 
		[RED("textBG")] 
		public inkWidgetReference TextBG
		{
			get => GetProperty(ref _textBG);
			set => SetProperty(ref _textBG, value);
		}

		[Ordinal(30)] 
		[RED("namesTextContainer2")] 
		public inkWidgetReference NamesTextContainer2
		{
			get => GetProperty(ref _namesTextContainer2);
			set => SetProperty(ref _namesTextContainer2, value);
		}

		[Ordinal(31)] 
		[RED("deviceHackNamesText2")] 
		public inkTextWidgetReference DeviceHackNamesText2
		{
			get => GetProperty(ref _deviceHackNamesText2);
			set => SetProperty(ref _deviceHackNamesText2, value);
		}

		[Ordinal(32)] 
		[RED("textBG2")] 
		public inkWidgetReference TextBG2
		{
			get => GetProperty(ref _textBG2);
			set => SetProperty(ref _textBG2, value);
		}

		[Ordinal(33)] 
		[RED("namesTextContainer3")] 
		public inkWidgetReference NamesTextContainer3
		{
			get => GetProperty(ref _namesTextContainer3);
			set => SetProperty(ref _namesTextContainer3, value);
		}

		[Ordinal(34)] 
		[RED("deviceHackNamesText3")] 
		public inkTextWidgetReference DeviceHackNamesText3
		{
			get => GetProperty(ref _deviceHackNamesText3);
			set => SetProperty(ref _deviceHackNamesText3, value);
		}

		[Ordinal(35)] 
		[RED("textBG3")] 
		public inkWidgetReference TextBG3
		{
			get => GetProperty(ref _textBG3);
			set => SetProperty(ref _textBG3, value);
		}

		[Ordinal(36)] 
		[RED("namesTextContainer4")] 
		public inkWidgetReference NamesTextContainer4
		{
			get => GetProperty(ref _namesTextContainer4);
			set => SetProperty(ref _namesTextContainer4, value);
		}

		[Ordinal(37)] 
		[RED("deviceHackNamesText4")] 
		public inkTextWidgetReference DeviceHackNamesText4
		{
			get => GetProperty(ref _deviceHackNamesText4);
			set => SetProperty(ref _deviceHackNamesText4, value);
		}

		[Ordinal(38)] 
		[RED("textBG4")] 
		public inkWidgetReference TextBG4
		{
			get => GetProperty(ref _textBG4);
			set => SetProperty(ref _textBG4, value);
		}

		[Ordinal(39)] 
		[RED("itemIconImage")] 
		public inkImageWidgetReference ItemIconImage
		{
			get => GetProperty(ref _itemIconImage);
			set => SetProperty(ref _itemIconImage, value);
		}

		[Ordinal(40)] 
		[RED("itemAttributeRequirementsWrapper")] 
		public inkWidgetReference ItemAttributeRequirementsWrapper
		{
			get => GetProperty(ref _itemAttributeRequirementsWrapper);
			set => SetProperty(ref _itemAttributeRequirementsWrapper, value);
		}

		[Ordinal(41)] 
		[RED("itemAttributeRequirements")] 
		public inkWidgetReference ItemAttributeRequirements
		{
			get => GetProperty(ref _itemAttributeRequirements);
			set => SetProperty(ref _itemAttributeRequirements, value);
		}

		[Ordinal(42)] 
		[RED("itemAttributeRequirementsText")] 
		public inkTextWidgetReference ItemAttributeRequirementsText
		{
			get => GetProperty(ref _itemAttributeRequirementsText);
			set => SetProperty(ref _itemAttributeRequirementsText, value);
		}

		[Ordinal(43)] 
		[RED("allocationCostsWrapper")] 
		public inkCompoundWidgetReference AllocationCostsWrapper
		{
			get => GetProperty(ref _allocationCostsWrapper);
			set => SetProperty(ref _allocationCostsWrapper, value);
		}

		[Ordinal(44)] 
		[RED("iconicLines")] 
		public inkImageWidgetReference IconicLines
		{
			get => GetProperty(ref _iconicLines);
			set => SetProperty(ref _iconicLines, value);
		}

		[Ordinal(45)] 
		[RED("equipedCorner")] 
		public inkWidgetReference EquipedCorner
		{
			get => GetProperty(ref _equipedCorner);
			set => SetProperty(ref _equipedCorner, value);
		}

		[Ordinal(46)] 
		[RED("root")] 
		public inkWidgetReference Root_1072
		{
			get => GetProperty(ref _root_1072);
			set => SetProperty(ref _root_1072, value);
		}

		[Ordinal(47)] 
		[RED("iconicBG")] 
		public inkWidgetReference IconicBG
		{
			get => GetProperty(ref _iconicBG);
			set => SetProperty(ref _iconicBG, value);
		}

		[Ordinal(48)] 
		[RED("recipeWrapper")] 
		public inkWidgetReference RecipeWrapper
		{
			get => GetProperty(ref _recipeWrapper);
			set => SetProperty(ref _recipeWrapper, value);
		}

		[Ordinal(49)] 
		[RED("recipeBG")] 
		public inkWidgetReference RecipeBG
		{
			get => GetProperty(ref _recipeBG);
			set => SetProperty(ref _recipeBG, value);
		}

		[Ordinal(50)] 
		[RED("illegalBG")] 
		public inkWidgetReference IllegalBG
		{
			get => GetProperty(ref _illegalBG);
			set => SetProperty(ref _illegalBG, value);
		}

		[Ordinal(51)] 
		[RED("cyberwareUpgradeContainer")] 
		public inkWidgetReference CyberwareUpgradeContainer
		{
			get => GetProperty(ref _cyberwareUpgradeContainer);
			set => SetProperty(ref _cyberwareUpgradeContainer, value);
		}

		[Ordinal(52)] 
		[RED("itemCWQuickHackMenuLinkContainer")] 
		public inkWidgetReference ItemCWQuickHackMenuLinkContainer
		{
			get => GetProperty(ref _itemCWQuickHackMenuLinkContainer);
			set => SetProperty(ref _itemCWQuickHackMenuLinkContainer, value);
		}

		[Ordinal(53)] 
		[RED("additionalModulesLibraryRes")] 
		public redResourceReferenceScriptToken AdditionalModulesLibraryRes
		{
			get => GetProperty(ref _additionalModulesLibraryRes);
			set => SetProperty(ref _additionalModulesLibraryRes, value);
		}

		[Ordinal(54)] 
		[RED("cyberwareUpgradeModuleName")] 
		public CName CyberwareUpgradeModuleName
		{
			get => GetProperty(ref _cyberwareUpgradeModuleName);
			set => SetProperty(ref _cyberwareUpgradeModuleName, value);
		}

		[Ordinal(55)] 
		[RED("rarityBarsController")] 
		public wCHandle<LevelBarsController> RarityBarsController
		{
			get => GetProperty(ref _rarityBarsController);
			set => SetProperty(ref _rarityBarsController, value);
		}

		[Ordinal(56)] 
		[RED("data")] 
		public CHandle<InventoryTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(57)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(58)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(59)] 
		[RED("cyberwareUpgradeController")] 
		public wCHandle<ItemTooltipCyberwareUpgradeController> CyberwareUpgradeController
		{
			get => GetProperty(ref _cyberwareUpgradeController);
			set => SetProperty(ref _cyberwareUpgradeController, value);
		}

		[Ordinal(60)] 
		[RED("hasVehiclePerk")] 
		public CBool HasVehiclePerk
		{
			get => GetProperty(ref _hasVehiclePerk);
			set => SetProperty(ref _hasVehiclePerk, value);
		}

		[Ordinal(61)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(62)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(63)] 
		[RED("settingsListener")] 
		public CHandle<CyberdeckTooltipSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(64)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(65)] 
		[RED("minWidth")] 
		public inkWidgetReference MinWidth
		{
			get => GetProperty(ref _minWidth);
			set => SetProperty(ref _minWidth, value);
		}

		[Ordinal(66)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(67)] 
		[RED("itemData")] 
		public wCHandle<UIInventoryItem> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(68)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(69)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetProperty(ref _comparisonData);
			set => SetProperty(ref _comparisonData, value);
		}

		[Ordinal(70)] 
		[RED("tooltipDisplayContext")] 
		public CEnum<InventoryTooltipDisplayContext> TooltipDisplayContext
		{
			get => GetProperty(ref _tooltipDisplayContext);
			set => SetProperty(ref _tooltipDisplayContext, value);
		}

		public CyberdeckTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
