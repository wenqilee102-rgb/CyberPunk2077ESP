using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotStartCondition_VehicleType : vehicleCinematicCameraShotStartCondition
	{
		private CEnum<gamedataVehicleType> _vehicleType;

		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		public vehicleCinematicCameraShotStartCondition_VehicleType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
