using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipCommonController : AGenericTooltipControllerWithDebug
	{
		private inkWidgetReference _backgroundContainer;
		private inkWidgetReference _itemEquippedContainer;
		private inkWidgetReference _itemRecipeContainer;
		private inkWidgetReference _itemHeaderContainer;
		private inkWidgetReference _itemIconContainer;
		private inkWidgetReference _itemWeaponInfoContainer;
		private inkWidgetReference _itemClothingInfoContainer;
		private inkWidgetReference _itemGrenadeInfoContainer;
		private inkWidgetReference _itemCyberwareContainer;
		private inkWidgetReference _itemRequirementsContainer;
		private inkWidgetReference _itemDetailsContainer;
		private inkWidgetReference _itemRecipeDataContainer;
		private inkWidgetReference _itemEvolutionContainer;
		private inkWidgetReference _itemCraftedContainer;
		private inkWidgetReference _itemActionContainer;
		private inkWidgetReference _itemBottomContainer;
		private inkWidgetReference _itemCWUpgradeContainer;
		private inkWidgetReference _itemCWQuickHackMenuLinkContainer;
		private inkWidgetReference _contentWrapper;
		private inkWidgetReference _cornerContainer;
		private inkWidgetReference _root_504;
		private inkWidgetReference _iconicBG;
		private inkWidgetReference _recipeBG;
		private inkWidgetReference _illegalBG;
		private inkWidgetReference _descriptionWrapper;
		private inkTextWidgetReference _descriptionText;
		private CName _cyberwareUpgradeModuleName;
		private CName _cyberwareQuickHackMenuLinkName;
		private redResourceReferenceScriptToken _cyberwareModulesLibraryRes;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CArray<wCHandle<ItemTooltipModuleController>> _spawnedModules;
		private wCHandle<ItemTooltipEquippedModule> _itemEquippedController;
		private wCHandle<ItemTooltipRepiceModule> _itemRecipeController;
		private wCHandle<ItemTooltipHeaderController> _itemHeaderController;
		private wCHandle<ItemTooltipIconModule> _itemIconController;
		private wCHandle<ItemTooltipWeaponInfoModule> _itemWeaponInfoController;
		private wCHandle<ItemTooltipClothingInfoModule> _itemClothingInfoController;
		private wCHandle<ItemTooltipGrenadeInfoModule> _itemGrenadeInfoController;
		private wCHandle<ItemTooltipCyberwareWeaponModule> _itemCyberwareController;
		private wCHandle<ItemTooltipRequirementsModule> _itemRequirementsController;
		private wCHandle<ItemTooltipDetailsModule> _itemDetailsController;
		private wCHandle<ItemTooltipRecipeDataModule> _itemRecipeDataController;
		private wCHandle<ItemTooltipEvolutionModule> _itemEvolutionController;
		private wCHandle<ItemTooltipCraftedModule> _itemCraftedController;
		private wCHandle<ItemTooltipCyberwareUpgradeController> _itemCWUpgradeController;
		private wCHandle<ItemTooltipBottomModule> _itemBottomController;
		private CBool _dEBUG_showAdditionalInfo;
		private CHandle<MinimalItemTooltipData> _data;
		private CHandle<InventoryTooltipData> _inventoryTooltipData;
		private CHandle<UIInventoryItem> _itemData;
		private CHandle<UIInventoryItemComparisonManager> _comparisonData;
		private wCHandle<PlayerPuppet> _player;
		private CArray<CName> _requestedModules;
		private CArray<CName> _pendingModules;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CEnum<InventoryTooltipDisplayContext> _tooltipDisplayContext;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;
		private CInt32 _priceOverride;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<ItemTooltipSettingsListener> _settingsListener;
		private CName _groupPath;
		private inkWidgetReference _minWidth;
		private CBool _bigFontEnabled;
		private CBool _inCrafting;

		[Ordinal(5)] 
		[RED("backgroundContainer")] 
		public inkWidgetReference BackgroundContainer
		{
			get => GetProperty(ref _backgroundContainer);
			set => SetProperty(ref _backgroundContainer, value);
		}

		[Ordinal(6)] 
		[RED("itemEquippedContainer")] 
		public inkWidgetReference ItemEquippedContainer
		{
			get => GetProperty(ref _itemEquippedContainer);
			set => SetProperty(ref _itemEquippedContainer, value);
		}

		[Ordinal(7)] 
		[RED("itemRecipeContainer")] 
		public inkWidgetReference ItemRecipeContainer
		{
			get => GetProperty(ref _itemRecipeContainer);
			set => SetProperty(ref _itemRecipeContainer, value);
		}

		[Ordinal(8)] 
		[RED("itemHeaderContainer")] 
		public inkWidgetReference ItemHeaderContainer
		{
			get => GetProperty(ref _itemHeaderContainer);
			set => SetProperty(ref _itemHeaderContainer, value);
		}

		[Ordinal(9)] 
		[RED("itemIconContainer")] 
		public inkWidgetReference ItemIconContainer
		{
			get => GetProperty(ref _itemIconContainer);
			set => SetProperty(ref _itemIconContainer, value);
		}

		[Ordinal(10)] 
		[RED("itemWeaponInfoContainer")] 
		public inkWidgetReference ItemWeaponInfoContainer
		{
			get => GetProperty(ref _itemWeaponInfoContainer);
			set => SetProperty(ref _itemWeaponInfoContainer, value);
		}

		[Ordinal(11)] 
		[RED("itemClothingInfoContainer")] 
		public inkWidgetReference ItemClothingInfoContainer
		{
			get => GetProperty(ref _itemClothingInfoContainer);
			set => SetProperty(ref _itemClothingInfoContainer, value);
		}

		[Ordinal(12)] 
		[RED("itemGrenadeInfoContainer")] 
		public inkWidgetReference ItemGrenadeInfoContainer
		{
			get => GetProperty(ref _itemGrenadeInfoContainer);
			set => SetProperty(ref _itemGrenadeInfoContainer, value);
		}

		[Ordinal(13)] 
		[RED("itemCyberwareContainer")] 
		public inkWidgetReference ItemCyberwareContainer
		{
			get => GetProperty(ref _itemCyberwareContainer);
			set => SetProperty(ref _itemCyberwareContainer, value);
		}

		[Ordinal(14)] 
		[RED("itemRequirementsContainer")] 
		public inkWidgetReference ItemRequirementsContainer
		{
			get => GetProperty(ref _itemRequirementsContainer);
			set => SetProperty(ref _itemRequirementsContainer, value);
		}

		[Ordinal(15)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetProperty(ref _itemDetailsContainer);
			set => SetProperty(ref _itemDetailsContainer, value);
		}

		[Ordinal(16)] 
		[RED("itemRecipeDataContainer")] 
		public inkWidgetReference ItemRecipeDataContainer
		{
			get => GetProperty(ref _itemRecipeDataContainer);
			set => SetProperty(ref _itemRecipeDataContainer, value);
		}

		[Ordinal(17)] 
		[RED("itemEvolutionContainer")] 
		public inkWidgetReference ItemEvolutionContainer
		{
			get => GetProperty(ref _itemEvolutionContainer);
			set => SetProperty(ref _itemEvolutionContainer, value);
		}

		[Ordinal(18)] 
		[RED("itemCraftedContainer")] 
		public inkWidgetReference ItemCraftedContainer
		{
			get => GetProperty(ref _itemCraftedContainer);
			set => SetProperty(ref _itemCraftedContainer, value);
		}

		[Ordinal(19)] 
		[RED("itemActionContainer")] 
		public inkWidgetReference ItemActionContainer
		{
			get => GetProperty(ref _itemActionContainer);
			set => SetProperty(ref _itemActionContainer, value);
		}

		[Ordinal(20)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get => GetProperty(ref _itemBottomContainer);
			set => SetProperty(ref _itemBottomContainer, value);
		}

		[Ordinal(21)] 
		[RED("itemCWUpgradeContainer")] 
		public inkWidgetReference ItemCWUpgradeContainer
		{
			get => GetProperty(ref _itemCWUpgradeContainer);
			set => SetProperty(ref _itemCWUpgradeContainer, value);
		}

		[Ordinal(22)] 
		[RED("itemCWQuickHackMenuLinkContainer")] 
		public inkWidgetReference ItemCWQuickHackMenuLinkContainer
		{
			get => GetProperty(ref _itemCWQuickHackMenuLinkContainer);
			set => SetProperty(ref _itemCWQuickHackMenuLinkContainer, value);
		}

		[Ordinal(23)] 
		[RED("contentWrapper")] 
		public inkWidgetReference ContentWrapper
		{
			get => GetProperty(ref _contentWrapper);
			set => SetProperty(ref _contentWrapper, value);
		}

		[Ordinal(24)] 
		[RED("cornerContainer")] 
		public inkWidgetReference CornerContainer
		{
			get => GetProperty(ref _cornerContainer);
			set => SetProperty(ref _cornerContainer, value);
		}

		[Ordinal(25)] 
		[RED("root")] 
		public inkWidgetReference Root_504
		{
			get => GetProperty(ref _root_504);
			set => SetProperty(ref _root_504, value);
		}

		[Ordinal(26)] 
		[RED("iconicBG")] 
		public inkWidgetReference IconicBG
		{
			get => GetProperty(ref _iconicBG);
			set => SetProperty(ref _iconicBG, value);
		}

		[Ordinal(27)] 
		[RED("recipeBG")] 
		public inkWidgetReference RecipeBG
		{
			get => GetProperty(ref _recipeBG);
			set => SetProperty(ref _recipeBG, value);
		}

		[Ordinal(28)] 
		[RED("illegalBG")] 
		public inkWidgetReference IllegalBG
		{
			get => GetProperty(ref _illegalBG);
			set => SetProperty(ref _illegalBG, value);
		}

		[Ordinal(29)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(30)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(31)] 
		[RED("cyberwareUpgradeModuleName")] 
		public CName CyberwareUpgradeModuleName
		{
			get => GetProperty(ref _cyberwareUpgradeModuleName);
			set => SetProperty(ref _cyberwareUpgradeModuleName, value);
		}

		[Ordinal(32)] 
		[RED("cyberwareQuickHackMenuLinkName")] 
		public CName CyberwareQuickHackMenuLinkName
		{
			get => GetProperty(ref _cyberwareQuickHackMenuLinkName);
			set => SetProperty(ref _cyberwareQuickHackMenuLinkName, value);
		}

		[Ordinal(33)] 
		[RED("cyberwareModulesLibraryRes")] 
		public redResourceReferenceScriptToken CyberwareModulesLibraryRes
		{
			get => GetProperty(ref _cyberwareModulesLibraryRes);
			set => SetProperty(ref _cyberwareModulesLibraryRes, value);
		}

		[Ordinal(34)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(35)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(36)] 
		[RED("spawnedModules")] 
		public CArray<wCHandle<ItemTooltipModuleController>> SpawnedModules
		{
			get => GetProperty(ref _spawnedModules);
			set => SetProperty(ref _spawnedModules, value);
		}

		[Ordinal(37)] 
		[RED("itemEquippedController")] 
		public wCHandle<ItemTooltipEquippedModule> ItemEquippedController
		{
			get => GetProperty(ref _itemEquippedController);
			set => SetProperty(ref _itemEquippedController, value);
		}

		[Ordinal(38)] 
		[RED("itemRecipeController")] 
		public wCHandle<ItemTooltipRepiceModule> ItemRecipeController
		{
			get => GetProperty(ref _itemRecipeController);
			set => SetProperty(ref _itemRecipeController, value);
		}

		[Ordinal(39)] 
		[RED("itemHeaderController")] 
		public wCHandle<ItemTooltipHeaderController> ItemHeaderController
		{
			get => GetProperty(ref _itemHeaderController);
			set => SetProperty(ref _itemHeaderController, value);
		}

		[Ordinal(40)] 
		[RED("itemIconController")] 
		public wCHandle<ItemTooltipIconModule> ItemIconController
		{
			get => GetProperty(ref _itemIconController);
			set => SetProperty(ref _itemIconController, value);
		}

		[Ordinal(41)] 
		[RED("itemWeaponInfoController")] 
		public wCHandle<ItemTooltipWeaponInfoModule> ItemWeaponInfoController
		{
			get => GetProperty(ref _itemWeaponInfoController);
			set => SetProperty(ref _itemWeaponInfoController, value);
		}

		[Ordinal(42)] 
		[RED("itemClothingInfoController")] 
		public wCHandle<ItemTooltipClothingInfoModule> ItemClothingInfoController
		{
			get => GetProperty(ref _itemClothingInfoController);
			set => SetProperty(ref _itemClothingInfoController, value);
		}

		[Ordinal(43)] 
		[RED("itemGrenadeInfoController")] 
		public wCHandle<ItemTooltipGrenadeInfoModule> ItemGrenadeInfoController
		{
			get => GetProperty(ref _itemGrenadeInfoController);
			set => SetProperty(ref _itemGrenadeInfoController, value);
		}

		[Ordinal(44)] 
		[RED("itemCyberwareController")] 
		public wCHandle<ItemTooltipCyberwareWeaponModule> ItemCyberwareController
		{
			get => GetProperty(ref _itemCyberwareController);
			set => SetProperty(ref _itemCyberwareController, value);
		}

		[Ordinal(45)] 
		[RED("itemRequirementsController")] 
		public wCHandle<ItemTooltipRequirementsModule> ItemRequirementsController
		{
			get => GetProperty(ref _itemRequirementsController);
			set => SetProperty(ref _itemRequirementsController, value);
		}

		[Ordinal(46)] 
		[RED("itemDetailsController")] 
		public wCHandle<ItemTooltipDetailsModule> ItemDetailsController
		{
			get => GetProperty(ref _itemDetailsController);
			set => SetProperty(ref _itemDetailsController, value);
		}

		[Ordinal(47)] 
		[RED("itemRecipeDataController")] 
		public wCHandle<ItemTooltipRecipeDataModule> ItemRecipeDataController
		{
			get => GetProperty(ref _itemRecipeDataController);
			set => SetProperty(ref _itemRecipeDataController, value);
		}

		[Ordinal(48)] 
		[RED("itemEvolutionController")] 
		public wCHandle<ItemTooltipEvolutionModule> ItemEvolutionController
		{
			get => GetProperty(ref _itemEvolutionController);
			set => SetProperty(ref _itemEvolutionController, value);
		}

		[Ordinal(49)] 
		[RED("itemCraftedController")] 
		public wCHandle<ItemTooltipCraftedModule> ItemCraftedController
		{
			get => GetProperty(ref _itemCraftedController);
			set => SetProperty(ref _itemCraftedController, value);
		}

		[Ordinal(50)] 
		[RED("itemCWUpgradeController")] 
		public wCHandle<ItemTooltipCyberwareUpgradeController> ItemCWUpgradeController
		{
			get => GetProperty(ref _itemCWUpgradeController);
			set => SetProperty(ref _itemCWUpgradeController, value);
		}

		[Ordinal(51)] 
		[RED("itemBottomController")] 
		public wCHandle<ItemTooltipBottomModule> ItemBottomController
		{
			get => GetProperty(ref _itemBottomController);
			set => SetProperty(ref _itemBottomController, value);
		}

		[Ordinal(52)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetProperty(ref _dEBUG_showAdditionalInfo);
			set => SetProperty(ref _dEBUG_showAdditionalInfo, value);
		}

		[Ordinal(53)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(54)] 
		[RED("inventoryTooltipData")] 
		public CHandle<InventoryTooltipData> InventoryTooltipData
		{
			get => GetProperty(ref _inventoryTooltipData);
			set => SetProperty(ref _inventoryTooltipData, value);
		}

		[Ordinal(55)] 
		[RED("itemData")] 
		public CHandle<UIInventoryItem> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(56)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetProperty(ref _comparisonData);
			set => SetProperty(ref _comparisonData, value);
		}

		[Ordinal(57)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(58)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get => GetProperty(ref _requestedModules);
			set => SetProperty(ref _requestedModules, value);
		}

		[Ordinal(59)] 
		[RED("pendingModules")] 
		public CArray<CName> PendingModules
		{
			get => GetProperty(ref _pendingModules);
			set => SetProperty(ref _pendingModules, value);
		}

		[Ordinal(60)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(61)] 
		[RED("tooltipDisplayContext")] 
		public CEnum<InventoryTooltipDisplayContext> TooltipDisplayContext
		{
			get => GetProperty(ref _tooltipDisplayContext);
			set => SetProperty(ref _tooltipDisplayContext, value);
		}

		[Ordinal(62)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(63)] 
		[RED("priceOverride")] 
		public CInt32 PriceOverride
		{
			get => GetProperty(ref _priceOverride);
			set => SetProperty(ref _priceOverride, value);
		}

		[Ordinal(64)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(65)] 
		[RED("settingsListener")] 
		public CHandle<ItemTooltipSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(66)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(67)] 
		[RED("minWidth")] 
		public inkWidgetReference MinWidth
		{
			get => GetProperty(ref _minWidth);
			set => SetProperty(ref _minWidth, value);
		}

		[Ordinal(68)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(69)] 
		[RED("inCrafting")] 
		public CBool InCrafting
		{
			get => GetProperty(ref _inCrafting);
			set => SetProperty(ref _inCrafting, value);
		}

		public ItemTooltipCommonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
