using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShouldContinuePatrolFromClosestPoint : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _patrolContinuationPolicy;

		[Ordinal(0)] 
		[RED("patrolContinuationPolicy")] 
		public CHandle<AIArgumentMapping> PatrolContinuationPolicy
		{
			get => GetProperty(ref _patrolContinuationPolicy);
			set => SetProperty(ref _patrolContinuationPolicy, value);
		}

		public ShouldContinuePatrolFromClosestPoint(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
