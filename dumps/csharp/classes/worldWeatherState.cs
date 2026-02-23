using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldWeatherState : ISerializable
	{
		private curveData<CFloat> _minDuration;
		private curveData<CFloat> _maxDuration;
		private rRef<worldEnvironmentAreaParameters> _environmentAreaParameters;
		private raRef<worldEffect> _effect;
		private CName _name;
		private curveData<CFloat> _probability;
		private curveData<CFloat> _transitionDuration;

		[Ordinal(0)] 
		[RED("minDuration")] 
		public curveData<CFloat> MinDuration
		{
			get => GetProperty(ref _minDuration);
			set => SetProperty(ref _minDuration, value);
		}

		[Ordinal(1)] 
		[RED("maxDuration")] 
		public curveData<CFloat> MaxDuration
		{
			get => GetProperty(ref _maxDuration);
			set => SetProperty(ref _maxDuration, value);
		}

		[Ordinal(2)] 
		[RED("environmentAreaParameters")] 
		public rRef<worldEnvironmentAreaParameters> EnvironmentAreaParameters
		{
			get => GetProperty(ref _environmentAreaParameters);
			set => SetProperty(ref _environmentAreaParameters, value);
		}

		[Ordinal(3)] 
		[RED("effect")] 
		public raRef<worldEffect> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(4)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(5)] 
		[RED("probability")] 
		public curveData<CFloat> Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		[Ordinal(6)] 
		[RED("transitionDuration")] 
		public curveData<CFloat> TransitionDuration
		{
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}

		public worldWeatherState(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
