using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDriverCombatHUDGameController : gameuiHUDGameController
	{
		private CBool _inWeaponizedVehicle;
		private CBool _inDriverCombat;
		private CBool _inReloadState;
		private CBool _inSafeState;
		private inkWidgetReference _crosshairBrackets;
		private inkWidgetReference _crosshairBracketsFlairLeft;
		private inkWidgetReference _crosshairBracketsFlairRight;
		private CArray<inkWidgetReference> _bracketsTransitionDetailsWidgetList;
		private Vector2 _crosshairBracketsMinSize;
		private CFloat _crosshairBracketsInstantSnapValue;
		private CFloat _crosshairBracketsInOutTransitionTime;
		private CFloat _crosshairBracketsIntroSizeMultiplier;
		private inkWidgetReference _crosshairBracketsTrail;
		private CFloat _crosshairBracketsTrailTransitionTime;
		private CFloat _crosshairReducedOpacity;
		private CFloat _unifomSafeZone;
		private wCHandle<gameObject> _player;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CHandle<redCallbackObject> _psmWeaponCallback;
		private CHandle<redCallbackObject> _uiActiveVehicleFPPRearviewCameraActivatedCallback;
		private CHandle<inkanimProxy> _reloadingAnimProxy;
		private inkWidgetReference _vehicleFPPRearviewCamera;
		private inkImageWidgetReference _vehicleManufacturer;
		private inkTextWidgetReference _debugTuningStatusText;

		[Ordinal(9)] 
		[RED("inWeaponizedVehicle")] 
		public CBool InWeaponizedVehicle
		{
			get => GetProperty(ref _inWeaponizedVehicle);
			set => SetProperty(ref _inWeaponizedVehicle, value);
		}

		[Ordinal(10)] 
		[RED("inDriverCombat")] 
		public CBool InDriverCombat
		{
			get => GetProperty(ref _inDriverCombat);
			set => SetProperty(ref _inDriverCombat, value);
		}

		[Ordinal(11)] 
		[RED("inReloadState")] 
		public CBool InReloadState
		{
			get => GetProperty(ref _inReloadState);
			set => SetProperty(ref _inReloadState, value);
		}

		[Ordinal(12)] 
		[RED("inSafeState")] 
		public CBool InSafeState
		{
			get => GetProperty(ref _inSafeState);
			set => SetProperty(ref _inSafeState, value);
		}

		[Ordinal(13)] 
		[RED("crosshairBrackets")] 
		public inkWidgetReference CrosshairBrackets
		{
			get => GetProperty(ref _crosshairBrackets);
			set => SetProperty(ref _crosshairBrackets, value);
		}

		[Ordinal(14)] 
		[RED("crosshairBracketsFlairLeft")] 
		public inkWidgetReference CrosshairBracketsFlairLeft
		{
			get => GetProperty(ref _crosshairBracketsFlairLeft);
			set => SetProperty(ref _crosshairBracketsFlairLeft, value);
		}

		[Ordinal(15)] 
		[RED("crosshairBracketsFlairRight")] 
		public inkWidgetReference CrosshairBracketsFlairRight
		{
			get => GetProperty(ref _crosshairBracketsFlairRight);
			set => SetProperty(ref _crosshairBracketsFlairRight, value);
		}

		[Ordinal(16)] 
		[RED("bracketsTransitionDetailsWidgetList")] 
		public CArray<inkWidgetReference> BracketsTransitionDetailsWidgetList
		{
			get => GetProperty(ref _bracketsTransitionDetailsWidgetList);
			set => SetProperty(ref _bracketsTransitionDetailsWidgetList, value);
		}

		[Ordinal(17)] 
		[RED("crosshairBracketsMinSize")] 
		public Vector2 CrosshairBracketsMinSize
		{
			get => GetProperty(ref _crosshairBracketsMinSize);
			set => SetProperty(ref _crosshairBracketsMinSize, value);
		}

		[Ordinal(18)] 
		[RED("crosshairBracketsInstantSnapValue")] 
		public CFloat CrosshairBracketsInstantSnapValue
		{
			get => GetProperty(ref _crosshairBracketsInstantSnapValue);
			set => SetProperty(ref _crosshairBracketsInstantSnapValue, value);
		}

		[Ordinal(19)] 
		[RED("crosshairBracketsInOutTransitionTime")] 
		public CFloat CrosshairBracketsInOutTransitionTime
		{
			get => GetProperty(ref _crosshairBracketsInOutTransitionTime);
			set => SetProperty(ref _crosshairBracketsInOutTransitionTime, value);
		}

		[Ordinal(20)] 
		[RED("crosshairBracketsIntroSizeMultiplier")] 
		public CFloat CrosshairBracketsIntroSizeMultiplier
		{
			get => GetProperty(ref _crosshairBracketsIntroSizeMultiplier);
			set => SetProperty(ref _crosshairBracketsIntroSizeMultiplier, value);
		}

		[Ordinal(21)] 
		[RED("crosshairBracketsTrail")] 
		public inkWidgetReference CrosshairBracketsTrail
		{
			get => GetProperty(ref _crosshairBracketsTrail);
			set => SetProperty(ref _crosshairBracketsTrail, value);
		}

		[Ordinal(22)] 
		[RED("crosshairBracketsTrailTransitionTime")] 
		public CFloat CrosshairBracketsTrailTransitionTime
		{
			get => GetProperty(ref _crosshairBracketsTrailTransitionTime);
			set => SetProperty(ref _crosshairBracketsTrailTransitionTime, value);
		}

		[Ordinal(23)] 
		[RED("crosshairReducedOpacity")] 
		public CFloat CrosshairReducedOpacity
		{
			get => GetProperty(ref _crosshairReducedOpacity);
			set => SetProperty(ref _crosshairReducedOpacity, value);
		}

		[Ordinal(24)] 
		[RED("unifomSafeZone")] 
		public CFloat UnifomSafeZone
		{
			get => GetProperty(ref _unifomSafeZone);
			set => SetProperty(ref _unifomSafeZone, value);
		}

		[Ordinal(25)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(26)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(27)] 
		[RED("psmWeaponCallback")] 
		public CHandle<redCallbackObject> PsmWeaponCallback
		{
			get => GetProperty(ref _psmWeaponCallback);
			set => SetProperty(ref _psmWeaponCallback, value);
		}

		[Ordinal(28)] 
		[RED("uiActiveVehicleFPPRearviewCameraActivatedCallback")] 
		public CHandle<redCallbackObject> UiActiveVehicleFPPRearviewCameraActivatedCallback
		{
			get => GetProperty(ref _uiActiveVehicleFPPRearviewCameraActivatedCallback);
			set => SetProperty(ref _uiActiveVehicleFPPRearviewCameraActivatedCallback, value);
		}

		[Ordinal(29)] 
		[RED("reloadingAnimProxy")] 
		public CHandle<inkanimProxy> ReloadingAnimProxy
		{
			get => GetProperty(ref _reloadingAnimProxy);
			set => SetProperty(ref _reloadingAnimProxy, value);
		}

		[Ordinal(30)] 
		[RED("vehicleFPPRearviewCamera")] 
		public inkWidgetReference VehicleFPPRearviewCamera
		{
			get => GetProperty(ref _vehicleFPPRearviewCamera);
			set => SetProperty(ref _vehicleFPPRearviewCamera, value);
		}

		[Ordinal(31)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetProperty(ref _vehicleManufacturer);
			set => SetProperty(ref _vehicleManufacturer, value);
		}

		[Ordinal(32)] 
		[RED("debugTuningStatusText")] 
		public inkTextWidgetReference DebugTuningStatusText
		{
			get => GetProperty(ref _debugTuningStatusText);
			set => SetProperty(ref _debugTuningStatusText, value);
		}

		public gameuiDriverCombatHUDGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
