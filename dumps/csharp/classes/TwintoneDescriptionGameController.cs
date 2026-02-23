using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TwintoneDescriptionGameController : BaseChunkGameController
	{
		private inkWidgetReference _cursorRootContainerRef;
		private inkWidgetReference _paintjobInterface;
		private inkWidgetReference _restrictedPaintjobInterface;
		private inkVideoWidgetReference _videoHeaderRef;
		private inkWidgetReference _videoGroupRef;
		private redResourceReferenceScriptToken _defaultVideoLoop;
		private redResourceReferenceScriptToken _thanksVideo;
		private inkImageWidgetReference _vehicleManufacturer;
		private inkWidgetReference _applicableGroupRef;
		private inkTextWidgetReference _buyButtonText;
		private inkTextWidgetReference _applicableModelNamesText;
		private inkTextWidgetReference _templateTypeText;
		private inkTextWidgetReference _priceText;
		private inkTextWidgetReference _profileNotAvailableText;
		private inkWidgetReference _colorTemplatePreviewContainer;
		private CUInt32 _c_progressBarDuration;
		private CUInt32 _c_progressBarUpdateRate;
		private wCHandle<ColorTemplatePreviewDisplayController> _colorTemplatePreview;
		private CHandle<redCallbackObject> _vehicleCustomizationChangedCallbackID;
		private CHandle<redCallbackObject> _vehicleManufacturerCallbackID;
		private CHandle<redCallbackObject> _playerMountedCallbackID;
		private CHandle<redCallbackObject> _scannerModeChangedCallbackID;
		private CHandle<redCallbackObject> _activeTabChangedCallbackID;
		private gameDelayID _progressBarDelayID;
		private VehicleVisualCustomizationTemplate _scannedVehicleTemplate;
		private CName _scannedModelName;
		private VehicleVisualCustomizationTemplate _cachedVehicleTemplate;
		private CName _cachedModelName;
		private CBool _isScanInProgress;
		private wCHandle<gameIBlackboard> _blackboardUI;
		private ScriptGameInstance _game;
		private CHandle<vehicleVisualCustomizationComponent> _playerVVCComponent;
		private CHandle<inkanimProxy> _progressBarUpdateProxy;
		private CFloat _progressBarCounter;
		private CHandle<inkanimProxy> _buyAnimationProxy;
		private CBool _twintoneVisible;
		private CBool _scanAvailable;
		private CBool _applyAvailable;
		private CBool _applyAfterSave;
		private CBool _endAnimationCancelled;

		[Ordinal(5)] 
		[RED("cursorRootContainerRef")] 
		public inkWidgetReference CursorRootContainerRef
		{
			get => GetProperty(ref _cursorRootContainerRef);
			set => SetProperty(ref _cursorRootContainerRef, value);
		}

		[Ordinal(6)] 
		[RED("paintjobInterface")] 
		public inkWidgetReference PaintjobInterface
		{
			get => GetProperty(ref _paintjobInterface);
			set => SetProperty(ref _paintjobInterface, value);
		}

		[Ordinal(7)] 
		[RED("restrictedPaintjobInterface")] 
		public inkWidgetReference RestrictedPaintjobInterface
		{
			get => GetProperty(ref _restrictedPaintjobInterface);
			set => SetProperty(ref _restrictedPaintjobInterface, value);
		}

		[Ordinal(8)] 
		[RED("videoHeaderRef")] 
		public inkVideoWidgetReference VideoHeaderRef
		{
			get => GetProperty(ref _videoHeaderRef);
			set => SetProperty(ref _videoHeaderRef, value);
		}

		[Ordinal(9)] 
		[RED("videoGroupRef")] 
		public inkWidgetReference VideoGroupRef
		{
			get => GetProperty(ref _videoGroupRef);
			set => SetProperty(ref _videoGroupRef, value);
		}

		[Ordinal(10)] 
		[RED("defaultVideoLoop")] 
		public redResourceReferenceScriptToken DefaultVideoLoop
		{
			get => GetProperty(ref _defaultVideoLoop);
			set => SetProperty(ref _defaultVideoLoop, value);
		}

		[Ordinal(11)] 
		[RED("thanksVideo")] 
		public redResourceReferenceScriptToken ThanksVideo
		{
			get => GetProperty(ref _thanksVideo);
			set => SetProperty(ref _thanksVideo, value);
		}

		[Ordinal(12)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetProperty(ref _vehicleManufacturer);
			set => SetProperty(ref _vehicleManufacturer, value);
		}

		[Ordinal(13)] 
		[RED("applicableGroupRef")] 
		public inkWidgetReference ApplicableGroupRef
		{
			get => GetProperty(ref _applicableGroupRef);
			set => SetProperty(ref _applicableGroupRef, value);
		}

		[Ordinal(14)] 
		[RED("buyButtonText")] 
		public inkTextWidgetReference BuyButtonText
		{
			get => GetProperty(ref _buyButtonText);
			set => SetProperty(ref _buyButtonText, value);
		}

		[Ordinal(15)] 
		[RED("applicableModelNamesText")] 
		public inkTextWidgetReference ApplicableModelNamesText
		{
			get => GetProperty(ref _applicableModelNamesText);
			set => SetProperty(ref _applicableModelNamesText, value);
		}

		[Ordinal(16)] 
		[RED("templateTypeText")] 
		public inkTextWidgetReference TemplateTypeText
		{
			get => GetProperty(ref _templateTypeText);
			set => SetProperty(ref _templateTypeText, value);
		}

		[Ordinal(17)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(18)] 
		[RED("profileNotAvailableText")] 
		public inkTextWidgetReference ProfileNotAvailableText
		{
			get => GetProperty(ref _profileNotAvailableText);
			set => SetProperty(ref _profileNotAvailableText, value);
		}

		[Ordinal(19)] 
		[RED("colorTemplatePreviewContainer")] 
		public inkWidgetReference ColorTemplatePreviewContainer
		{
			get => GetProperty(ref _colorTemplatePreviewContainer);
			set => SetProperty(ref _colorTemplatePreviewContainer, value);
		}

		[Ordinal(20)] 
		[RED("c_progressBarDuration")] 
		public CUInt32 C_progressBarDuration
		{
			get => GetProperty(ref _c_progressBarDuration);
			set => SetProperty(ref _c_progressBarDuration, value);
		}

		[Ordinal(21)] 
		[RED("c_progressBarUpdateRate")] 
		public CUInt32 C_progressBarUpdateRate
		{
			get => GetProperty(ref _c_progressBarUpdateRate);
			set => SetProperty(ref _c_progressBarUpdateRate, value);
		}

		[Ordinal(22)] 
		[RED("colorTemplatePreview")] 
		public wCHandle<ColorTemplatePreviewDisplayController> ColorTemplatePreview
		{
			get => GetProperty(ref _colorTemplatePreview);
			set => SetProperty(ref _colorTemplatePreview, value);
		}

		[Ordinal(23)] 
		[RED("vehicleCustomizationChangedCallbackID")] 
		public CHandle<redCallbackObject> VehicleCustomizationChangedCallbackID
		{
			get => GetProperty(ref _vehicleCustomizationChangedCallbackID);
			set => SetProperty(ref _vehicleCustomizationChangedCallbackID, value);
		}

		[Ordinal(24)] 
		[RED("vehicleManufacturerCallbackID")] 
		public CHandle<redCallbackObject> VehicleManufacturerCallbackID
		{
			get => GetProperty(ref _vehicleManufacturerCallbackID);
			set => SetProperty(ref _vehicleManufacturerCallbackID, value);
		}

		[Ordinal(25)] 
		[RED("playerMountedCallbackID")] 
		public CHandle<redCallbackObject> PlayerMountedCallbackID
		{
			get => GetProperty(ref _playerMountedCallbackID);
			set => SetProperty(ref _playerMountedCallbackID, value);
		}

		[Ordinal(26)] 
		[RED("scannerModeChangedCallbackID")] 
		public CHandle<redCallbackObject> ScannerModeChangedCallbackID
		{
			get => GetProperty(ref _scannerModeChangedCallbackID);
			set => SetProperty(ref _scannerModeChangedCallbackID, value);
		}

		[Ordinal(27)] 
		[RED("activeTabChangedCallbackID")] 
		public CHandle<redCallbackObject> ActiveTabChangedCallbackID
		{
			get => GetProperty(ref _activeTabChangedCallbackID);
			set => SetProperty(ref _activeTabChangedCallbackID, value);
		}

		[Ordinal(28)] 
		[RED("progressBarDelayID")] 
		public gameDelayID ProgressBarDelayID
		{
			get => GetProperty(ref _progressBarDelayID);
			set => SetProperty(ref _progressBarDelayID, value);
		}

		[Ordinal(29)] 
		[RED("scannedVehicleTemplate")] 
		public VehicleVisualCustomizationTemplate ScannedVehicleTemplate
		{
			get => GetProperty(ref _scannedVehicleTemplate);
			set => SetProperty(ref _scannedVehicleTemplate, value);
		}

		[Ordinal(30)] 
		[RED("scannedModelName")] 
		public CName ScannedModelName
		{
			get => GetProperty(ref _scannedModelName);
			set => SetProperty(ref _scannedModelName, value);
		}

		[Ordinal(31)] 
		[RED("cachedVehicleTemplate")] 
		public VehicleVisualCustomizationTemplate CachedVehicleTemplate
		{
			get => GetProperty(ref _cachedVehicleTemplate);
			set => SetProperty(ref _cachedVehicleTemplate, value);
		}

		[Ordinal(32)] 
		[RED("cachedModelName")] 
		public CName CachedModelName
		{
			get => GetProperty(ref _cachedModelName);
			set => SetProperty(ref _cachedModelName, value);
		}

		[Ordinal(33)] 
		[RED("isScanInProgress")] 
		public CBool IsScanInProgress
		{
			get => GetProperty(ref _isScanInProgress);
			set => SetProperty(ref _isScanInProgress, value);
		}

		[Ordinal(34)] 
		[RED("blackboardUI")] 
		public wCHandle<gameIBlackboard> BlackboardUI
		{
			get => GetProperty(ref _blackboardUI);
			set => SetProperty(ref _blackboardUI, value);
		}

		[Ordinal(35)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(36)] 
		[RED("playerVVCComponent")] 
		public CHandle<vehicleVisualCustomizationComponent> PlayerVVCComponent
		{
			get => GetProperty(ref _playerVVCComponent);
			set => SetProperty(ref _playerVVCComponent, value);
		}

		[Ordinal(37)] 
		[RED("progressBarUpdateProxy")] 
		public CHandle<inkanimProxy> ProgressBarUpdateProxy
		{
			get => GetProperty(ref _progressBarUpdateProxy);
			set => SetProperty(ref _progressBarUpdateProxy, value);
		}

		[Ordinal(38)] 
		[RED("progressBarCounter")] 
		public CFloat ProgressBarCounter
		{
			get => GetProperty(ref _progressBarCounter);
			set => SetProperty(ref _progressBarCounter, value);
		}

		[Ordinal(39)] 
		[RED("buyAnimationProxy")] 
		public CHandle<inkanimProxy> BuyAnimationProxy
		{
			get => GetProperty(ref _buyAnimationProxy);
			set => SetProperty(ref _buyAnimationProxy, value);
		}

		[Ordinal(40)] 
		[RED("twintoneVisible")] 
		public CBool TwintoneVisible
		{
			get => GetProperty(ref _twintoneVisible);
			set => SetProperty(ref _twintoneVisible, value);
		}

		[Ordinal(41)] 
		[RED("scanAvailable")] 
		public CBool ScanAvailable
		{
			get => GetProperty(ref _scanAvailable);
			set => SetProperty(ref _scanAvailable, value);
		}

		[Ordinal(42)] 
		[RED("applyAvailable")] 
		public CBool ApplyAvailable
		{
			get => GetProperty(ref _applyAvailable);
			set => SetProperty(ref _applyAvailable, value);
		}

		[Ordinal(43)] 
		[RED("applyAfterSave")] 
		public CBool ApplyAfterSave
		{
			get => GetProperty(ref _applyAfterSave);
			set => SetProperty(ref _applyAfterSave, value);
		}

		[Ordinal(44)] 
		[RED("endAnimationCancelled")] 
		public CBool EndAnimationCancelled
		{
			get => GetProperty(ref _endAnimationCancelled);
			set => SetProperty(ref _endAnimationCancelled, value);
		}

		public TwintoneDescriptionGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
