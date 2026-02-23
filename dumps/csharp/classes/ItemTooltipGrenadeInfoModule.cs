using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipGrenadeInfoModule : ItemTooltipModuleController
	{
		private inkTextWidgetReference _headerText;
		private inkTextWidgetReference _totalDamageText;
		private inkWidgetReference _lineDamage;
		private inkWidgetReference _damageWrapper;
		private inkTextWidgetReference _damageTypeText;
		private inkTextWidgetReference _damageValue;
		private inkWidgetReference _damageSec;
		private inkTextWidgetReference _durationText;
		private inkTextWidgetReference _rangeText;
		private inkImageWidgetReference _deliveryIcon;
		private inkTextWidgetReference _deliveryText;

		[Ordinal(5)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetProperty(ref _headerText);
			set => SetProperty(ref _headerText, value);
		}

		[Ordinal(6)] 
		[RED("totalDamageText")] 
		public inkTextWidgetReference TotalDamageText
		{
			get => GetProperty(ref _totalDamageText);
			set => SetProperty(ref _totalDamageText, value);
		}

		[Ordinal(7)] 
		[RED("lineDamage")] 
		public inkWidgetReference LineDamage
		{
			get => GetProperty(ref _lineDamage);
			set => SetProperty(ref _lineDamage, value);
		}

		[Ordinal(8)] 
		[RED("damageWrapper")] 
		public inkWidgetReference DamageWrapper
		{
			get => GetProperty(ref _damageWrapper);
			set => SetProperty(ref _damageWrapper, value);
		}

		[Ordinal(9)] 
		[RED("damageTypeText")] 
		public inkTextWidgetReference DamageTypeText
		{
			get => GetProperty(ref _damageTypeText);
			set => SetProperty(ref _damageTypeText, value);
		}

		[Ordinal(10)] 
		[RED("damageValue")] 
		public inkTextWidgetReference DamageValue
		{
			get => GetProperty(ref _damageValue);
			set => SetProperty(ref _damageValue, value);
		}

		[Ordinal(11)] 
		[RED("damageSec")] 
		public inkWidgetReference DamageSec
		{
			get => GetProperty(ref _damageSec);
			set => SetProperty(ref _damageSec, value);
		}

		[Ordinal(12)] 
		[RED("durationText")] 
		public inkTextWidgetReference DurationText
		{
			get => GetProperty(ref _durationText);
			set => SetProperty(ref _durationText, value);
		}

		[Ordinal(13)] 
		[RED("rangeText")] 
		public inkTextWidgetReference RangeText
		{
			get => GetProperty(ref _rangeText);
			set => SetProperty(ref _rangeText, value);
		}

		[Ordinal(14)] 
		[RED("deliveryIcon")] 
		public inkImageWidgetReference DeliveryIcon
		{
			get => GetProperty(ref _deliveryIcon);
			set => SetProperty(ref _deliveryIcon, value);
		}

		[Ordinal(15)] 
		[RED("deliveryText")] 
		public inkTextWidgetReference DeliveryText
		{
			get => GetProperty(ref _deliveryText);
			set => SetProperty(ref _deliveryText, value);
		}

		public ItemTooltipGrenadeInfoModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
