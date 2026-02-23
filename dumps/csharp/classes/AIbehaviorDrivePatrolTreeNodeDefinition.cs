using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDrivePatrolTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _maxSpeed;
		private CHandle<AIArgumentMapping> _minSpeed;
		private CHandle<AIArgumentMapping> _clearTrafficOnPath;
		private CHandle<AIArgumentMapping> _emergencyPatrol;
		private CHandle<AIArgumentMapping> _numPatrolLoops;
		private CHandle<AIArgumentMapping> _forcedStartSpeed;

		[Ordinal(1)] 
		[RED("maxSpeed")] 
		public CHandle<AIArgumentMapping> MaxSpeed
		{
			get => GetProperty(ref _maxSpeed);
			set => SetProperty(ref _maxSpeed, value);
		}

		[Ordinal(2)] 
		[RED("minSpeed")] 
		public CHandle<AIArgumentMapping> MinSpeed
		{
			get => GetProperty(ref _minSpeed);
			set => SetProperty(ref _minSpeed, value);
		}

		[Ordinal(3)] 
		[RED("clearTrafficOnPath")] 
		public CHandle<AIArgumentMapping> ClearTrafficOnPath
		{
			get => GetProperty(ref _clearTrafficOnPath);
			set => SetProperty(ref _clearTrafficOnPath, value);
		}

		[Ordinal(4)] 
		[RED("emergencyPatrol")] 
		public CHandle<AIArgumentMapping> EmergencyPatrol
		{
			get => GetProperty(ref _emergencyPatrol);
			set => SetProperty(ref _emergencyPatrol, value);
		}

		[Ordinal(5)] 
		[RED("numPatrolLoops")] 
		public CHandle<AIArgumentMapping> NumPatrolLoops
		{
			get => GetProperty(ref _numPatrolLoops);
			set => SetProperty(ref _numPatrolLoops, value);
		}

		[Ordinal(6)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		public AIbehaviorDrivePatrolTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
