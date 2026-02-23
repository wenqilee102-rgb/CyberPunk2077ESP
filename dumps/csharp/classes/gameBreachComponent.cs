using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBreachComponent : entIPlacedComponent
	{
		private CFloat _radius;
		private CFloat _healthPercentageOverride;

		[Ordinal(5)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(6)] 
		[RED("healthPercentageOverride")] 
		public CFloat HealthPercentageOverride
		{
			get => GetProperty(ref _healthPercentageOverride);
			set => SetProperty(ref _healthPercentageOverride, value);
		}

		public gameBreachComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
