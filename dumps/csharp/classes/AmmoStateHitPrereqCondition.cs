using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoStateHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<EMagazineAmmoState> _valueToListen;
		private CFloat _ratio;
		private CEnum<EComparisonType> _comparisonType;

		[Ordinal(3)] 
		[RED("valueToListen")] 
		public CEnum<EMagazineAmmoState> ValueToListen
		{
			get => GetProperty(ref _valueToListen);
			set => SetProperty(ref _valueToListen, value);
		}

		[Ordinal(4)] 
		[RED("ratio")] 
		public CFloat Ratio
		{
			get => GetProperty(ref _ratio);
			set => SetProperty(ref _ratio, value);
		}

		[Ordinal(5)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		public AmmoStateHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
