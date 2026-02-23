using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemColorGrade : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _contrast;
		private effectEffectParameterEvaluatorFloat _saturate;
		private effectEffectParameterEvaluatorFloat _brightness;
		private effectEffectParameterEvaluatorFloat _lutWeight;
		private ColorGradingLutParams _lutParams;
		private ColorGradingLutParams _lutParamsHdr;
		private CBool _blendWithBaseLut;
		private CArray<CEnum<ERenderObjectType>> _mask;

		[Ordinal(3)] 
		[RED("contrast")] 
		public effectEffectParameterEvaluatorFloat Contrast
		{
			get => GetProperty(ref _contrast);
			set => SetProperty(ref _contrast, value);
		}

		[Ordinal(4)] 
		[RED("saturate")] 
		public effectEffectParameterEvaluatorFloat Saturate
		{
			get => GetProperty(ref _saturate);
			set => SetProperty(ref _saturate, value);
		}

		[Ordinal(5)] 
		[RED("brightness")] 
		public effectEffectParameterEvaluatorFloat Brightness
		{
			get => GetProperty(ref _brightness);
			set => SetProperty(ref _brightness, value);
		}

		[Ordinal(6)] 
		[RED("lutWeight")] 
		public effectEffectParameterEvaluatorFloat LutWeight
		{
			get => GetProperty(ref _lutWeight);
			set => SetProperty(ref _lutWeight, value);
		}

		[Ordinal(7)] 
		[RED("lutParams")] 
		public ColorGradingLutParams LutParams
		{
			get => GetProperty(ref _lutParams);
			set => SetProperty(ref _lutParams, value);
		}

		[Ordinal(8)] 
		[RED("lutParamsHdr")] 
		public ColorGradingLutParams LutParamsHdr
		{
			get => GetProperty(ref _lutParamsHdr);
			set => SetProperty(ref _lutParamsHdr, value);
		}

		[Ordinal(9)] 
		[RED("blendWithBaseLut")] 
		public CBool BlendWithBaseLut
		{
			get => GetProperty(ref _blendWithBaseLut);
			set => SetProperty(ref _blendWithBaseLut, value);
		}

		[Ordinal(10)] 
		[RED("mask")] 
		public CArray<CEnum<ERenderObjectType>> Mask
		{
			get => GetProperty(ref _mask);
			set => SetProperty(ref _mask, value);
		}

		public effectTrackItemColorGrade(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
