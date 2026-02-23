using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JoinTrafficInPoliceVehicle : AIVehicleTaskAbstract
	{
		private wCHandle<vehicleBaseObject> _vehicle;
		private CHandle<AIVehiclePanicCommand> _panicDrivingCmd;

		[Ordinal(0)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(1)] 
		[RED("panicDrivingCmd")] 
		public CHandle<AIVehiclePanicCommand> PanicDrivingCmd
		{
			get => GetProperty(ref _panicDrivingCmd);
			set => SetProperty(ref _panicDrivingCmd, value);
		}

		public JoinTrafficInPoliceVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
