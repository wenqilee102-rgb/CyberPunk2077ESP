using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleColorSelectorGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _cursorRootContainerRef;
		private inkWidgetReference _cursorRootOffsetPoint;
		private inkWidgetReference _colorPaletteRef;
		private inkWidgetReference _stickerPaletteRef;
		private inkWidgetReference _currentTemplateParentRef;
		private inkTextWidgetReference _windowTitle;
		private CArray<inkWidgetReference> _classicBackgrounds;
		private CArray<inkWidgetReference> _mordredBackgrounds;
		private inkWidgetReference _colorWheelColorA;
		private inkWidgetReference _colorWheelColorB;
		private inkWidgetReference _colorWheelColorLights;
		private inkWidgetReference _colorWheelColorLightsCircle;
		private inkWidgetReference _colorWheelColorLightsFixedCircleContainer;
		private inkWidgetReference _colorWheelColorLightsFixedCircle;
		private vehicleColorSelectorPointerDef _colorPickerA;
		private vehicleColorSelectorPointerDef _selectedColorPointerA;
		private vehicleColorSelectorPointerDef _colorPickerB;
		private vehicleColorSelectorPointerDef _selectedColorPointerB;
		private vehicleColorSelectorPointerDef _colorPickerLights;
		private vehicleColorSelectorPointerDef _selectedColorPointerLights;
		private inkWidgetReference _swapColorHint;
		private inkWidgetReference _changeSliderHint;
		private inkTextWidgetReference _twintoneApplyHintText;
		private inkWidgetReference _changeTabRightHint;
		private inkWidgetReference _changeTabLeftHint;
		private inkWidgetReference _mouseHitColor1Ref;
		private inkWidgetReference _mouseHitColor2Ref;
		private inkWidgetReference _mouseHitLightsRef;
		private inkImageWidgetReference _vehiclePreviewColorA;
		private inkImageWidgetReference _vehiclePreviewColorB;
		private inkImageWidgetReference _vehiclePreviewLightsCar;
		private inkImageWidgetReference _vehiclePreviewLightsBike;
		private inkImageWidgetReference _vehiclePreviewBackground;
		private inkImageWidgetReference _vehiclePreviewForeground;
		private inkImageWidgetReference _vehiclePreviewGlowBackground;
		private inkImageWidgetReference _vehiclePreviewGlowA;
		private inkImageWidgetReference _vehiclePreviewGlowB;
		private inkImageWidgetReference _vehiclePreviewGlowLights;
		private inkWidgetReference _vehiclePreviewScalingCanvas;
		private inkImageWidgetReference _lightsPreviewBeamA;
		private inkImageWidgetReference _lightsPreviewBeamB;
		private inkImageWidgetReference _lightsPreviewBeamBike;
		private inkTextWidgetReference _lightErrorMessage;
		private CString _timeDilationProfile;
		private CName _introAnimation;
		private CName _cancelAnimation;
		private CName _applyAnimation;
		private inkTextWidgetReference _titleTextMain;
		private inkTextWidgetReference _titleTextNumber;
		private inkWidgetReference _colorHints;
		private inkWidgetReference _mouseHitSaturationBar;
		private inkWidgetReference _saturationBarFill;
		private inkWidgetReference _saturationPointer;
		private inkImageWidgetReference _saturationBarHighlight;
		private inkWidgetReference _saturationBarHint;
		private inkImageWidgetReference _brightnessBarHighlight;
		private inkWidgetReference _brightnessBarHint;
		private inkWidgetReference _headlightsIcon;
		private inkWidgetReference _mouseHitBrightnessBar;
		private inkWidgetReference _brightnessPointer;
		private inkWidgetReference _modeChangeBack;
		private inkWidgetReference _modeChangeNext;
		private inkWidgetReference _applyContainerWidget;
		private inkWidgetReference _resetContainerWidget;
		private inkWidgetReference _vehicleUnknownPane;
		private inkImageWidgetReference _vehicleBrandIcon;
		private CFloat _crackedCarGlitchMinimumInterval;
		private CFloat _crackedCarGlitchMaximumInterval;
		private inkTextWidgetReference _vehicleNameText;
		private inkWidgetLibraryReference _templatePreviewLibraryRef;
		private inkWidgetReference _uniqueColorPanel;
		private inkWidgetReference _uniqueColorErrorPanel;
		private inkVirtualCompoundWidgetReference _genericPatternsGrid;
		private inkVirtualCompoundWidgetReference _uniquePatternsGrid;
		private inkWidgetReference _saveProfileHint;
		private inkWidgetReference _deleteProfileHint;
		private CHandle<inkGameNotificationData> _popupData;
		private wCHandle<inkISystemRequestsHandler> _systemRequestsHandler;
		private wCHandle<PlayerPuppet> _player;
		private ScriptGameInstance _gameInstance;
		private CHandle<gameTimeSystem> _timeSystem;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _fakeUpdateProxy;
		private CHandle<inkanimProxy> _sbBarsProxy;
		private CHandle<inkanimProxy> _lightsFocusProxy;
		private wCHandle<inkWidget> _stickersPage;
		private CHandle<redCallbackObject> _isInMenuCallbackID;
		private CEnum<vehicleColorSelectorActiveMode> _activeMode;
		private CEnum<vehicleColorSelectorActiveMode> _previousMode;
		private CEnum<vehicleColorSelectorActiveInputMode> _activeInputMode;
		private CFloat _currentAngle;
		private CBool _colorADefined;
		private CBool _colorBDefined;
		private CBool _lightsDefined;
		private CFloat _targetColorAngleA;
		private CFloat _targetColorAngleB;
		private CFloat _targetColorAngleLights;
		private CFloat _targetColorASaturation;
		private CFloat _targetColorBSaturation;
		private CFloat _targetColorABrightness;
		private CFloat _targetColorBBrightness;
		private Vector2 _axisInputCache;
		private CBool _inputEnabled;
		private CBool _sbBarsShown;
		private CFloat _sbBarsLength;
		private CFloat _axisInputThreshold;
		private CFloat _saturationPointerPosition;
		private CFloat _brightnessPointerPosition;
		private CBool _mouseInputEnabled;
		private CBool _lightsEditingEnabled;
		private CBool _hasCustomRims;
		private CBool _hasUniquePaintjobs;
		private CBool _saturationSliderHolded;
		private CBool _brightnessSliderHolded;
		private CFloat _chromaSliderStepPad;
		private CFloat _chromaSliderStepMouse;
		private CBool _sliderHoldGamepad;
		private CInt32 _sliderHoldGamepadDamp;
		private CInt32 _sliderPadHoldAccelerationTreshhold;
		private CInt32 _storedSelectedColorID;
		private CColor _cachedNewColorA;
		private CColor _cachedNewColorB;
		private CColor _cachedNewColorLights;
		private CEnum<vehicleColorSelectorMenuCloseReason> _closeReason;
		private CBool _unsupportedVehicle;
		private CBool _previewDataMissing;
		private wCHandle<TwintoneTemplateGridController> _virtualGenericTemplateGridController;
		private wCHandle<TwintoneTemplateGridController> _virtualUniqueTemplateGridController;
		private CBool _genericGridInitialized;
		private CBool _uniqueGridInitialized;
		private VehicleVisualCustomizationTemplate _currentTemplate;
		private VehicleVisualCustomizationTemplate _toggledTemplate;
		private wCHandle<ColorTemplatePreviewDisplayController> _currentTemplatePreview;
		private CEnum<vehicleColorSelectorActiveTab> _activePanel;
		private CEnum<vehicleColorSelectorSBBar> _activeSBBar;
		private CHandle<inkanimProxy> _mainPanelAnimProxy;
		private CHandle<inkanimProxy> _twintonePanelAnimProxy;
		private CHandle<inkanimProxy> _carGlitchProxy;
		private CHandle<inkanimProxy> _crackedAnimProxy;

		[Ordinal(2)] 
		[RED("CursorRootContainerRef")] 
		public inkWidgetReference CursorRootContainerRef
		{
			get => GetProperty(ref _cursorRootContainerRef);
			set => SetProperty(ref _cursorRootContainerRef, value);
		}

		[Ordinal(3)] 
		[RED("CursorRootOffsetPoint")] 
		public inkWidgetReference CursorRootOffsetPoint
		{
			get => GetProperty(ref _cursorRootOffsetPoint);
			set => SetProperty(ref _cursorRootOffsetPoint, value);
		}

		[Ordinal(4)] 
		[RED("colorPaletteRef")] 
		public inkWidgetReference ColorPaletteRef
		{
			get => GetProperty(ref _colorPaletteRef);
			set => SetProperty(ref _colorPaletteRef, value);
		}

		[Ordinal(5)] 
		[RED("stickerPaletteRef")] 
		public inkWidgetReference StickerPaletteRef
		{
			get => GetProperty(ref _stickerPaletteRef);
			set => SetProperty(ref _stickerPaletteRef, value);
		}

		[Ordinal(6)] 
		[RED("currentTemplateParentRef")] 
		public inkWidgetReference CurrentTemplateParentRef
		{
			get => GetProperty(ref _currentTemplateParentRef);
			set => SetProperty(ref _currentTemplateParentRef, value);
		}

		[Ordinal(7)] 
		[RED("windowTitle")] 
		public inkTextWidgetReference WindowTitle
		{
			get => GetProperty(ref _windowTitle);
			set => SetProperty(ref _windowTitle, value);
		}

		[Ordinal(8)] 
		[RED("classicBackgrounds")] 
		public CArray<inkWidgetReference> ClassicBackgrounds
		{
			get => GetProperty(ref _classicBackgrounds);
			set => SetProperty(ref _classicBackgrounds, value);
		}

		[Ordinal(9)] 
		[RED("mordredBackgrounds")] 
		public CArray<inkWidgetReference> MordredBackgrounds
		{
			get => GetProperty(ref _mordredBackgrounds);
			set => SetProperty(ref _mordredBackgrounds, value);
		}

		[Ordinal(10)] 
		[RED("colorWheelColorA")] 
		public inkWidgetReference ColorWheelColorA
		{
			get => GetProperty(ref _colorWheelColorA);
			set => SetProperty(ref _colorWheelColorA, value);
		}

		[Ordinal(11)] 
		[RED("colorWheelColorB")] 
		public inkWidgetReference ColorWheelColorB
		{
			get => GetProperty(ref _colorWheelColorB);
			set => SetProperty(ref _colorWheelColorB, value);
		}

		[Ordinal(12)] 
		[RED("colorWheelColorLights")] 
		public inkWidgetReference ColorWheelColorLights
		{
			get => GetProperty(ref _colorWheelColorLights);
			set => SetProperty(ref _colorWheelColorLights, value);
		}

		[Ordinal(13)] 
		[RED("colorWheelColorLightsCircle")] 
		public inkWidgetReference ColorWheelColorLightsCircle
		{
			get => GetProperty(ref _colorWheelColorLightsCircle);
			set => SetProperty(ref _colorWheelColorLightsCircle, value);
		}

		[Ordinal(14)] 
		[RED("colorWheelColorLightsFixedCircleContainer")] 
		public inkWidgetReference ColorWheelColorLightsFixedCircleContainer
		{
			get => GetProperty(ref _colorWheelColorLightsFixedCircleContainer);
			set => SetProperty(ref _colorWheelColorLightsFixedCircleContainer, value);
		}

		[Ordinal(15)] 
		[RED("colorWheelColorLightsFixedCircle")] 
		public inkWidgetReference ColorWheelColorLightsFixedCircle
		{
			get => GetProperty(ref _colorWheelColorLightsFixedCircle);
			set => SetProperty(ref _colorWheelColorLightsFixedCircle, value);
		}

		[Ordinal(16)] 
		[RED("colorPickerA")] 
		public vehicleColorSelectorPointerDef ColorPickerA
		{
			get => GetProperty(ref _colorPickerA);
			set => SetProperty(ref _colorPickerA, value);
		}

		[Ordinal(17)] 
		[RED("selectedColorPointerA")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerA
		{
			get => GetProperty(ref _selectedColorPointerA);
			set => SetProperty(ref _selectedColorPointerA, value);
		}

		[Ordinal(18)] 
		[RED("colorPickerB")] 
		public vehicleColorSelectorPointerDef ColorPickerB
		{
			get => GetProperty(ref _colorPickerB);
			set => SetProperty(ref _colorPickerB, value);
		}

		[Ordinal(19)] 
		[RED("selectedColorPointerB")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerB
		{
			get => GetProperty(ref _selectedColorPointerB);
			set => SetProperty(ref _selectedColorPointerB, value);
		}

		[Ordinal(20)] 
		[RED("colorPickerLights")] 
		public vehicleColorSelectorPointerDef ColorPickerLights
		{
			get => GetProperty(ref _colorPickerLights);
			set => SetProperty(ref _colorPickerLights, value);
		}

		[Ordinal(21)] 
		[RED("selectedColorPointerLights")] 
		public vehicleColorSelectorPointerDef SelectedColorPointerLights
		{
			get => GetProperty(ref _selectedColorPointerLights);
			set => SetProperty(ref _selectedColorPointerLights, value);
		}

		[Ordinal(22)] 
		[RED("swapColorHint")] 
		public inkWidgetReference SwapColorHint
		{
			get => GetProperty(ref _swapColorHint);
			set => SetProperty(ref _swapColorHint, value);
		}

		[Ordinal(23)] 
		[RED("changeSliderHint")] 
		public inkWidgetReference ChangeSliderHint
		{
			get => GetProperty(ref _changeSliderHint);
			set => SetProperty(ref _changeSliderHint, value);
		}

		[Ordinal(24)] 
		[RED("twintoneApplyHintText")] 
		public inkTextWidgetReference TwintoneApplyHintText
		{
			get => GetProperty(ref _twintoneApplyHintText);
			set => SetProperty(ref _twintoneApplyHintText, value);
		}

		[Ordinal(25)] 
		[RED("changeTabRightHint")] 
		public inkWidgetReference ChangeTabRightHint
		{
			get => GetProperty(ref _changeTabRightHint);
			set => SetProperty(ref _changeTabRightHint, value);
		}

		[Ordinal(26)] 
		[RED("changeTabLeftHint")] 
		public inkWidgetReference ChangeTabLeftHint
		{
			get => GetProperty(ref _changeTabLeftHint);
			set => SetProperty(ref _changeTabLeftHint, value);
		}

		[Ordinal(27)] 
		[RED("mouseHitColor1Ref")] 
		public inkWidgetReference MouseHitColor1Ref
		{
			get => GetProperty(ref _mouseHitColor1Ref);
			set => SetProperty(ref _mouseHitColor1Ref, value);
		}

		[Ordinal(28)] 
		[RED("mouseHitColor2Ref")] 
		public inkWidgetReference MouseHitColor2Ref
		{
			get => GetProperty(ref _mouseHitColor2Ref);
			set => SetProperty(ref _mouseHitColor2Ref, value);
		}

		[Ordinal(29)] 
		[RED("mouseHitLightsRef")] 
		public inkWidgetReference MouseHitLightsRef
		{
			get => GetProperty(ref _mouseHitLightsRef);
			set => SetProperty(ref _mouseHitLightsRef, value);
		}

		[Ordinal(30)] 
		[RED("vehiclePreviewColorA")] 
		public inkImageWidgetReference VehiclePreviewColorA
		{
			get => GetProperty(ref _vehiclePreviewColorA);
			set => SetProperty(ref _vehiclePreviewColorA, value);
		}

		[Ordinal(31)] 
		[RED("vehiclePreviewColorB")] 
		public inkImageWidgetReference VehiclePreviewColorB
		{
			get => GetProperty(ref _vehiclePreviewColorB);
			set => SetProperty(ref _vehiclePreviewColorB, value);
		}

		[Ordinal(32)] 
		[RED("vehiclePreviewLightsCar")] 
		public inkImageWidgetReference VehiclePreviewLightsCar
		{
			get => GetProperty(ref _vehiclePreviewLightsCar);
			set => SetProperty(ref _vehiclePreviewLightsCar, value);
		}

		[Ordinal(33)] 
		[RED("vehiclePreviewLightsBike")] 
		public inkImageWidgetReference VehiclePreviewLightsBike
		{
			get => GetProperty(ref _vehiclePreviewLightsBike);
			set => SetProperty(ref _vehiclePreviewLightsBike, value);
		}

		[Ordinal(34)] 
		[RED("vehiclePreviewBackground")] 
		public inkImageWidgetReference VehiclePreviewBackground
		{
			get => GetProperty(ref _vehiclePreviewBackground);
			set => SetProperty(ref _vehiclePreviewBackground, value);
		}

		[Ordinal(35)] 
		[RED("vehiclePreviewForeground")] 
		public inkImageWidgetReference VehiclePreviewForeground
		{
			get => GetProperty(ref _vehiclePreviewForeground);
			set => SetProperty(ref _vehiclePreviewForeground, value);
		}

		[Ordinal(36)] 
		[RED("vehiclePreviewGlowBackground")] 
		public inkImageWidgetReference VehiclePreviewGlowBackground
		{
			get => GetProperty(ref _vehiclePreviewGlowBackground);
			set => SetProperty(ref _vehiclePreviewGlowBackground, value);
		}

		[Ordinal(37)] 
		[RED("vehiclePreviewGlowA")] 
		public inkImageWidgetReference VehiclePreviewGlowA
		{
			get => GetProperty(ref _vehiclePreviewGlowA);
			set => SetProperty(ref _vehiclePreviewGlowA, value);
		}

		[Ordinal(38)] 
		[RED("vehiclePreviewGlowB")] 
		public inkImageWidgetReference VehiclePreviewGlowB
		{
			get => GetProperty(ref _vehiclePreviewGlowB);
			set => SetProperty(ref _vehiclePreviewGlowB, value);
		}

		[Ordinal(39)] 
		[RED("vehiclePreviewGlowLights")] 
		public inkImageWidgetReference VehiclePreviewGlowLights
		{
			get => GetProperty(ref _vehiclePreviewGlowLights);
			set => SetProperty(ref _vehiclePreviewGlowLights, value);
		}

		[Ordinal(40)] 
		[RED("vehiclePreviewScalingCanvas")] 
		public inkWidgetReference VehiclePreviewScalingCanvas
		{
			get => GetProperty(ref _vehiclePreviewScalingCanvas);
			set => SetProperty(ref _vehiclePreviewScalingCanvas, value);
		}

		[Ordinal(41)] 
		[RED("lightsPreviewBeamA")] 
		public inkImageWidgetReference LightsPreviewBeamA
		{
			get => GetProperty(ref _lightsPreviewBeamA);
			set => SetProperty(ref _lightsPreviewBeamA, value);
		}

		[Ordinal(42)] 
		[RED("lightsPreviewBeamB")] 
		public inkImageWidgetReference LightsPreviewBeamB
		{
			get => GetProperty(ref _lightsPreviewBeamB);
			set => SetProperty(ref _lightsPreviewBeamB, value);
		}

		[Ordinal(43)] 
		[RED("lightsPreviewBeamBike")] 
		public inkImageWidgetReference LightsPreviewBeamBike
		{
			get => GetProperty(ref _lightsPreviewBeamBike);
			set => SetProperty(ref _lightsPreviewBeamBike, value);
		}

		[Ordinal(44)] 
		[RED("lightErrorMessage")] 
		public inkTextWidgetReference LightErrorMessage
		{
			get => GetProperty(ref _lightErrorMessage);
			set => SetProperty(ref _lightErrorMessage, value);
		}

		[Ordinal(45)] 
		[RED("timeDilationProfile")] 
		public CString TimeDilationProfile
		{
			get => GetProperty(ref _timeDilationProfile);
			set => SetProperty(ref _timeDilationProfile, value);
		}

		[Ordinal(46)] 
		[RED("introAnimation")] 
		public CName IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(47)] 
		[RED("cancelAnimation")] 
		public CName CancelAnimation
		{
			get => GetProperty(ref _cancelAnimation);
			set => SetProperty(ref _cancelAnimation, value);
		}

		[Ordinal(48)] 
		[RED("applyAnimation")] 
		public CName ApplyAnimation
		{
			get => GetProperty(ref _applyAnimation);
			set => SetProperty(ref _applyAnimation, value);
		}

		[Ordinal(49)] 
		[RED("titleTextMain")] 
		public inkTextWidgetReference TitleTextMain
		{
			get => GetProperty(ref _titleTextMain);
			set => SetProperty(ref _titleTextMain, value);
		}

		[Ordinal(50)] 
		[RED("titleTextNumber")] 
		public inkTextWidgetReference TitleTextNumber
		{
			get => GetProperty(ref _titleTextNumber);
			set => SetProperty(ref _titleTextNumber, value);
		}

		[Ordinal(51)] 
		[RED("colorHints")] 
		public inkWidgetReference ColorHints
		{
			get => GetProperty(ref _colorHints);
			set => SetProperty(ref _colorHints, value);
		}

		[Ordinal(52)] 
		[RED("mouseHitSaturationBar")] 
		public inkWidgetReference MouseHitSaturationBar
		{
			get => GetProperty(ref _mouseHitSaturationBar);
			set => SetProperty(ref _mouseHitSaturationBar, value);
		}

		[Ordinal(53)] 
		[RED("saturationBarFill")] 
		public inkWidgetReference SaturationBarFill
		{
			get => GetProperty(ref _saturationBarFill);
			set => SetProperty(ref _saturationBarFill, value);
		}

		[Ordinal(54)] 
		[RED("saturationPointer")] 
		public inkWidgetReference SaturationPointer
		{
			get => GetProperty(ref _saturationPointer);
			set => SetProperty(ref _saturationPointer, value);
		}

		[Ordinal(55)] 
		[RED("saturationBarHighlight")] 
		public inkImageWidgetReference SaturationBarHighlight
		{
			get => GetProperty(ref _saturationBarHighlight);
			set => SetProperty(ref _saturationBarHighlight, value);
		}

		[Ordinal(56)] 
		[RED("saturationBarHint")] 
		public inkWidgetReference SaturationBarHint
		{
			get => GetProperty(ref _saturationBarHint);
			set => SetProperty(ref _saturationBarHint, value);
		}

		[Ordinal(57)] 
		[RED("brightnessBarHighlight")] 
		public inkImageWidgetReference BrightnessBarHighlight
		{
			get => GetProperty(ref _brightnessBarHighlight);
			set => SetProperty(ref _brightnessBarHighlight, value);
		}

		[Ordinal(58)] 
		[RED("brightnessBarHint")] 
		public inkWidgetReference BrightnessBarHint
		{
			get => GetProperty(ref _brightnessBarHint);
			set => SetProperty(ref _brightnessBarHint, value);
		}

		[Ordinal(59)] 
		[RED("headlightsIcon")] 
		public inkWidgetReference HeadlightsIcon
		{
			get => GetProperty(ref _headlightsIcon);
			set => SetProperty(ref _headlightsIcon, value);
		}

		[Ordinal(60)] 
		[RED("mouseHitBrightnessBar")] 
		public inkWidgetReference MouseHitBrightnessBar
		{
			get => GetProperty(ref _mouseHitBrightnessBar);
			set => SetProperty(ref _mouseHitBrightnessBar, value);
		}

		[Ordinal(61)] 
		[RED("brightnessPointer")] 
		public inkWidgetReference BrightnessPointer
		{
			get => GetProperty(ref _brightnessPointer);
			set => SetProperty(ref _brightnessPointer, value);
		}

		[Ordinal(62)] 
		[RED("modeChangeBack")] 
		public inkWidgetReference ModeChangeBack
		{
			get => GetProperty(ref _modeChangeBack);
			set => SetProperty(ref _modeChangeBack, value);
		}

		[Ordinal(63)] 
		[RED("modeChangeNext")] 
		public inkWidgetReference ModeChangeNext
		{
			get => GetProperty(ref _modeChangeNext);
			set => SetProperty(ref _modeChangeNext, value);
		}

		[Ordinal(64)] 
		[RED("applyContainerWidget")] 
		public inkWidgetReference ApplyContainerWidget
		{
			get => GetProperty(ref _applyContainerWidget);
			set => SetProperty(ref _applyContainerWidget, value);
		}

		[Ordinal(65)] 
		[RED("resetContainerWidget")] 
		public inkWidgetReference ResetContainerWidget
		{
			get => GetProperty(ref _resetContainerWidget);
			set => SetProperty(ref _resetContainerWidget, value);
		}

		[Ordinal(66)] 
		[RED("vehicleUnknownPane")] 
		public inkWidgetReference VehicleUnknownPane
		{
			get => GetProperty(ref _vehicleUnknownPane);
			set => SetProperty(ref _vehicleUnknownPane, value);
		}

		[Ordinal(67)] 
		[RED("vehicleBrandIcon")] 
		public inkImageWidgetReference VehicleBrandIcon
		{
			get => GetProperty(ref _vehicleBrandIcon);
			set => SetProperty(ref _vehicleBrandIcon, value);
		}

		[Ordinal(68)] 
		[RED("crackedCarGlitchMinimumInterval")] 
		public CFloat CrackedCarGlitchMinimumInterval
		{
			get => GetProperty(ref _crackedCarGlitchMinimumInterval);
			set => SetProperty(ref _crackedCarGlitchMinimumInterval, value);
		}

		[Ordinal(69)] 
		[RED("crackedCarGlitchMaximumInterval")] 
		public CFloat CrackedCarGlitchMaximumInterval
		{
			get => GetProperty(ref _crackedCarGlitchMaximumInterval);
			set => SetProperty(ref _crackedCarGlitchMaximumInterval, value);
		}

		[Ordinal(70)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetProperty(ref _vehicleNameText);
			set => SetProperty(ref _vehicleNameText, value);
		}

		[Ordinal(71)] 
		[RED("templatePreviewLibraryRef")] 
		public inkWidgetLibraryReference TemplatePreviewLibraryRef
		{
			get => GetProperty(ref _templatePreviewLibraryRef);
			set => SetProperty(ref _templatePreviewLibraryRef, value);
		}

		[Ordinal(72)] 
		[RED("uniqueColorPanel")] 
		public inkWidgetReference UniqueColorPanel
		{
			get => GetProperty(ref _uniqueColorPanel);
			set => SetProperty(ref _uniqueColorPanel, value);
		}

		[Ordinal(73)] 
		[RED("uniqueColorErrorPanel")] 
		public inkWidgetReference UniqueColorErrorPanel
		{
			get => GetProperty(ref _uniqueColorErrorPanel);
			set => SetProperty(ref _uniqueColorErrorPanel, value);
		}

		[Ordinal(74)] 
		[RED("genericPatternsGrid")] 
		public inkVirtualCompoundWidgetReference GenericPatternsGrid
		{
			get => GetProperty(ref _genericPatternsGrid);
			set => SetProperty(ref _genericPatternsGrid, value);
		}

		[Ordinal(75)] 
		[RED("uniquePatternsGrid")] 
		public inkVirtualCompoundWidgetReference UniquePatternsGrid
		{
			get => GetProperty(ref _uniquePatternsGrid);
			set => SetProperty(ref _uniquePatternsGrid, value);
		}

		[Ordinal(76)] 
		[RED("saveProfileHint")] 
		public inkWidgetReference SaveProfileHint
		{
			get => GetProperty(ref _saveProfileHint);
			set => SetProperty(ref _saveProfileHint, value);
		}

		[Ordinal(77)] 
		[RED("deleteProfileHint")] 
		public inkWidgetReference DeleteProfileHint
		{
			get => GetProperty(ref _deleteProfileHint);
			set => SetProperty(ref _deleteProfileHint, value);
		}

		[Ordinal(78)] 
		[RED("popupData")] 
		public CHandle<inkGameNotificationData> PopupData
		{
			get => GetProperty(ref _popupData);
			set => SetProperty(ref _popupData, value);
		}

		[Ordinal(79)] 
		[RED("systemRequestsHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemRequestsHandler
		{
			get => GetProperty(ref _systemRequestsHandler);
			set => SetProperty(ref _systemRequestsHandler, value);
		}

		[Ordinal(80)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(81)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(82)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetProperty(ref _timeSystem);
			set => SetProperty(ref _timeSystem, value);
		}

		[Ordinal(83)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(84)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(85)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetProperty(ref _fakeUpdateProxy);
			set => SetProperty(ref _fakeUpdateProxy, value);
		}

		[Ordinal(86)] 
		[RED("sbBarsProxy")] 
		public CHandle<inkanimProxy> SbBarsProxy
		{
			get => GetProperty(ref _sbBarsProxy);
			set => SetProperty(ref _sbBarsProxy, value);
		}

		[Ordinal(87)] 
		[RED("LightsFocusProxy")] 
		public CHandle<inkanimProxy> LightsFocusProxy
		{
			get => GetProperty(ref _lightsFocusProxy);
			set => SetProperty(ref _lightsFocusProxy, value);
		}

		[Ordinal(88)] 
		[RED("stickersPage")] 
		public wCHandle<inkWidget> StickersPage
		{
			get => GetProperty(ref _stickersPage);
			set => SetProperty(ref _stickersPage, value);
		}

		[Ordinal(89)] 
		[RED("isInMenuCallbackID")] 
		public CHandle<redCallbackObject> IsInMenuCallbackID
		{
			get => GetProperty(ref _isInMenuCallbackID);
			set => SetProperty(ref _isInMenuCallbackID, value);
		}

		[Ordinal(90)] 
		[RED("activeMode")] 
		public CEnum<vehicleColorSelectorActiveMode> ActiveMode
		{
			get => GetProperty(ref _activeMode);
			set => SetProperty(ref _activeMode, value);
		}

		[Ordinal(91)] 
		[RED("previousMode")] 
		public CEnum<vehicleColorSelectorActiveMode> PreviousMode
		{
			get => GetProperty(ref _previousMode);
			set => SetProperty(ref _previousMode, value);
		}

		[Ordinal(92)] 
		[RED("activeInputMode")] 
		public CEnum<vehicleColorSelectorActiveInputMode> ActiveInputMode
		{
			get => GetProperty(ref _activeInputMode);
			set => SetProperty(ref _activeInputMode, value);
		}

		[Ordinal(93)] 
		[RED("currentAngle")] 
		public CFloat CurrentAngle
		{
			get => GetProperty(ref _currentAngle);
			set => SetProperty(ref _currentAngle, value);
		}

		[Ordinal(94)] 
		[RED("colorADefined")] 
		public CBool ColorADefined
		{
			get => GetProperty(ref _colorADefined);
			set => SetProperty(ref _colorADefined, value);
		}

		[Ordinal(95)] 
		[RED("colorBDefined")] 
		public CBool ColorBDefined
		{
			get => GetProperty(ref _colorBDefined);
			set => SetProperty(ref _colorBDefined, value);
		}

		[Ordinal(96)] 
		[RED("lightsDefined")] 
		public CBool LightsDefined
		{
			get => GetProperty(ref _lightsDefined);
			set => SetProperty(ref _lightsDefined, value);
		}

		[Ordinal(97)] 
		[RED("targetColorAngleA")] 
		public CFloat TargetColorAngleA
		{
			get => GetProperty(ref _targetColorAngleA);
			set => SetProperty(ref _targetColorAngleA, value);
		}

		[Ordinal(98)] 
		[RED("targetColorAngleB")] 
		public CFloat TargetColorAngleB
		{
			get => GetProperty(ref _targetColorAngleB);
			set => SetProperty(ref _targetColorAngleB, value);
		}

		[Ordinal(99)] 
		[RED("targetColorAngleLights")] 
		public CFloat TargetColorAngleLights
		{
			get => GetProperty(ref _targetColorAngleLights);
			set => SetProperty(ref _targetColorAngleLights, value);
		}

		[Ordinal(100)] 
		[RED("targetColorASaturation")] 
		public CFloat TargetColorASaturation
		{
			get => GetProperty(ref _targetColorASaturation);
			set => SetProperty(ref _targetColorASaturation, value);
		}

		[Ordinal(101)] 
		[RED("targetColorBSaturation")] 
		public CFloat TargetColorBSaturation
		{
			get => GetProperty(ref _targetColorBSaturation);
			set => SetProperty(ref _targetColorBSaturation, value);
		}

		[Ordinal(102)] 
		[RED("targetColorABrightness")] 
		public CFloat TargetColorABrightness
		{
			get => GetProperty(ref _targetColorABrightness);
			set => SetProperty(ref _targetColorABrightness, value);
		}

		[Ordinal(103)] 
		[RED("targetColorBBrightness")] 
		public CFloat TargetColorBBrightness
		{
			get => GetProperty(ref _targetColorBBrightness);
			set => SetProperty(ref _targetColorBBrightness, value);
		}

		[Ordinal(104)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetProperty(ref _axisInputCache);
			set => SetProperty(ref _axisInputCache, value);
		}

		[Ordinal(105)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetProperty(ref _inputEnabled);
			set => SetProperty(ref _inputEnabled, value);
		}

		[Ordinal(106)] 
		[RED("sbBarsShown")] 
		public CBool SbBarsShown
		{
			get => GetProperty(ref _sbBarsShown);
			set => SetProperty(ref _sbBarsShown, value);
		}

		[Ordinal(107)] 
		[RED("sbBarsLength")] 
		public CFloat SbBarsLength
		{
			get => GetProperty(ref _sbBarsLength);
			set => SetProperty(ref _sbBarsLength, value);
		}

		[Ordinal(108)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetProperty(ref _axisInputThreshold);
			set => SetProperty(ref _axisInputThreshold, value);
		}

		[Ordinal(109)] 
		[RED("saturationPointerPosition")] 
		public CFloat SaturationPointerPosition
		{
			get => GetProperty(ref _saturationPointerPosition);
			set => SetProperty(ref _saturationPointerPosition, value);
		}

		[Ordinal(110)] 
		[RED("brightnessPointerPosition")] 
		public CFloat BrightnessPointerPosition
		{
			get => GetProperty(ref _brightnessPointerPosition);
			set => SetProperty(ref _brightnessPointerPosition, value);
		}

		[Ordinal(111)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetProperty(ref _mouseInputEnabled);
			set => SetProperty(ref _mouseInputEnabled, value);
		}

		[Ordinal(112)] 
		[RED("lightsEditingEnabled")] 
		public CBool LightsEditingEnabled
		{
			get => GetProperty(ref _lightsEditingEnabled);
			set => SetProperty(ref _lightsEditingEnabled, value);
		}

		[Ordinal(113)] 
		[RED("hasCustomRims")] 
		public CBool HasCustomRims
		{
			get => GetProperty(ref _hasCustomRims);
			set => SetProperty(ref _hasCustomRims, value);
		}

		[Ordinal(114)] 
		[RED("hasUniquePaintjobs")] 
		public CBool HasUniquePaintjobs
		{
			get => GetProperty(ref _hasUniquePaintjobs);
			set => SetProperty(ref _hasUniquePaintjobs, value);
		}

		[Ordinal(115)] 
		[RED("saturationSliderHolded")] 
		public CBool SaturationSliderHolded
		{
			get => GetProperty(ref _saturationSliderHolded);
			set => SetProperty(ref _saturationSliderHolded, value);
		}

		[Ordinal(116)] 
		[RED("brightnessSliderHolded")] 
		public CBool BrightnessSliderHolded
		{
			get => GetProperty(ref _brightnessSliderHolded);
			set => SetProperty(ref _brightnessSliderHolded, value);
		}

		[Ordinal(117)] 
		[RED("ChromaSliderStepPad")] 
		public CFloat ChromaSliderStepPad
		{
			get => GetProperty(ref _chromaSliderStepPad);
			set => SetProperty(ref _chromaSliderStepPad, value);
		}

		[Ordinal(118)] 
		[RED("ChromaSliderStepMouse")] 
		public CFloat ChromaSliderStepMouse
		{
			get => GetProperty(ref _chromaSliderStepMouse);
			set => SetProperty(ref _chromaSliderStepMouse, value);
		}

		[Ordinal(119)] 
		[RED("sliderHoldGamepad")] 
		public CBool SliderHoldGamepad
		{
			get => GetProperty(ref _sliderHoldGamepad);
			set => SetProperty(ref _sliderHoldGamepad, value);
		}

		[Ordinal(120)] 
		[RED("sliderHoldGamepadDamp")] 
		public CInt32 SliderHoldGamepadDamp
		{
			get => GetProperty(ref _sliderHoldGamepadDamp);
			set => SetProperty(ref _sliderHoldGamepadDamp, value);
		}

		[Ordinal(121)] 
		[RED("sliderPadHoldAccelerationTreshhold")] 
		public CInt32 SliderPadHoldAccelerationTreshhold
		{
			get => GetProperty(ref _sliderPadHoldAccelerationTreshhold);
			set => SetProperty(ref _sliderPadHoldAccelerationTreshhold, value);
		}

		[Ordinal(122)] 
		[RED("storedSelectedColorID")] 
		public CInt32 StoredSelectedColorID
		{
			get => GetProperty(ref _storedSelectedColorID);
			set => SetProperty(ref _storedSelectedColorID, value);
		}

		[Ordinal(123)] 
		[RED("cachedNewColorA")] 
		public CColor CachedNewColorA
		{
			get => GetProperty(ref _cachedNewColorA);
			set => SetProperty(ref _cachedNewColorA, value);
		}

		[Ordinal(124)] 
		[RED("cachedNewColorB")] 
		public CColor CachedNewColorB
		{
			get => GetProperty(ref _cachedNewColorB);
			set => SetProperty(ref _cachedNewColorB, value);
		}

		[Ordinal(125)] 
		[RED("cachedNewColorLights")] 
		public CColor CachedNewColorLights
		{
			get => GetProperty(ref _cachedNewColorLights);
			set => SetProperty(ref _cachedNewColorLights, value);
		}

		[Ordinal(126)] 
		[RED("CloseReason")] 
		public CEnum<vehicleColorSelectorMenuCloseReason> CloseReason
		{
			get => GetProperty(ref _closeReason);
			set => SetProperty(ref _closeReason, value);
		}

		[Ordinal(127)] 
		[RED("unsupportedVehicle")] 
		public CBool UnsupportedVehicle
		{
			get => GetProperty(ref _unsupportedVehicle);
			set => SetProperty(ref _unsupportedVehicle, value);
		}

		[Ordinal(128)] 
		[RED("previewDataMissing")] 
		public CBool PreviewDataMissing
		{
			get => GetProperty(ref _previewDataMissing);
			set => SetProperty(ref _previewDataMissing, value);
		}

		[Ordinal(129)] 
		[RED("virtualGenericTemplateGridController")] 
		public wCHandle<TwintoneTemplateGridController> VirtualGenericTemplateGridController
		{
			get => GetProperty(ref _virtualGenericTemplateGridController);
			set => SetProperty(ref _virtualGenericTemplateGridController, value);
		}

		[Ordinal(130)] 
		[RED("virtualUniqueTemplateGridController")] 
		public wCHandle<TwintoneTemplateGridController> VirtualUniqueTemplateGridController
		{
			get => GetProperty(ref _virtualUniqueTemplateGridController);
			set => SetProperty(ref _virtualUniqueTemplateGridController, value);
		}

		[Ordinal(131)] 
		[RED("genericGridInitialized")] 
		public CBool GenericGridInitialized
		{
			get => GetProperty(ref _genericGridInitialized);
			set => SetProperty(ref _genericGridInitialized, value);
		}

		[Ordinal(132)] 
		[RED("uniqueGridInitialized")] 
		public CBool UniqueGridInitialized
		{
			get => GetProperty(ref _uniqueGridInitialized);
			set => SetProperty(ref _uniqueGridInitialized, value);
		}

		[Ordinal(133)] 
		[RED("currentTemplate")] 
		public VehicleVisualCustomizationTemplate CurrentTemplate
		{
			get => GetProperty(ref _currentTemplate);
			set => SetProperty(ref _currentTemplate, value);
		}

		[Ordinal(134)] 
		[RED("toggledTemplate")] 
		public VehicleVisualCustomizationTemplate ToggledTemplate
		{
			get => GetProperty(ref _toggledTemplate);
			set => SetProperty(ref _toggledTemplate, value);
		}

		[Ordinal(135)] 
		[RED("currentTemplatePreview")] 
		public wCHandle<ColorTemplatePreviewDisplayController> CurrentTemplatePreview
		{
			get => GetProperty(ref _currentTemplatePreview);
			set => SetProperty(ref _currentTemplatePreview, value);
		}

		[Ordinal(136)] 
		[RED("activePanel")] 
		public CEnum<vehicleColorSelectorActiveTab> ActivePanel
		{
			get => GetProperty(ref _activePanel);
			set => SetProperty(ref _activePanel, value);
		}

		[Ordinal(137)] 
		[RED("activeSBBar")] 
		public CEnum<vehicleColorSelectorSBBar> ActiveSBBar
		{
			get => GetProperty(ref _activeSBBar);
			set => SetProperty(ref _activeSBBar, value);
		}

		[Ordinal(138)] 
		[RED("mainPanelAnimProxy")] 
		public CHandle<inkanimProxy> MainPanelAnimProxy
		{
			get => GetProperty(ref _mainPanelAnimProxy);
			set => SetProperty(ref _mainPanelAnimProxy, value);
		}

		[Ordinal(139)] 
		[RED("twintonePanelAnimProxy")] 
		public CHandle<inkanimProxy> TwintonePanelAnimProxy
		{
			get => GetProperty(ref _twintonePanelAnimProxy);
			set => SetProperty(ref _twintonePanelAnimProxy, value);
		}

		[Ordinal(140)] 
		[RED("carGlitchProxy")] 
		public CHandle<inkanimProxy> CarGlitchProxy
		{
			get => GetProperty(ref _carGlitchProxy);
			set => SetProperty(ref _carGlitchProxy, value);
		}

		[Ordinal(141)] 
		[RED("crackedAnimProxy")] 
		public CHandle<inkanimProxy> CrackedAnimProxy
		{
			get => GetProperty(ref _crackedAnimProxy);
			set => SetProperty(ref _crackedAnimProxy, value);
		}

		public vehicleColorSelectorGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
