using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleBaseObject : gameObject
	{
		private rRef<AIArchetype> _archetype;
		private CBool _isVehicleOnStateLocked;
		private wCHandle<VehicleComponent> _vehicleComponent;
		private wCHandle<WorldWidgetComponent> _uiComponent;
		private CHandle<CrowdMemberBaseComponent> _crowdMemberComponent;
		private CHandle<gameAttitudeAgent> _attitudeAgent;
		private CFloat _hitTimestamp;
		private CName _drivingTrafficPattern;
		private CBool _onPavement;
		private CBool _inTrafficLane;
		private CInt32 _timesSentReactionEvent;
		private CInt32 _timesToResendHandleReactionEvent;
		private CBool _hasReactedToStimuli;
		private CInt32 _gotStuckIncrement;
		private gameDelayID _waitForPassengersToSpawnEventDelayID;
		private gameDelayID _triggerPanicDrivingEventDelayID;
		private CHandle<HandleReactionEvent> _reactionTriggerEvent;
		private CBool _fearInside;
		private CHandle<redCallbackObject> _photoModeActiveListener;
		private CBool _vehicleUpsideDown;
		private CBool _isQhackUploadInProgress;
		private CBool _hitByPlayer;
		private wCHandle<ScriptableDeviceAction> _currentlyUploadingAction;
		private CInt32 _bumpedRecently;
		private CFloat _bumpTimestamp;
		private CFloat _minUnconsciousImpact;
		private CBool _driverUnconscious;
		private CBool _abandoned;

		[Ordinal(36)] 
		[RED("archetype")] 
		public rRef<AIArchetype> Archetype
		{
			get => GetProperty(ref _archetype);
			set => SetProperty(ref _archetype, value);
		}

		[Ordinal(37)] 
		[RED("isVehicleOnStateLocked")] 
		public CBool IsVehicleOnStateLocked
		{
			get => GetProperty(ref _isVehicleOnStateLocked);
			set => SetProperty(ref _isVehicleOnStateLocked, value);
		}

		[Ordinal(38)] 
		[RED("vehicleComponent")] 
		public wCHandle<VehicleComponent> VehicleComponent
		{
			get => GetProperty(ref _vehicleComponent);
			set => SetProperty(ref _vehicleComponent, value);
		}

		[Ordinal(39)] 
		[RED("uiComponent")] 
		public wCHandle<WorldWidgetComponent> UiComponent
		{
			get => GetProperty(ref _uiComponent);
			set => SetProperty(ref _uiComponent, value);
		}

		[Ordinal(40)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetProperty(ref _crowdMemberComponent);
			set => SetProperty(ref _crowdMemberComponent, value);
		}

		[Ordinal(41)] 
		[RED("attitudeAgent")] 
		public CHandle<gameAttitudeAgent> AttitudeAgent
		{
			get => GetProperty(ref _attitudeAgent);
			set => SetProperty(ref _attitudeAgent, value);
		}

		[Ordinal(42)] 
		[RED("hitTimestamp")] 
		public CFloat HitTimestamp
		{
			get => GetProperty(ref _hitTimestamp);
			set => SetProperty(ref _hitTimestamp, value);
		}

		[Ordinal(43)] 
		[RED("drivingTrafficPattern")] 
		public CName DrivingTrafficPattern
		{
			get => GetProperty(ref _drivingTrafficPattern);
			set => SetProperty(ref _drivingTrafficPattern, value);
		}

		[Ordinal(44)] 
		[RED("onPavement")] 
		public CBool OnPavement
		{
			get => GetProperty(ref _onPavement);
			set => SetProperty(ref _onPavement, value);
		}

		[Ordinal(45)] 
		[RED("inTrafficLane")] 
		public CBool InTrafficLane
		{
			get => GetProperty(ref _inTrafficLane);
			set => SetProperty(ref _inTrafficLane, value);
		}

		[Ordinal(46)] 
		[RED("timesSentReactionEvent")] 
		public CInt32 TimesSentReactionEvent
		{
			get => GetProperty(ref _timesSentReactionEvent);
			set => SetProperty(ref _timesSentReactionEvent, value);
		}

		[Ordinal(47)] 
		[RED("timesToResendHandleReactionEvent")] 
		public CInt32 TimesToResendHandleReactionEvent
		{
			get => GetProperty(ref _timesToResendHandleReactionEvent);
			set => SetProperty(ref _timesToResendHandleReactionEvent, value);
		}

		[Ordinal(48)] 
		[RED("hasReactedToStimuli")] 
		public CBool HasReactedToStimuli
		{
			get => GetProperty(ref _hasReactedToStimuli);
			set => SetProperty(ref _hasReactedToStimuli, value);
		}

		[Ordinal(49)] 
		[RED("gotStuckIncrement")] 
		public CInt32 GotStuckIncrement
		{
			get => GetProperty(ref _gotStuckIncrement);
			set => SetProperty(ref _gotStuckIncrement, value);
		}

		[Ordinal(50)] 
		[RED("waitForPassengersToSpawnEventDelayID")] 
		public gameDelayID WaitForPassengersToSpawnEventDelayID
		{
			get => GetProperty(ref _waitForPassengersToSpawnEventDelayID);
			set => SetProperty(ref _waitForPassengersToSpawnEventDelayID, value);
		}

		[Ordinal(51)] 
		[RED("triggerPanicDrivingEventDelayID")] 
		public gameDelayID TriggerPanicDrivingEventDelayID
		{
			get => GetProperty(ref _triggerPanicDrivingEventDelayID);
			set => SetProperty(ref _triggerPanicDrivingEventDelayID, value);
		}

		[Ordinal(52)] 
		[RED("reactionTriggerEvent")] 
		public CHandle<HandleReactionEvent> ReactionTriggerEvent
		{
			get => GetProperty(ref _reactionTriggerEvent);
			set => SetProperty(ref _reactionTriggerEvent, value);
		}

		[Ordinal(53)] 
		[RED("fearInside")] 
		public CBool FearInside
		{
			get => GetProperty(ref _fearInside);
			set => SetProperty(ref _fearInside, value);
		}

		[Ordinal(54)] 
		[RED("photoModeActiveListener")] 
		public CHandle<redCallbackObject> PhotoModeActiveListener
		{
			get => GetProperty(ref _photoModeActiveListener);
			set => SetProperty(ref _photoModeActiveListener, value);
		}

		[Ordinal(55)] 
		[RED("vehicleUpsideDown")] 
		public CBool VehicleUpsideDown
		{
			get => GetProperty(ref _vehicleUpsideDown);
			set => SetProperty(ref _vehicleUpsideDown, value);
		}

		[Ordinal(56)] 
		[RED("isQhackUploadInProgress")] 
		public CBool IsQhackUploadInProgress
		{
			get => GetProperty(ref _isQhackUploadInProgress);
			set => SetProperty(ref _isQhackUploadInProgress, value);
		}

		[Ordinal(57)] 
		[RED("hitByPlayer")] 
		public CBool HitByPlayer
		{
			get => GetProperty(ref _hitByPlayer);
			set => SetProperty(ref _hitByPlayer, value);
		}

		[Ordinal(58)] 
		[RED("currentlyUploadingAction")] 
		public wCHandle<ScriptableDeviceAction> CurrentlyUploadingAction
		{
			get => GetProperty(ref _currentlyUploadingAction);
			set => SetProperty(ref _currentlyUploadingAction, value);
		}

		[Ordinal(59)] 
		[RED("bumpedRecently")] 
		public CInt32 BumpedRecently
		{
			get => GetProperty(ref _bumpedRecently);
			set => SetProperty(ref _bumpedRecently, value);
		}

		[Ordinal(60)] 
		[RED("bumpTimestamp")] 
		public CFloat BumpTimestamp
		{
			get => GetProperty(ref _bumpTimestamp);
			set => SetProperty(ref _bumpTimestamp, value);
		}

		[Ordinal(61)] 
		[RED("minUnconsciousImpact")] 
		public CFloat MinUnconsciousImpact
		{
			get => GetProperty(ref _minUnconsciousImpact);
			set => SetProperty(ref _minUnconsciousImpact, value);
		}

		[Ordinal(62)] 
		[RED("driverUnconscious")] 
		public CBool DriverUnconscious
		{
			get => GetProperty(ref _driverUnconscious);
			set => SetProperty(ref _driverUnconscious, value);
		}

		[Ordinal(63)] 
		[RED("abandoned")] 
		public CBool Abandoned
		{
			get => GetProperty(ref _abandoned);
			set => SetProperty(ref _abandoned, value);
		}

		public vehicleBaseObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
