using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSavePatrolProgressTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CBool _saveOnDeactivation;
		private CHandle<AIArgumentMapping> _savedState;

		[Ordinal(1)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetProperty(ref _patrolProgress);
			set => SetProperty(ref _patrolProgress, value);
		}

		[Ordinal(2)] 
		[RED("saveOnDeactivation")] 
		public CBool SaveOnDeactivation
		{
			get => GetProperty(ref _saveOnDeactivation);
			set => SetProperty(ref _saveOnDeactivation, value);
		}

		[Ordinal(3)] 
		[RED("savedState")] 
		public CHandle<AIArgumentMapping> SavedState
		{
			get => GetProperty(ref _savedState);
			set => SetProperty(ref _savedState, value);
		}

		public AIbehaviorSavePatrolProgressTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
