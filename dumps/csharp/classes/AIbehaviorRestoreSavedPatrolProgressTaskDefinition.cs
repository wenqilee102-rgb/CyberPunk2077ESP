using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorRestoreSavedPatrolProgressTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _path;
		private CHandle<AIArgumentMapping> _savedState;
		private CHandle<AIArgumentMapping> _patrolProgress;
		private CHandle<AIArgumentMapping> _destinationPosition;
		private CHandle<AIArgumentMapping> _destinationTangent;

		[Ordinal(1)] 
		[RED("path")] 
		public CHandle<AIArgumentMapping> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(2)] 
		[RED("savedState")] 
		public CHandle<AIArgumentMapping> SavedState
		{
			get => GetProperty(ref _savedState);
			set => SetProperty(ref _savedState, value);
		}

		[Ordinal(3)] 
		[RED("patrolProgress")] 
		public CHandle<AIArgumentMapping> PatrolProgress
		{
			get => GetProperty(ref _patrolProgress);
			set => SetProperty(ref _patrolProgress, value);
		}

		[Ordinal(4)] 
		[RED("destinationPosition")] 
		public CHandle<AIArgumentMapping> DestinationPosition
		{
			get => GetProperty(ref _destinationPosition);
			set => SetProperty(ref _destinationPosition, value);
		}

		[Ordinal(5)] 
		[RED("destinationTangent")] 
		public CHandle<AIArgumentMapping> DestinationTangent
		{
			get => GetProperty(ref _destinationTangent);
			set => SetProperty(ref _destinationTangent, value);
		}

		public AIbehaviorRestoreSavedPatrolProgressTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
