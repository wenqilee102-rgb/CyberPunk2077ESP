using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameFreeCameraSettings : CVariable
	{
		private CFloat _movPrecision;
		private CFloat _rotPrecision;
		private CFloat _roll;
		private CFloat _fov;
		private CFloat _dofIntensity;
		private CFloat _dofNearBlur;
		private CFloat _dofNearFocus;
		private CFloat _dofFarBlur;
		private CFloat _dofFarFocus;
		private CInt32 _iso;
		private CFloat _shutter;
		private CFloat _aperture;
		private CArray<gameFreeCameraLightSettings> _lights;

		[Ordinal(0)] 
		[RED("movPrecision")] 
		public CFloat MovPrecision
		{
			get => GetProperty(ref _movPrecision);
			set => SetProperty(ref _movPrecision, value);
		}

		[Ordinal(1)] 
		[RED("rotPrecision")] 
		public CFloat RotPrecision
		{
			get => GetProperty(ref _rotPrecision);
			set => SetProperty(ref _rotPrecision, value);
		}

		[Ordinal(2)] 
		[RED("roll")] 
		public CFloat Roll
		{
			get => GetProperty(ref _roll);
			set => SetProperty(ref _roll, value);
		}

		[Ordinal(3)] 
		[RED("fov")] 
		public CFloat Fov
		{
			get => GetProperty(ref _fov);
			set => SetProperty(ref _fov, value);
		}

		[Ordinal(4)] 
		[RED("dofIntensity")] 
		public CFloat DofIntensity
		{
			get => GetProperty(ref _dofIntensity);
			set => SetProperty(ref _dofIntensity, value);
		}

		[Ordinal(5)] 
		[RED("dofNearBlur")] 
		public CFloat DofNearBlur
		{
			get => GetProperty(ref _dofNearBlur);
			set => SetProperty(ref _dofNearBlur, value);
		}

		[Ordinal(6)] 
		[RED("dofNearFocus")] 
		public CFloat DofNearFocus
		{
			get => GetProperty(ref _dofNearFocus);
			set => SetProperty(ref _dofNearFocus, value);
		}

		[Ordinal(7)] 
		[RED("dofFarBlur")] 
		public CFloat DofFarBlur
		{
			get => GetProperty(ref _dofFarBlur);
			set => SetProperty(ref _dofFarBlur, value);
		}

		[Ordinal(8)] 
		[RED("dofFarFocus")] 
		public CFloat DofFarFocus
		{
			get => GetProperty(ref _dofFarFocus);
			set => SetProperty(ref _dofFarFocus, value);
		}

		[Ordinal(9)] 
		[RED("iso")] 
		public CInt32 Iso
		{
			get => GetProperty(ref _iso);
			set => SetProperty(ref _iso, value);
		}

		[Ordinal(10)] 
		[RED("shutter")] 
		public CFloat Shutter
		{
			get => GetProperty(ref _shutter);
			set => SetProperty(ref _shutter, value);
		}

		[Ordinal(11)] 
		[RED("aperture")] 
		public CFloat Aperture
		{
			get => GetProperty(ref _aperture);
			set => SetProperty(ref _aperture, value);
		}

		[Ordinal(12)] 
		[RED("lights")] 
		public CArray<gameFreeCameraLightSettings> Lights
		{
			get => GetProperty(ref _lights);
			set => SetProperty(ref _lights, value);
		}

		public gameFreeCameraSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
