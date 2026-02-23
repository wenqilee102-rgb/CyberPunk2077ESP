using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrossplayInfoPanelController : inkWidgetLogicController
	{
		private CBool _signOutEnabled;
		private inkWidgetReference _disconnectBtn;

		[Ordinal(1)] 
		[RED("signOutEnabled")] 
		public CBool SignOutEnabled
		{
			get => GetProperty(ref _signOutEnabled);
			set => SetProperty(ref _signOutEnabled, value);
		}

		[Ordinal(2)] 
		[RED("disconnectBtn")] 
		public inkWidgetReference DisconnectBtn
		{
			get => GetProperty(ref _disconnectBtn);
			set => SetProperty(ref _disconnectBtn, value);
		}

		public CrossplayInfoPanelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
