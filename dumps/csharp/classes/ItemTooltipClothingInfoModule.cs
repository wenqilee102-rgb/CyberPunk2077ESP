using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipClothingInfoModule : ItemTooltipModuleController
	{
		private inkCompoundWidgetReference _allocationCostsWrapper;
		private inkWidgetReference _armorContainer;
		private inkTextWidgetReference _value;
		private inkImageWidgetReference _arrow;

		[Ordinal(5)] 
		[RED("allocationCostsWrapper")] 
		public inkCompoundWidgetReference AllocationCostsWrapper
		{
			get => GetProperty(ref _allocationCostsWrapper);
			set => SetProperty(ref _allocationCostsWrapper, value);
		}

		[Ordinal(6)] 
		[RED("armorContainer")] 
		public inkWidgetReference ArmorContainer
		{
			get => GetProperty(ref _armorContainer);
			set => SetProperty(ref _armorContainer, value);
		}

		[Ordinal(7)] 
		[RED("value")] 
		public inkTextWidgetReference Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(8)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		public ItemTooltipClothingInfoModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
