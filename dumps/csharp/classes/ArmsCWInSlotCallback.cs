using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmsCWInSlotCallback : gameAttachmentSlotsScriptCallback
	{
		private wCHandle<ArmsCWInSlotPrereqState> _state;

		[Ordinal(2)] 
		[RED("state")] 
		public wCHandle<ArmsCWInSlotPrereqState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		public ArmsCWInSlotCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
