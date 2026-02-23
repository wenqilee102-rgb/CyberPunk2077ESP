using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleComponent : ScriptableDeviceComponent
	{
		private CHandle<gameinteractionsComponent> _interaction;
		private CHandle<gameScanningComponent> _scanningComponent;
		private CHandle<vehicleVehicleCustomization> _customizationComponent;
		private CInt32 _damageLevel;
		private CBool _coolerDestro;
		private CInt32 _bumperFrontState;
		private CInt32 _bumperBackState;
		private CBool _visualDestructionSet;
		private CBool _immuneInDecay;
		private CFloat _healthDecayThreshold;
		private CBool _isBroadcastingHazardStims;
		private CHandle<VehicleHealthStatPoolListener> _healthStatPoolListener;
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CBool _radioState;
		private CBool _mounted;
		private CFloat _enterTime;
		private gameNewMappinID _mappinID;
		private gameNewMappinID _quickhackMappinID;
		private CBool _ignoreAutoDoorClose;
		private CBool _mappinDestroyedBeforeCreation;
		private CUInt32 _timeSystemCallbackID;
		private CHandle<redCallbackObject> _vehicleTPPCallbackID;
		private CHandle<redCallbackObject> _vehicleSpeedCallbackID;
		private CHandle<redCallbackObject> _carAlarmCallbackID;
		private CHandle<redCallbackObject> _vehicleRPMCallbackID;
		private gameDelayID _vehicleDisableAlarmDelayID;
		private gameDelayID _vehicleExitDelayId;
		private CBool _broadcasting;
		private CBool _hasSpoiler;
		private CFloat _spoilerUp;
		private CFloat _spoilerDown;
		private CBool _spoilerDeployed;
		private CBool _hasTurboCharger;
		private CHandle<worldEffectBlackboard> _overheatEffectBlackboard;
		private CBool _overheatActive;
		private CBool _hornOn;
		private CBool _useAuxiliary;
		private CFloat _sirenPressTime;
		private CFloat _radioPressTime;
		private gameDelayID _raceClockTickID;
		private CHandle<gameObjectActionsCallbackController> _objectActionsCallbackCtrl;
		private wCHandle<gameObject> _trunkNpcBody;
		private wCHandle<PlayerPuppet> _mountedPlayer;
		private CBool _isIgnoredInTargetingSystem;
		private CBool _arePlayerHitShapesEnabled;
		private wCHandle<gameIBlackboard> _uiWantedBarBB;
		private CHandle<redCallbackObject> _currentWantedLevelCallback;
		private CInt32 _preventionPassengers;
		private CFloat _timeSinceLastHit;
		private CFloat _dragTime;
		private CHandle<vehicleController> _vehicleController;

		[Ordinal(4)] 
		[RED("interaction")] 
		public CHandle<gameinteractionsComponent> Interaction
		{
			get => GetProperty(ref _interaction);
			set => SetProperty(ref _interaction, value);
		}

		[Ordinal(5)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get => GetProperty(ref _scanningComponent);
			set => SetProperty(ref _scanningComponent, value);
		}

		[Ordinal(6)] 
		[RED("customizationComponent")] 
		public CHandle<vehicleVehicleCustomization> CustomizationComponent
		{
			get => GetProperty(ref _customizationComponent);
			set => SetProperty(ref _customizationComponent, value);
		}

		[Ordinal(7)] 
		[RED("damageLevel")] 
		public CInt32 DamageLevel
		{
			get => GetProperty(ref _damageLevel);
			set => SetProperty(ref _damageLevel, value);
		}

		[Ordinal(8)] 
		[RED("coolerDestro")] 
		public CBool CoolerDestro
		{
			get => GetProperty(ref _coolerDestro);
			set => SetProperty(ref _coolerDestro, value);
		}

		[Ordinal(9)] 
		[RED("bumperFrontState")] 
		public CInt32 BumperFrontState
		{
			get => GetProperty(ref _bumperFrontState);
			set => SetProperty(ref _bumperFrontState, value);
		}

		[Ordinal(10)] 
		[RED("bumperBackState")] 
		public CInt32 BumperBackState
		{
			get => GetProperty(ref _bumperBackState);
			set => SetProperty(ref _bumperBackState, value);
		}

		[Ordinal(11)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetProperty(ref _visualDestructionSet);
			set => SetProperty(ref _visualDestructionSet, value);
		}

		[Ordinal(12)] 
		[RED("immuneInDecay")] 
		public CBool ImmuneInDecay
		{
			get => GetProperty(ref _immuneInDecay);
			set => SetProperty(ref _immuneInDecay, value);
		}

		[Ordinal(13)] 
		[RED("healthDecayThreshold")] 
		public CFloat HealthDecayThreshold
		{
			get => GetProperty(ref _healthDecayThreshold);
			set => SetProperty(ref _healthDecayThreshold, value);
		}

		[Ordinal(14)] 
		[RED("isBroadcastingHazardStims")] 
		public CBool IsBroadcastingHazardStims
		{
			get => GetProperty(ref _isBroadcastingHazardStims);
			set => SetProperty(ref _isBroadcastingHazardStims, value);
		}

		[Ordinal(15)] 
		[RED("healthStatPoolListener")] 
		public CHandle<VehicleHealthStatPoolListener> HealthStatPoolListener
		{
			get => GetProperty(ref _healthStatPoolListener);
			set => SetProperty(ref _healthStatPoolListener, value);
		}

		[Ordinal(16)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(17)] 
		[RED("radioState")] 
		public CBool RadioState
		{
			get => GetProperty(ref _radioState);
			set => SetProperty(ref _radioState, value);
		}

		[Ordinal(18)] 
		[RED("mounted")] 
		public CBool Mounted
		{
			get => GetProperty(ref _mounted);
			set => SetProperty(ref _mounted, value);
		}

		[Ordinal(19)] 
		[RED("enterTime")] 
		public CFloat EnterTime
		{
			get => GetProperty(ref _enterTime);
			set => SetProperty(ref _enterTime, value);
		}

		[Ordinal(20)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(21)] 
		[RED("quickhackMappinID")] 
		public gameNewMappinID QuickhackMappinID
		{
			get => GetProperty(ref _quickhackMappinID);
			set => SetProperty(ref _quickhackMappinID, value);
		}

		[Ordinal(22)] 
		[RED("ignoreAutoDoorClose")] 
		public CBool IgnoreAutoDoorClose
		{
			get => GetProperty(ref _ignoreAutoDoorClose);
			set => SetProperty(ref _ignoreAutoDoorClose, value);
		}

		[Ordinal(23)] 
		[RED("mappinDestroyedBeforeCreation")] 
		public CBool MappinDestroyedBeforeCreation
		{
			get => GetProperty(ref _mappinDestroyedBeforeCreation);
			set => SetProperty(ref _mappinDestroyedBeforeCreation, value);
		}

		[Ordinal(24)] 
		[RED("timeSystemCallbackID")] 
		public CUInt32 TimeSystemCallbackID
		{
			get => GetProperty(ref _timeSystemCallbackID);
			set => SetProperty(ref _timeSystemCallbackID, value);
		}

		[Ordinal(25)] 
		[RED("vehicleTPPCallbackID")] 
		public CHandle<redCallbackObject> VehicleTPPCallbackID
		{
			get => GetProperty(ref _vehicleTPPCallbackID);
			set => SetProperty(ref _vehicleTPPCallbackID, value);
		}

		[Ordinal(26)] 
		[RED("vehicleSpeedCallbackID")] 
		public CHandle<redCallbackObject> VehicleSpeedCallbackID
		{
			get => GetProperty(ref _vehicleSpeedCallbackID);
			set => SetProperty(ref _vehicleSpeedCallbackID, value);
		}

		[Ordinal(27)] 
		[RED("carAlarmCallbackID")] 
		public CHandle<redCallbackObject> CarAlarmCallbackID
		{
			get => GetProperty(ref _carAlarmCallbackID);
			set => SetProperty(ref _carAlarmCallbackID, value);
		}

		[Ordinal(28)] 
		[RED("vehicleRPMCallbackID")] 
		public CHandle<redCallbackObject> VehicleRPMCallbackID
		{
			get => GetProperty(ref _vehicleRPMCallbackID);
			set => SetProperty(ref _vehicleRPMCallbackID, value);
		}

		[Ordinal(29)] 
		[RED("vehicleDisableAlarmDelayID")] 
		public gameDelayID VehicleDisableAlarmDelayID
		{
			get => GetProperty(ref _vehicleDisableAlarmDelayID);
			set => SetProperty(ref _vehicleDisableAlarmDelayID, value);
		}

		[Ordinal(30)] 
		[RED("vehicleExitDelayId")] 
		public gameDelayID VehicleExitDelayId
		{
			get => GetProperty(ref _vehicleExitDelayId);
			set => SetProperty(ref _vehicleExitDelayId, value);
		}

		[Ordinal(31)] 
		[RED("broadcasting")] 
		public CBool Broadcasting
		{
			get => GetProperty(ref _broadcasting);
			set => SetProperty(ref _broadcasting, value);
		}

		[Ordinal(32)] 
		[RED("hasSpoiler")] 
		public CBool HasSpoiler
		{
			get => GetProperty(ref _hasSpoiler);
			set => SetProperty(ref _hasSpoiler, value);
		}

		[Ordinal(33)] 
		[RED("spoilerUp")] 
		public CFloat SpoilerUp
		{
			get => GetProperty(ref _spoilerUp);
			set => SetProperty(ref _spoilerUp, value);
		}

		[Ordinal(34)] 
		[RED("spoilerDown")] 
		public CFloat SpoilerDown
		{
			get => GetProperty(ref _spoilerDown);
			set => SetProperty(ref _spoilerDown, value);
		}

		[Ordinal(35)] 
		[RED("spoilerDeployed")] 
		public CBool SpoilerDeployed
		{
			get => GetProperty(ref _spoilerDeployed);
			set => SetProperty(ref _spoilerDeployed, value);
		}

		[Ordinal(36)] 
		[RED("hasTurboCharger")] 
		public CBool HasTurboCharger
		{
			get => GetProperty(ref _hasTurboCharger);
			set => SetProperty(ref _hasTurboCharger, value);
		}

		[Ordinal(37)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get => GetProperty(ref _overheatEffectBlackboard);
			set => SetProperty(ref _overheatEffectBlackboard, value);
		}

		[Ordinal(38)] 
		[RED("overheatActive")] 
		public CBool OverheatActive
		{
			get => GetProperty(ref _overheatActive);
			set => SetProperty(ref _overheatActive, value);
		}

		[Ordinal(39)] 
		[RED("hornOn")] 
		public CBool HornOn
		{
			get => GetProperty(ref _hornOn);
			set => SetProperty(ref _hornOn, value);
		}

		[Ordinal(40)] 
		[RED("useAuxiliary")] 
		public CBool UseAuxiliary
		{
			get => GetProperty(ref _useAuxiliary);
			set => SetProperty(ref _useAuxiliary, value);
		}

		[Ordinal(41)] 
		[RED("sirenPressTime")] 
		public CFloat SirenPressTime
		{
			get => GetProperty(ref _sirenPressTime);
			set => SetProperty(ref _sirenPressTime, value);
		}

		[Ordinal(42)] 
		[RED("radioPressTime")] 
		public CFloat RadioPressTime
		{
			get => GetProperty(ref _radioPressTime);
			set => SetProperty(ref _radioPressTime, value);
		}

		[Ordinal(43)] 
		[RED("raceClockTickID")] 
		public gameDelayID RaceClockTickID
		{
			get => GetProperty(ref _raceClockTickID);
			set => SetProperty(ref _raceClockTickID, value);
		}

		[Ordinal(44)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetProperty(ref _objectActionsCallbackCtrl);
			set => SetProperty(ref _objectActionsCallbackCtrl, value);
		}

		[Ordinal(45)] 
		[RED("trunkNpcBody")] 
		public wCHandle<gameObject> TrunkNpcBody
		{
			get => GetProperty(ref _trunkNpcBody);
			set => SetProperty(ref _trunkNpcBody, value);
		}

		[Ordinal(46)] 
		[RED("mountedPlayer")] 
		public wCHandle<PlayerPuppet> MountedPlayer
		{
			get => GetProperty(ref _mountedPlayer);
			set => SetProperty(ref _mountedPlayer, value);
		}

		[Ordinal(47)] 
		[RED("isIgnoredInTargetingSystem")] 
		public CBool IsIgnoredInTargetingSystem
		{
			get => GetProperty(ref _isIgnoredInTargetingSystem);
			set => SetProperty(ref _isIgnoredInTargetingSystem, value);
		}

		[Ordinal(48)] 
		[RED("arePlayerHitShapesEnabled")] 
		public CBool ArePlayerHitShapesEnabled
		{
			get => GetProperty(ref _arePlayerHitShapesEnabled);
			set => SetProperty(ref _arePlayerHitShapesEnabled, value);
		}

		[Ordinal(49)] 
		[RED("uiWantedBarBB")] 
		public wCHandle<gameIBlackboard> UiWantedBarBB
		{
			get => GetProperty(ref _uiWantedBarBB);
			set => SetProperty(ref _uiWantedBarBB, value);
		}

		[Ordinal(50)] 
		[RED("currentWantedLevelCallback")] 
		public CHandle<redCallbackObject> CurrentWantedLevelCallback
		{
			get => GetProperty(ref _currentWantedLevelCallback);
			set => SetProperty(ref _currentWantedLevelCallback, value);
		}

		[Ordinal(51)] 
		[RED("preventionPassengers")] 
		public CInt32 PreventionPassengers
		{
			get => GetProperty(ref _preventionPassengers);
			set => SetProperty(ref _preventionPassengers, value);
		}

		[Ordinal(52)] 
		[RED("timeSinceLastHit")] 
		public CFloat TimeSinceLastHit
		{
			get => GetProperty(ref _timeSinceLastHit);
			set => SetProperty(ref _timeSinceLastHit, value);
		}

		[Ordinal(53)] 
		[RED("dragTime")] 
		public CFloat DragTime
		{
			get => GetProperty(ref _dragTime);
			set => SetProperty(ref _dragTime, value);
		}

		[Ordinal(54)] 
		[RED("vehicleController")] 
		public CHandle<vehicleController> VehicleController
		{
			get => GetProperty(ref _vehicleController);
			set => SetProperty(ref _vehicleController, value);
		}

		public VehicleComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
