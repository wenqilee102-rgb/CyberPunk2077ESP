using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksCategoriesGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _perksCategoriesContainer;
		private inkWidgetReference _tabsContainer;
		private inkWidgetReference _perksScreenContainer;
		private inkWidgetReference _espionageScreenContainer;
		private inkWidgetReference _skillsScreenContainer;
		private inkWidgetReference _pointsDisplay;
		private inkTextWidgetReference _playerLevel;
		private inkWidgetReference _resetAttributesButton;
		private inkWidgetReference _skillsScreenButton;
		private inkWidgetReference _espionageAttributeMask;
		private inkWidgetReference _espionagePointsRef;
		private inkWidgetReference _attributeTooltipHolderRight;
		private inkWidgetReference _attributeTooltipHolderLeft;
		private CArray<inkWidgetReference> _centerHiglightParts;
		private inkWidgetReference _perkTooltipPlacementLeft;
		private inkWidgetReference _perkTooltipPlacementRight;
		private inkWidgetReference _perkTooltipBgLeft;
		private inkWidgetReference _perkTooltipBgRight;
		private CHandle<inkanimProxy> _perkTooltipBgAnimProxy;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<NewPerkTabsController> _tabsController;
		private wCHandle<NewPerksScreenLogicController> _perksScreenController;
		private wCHandle<NewPerksScreenLogicController> _espionageScreenController;
		private wCHandle<NewPerkSkillsLogicController> _skillScreenController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<PlayerDevelopmentDataManager> _dataManager;
		private wCHandle<questQuestsSystem> _questSystem;
		private CArray<wCHandle<PerksMenuAttributeItemController>> _attributesControllersList;
		private CArray<CHandle<PerksMenuAttributeItemCreated>> _perksMenuItemCreatedQueue;
		private wCHandle<PerksPointsDisplayController> _pointsDisplayController;
		private wCHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<redCallbackObject> _characterLevelListener;
		private wCHandle<PlayerPuppet> _player;
		private CEnum<NewPeksActiveScreen> _previousScreen;
		private CEnum<NewPeksActiveScreen> _currentScreen;
		private CEnum<gamedataStatType> _currentStatScreen;
		private CBool _johnnyEspionageInitialized;
		private CBool _isEspionageUnlocked;
		private CEnum<PerkMenuAttribute> _lastHoveredAttribute;
		private CHandle<inkGameNotificationToken> _cyberwarePerkDetailsPopupToken;
		private CHandle<inkanimProxy> _perksScreenIntroAnimProxy;
		private CHandle<inkanimProxy> _perksScreenOutroAnimProxy;
		private CEnum<NewPerkTabsArrowDirection> _perksScreenDirection;
		private PerkHoverEventTooltipData _currentTooltipData;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private Vector2 _currentCursorPos;
		private CHandle<PerkUserData> _perkUserData;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<OpenSkillsMenuData> _skillsOpenData;
		private CHandle<inkGameNotificationToken> _resetConfirmationToken;
		private CHandle<IScriptable> _userData;
		private CBool _isPlayerInCombat;
		private CEnum<ScreenDisplayContext> _screenDisplayContext;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("perksCategoriesContainer")] 
		public inkWidgetReference PerksCategoriesContainer
		{
			get => GetProperty(ref _perksCategoriesContainer);
			set => SetProperty(ref _perksCategoriesContainer, value);
		}

		[Ordinal(6)] 
		[RED("tabsContainer")] 
		public inkWidgetReference TabsContainer
		{
			get => GetProperty(ref _tabsContainer);
			set => SetProperty(ref _tabsContainer, value);
		}

		[Ordinal(7)] 
		[RED("perksScreenContainer")] 
		public inkWidgetReference PerksScreenContainer
		{
			get => GetProperty(ref _perksScreenContainer);
			set => SetProperty(ref _perksScreenContainer, value);
		}

		[Ordinal(8)] 
		[RED("espionageScreenContainer")] 
		public inkWidgetReference EspionageScreenContainer
		{
			get => GetProperty(ref _espionageScreenContainer);
			set => SetProperty(ref _espionageScreenContainer, value);
		}

		[Ordinal(9)] 
		[RED("skillsScreenContainer")] 
		public inkWidgetReference SkillsScreenContainer
		{
			get => GetProperty(ref _skillsScreenContainer);
			set => SetProperty(ref _skillsScreenContainer, value);
		}

		[Ordinal(10)] 
		[RED("pointsDisplay")] 
		public inkWidgetReference PointsDisplay
		{
			get => GetProperty(ref _pointsDisplay);
			set => SetProperty(ref _pointsDisplay, value);
		}

		[Ordinal(11)] 
		[RED("playerLevel")] 
		public inkTextWidgetReference PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(12)] 
		[RED("resetAttributesButton")] 
		public inkWidgetReference ResetAttributesButton
		{
			get => GetProperty(ref _resetAttributesButton);
			set => SetProperty(ref _resetAttributesButton, value);
		}

		[Ordinal(13)] 
		[RED("skillsScreenButton")] 
		public inkWidgetReference SkillsScreenButton
		{
			get => GetProperty(ref _skillsScreenButton);
			set => SetProperty(ref _skillsScreenButton, value);
		}

		[Ordinal(14)] 
		[RED("espionageAttributeMask")] 
		public inkWidgetReference EspionageAttributeMask
		{
			get => GetProperty(ref _espionageAttributeMask);
			set => SetProperty(ref _espionageAttributeMask, value);
		}

		[Ordinal(15)] 
		[RED("espionagePointsRef")] 
		public inkWidgetReference EspionagePointsRef
		{
			get => GetProperty(ref _espionagePointsRef);
			set => SetProperty(ref _espionagePointsRef, value);
		}

		[Ordinal(16)] 
		[RED("attributeTooltipHolderRight")] 
		public inkWidgetReference AttributeTooltipHolderRight
		{
			get => GetProperty(ref _attributeTooltipHolderRight);
			set => SetProperty(ref _attributeTooltipHolderRight, value);
		}

		[Ordinal(17)] 
		[RED("attributeTooltipHolderLeft")] 
		public inkWidgetReference AttributeTooltipHolderLeft
		{
			get => GetProperty(ref _attributeTooltipHolderLeft);
			set => SetProperty(ref _attributeTooltipHolderLeft, value);
		}

		[Ordinal(18)] 
		[RED("centerHiglightParts")] 
		public CArray<inkWidgetReference> CenterHiglightParts
		{
			get => GetProperty(ref _centerHiglightParts);
			set => SetProperty(ref _centerHiglightParts, value);
		}

		[Ordinal(19)] 
		[RED("perkTooltipPlacementLeft")] 
		public inkWidgetReference PerkTooltipPlacementLeft
		{
			get => GetProperty(ref _perkTooltipPlacementLeft);
			set => SetProperty(ref _perkTooltipPlacementLeft, value);
		}

		[Ordinal(20)] 
		[RED("perkTooltipPlacementRight")] 
		public inkWidgetReference PerkTooltipPlacementRight
		{
			get => GetProperty(ref _perkTooltipPlacementRight);
			set => SetProperty(ref _perkTooltipPlacementRight, value);
		}

		[Ordinal(21)] 
		[RED("perkTooltipBgLeft")] 
		public inkWidgetReference PerkTooltipBgLeft
		{
			get => GetProperty(ref _perkTooltipBgLeft);
			set => SetProperty(ref _perkTooltipBgLeft, value);
		}

		[Ordinal(22)] 
		[RED("perkTooltipBgRight")] 
		public inkWidgetReference PerkTooltipBgRight
		{
			get => GetProperty(ref _perkTooltipBgRight);
			set => SetProperty(ref _perkTooltipBgRight, value);
		}

		[Ordinal(23)] 
		[RED("perkTooltipBgAnimProxy")] 
		public CHandle<inkanimProxy> PerkTooltipBgAnimProxy
		{
			get => GetProperty(ref _perkTooltipBgAnimProxy);
			set => SetProperty(ref _perkTooltipBgAnimProxy, value);
		}

		[Ordinal(24)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(25)] 
		[RED("tabsController")] 
		public wCHandle<NewPerkTabsController> TabsController
		{
			get => GetProperty(ref _tabsController);
			set => SetProperty(ref _tabsController, value);
		}

		[Ordinal(26)] 
		[RED("perksScreenController")] 
		public wCHandle<NewPerksScreenLogicController> PerksScreenController
		{
			get => GetProperty(ref _perksScreenController);
			set => SetProperty(ref _perksScreenController, value);
		}

		[Ordinal(27)] 
		[RED("espionageScreenController")] 
		public wCHandle<NewPerksScreenLogicController> EspionageScreenController
		{
			get => GetProperty(ref _espionageScreenController);
			set => SetProperty(ref _espionageScreenController, value);
		}

		[Ordinal(28)] 
		[RED("skillScreenController")] 
		public wCHandle<NewPerkSkillsLogicController> SkillScreenController
		{
			get => GetProperty(ref _skillScreenController);
			set => SetProperty(ref _skillScreenController, value);
		}

		[Ordinal(29)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(30)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(31)] 
		[RED("dataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(32)] 
		[RED("questSystem")] 
		public wCHandle<questQuestsSystem> QuestSystem
		{
			get => GetProperty(ref _questSystem);
			set => SetProperty(ref _questSystem, value);
		}

		[Ordinal(33)] 
		[RED("attributesControllersList")] 
		public CArray<wCHandle<PerksMenuAttributeItemController>> AttributesControllersList
		{
			get => GetProperty(ref _attributesControllersList);
			set => SetProperty(ref _attributesControllersList, value);
		}

		[Ordinal(34)] 
		[RED("perksMenuItemCreatedQueue")] 
		public CArray<CHandle<PerksMenuAttributeItemCreated>> PerksMenuItemCreatedQueue
		{
			get => GetProperty(ref _perksMenuItemCreatedQueue);
			set => SetProperty(ref _perksMenuItemCreatedQueue, value);
		}

		[Ordinal(35)] 
		[RED("pointsDisplayController")] 
		public wCHandle<PerksPointsDisplayController> PointsDisplayController
		{
			get => GetProperty(ref _pointsDisplayController);
			set => SetProperty(ref _pointsDisplayController, value);
		}

		[Ordinal(36)] 
		[RED("playerStatsBlackboard")] 
		public wCHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(37)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(38)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(39)] 
		[RED("previousScreen")] 
		public CEnum<NewPeksActiveScreen> PreviousScreen
		{
			get => GetProperty(ref _previousScreen);
			set => SetProperty(ref _previousScreen, value);
		}

		[Ordinal(40)] 
		[RED("currentScreen")] 
		public CEnum<NewPeksActiveScreen> CurrentScreen
		{
			get => GetProperty(ref _currentScreen);
			set => SetProperty(ref _currentScreen, value);
		}

		[Ordinal(41)] 
		[RED("currentStatScreen")] 
		public CEnum<gamedataStatType> CurrentStatScreen
		{
			get => GetProperty(ref _currentStatScreen);
			set => SetProperty(ref _currentStatScreen, value);
		}

		[Ordinal(42)] 
		[RED("johnnyEspionageInitialized")] 
		public CBool JohnnyEspionageInitialized
		{
			get => GetProperty(ref _johnnyEspionageInitialized);
			set => SetProperty(ref _johnnyEspionageInitialized, value);
		}

		[Ordinal(43)] 
		[RED("isEspionageUnlocked")] 
		public CBool IsEspionageUnlocked
		{
			get => GetProperty(ref _isEspionageUnlocked);
			set => SetProperty(ref _isEspionageUnlocked, value);
		}

		[Ordinal(44)] 
		[RED("lastHoveredAttribute")] 
		public CEnum<PerkMenuAttribute> LastHoveredAttribute
		{
			get => GetProperty(ref _lastHoveredAttribute);
			set => SetProperty(ref _lastHoveredAttribute, value);
		}

		[Ordinal(45)] 
		[RED("cyberwarePerkDetailsPopupToken")] 
		public CHandle<inkGameNotificationToken> CyberwarePerkDetailsPopupToken
		{
			get => GetProperty(ref _cyberwarePerkDetailsPopupToken);
			set => SetProperty(ref _cyberwarePerkDetailsPopupToken, value);
		}

		[Ordinal(46)] 
		[RED("perksScreenIntroAnimProxy")] 
		public CHandle<inkanimProxy> PerksScreenIntroAnimProxy
		{
			get => GetProperty(ref _perksScreenIntroAnimProxy);
			set => SetProperty(ref _perksScreenIntroAnimProxy, value);
		}

		[Ordinal(47)] 
		[RED("perksScreenOutroAnimProxy")] 
		public CHandle<inkanimProxy> PerksScreenOutroAnimProxy
		{
			get => GetProperty(ref _perksScreenOutroAnimProxy);
			set => SetProperty(ref _perksScreenOutroAnimProxy, value);
		}

		[Ordinal(48)] 
		[RED("perksScreenDirection")] 
		public CEnum<NewPerkTabsArrowDirection> PerksScreenDirection
		{
			get => GetProperty(ref _perksScreenDirection);
			set => SetProperty(ref _perksScreenDirection, value);
		}

		[Ordinal(49)] 
		[RED("currentTooltipData")] 
		public PerkHoverEventTooltipData CurrentTooltipData
		{
			get => GetProperty(ref _currentTooltipData);
			set => SetProperty(ref _currentTooltipData, value);
		}

		[Ordinal(50)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(51)] 
		[RED("currentCursorPos")] 
		public Vector2 CurrentCursorPos
		{
			get => GetProperty(ref _currentCursorPos);
			set => SetProperty(ref _currentCursorPos, value);
		}

		[Ordinal(52)] 
		[RED("perkUserData")] 
		public CHandle<PerkUserData> PerkUserData
		{
			get => GetProperty(ref _perkUserData);
			set => SetProperty(ref _perkUserData, value);
		}

		[Ordinal(53)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetProperty(ref _vendorUserData);
			set => SetProperty(ref _vendorUserData, value);
		}

		[Ordinal(54)] 
		[RED("skillsOpenData")] 
		public CHandle<OpenSkillsMenuData> SkillsOpenData
		{
			get => GetProperty(ref _skillsOpenData);
			set => SetProperty(ref _skillsOpenData, value);
		}

		[Ordinal(55)] 
		[RED("resetConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ResetConfirmationToken
		{
			get => GetProperty(ref _resetConfirmationToken);
			set => SetProperty(ref _resetConfirmationToken, value);
		}

		[Ordinal(56)] 
		[RED("userData")] 
		public CHandle<IScriptable> UserData
		{
			get => GetProperty(ref _userData);
			set => SetProperty(ref _userData, value);
		}

		[Ordinal(57)] 
		[RED("isPlayerInCombat")] 
		public CBool IsPlayerInCombat
		{
			get => GetProperty(ref _isPlayerInCombat);
			set => SetProperty(ref _isPlayerInCombat, value);
		}

		[Ordinal(58)] 
		[RED("screenDisplayContext")] 
		public CEnum<ScreenDisplayContext> ScreenDisplayContext
		{
			get => GetProperty(ref _screenDisplayContext);
			set => SetProperty(ref _screenDisplayContext, value);
		}

		public NewPerksCategoriesGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
