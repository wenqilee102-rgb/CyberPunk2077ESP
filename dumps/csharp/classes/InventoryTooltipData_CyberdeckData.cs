using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_CyberdeckData : IScriptable
	{
		private CBool _vehicleHackUnlocked;
		private CBool _viewingTooltipFromCyberwareMenu;

		[Ordinal(0)] 
		[RED("vehicleHackUnlocked")] 
		public CBool VehicleHackUnlocked
		{
			get => GetProperty(ref _vehicleHackUnlocked);
			set => SetProperty(ref _vehicleHackUnlocked, value);
		}

		[Ordinal(1)] 
		[RED("viewingTooltipFromCyberwareMenu")] 
		public CBool ViewingTooltipFromCyberwareMenu
		{
			get => GetProperty(ref _viewingTooltipFromCyberwareMenu);
			set => SetProperty(ref _viewingTooltipFromCyberwareMenu, value);
		}

		public InventoryTooltipData_CyberdeckData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
