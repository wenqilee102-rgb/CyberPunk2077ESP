using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorInstantRunAwayConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _destination;
		private CHandle<AIArgumentMapping> _runOnNavmesh;

		[Ordinal(1)] 
		[RED("destination")] 
		public CHandle<AIArgumentMapping> Destination
		{
			get => GetProperty(ref _destination);
			set => SetProperty(ref _destination, value);
		}

		[Ordinal(2)] 
		[RED("runOnNavmesh")] 
		public CHandle<AIArgumentMapping> RunOnNavmesh
		{
			get => GetProperty(ref _runOnNavmesh);
			set => SetProperty(ref _runOnNavmesh, value);
		}

		public AIbehaviorInstantRunAwayConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
