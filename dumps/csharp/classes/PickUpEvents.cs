using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PickUpEvents : CarriedObjectEvents
	{
		private gamestateMachineStateMachineInstanceData _stateMachineInstanceData;
		private CBool _noCameraControlApplied;
		private CBool _noMovementApplied;

		[Ordinal(9)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetProperty(ref _stateMachineInstanceData);
			set => SetProperty(ref _stateMachineInstanceData, value);
		}

		[Ordinal(10)] 
		[RED("noCameraControlApplied")] 
		public CBool NoCameraControlApplied
		{
			get => GetProperty(ref _noCameraControlApplied);
			set => SetProperty(ref _noCameraControlApplied, value);
		}

		[Ordinal(11)] 
		[RED("noMovementApplied")] 
		public CBool NoMovementApplied
		{
			get => GetProperty(ref _noMovementApplied);
			set => SetProperty(ref _noMovementApplied, value);
		}

		public PickUpEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
