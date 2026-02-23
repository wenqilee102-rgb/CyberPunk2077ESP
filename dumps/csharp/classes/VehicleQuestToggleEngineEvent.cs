using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestToggleEngineEvent : redEvent
	{
		private CBool _toggle;
		private CEnum<VehicleQuestEngineLockState> _lockState;
		private CBool _vehicleOnEngineOff;

		[Ordinal(0)] 
		[RED("toggle")] 
		public CBool Toggle
		{
			get => GetProperty(ref _toggle);
			set => SetProperty(ref _toggle, value);
		}

		[Ordinal(1)] 
		[RED("lockState")] 
		public CEnum<VehicleQuestEngineLockState> LockState
		{
			get => GetProperty(ref _lockState);
			set => SetProperty(ref _lockState, value);
		}

		[Ordinal(2)] 
		[RED("vehicleOnEngineOff")] 
		public CBool VehicleOnEngineOff
		{
			get => GetProperty(ref _vehicleOnEngineOff);
			set => SetProperty(ref _vehicleOnEngineOff, value);
		}

		public VehicleQuestToggleEngineEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
