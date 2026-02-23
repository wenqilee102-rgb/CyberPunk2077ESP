using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiFPSCounterGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _counterWidget;

		[Ordinal(9)] 
		[RED("counterWidget")] 
		public inkTextWidgetReference CounterWidget
		{
			get => GetProperty(ref _counterWidget);
			set => SetProperty(ref _counterWidget, value);
		}

		public gameuiFPSCounterGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
