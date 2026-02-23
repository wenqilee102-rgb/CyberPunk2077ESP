using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotEffect_FOV : vehicleTimedCinematicCameraShotEffect
	{
		private CName _curve;
		private CFloat _startFOV;
		private CFloat _endFOV;

		[Ordinal(3)] 
		[RED("curve")] 
		public CName Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(4)] 
		[RED("startFOV")] 
		public CFloat StartFOV
		{
			get => GetProperty(ref _startFOV);
			set => SetProperty(ref _startFOV, value);
		}

		[Ordinal(5)] 
		[RED("endFOV")] 
		public CFloat EndFOV
		{
			get => GetProperty(ref _endFOV);
			set => SetProperty(ref _endFOV, value);
		}

		public cameraShotEffect_FOV(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
