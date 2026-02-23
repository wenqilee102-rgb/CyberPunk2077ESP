using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InVehicleDriveToPointAutonomousDecorator : AIVehicleTaskAbstract
	{
		private CHandle<AIVehicleDriveToPointAutonomousCommand> _vehCommand;
		private CHandle<AIArgumentMapping> _targetPosition;
		private CHandle<AIArgumentMapping> _minimumDistanceToTarget;
		private CHandle<AIArgumentMapping> _maxSpeed;
		private CHandle<AIArgumentMapping> _minSpeed;
		private CHandle<AIArgumentMapping> _clearTrafficOnPath;
		private CHandle<AIArgumentMapping> _driveDownTheRoadIndefinitely;

		[Ordinal(0)] 
		[RED("vehCommand")] 
		public CHandle<AIVehicleDriveToPointAutonomousCommand> VehCommand
		{
			get => GetProperty(ref _vehCommand);
			set => SetProperty(ref _vehCommand, value);
		}

		[Ordinal(1)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(2)] 
		[RED("minimumDistanceToTarget")] 
		public CHandle<AIArgumentMapping> MinimumDistanceToTarget
		{
			get => GetProperty(ref _minimumDistanceToTarget);
			set => SetProperty(ref _minimumDistanceToTarget, value);
		}

		[Ordinal(3)] 
		[RED("maxSpeed")] 
		public CHandle<AIArgumentMapping> MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(4)] 
		[RED("minSpeed")] 
		public CHandle<AIArgumentMapping> MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(5)] 
		[RED("clearTrafficOnPath")] 
		public CHandle<AIArgumentMapping> ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		[Ordinal(6)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CHandle<AIArgumentMapping> DriveDownTheRoadIndefinitely
		{
			get => GetProperty(ref _driveDownTheRoadIndefinitely);
			set => SetProperty(ref _driveDownTheRoadIndefinitely, value);
		}

		public InVehicleDriveToPointAutonomousDecorator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
