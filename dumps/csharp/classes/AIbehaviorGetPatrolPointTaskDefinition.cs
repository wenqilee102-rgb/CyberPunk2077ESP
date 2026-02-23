using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorGetPatrolPointTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _inPatrolDistance;
		private CHandle<AIArgumentMapping> _inLastKnownPosition;
		private CHandle<AIArgumentMapping> _outFollowTrailPoint;

		[Ordinal(1)] 
		[RED("inPatrolDistance")] 
		public CHandle<AIArgumentMapping> InPatrolDistance
		{
			get => GetProperty(ref _inPatrolDistance);
			set => SetProperty(ref _inPatrolDistance, value);
		}

		[Ordinal(2)] 
		[RED("inLastKnownPosition")] 
		public CHandle<AIArgumentMapping> InLastKnownPosition
		{
			get => GetProperty(ref _inLastKnownPosition);
			set => SetProperty(ref _inLastKnownPosition, value);
		}

		[Ordinal(3)] 
		[RED("outFollowTrailPoint")] 
		public CHandle<AIArgumentMapping> OutFollowTrailPoint
		{
			get => GetProperty(ref _outFollowTrailPoint);
			set => SetProperty(ref _outFollowTrailPoint, value);
		}

		public AIbehaviorGetPatrolPointTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
