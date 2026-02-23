using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UpgradingScreenController : CraftingMainLogicController
	{
		private inkTextWidgetReference _itemNameUpgrade;
		private inkWidgetReference _arrowComparison;
		private wCHandle<AGenericTooltipController> _itemTooltipControllerLeft;
		private wCHandle<AGenericTooltipController> _itemTooltipControllerRight;
		private CHandle<MinimalItemTooltipData> _tooltipDataLeft;
		private CHandle<MinimalItemTooltipData> _tooltipDataRight;
		private CArray<CEnum<gamedataItemType>> _weaponAreas;
		private CArray<CEnum<gamedataEquipmentArea>> _equipAreas;
		private CFloat _dELAYED_TOOLTIP_RIGHT;

		[Ordinal(51)] 
		[RED("itemNameUpgrade")] 
		public inkTextWidgetReference ItemNameUpgrade
		{
			get => GetProperty(ref _itemNameUpgrade);
			set => SetProperty(ref _itemNameUpgrade, value);
		}

		[Ordinal(52)] 
		[RED("arrowComparison")] 
		public inkWidgetReference ArrowComparison
		{
			get => GetProperty(ref _arrowComparison);
			set => SetProperty(ref _arrowComparison, value);
		}

		[Ordinal(53)] 
		[RED("itemTooltipControllerLeft")] 
		public wCHandle<AGenericTooltipController> ItemTooltipControllerLeft
		{
			get => GetProperty(ref _itemTooltipControllerLeft);
			set => SetProperty(ref _itemTooltipControllerLeft, value);
		}

		[Ordinal(54)] 
		[RED("itemTooltipControllerRight")] 
		public wCHandle<AGenericTooltipController> ItemTooltipControllerRight
		{
			get => GetProperty(ref _itemTooltipControllerRight);
			set => SetProperty(ref _itemTooltipControllerRight, value);
		}

		[Ordinal(55)] 
		[RED("tooltipDataLeft")] 
		public CHandle<MinimalItemTooltipData> TooltipDataLeft
		{
			get => GetProperty(ref _tooltipDataLeft);
			set => SetProperty(ref _tooltipDataLeft, value);
		}

		[Ordinal(56)] 
		[RED("tooltipDataRight")] 
		public CHandle<MinimalItemTooltipData> TooltipDataRight
		{
			get => GetProperty(ref _tooltipDataRight);
			set => SetProperty(ref _tooltipDataRight, value);
		}

		[Ordinal(57)] 
		[RED("WeaponAreas")] 
		public CArray<CEnum<gamedataItemType>> WeaponAreas
		{
			get => GetProperty(ref _weaponAreas);
			set => SetProperty(ref _weaponAreas, value);
		}

		[Ordinal(58)] 
		[RED("EquipAreas")] 
		public CArray<CEnum<gamedataEquipmentArea>> EquipAreas
		{
			get => GetProperty(ref _equipAreas);
			set => SetProperty(ref _equipAreas, value);
		}

		[Ordinal(59)] 
		[RED("DELAYED_TOOLTIP_RIGHT")] 
		public CFloat DELAYED_TOOLTIP_RIGHT
		{
			get => GetProperty(ref _dELAYED_TOOLTIP_RIGHT);
			set => SetProperty(ref _dELAYED_TOOLTIP_RIGHT, value);
		}

		public UpgradingScreenController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
