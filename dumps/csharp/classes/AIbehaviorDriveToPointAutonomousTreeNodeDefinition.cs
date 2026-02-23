using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveToPointAutonomousTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _targetPosition;
		private CHandle<AIArgumentMapping> _maxSpeed;
		private CHandle<AIArgumentMapping> _minSpeed;
		private CHandle<AIArgumentMapping> _clearTrafficOnPath;
		private CHandle<AIArgumentMapping> _minimumDistanceToTarget;
		private CHandle<AIArgumentMapping> _forcedStartSpeed;
		private CHandle<AIArgumentMapping> _driveDownTheRoadIndefinitely;

		[Ordinal(1)] 
		[RED("targetPosition")] 
		public CHandle<AIArgumentMapping> TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(2)] 
		[RED("maxSpeed")] 
		public CHandle<AIArgumentMapping> MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(3)] 
		[RED("minSpeed")] 
		public CHandle<AIArgumentMapping> MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(4)] 
		[RED("clearTrafficOnPath")] 
		public CHandle<AIArgumentMapping> ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		[Ordinal(5)] 
		[RED("minimumDistanceToTarget")] 
		public CHandle<AIArgumentMapping> MinimumDistanceToTarget
		{
			get => GetProperty(ref _minimumDistanceToTarget);
			set => SetProperty(ref _minimumDistanceToTarget, value);
		}

		[Ordinal(6)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(7)] 
		[RED("driveDownTheRoadIndefinitely")] 
		public CHandle<AIArgumentMapping> DriveDownTheRoadIndefinitely
		{
			get => GetProperty(ref _driveDownTheRoadIndefinitely);
			set => SetProperty(ref _driveDownTheRoadIndefinitely, value);
		}

		public AIbehaviorDriveToPointAutonomousTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
