using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemHudParameter : effectTrackItem
	{
		private CFloat _scale;
		private effectEffectParameterEvaluator _glitchParameter;
		private CFloat _scale1;
		private effectEffectParameterEvaluator _glitchParameter1;
		private CFloat _blackwallScale;
		private effectEffectParameterEvaluator _blackwallParameter;

		[Ordinal(3)] 
		[RED("scale")] 
		public CFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(4)] 
		[RED("glitchParameter")] 
		public effectEffectParameterEvaluator GlitchParameter
		{
			get => GetProperty(ref _glitchParameter);
			set => SetProperty(ref _glitchParameter, value);
		}

		[Ordinal(5)] 
		[RED("scale1")] 
		public CFloat Scale1
		{
			get => GetProperty(ref _scale1);
			set => SetProperty(ref _scale1, value);
		}

		[Ordinal(6)] 
		[RED("glitchParameter1")] 
		public effectEffectParameterEvaluator GlitchParameter1
		{
			get => GetProperty(ref _glitchParameter1);
			set => SetProperty(ref _glitchParameter1, value);
		}

		[Ordinal(7)] 
		[RED("blackwallScale")] 
		public CFloat BlackwallScale
		{
			get => GetProperty(ref _blackwallScale);
			set => SetProperty(ref _blackwallScale, value);
		}

		[Ordinal(8)] 
		[RED("blackwallParameter")] 
		public effectEffectParameterEvaluator BlackwallParameter
		{
			get => GetProperty(ref _blackwallParameter);
			set => SetProperty(ref _blackwallParameter, value);
		}

		public effectTrackItemHudParameter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
