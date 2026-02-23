using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPrereq : gameIScriptablePrereq
	{
		private CBool _notifyOnAnyChange;
		private CBool _notifyOnlyOnStateFulfilled;
		private CEnum<gamedataStatType> _statType;
		private CFloat _valueToCheck;
		private CEnum<EComparisonType> _comparisonType;
		private CBool _statModifiersUsed;
		private TweakDBID _statPrereqRecordID;
		private CName _objToCheck;

		[Ordinal(0)] 
		[RED("notifyOnAnyChange")] 
		public CBool NotifyOnAnyChange
		{
			get => GetProperty(ref _notifyOnAnyChange);
			set => SetProperty(ref _notifyOnAnyChange, value);
		}

		[Ordinal(1)] 
		[RED("notifyOnlyOnStateFulfilled")] 
		public CBool NotifyOnlyOnStateFulfilled
		{
			get => GetProperty(ref _notifyOnlyOnStateFulfilled);
			set => SetProperty(ref _notifyOnlyOnStateFulfilled, value);
		}

		[Ordinal(2)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(3)] 
		[RED("valueToCheck")] 
		public CFloat ValueToCheck
		{
			get => GetProperty(ref _valueToCheck);
			set => SetProperty(ref _valueToCheck, value);
		}

		[Ordinal(4)] 
		[RED("comparisonType")] 
		public CEnum<EComparisonType> ComparisonType
		{
			get => GetProperty(ref _comparisonType);
			set => SetProperty(ref _comparisonType, value);
		}

		[Ordinal(5)] 
		[RED("statModifiersUsed")] 
		public CBool StatModifiersUsed
		{
			get => GetProperty(ref _statModifiersUsed);
			set => SetProperty(ref _statModifiersUsed, value);
		}

		[Ordinal(6)] 
		[RED("statPrereqRecordID")] 
		public TweakDBID StatPrereqRecordID
		{
			get => GetProperty(ref _statPrereqRecordID);
			set => SetProperty(ref _statPrereqRecordID, value);
		}

		[Ordinal(7)] 
		[RED("objToCheck")] 
		public CName ObjToCheck
		{
			get => GetProperty(ref _objToCheck);
			set => SetProperty(ref _objToCheck, value);
		}

		public StatPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
