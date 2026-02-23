using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRaceBackgroundController : gameuiarcadeArcadeBackgroundController
	{
		private CArray<CFloat> _parallaxPlaneRelativeVelocityList;
		private inkWidgetReference _daynightWidget;
		private inkWidgetReference _backgroundObjectSpawner;
		private inkWidgetReference _cloudSpawner;

		[Ordinal(2)] 
		[RED("parallaxPlaneRelativeVelocityList")] 
		public CArray<CFloat> ParallaxPlaneRelativeVelocityList
		{
			get => GetProperty(ref _parallaxPlaneRelativeVelocityList);
			set => SetProperty(ref _parallaxPlaneRelativeVelocityList, value);
		}

		[Ordinal(3)] 
		[RED("daynightWidget")] 
		public inkWidgetReference DaynightWidget
		{
			get => GetProperty(ref _daynightWidget);
			set => SetProperty(ref _daynightWidget, value);
		}

		[Ordinal(4)] 
		[RED("backgroundObjectSpawner")] 
		public inkWidgetReference BackgroundObjectSpawner
		{
			get => GetProperty(ref _backgroundObjectSpawner);
			set => SetProperty(ref _backgroundObjectSpawner, value);
		}

		[Ordinal(5)] 
		[RED("cloudSpawner")] 
		public inkWidgetReference CloudSpawner
		{
			get => GetProperty(ref _cloudSpawner);
			set => SetProperty(ref _cloudSpawner, value);
		}

		public gameuiarcadeRoachRaceBackgroundController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
