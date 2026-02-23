using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocBarTooltip : AGenericTooltipController
	{
		private inkWidgetReference _statsHolder;
		private inkWidgetReference _perksHolder;
		private inkWidgetReference _capacityDescription;
		private inkWidgetReference _armorDescription;
		private inkTextWidgetReference _armorReductionDescription;
		private inkWidgetReference _titleHolder;
		private inkTextWidgetReference _titleName;
		private inkTextWidgetReference _titleTotalValue;
		private inkTextWidgetReference _titleMaxValue;
		private inkWidgetReference _stats1;
		private inkTextWidgetReference _stats1Name;
		private inkTextWidgetReference _stats1Value;
		private inkWidgetReference _stats2;
		private inkTextWidgetReference _stats2Name;
		private inkTextWidgetReference _stats2Value;
		private inkWidgetReference _stats3;
		private inkTextWidgetReference _stats3Name;
		private inkTextWidgetReference _stats3Value;
		private inkTextWidgetReference _perkTypeName;
		private inkWidgetReference _perk1;
		private inkImageWidgetReference _perk1Icon;
		private inkTextWidgetReference _perk1Name;
		private inkWidgetReference _perk2;
		private inkImageWidgetReference _perk2Icon;
		private inkTextWidgetReference _perk2Name;
		private inkWidgetReference _perkTreeInput;
		private inkImageWidgetReference _perkTreeIcon;
		private CName _capacityTitleNameLocKey;
		private CName _capacityStat1LocKey;
		private CName _capacityStat2LocKey;
		private CName _capacityStat3LocKey;
		private CName _capacityPerkTitleLocKey;
		private CName _capacityPerk1IconsName;
		private CName _capacityPerk1LocKey;
		private CName _capacityPerk2IconsName;
		private CName _capacityPerk2LocKey;
		private CName _armorTitleNameLocKey;
		private CName _armorStat1LocKey;
		private CName _armorStat2LocKey;
		private CName _armorStat3LocKey;
		private CName _armorPerkTitleLocKey;
		private CName _armorPerk1IconsName;
		private CName _armorPerk1LocKey;

		[Ordinal(2)] 
		[RED("statsHolder")] 
		public inkWidgetReference StatsHolder
		{
			get => GetProperty(ref _statsHolder);
			set => SetProperty(ref _statsHolder, value);
		}

		[Ordinal(3)] 
		[RED("perksHolder")] 
		public inkWidgetReference PerksHolder
		{
			get => GetProperty(ref _perksHolder);
			set => SetProperty(ref _perksHolder, value);
		}

		[Ordinal(4)] 
		[RED("capacityDescription")] 
		public inkWidgetReference CapacityDescription
		{
			get => GetProperty(ref _capacityDescription);
			set => SetProperty(ref _capacityDescription, value);
		}

		[Ordinal(5)] 
		[RED("armorDescription")] 
		public inkWidgetReference ArmorDescription
		{
			get => GetProperty(ref _armorDescription);
			set => SetProperty(ref _armorDescription, value);
		}

		[Ordinal(6)] 
		[RED("armorReductionDescription")] 
		public inkTextWidgetReference ArmorReductionDescription
		{
			get => GetProperty(ref _armorReductionDescription);
			set => SetProperty(ref _armorReductionDescription, value);
		}

		[Ordinal(7)] 
		[RED("titleHolder")] 
		public inkWidgetReference TitleHolder
		{
			get => GetProperty(ref _titleHolder);
			set => SetProperty(ref _titleHolder, value);
		}

		[Ordinal(8)] 
		[RED("titleName")] 
		public inkTextWidgetReference TitleName
		{
			get => GetProperty(ref _titleName);
			set => SetProperty(ref _titleName, value);
		}

		[Ordinal(9)] 
		[RED("titleTotalValue")] 
		public inkTextWidgetReference TitleTotalValue
		{
			get => GetProperty(ref _titleTotalValue);
			set => SetProperty(ref _titleTotalValue, value);
		}

		[Ordinal(10)] 
		[RED("titleMaxValue")] 
		public inkTextWidgetReference TitleMaxValue
		{
			get => GetProperty(ref _titleMaxValue);
			set => SetProperty(ref _titleMaxValue, value);
		}

		[Ordinal(11)] 
		[RED("stats1")] 
		public inkWidgetReference Stats1
		{
			get => GetProperty(ref _stats1);
			set => SetProperty(ref _stats1, value);
		}

		[Ordinal(12)] 
		[RED("stats1Name")] 
		public inkTextWidgetReference Stats1Name
		{
			get => GetProperty(ref _stats1Name);
			set => SetProperty(ref _stats1Name, value);
		}

		[Ordinal(13)] 
		[RED("stats1Value")] 
		public inkTextWidgetReference Stats1Value
		{
			get => GetProperty(ref _stats1Value);
			set => SetProperty(ref _stats1Value, value);
		}

		[Ordinal(14)] 
		[RED("stats2")] 
		public inkWidgetReference Stats2
		{
			get => GetProperty(ref _stats2);
			set => SetProperty(ref _stats2, value);
		}

		[Ordinal(15)] 
		[RED("stats2Name")] 
		public inkTextWidgetReference Stats2Name
		{
			get => GetProperty(ref _stats2Name);
			set => SetProperty(ref _stats2Name, value);
		}

		[Ordinal(16)] 
		[RED("stats2Value")] 
		public inkTextWidgetReference Stats2Value
		{
			get => GetProperty(ref _stats2Value);
			set => SetProperty(ref _stats2Value, value);
		}

		[Ordinal(17)] 
		[RED("stats3")] 
		public inkWidgetReference Stats3
		{
			get => GetProperty(ref _stats3);
			set => SetProperty(ref _stats3, value);
		}

		[Ordinal(18)] 
		[RED("stats3Name")] 
		public inkTextWidgetReference Stats3Name
		{
			get => GetProperty(ref _stats3Name);
			set => SetProperty(ref _stats3Name, value);
		}

		[Ordinal(19)] 
		[RED("stats3Value")] 
		public inkTextWidgetReference Stats3Value
		{
			get => GetProperty(ref _stats3Value);
			set => SetProperty(ref _stats3Value, value);
		}

		[Ordinal(20)] 
		[RED("perkTypeName")] 
		public inkTextWidgetReference PerkTypeName
		{
			get => GetProperty(ref _perkTypeName);
			set => SetProperty(ref _perkTypeName, value);
		}

		[Ordinal(21)] 
		[RED("perk1")] 
		public inkWidgetReference Perk1
		{
			get => GetProperty(ref _perk1);
			set => SetProperty(ref _perk1, value);
		}

		[Ordinal(22)] 
		[RED("perk1Icon")] 
		public inkImageWidgetReference Perk1Icon
		{
			get => GetProperty(ref _perk1Icon);
			set => SetProperty(ref _perk1Icon, value);
		}

		[Ordinal(23)] 
		[RED("perk1Name")] 
		public inkTextWidgetReference Perk1Name
		{
			get => GetProperty(ref _perk1Name);
			set => SetProperty(ref _perk1Name, value);
		}

		[Ordinal(24)] 
		[RED("perk2")] 
		public inkWidgetReference Perk2
		{
			get => GetProperty(ref _perk2);
			set => SetProperty(ref _perk2, value);
		}

		[Ordinal(25)] 
		[RED("perk2Icon")] 
		public inkImageWidgetReference Perk2Icon
		{
			get => GetProperty(ref _perk2Icon);
			set => SetProperty(ref _perk2Icon, value);
		}

		[Ordinal(26)] 
		[RED("perk2Name")] 
		public inkTextWidgetReference Perk2Name
		{
			get => GetProperty(ref _perk2Name);
			set => SetProperty(ref _perk2Name, value);
		}

		[Ordinal(27)] 
		[RED("perkTreeInput")] 
		public inkWidgetReference PerkTreeInput
		{
			get => GetProperty(ref _perkTreeInput);
			set => SetProperty(ref _perkTreeInput, value);
		}

		[Ordinal(28)] 
		[RED("perkTreeIcon")] 
		public inkImageWidgetReference PerkTreeIcon
		{
			get => GetProperty(ref _perkTreeIcon);
			set => SetProperty(ref _perkTreeIcon, value);
		}

		[Ordinal(29)] 
		[RED("capacityTitleNameLocKey")] 
		public CName CapacityTitleNameLocKey
		{
			get => GetProperty(ref _capacityTitleNameLocKey);
			set => SetProperty(ref _capacityTitleNameLocKey, value);
		}

		[Ordinal(30)] 
		[RED("capacityStat1LocKey")] 
		public CName CapacityStat1LocKey
		{
			get => GetProperty(ref _capacityStat1LocKey);
			set => SetProperty(ref _capacityStat1LocKey, value);
		}

		[Ordinal(31)] 
		[RED("capacityStat2LocKey")] 
		public CName CapacityStat2LocKey
		{
			get => GetProperty(ref _capacityStat2LocKey);
			set => SetProperty(ref _capacityStat2LocKey, value);
		}

		[Ordinal(32)] 
		[RED("capacityStat3LocKey")] 
		public CName CapacityStat3LocKey
		{
			get => GetProperty(ref _capacityStat3LocKey);
			set => SetProperty(ref _capacityStat3LocKey, value);
		}

		[Ordinal(33)] 
		[RED("capacityPerkTitleLocKey")] 
		public CName CapacityPerkTitleLocKey
		{
			get => GetProperty(ref _capacityPerkTitleLocKey);
			set => SetProperty(ref _capacityPerkTitleLocKey, value);
		}

		[Ordinal(34)] 
		[RED("capacityPerk1IconsName")] 
		public CName CapacityPerk1IconsName
		{
			get => GetProperty(ref _capacityPerk1IconsName);
			set => SetProperty(ref _capacityPerk1IconsName, value);
		}

		[Ordinal(35)] 
		[RED("capacityPerk1LocKey")] 
		public CName CapacityPerk1LocKey
		{
			get => GetProperty(ref _capacityPerk1LocKey);
			set => SetProperty(ref _capacityPerk1LocKey, value);
		}

		[Ordinal(36)] 
		[RED("capacityPerk2IconsName")] 
		public CName CapacityPerk2IconsName
		{
			get => GetProperty(ref _capacityPerk2IconsName);
			set => SetProperty(ref _capacityPerk2IconsName, value);
		}

		[Ordinal(37)] 
		[RED("capacityPerk2LocKey")] 
		public CName CapacityPerk2LocKey
		{
			get => GetProperty(ref _capacityPerk2LocKey);
			set => SetProperty(ref _capacityPerk2LocKey, value);
		}

		[Ordinal(38)] 
		[RED("armorTitleNameLocKey")] 
		public CName ArmorTitleNameLocKey
		{
			get => GetProperty(ref _armorTitleNameLocKey);
			set => SetProperty(ref _armorTitleNameLocKey, value);
		}

		[Ordinal(39)] 
		[RED("armorStat1LocKey")] 
		public CName ArmorStat1LocKey
		{
			get => GetProperty(ref _armorStat1LocKey);
			set => SetProperty(ref _armorStat1LocKey, value);
		}

		[Ordinal(40)] 
		[RED("armorStat2LocKey")] 
		public CName ArmorStat2LocKey
		{
			get => GetProperty(ref _armorStat2LocKey);
			set => SetProperty(ref _armorStat2LocKey, value);
		}

		[Ordinal(41)] 
		[RED("armorStat3LocKey")] 
		public CName ArmorStat3LocKey
		{
			get => GetProperty(ref _armorStat3LocKey);
			set => SetProperty(ref _armorStat3LocKey, value);
		}

		[Ordinal(42)] 
		[RED("armorPerkTitleLocKey")] 
		public CName ArmorPerkTitleLocKey
		{
			get => GetProperty(ref _armorPerkTitleLocKey);
			set => SetProperty(ref _armorPerkTitleLocKey, value);
		}

		[Ordinal(43)] 
		[RED("armorPerk1IconsName")] 
		public CName ArmorPerk1IconsName
		{
			get => GetProperty(ref _armorPerk1IconsName);
			set => SetProperty(ref _armorPerk1IconsName, value);
		}

		[Ordinal(44)] 
		[RED("armorPerk1LocKey")] 
		public CName ArmorPerk1LocKey
		{
			get => GetProperty(ref _armorPerk1LocKey);
			set => SetProperty(ref _armorPerk1LocKey, value);
		}

		public RipperdocBarTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
