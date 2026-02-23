using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BloomAreaSettings : IAreaSettings
	{
		private CFloat _blurSizeX;
		private CFloat _blurSizeY;
		private CArrayFixedSize<CColor> _mipColors;
		private CArrayFixedSize<CFloat> _mipLuminanceClamp;
		private CFloat _luminanceThresholdMin;
		private CFloat _luminanceThresholdMax;
		private CFloat _sceneColorScale;
		private CFloat _bloomColorScale;
		private CUInt8 _numDownsamplePasses;
		private ShaftsAreaSettings _shaftsAreaSettings;

		[Ordinal(2)] 
		[RED("blurSizeX")] 
		public CFloat BlurSizeX
		{
			get => GetProperty(ref _blurSizeX);
			set => SetProperty(ref _blurSizeX, value);
		}

		[Ordinal(3)] 
		[RED("blurSizeY")] 
		public CFloat BlurSizeY
		{
			get => GetProperty(ref _blurSizeY);
			set => SetProperty(ref _blurSizeY, value);
		}

		[Ordinal(4)] 
		[RED("mipColors", 5)] 
		public CArrayFixedSize<CColor> MipColors
		{
			get => GetProperty(ref _mipColors);
			set => SetProperty(ref _mipColors, value);
		}

		[Ordinal(5)] 
		[RED("mipLuminanceClamp", 3)] 
		public CArrayFixedSize<CFloat> MipLuminanceClamp
		{
			get => GetProperty(ref _mipLuminanceClamp);
			set => SetProperty(ref _mipLuminanceClamp, value);
		}

		[Ordinal(6)] 
		[RED("luminanceThresholdMin")] 
		public CFloat LuminanceThresholdMin
		{
			get => GetProperty(ref _luminanceThresholdMin);
			set => SetProperty(ref _luminanceThresholdMin, value);
		}

		[Ordinal(7)] 
		[RED("luminanceThresholdMax")] 
		public CFloat LuminanceThresholdMax
		{
			get => GetProperty(ref _luminanceThresholdMax);
			set => SetProperty(ref _luminanceThresholdMax, value);
		}

		[Ordinal(8)] 
		[RED("sceneColorScale")] 
		public CFloat SceneColorScale
		{
			get => GetProperty(ref _sceneColorScale);
			set => SetProperty(ref _sceneColorScale, value);
		}

		[Ordinal(9)] 
		[RED("bloomColorScale")] 
		public CFloat BloomColorScale
		{
			get => GetProperty(ref _bloomColorScale);
			set => SetProperty(ref _bloomColorScale, value);
		}

		[Ordinal(10)] 
		[RED("numDownsamplePasses")] 
		public CUInt8 NumDownsamplePasses
		{
			get => GetProperty(ref _numDownsamplePasses);
			set => SetProperty(ref _numDownsamplePasses, value);
		}

		[Ordinal(11)] 
		[RED("shaftsAreaSettings")] 
		public ShaftsAreaSettings ShaftsAreaSettings
		{
			get => GetProperty(ref _shaftsAreaSettings);
			set => SetProperty(ref _shaftsAreaSettings, value);
		}

		public BloomAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
