using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleplayerMenuGameController : gameuiMainMenuGameController
	{
		private inkCompoundWidgetReference _baseLogoContainer;
		private inkCompoundWidgetReference _ep1LogoContainer;
		private inkWidgetReference _gogButtonWidgetRef;
		private inkCompoundWidgetReference _accountSelector;
		private inkCompoundWidgetReference _gameVersionButton;
		private inkCompoundWidgetReference _patch2Notification;
		private CFloat _patch2NotificationDelay;
		private inkCompoundWidgetReference _expansionBanner;
		private CName _ep1IdName;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _continuetooltipContainer;
		private inkWidgetReference _tooltipsManagerRef;
		private inkTextWidgetReference _versionTextRef;
		private inkWidgetReference _eulaWidget;
		private inkWidgetReference _quitGameWidget;
		private inkWidgetReference _sliderWidget;
		private inkWidgetReference _declineButtonWidget;
		private inkWidgetReference _acceptButtonWidget;
		private inkTextWidgetReference _declineButtonText;
		private inkTextWidgetReference _acceptButtonText;
		private wCHandle<gameIOnlineSystem> _onlineSystem;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<ContinueGameTooltip> _continueGameTooltipController;
		private wCHandle<inkWidgetLogicController> _expansionHintController;
		private wCHandle<ExpansionBannerController> _expansionBannerController;
		private wCHandle<inkMenuAccountLogicController> _accountSelectorController;
		private wCHandle<inkTextReplaceAnimationController> _textAnimController;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CHandle<PatchNotesCheckData> _patchNotesCheckData;
		private CEnum<servicesCloudSavesQueryStatus> _dataSyncStatus;
		private CInt32 _savesCount;
		private CBool _savesReady;
		private CBool _isOffline;
		private CBool _isModded;
		private CBool _isExpansionHintShown;
		private CBool _isMainMenuShownFirstTime;
		private CBool _isPatch2NotificationShown;
		private CBool _isReloadPopupShown;
		private CBool _isEp1Enabled;
		private CString _gameVersion;
		private CName _patch2NotificationIntroName;
		private CName _patch2NotificationOutroName;
		private CHandle<inkanimProxy> _patch2NotificationAnimProxy;
		private CHandle<inkanimProxy> _gameVersionAnim;
		private CBool _eulaIsAccepted;
		private CBool _isEulaWindowOpened;
		private CBool _eulaRead;
		private wCHandle<inkSliderController> _sliderController;
		private wCHandle<inkButtonController> _declineButtonController;
		private wCHandle<inkButtonController> _acceptButtonController;
		private CHandle<inkanimProxy> _eulaAnimationProxy;

		[Ordinal(7)] 
		[RED("baseLogoContainer")] 
		public inkCompoundWidgetReference BaseLogoContainer
		{
			get => GetProperty(ref _baseLogoContainer);
			set => SetProperty(ref _baseLogoContainer, value);
		}

		[Ordinal(8)] 
		[RED("ep1LogoContainer")] 
		public inkCompoundWidgetReference Ep1LogoContainer
		{
			get => GetProperty(ref _ep1LogoContainer);
			set => SetProperty(ref _ep1LogoContainer, value);
		}

		[Ordinal(9)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetProperty(ref _gogButtonWidgetRef);
			set => SetProperty(ref _gogButtonWidgetRef, value);
		}

		[Ordinal(10)] 
		[RED("accountSelector")] 
		public inkCompoundWidgetReference AccountSelector
		{
			get => GetProperty(ref _accountSelector);
			set => SetProperty(ref _accountSelector, value);
		}

		[Ordinal(11)] 
		[RED("gameVersionButton")] 
		public inkCompoundWidgetReference GameVersionButton
		{
			get => GetProperty(ref _gameVersionButton);
			set => SetProperty(ref _gameVersionButton, value);
		}

		[Ordinal(12)] 
		[RED("patch2Notification")] 
		public inkCompoundWidgetReference Patch2Notification
		{
			get => GetProperty(ref _patch2Notification);
			set => SetProperty(ref _patch2Notification, value);
		}

		[Ordinal(13)] 
		[RED("patch2NotificationDelay")] 
		public CFloat Patch2NotificationDelay
		{
			get => GetProperty(ref _patch2NotificationDelay);
			set => SetProperty(ref _patch2NotificationDelay, value);
		}

		[Ordinal(14)] 
		[RED("expansionBanner")] 
		public inkCompoundWidgetReference ExpansionBanner
		{
			get => GetProperty(ref _expansionBanner);
			set => SetProperty(ref _expansionBanner, value);
		}

		[Ordinal(15)] 
		[RED("ep1IdName")] 
		public CName Ep1IdName
		{
			get => GetProperty(ref _ep1IdName);
			set => SetProperty(ref _ep1IdName, value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(17)] 
		[RED("continuetooltipContainer")] 
		public inkCompoundWidgetReference ContinuetooltipContainer
		{
			get => GetProperty(ref _continuetooltipContainer);
			set => SetProperty(ref _continuetooltipContainer, value);
		}

		[Ordinal(18)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(19)] 
		[RED("versionTextRef")] 
		public inkTextWidgetReference VersionTextRef
		{
			get => GetProperty(ref _versionTextRef);
			set => SetProperty(ref _versionTextRef, value);
		}

		[Ordinal(20)] 
		[RED("eulaWidget")] 
		public inkWidgetReference EulaWidget
		{
			get => GetProperty(ref _eulaWidget);
			set => SetProperty(ref _eulaWidget, value);
		}

		[Ordinal(21)] 
		[RED("quitGameWidget")] 
		public inkWidgetReference QuitGameWidget
		{
			get => GetProperty(ref _quitGameWidget);
			set => SetProperty(ref _quitGameWidget, value);
		}

		[Ordinal(22)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetProperty(ref _sliderWidget);
			set => SetProperty(ref _sliderWidget, value);
		}

		[Ordinal(23)] 
		[RED("declineButtonWidget")] 
		public inkWidgetReference DeclineButtonWidget
		{
			get => GetProperty(ref _declineButtonWidget);
			set => SetProperty(ref _declineButtonWidget, value);
		}

		[Ordinal(24)] 
		[RED("acceptButtonWidget")] 
		public inkWidgetReference AcceptButtonWidget
		{
			get => GetProperty(ref _acceptButtonWidget);
			set => SetProperty(ref _acceptButtonWidget, value);
		}

		[Ordinal(25)] 
		[RED("declineButtonText")] 
		public inkTextWidgetReference DeclineButtonText
		{
			get => GetProperty(ref _declineButtonText);
			set => SetProperty(ref _declineButtonText, value);
		}

		[Ordinal(26)] 
		[RED("acceptButtonText")] 
		public inkTextWidgetReference AcceptButtonText
		{
			get => GetProperty(ref _acceptButtonText);
			set => SetProperty(ref _acceptButtonText, value);
		}

		[Ordinal(27)] 
		[RED("onlineSystem")] 
		public wCHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetProperty(ref _onlineSystem);
			set => SetProperty(ref _onlineSystem, value);
		}

		[Ordinal(28)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		[Ordinal(29)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(30)] 
		[RED("continueGameTooltipController")] 
		public wCHandle<ContinueGameTooltip> ContinueGameTooltipController
		{
			get => GetProperty(ref _continueGameTooltipController);
			set => SetProperty(ref _continueGameTooltipController, value);
		}

		[Ordinal(31)] 
		[RED("expansionHintController")] 
		public wCHandle<inkWidgetLogicController> ExpansionHintController
		{
			get => GetProperty(ref _expansionHintController);
			set => SetProperty(ref _expansionHintController, value);
		}

		[Ordinal(32)] 
		[RED("expansionBannerController")] 
		public wCHandle<ExpansionBannerController> ExpansionBannerController
		{
			get => GetProperty(ref _expansionBannerController);
			set => SetProperty(ref _expansionBannerController, value);
		}

		[Ordinal(33)] 
		[RED("accountSelectorController")] 
		public wCHandle<inkMenuAccountLogicController> AccountSelectorController
		{
			get => GetProperty(ref _accountSelectorController);
			set => SetProperty(ref _accountSelectorController, value);
		}

		[Ordinal(34)] 
		[RED("textAnimController")] 
		public wCHandle<inkTextReplaceAnimationController> TextAnimController
		{
			get => GetProperty(ref _textAnimController);
			set => SetProperty(ref _textAnimController, value);
		}

		[Ordinal(35)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(36)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(37)] 
		[RED("patchNotesCheckData")] 
		public CHandle<PatchNotesCheckData> PatchNotesCheckData
		{
			get => GetProperty(ref _patchNotesCheckData);
			set => SetProperty(ref _patchNotesCheckData, value);
		}

		[Ordinal(38)] 
		[RED("dataSyncStatus")] 
		public CEnum<servicesCloudSavesQueryStatus> DataSyncStatus
		{
			get => GetProperty(ref _dataSyncStatus);
			set => SetProperty(ref _dataSyncStatus, value);
		}

		[Ordinal(39)] 
		[RED("savesCount")] 
		public CInt32 SavesCount
		{
			get => GetProperty(ref _savesCount);
			set => SetProperty(ref _savesCount, value);
		}

		[Ordinal(40)] 
		[RED("savesReady")] 
		public CBool SavesReady
		{
			get => GetProperty(ref _savesReady);
			set => SetProperty(ref _savesReady, value);
		}

		[Ordinal(41)] 
		[RED("isOffline")] 
		public CBool IsOffline
		{
			get => GetProperty(ref _isOffline);
			set => SetProperty(ref _isOffline, value);
		}

		[Ordinal(42)] 
		[RED("isModded")] 
		public CBool IsModded
		{
			get => GetProperty(ref _isModded);
			set => SetProperty(ref _isModded, value);
		}

		[Ordinal(43)] 
		[RED("isExpansionHintShown")] 
		public CBool IsExpansionHintShown
		{
			get => GetProperty(ref _isExpansionHintShown);
			set => SetProperty(ref _isExpansionHintShown, value);
		}

		[Ordinal(44)] 
		[RED("isMainMenuShownFirstTime")] 
		public CBool IsMainMenuShownFirstTime
		{
			get => GetProperty(ref _isMainMenuShownFirstTime);
			set => SetProperty(ref _isMainMenuShownFirstTime, value);
		}

		[Ordinal(45)] 
		[RED("isPatch2NotificationShown")] 
		public CBool IsPatch2NotificationShown
		{
			get => GetProperty(ref _isPatch2NotificationShown);
			set => SetProperty(ref _isPatch2NotificationShown, value);
		}

		[Ordinal(46)] 
		[RED("isReloadPopupShown")] 
		public CBool IsReloadPopupShown
		{
			get => GetProperty(ref _isReloadPopupShown);
			set => SetProperty(ref _isReloadPopupShown, value);
		}

		[Ordinal(47)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetProperty(ref _isEp1Enabled);
			set => SetProperty(ref _isEp1Enabled, value);
		}

		[Ordinal(48)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetProperty(ref _gameVersion);
			set => SetProperty(ref _gameVersion, value);
		}

		[Ordinal(49)] 
		[RED("patch2NotificationIntroName")] 
		public CName Patch2NotificationIntroName
		{
			get => GetProperty(ref _patch2NotificationIntroName);
			set => SetProperty(ref _patch2NotificationIntroName, value);
		}

		[Ordinal(50)] 
		[RED("patch2NotificationOutroName")] 
		public CName Patch2NotificationOutroName
		{
			get => GetProperty(ref _patch2NotificationOutroName);
			set => SetProperty(ref _patch2NotificationOutroName, value);
		}

		[Ordinal(51)] 
		[RED("patch2NotificationAnimProxy")] 
		public CHandle<inkanimProxy> Patch2NotificationAnimProxy
		{
			get => GetProperty(ref _patch2NotificationAnimProxy);
			set => SetProperty(ref _patch2NotificationAnimProxy, value);
		}

		[Ordinal(52)] 
		[RED("gameVersionAnim")] 
		public CHandle<inkanimProxy> GameVersionAnim
		{
			get => GetProperty(ref _gameVersionAnim);
			set => SetProperty(ref _gameVersionAnim, value);
		}

		[Ordinal(53)] 
		[RED("eulaIsAccepted")] 
		public CBool EulaIsAccepted
		{
			get => GetProperty(ref _eulaIsAccepted);
			set => SetProperty(ref _eulaIsAccepted, value);
		}

		[Ordinal(54)] 
		[RED("isEulaWindowOpened")] 
		public CBool IsEulaWindowOpened
		{
			get => GetProperty(ref _isEulaWindowOpened);
			set => SetProperty(ref _isEulaWindowOpened, value);
		}

		[Ordinal(55)] 
		[RED("eulaRead")] 
		public CBool EulaRead
		{
			get => GetProperty(ref _eulaRead);
			set => SetProperty(ref _eulaRead, value);
		}

		[Ordinal(56)] 
		[RED("sliderController")] 
		public wCHandle<inkSliderController> SliderController
		{
			get => GetProperty(ref _sliderController);
			set => SetProperty(ref _sliderController, value);
		}

		[Ordinal(57)] 
		[RED("declineButtonController")] 
		public wCHandle<inkButtonController> DeclineButtonController
		{
			get => GetProperty(ref _declineButtonController);
			set => SetProperty(ref _declineButtonController, value);
		}

		[Ordinal(58)] 
		[RED("acceptButtonController")] 
		public wCHandle<inkButtonController> AcceptButtonController
		{
			get => GetProperty(ref _acceptButtonController);
			set => SetProperty(ref _acceptButtonController, value);
		}

		[Ordinal(59)] 
		[RED("eulaAnimationProxy")] 
		public CHandle<inkanimProxy> EulaAnimationProxy
		{
			get => GetProperty(ref _eulaAnimationProxy);
			set => SetProperty(ref _eulaAnimationProxy, value);
		}

		public SingleplayerMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
