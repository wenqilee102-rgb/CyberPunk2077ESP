using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleListItemData : IScriptable
	{
		private CName _displayName;
		private vehiclePlayerVehicle _data;
		private wCHandle<gamedataUIIcon_Record> _icon;
		private CFloat _repairTimeRemaining;
		private CBool _canBeActive;

		[Ordinal(0)] 
		[RED("displayName")] 
		public CName DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public vehiclePlayerVehicle Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(2)] 
		[RED("icon")] 
		public wCHandle<gamedataUIIcon_Record> Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(3)] 
		[RED("repairTimeRemaining")] 
		public CFloat RepairTimeRemaining
		{
			get => GetProperty(ref _repairTimeRemaining);
			set => SetProperty(ref _repairTimeRemaining, value);
		}

		[Ordinal(4)] 
		[RED("canBeActive")] 
		public CBool CanBeActive
		{
			get => GetProperty(ref _canBeActive);
			set => SetProperty(ref _canBeActive, value);
		}

		public VehicleListItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
