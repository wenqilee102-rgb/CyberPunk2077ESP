using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWeatherStateTransition : ISerializable
	{
		private curveData<CFloat> _probability;
		private curveData<CFloat> _transitionDuration;
		private CHandle<worldWeatherState> _sourceWeatherState;
		private CHandle<worldWeatherState> _targetWeatherState;

		[Ordinal(0)] 
		[RED("probability")] 
		public curveData<CFloat> Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		[Ordinal(1)] 
		[RED("transitionDuration")] 
		public curveData<CFloat> TransitionDuration
		{
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}

		[Ordinal(2)] 
		[RED("sourceWeatherState")] 
		public CHandle<worldWeatherState> SourceWeatherState
		{
			get => GetProperty(ref _sourceWeatherState);
			set => SetProperty(ref _sourceWeatherState, value);
		}

		[Ordinal(3)] 
		[RED("targetWeatherState")] 
		public CHandle<worldWeatherState> TargetWeatherState
		{
			get => GetProperty(ref _targetWeatherState);
			set => SetProperty(ref _targetWeatherState, value);
		}

		public worldWeatherStateTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
