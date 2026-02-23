using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BunkerMapGameController : StatusScreenGameController
	{
		private inkWidgetReference _mapPosition01;
		private inkWidgetReference _mapPosition02;
		private inkWidgetReference _mapPosition03;

		[Ordinal(10)] 
		[RED("mapPosition01")] 
		public inkWidgetReference MapPosition01
		{
			get => GetProperty(ref _mapPosition01);
			set => SetProperty(ref _mapPosition01, value);
		}

		[Ordinal(11)] 
		[RED("mapPosition02")] 
		public inkWidgetReference MapPosition02
		{
			get => GetProperty(ref _mapPosition02);
			set => SetProperty(ref _mapPosition02, value);
		}

		[Ordinal(12)] 
		[RED("mapPosition03")] 
		public inkWidgetReference MapPosition03
		{
			get => GetProperty(ref _mapPosition03);
			set => SetProperty(ref _mapPosition03, value);
		}

		public BunkerMapGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
