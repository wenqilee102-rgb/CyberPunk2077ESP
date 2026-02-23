using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleNetrunnerQuickhackVehicleEndedEvent : redEvent
	{
		private CEnum<vehicleVehicleNetrunnerQuickhackType> _vehicleNetrunnerQuickhackType;
		private CBool _shouldTriggerPanicDriving;
		private CBool _shouldRejoinTraffic;

		[Ordinal(0)] 
		[RED("vehicleNetrunnerQuickhackType")] 
		public CEnum<vehicleVehicleNetrunnerQuickhackType> VehicleNetrunnerQuickhackType
		{
			get => GetProperty(ref _vehicleNetrunnerQuickhackType);
			set => SetProperty(ref _vehicleNetrunnerQuickhackType, value);
		}

		[Ordinal(1)] 
		[RED("shouldTriggerPanicDriving")] 
		public CBool ShouldTriggerPanicDriving
		{
			get => GetProperty(ref _shouldTriggerPanicDriving);
			set => SetProperty(ref _shouldTriggerPanicDriving, value);
		}

		[Ordinal(2)] 
		[RED("shouldRejoinTraffic")] 
		public CBool ShouldRejoinTraffic
		{
			get => GetProperty(ref _shouldRejoinTraffic);
			set => SetProperty(ref _shouldRejoinTraffic, value);
		}

		public vehicleNetrunnerQuickhackVehicleEndedEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
