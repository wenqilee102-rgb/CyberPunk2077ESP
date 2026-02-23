using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotEffect_Shake : vehicleCinematicCameraShotEffect_EulerAnglesDamper
	{
		private CFloat _shakeStrength;
		private CFloat _frequency;

		[Ordinal(5)] 
		[RED("shakeStrength")] 
		public CFloat ShakeStrength
		{
			get => GetProperty(ref _shakeStrength);
			set => SetProperty(ref _shakeStrength, value);
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get => GetProperty(ref _frequency);
			set => SetProperty(ref _frequency, value);
		}

		public cameraShotEffect_Shake(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
