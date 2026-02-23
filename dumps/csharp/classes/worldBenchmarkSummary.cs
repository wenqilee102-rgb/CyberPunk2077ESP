using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldBenchmarkSummary : IScriptable
	{
		private CString _gameVersion;
		private CString _benchmarkName;
		private CString _gpuName;
		private CUInt64 _gpuMemory;
		private CString _gpuDriverVersion;
		private CString _cpuName;
		private CUInt64 _systemMemory;
		private CString _osName;
		private CString _osVersion;
		private CString _presetName;
		private CName _presetLocalizedName;
		private CName _textureQualityPresetLocalizedName;
		private CUInt32 _renderWidth;
		private CUInt32 _renderHeight;
		private CUInt8 _windowMode;
		private CBool _verticalSync;
		private CInt32 _fpsClamp;
		private CFloat _averageFps;
		private CFloat _minFps;
		private CFloat _maxFps;
		private CFloat _time;
		private CUInt32 _frameNumber;
		private CUInt8 _upscalingType;
		private CUInt8 _frameGenerationType;
		private CBool _dLAAEnabled;
		private CFloat _dLAASharpness;
		private CBool _dLSSEnabled;
		private CInt32 _dLSSPreset;
		private CBool _dLSSDEnabled;
		private CInt32 _dLSSQuality;
		private CFloat _dLSSSharpness;
		private CBool _dLSSFrameGenEnabled;
		private CBool _dLSSMultiFrameGenEnabled;
		private CInt32 _dLSSMultiFrameGenFrameToGenerate;
		private CBool _fSR2Enabled;
		private CInt32 _fSR2Quality;
		private CFloat _fSR2Sharpness;
		private CBool _fSR3Enabled;
		private CInt32 _fSR3Quality;
		private CFloat _fSR3Sharpness;
		private CBool _fSR3FrameGenEnabled;
		private CBool _fSR4Enabled;
		private CInt32 _fSR4Quality;
		private CFloat _fSR4Sharpness;
		private CBool _xeSSEnabled;
		private CInt32 _xeSSQuality;
		private CFloat _xeSSSharpness;
		private CBool _xeSSFrameGenEnabled;
		private CBool _dRSEnabled;
		private CUInt32 _dRSTargetFPS;
		private CUInt32 _dRSMinimalResolutionPercentage;
		private CUInt32 _dRSMaximalResolutionPercentage;
		private CBool _cASSharpeningEnabled;
		private CBool _fSREnabled;
		private CInt32 _fSRQuality;
		private CBool _rayTracingEnabled;
		private CBool _rayTracedReflections;
		private CBool _rayTracedSunShadows;
		private CBool _rayTracedLocalShadows;
		private CInt32 _rayTracedLightingQuality;
		private CBool _rayTracedPathTracingEnabled;

		[Ordinal(0)] 
		[RED("gameVersion")] 
		public CString GameVersion
		{
			get => GetProperty(ref _gameVersion);
			set => SetProperty(ref _gameVersion, value);
		}

		[Ordinal(1)] 
		[RED("benchmarkName")] 
		public CString BenchmarkName
		{
			get => GetProperty(ref _benchmarkName);
			set => SetProperty(ref _benchmarkName, value);
		}

		[Ordinal(2)] 
		[RED("gpuName")] 
		public CString GpuName
		{
			get => GetProperty(ref _gpuName);
			set => SetProperty(ref _gpuName, value);
		}

		[Ordinal(3)] 
		[RED("gpuMemory")] 
		public CUInt64 GpuMemory
		{
			get => GetProperty(ref _gpuMemory);
			set => SetProperty(ref _gpuMemory, value);
		}

		[Ordinal(4)] 
		[RED("gpuDriverVersion")] 
		public CString GpuDriverVersion
		{
			get => GetProperty(ref _gpuDriverVersion);
			set => SetProperty(ref _gpuDriverVersion, value);
		}

		[Ordinal(5)] 
		[RED("cpuName")] 
		public CString CpuName
		{
			get => GetProperty(ref _cpuName);
			set => SetProperty(ref _cpuName, value);
		}

		[Ordinal(6)] 
		[RED("systemMemory")] 
		public CUInt64 SystemMemory
		{
			get => GetProperty(ref _systemMemory);
			set => SetProperty(ref _systemMemory, value);
		}

		[Ordinal(7)] 
		[RED("osName")] 
		public CString OsName
		{
			get => GetProperty(ref _osName);
			set => SetProperty(ref _osName, value);
		}

		[Ordinal(8)] 
		[RED("osVersion")] 
		public CString OsVersion
		{
			get => GetProperty(ref _osVersion);
			set => SetProperty(ref _osVersion, value);
		}

		[Ordinal(9)] 
		[RED("presetName")] 
		public CString PresetName
		{
			get => GetProperty(ref _presetName);
			set => SetProperty(ref _presetName, value);
		}

		[Ordinal(10)] 
		[RED("presetLocalizedName")] 
		public CName PresetLocalizedName
		{
			get => GetProperty(ref _presetLocalizedName);
			set => SetProperty(ref _presetLocalizedName, value);
		}

		[Ordinal(11)] 
		[RED("textureQualityPresetLocalizedName")] 
		public CName TextureQualityPresetLocalizedName
		{
			get => GetProperty(ref _textureQualityPresetLocalizedName);
			set => SetProperty(ref _textureQualityPresetLocalizedName, value);
		}

		[Ordinal(12)] 
		[RED("renderWidth")] 
		public CUInt32 RenderWidth
		{
			get => GetProperty(ref _renderWidth);
			set => SetProperty(ref _renderWidth, value);
		}

		[Ordinal(13)] 
		[RED("renderHeight")] 
		public CUInt32 RenderHeight
		{
			get => GetProperty(ref _renderHeight);
			set => SetProperty(ref _renderHeight, value);
		}

		[Ordinal(14)] 
		[RED("windowMode")] 
		public CUInt8 WindowMode
		{
			get => GetProperty(ref _windowMode);
			set => SetProperty(ref _windowMode, value);
		}

		[Ordinal(15)] 
		[RED("verticalSync")] 
		public CBool VerticalSync
		{
			get => GetProperty(ref _verticalSync);
			set => SetProperty(ref _verticalSync, value);
		}

		[Ordinal(16)] 
		[RED("fpsClamp")] 
		public CInt32 FpsClamp
		{
			get => GetProperty(ref _fpsClamp);
			set => SetProperty(ref _fpsClamp, value);
		}

		[Ordinal(17)] 
		[RED("averageFps")] 
		public CFloat AverageFps
		{
			get => GetProperty(ref _averageFps);
			set => SetProperty(ref _averageFps, value);
		}

		[Ordinal(18)] 
		[RED("minFps")] 
		public CFloat MinFps
		{
			get => GetProperty(ref _minFps);
			set => SetProperty(ref _minFps, value);
		}

		[Ordinal(19)] 
		[RED("maxFps")] 
		public CFloat MaxFps
		{
			get => GetProperty(ref _maxFps);
			set => SetProperty(ref _maxFps, value);
		}

		[Ordinal(20)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(21)] 
		[RED("frameNumber")] 
		public CUInt32 FrameNumber
		{
			get => GetProperty(ref _frameNumber);
			set => SetProperty(ref _frameNumber, value);
		}

		[Ordinal(22)] 
		[RED("upscalingType")] 
		public CUInt8 UpscalingType
		{
			get => GetProperty(ref _upscalingType);
			set => SetProperty(ref _upscalingType, value);
		}

		[Ordinal(23)] 
		[RED("frameGenerationType")] 
		public CUInt8 FrameGenerationType
		{
			get => GetProperty(ref _frameGenerationType);
			set => SetProperty(ref _frameGenerationType, value);
		}

		[Ordinal(24)] 
		[RED("DLAAEnabled")] 
		public CBool DLAAEnabled
		{
			get => GetProperty(ref _dLAAEnabled);
			set => SetProperty(ref _dLAAEnabled, value);
		}

		[Ordinal(25)] 
		[RED("DLAASharpness")] 
		public CFloat DLAASharpness
		{
			get => GetProperty(ref _dLAASharpness);
			set => SetProperty(ref _dLAASharpness, value);
		}

		[Ordinal(26)] 
		[RED("DLSSEnabled")] 
		public CBool DLSSEnabled
		{
			get => GetProperty(ref _dLSSEnabled);
			set => SetProperty(ref _dLSSEnabled, value);
		}

		[Ordinal(27)] 
		[RED("DLSSPreset")] 
		public CInt32 DLSSPreset
		{
			get => GetProperty(ref _dLSSPreset);
			set => SetProperty(ref _dLSSPreset, value);
		}

		[Ordinal(28)] 
		[RED("DLSSDEnabled")] 
		public CBool DLSSDEnabled
		{
			get => GetProperty(ref _dLSSDEnabled);
			set => SetProperty(ref _dLSSDEnabled, value);
		}

		[Ordinal(29)] 
		[RED("DLSSQuality")] 
		public CInt32 DLSSQuality
		{
			get => GetProperty(ref _dLSSQuality);
			set => SetProperty(ref _dLSSQuality, value);
		}

		[Ordinal(30)] 
		[RED("DLSSSharpness")] 
		public CFloat DLSSSharpness
		{
			get => GetProperty(ref _dLSSSharpness);
			set => SetProperty(ref _dLSSSharpness, value);
		}

		[Ordinal(31)] 
		[RED("DLSSFrameGenEnabled")] 
		public CBool DLSSFrameGenEnabled
		{
			get => GetProperty(ref _dLSSFrameGenEnabled);
			set => SetProperty(ref _dLSSFrameGenEnabled, value);
		}

		[Ordinal(32)] 
		[RED("DLSSMultiFrameGenEnabled")] 
		public CBool DLSSMultiFrameGenEnabled
		{
			get => GetProperty(ref _dLSSMultiFrameGenEnabled);
			set => SetProperty(ref _dLSSMultiFrameGenEnabled, value);
		}

		[Ordinal(33)] 
		[RED("DLSSMultiFrameGenFrameToGenerate")] 
		public CInt32 DLSSMultiFrameGenFrameToGenerate
		{
			get => GetProperty(ref _dLSSMultiFrameGenFrameToGenerate);
			set => SetProperty(ref _dLSSMultiFrameGenFrameToGenerate, value);
		}

		[Ordinal(34)] 
		[RED("FSR2Enabled")] 
		public CBool FSR2Enabled
		{
			get => GetProperty(ref _fSR2Enabled);
			set => SetProperty(ref _fSR2Enabled, value);
		}

		[Ordinal(35)] 
		[RED("FSR2Quality")] 
		public CInt32 FSR2Quality
		{
			get => GetProperty(ref _fSR2Quality);
			set => SetProperty(ref _fSR2Quality, value);
		}

		[Ordinal(36)] 
		[RED("FSR2Sharpness")] 
		public CFloat FSR2Sharpness
		{
			get => GetProperty(ref _fSR2Sharpness);
			set => SetProperty(ref _fSR2Sharpness, value);
		}

		[Ordinal(37)] 
		[RED("FSR3Enabled")] 
		public CBool FSR3Enabled
		{
			get => GetProperty(ref _fSR3Enabled);
			set => SetProperty(ref _fSR3Enabled, value);
		}

		[Ordinal(38)] 
		[RED("FSR3Quality")] 
		public CInt32 FSR3Quality
		{
			get => GetProperty(ref _fSR3Quality);
			set => SetProperty(ref _fSR3Quality, value);
		}

		[Ordinal(39)] 
		[RED("FSR3Sharpness")] 
		public CFloat FSR3Sharpness
		{
			get => GetProperty(ref _fSR3Sharpness);
			set => SetProperty(ref _fSR3Sharpness, value);
		}

		[Ordinal(40)] 
		[RED("FSR3FrameGenEnabled")] 
		public CBool FSR3FrameGenEnabled
		{
			get => GetProperty(ref _fSR3FrameGenEnabled);
			set => SetProperty(ref _fSR3FrameGenEnabled, value);
		}

		[Ordinal(41)] 
		[RED("FSR4Enabled")] 
		public CBool FSR4Enabled
		{
			get => GetProperty(ref _fSR4Enabled);
			set => SetProperty(ref _fSR4Enabled, value);
		}

		[Ordinal(42)] 
		[RED("FSR4Quality")] 
		public CInt32 FSR4Quality
		{
			get => GetProperty(ref _fSR4Quality);
			set => SetProperty(ref _fSR4Quality, value);
		}

		[Ordinal(43)] 
		[RED("FSR4Sharpness")] 
		public CFloat FSR4Sharpness
		{
			get => GetProperty(ref _fSR4Sharpness);
			set => SetProperty(ref _fSR4Sharpness, value);
		}

		[Ordinal(44)] 
		[RED("XeSSEnabled")] 
		public CBool XeSSEnabled
		{
			get => GetProperty(ref _xeSSEnabled);
			set => SetProperty(ref _xeSSEnabled, value);
		}

		[Ordinal(45)] 
		[RED("XeSSQuality")] 
		public CInt32 XeSSQuality
		{
			get => GetProperty(ref _xeSSQuality);
			set => SetProperty(ref _xeSSQuality, value);
		}

		[Ordinal(46)] 
		[RED("XeSSSharpness")] 
		public CFloat XeSSSharpness
		{
			get => GetProperty(ref _xeSSSharpness);
			set => SetProperty(ref _xeSSSharpness, value);
		}

		[Ordinal(47)] 
		[RED("XeSSFrameGenEnabled")] 
		public CBool XeSSFrameGenEnabled
		{
			get => GetProperty(ref _xeSSFrameGenEnabled);
			set => SetProperty(ref _xeSSFrameGenEnabled, value);
		}

		[Ordinal(48)] 
		[RED("DRSEnabled")] 
		public CBool DRSEnabled
		{
			get => GetProperty(ref _dRSEnabled);
			set => SetProperty(ref _dRSEnabled, value);
		}

		[Ordinal(49)] 
		[RED("DRSTargetFPS")] 
		public CUInt32 DRSTargetFPS
		{
			get => GetProperty(ref _dRSTargetFPS);
			set => SetProperty(ref _dRSTargetFPS, value);
		}

		[Ordinal(50)] 
		[RED("DRSMinimalResolutionPercentage")] 
		public CUInt32 DRSMinimalResolutionPercentage
		{
			get => GetProperty(ref _dRSMinimalResolutionPercentage);
			set => SetProperty(ref _dRSMinimalResolutionPercentage, value);
		}

		[Ordinal(51)] 
		[RED("DRSMaximalResolutionPercentage")] 
		public CUInt32 DRSMaximalResolutionPercentage
		{
			get => GetProperty(ref _dRSMaximalResolutionPercentage);
			set => SetProperty(ref _dRSMaximalResolutionPercentage, value);
		}

		[Ordinal(52)] 
		[RED("CASSharpeningEnabled")] 
		public CBool CASSharpeningEnabled
		{
			get => GetProperty(ref _cASSharpeningEnabled);
			set => SetProperty(ref _cASSharpeningEnabled, value);
		}

		[Ordinal(53)] 
		[RED("FSREnabled")] 
		public CBool FSREnabled
		{
			get => GetProperty(ref _fSREnabled);
			set => SetProperty(ref _fSREnabled, value);
		}

		[Ordinal(54)] 
		[RED("FSRQuality")] 
		public CInt32 FSRQuality
		{
			get => GetProperty(ref _fSRQuality);
			set => SetProperty(ref _fSRQuality, value);
		}

		[Ordinal(55)] 
		[RED("rayTracingEnabled")] 
		public CBool RayTracingEnabled
		{
			get => GetProperty(ref _rayTracingEnabled);
			set => SetProperty(ref _rayTracingEnabled, value);
		}

		[Ordinal(56)] 
		[RED("rayTracedReflections")] 
		public CBool RayTracedReflections
		{
			get => GetProperty(ref _rayTracedReflections);
			set => SetProperty(ref _rayTracedReflections, value);
		}

		[Ordinal(57)] 
		[RED("rayTracedSunShadows")] 
		public CBool RayTracedSunShadows
		{
			get => GetProperty(ref _rayTracedSunShadows);
			set => SetProperty(ref _rayTracedSunShadows, value);
		}

		[Ordinal(58)] 
		[RED("rayTracedLocalShadows")] 
		public CBool RayTracedLocalShadows
		{
			get => GetProperty(ref _rayTracedLocalShadows);
			set => SetProperty(ref _rayTracedLocalShadows, value);
		}

		[Ordinal(59)] 
		[RED("rayTracedLightingQuality")] 
		public CInt32 RayTracedLightingQuality
		{
			get => GetProperty(ref _rayTracedLightingQuality);
			set => SetProperty(ref _rayTracedLightingQuality, value);
		}

		[Ordinal(60)] 
		[RED("rayTracedPathTracingEnabled")] 
		public CBool RayTracedPathTracingEnabled
		{
			get => GetProperty(ref _rayTracedPathTracingEnabled);
			set => SetProperty(ref _rayTracedPathTracingEnabled, value);
		}

		public worldBenchmarkSummary(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
