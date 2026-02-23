using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CloudAreaSettings : IAreaSettings
	{
		private curveData<CFloat> _cloudSunShadowFaloff;
		private curveData<CFloat> _cloudSunScattering;
		private curveData<CFloat> _cloudMoonScattering;
		private curveData<HDRColor> _cloudLightColor;
		private curveData<CFloat> _cloudAmbientIntensity;
		private curveData<CFloat> _cloudCirrusOpacity;
		private curveData<CFloat> _cloudCirrusScale;
		private curveData<CFloat> _cloudCirrusAltitude;
		private rRef<CBitmapTexture> _cloudCirrusTexture;
		private rRef<CBitmapTexture> _volWeatherTexture;
		private rRef<CBitmapTexture> _volNoiseTexture;
		private CFloat _volHorizonCoverage;
		private curveData<CFloat> _volCoverage;
		private curveData<CFloat> _volDensity;
		private CFloat _cloudsBottom;
		private CFloat _cloudsTop;
		private CFloat _rayStartOffset;
		private CFloat _rayStartFalloff;
		private curveData<CFloat> _lightIntensity;
		private curveData<CFloat> _reflectionProbeLightIntensity;
		private curveData<CFloat> _shadowIntensity;
		private curveData<CFloat> _worldShadowIntensity;
		private curveData<CFloat> _ambientIntensity;
		private curveData<CFloat> _ambientOutscatter;
		private CFloat _inScatter;
		private CFloat _outScatter;
		private CFloat _inVsOutScatter;
		private CFloat _silverLining;
		private CFloat _volCoverageWindInfluence;
		private CFloat _volNoiseWindInfluence;
		private CFloat _volDetailWindInfluence;
		private CFloat _volDistantFogOpacity;
		private Vector2 _volCoverageOffset;

		[Ordinal(2)] 
		[RED("cloudSunShadowFaloff")] 
		public curveData<CFloat> CloudSunShadowFaloff
		{
			get => GetProperty(ref _cloudSunShadowFaloff);
			set => SetProperty(ref _cloudSunShadowFaloff, value);
		}

		[Ordinal(3)] 
		[RED("cloudSunScattering")] 
		public curveData<CFloat> CloudSunScattering
		{
			get => GetProperty(ref _cloudSunScattering);
			set => SetProperty(ref _cloudSunScattering, value);
		}

		[Ordinal(4)] 
		[RED("cloudMoonScattering")] 
		public curveData<CFloat> CloudMoonScattering
		{
			get => GetProperty(ref _cloudMoonScattering);
			set => SetProperty(ref _cloudMoonScattering, value);
		}

		[Ordinal(5)] 
		[RED("cloudLightColor")] 
		public curveData<HDRColor> CloudLightColor
		{
			get => GetProperty(ref _cloudLightColor);
			set => SetProperty(ref _cloudLightColor, value);
		}

		[Ordinal(6)] 
		[RED("cloudAmbientIntensity")] 
		public curveData<CFloat> CloudAmbientIntensity
		{
			get => GetProperty(ref _cloudAmbientIntensity);
			set => SetProperty(ref _cloudAmbientIntensity, value);
		}

		[Ordinal(7)] 
		[RED("cloudCirrusOpacity")] 
		public curveData<CFloat> CloudCirrusOpacity
		{
			get => GetProperty(ref _cloudCirrusOpacity);
			set => SetProperty(ref _cloudCirrusOpacity, value);
		}

		[Ordinal(8)] 
		[RED("cloudCirrusScale")] 
		public curveData<CFloat> CloudCirrusScale
		{
			get => GetProperty(ref _cloudCirrusScale);
			set => SetProperty(ref _cloudCirrusScale, value);
		}

		[Ordinal(9)] 
		[RED("cloudCirrusAltitude")] 
		public curveData<CFloat> CloudCirrusAltitude
		{
			get => GetProperty(ref _cloudCirrusAltitude);
			set => SetProperty(ref _cloudCirrusAltitude, value);
		}

		[Ordinal(10)] 
		[RED("cloudCirrusTexture")] 
		public rRef<CBitmapTexture> CloudCirrusTexture
		{
			get => GetProperty(ref _cloudCirrusTexture);
			set => SetProperty(ref _cloudCirrusTexture, value);
		}

		[Ordinal(11)] 
		[RED("volWeatherTexture")] 
		public rRef<CBitmapTexture> VolWeatherTexture
		{
			get => GetProperty(ref _volWeatherTexture);
			set => SetProperty(ref _volWeatherTexture, value);
		}

		[Ordinal(12)] 
		[RED("volNoiseTexture")] 
		public rRef<CBitmapTexture> VolNoiseTexture
		{
			get => GetProperty(ref _volNoiseTexture);
			set => SetProperty(ref _volNoiseTexture, value);
		}

		[Ordinal(13)] 
		[RED("volHorizonCoverage")] 
		public CFloat VolHorizonCoverage
		{
			get => GetProperty(ref _volHorizonCoverage);
			set => SetProperty(ref _volHorizonCoverage, value);
		}

		[Ordinal(14)] 
		[RED("volCoverage")] 
		public curveData<CFloat> VolCoverage
		{
			get => GetProperty(ref _volCoverage);
			set => SetProperty(ref _volCoverage, value);
		}

		[Ordinal(15)] 
		[RED("volDensity")] 
		public curveData<CFloat> VolDensity
		{
			get => GetProperty(ref _volDensity);
			set => SetProperty(ref _volDensity, value);
		}

		[Ordinal(16)] 
		[RED("cloudsBottom")] 
		public CFloat CloudsBottom
		{
			get => GetProperty(ref _cloudsBottom);
			set => SetProperty(ref _cloudsBottom, value);
		}

		[Ordinal(17)] 
		[RED("cloudsTop")] 
		public CFloat CloudsTop
		{
			get => GetProperty(ref _cloudsTop);
			set => SetProperty(ref _cloudsTop, value);
		}

		[Ordinal(18)] 
		[RED("rayStartOffset")] 
		public CFloat RayStartOffset
		{
			get => GetProperty(ref _rayStartOffset);
			set => SetProperty(ref _rayStartOffset, value);
		}

		[Ordinal(19)] 
		[RED("rayStartFalloff")] 
		public CFloat RayStartFalloff
		{
			get => GetProperty(ref _rayStartFalloff);
			set => SetProperty(ref _rayStartFalloff, value);
		}

		[Ordinal(20)] 
		[RED("lightIntensity")] 
		public curveData<CFloat> LightIntensity
		{
			get => GetProperty(ref _lightIntensity);
			set => SetProperty(ref _lightIntensity, value);
		}

		[Ordinal(21)] 
		[RED("reflectionProbeLightIntensity")] 
		public curveData<CFloat> ReflectionProbeLightIntensity
		{
			get => GetProperty(ref _reflectionProbeLightIntensity);
			set => SetProperty(ref _reflectionProbeLightIntensity, value);
		}

		[Ordinal(22)] 
		[RED("shadowIntensity")] 
		public curveData<CFloat> ShadowIntensity
		{
			get => GetProperty(ref _shadowIntensity);
			set => SetProperty(ref _shadowIntensity, value);
		}

		[Ordinal(23)] 
		[RED("worldShadowIntensity")] 
		public curveData<CFloat> WorldShadowIntensity
		{
			get => GetProperty(ref _worldShadowIntensity);
			set => SetProperty(ref _worldShadowIntensity, value);
		}

		[Ordinal(24)] 
		[RED("ambientIntensity")] 
		public curveData<CFloat> AmbientIntensity
		{
			get => GetProperty(ref _ambientIntensity);
			set => SetProperty(ref _ambientIntensity, value);
		}

		[Ordinal(25)] 
		[RED("ambientOutscatter")] 
		public curveData<CFloat> AmbientOutscatter
		{
			get => GetProperty(ref _ambientOutscatter);
			set => SetProperty(ref _ambientOutscatter, value);
		}

		[Ordinal(26)] 
		[RED("inScatter")] 
		public CFloat InScatter
		{
			get => GetProperty(ref _inScatter);
			set => SetProperty(ref _inScatter, value);
		}

		[Ordinal(27)] 
		[RED("outScatter")] 
		public CFloat OutScatter
		{
			get => GetProperty(ref _outScatter);
			set => SetProperty(ref _outScatter, value);
		}

		[Ordinal(28)] 
		[RED("inVsOutScatter")] 
		public CFloat InVsOutScatter
		{
			get => GetProperty(ref _inVsOutScatter);
			set => SetProperty(ref _inVsOutScatter, value);
		}

		[Ordinal(29)] 
		[RED("silverLining")] 
		public CFloat SilverLining
		{
			get => GetProperty(ref _silverLining);
			set => SetProperty(ref _silverLining, value);
		}

		[Ordinal(30)] 
		[RED("volCoverageWindInfluence")] 
		public CFloat VolCoverageWindInfluence
		{
			get => GetProperty(ref _volCoverageWindInfluence);
			set => SetProperty(ref _volCoverageWindInfluence, value);
		}

		[Ordinal(31)] 
		[RED("volNoiseWindInfluence")] 
		public CFloat VolNoiseWindInfluence
		{
			get => GetProperty(ref _volNoiseWindInfluence);
			set => SetProperty(ref _volNoiseWindInfluence, value);
		}

		[Ordinal(32)] 
		[RED("volDetailWindInfluence")] 
		public CFloat VolDetailWindInfluence
		{
			get => GetProperty(ref _volDetailWindInfluence);
			set => SetProperty(ref _volDetailWindInfluence, value);
		}

		[Ordinal(33)] 
		[RED("volDistantFogOpacity")] 
		public CFloat VolDistantFogOpacity
		{
			get => GetProperty(ref _volDistantFogOpacity);
			set => SetProperty(ref _volDistantFogOpacity, value);
		}

		[Ordinal(34)] 
		[RED("volCoverageOffset")] 
		public Vector2 VolCoverageOffset
		{
			get => GetProperty(ref _volCoverageOffset);
			set => SetProperty(ref _volCoverageOffset, value);
		}

		public CloudAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
