using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksPerkItemInitData : IScriptable
	{
		private wCHandle<gamedataNewPerk_Record> _perkRecord;
		private CEnum<gamedataNewPerkType> _perkType;
		private CInt32 _requiredAttributePoints;
		private CBool _isAttributeRequirementMet;
		private CInt32 _maxPerkLevel;
		private TweakDBID _icon;
		private redResourceReferenceScriptToken _binkRef;
		private CEnum<gamedataNewPerkCategoryType> _category;
		private CEnum<gamedataStatType> _stat;

		[Ordinal(0)] 
		[RED("perkRecord")] 
		public wCHandle<gamedataNewPerk_Record> PerkRecord
		{
			get => GetProperty(ref _perkRecord);
			set => SetProperty(ref _perkRecord, value);
		}

		[Ordinal(1)] 
		[RED("perkType")] 
		public CEnum<gamedataNewPerkType> PerkType
		{
			get => GetProperty(ref _perkType);
			set => SetProperty(ref _perkType, value);
		}

		[Ordinal(2)] 
		[RED("requiredAttributePoints")] 
		public CInt32 RequiredAttributePoints
		{
			get => GetProperty(ref _requiredAttributePoints);
			set => SetProperty(ref _requiredAttributePoints, value);
		}

		[Ordinal(3)] 
		[RED("isAttributeRequirementMet")] 
		public CBool IsAttributeRequirementMet
		{
			get => GetProperty(ref _isAttributeRequirementMet);
			set => SetProperty(ref _isAttributeRequirementMet, value);
		}

		[Ordinal(4)] 
		[RED("maxPerkLevel")] 
		public CInt32 MaxPerkLevel
		{
			get => GetProperty(ref _maxPerkLevel);
			set => SetProperty(ref _maxPerkLevel, value);
		}

		[Ordinal(5)] 
		[RED("icon")] 
		public TweakDBID Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(6)] 
		[RED("binkRef")] 
		public redResourceReferenceScriptToken BinkRef
		{
			get => GetProperty(ref _binkRef);
			set => SetProperty(ref _binkRef, value);
		}

		[Ordinal(7)] 
		[RED("category")] 
		public CEnum<gamedataNewPerkCategoryType> Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(8)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		public NewPerksPerkItemInitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
