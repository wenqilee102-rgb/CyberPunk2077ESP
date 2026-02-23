using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksScreenInitData : IScriptable
	{
		private CEnum<gamedataStatType> _stat;
		private TweakDBID _attribute;
		private wCHandle<gamedataAttributeData_Record> _attributeData;
		private CEnum<PerkMenuAttribute> _perkMenuAttribute;
		private CBool _isPlayerInCombat;

		[Ordinal(0)] 
		[RED("stat")] 
		public CEnum<gamedataStatType> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(1)] 
		[RED("attribute")] 
		public TweakDBID Attribute
		{
			get => GetProperty(ref _attribute);
			set => SetProperty(ref _attribute, value);
		}

		[Ordinal(2)] 
		[RED("attributeData")] 
		public wCHandle<gamedataAttributeData_Record> AttributeData
		{
			get => GetProperty(ref _attributeData);
			set => SetProperty(ref _attributeData, value);
		}

		[Ordinal(3)] 
		[RED("perkMenuAttribute")] 
		public CEnum<PerkMenuAttribute> PerkMenuAttribute
		{
			get => GetProperty(ref _perkMenuAttribute);
			set => SetProperty(ref _perkMenuAttribute, value);
		}

		[Ordinal(4)] 
		[RED("isPlayerInCombat")] 
		public CBool IsPlayerInCombat
		{
			get => GetProperty(ref _isPlayerInCombat);
			set => SetProperty(ref _isPlayerInCombat, value);
		}

		public NewPerksScreenInitData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
