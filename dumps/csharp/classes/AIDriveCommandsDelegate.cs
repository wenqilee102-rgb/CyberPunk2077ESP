using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIDriveCommandsDelegate : AIbehaviorScriptBehaviorDelegate
	{
		private CBool _useKinematic;
		private CBool _needDriver;
		private NodeRef _splineRef;
		private CFloat _secureTimeOut;
		private CFloat _forcedStartSpeed;
		private CBool _stopAtPathEnd;
		private CBool _driveBackwards;
		private CBool _reverseSpline;
		private CBool _startFromClosest;
		private CBool _keepDistanceBool;
		private wCHandle<gameObject> _keepDistanceCompanion;
		private CFloat _keepDistanceDistance;
		private CBool _rubberBandingBool;
		private wCHandle<gameObject> _rubberBandingTargetRef;
		private CFloat _rubberBandingTargetForwardOffset;
		private CFloat _rubberBandingMinDistance;
		private CFloat _rubberBandingMaxDistance;
		private CBool _rubberBandingStopAndWait;
		private CBool _rubberBandingTeleportToCatchUp;
		private CBool _rubberBandingStayInFront;
		private CHandle<vehicleAudioCurvesParam> _audioCurvesParam;
		private CBool _allowSimplifiedMovement;
		private CBool _ignoreTickets;
		private CBool _disabeStuckDetection;
		private CBool _aggressiveRammingEnabled;
		private CBool _useSpeedBasedLookupRange;
		private CBool _tryDriveAwayFromPlayer;
		private Vector3 _targetPosition;
		private CFloat _maxSpeed;
		private CFloat _minSpeed;
		private CBool _clearTrafficOnPath;
		private CFloat _minimumDistanceToTarget;
		private CBool _emergencyPatrol;
		private CUInt32 _numPatrolLoops;
		private CBool _driveDownTheRoadIndefinitely;
		private CBool _ignoreChaseVehiclesLimit;
		private CBool _boostDrivingStats;
		private CHandle<AIVehicleOnSplineCommand> _driveOnSplineCommand;
		private CBool _useTraffic;
		private CFloat _speedInTraffic;
		private wCHandle<gameObject> _target;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CBool _stopWhenTargetReached;
		private CBool _trafficTryNeighborsForStart;
		private CBool _trafficTryNeighborsForEnd;
		private CBool _ignoreNoAIDrivingLanes;
		private CHandle<AIVehicleFollowCommand> _driveFollowCommand;
		private CHandle<AIVehicleChaseCommand> _driveChaseCommand;
		private CHandle<AIVehiclePanicCommand> _drivePanicCommand;
		private CHandle<AIVehicleDriveToPointAutonomousCommand> _driveToPointAutonomousCommand;
		private CHandle<AIVehicleDrivePatrolCommand> _drivePatrolCommand;
		private NodeRef _nodeRef;
		private CBool _isPlayer;
		private CBool _forceGreenLights;
		private CHandle<vehiclePortalsList> _portals;
		private CHandle<AIVehicleToNodeCommand> _driveToNodeCommand;
		private CHandle<AIVehicleRacingCommand> _driveRacingCommand;
		private CHandle<AIVehicleJoinTrafficCommand> _driveJoinTrafficCommand;

		[Ordinal(0)] 
		[RED("useKinematic")] 
		public CBool UseKinematic
		{
			get => GetProperty(ref _useKinematic);
			set => SetProperty(ref _useKinematic, value);
		}

		[Ordinal(1)] 
		[RED("needDriver")] 
		public CBool NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(2)] 
		[RED("splineRef")] 
		public NodeRef SplineRef
		{
			get => GetProperty(ref _splineRef);
			set => SetProperty(ref _splineRef, value);
		}

		[Ordinal(3)] 
		[RED("secureTimeOut")] 
		public CFloat SecureTimeOut
		{
			get => GetProperty(ref _secureTimeOut);
			set => SetProperty(ref _secureTimeOut, value);
		}

		[Ordinal(4)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(5)] 
		[RED("stopAtPathEnd")] 
		public CBool StopAtPathEnd
		{
			get => GetProperty(ref _stopAtPathEnd);
			set => SetProperty(ref _stopAtPathEnd, value);
		}

		[Ordinal(6)] 
		[RED("driveBackwards")] 
		public CBool DriveBackwards
		{
			get => GetProperty(ref _driveBackwards);
			set => SetProperty(ref _driveBackwards, value);
		}

		[Ordinal(7)] 
		[RED("reverseSpline")] 
		public CBool ReverseSpline
		{
			get => GetProperty(ref _reverseSpline);
			set => SetProperty(ref _reverseSpline, value);
		}

		[Ordinal(8)] 
		[RED("startFromClosest")] 
		public CBool StartFromClosest
		{
			get => GetProperty(ref _startFromClosest);
			set => SetProperty(ref _startFromClosest, value);
		}

		[Ordinal(9)] 
		[RED("keepDistanceBool")] 
		public CBool KeepDistanceBool
		{
			get => GetProperty(ref _keepDistanceBool);
			set => SetProperty(ref _keepDistanceBool, value);
		}

		[Ordinal(10)] 
		[RED("keepDistanceCompanion")] 
		public wCHandle<gameObject> KeepDistanceCompanion
		{
			get => GetProperty(ref _keepDistanceCompanion);
			set => SetProperty(ref _keepDistanceCompanion, value);
		}

		[Ordinal(11)] 
		[RED("keepDistanceDistance")] 
		public CFloat KeepDistanceDistance
		{
			get => GetProperty(ref _keepDistanceDistance);
			set => SetProperty(ref _keepDistanceDistance, value);
		}

		[Ordinal(12)] 
		[RED("rubberBandingBool")] 
		public CBool RubberBandingBool
		{
			get => GetProperty(ref _rubberBandingBool);
			set => SetProperty(ref _rubberBandingBool, value);
		}

		[Ordinal(13)] 
		[RED("rubberBandingTargetRef")] 
		public wCHandle<gameObject> RubberBandingTargetRef
		{
			get => GetProperty(ref _rubberBandingTargetRef);
			set => SetProperty(ref _rubberBandingTargetRef, value);
		}

		[Ordinal(14)] 
		[RED("rubberBandingTargetForwardOffset")] 
		public CFloat RubberBandingTargetForwardOffset
		{
			get => GetProperty(ref _rubberBandingTargetForwardOffset);
			set => SetProperty(ref _rubberBandingTargetForwardOffset, value);
		}

		[Ordinal(15)] 
		[RED("rubberBandingMinDistance")] 
		public CFloat RubberBandingMinDistance
		{
			get => GetProperty(ref _rubberBandingMinDistance);
			set => SetProperty(ref _rubberBandingMinDistance, value);
		}

		[Ordinal(16)] 
		[RED("rubberBandingMaxDistance")] 
		public CFloat RubberBandingMaxDistance
		{
			get => GetProperty(ref _rubberBandingMaxDistance);
			set => SetProperty(ref _rubberBandingMaxDistance, value);
		}

		[Ordinal(17)] 
		[RED("rubberBandingStopAndWait")] 
		public CBool RubberBandingStopAndWait
		{
			get => GetProperty(ref _rubberBandingStopAndWait);
			set => SetProperty(ref _rubberBandingStopAndWait, value);
		}

		[Ordinal(18)] 
		[RED("rubberBandingTeleportToCatchUp")] 
		public CBool RubberBandingTeleportToCatchUp
		{
			get => GetProperty(ref _rubberBandingTeleportToCatchUp);
			set => SetProperty(ref _rubberBandingTeleportToCatchUp, value);
		}

		[Ordinal(19)] 
		[RED("rubberBandingStayInFront")] 
		public CBool RubberBandingStayInFront
		{
			get => GetProperty(ref _rubberBandingStayInFront);
			set => SetProperty(ref _rubberBandingStayInFront, value);
		}

		[Ordinal(20)] 
		[RED("audioCurvesParam")] 
		public CHandle<vehicleAudioCurvesParam> AudioCurvesParam
		{
			get => GetProperty(ref _audioCurvesParam);
			set => SetProperty(ref _audioCurvesParam, value);
		}

		[Ordinal(21)] 
		[RED("allowSimplifiedMovement")] 
		public CBool AllowSimplifiedMovement
		{
			get => GetProperty(ref _allowSimplifiedMovement);
			set => SetProperty(ref _allowSimplifiedMovement, value);
		}

		[Ordinal(22)] 
		[RED("ignoreTickets")] 
		public CBool IgnoreTickets
		{
			get => GetProperty(ref _ignoreTickets);
			set => SetProperty(ref _ignoreTickets, value);
		}

		[Ordinal(23)] 
		[RED("disabeStuckDetection")] 
		public CBool DisabeStuckDetection
		{
			get => GetProperty(ref _disabeStuckDetection);
			set => SetProperty(ref _disabeStuckDetection, value);
		}

		[Ordinal(24)] 
		[RED("aggressiveRammingEnabled")] 
		public CBool AggressiveRammingEnabled
		{
			get => GetProperty(ref _aggressiveRammingEnabled);
			set => SetProperty(ref _aggressiveRammingEnabled, value);
		}

		[Ordinal(25)] 
		[RED("useSpeedBasedLookupRange")] 
		public CBool UseSpeedBasedLookupRange
		{
			get => GetProperty(ref _useSpeedBasedLookupRange);
			set => SetProperty(ref _useSpeedBasedLookupRange, value);
		}

		[Ordinal(26)] 
		[RED("tryDriveAwayFromPlayer")] 
		public CBool TryDriveAwayFromPlayer
		{
			get => GetProperty(ref _tryDriveAwayFromPlayer);
			set => SetProperty(ref _tryDriveAwayFromPlayer, value);
		}

		[Ordinal(27)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(28)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(29)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(30)] 
		[RED("clearTrafficOnPath")] 
		public CBool ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		[Ordinal(31)] 
		[RED("minimumDistanceToTarget")] 
		public CFloat MinimumDistanceToTarget
		{
			get => GetProperty(ref _minimumDistanceToTarget);
			set => SetProperty(ref _minimumDistanceToTarget, value);
		}

		[Ordinal(32)] 
		[RED("emergencyPatrol")] 
		public CBool EmergencyPatrol
		{
			get => GetProperty(ref _emergencyPatrol);
			set => SetProperty(ref _emergencyPatrol, value);
		}

		[Ordinal(33)] 
		[RED("numPatrolLoops")] 
		public CUInt32 NumPatrolLoops
		{
			get => GetProperty(ref _numPatrolLoops);
			set => SetProperty(ref _numPatrolLoops, value);
		}

		[Ordinal(34)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CBool DriveDownTheRoadIndefinitely
		{
			get => GetProperty(ref _driveDownTheRoadIndefinitely);
			set => SetProperty(ref _driveDownTheRoadIndefinitely, value);
		}

		[Ordinal(35)] 
		[RED("ignoreChaseVehiclesLimit")] 
		public CBool IgnoreChaseVehiclesLimit
		{
			get => GetProperty(ref _ignoreChaseVehiclesLimit);
			set => SetProperty(ref _ignoreChaseVehiclesLimit, value);
		}

		[Ordinal(36)] 
		[RED("boostDrivingStats")] 
		public CBool BoostDrivingStats
		{
			get => GetProperty(ref _boostDrivingStats);
			set => SetProperty(ref _boostDrivingStats, value);
		}

		[Ordinal(37)] 
		[RED("driveOnSplineCommand")] 
		public CHandle<AIVehicleOnSplineCommand> DriveOnSplineCommand
		{
			get => GetProperty(ref _driveOnSplineCommand);
			set => SetProperty(ref _driveOnSplineCommand, value);
		}

		[Ordinal(38)] 
		[RED("useTraffic")] 
		public CBool UseTraffic
		{
			get => GetProperty(ref _useTraffic);
			set => SetProperty(ref _useTraffic, value);
		}

		[Ordinal(39)] 
		[RED("speedInTraffic")] 
		public CFloat SpeedInTraffic
		{
			get => GetProperty(ref _speedInTraffic);
			set => SetProperty(ref _speedInTraffic, value);
		}

		[Ordinal(40)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(41)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(42)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(43)] 
		[RED("stopWhenTargetReached")] 
		public CBool StopWhenTargetReached
		{
			get => GetProperty(ref _stopWhenTargetReached);
			set => SetProperty(ref _stopWhenTargetReached, value);
		}

		[Ordinal(44)] 
		[RED("trafficTryNeighborsForStart")] 
		public CBool TrafficTryNeighborsForStart
		{
			get => GetProperty(ref _trafficTryNeighborsForStart);
			set => SetProperty(ref _trafficTryNeighborsForStart, value);
		}

		[Ordinal(45)] 
		[RED("trafficTryNeighborsForEnd")] 
		public CBool TrafficTryNeighborsForEnd
		{
			get => GetProperty(ref _trafficTryNeighborsForEnd);
			set => SetProperty(ref _trafficTryNeighborsForEnd, value);
		}

		[Ordinal(46)] 
		[RED("ignoreNoAIDrivingLanes")] 
		public CBool IgnoreNoAIDrivingLanes
		{
			get => GetProperty(ref _ignoreNoAIDrivingLanes);
			set => SetProperty(ref _ignoreNoAIDrivingLanes, value);
		}

		[Ordinal(47)] 
		[RED("driveFollowCommand")] 
		public CHandle<AIVehicleFollowCommand> DriveFollowCommand
		{
			get => GetProperty(ref _driveFollowCommand);
			set => SetProperty(ref _driveFollowCommand, value);
		}

		[Ordinal(48)] 
		[RED("driveChaseCommand")] 
		public CHandle<AIVehicleChaseCommand> DriveChaseCommand
		{
			get => GetProperty(ref _driveChaseCommand);
			set => SetProperty(ref _driveChaseCommand, value);
		}

		[Ordinal(49)] 
		[RED("drivePanicCommand")] 
		public CHandle<AIVehiclePanicCommand> DrivePanicCommand
		{
			get => GetProperty(ref _drivePanicCommand);
			set => SetProperty(ref _drivePanicCommand, value);
		}

		[Ordinal(50)] 
		[RED("driveToPointAutonomousCommand")] 
		public CHandle<AIVehicleDriveToPointAutonomousCommand> DriveToPointAutonomousCommand
		{
			get => GetProperty(ref _driveToPointAutonomousCommand);
			set => SetProperty(ref _driveToPointAutonomousCommand, value);
		}

		[Ordinal(51)] 
		[RED("drivePatrolCommand")] 
		public CHandle<AIVehicleDrivePatrolCommand> DrivePatrolCommand
		{
			get => GetProperty(ref _drivePatrolCommand);
			set => SetProperty(ref _drivePatrolCommand, value);
		}

		[Ordinal(52)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(53)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(54)] 
		[RED("forceGreenLights")] 
		public CBool ForceGreenLights
		{
			get => GetProperty(ref _forceGreenLights);
			set => SetProperty(ref _forceGreenLights, value);
		}

		[Ordinal(55)] 
		[RED("portals")] 
		public CHandle<vehiclePortalsList> Portals
		{
			get => GetProperty(ref _portals);
			set => SetProperty(ref _portals, value);
		}

		[Ordinal(56)] 
		[RED("driveToNodeCommand")] 
		public CHandle<AIVehicleToNodeCommand> DriveToNodeCommand
		{
			get => GetProperty(ref _driveToNodeCommand);
			set => SetProperty(ref _driveToNodeCommand, value);
		}

		[Ordinal(57)] 
		[RED("driveRacingCommand")] 
		public CHandle<AIVehicleRacingCommand> DriveRacingCommand
		{
			get => GetProperty(ref _driveRacingCommand);
			set => SetProperty(ref _driveRacingCommand, value);
		}

		[Ordinal(58)] 
		[RED("driveJoinTrafficCommand")] 
		public CHandle<AIVehicleJoinTrafficCommand> DriveJoinTrafficCommand
		{
			get => GetProperty(ref _driveJoinTrafficCommand);
			set => SetProperty(ref _driveJoinTrafficCommand, value);
		}

		public AIDriveCommandsDelegate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
