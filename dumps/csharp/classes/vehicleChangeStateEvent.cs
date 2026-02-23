using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleChangeStateEvent : redEvent
	{
		private CEnum<vehicleEState> _newState;
		private CEnum<vehicleEState> _oldState;

		[Ordinal(0)] 
		[RED("newState")] 
		public CEnum<vehicleEState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		[Ordinal(1)] 
		[RED("oldState")] 
		public CEnum<vehicleEState> OldState
		{
			get => GetProperty(ref _oldState);
			set => SetProperty(ref _oldState, value);
		}

		public vehicleChangeStateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
