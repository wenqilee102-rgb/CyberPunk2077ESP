using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayTooltipController : AGenericTooltipControllerWithDebug
	{
		private inkWidgetReference _root_24;
		private inkTextWidgetReference _perkNameText;
		private inkWidgetReference _videoWrapper;
		private inkVideoWidgetReference _videoWidget;
		private inkTextWidgetReference _unlockStateText;
		private inkTextWidgetReference _perkTypeText;
		private inkWidgetReference _perkTypeWrapper;
		private inkWidgetReference _unlockInfoWrapper;
		private inkTextWidgetReference _unlockPointsText;
		private inkTextWidgetReference _unlockPointsDesc;
		private inkWidgetReference _unlockPerkWrapper;
		private inkTextWidgetReference _levelText;
		private inkTextWidgetReference _levelDescriptionText;
		private inkWidgetReference _nextLevelWrapper;
		private inkTextWidgetReference _nextLevelText;
		private inkTextWidgetReference _nextLevelDescriptionText;
		private inkWidgetReference _level1Wrapper;
		private CArray<PerkTooltipDescriptionEntry> _levelsDescriptions;
		private inkWidgetReference _relatedWeaponTypeWrapper;
		private inkImageWidgetReference _relatedWeaponTypeIcon;
		private inkTextWidgetReference _relatedWeaponTypeText;
		private inkTextWidgetReference _traitLevelGrowthText;
		private inkTextWidgetReference _unlockTraitPointsText;
		private inkWidgetReference _unlockTraitWrapper;
		private inkWidgetReference _inputHints;
		private inkWidgetReference _buyHint;
		private inkWidgetReference _sellHint;
		private inkWidgetReference _relicCost;
		private inkTextWidgetReference _costText;
		private inkImageWidgetReference _costImage;
		private inkWidgetReference _perkLevelWrapper;
		private inkTextWidgetReference _perkLevelCurrent;
		private inkTextWidgetReference _perkLevelMax;
		private inkWidgetReference _cornerContainer;
		private inkWidgetReference _cyberwareDetailsInfo;
		private inkWidgetReference _dEBUG_iconErrorWrapper;
		private inkTextWidgetReference _dEBUG_iconErrorText;
		private CHandle<BasePerksMenuTooltipData> _data;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<PerkDisplayTooltipSettingsListener> _settingsListener;
		private CName _groupPath;
		private inkWidgetReference _tooltipWrapper;
		private inkWidgetReference _horizontalSizer;
		private CBool _bigFontEnabled;

		[Ordinal(5)] 
		[RED("root")] 
		public inkWidgetReference Root_24
		{
			get => GetProperty(ref _root_24);
			set => SetProperty(ref _root_24, value);
		}

		[Ordinal(6)] 
		[RED("perkNameText")] 
		public inkTextWidgetReference PerkNameText
		{
			get => GetProperty(ref _perkNameText);
			set => SetProperty(ref _perkNameText, value);
		}

		[Ordinal(7)] 
		[RED("videoWrapper")] 
		public inkWidgetReference VideoWrapper
		{
			get => GetProperty(ref _videoWrapper);
			set => SetProperty(ref _videoWrapper, value);
		}

		[Ordinal(8)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(9)] 
		[RED("unlockStateText")] 
		public inkTextWidgetReference UnlockStateText
		{
			get => GetProperty(ref _unlockStateText);
			set => SetProperty(ref _unlockStateText, value);
		}

		[Ordinal(10)] 
		[RED("perkTypeText")] 
		public inkTextWidgetReference PerkTypeText
		{
			get => GetProperty(ref _perkTypeText);
			set => SetProperty(ref _perkTypeText, value);
		}

		[Ordinal(11)] 
		[RED("perkTypeWrapper")] 
		public inkWidgetReference PerkTypeWrapper
		{
			get => GetProperty(ref _perkTypeWrapper);
			set => SetProperty(ref _perkTypeWrapper, value);
		}

		[Ordinal(12)] 
		[RED("unlockInfoWrapper")] 
		public inkWidgetReference UnlockInfoWrapper
		{
			get => GetProperty(ref _unlockInfoWrapper);
			set => SetProperty(ref _unlockInfoWrapper, value);
		}

		[Ordinal(13)] 
		[RED("unlockPointsText")] 
		public inkTextWidgetReference UnlockPointsText
		{
			get => GetProperty(ref _unlockPointsText);
			set => SetProperty(ref _unlockPointsText, value);
		}

		[Ordinal(14)] 
		[RED("unlockPointsDesc")] 
		public inkTextWidgetReference UnlockPointsDesc
		{
			get => GetProperty(ref _unlockPointsDesc);
			set => SetProperty(ref _unlockPointsDesc, value);
		}

		[Ordinal(15)] 
		[RED("unlockPerkWrapper")] 
		public inkWidgetReference UnlockPerkWrapper
		{
			get => GetProperty(ref _unlockPerkWrapper);
			set => SetProperty(ref _unlockPerkWrapper, value);
		}

		[Ordinal(16)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(17)] 
		[RED("levelDescriptionText")] 
		public inkTextWidgetReference LevelDescriptionText
		{
			get => GetProperty(ref _levelDescriptionText);
			set => SetProperty(ref _levelDescriptionText, value);
		}

		[Ordinal(18)] 
		[RED("nextLevelWrapper")] 
		public inkWidgetReference NextLevelWrapper
		{
			get => GetProperty(ref _nextLevelWrapper);
			set => SetProperty(ref _nextLevelWrapper, value);
		}

		[Ordinal(19)] 
		[RED("nextLevelText")] 
		public inkTextWidgetReference NextLevelText
		{
			get => GetProperty(ref _nextLevelText);
			set => SetProperty(ref _nextLevelText, value);
		}

		[Ordinal(20)] 
		[RED("nextLevelDescriptionText")] 
		public inkTextWidgetReference NextLevelDescriptionText
		{
			get => GetProperty(ref _nextLevelDescriptionText);
			set => SetProperty(ref _nextLevelDescriptionText, value);
		}

		[Ordinal(21)] 
		[RED("level1Wrapper")] 
		public inkWidgetReference Level1Wrapper
		{
			get => GetProperty(ref _level1Wrapper);
			set => SetProperty(ref _level1Wrapper, value);
		}

		[Ordinal(22)] 
		[RED("levelsDescriptions")] 
		public CArray<PerkTooltipDescriptionEntry> LevelsDescriptions
		{
			get => GetProperty(ref _levelsDescriptions);
			set => SetProperty(ref _levelsDescriptions, value);
		}

		[Ordinal(23)] 
		[RED("relatedWeaponTypeWrapper")] 
		public inkWidgetReference RelatedWeaponTypeWrapper
		{
			get => GetProperty(ref _relatedWeaponTypeWrapper);
			set => SetProperty(ref _relatedWeaponTypeWrapper, value);
		}

		[Ordinal(24)] 
		[RED("relatedWeaponTypeIcon")] 
		public inkImageWidgetReference RelatedWeaponTypeIcon
		{
			get => GetProperty(ref _relatedWeaponTypeIcon);
			set => SetProperty(ref _relatedWeaponTypeIcon, value);
		}

		[Ordinal(25)] 
		[RED("relatedWeaponTypeText")] 
		public inkTextWidgetReference RelatedWeaponTypeText
		{
			get => GetProperty(ref _relatedWeaponTypeText);
			set => SetProperty(ref _relatedWeaponTypeText, value);
		}

		[Ordinal(26)] 
		[RED("traitLevelGrowthText")] 
		public inkTextWidgetReference TraitLevelGrowthText
		{
			get => GetProperty(ref _traitLevelGrowthText);
			set => SetProperty(ref _traitLevelGrowthText, value);
		}

		[Ordinal(27)] 
		[RED("unlockTraitPointsText")] 
		public inkTextWidgetReference UnlockTraitPointsText
		{
			get => GetProperty(ref _unlockTraitPointsText);
			set => SetProperty(ref _unlockTraitPointsText, value);
		}

		[Ordinal(28)] 
		[RED("unlockTraitWrapper")] 
		public inkWidgetReference UnlockTraitWrapper
		{
			get => GetProperty(ref _unlockTraitWrapper);
			set => SetProperty(ref _unlockTraitWrapper, value);
		}

		[Ordinal(29)] 
		[RED("inputHints")] 
		public inkWidgetReference InputHints
		{
			get => GetProperty(ref _inputHints);
			set => SetProperty(ref _inputHints, value);
		}

		[Ordinal(30)] 
		[RED("buyHint")] 
		public inkWidgetReference BuyHint
		{
			get => GetProperty(ref _buyHint);
			set => SetProperty(ref _buyHint, value);
		}

		[Ordinal(31)] 
		[RED("sellHint")] 
		public inkWidgetReference SellHint
		{
			get => GetProperty(ref _sellHint);
			set => SetProperty(ref _sellHint, value);
		}

		[Ordinal(32)] 
		[RED("relicCost")] 
		public inkWidgetReference RelicCost
		{
			get => GetProperty(ref _relicCost);
			set => SetProperty(ref _relicCost, value);
		}

		[Ordinal(33)] 
		[RED("costText")] 
		public inkTextWidgetReference CostText
		{
			get => GetProperty(ref _costText);
			set => SetProperty(ref _costText, value);
		}

		[Ordinal(34)] 
		[RED("costImage")] 
		public inkImageWidgetReference CostImage
		{
			get => GetProperty(ref _costImage);
			set => SetProperty(ref _costImage, value);
		}

		[Ordinal(35)] 
		[RED("perkLevelWrapper")] 
		public inkWidgetReference PerkLevelWrapper
		{
			get => GetProperty(ref _perkLevelWrapper);
			set => SetProperty(ref _perkLevelWrapper, value);
		}

		[Ordinal(36)] 
		[RED("perkLevelCurrent")] 
		public inkTextWidgetReference PerkLevelCurrent
		{
			get => GetProperty(ref _perkLevelCurrent);
			set => SetProperty(ref _perkLevelCurrent, value);
		}

		[Ordinal(37)] 
		[RED("perkLevelMax")] 
		public inkTextWidgetReference PerkLevelMax
		{
			get => GetProperty(ref _perkLevelMax);
			set => SetProperty(ref _perkLevelMax, value);
		}

		[Ordinal(38)] 
		[RED("cornerContainer")] 
		public inkWidgetReference CornerContainer
		{
			get => GetProperty(ref _cornerContainer);
			set => SetProperty(ref _cornerContainer, value);
		}

		[Ordinal(39)] 
		[RED("cyberwareDetailsInfo")] 
		public inkWidgetReference CyberwareDetailsInfo
		{
			get => GetProperty(ref _cyberwareDetailsInfo);
			set => SetProperty(ref _cyberwareDetailsInfo, value);
		}

		[Ordinal(40)] 
		[RED("DEBUG_iconErrorWrapper")] 
		public inkWidgetReference DEBUG_iconErrorWrapper
		{
			get => GetProperty(ref _dEBUG_iconErrorWrapper);
			set => SetProperty(ref _dEBUG_iconErrorWrapper, value);
		}

		[Ordinal(41)] 
		[RED("DEBUG_iconErrorText")] 
		public inkTextWidgetReference DEBUG_iconErrorText
		{
			get => GetProperty(ref _dEBUG_iconErrorText);
			set => SetProperty(ref _dEBUG_iconErrorText, value);
		}

		[Ordinal(42)] 
		[RED("data")] 
		public CHandle<BasePerksMenuTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(43)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(44)] 
		[RED("settingsListener")] 
		public CHandle<PerkDisplayTooltipSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(45)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(46)] 
		[RED("tooltipWrapper")] 
		public inkWidgetReference TooltipWrapper
		{
			get => GetProperty(ref _tooltipWrapper);
			set => SetProperty(ref _tooltipWrapper, value);
		}

		[Ordinal(47)] 
		[RED("horizontalSizer")] 
		public inkWidgetReference HorizontalSizer
		{
			get => GetProperty(ref _horizontalSizer);
			set => SetProperty(ref _horizontalSizer, value);
		}

		[Ordinal(48)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		public PerkDisplayTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
