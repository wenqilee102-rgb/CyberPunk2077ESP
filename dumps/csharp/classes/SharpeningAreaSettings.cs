using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SharpeningAreaSettings : IAreaSettings
	{
		private CFloat _sharpeningStrength;
		private CFloat _sharpeningStrengthWhenUpsaling;
		private CFloat _sharpeningStrengthUpscalingTreshold;

		[Ordinal(2)] 
		[RED("sharpeningStrength")] 
		public CFloat SharpeningStrength
		{
			get => GetProperty(ref _sharpeningStrength);
			set => SetProperty(ref _sharpeningStrength, value);
		}

		[Ordinal(3)] 
		[RED("sharpeningStrengthWhenUpsaling")] 
		public CFloat SharpeningStrengthWhenUpsaling
		{
			get => GetProperty(ref _sharpeningStrengthWhenUpsaling);
			set => SetProperty(ref _sharpeningStrengthWhenUpsaling, value);
		}

		[Ordinal(4)] 
		[RED("sharpeningStrengthUpscalingTreshold")] 
		public CFloat SharpeningStrengthUpscalingTreshold
		{
			get => GetProperty(ref _sharpeningStrengthUpscalingTreshold);
			set => SetProperty(ref _sharpeningStrengthUpscalingTreshold, value);
		}

		public SharpeningAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
