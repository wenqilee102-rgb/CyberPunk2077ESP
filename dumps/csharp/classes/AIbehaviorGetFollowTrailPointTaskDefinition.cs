using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorGetFollowTrailPointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _inTrailDelay;
		private CHandle<AIArgumentMapping> _outFollowTrailPoint;

		[Ordinal(1)] 
		[RED("inTrailDelay")] 
		public CHandle<AIArgumentMapping> InTrailDelay
		{
			get => GetProperty(ref _inTrailDelay);
			set => SetProperty(ref _inTrailDelay, value);
		}

		[Ordinal(2)] 
		[RED("outFollowTrailPoint")] 
		public CHandle<AIArgumentMapping> OutFollowTrailPoint
		{
			get => GetProperty(ref _outFollowTrailPoint);
			set => SetProperty(ref _outFollowTrailPoint, value);
		}

		public AIbehaviorGetFollowTrailPointTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
