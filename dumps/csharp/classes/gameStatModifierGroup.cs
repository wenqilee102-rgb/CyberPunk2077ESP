using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierGroup : CVariable
	{
		private CArray<gameStatModifierHandle> _statModifierArray;
		private CInt32 _statModifiersLimit;
		private TweakDBID _statModifiersLimitModifier;
		private CArray<TweakDBID> _relatedModifierGroups;
		private TweakDBID _statModifierGroupRecordID;
		private CUInt16 _stackCount;
		private CBool _drawBasedOnStatType;
		private CBool _saveBasedOnStatType;
		private CBool _optimiseCombinedModifiers;

		[Ordinal(0)] 
		[RED("statModifierArray")] 
		public CArray<gameStatModifierHandle> StatModifierArray
		{
			get => GetProperty(ref _statModifierArray);
			set => SetProperty(ref _statModifierArray, value);
		}

		[Ordinal(1)] 
		[RED("statModifiersLimit")] 
		public CInt32 StatModifiersLimit
		{
			get => GetProperty(ref _statModifiersLimit);
			set => SetProperty(ref _statModifiersLimit, value);
		}

		[Ordinal(2)] 
		[RED("statModifiersLimitModifier")] 
		public TweakDBID StatModifiersLimitModifier
		{
			get => GetProperty(ref _statModifiersLimitModifier);
			set => SetProperty(ref _statModifiersLimitModifier, value);
		}

		[Ordinal(3)] 
		[RED("relatedModifierGroups")] 
		public CArray<TweakDBID> RelatedModifierGroups
		{
			get => GetProperty(ref _relatedModifierGroups);
			set => SetProperty(ref _relatedModifierGroups, value);
		}

		[Ordinal(4)] 
		[RED("statModifierGroupRecordID")] 
		public TweakDBID StatModifierGroupRecordID
		{
			get => GetProperty(ref _statModifierGroupRecordID);
			set => SetProperty(ref _statModifierGroupRecordID, value);
		}

		[Ordinal(5)] 
		[RED("stackCount")] 
		public CUInt16 StackCount
		{
			get => GetProperty(ref _stackCount);
			set => SetProperty(ref _stackCount, value);
		}

		[Ordinal(6)] 
		[RED("drawBasedOnStatType")] 
		public CBool DrawBasedOnStatType
		{
			get => GetProperty(ref _drawBasedOnStatType);
			set => SetProperty(ref _drawBasedOnStatType, value);
		}

		[Ordinal(7)] 
		[RED("saveBasedOnStatType")] 
		public CBool SaveBasedOnStatType
		{
			get => GetProperty(ref _saveBasedOnStatType);
			set => SetProperty(ref _saveBasedOnStatType, value);
		}

		[Ordinal(8)] 
		[RED("optimiseCombinedModifiers")] 
		public CBool OptimiseCombinedModifiers
		{
			get => GetProperty(ref _optimiseCombinedModifiers);
			set => SetProperty(ref _optimiseCombinedModifiers, value);
		}

		public gameStatModifierGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
