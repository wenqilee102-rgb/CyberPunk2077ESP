using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StandEvents : LocomotionGroundEvents
	{
		private CBool _enteredAfterSprintWithNoInput;

		[Ordinal(6)] 
		[RED("enteredAfterSprintWithNoInput")] 
		public CBool EnteredAfterSprintWithNoInput
		{
			get => GetProperty(ref _enteredAfterSprintWithNoInput);
			set => SetProperty(ref _enteredAfterSprintWithNoInput, value);
		}

		public StandEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
