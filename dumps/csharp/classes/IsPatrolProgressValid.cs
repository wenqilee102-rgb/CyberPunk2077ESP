using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsPatrolProgressValid : AIbehaviorconditionScript
	{
		private CHandle<AIArgumentMapping> _patrolProgress;

		[Ordinal(0)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetProperty(ref _patrolProgress);
			set => SetProperty(ref _patrolProgress, value);
		}

		public IsPatrolProgressValid(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
