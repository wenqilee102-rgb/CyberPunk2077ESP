using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SettingsMainGameController : gameuiSettingsMenuGameController
	{
		private inkWidgetReference _scrollPanel;
		private inkWidgetReference _selectorWidget;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkCompoundWidgetReference _settingsOptionsList;
		private inkWidgetReference _applyButton;
		private inkWidgetReference _resetButton;
		private inkWidgetReference _defaultButton;
		private inkWidgetReference _benchmarkButton;
		private inkWidgetReference _brightnessButton;
		private inkWidgetReference _hdrButton;
		private inkWidgetReference _controllerButton;
		private inkWidgetReference _safezonesButton;
		private inkWidgetReference _replayTutorialButton;
		private inkWidgetReference _languageInstallProgressBarRoot;
		private inkWidgetReference _languageDisclaimer;
		private inkTextWidgetReference _descriptionText;
		private CName _settingGroupName_Video;
		private CName _settingGroupName_Graphics;
		private CName _settingGroupName_Interface;
		private CName _settingGroupName_Controls;
		private CName _settingGroupName_Language;
		private CName _settingGroupName_KeyBindings;
		private CString _descriptionWarningRichColor;
		private wCHandle<SettingsLanguageInstallProgressBar> _languageInstallProgressBar;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CArray<wCHandle<inkSettingsSelectorController>> _settingsElements;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CArray<SettingsCategory> _data;
		private CArray<CName> _menusList;
		private CHandle<SettingsVarListener> _settingsListener;
		private CHandle<SettingsNotificationListener> _settingsNotificationListener;
		private CHandle<userSettingsUserSettings> _settings;
		private CBool _isPreGame;
		private CHandle<inkGameNotificationToken> _benchmarkNotificationToken;
		private CHandle<inkGameNotificationToken> _safezonesEditorToken;
		private CBool _applyButtonEnabled;
		private CBool _resetButtonEnabled;
		private CBool _closeSettingsRequest;
		private CBool _resetSettingsRequest;
		private CBool _isDlcSettings;
		private CBool _isBenchmarkSettings;
		private CBool _showHdrButton;
		private CBool _showBrightnessButton;
		private CBool _useRightAligned;
		private CInt32 _currentHDRindex;
		private wCHandle<inkListController> _selectorCtrl;

		[Ordinal(3)] 
		[RED("scrollPanel")] 
		public inkWidgetReference ScrollPanel
		{
			get => GetProperty(ref _scrollPanel);
			set => SetProperty(ref _scrollPanel, value);
		}

		[Ordinal(4)] 
		[RED("selectorWidget")] 
		public inkWidgetReference SelectorWidget
		{
			get => GetProperty(ref _selectorWidget);
			set => SetProperty(ref _selectorWidget, value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("settingsOptionsList")] 
		public inkCompoundWidgetReference SettingsOptionsList
		{
			get => GetProperty(ref _settingsOptionsList);
			set => SetProperty(ref _settingsOptionsList, value);
		}

		[Ordinal(7)] 
		[RED("applyButton")] 
		public inkWidgetReference ApplyButton
		{
			get => GetProperty(ref _applyButton);
			set => SetProperty(ref _applyButton, value);
		}

		[Ordinal(8)] 
		[RED("resetButton")] 
		public inkWidgetReference ResetButton
		{
			get => GetProperty(ref _resetButton);
			set => SetProperty(ref _resetButton, value);
		}

		[Ordinal(9)] 
		[RED("defaultButton")] 
		public inkWidgetReference DefaultButton
		{
			get => GetProperty(ref _defaultButton);
			set => SetProperty(ref _defaultButton, value);
		}

		[Ordinal(10)] 
		[RED("benchmarkButton")] 
		public inkWidgetReference BenchmarkButton
		{
			get => GetProperty(ref _benchmarkButton);
			set => SetProperty(ref _benchmarkButton, value);
		}

		[Ordinal(11)] 
		[RED("brightnessButton")] 
		public inkWidgetReference BrightnessButton
		{
			get => GetProperty(ref _brightnessButton);
			set => SetProperty(ref _brightnessButton, value);
		}

		[Ordinal(12)] 
		[RED("hdrButton")] 
		public inkWidgetReference HdrButton
		{
			get => GetProperty(ref _hdrButton);
			set => SetProperty(ref _hdrButton, value);
		}

		[Ordinal(13)] 
		[RED("controllerButton")] 
		public inkWidgetReference ControllerButton
		{
			get => GetProperty(ref _controllerButton);
			set => SetProperty(ref _controllerButton, value);
		}

		[Ordinal(14)] 
		[RED("safezonesButton")] 
		public inkWidgetReference SafezonesButton
		{
			get => GetProperty(ref _safezonesButton);
			set => SetProperty(ref _safezonesButton, value);
		}

		[Ordinal(15)] 
		[RED("replayTutorialButton")] 
		public inkWidgetReference ReplayTutorialButton
		{
			get => GetProperty(ref _replayTutorialButton);
			set => SetProperty(ref _replayTutorialButton, value);
		}

		[Ordinal(16)] 
		[RED("languageInstallProgressBarRoot")] 
		public inkWidgetReference LanguageInstallProgressBarRoot
		{
			get => GetProperty(ref _languageInstallProgressBarRoot);
			set => SetProperty(ref _languageInstallProgressBarRoot, value);
		}

		[Ordinal(17)] 
		[RED("languageDisclaimer")] 
		public inkWidgetReference LanguageDisclaimer
		{
			get => GetProperty(ref _languageDisclaimer);
			set => SetProperty(ref _languageDisclaimer, value);
		}

		[Ordinal(18)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(19)] 
		[RED("settingGroupName_Video")] 
		public CName SettingGroupName_Video
		{
			get => GetProperty(ref _settingGroupName_Video);
			set => SetProperty(ref _settingGroupName_Video, value);
		}

		[Ordinal(20)] 
		[RED("settingGroupName_Graphics")] 
		public CName SettingGroupName_Graphics
		{
			get => GetProperty(ref _settingGroupName_Graphics);
			set => SetProperty(ref _settingGroupName_Graphics, value);
		}

		[Ordinal(21)] 
		[RED("settingGroupName_Interface")] 
		public CName SettingGroupName_Interface
		{
			get => GetProperty(ref _settingGroupName_Interface);
			set => SetProperty(ref _settingGroupName_Interface, value);
		}

		[Ordinal(22)] 
		[RED("settingGroupName_Controls")] 
		public CName SettingGroupName_Controls
		{
			get => GetProperty(ref _settingGroupName_Controls);
			set => SetProperty(ref _settingGroupName_Controls, value);
		}

		[Ordinal(23)] 
		[RED("settingGroupName_Language")] 
		public CName SettingGroupName_Language
		{
			get => GetProperty(ref _settingGroupName_Language);
			set => SetProperty(ref _settingGroupName_Language, value);
		}

		[Ordinal(24)] 
		[RED("settingGroupName_KeyBindings")] 
		public CName SettingGroupName_KeyBindings
		{
			get => GetProperty(ref _settingGroupName_KeyBindings);
			set => SetProperty(ref _settingGroupName_KeyBindings, value);
		}

		[Ordinal(25)] 
		[RED("descriptionWarningRichColor")] 
		public CString DescriptionWarningRichColor
		{
			get => GetProperty(ref _descriptionWarningRichColor);
			set => SetProperty(ref _descriptionWarningRichColor, value);
		}

		[Ordinal(26)] 
		[RED("languageInstallProgressBar")] 
		public wCHandle<SettingsLanguageInstallProgressBar> LanguageInstallProgressBar
		{
			get => GetProperty(ref _languageInstallProgressBar);
			set => SetProperty(ref _languageInstallProgressBar, value);
		}

		[Ordinal(27)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(28)] 
		[RED("settingsElements")] 
		public CArray<wCHandle<inkSettingsSelectorController>> SettingsElements
		{
			get => GetProperty(ref _settingsElements);
			set => SetProperty(ref _settingsElements, value);
		}

		[Ordinal(29)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(30)] 
		[RED("data")] 
		public CArray<SettingsCategory> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(31)] 
		[RED("menusList")] 
		public CArray<CName> MenusList
		{
			get => GetProperty(ref _menusList);
			set => SetProperty(ref _menusList, value);
		}

		[Ordinal(32)] 
		[RED("settingsListener")] 
		public CHandle<SettingsVarListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(33)] 
		[RED("settingsNotificationListener")] 
		public CHandle<SettingsNotificationListener> SettingsNotificationListener
		{
			get => GetProperty(ref _settingsNotificationListener);
			set => SetProperty(ref _settingsNotificationListener, value);
		}

		[Ordinal(34)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(35)] 
		[RED("isPreGame")] 
		public CBool IsPreGame
		{
			get => GetProperty(ref _isPreGame);
			set => SetProperty(ref _isPreGame, value);
		}

		[Ordinal(36)] 
		[RED("benchmarkNotificationToken")] 
		public CHandle<inkGameNotificationToken> BenchmarkNotificationToken
		{
			get => GetProperty(ref _benchmarkNotificationToken);
			set => SetProperty(ref _benchmarkNotificationToken, value);
		}

		[Ordinal(37)] 
		[RED("safezonesEditorToken")] 
		public CHandle<inkGameNotificationToken> SafezonesEditorToken
		{
			get => GetProperty(ref _safezonesEditorToken);
			set => SetProperty(ref _safezonesEditorToken, value);
		}

		[Ordinal(38)] 
		[RED("applyButtonEnabled")] 
		public CBool ApplyButtonEnabled
		{
			get => GetProperty(ref _applyButtonEnabled);
			set => SetProperty(ref _applyButtonEnabled, value);
		}

		[Ordinal(39)] 
		[RED("resetButtonEnabled")] 
		public CBool ResetButtonEnabled
		{
			get => GetProperty(ref _resetButtonEnabled);
			set => SetProperty(ref _resetButtonEnabled, value);
		}

		[Ordinal(40)] 
		[RED("closeSettingsRequest")] 
		public CBool CloseSettingsRequest
		{
			get => GetProperty(ref _closeSettingsRequest);
			set => SetProperty(ref _closeSettingsRequest, value);
		}

		[Ordinal(41)] 
		[RED("resetSettingsRequest")] 
		public CBool ResetSettingsRequest
		{
			get => GetProperty(ref _resetSettingsRequest);
			set => SetProperty(ref _resetSettingsRequest, value);
		}

		[Ordinal(42)] 
		[RED("isDlcSettings")] 
		public CBool IsDlcSettings
		{
			get => GetProperty(ref _isDlcSettings);
			set => SetProperty(ref _isDlcSettings, value);
		}

		[Ordinal(43)] 
		[RED("isBenchmarkSettings")] 
		public CBool IsBenchmarkSettings
		{
			get => GetProperty(ref _isBenchmarkSettings);
			set => SetProperty(ref _isBenchmarkSettings, value);
		}

		[Ordinal(44)] 
		[RED("showHdrButton")] 
		public CBool ShowHdrButton
		{
			get => GetProperty(ref _showHdrButton);
			set => SetProperty(ref _showHdrButton, value);
		}

		[Ordinal(45)] 
		[RED("showBrightnessButton")] 
		public CBool ShowBrightnessButton
		{
			get => GetProperty(ref _showBrightnessButton);
			set => SetProperty(ref _showBrightnessButton, value);
		}

		[Ordinal(46)] 
		[RED("useRightAligned")] 
		public CBool UseRightAligned
		{
			get => GetProperty(ref _useRightAligned);
			set => SetProperty(ref _useRightAligned, value);
		}

		[Ordinal(47)] 
		[RED("currentHDRindex")] 
		public CInt32 CurrentHDRindex
		{
			get => GetProperty(ref _currentHDRindex);
			set => SetProperty(ref _currentHDRindex, value);
		}

		[Ordinal(48)] 
		[RED("selectorCtrl")] 
		public wCHandle<inkListController> SelectorCtrl
		{
			get => GetProperty(ref _selectorCtrl);
			set => SetProperty(ref _selectorCtrl, value);
		}

		public SettingsMainGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
