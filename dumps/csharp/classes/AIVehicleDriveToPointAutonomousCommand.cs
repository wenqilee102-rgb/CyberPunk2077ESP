using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleDriveToPointAutonomousCommand : AIVehicleCommand
	{
		private Vector3 _targetPosition;
		private CFloat _maxSpeed;
		private CFloat _minSpeed;
		private CBool _clearTrafficOnPath;
		private CFloat _minimumDistanceToTarget;
		private CFloat _forcedStartSpeed;
		private CBool _driveDownTheRoadIndefinitely;

		[Ordinal(6)] 
		[RED("targetPosition")] 
		public Vector3 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(7)] 
		[RED("maxSpeed")] 
		public CFloat MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(8)] 
		[RED("minSpeed")] 
		public CFloat MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(9)] 
		[RED("clearTrafficOnPath")] 
		public CBool ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		[Ordinal(10)] 
		[RED("minimumDistanceToTarget")] 
		public CFloat MinimumDistanceToTarget
		{
			get => GetProperty(ref _minimumDistanceToTarget);
			set => SetProperty(ref _minimumDistanceToTarget, value);
		}

		[Ordinal(11)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(12)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CBool DriveDownTheRoadIndefinitely
		{
			get => GetProperty(ref _driveDownTheRoadIndefinitely);
			set => SetProperty(ref _driveDownTheRoadIndefinitely, value);
		}

		public AIVehicleDriveToPointAutonomousCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
