using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatHitPrereqCondition : BaseHitPrereqCondition
	{
		private CFloat _valueToCheck;
		private CName _objectToCheck;
		private CEnum<EComparisonType> _comparisonType;
		private CEnum<gamedataStatType> _statToCompare;

		[Ordinal(3)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(4)] 
		[RED("objectToCheck")] 
		public CName ObjectToCheck
		{
			get => GetProperty(ref _objectToCheck);
			set => SetProperty(ref _objectToCheck, value);
		}

		[Ordinal(5)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(6)] 
		[RED("statToCompare")] 
		public CEnum<gamedataStatType> StatToCompare
		{
			get => GetProperty(ref _statToCompare);
			set => SetProperty(ref _statToCompare, value);
		}

		public StatHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
