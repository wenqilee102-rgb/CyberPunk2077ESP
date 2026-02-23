using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankCounterHUDController : inkWidgetLogicController
	{
		private inkTextWidgetReference _counterText;

		[Ordinal(1)] 
		[RED("counterText")] 
		public inkTextWidgetReference CounterText
		{
			get => GetProperty(ref _counterText);
			set => SetProperty(ref _counterText, value);
		}

		public gameuiarcadeTankCounterHUDController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
