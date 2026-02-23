using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotEffect_EulerAnglesDamper : vehicleTimedCinematicCameraShotEffect
	{
		private CName _dampingCurve;
		private CFloat _damping;

		[Ordinal(3)] 
		[RED("dampingCurve")] 
		public CName DampingCurve
		{
			get => GetProperty(ref _dampingCurve);
			set => SetProperty(ref _dampingCurve, value);
		}

		[Ordinal(4)] 
		[RED("damping")] 
		public CFloat Damping
		{
			get => GetProperty(ref _damping);
			set => SetProperty(ref _damping, value);
		}

		public vehicleCinematicCameraShotEffect_EulerAnglesDamper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
