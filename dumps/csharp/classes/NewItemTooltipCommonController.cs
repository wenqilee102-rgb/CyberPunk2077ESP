using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipCommonController : AGenericTooltipControllerWithDebug
	{
		private inkWidgetReference _backgroundContainer;
		private inkWidgetReference _itemEquippedContainer;
		private inkWidgetReference _itemRecipeContainer;
		private inkWidgetReference _itemHeaderContainer;
		private inkWidgetReference _itemBrokenContainer;
		private inkWidgetReference _itemWeaponBarsContainer;
		private inkWidgetReference _itemRequirementsContainer;
		private inkWidgetReference _itemDetailsStatsContainer;
		private inkWidgetReference _itemDescriptionContainer;
		private inkWidgetReference _itemDetailsContainer;
		private inkWidgetReference _itemBottomContainer;
		private inkWidgetReference _cornerContainer;
		private inkWidgetReference _root_312;
		private inkWidgetReference _iconicBG;
		private inkWidgetReference _recipeBG;
		private inkWidgetReference _illegalBG;
		private inkWidgetReference _descriptionWrapper;
		private inkTextWidgetReference _descriptionText;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CArray<inkWidgetReference> _frames;
		private CArray<wCHandle<NewItemTooltipModuleController>> _spawnedModules;
		private wCHandle<NewItemTooltipEquippedModule> _itemEquippedController;
		private wCHandle<NewItemTooltipRepiceModule> _itemRecipeController;
		private wCHandle<NewItemTooltipHeaderController> _itemHeaderController;
		private wCHandle<NewItemTooltipBrokenModule> _itemBrokenController;
		private wCHandle<NewItemTooltipWeaponBarsModule> _itemWeaponBarsController;
		private wCHandle<NewItemTooltipRequirementsModule> _itemRequirementsController;
		private wCHandle<NewItemTooltipDetailsStatsModule> _itemDetailsStatsController;
		private wCHandle<NewItemTooltipDescriptionModule> _itemDescriptionController;
		private wCHandle<NewItemTooltipDetailsModule> _itemDetailsController;
		private wCHandle<NewItemTooltipBottomModule> _itemBottomController;
		private CBool _dEBUG_showAdditionalInfo;
		private CHandle<MinimalItemTooltipData> _data;
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
		private CHandle<NewItemTooltipSettingsListener> _settingsListener;
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
		[RED("itemBrokenContainer")] 
		public inkWidgetReference ItemBrokenContainer
		{
			get => GetProperty(ref _itemBrokenContainer);
			set => SetProperty(ref _itemBrokenContainer, value);
		}

		[Ordinal(10)] 
		[RED("itemWeaponBarsContainer")] 
		public inkWidgetReference ItemWeaponBarsContainer
		{
			get => GetProperty(ref _itemWeaponBarsContainer);
			set => SetProperty(ref _itemWeaponBarsContainer, value);
		}

		[Ordinal(11)] 
		[RED("itemRequirementsContainer")] 
		public inkWidgetReference ItemRequirementsContainer
		{
			get => GetProperty(ref _itemRequirementsContainer);
			set => SetProperty(ref _itemRequirementsContainer, value);
		}

		[Ordinal(12)] 
		[RED("itemDetailsStatsContainer")] 
		public inkWidgetReference ItemDetailsStatsContainer
		{
			get => GetProperty(ref _itemDetailsStatsContainer);
			set => SetProperty(ref _itemDetailsStatsContainer, value);
		}

		[Ordinal(13)] 
		[RED("itemDescriptionContainer")] 
		public inkWidgetReference ItemDescriptionContainer
		{
			get => GetProperty(ref _itemDescriptionContainer);
			set => SetProperty(ref _itemDescriptionContainer, value);
		}

		[Ordinal(14)] 
		[RED("itemDetailsContainer")] 
		public inkWidgetReference ItemDetailsContainer
		{
			get => GetProperty(ref _itemDetailsContainer);
			set => SetProperty(ref _itemDetailsContainer, value);
		}

		[Ordinal(15)] 
		[RED("itemBottomContainer")] 
		public inkWidgetReference ItemBottomContainer
		{
			get => GetProperty(ref _itemBottomContainer);
			set => SetProperty(ref _itemBottomContainer, value);
		}

		[Ordinal(16)] 
		[RED("cornerContainer")] 
		public inkWidgetReference CornerContainer
		{
			get => GetProperty(ref _cornerContainer);
			set => SetProperty(ref _cornerContainer, value);
		}

		[Ordinal(17)] 
		[RED("root")] 
		public inkWidgetReference Root_312
		{
			get => GetProperty(ref _root_312);
			set => SetProperty(ref _root_312, value);
		}

		[Ordinal(18)] 
		[RED("iconicBG")] 
		public inkWidgetReference IconicBG
		{
			get => GetProperty(ref _iconicBG);
			set => SetProperty(ref _iconicBG, value);
		}

		[Ordinal(19)] 
		[RED("recipeBG")] 
		public inkWidgetReference RecipeBG
		{
			get => GetProperty(ref _recipeBG);
			set => SetProperty(ref _recipeBG, value);
		}

		[Ordinal(20)] 
		[RED("illegalBG")] 
		public inkWidgetReference IllegalBG
		{
			get => GetProperty(ref _illegalBG);
			set => SetProperty(ref _illegalBG, value);
		}

		[Ordinal(21)] 
		[RED("descriptionWrapper")] 
		public inkWidgetReference DescriptionWrapper
		{
			get => GetProperty(ref _descriptionWrapper);
			set => SetProperty(ref _descriptionWrapper, value);
		}

		[Ordinal(22)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(23)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(24)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(25)] 
		[RED("frames")] 
		public CArray<inkWidgetReference> Frames
		{
			get => GetProperty(ref _frames);
			set => SetProperty(ref _frames, value);
		}

		[Ordinal(26)] 
		[RED("spawnedModules")] 
		public CArray<wCHandle<NewItemTooltipModuleController>> SpawnedModules
		{
			get => GetProperty(ref _spawnedModules);
			set => SetProperty(ref _spawnedModules, value);
		}

		[Ordinal(27)] 
		[RED("itemEquippedController")] 
		public wCHandle<NewItemTooltipEquippedModule> ItemEquippedController
		{
			get => GetProperty(ref _itemEquippedController);
			set => SetProperty(ref _itemEquippedController, value);
		}

		[Ordinal(28)] 
		[RED("itemRecipeController")] 
		public wCHandle<NewItemTooltipRepiceModule> ItemRecipeController
		{
			get => GetProperty(ref _itemRecipeController);
			set => SetProperty(ref _itemRecipeController, value);
		}

		[Ordinal(29)] 
		[RED("itemHeaderController")] 
		public wCHandle<NewItemTooltipHeaderController> ItemHeaderController
		{
			get => GetProperty(ref _itemHeaderController);
			set => SetProperty(ref _itemHeaderController, value);
		}

		[Ordinal(30)] 
		[RED("itemBrokenController")] 
		public wCHandle<NewItemTooltipBrokenModule> ItemBrokenController
		{
			get => GetProperty(ref _itemBrokenController);
			set => SetProperty(ref _itemBrokenController, value);
		}

		[Ordinal(31)] 
		[RED("itemWeaponBarsController")] 
		public wCHandle<NewItemTooltipWeaponBarsModule> ItemWeaponBarsController
		{
			get => GetProperty(ref _itemWeaponBarsController);
			set => SetProperty(ref _itemWeaponBarsController, value);
		}

		[Ordinal(32)] 
		[RED("itemRequirementsController")] 
		public wCHandle<NewItemTooltipRequirementsModule> ItemRequirementsController
		{
			get => GetProperty(ref _itemRequirementsController);
			set => SetProperty(ref _itemRequirementsController, value);
		}

		[Ordinal(33)] 
		[RED("itemDetailsStatsController")] 
		public wCHandle<NewItemTooltipDetailsStatsModule> ItemDetailsStatsController
		{
			get => GetProperty(ref _itemDetailsStatsController);
			set => SetProperty(ref _itemDetailsStatsController, value);
		}

		[Ordinal(34)] 
		[RED("itemDescriptionController")] 
		public wCHandle<NewItemTooltipDescriptionModule> ItemDescriptionController
		{
			get => GetProperty(ref _itemDescriptionController);
			set => SetProperty(ref _itemDescriptionController, value);
		}

		[Ordinal(35)] 
		[RED("itemDetailsController")] 
		public wCHandle<NewItemTooltipDetailsModule> ItemDetailsController
		{
			get => GetProperty(ref _itemDetailsController);
			set => SetProperty(ref _itemDetailsController, value);
		}

		[Ordinal(36)] 
		[RED("itemBottomController")] 
		public wCHandle<NewItemTooltipBottomModule> ItemBottomController
		{
			get => GetProperty(ref _itemBottomController);
			set => SetProperty(ref _itemBottomController, value);
		}

		[Ordinal(37)] 
		[RED("DEBUG_showAdditionalInfo")] 
		public CBool DEBUG_showAdditionalInfo
		{
			get => GetProperty(ref _dEBUG_showAdditionalInfo);
			set => SetProperty(ref _dEBUG_showAdditionalInfo, value);
		}

		[Ordinal(38)] 
		[RED("data")] 
		public CHandle<MinimalItemTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(39)] 
		[RED("itemData")] 
		public CHandle<UIInventoryItem> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(40)] 
		[RED("comparisonData")] 
		public CHandle<UIInventoryItemComparisonManager> ComparisonData
		{
			get => GetProperty(ref _comparisonData);
			set => SetProperty(ref _comparisonData, value);
		}

		[Ordinal(41)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(42)] 
		[RED("requestedModules")] 
		public CArray<CName> RequestedModules
		{
			get => GetProperty(ref _requestedModules);
			set => SetProperty(ref _requestedModules, value);
		}

		[Ordinal(43)] 
		[RED("pendingModules")] 
		public CArray<CName> PendingModules
		{
			get => GetProperty(ref _pendingModules);
			set => SetProperty(ref _pendingModules, value);
		}

		[Ordinal(44)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(45)] 
		[RED("tooltipDisplayContext")] 
		public CEnum<InventoryTooltipDisplayContext> TooltipDisplayContext
		{
			get => GetProperty(ref _tooltipDisplayContext);
			set => SetProperty(ref _tooltipDisplayContext, value);
		}

		[Ordinal(46)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		[Ordinal(47)] 
		[RED("priceOverride")] 
		public CInt32 PriceOverride
		{
			get => GetProperty(ref _priceOverride);
			set => SetProperty(ref _priceOverride, value);
		}

		[Ordinal(48)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(49)] 
		[RED("settingsListener")] 
		public CHandle<NewItemTooltipSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(50)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(51)] 
		[RED("minWidth")] 
		public inkWidgetReference MinWidth
		{
			get => GetProperty(ref _minWidth);
			set => SetProperty(ref _minWidth, value);
		}

		[Ordinal(52)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(53)] 
		[RED("inCrafting")] 
		public CBool InCrafting
		{
			get => GetProperty(ref _inCrafting);
			set => SetProperty(ref _inCrafting, value);
		}

		public NewItemTooltipCommonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
