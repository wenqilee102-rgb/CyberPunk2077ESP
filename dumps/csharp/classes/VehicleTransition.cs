using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleTransition : DefaultTransition
	{
		private wCHandle<VehicleTransitionInitData> _stateMachineInitData;
		private CName _exitSlot;

		[Ordinal(0)] 
		[RED("stateMachineInitData")] 
		public wCHandle<VehicleTransitionInitData> StateMachineInitData
		{
			get => GetProperty(ref _stateMachineInitData);
			set => SetProperty(ref _stateMachineInitData, value);
		}

		[Ordinal(1)] 
		[RED("exitSlot")] 
		public CName ExitSlot
		{
			get => GetProperty(ref _exitSlot);
			set => SetProperty(ref _exitSlot, value);
		}

		public VehicleTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
