using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksScreenLogicController : inkWidgetLogicController
	{
		private CArray<inkWidgetReference> _perksWidgets;
		private inkWidgetReference _gauge;
		private CArray<PerkScreenTierInfo> _tiers;
		private inkWidgetReference _animationBoldLineWidget;
		private inkWidgetReference _animationLineWidget;
		private inkWidgetReference _animationGradientWidget;
		private inkWidgetReference _attributeButtonWidget;
		private inkWidgetReference _lockedLineIcon;
		private inkWidgetReference _unlockedLineIcon;
		private CArray<inkTextWidgetReference> _attributeRequirementTexts;
		private CArray<inkTextWidgetReference> _levelRequirementTexts;
		private CBool _perksInitialized;
		private CHandle<inkScriptHashMap> _perksControllers;
		private CHandle<inkScriptHashMap> _perksContainersControllers;
		private CArray<wCHandle<NewPerksPerkContainerLogicController>> _perkControllersArray;
		private CArray<wCHandle<NewPerksPerkContainerLogicController>> _enabledControllers;
		private CHandle<NewPerksScreenInitData> _initData;
		private CArray<wCHandle<gamedataNewPerk_Record>> _perksList;
		private wCHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<PlayerDevelopmentData> _playerDevelopmentData;
		private CInt32 _attributePoints;
		private CHandle<NewPerksRequirementsLinksManager> _linksManager;
		private wCHandle<NewPerksGaugeController> _gaugeController;
		private wCHandle<NewPerksAttributeButtonController> _attributeButtonController;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<PlayerDevelopmentDataManager> _dataManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CArray<NewPerksGaugePointDetails> _levels;
		private CArray<PerkTierHighlight> _highlightData;
		private CArray<CHandle<inkanimProxy>> _activeProxies;
		private CArray<inkWidgetReference> _highlightedWires;
		private CArray<wCHandle<inkWidget>> _highlightedPerks;
		private CArray<inkWidgetReference> _dimmedWidgets;
		private CArray<CHandle<inkanimProxy>> _dimProxies;
		private CArray<CHandle<inkanimProxy>> _undimProxies;
		private CBool _isActiveScreen;
		private CBool _isEspionage;
		private UnlockAnimData _unlockAnimData;
		private CHandle<inkanimProxy> _lineAnimProxy;
		private CHandle<inkanimProxy> _buttonMoveAnimProxy;
		private CHandle<inkanimProxy> _buttonCustomAnimProxy;
		private CHandle<inkanimProxy> _lockAnimProxy;
		private CBool _introFinished;
		private CBool _perkHovered;
		private CHandle<NewPerkDisplayData> _currentHoveredPerkData;
		private wCHandle<NewPerksCategoriesGameController> _gameController;
		private CHandle<inkGameNotificationToken> _sellFailToken;
		private CEnum<gamedataNewPerkType> _perkToSnapCursor;
		private CInt32 _unlockState;

		[Ordinal(1)] 
		[RED("perksWidgets")] 
		public CArray<inkWidgetReference> PerksWidgets
		{
			get => GetProperty(ref _perksWidgets);
			set => SetProperty(ref _perksWidgets, value);
		}

		[Ordinal(2)] 
		[RED("gauge")] 
		public inkWidgetReference Gauge
		{
			get => GetProperty(ref _gauge);
			set => SetProperty(ref _gauge, value);
		}

		[Ordinal(3)] 
		[RED("tiers")] 
		public CArray<PerkScreenTierInfo> Tiers
		{
			get => GetProperty(ref _tiers);
			set => SetProperty(ref _tiers, value);
		}

		[Ordinal(4)] 
		[RED("animationBoldLineWidget")] 
		public inkWidgetReference AnimationBoldLineWidget
		{
			get => GetProperty(ref _animationBoldLineWidget);
			set => SetProperty(ref _animationBoldLineWidget, value);
		}

		[Ordinal(5)] 
		[RED("animationLineWidget")] 
		public inkWidgetReference AnimationLineWidget
		{
			get => GetProperty(ref _animationLineWidget);
			set => SetProperty(ref _animationLineWidget, value);
		}

		[Ordinal(6)] 
		[RED("animationGradientWidget")] 
		public inkWidgetReference AnimationGradientWidget
		{
			get => GetProperty(ref _animationGradientWidget);
			set => SetProperty(ref _animationGradientWidget, value);
		}

		[Ordinal(7)] 
		[RED("attributeButtonWidget")] 
		public inkWidgetReference AttributeButtonWidget
		{
			get => GetProperty(ref _attributeButtonWidget);
			set => SetProperty(ref _attributeButtonWidget, value);
		}

		[Ordinal(8)] 
		[RED("lockedLineIcon")] 
		public inkWidgetReference LockedLineIcon
		{
			get => GetProperty(ref _lockedLineIcon);
			set => SetProperty(ref _lockedLineIcon, value);
		}

		[Ordinal(9)] 
		[RED("unlockedLineIcon")] 
		public inkWidgetReference UnlockedLineIcon
		{
			get => GetProperty(ref _unlockedLineIcon);
			set => SetProperty(ref _unlockedLineIcon, value);
		}

		[Ordinal(10)] 
		[RED("attributeRequirementTexts")] 
		public CArray<inkTextWidgetReference> AttributeRequirementTexts
		{
			get => GetProperty(ref _attributeRequirementTexts);
			set => SetProperty(ref _attributeRequirementTexts, value);
		}

		[Ordinal(11)] 
		[RED("levelRequirementTexts")] 
		public CArray<inkTextWidgetReference> LevelRequirementTexts
		{
			get => GetProperty(ref _levelRequirementTexts);
			set => SetProperty(ref _levelRequirementTexts, value);
		}

		[Ordinal(12)] 
		[RED("perksInitialized")] 
		public CBool PerksInitialized
		{
			get => GetProperty(ref _perksInitialized);
			set => SetProperty(ref _perksInitialized, value);
		}

		[Ordinal(13)] 
		[RED("perksControllers")] 
		public CHandle<inkScriptHashMap> PerksControllers
		{
			get => GetProperty(ref _perksControllers);
			set => SetProperty(ref _perksControllers, value);
		}

		[Ordinal(14)] 
		[RED("perksContainersControllers")] 
		public CHandle<inkScriptHashMap> PerksContainersControllers
		{
			get => GetProperty(ref _perksContainersControllers);
			set => SetProperty(ref _perksContainersControllers, value);
		}

		[Ordinal(15)] 
		[RED("perkControllersArray")] 
		public CArray<wCHandle<NewPerksPerkContainerLogicController>> PerkControllersArray
		{
			get => GetProperty(ref _perkControllersArray);
			set => SetProperty(ref _perkControllersArray, value);
		}

		[Ordinal(16)] 
		[RED("enabledControllers")] 
		public CArray<wCHandle<NewPerksPerkContainerLogicController>> EnabledControllers
		{
			get => GetProperty(ref _enabledControllers);
			set => SetProperty(ref _enabledControllers, value);
		}

		[Ordinal(17)] 
		[RED("initData")] 
		public CHandle<NewPerksScreenInitData> InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}

		[Ordinal(18)] 
		[RED("perksList")] 
		public CArray<wCHandle<gamedataNewPerk_Record>> PerksList
		{
			get => GetProperty(ref _perksList);
			set => SetProperty(ref _perksList, value);
		}

		[Ordinal(19)] 
		[RED("playerDevelopmentSystem")] 
		public wCHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetProperty(ref _playerDevelopmentSystem);
			set => SetProperty(ref _playerDevelopmentSystem, value);
		}

		[Ordinal(20)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(21)] 
		[RED("playerDevelopmentData")] 
		public wCHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get => GetProperty(ref _playerDevelopmentData);
			set => SetProperty(ref _playerDevelopmentData, value);
		}

		[Ordinal(22)] 
		[RED("attributePoints")] 
		public CInt32 AttributePoints
		{
			get => GetProperty(ref _attributePoints);
			set => SetProperty(ref _attributePoints, value);
		}

		[Ordinal(23)] 
		[RED("linksManager")] 
		public CHandle<NewPerksRequirementsLinksManager> LinksManager
		{
			get => GetProperty(ref _linksManager);
			set => SetProperty(ref _linksManager, value);
		}

		[Ordinal(24)] 
		[RED("gaugeController")] 
		public wCHandle<NewPerksGaugeController> GaugeController
		{
			get => GetProperty(ref _gaugeController);
			set => SetProperty(ref _gaugeController, value);
		}

		[Ordinal(25)] 
		[RED("attributeButtonController")] 
		public wCHandle<NewPerksAttributeButtonController> AttributeButtonController
		{
			get => GetProperty(ref _attributeButtonController);
			set => SetProperty(ref _attributeButtonController, value);
		}

		[Ordinal(26)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(27)] 
		[RED("dataManager")] 
		public wCHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(28)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(29)] 
		[RED("levels")] 
		public CArray<NewPerksGaugePointDetails> Levels
		{
			get => GetProperty(ref _levels);
			set => SetProperty(ref _levels, value);
		}

		[Ordinal(30)] 
		[RED("highlightData")] 
		public CArray<PerkTierHighlight> HighlightData
		{
			get => GetProperty(ref _highlightData);
			set => SetProperty(ref _highlightData, value);
		}

		[Ordinal(31)] 
		[RED("activeProxies")] 
		public CArray<CHandle<inkanimProxy>> ActiveProxies
		{
			get => GetProperty(ref _activeProxies);
			set => SetProperty(ref _activeProxies, value);
		}

		[Ordinal(32)] 
		[RED("highlightedWires")] 
		public CArray<inkWidgetReference> HighlightedWires
		{
			get => GetProperty(ref _highlightedWires);
			set => SetProperty(ref _highlightedWires, value);
		}

		[Ordinal(33)] 
		[RED("highlightedPerks")] 
		public CArray<wCHandle<inkWidget>> HighlightedPerks
		{
			get => GetProperty(ref _highlightedPerks);
			set => SetProperty(ref _highlightedPerks, value);
		}

		[Ordinal(34)] 
		[RED("dimmedWidgets")] 
		public CArray<inkWidgetReference> DimmedWidgets
		{
			get => GetProperty(ref _dimmedWidgets);
			set => SetProperty(ref _dimmedWidgets, value);
		}

		[Ordinal(35)] 
		[RED("dimProxies")] 
		public CArray<CHandle<inkanimProxy>> DimProxies
		{
			get => GetProperty(ref _dimProxies);
			set => SetProperty(ref _dimProxies, value);
		}

		[Ordinal(36)] 
		[RED("undimProxies")] 
		public CArray<CHandle<inkanimProxy>> UndimProxies
		{
			get => GetProperty(ref _undimProxies);
			set => SetProperty(ref _undimProxies, value);
		}

		[Ordinal(37)] 
		[RED("isActiveScreen")] 
		public CBool IsActiveScreen
		{
			get => GetProperty(ref _isActiveScreen);
			set => SetProperty(ref _isActiveScreen, value);
		}

		[Ordinal(38)] 
		[RED("isEspionage")] 
		public CBool IsEspionage
		{
			get => GetProperty(ref _isEspionage);
			set => SetProperty(ref _isEspionage, value);
		}

		[Ordinal(39)] 
		[RED("unlockAnimData")] 
		public UnlockAnimData UnlockAnimData
		{
			get => GetProperty(ref _unlockAnimData);
			set => SetProperty(ref _unlockAnimData, value);
		}

		[Ordinal(40)] 
		[RED("lineAnimProxy")] 
		public CHandle<inkanimProxy> LineAnimProxy
		{
			get => GetProperty(ref _lineAnimProxy);
			set => SetProperty(ref _lineAnimProxy, value);
		}

		[Ordinal(41)] 
		[RED("buttonMoveAnimProxy")] 
		public CHandle<inkanimProxy> ButtonMoveAnimProxy
		{
			get => GetProperty(ref _buttonMoveAnimProxy);
			set => SetProperty(ref _buttonMoveAnimProxy, value);
		}

		[Ordinal(42)] 
		[RED("buttonCustomAnimProxy")] 
		public CHandle<inkanimProxy> ButtonCustomAnimProxy
		{
			get => GetProperty(ref _buttonCustomAnimProxy);
			set => SetProperty(ref _buttonCustomAnimProxy, value);
		}

		[Ordinal(43)] 
		[RED("lockAnimProxy")] 
		public CHandle<inkanimProxy> LockAnimProxy
		{
			get => GetProperty(ref _lockAnimProxy);
			set => SetProperty(ref _lockAnimProxy, value);
		}

		[Ordinal(44)] 
		[RED("introFinished")] 
		public CBool IntroFinished
		{
			get => GetProperty(ref _introFinished);
			set => SetProperty(ref _introFinished, value);
		}

		[Ordinal(45)] 
		[RED("perkHovered")] 
		public CBool PerkHovered
		{
			get => GetProperty(ref _perkHovered);
			set => SetProperty(ref _perkHovered, value);
		}

		[Ordinal(46)] 
		[RED("currentHoveredPerkData")] 
		public CHandle<NewPerkDisplayData> CurrentHoveredPerkData
		{
			get => GetProperty(ref _currentHoveredPerkData);
			set => SetProperty(ref _currentHoveredPerkData, value);
		}

		[Ordinal(47)] 
		[RED("gameController")] 
		public wCHandle<NewPerksCategoriesGameController> GameController
		{
			get => GetProperty(ref _gameController);
			set => SetProperty(ref _gameController, value);
		}

		[Ordinal(48)] 
		[RED("sellFailToken")] 
		public CHandle<inkGameNotificationToken> SellFailToken
		{
			get => GetProperty(ref _sellFailToken);
			set => SetProperty(ref _sellFailToken, value);
		}

		[Ordinal(49)] 
		[RED("perkToSnapCursor")] 
		public CEnum<gamedataNewPerkType> PerkToSnapCursor
		{
			get => GetProperty(ref _perkToSnapCursor);
			set => SetProperty(ref _perkToSnapCursor, value);
		}

		[Ordinal(50)] 
		[RED("unlockState")] 
		public CInt32 UnlockState
		{
			get => GetProperty(ref _unlockState);
			set => SetProperty(ref _unlockState, value);
		}

		public NewPerksScreenLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
