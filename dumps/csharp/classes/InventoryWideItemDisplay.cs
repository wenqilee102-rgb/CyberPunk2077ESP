using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryWideItemDisplay : InventoryItemDisplay
	{
		private inkTextWidgetReference _itemNameText;
		private inkWidgetReference _rarityBackground;
		private inkWidgetReference _iconWrapper;
		private inkWidgetReference _statsWrapper;
		private inkTextWidgetReference _dpsText;
		private inkWidgetReference _damageIndicatorRef;
		private inkTextWidgetReference _additionalInfoText;
		private Vector2 _singleIconSize;
		private wCHandle<DamageTypeIndicator> _damageTypeIndicator;
		private CEnum<ItemAdditionalInfoType> _additionalInfoToShow;

		[Ordinal(24)] 
		[RED("itemNameText")] 
		public inkTextWidgetReference ItemNameText
		{
			get => GetProperty(ref _itemNameText);
			set => SetProperty(ref _itemNameText, value);
		}

		[Ordinal(25)] 
		[RED("rarityBackground")] 
		public inkWidgetReference RarityBackground
		{
			get => GetProperty(ref _rarityBackground);
			set => SetProperty(ref _rarityBackground, value);
		}

		[Ordinal(26)] 
		[RED("iconWrapper")] 
		public inkWidgetReference IconWrapper
		{
			get => GetProperty(ref _iconWrapper);
			set => SetProperty(ref _iconWrapper, value);
		}

		[Ordinal(27)] 
		[RED("statsWrapper")] 
		public inkWidgetReference StatsWrapper
		{
			get => GetProperty(ref _statsWrapper);
			set => SetProperty(ref _statsWrapper, value);
		}

		[Ordinal(28)] 
		[RED("dpsText")] 
		public inkTextWidgetReference DpsText
		{
			get => GetProperty(ref _dpsText);
			set => SetProperty(ref _dpsText, value);
		}

		[Ordinal(29)] 
		[RED("damageIndicatorRef")] 
		public inkWidgetReference DamageIndicatorRef
		{
			get => GetProperty(ref _damageIndicatorRef);
			set => SetProperty(ref _damageIndicatorRef, value);
		}

		[Ordinal(30)] 
		[RED("additionalInfoText")] 
		public inkTextWidgetReference AdditionalInfoText
		{
			get => GetProperty(ref _additionalInfoText);
			set => SetProperty(ref _additionalInfoText, value);
		}

		[Ordinal(31)] 
		[RED("singleIconSize")] 
		public Vector2 SingleIconSize
		{
			get => GetProperty(ref _singleIconSize);
			set => SetProperty(ref _singleIconSize, value);
		}

		[Ordinal(32)] 
		[RED("damageTypeIndicator")] 
		public wCHandle<DamageTypeIndicator> DamageTypeIndicator
		{
			get => GetProperty(ref _damageTypeIndicator);
			set => SetProperty(ref _damageTypeIndicator, value);
		}

		[Ordinal(33)] 
		[RED("additionalInfoToShow")] 
		public CEnum<ItemAdditionalInfoType> AdditionalInfoToShow
		{
			get => GetProperty(ref _additionalInfoToShow);
			set => SetProperty(ref _additionalInfoToShow, value);
		}

		public InventoryWideItemDisplay(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
