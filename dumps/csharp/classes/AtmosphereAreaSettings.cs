using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AtmosphereAreaSettings : IAreaSettings
	{
		private curveData<HDRColor> _skydomeColor;
		private curveData<HDRColor> _skylightColor;
		private curveData<HDRColor> _groundReflectance;
		private curveData<CFloat> _sunMinZ;
		private curveData<CFloat> _horizonMinZ;
		private curveData<CFloat> _horizonFalloff;
		private curveData<CFloat> _turbidity;
		private curveData<CFloat> _lutTurbidity;
		private curveData<HDRColor> _artisticDarkeningColor;
		private curveData<CFloat> _artisticDarkeningStartPoint;
		private curveData<CFloat> _artisticDarkeningEndPoint;
		private curveData<CFloat> _artisticDarkeningExponent;
		private curveData<HDRColor> _sunColor;
		private curveData<CFloat> _sunFalloff;
		private curveData<CFloat> _rayTracedSunShadowRange;
		private curveData<HDRColor> _moonColor;
		private curveData<CFloat> _moonFalloff;
		private curveData<CFloat> _moonGlowIntensity;
		private curveData<CFloat> _moonGlowFalloff;
		private rRef<CBitmapTexture> _moonTexture;
		private curveData<CFloat> _galaxyIntensity;
		private curveData<CFloat> _starMapIntensity;
		private curveData<CFloat> _starMapBrightScale;
		private curveData<CFloat> _starMapDimScale;
		private curveData<CFloat> _starMapConstelationsScale;
		private curveData<CFloat> _starCornerLuminanceFix;
		private rRef<CCubeTexture> _starMapTexture;
		private rRef<CBitmapTexture> _galaxyTexture;
		private curveData<HDRColor> _probeColorOverrideHorizon;
		private curveData<CFloat> _probeAlphaOverrideHorizon;
		private curveData<HDRColor> _probeColorOverrideZenith;
		private curveData<CFloat> _probeAlphaOverrideZenith;

		[Ordinal(2)] 
		[RED("skydomeColor")] 
		public curveData<HDRColor> SkydomeColor
		{
			get => GetProperty(ref _skydomeColor);
			set => SetProperty(ref _skydomeColor, value);
		}

		[Ordinal(3)] 
		[RED("skylightColor")] 
		public curveData<HDRColor> SkylightColor
		{
			get => GetProperty(ref _skylightColor);
			set => SetProperty(ref _skylightColor, value);
		}

		[Ordinal(4)] 
		[RED("groundReflectance")] 
		public curveData<HDRColor> GroundReflectance
		{
			get => GetProperty(ref _groundReflectance);
			set => SetProperty(ref _groundReflectance, value);
		}

		[Ordinal(5)] 
		[RED("sunMinZ")] 
		public curveData<CFloat> SunMinZ
		{
			get => GetProperty(ref _sunMinZ);
			set => SetProperty(ref _sunMinZ, value);
		}

		[Ordinal(6)] 
		[RED("horizonMinZ")] 
		public curveData<CFloat> HorizonMinZ
		{
			get => GetProperty(ref _horizonMinZ);
			set => SetProperty(ref _horizonMinZ, value);
		}

		[Ordinal(7)] 
		[RED("horizonFalloff")] 
		public curveData<CFloat> HorizonFalloff
		{
			get => GetProperty(ref _horizonFalloff);
			set => SetProperty(ref _horizonFalloff, value);
		}

		[Ordinal(8)] 
		[RED("turbidity")] 
		public curveData<CFloat> Turbidity
		{
			get => GetProperty(ref _turbidity);
			set => SetProperty(ref _turbidity, value);
		}

		[Ordinal(9)] 
		[RED("lutTurbidity")] 
		public curveData<CFloat> LutTurbidity
		{
			get => GetProperty(ref _lutTurbidity);
			set => SetProperty(ref _lutTurbidity, value);
		}

		[Ordinal(10)] 
		[RED("artisticDarkeningColor")] 
		public curveData<HDRColor> ArtisticDarkeningColor
		{
			get => GetProperty(ref _artisticDarkeningColor);
			set => SetProperty(ref _artisticDarkeningColor, value);
		}

		[Ordinal(11)] 
		[RED("artisticDarkeningStartPoint")] 
		public curveData<CFloat> ArtisticDarkeningStartPoint
		{
			get => GetProperty(ref _artisticDarkeningStartPoint);
			set => SetProperty(ref _artisticDarkeningStartPoint, value);
		}

		[Ordinal(12)] 
		[RED("artisticDarkeningEndPoint")] 
		public curveData<CFloat> ArtisticDarkeningEndPoint
		{
			get => GetProperty(ref _artisticDarkeningEndPoint);
			set => SetProperty(ref _artisticDarkeningEndPoint, value);
		}

		[Ordinal(13)] 
		[RED("artisticDarkeningExponent")] 
		public curveData<CFloat> ArtisticDarkeningExponent
		{
			get => GetProperty(ref _artisticDarkeningExponent);
			set => SetProperty(ref _artisticDarkeningExponent, value);
		}

		[Ordinal(14)] 
		[RED("sunColor")] 
		public curveData<HDRColor> SunColor
		{
			get => GetProperty(ref _sunColor);
			set => SetProperty(ref _sunColor, value);
		}

		[Ordinal(15)] 
		[RED("sunFalloff")] 
		public curveData<CFloat> SunFalloff
		{
			get => GetProperty(ref _sunFalloff);
			set => SetProperty(ref _sunFalloff, value);
		}

		[Ordinal(16)] 
		[RED("rayTracedSunShadowRange")] 
		public curveData<CFloat> RayTracedSunShadowRange
		{
			get => GetProperty(ref _rayTracedSunShadowRange);
			set => SetProperty(ref _rayTracedSunShadowRange, value);
		}

		[Ordinal(17)] 
		[RED("moonColor")] 
		public curveData<HDRColor> MoonColor
		{
			get => GetProperty(ref _moonColor);
			set => SetProperty(ref _moonColor, value);
		}

		[Ordinal(18)] 
		[RED("moonFalloff")] 
		public curveData<CFloat> MoonFalloff
		{
			get => GetProperty(ref _moonFalloff);
			set => SetProperty(ref _moonFalloff, value);
		}

		[Ordinal(19)] 
		[RED("moonGlowIntensity")] 
		public curveData<CFloat> MoonGlowIntensity
		{
			get => GetProperty(ref _moonGlowIntensity);
			set => SetProperty(ref _moonGlowIntensity, value);
		}

		[Ordinal(20)] 
		[RED("moonGlowFalloff")] 
		public curveData<CFloat> MoonGlowFalloff
		{
			get => GetProperty(ref _moonGlowFalloff);
			set => SetProperty(ref _moonGlowFalloff, value);
		}

		[Ordinal(21)] 
		[RED("moonTexture")] 
		public rRef<CBitmapTexture> MoonTexture
		{
			get => GetProperty(ref _moonTexture);
			set => SetProperty(ref _moonTexture, value);
		}

		[Ordinal(22)] 
		[RED("galaxyIntensity")] 
		public curveData<CFloat> GalaxyIntensity
		{
			get => GetProperty(ref _galaxyIntensity);
			set => SetProperty(ref _galaxyIntensity, value);
		}

		[Ordinal(23)] 
		[RED("starMapIntensity")] 
		public curveData<CFloat> StarMapIntensity
		{
			get => GetProperty(ref _starMapIntensity);
			set => SetProperty(ref _starMapIntensity, value);
		}

		[Ordinal(24)] 
		[RED("starMapBrightScale")] 
		public curveData<CFloat> StarMapBrightScale
		{
			get => GetProperty(ref _starMapBrightScale);
			set => SetProperty(ref _starMapBrightScale, value);
		}

		[Ordinal(25)] 
		[RED("starMapDimScale")] 
		public curveData<CFloat> StarMapDimScale
		{
			get => GetProperty(ref _starMapDimScale);
			set => SetProperty(ref _starMapDimScale, value);
		}

		[Ordinal(26)] 
		[RED("starMapConstelationsScale")] 
		public curveData<CFloat> StarMapConstelationsScale
		{
			get => GetProperty(ref _starMapConstelationsScale);
			set => SetProperty(ref _starMapConstelationsScale, value);
		}

		[Ordinal(27)] 
		[RED("starCornerLuminanceFix")] 
		public curveData<CFloat> StarCornerLuminanceFix
		{
			get => GetProperty(ref _starCornerLuminanceFix);
			set => SetProperty(ref _starCornerLuminanceFix, value);
		}

		[Ordinal(28)] 
		[RED("starMapTexture")] 
		public rRef<CCubeTexture> StarMapTexture
		{
			get => GetProperty(ref _starMapTexture);
			set => SetProperty(ref _starMapTexture, value);
		}

		[Ordinal(29)] 
		[RED("galaxyTexture")] 
		public rRef<CBitmapTexture> GalaxyTexture
		{
			get => GetProperty(ref _galaxyTexture);
			set => SetProperty(ref _galaxyTexture, value);
		}

		[Ordinal(30)] 
		[RED("probeColorOverrideHorizon")] 
		public curveData<HDRColor> ProbeColorOverrideHorizon
		{
			get => GetProperty(ref _probeColorOverrideHorizon);
			set => SetProperty(ref _probeColorOverrideHorizon, value);
		}

		[Ordinal(31)] 
		[RED("probeAlphaOverrideHorizon")] 
		public curveData<CFloat> ProbeAlphaOverrideHorizon
		{
			get => GetProperty(ref _probeAlphaOverrideHorizon);
			set => SetProperty(ref _probeAlphaOverrideHorizon, value);
		}

		[Ordinal(32)] 
		[RED("probeColorOverrideZenith")] 
		public curveData<HDRColor> ProbeColorOverrideZenith
		{
			get => GetProperty(ref _probeColorOverrideZenith);
			set => SetProperty(ref _probeColorOverrideZenith, value);
		}

		[Ordinal(33)] 
		[RED("probeAlphaOverrideZenith")] 
		public curveData<CFloat> ProbeAlphaOverrideZenith
		{
			get => GetProperty(ref _probeAlphaOverrideZenith);
			set => SetProperty(ref _probeAlphaOverrideZenith, value);
		}

		public AtmosphereAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
