using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapStealthMappinController : gameuiBaseMinimapMappinController
	{
		private inkImageWidgetReference _visionConeWidget;
		private wCHandle<gamemappinsStealthMappin> _stealthMappin;
		private CHandle<inkanimProxy> _fadeOutAnim;
		private CBool _isTagged;
		private CBool _wasVisible;
		private CName _mappinState;
		private CName _preventionState;
		private CBool _hasBeenLooted;
		private CBool _isAggressive;
		private CBool _detectionAboveZero;
		private CBool _isAlive;
		private CBool _wasAlive;
		private CBool _wasCompanion;
		private CBool _couldSeePlayer;
		private CBool _isPrevention;
		private CBool _isCrowdNPC;
		private CBool _cautious;
		private CBool _shouldShowVisionCone;
		private CBool _isDevice;
		private CBool _isCamera;
		private CBool _isTurret;
		private CBool _isNetrunner;
		private CBool _isHacking;
		private CBool _isSquadInCombat;
		private CBool _wasSquadInCombat;
		private CBool _clampingAvailable;
		private CFloat _defaultOpacity;
		private CFloat _adjustedOpacity;
		private CFloat _defaultConeOpacity;
		private CFloat _detectingConeOpacity;
		private CUInt32 _highestLootQuality;
		private CBool _lockLootQuality;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private wCHandle<inkWidget> _iconWidgetGlitch;
		private wCHandle<inkWidget> _visionConeWidgetGlitch;
		private wCHandle<inkWidget> _clampArrowWidgetGlitch;
		private wCHandle<gameIBlackboard> _puppetStateBlackboard;
		private CBool _isInVehicleStance;
		private CHandle<redCallbackObject> _stanceStateCb;
		private CBool _policeChasePrototypeEnabled;
		private CHandle<PreventionMinimapMappinComponent> _preventionMinimapMappinComponent;
		private CName _preventionVisionConeColor;
		private CFloat _preventionDetectionDropThreshold;
		private CBool _wasMaxDetectionReached;
		private CHandle<inkanimProxy> _showAnim;
		private CHandle<inkanimProxy> _alertedAnim;
		private CHandle<inkanimProxy> _preventionAnimProxy;

		[Ordinal(14)] 
		[RED("visionConeWidget")] 
		public inkImageWidgetReference VisionConeWidget
		{
			get => GetProperty(ref _visionConeWidget);
			set => SetProperty(ref _visionConeWidget, value);
		}

		[Ordinal(15)] 
		[RED("stealthMappin")] 
		public wCHandle<gamemappinsStealthMappin> StealthMappin
		{
			get => GetProperty(ref _stealthMappin);
			set => SetProperty(ref _stealthMappin, value);
		}

		[Ordinal(16)] 
		[RED("fadeOutAnim")] 
		public CHandle<inkanimProxy> FadeOutAnim
		{
			get => GetProperty(ref _fadeOutAnim);
			set => SetProperty(ref _fadeOutAnim, value);
		}

		[Ordinal(17)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(18)] 
		[RED("wasVisible")] 
		public CBool WasVisible
		{
			get => GetProperty(ref _wasVisible);
			set => SetProperty(ref _wasVisible, value);
		}

		[Ordinal(19)] 
		[RED("mappinState")] 
		public CName MappinState
		{
			get => GetProperty(ref _mappinState);
			set => SetProperty(ref _mappinState, value);
		}

		[Ordinal(20)] 
		[RED("preventionState")] 
		public CName PreventionState
		{
			get => GetProperty(ref _preventionState);
			set => SetProperty(ref _preventionState, value);
		}

		[Ordinal(21)] 
		[RED("hasBeenLooted")] 
		public CBool HasBeenLooted
		{
			get => GetProperty(ref _hasBeenLooted);
			set => SetProperty(ref _hasBeenLooted, value);
		}

		[Ordinal(22)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetProperty(ref _isAggressive);
			set => SetProperty(ref _isAggressive, value);
		}

		[Ordinal(23)] 
		[RED("detectionAboveZero")] 
		public CBool DetectionAboveZero
		{
			get => GetProperty(ref _detectionAboveZero);
			set => SetProperty(ref _detectionAboveZero, value);
		}

		[Ordinal(24)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(25)] 
		[RED("wasAlive")] 
		public CBool WasAlive
		{
			get => GetProperty(ref _wasAlive);
			set => SetProperty(ref _wasAlive, value);
		}

		[Ordinal(26)] 
		[RED("wasCompanion")] 
		public CBool WasCompanion
		{
			get => GetProperty(ref _wasCompanion);
			set => SetProperty(ref _wasCompanion, value);
		}

		[Ordinal(27)] 
		[RED("couldSeePlayer")] 
		public CBool CouldSeePlayer
		{
			get => GetProperty(ref _couldSeePlayer);
			set => SetProperty(ref _couldSeePlayer, value);
		}

		[Ordinal(28)] 
		[RED("isPrevention")] 
		public CBool IsPrevention
		{
			get => GetProperty(ref _isPrevention);
			set => SetProperty(ref _isPrevention, value);
		}

		[Ordinal(29)] 
		[RED("isCrowdNPC")] 
		public CBool IsCrowdNPC
		{
			get => GetProperty(ref _isCrowdNPC);
			set => SetProperty(ref _isCrowdNPC, value);
		}

		[Ordinal(30)] 
		[RED("cautious")] 
		public CBool Cautious
		{
			get => GetProperty(ref _cautious);
			set => SetProperty(ref _cautious, value);
		}

		[Ordinal(31)] 
		[RED("shouldShowVisionCone")] 
		public CBool ShouldShowVisionCone
		{
			get => GetProperty(ref _shouldShowVisionCone);
			set => SetProperty(ref _shouldShowVisionCone, value);
		}

		[Ordinal(32)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetProperty(ref _isDevice);
			set => SetProperty(ref _isDevice, value);
		}

		[Ordinal(33)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetProperty(ref _isCamera);
			set => SetProperty(ref _isCamera, value);
		}

		[Ordinal(34)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetProperty(ref _isTurret);
			set => SetProperty(ref _isTurret, value);
		}

		[Ordinal(35)] 
		[RED("isNetrunner")] 
		public CBool IsNetrunner
		{
			get => GetProperty(ref _isNetrunner);
			set => SetProperty(ref _isNetrunner, value);
		}

		[Ordinal(36)] 
		[RED("isHacking")] 
		public CBool IsHacking
		{
			get => GetProperty(ref _isHacking);
			set => SetProperty(ref _isHacking, value);
		}

		[Ordinal(37)] 
		[RED("isSquadInCombat")] 
		public CBool IsSquadInCombat
		{
			get => GetProperty(ref _isSquadInCombat);
			set => SetProperty(ref _isSquadInCombat, value);
		}

		[Ordinal(38)] 
		[RED("wasSquadInCombat")] 
		public CBool WasSquadInCombat
		{
			get => GetProperty(ref _wasSquadInCombat);
			set => SetProperty(ref _wasSquadInCombat, value);
		}

		[Ordinal(39)] 
		[RED("clampingAvailable")] 
		public CBool ClampingAvailable
		{
			get => GetProperty(ref _clampingAvailable);
			set => SetProperty(ref _clampingAvailable, value);
		}

		[Ordinal(40)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetProperty(ref _defaultOpacity);
			set => SetProperty(ref _defaultOpacity, value);
		}

		[Ordinal(41)] 
		[RED("adjustedOpacity")] 
		public CFloat AdjustedOpacity
		{
			get => GetProperty(ref _adjustedOpacity);
			set => SetProperty(ref _adjustedOpacity, value);
		}

		[Ordinal(42)] 
		[RED("defaultConeOpacity")] 
		public CFloat DefaultConeOpacity
		{
			get => GetProperty(ref _defaultConeOpacity);
			set => SetProperty(ref _defaultConeOpacity, value);
		}

		[Ordinal(43)] 
		[RED("detectingConeOpacity")] 
		public CFloat DetectingConeOpacity
		{
			get => GetProperty(ref _detectingConeOpacity);
			set => SetProperty(ref _detectingConeOpacity, value);
		}

		[Ordinal(44)] 
		[RED("highestLootQuality")] 
		public CUInt32 HighestLootQuality
		{
			get => GetProperty(ref _highestLootQuality);
			set => SetProperty(ref _highestLootQuality, value);
		}

		[Ordinal(45)] 
		[RED("lockLootQuality")] 
		public CBool LockLootQuality
		{
			get => GetProperty(ref _lockLootQuality);
			set => SetProperty(ref _lockLootQuality, value);
		}

		[Ordinal(46)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(47)] 
		[RED("iconWidgetGlitch")] 
		public wCHandle<inkWidget> IconWidgetGlitch
		{
			get => GetProperty(ref _iconWidgetGlitch);
			set => SetProperty(ref _iconWidgetGlitch, value);
		}

		[Ordinal(48)] 
		[RED("visionConeWidgetGlitch")] 
		public wCHandle<inkWidget> VisionConeWidgetGlitch
		{
			get => GetProperty(ref _visionConeWidgetGlitch);
			set => SetProperty(ref _visionConeWidgetGlitch, value);
		}

		[Ordinal(49)] 
		[RED("clampArrowWidgetGlitch")] 
		public wCHandle<inkWidget> ClampArrowWidgetGlitch
		{
			get => GetProperty(ref _clampArrowWidgetGlitch);
			set => SetProperty(ref _clampArrowWidgetGlitch, value);
		}

		[Ordinal(50)] 
		[RED("puppetStateBlackboard")] 
		public wCHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetProperty(ref _puppetStateBlackboard);
			set => SetProperty(ref _puppetStateBlackboard, value);
		}

		[Ordinal(51)] 
		[RED("isInVehicleStance")] 
		public CBool IsInVehicleStance
		{
			get => GetProperty(ref _isInVehicleStance);
			set => SetProperty(ref _isInVehicleStance, value);
		}

		[Ordinal(52)] 
		[RED("stanceStateCb")] 
		public CHandle<redCallbackObject> StanceStateCb
		{
			get => GetProperty(ref _stanceStateCb);
			set => SetProperty(ref _stanceStateCb, value);
		}

		[Ordinal(53)] 
		[RED("policeChasePrototypeEnabled")] 
		public CBool PoliceChasePrototypeEnabled
		{
			get => GetProperty(ref _policeChasePrototypeEnabled);
			set => SetProperty(ref _policeChasePrototypeEnabled, value);
		}

		[Ordinal(54)] 
		[RED("preventionMinimapMappinComponent")] 
		public CHandle<PreventionMinimapMappinComponent> PreventionMinimapMappinComponent
		{
			get => GetProperty(ref _preventionMinimapMappinComponent);
			set => SetProperty(ref _preventionMinimapMappinComponent, value);
		}

		[Ordinal(55)] 
		[RED("preventionVisionConeColor")] 
		public CName PreventionVisionConeColor
		{
			get => GetProperty(ref _preventionVisionConeColor);
			set => SetProperty(ref _preventionVisionConeColor, value);
		}

		[Ordinal(56)] 
		[RED("preventionDetectionDropThreshold")] 
		public CFloat PreventionDetectionDropThreshold
		{
			get => GetProperty(ref _preventionDetectionDropThreshold);
			set => SetProperty(ref _preventionDetectionDropThreshold, value);
		}

		[Ordinal(57)] 
		[RED("wasMaxDetectionReached")] 
		public CBool WasMaxDetectionReached
		{
			get => GetProperty(ref _wasMaxDetectionReached);
			set => SetProperty(ref _wasMaxDetectionReached, value);
		}

		[Ordinal(58)] 
		[RED("showAnim")] 
		public CHandle<inkanimProxy> ShowAnim
		{
			get => GetProperty(ref _showAnim);
			set => SetProperty(ref _showAnim, value);
		}

		[Ordinal(59)] 
		[RED("alertedAnim")] 
		public CHandle<inkanimProxy> AlertedAnim
		{
			get => GetProperty(ref _alertedAnim);
			set => SetProperty(ref _alertedAnim, value);
		}

		[Ordinal(60)] 
		[RED("preventionAnimProxy")] 
		public CHandle<inkanimProxy> PreventionAnimProxy
		{
			get => GetProperty(ref _preventionAnimProxy);
			set => SetProperty(ref _preventionAnimProxy, value);
		}

		public gameuiMinimapStealthMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
