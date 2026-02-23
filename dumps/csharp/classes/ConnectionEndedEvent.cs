using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ConnectionEndedEvent : redEvent
	{
		private CHandle<TogglePersonalLink> _togglePersonalLinkAction;

		[Ordinal(0)] 
		[RED("togglePersonalLinkAction")] 
		public CHandle<TogglePersonalLink> TogglePersonalLinkAction
		{
			get => GetProperty(ref _togglePersonalLinkAction);
			set => SetProperty(ref _togglePersonalLinkAction, value);
		}

		public ConnectionEndedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
