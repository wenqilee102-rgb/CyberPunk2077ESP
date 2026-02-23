using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PathTracingSettings : IAreaSettings
	{
		private CFloat _albedoModulation;
		private CFloat _diffuseGlobalScale;
		private CFloat _diffuseSunScale;
		private CFloat _diffuseSkyScale;
		private CFloat _diffuseLocalLightsScale;
		private CFloat _diffuseEmissiveScale;
		private CFloat _specularGlobalScale;
		private CFloat _specularSunScale;
		private CFloat _specularSkyScale;
		private CFloat _specularLocalLightsScale;
		private CFloat _specularEmissiveScale;
		private CFloat _maxIntensity;
		private CFloat _gIOnlyLightScale;
		private CUInt32 _rayNumber;
		private CUInt32 _bounceNumber;
		private CUInt32 _rayNumberScreenshot;
		private CUInt32 _bounceNumberScreenshot;

		[Ordinal(2)] 
		[RED("albedoModulation")] 
		public CFloat AlbedoModulation
		{
			get => GetProperty(ref _albedoModulation);
			set => SetProperty(ref _albedoModulation, value);
		}

		[Ordinal(3)] 
		[RED("diffuseGlobalScale")] 
		public CFloat DiffuseGlobalScale
		{
			get => GetProperty(ref _diffuseGlobalScale);
			set => SetProperty(ref _diffuseGlobalScale, value);
		}

		[Ordinal(4)] 
		[RED("diffuseSunScale")] 
		public CFloat DiffuseSunScale
		{
			get => GetProperty(ref _diffuseSunScale);
			set => SetProperty(ref _diffuseSunScale, value);
		}

		[Ordinal(5)] 
		[RED("diffuseSkyScale")] 
		public CFloat DiffuseSkyScale
		{
			get => GetProperty(ref _diffuseSkyScale);
			set => SetProperty(ref _diffuseSkyScale, value);
		}

		[Ordinal(6)] 
		[RED("diffuseLocalLightsScale")] 
		public CFloat DiffuseLocalLightsScale
		{
			get => GetProperty(ref _diffuseLocalLightsScale);
			set => SetProperty(ref _diffuseLocalLightsScale, value);
		}

		[Ordinal(7)] 
		[RED("diffuseEmissiveScale")] 
		public CFloat DiffuseEmissiveScale
		{
			get => GetProperty(ref _diffuseEmissiveScale);
			set => SetProperty(ref _diffuseEmissiveScale, value);
		}

		[Ordinal(8)] 
		[RED("specularGlobalScale")] 
		public CFloat SpecularGlobalScale
		{
			get => GetProperty(ref _specularGlobalScale);
			set => SetProperty(ref _specularGlobalScale, value);
		}

		[Ordinal(9)] 
		[RED("specularSunScale")] 
		public CFloat SpecularSunScale
		{
			get => GetProperty(ref _specularSunScale);
			set => SetProperty(ref _specularSunScale, value);
		}

		[Ordinal(10)] 
		[RED("specularSkyScale")] 
		public CFloat SpecularSkyScale
		{
			get => GetProperty(ref _specularSkyScale);
			set => SetProperty(ref _specularSkyScale, value);
		}

		[Ordinal(11)] 
		[RED("specularLocalLightsScale")] 
		public CFloat SpecularLocalLightsScale
		{
			get => GetProperty(ref _specularLocalLightsScale);
			set => SetProperty(ref _specularLocalLightsScale, value);
		}

		[Ordinal(12)] 
		[RED("specularEmissiveScale")] 
		public CFloat SpecularEmissiveScale
		{
			get => GetProperty(ref _specularEmissiveScale);
			set => SetProperty(ref _specularEmissiveScale, value);
		}

		[Ordinal(13)] 
		[RED("maxIntensity")] 
		public CFloat MaxIntensity
		{
			get => GetProperty(ref _maxIntensity);
			set => SetProperty(ref _maxIntensity, value);
		}

		[Ordinal(14)] 
		[RED("GIOnlyLightScale")] 
		public CFloat GIOnlyLightScale
		{
			get => GetProperty(ref _gIOnlyLightScale);
			set => SetProperty(ref _gIOnlyLightScale, value);
		}

		[Ordinal(15)] 
		[RED("rayNumber")] 
		public CUInt32 RayNumber
		{
			get => GetProperty(ref _rayNumber);
			set => SetProperty(ref _rayNumber, value);
		}

		[Ordinal(16)] 
		[RED("bounceNumber")] 
		public CUInt32 BounceNumber
		{
			get => GetProperty(ref _bounceNumber);
			set => SetProperty(ref _bounceNumber, value);
		}

		[Ordinal(17)] 
		[RED("rayNumberScreenshot")] 
		public CUInt32 RayNumberScreenshot
		{
			get => GetProperty(ref _rayNumberScreenshot);
			set => SetProperty(ref _rayNumberScreenshot, value);
		}

		[Ordinal(18)] 
		[RED("bounceNumberScreenshot")] 
		public CUInt32 BounceNumberScreenshot
		{
			get => GetProperty(ref _bounceNumberScreenshot);
			set => SetProperty(ref _bounceNumberScreenshot, value);
		}

		public PathTracingSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
