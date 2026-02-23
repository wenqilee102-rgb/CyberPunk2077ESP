using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentDefinition : CResource
	{
		private WorldRenderAreaSettings _worldRenderSettings;
		private WorldShadowConfig _worldShadowConfig;
		private WorldLightingConfig _worldLightingConfig;
		private RenderSettingFactors _renderSettingFactors;
		private CArray<CHandle<worldWeatherState>> _weatherStates;
		private CArray<CHandle<worldWeatherStateTransition>> _weatherStateTransitions;
		private CArray<rRef<worldEnvironmentAreaParameters>> _areaEnvironmentParameterLayers;
		private CUInt8 _resourceVersion;

		[Ordinal(1)] 
		[RED("worldRenderSettings")] 
		public WorldRenderAreaSettings WorldRenderSettings
		{
			get => GetProperty(ref _worldRenderSettings);
			set => SetProperty(ref _worldRenderSettings, value);
		}

		[Ordinal(2)] 
		[RED("worldShadowConfig")] 
		public WorldShadowConfig WorldShadowConfig
		{
			get => GetProperty(ref _worldShadowConfig);
			set => SetProperty(ref _worldShadowConfig, value);
		}

		[Ordinal(3)] 
		[RED("worldLightingConfig")] 
		public WorldLightingConfig WorldLightingConfig
		{
			get => GetProperty(ref _worldLightingConfig);
			set => SetProperty(ref _worldLightingConfig, value);
		}

		[Ordinal(4)] 
		[RED("renderSettingFactors")] 
		public RenderSettingFactors RenderSettingFactors
		{
			get => GetProperty(ref _renderSettingFactors);
			set => SetProperty(ref _renderSettingFactors, value);
		}

		[Ordinal(5)] 
		[RED("weatherStates")] 
		public CArray<CHandle<worldWeatherState>> WeatherStates
		{
			get => GetProperty(ref _weatherStates);
			set => SetProperty(ref _weatherStates, value);
		}

		[Ordinal(6)] 
		[RED("weatherStateTransitions")] 
		public CArray<CHandle<worldWeatherStateTransition>> WeatherStateTransitions
		{
			get => GetProperty(ref _weatherStateTransitions);
			set => SetProperty(ref _weatherStateTransitions, value);
		}

		[Ordinal(7)] 
		[RED("areaEnvironmentParameterLayers")] 
		public CArray<rRef<worldEnvironmentAreaParameters>> AreaEnvironmentParameterLayers
		{
			get => GetProperty(ref _areaEnvironmentParameterLayers);
			set => SetProperty(ref _areaEnvironmentParameterLayers, value);
		}

		[Ordinal(8)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetProperty(ref _resourceVersion);
			set => SetProperty(ref _resourceVersion, value);
		}

		public worldEnvironmentDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
