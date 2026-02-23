using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questAudioVehicleMultipliers_NodeType : questIVehicleManagerNodeType
	{
		private gameEntityReference _vehicleRef;
		private audioVehicleMultipliers _multipliers;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("multipliers")] 
		public audioVehicleMultipliers Multipliers
		{
			get => GetProperty(ref _multipliers);
			set => SetProperty(ref _multipliers, value);
		}

		public questAudioVehicleMultipliers_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
