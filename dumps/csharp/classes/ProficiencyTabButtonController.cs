using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyTabButtonController : TabButtonController
	{
		private inkWidgetReference _bottom_bar;
		private CHandle<inkanimProxy> _proxy;
		private CBool _isToggledState;

		[Ordinal(21)] 
		[RED("bottom_bar")] 
		public inkWidgetReference Bottom_bar
		{
			get => GetProperty(ref _bottom_bar);
			set => SetProperty(ref _bottom_bar, value);
		}

		[Ordinal(22)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetProperty(ref _proxy);
			set => SetProperty(ref _proxy, value);
		}

		[Ordinal(23)] 
		[RED("isToggledState")] 
		public CBool IsToggledState
		{
			get => GetProperty(ref _isToggledState);
			set => SetProperty(ref _isToggledState, value);
		}

		public ProficiencyTabButtonController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
