using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankPlayerHealthController : inkWidgetLogicController
	{
		private inkWidgetReference _health;

		[Ordinal(1)] 
		[RED("health")] 
		public inkWidgetReference Health
		{
			get => GetProperty(ref _health);
			set => SetProperty(ref _health, value);
		}

		public gameuiarcadeTankPlayerHealthController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
