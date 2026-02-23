using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipBottomModule : NewItemTooltipModuleController
	{
		private inkWidgetReference _weightWrapper;
		private inkWidgetReference _priceWrapper;
		private inkWidgetReference _ammoWrapper;
		private inkTextWidgetReference _weightText;
		private inkTextWidgetReference _priceText;
		private inkTextWidgetReference _ammoText;
		private inkImageWidgetReference _ammoIcon;

		[Ordinal(5)] 
		[RED("weightWrapper")] 
		public inkWidgetReference WeightWrapper
		{
			get => GetProperty(ref _weightWrapper);
			set => SetProperty(ref _weightWrapper, value);
		}

		[Ordinal(6)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetProperty(ref _priceWrapper);
			set => SetProperty(ref _priceWrapper, value);
		}

		[Ordinal(7)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get => GetProperty(ref _ammoWrapper);
			set => SetProperty(ref _ammoWrapper, value);
		}

		[Ordinal(8)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get => GetProperty(ref _weightText);
			set => SetProperty(ref _weightText, value);
		}

		[Ordinal(9)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(10)] 
		[RED("ammoText")] 
		public inkTextWidgetReference AmmoText
		{
			get => GetProperty(ref _ammoText);
			set => SetProperty(ref _ammoText, value);
		}

		[Ordinal(11)] 
		[RED("ammoIcon")] 
		public inkImageWidgetReference AmmoIcon
		{
			get => GetProperty(ref _ammoIcon);
			set => SetProperty(ref _ammoIcon, value);
		}

		public NewItemTooltipBottomModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
