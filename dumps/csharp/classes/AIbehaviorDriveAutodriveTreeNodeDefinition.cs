using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveAutodriveTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _laneFindRange;
		private CHandle<AIArgumentMapping> _minimumDistanceToTarget;
		private CHandle<AIArgumentMapping> _minimumDistanceToTargetVertical;

		[Ordinal(1)] 
		[RED("laneFindRange")] 
		public CHandle<AIArgumentMapping> LaneFindRange
		{
			get => GetProperty(ref _laneFindRange);
			set => SetProperty(ref _laneFindRange, value);
		}

		[Ordinal(2)] 
		[RED("minimumDistanceToTarget")] 
		public CHandle<AIArgumentMapping> MinimumDistanceToTarget
		{
			get => GetProperty(ref _minimumDistanceToTarget);
			set => SetProperty(ref _minimumDistanceToTarget, value);
		}

		[Ordinal(3)] 
		[RED("minimumDistanceToTargetVertical")] 
		public CHandle<AIArgumentMapping> MinimumDistanceToTargetVertical
		{
			get => GetProperty(ref _minimumDistanceToTargetVertical);
			set => SetProperty(ref _minimumDistanceToTargetVertical, value);
		}

		public AIbehaviorDriveAutodriveTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
