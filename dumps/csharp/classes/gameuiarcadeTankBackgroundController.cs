using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankBackgroundController : gameuiarcadeArcadeBackgroundController
	{
		private inkWidgetReference _decorationSpawner;

		[Ordinal(2)] 
		[RED("decorationSpawner")] 
		public inkWidgetReference DecorationSpawner
		{
			get => GetProperty(ref _decorationSpawner);
			set => SetProperty(ref _decorationSpawner, value);
		}

		public gameuiarcadeTankBackgroundController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
