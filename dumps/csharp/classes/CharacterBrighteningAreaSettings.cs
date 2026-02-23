using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CharacterBrighteningAreaSettings : IAreaSettings
	{
		private CFloat _effectStrengthMultiplier;
		private CFloat _minDistance;
		private CFloat _maxDistance;
		private curveData<CFloat> _envMultiplier;

		[Ordinal(2)] 
		[RED("effectStrengthMultiplier")] 
		public CFloat EffectStrengthMultiplier
		{
			get => GetProperty(ref _effectStrengthMultiplier);
			set => SetProperty(ref _effectStrengthMultiplier, value);
		}

		[Ordinal(3)] 
		[RED("minDistance")] 
		public CFloat MinDistance
		{
			get => GetProperty(ref _minDistance);
			set => SetProperty(ref _minDistance, value);
		}

		[Ordinal(4)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(5)] 
		[RED("envMultiplier")] 
		public curveData<CFloat> EnvMultiplier
		{
			get => GetProperty(ref _envMultiplier);
			set => SetProperty(ref _envMultiplier, value);
		}

		public CharacterBrighteningAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
