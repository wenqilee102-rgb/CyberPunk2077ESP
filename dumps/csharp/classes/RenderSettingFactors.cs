using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RenderSettingFactors : CVariable
	{
		private curveData<CFloat> _resolutionAberrationScale;
		private curveData<CFloat> _resolutionAberrationDispersal;
		private curveData<CFloat> _resolutionFilmGrainScale;
		private curveData<CFloat> _resolutionFilmGrainStrength;

		[Ordinal(0)] 
		[RED("resolutionAberrationScale")] 
		public curveData<CFloat> ResolutionAberrationScale
		{
			get => GetProperty(ref _resolutionAberrationScale);
			set => SetProperty(ref _resolutionAberrationScale, value);
		}

		[Ordinal(1)] 
		[RED("resolutionAberrationDispersal")] 
		public curveData<CFloat> ResolutionAberrationDispersal
		{
			get => GetProperty(ref _resolutionAberrationDispersal);
			set => SetProperty(ref _resolutionAberrationDispersal, value);
		}

		[Ordinal(2)] 
		[RED("resolutionFilmGrainScale")] 
		public curveData<CFloat> ResolutionFilmGrainScale
		{
			get => GetProperty(ref _resolutionFilmGrainScale);
			set => SetProperty(ref _resolutionFilmGrainScale, value);
		}

		[Ordinal(3)] 
		[RED("resolutionFilmGrainStrength")] 
		public curveData<CFloat> ResolutionFilmGrainStrength
		{
			get => GetProperty(ref _resolutionFilmGrainStrength);
			set => SetProperty(ref _resolutionFilmGrainStrength, value);
		}

		public RenderSettingFactors(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
