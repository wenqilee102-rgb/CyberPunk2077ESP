using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocArmorData : IScriptable
	{
		private CFloat _currentArmor;
		private CFloat _currentMaxArmor;
		private CFloat _maxArmorPossible;
		private CFloat _maxDamageReduction;

		[Ordinal(0)] 
		[RED("CurrentArmor")] 
		public CFloat CurrentArmor
		{
			get => GetProperty(ref _currentArmor);
			set => SetProperty(ref _currentArmor, value);
		}

		[Ordinal(1)] 
		[RED("CurrentMaxArmor")] 
		public CFloat CurrentMaxArmor
		{
			get => GetProperty(ref _currentMaxArmor);
			set => SetProperty(ref _currentMaxArmor, value);
		}

		[Ordinal(2)] 
		[RED("MaxArmorPossible")] 
		public CFloat MaxArmorPossible
		{
			get => GetProperty(ref _maxArmorPossible);
			set => SetProperty(ref _maxArmorPossible, value);
		}

		[Ordinal(3)] 
		[RED("MaxDamageReduction")] 
		public CFloat MaxDamageReduction
		{
			get => GetProperty(ref _maxDamageReduction);
			set => SetProperty(ref _maxDamageReduction, value);
		}

		public RipperdocArmorData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
