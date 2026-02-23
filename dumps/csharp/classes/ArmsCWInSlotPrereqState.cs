using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArmsCWInSlotPrereqState : gamePrereqState
	{
		private CHandle<ArmsCWInSlotCallback> _listener;
		private wCHandle<gameObject> _owner;

		[Ordinal(0)] 
		[RED("listener")] 
		public CHandle<ArmsCWInSlotCallback> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(1)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		public ArmsCWInSlotPrereqState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
