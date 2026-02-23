using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCompassWidgetGameController : gameuiHUDGameController
	{
		private inkWidgetReference _compassWidget;

		[Ordinal(9)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetProperty(ref _compassWidget);
			set => SetProperty(ref _compassWidget, value);
		}

		public gameuiCompassWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
