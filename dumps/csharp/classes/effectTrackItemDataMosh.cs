using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemDataMosh : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _intensity;
		private CBool _useGlitch;
		private effectEffectParameterEvaluatorVector _glitchColor;
		private CBool _usePixelsort;
		private CBool _pixelsortOverride;
		private effectEffectParameterEvaluatorFloat _pixelsortIntensity;
		private CBool _pixelsortStencil;
		private CBool _pixelsortVfx;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(4)] 
		[RED("intensity")] 
		public effectEffectParameterEvaluatorFloat Intensity
		{
			get => GetProperty(ref _intensity);
			set => SetProperty(ref _intensity, value);
		}

		[Ordinal(5)] 
		[RED("useGlitch")] 
		public CBool UseGlitch
		{
			get => GetProperty(ref _useGlitch);
			set => SetProperty(ref _useGlitch, value);
		}

		[Ordinal(6)] 
		[RED("glitchColor")] 
		public effectEffectParameterEvaluatorVector GlitchColor
		{
			get => GetProperty(ref _glitchColor);
			set => SetProperty(ref _glitchColor, value);
		}

		[Ordinal(7)] 
		[RED("usePixelsort")] 
		public CBool UsePixelsort
		{
			get => GetProperty(ref _usePixelsort);
			set => SetProperty(ref _usePixelsort, value);
		}

		[Ordinal(8)] 
		[RED("pixelsortOverride")] 
		public CBool PixelsortOverride
		{
			get => GetProperty(ref _pixelsortOverride);
			set => SetProperty(ref _pixelsortOverride, value);
		}

		[Ordinal(9)] 
		[RED("pixelsortIntensity")] 
		public effectEffectParameterEvaluatorFloat PixelsortIntensity
		{
			get => GetProperty(ref _pixelsortIntensity);
			set => SetProperty(ref _pixelsortIntensity, value);
		}

		[Ordinal(10)] 
		[RED("pixelsortStencil")] 
		public CBool PixelsortStencil
		{
			get => GetProperty(ref _pixelsortStencil);
			set => SetProperty(ref _pixelsortStencil, value);
		}

		[Ordinal(11)] 
		[RED("pixelsortVfx")] 
		public CBool PixelsortVfx
		{
			get => GetProperty(ref _pixelsortVfx);
			set => SetProperty(ref _pixelsortVfx, value);
		}

		public effectTrackItemDataMosh(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
