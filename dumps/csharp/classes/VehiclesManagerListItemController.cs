using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclesManagerListItemController : inkVirtualCompoundItemController
	{
		private inkTextWidgetReference _label;
		private inkImageWidgetReference _typeIcon;
		private inkImageWidgetReference _customizableIcon;
		private inkTextWidgetReference _repairTime;
		private CHandle<VehicleListItemData> _vehicleData;

		[Ordinal(18)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(19)] 
		[RED("typeIcon")] 
		public inkImageWidgetReference TypeIcon
		{
			get => GetProperty(ref _typeIcon);
			set => SetProperty(ref _typeIcon, value);
		}

		[Ordinal(20)] 
		[RED("customizableIcon")] 
		public inkImageWidgetReference CustomizableIcon
		{
			get => GetProperty(ref _customizableIcon);
			set => SetProperty(ref _customizableIcon, value);
		}

		[Ordinal(21)] 
		[RED("repairTime")] 
		public inkTextWidgetReference RepairTime
		{
			get => GetProperty(ref _repairTime);
			set => SetProperty(ref _repairTime, value);
		}

		[Ordinal(22)] 
		[RED("vehicleData")] 
		public CHandle<VehicleListItemData> VehicleData
		{
			get => GetProperty(ref _vehicleData);
			set => SetProperty(ref _vehicleData, value);
		}

		public VehiclesManagerListItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
