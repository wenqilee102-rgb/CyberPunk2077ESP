using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioVehicleGeneralData : CVariable
	{
		private CName _revSoundbankName;
		private CName _revElectricSoundbankName;
		private CName _reverbSoundbankName;
		private CName _enterVehicleEvent;
		private CName _exitVehicleEvent;
		private CName _ignitionStartEvent;
		private CName _ignitionEndEvent;
		private CName _uIStartEvent;
		private CName _uIEndEvent;
		private CName _hornOnEvent;
		private CName _hornOffEvent;
		private CName _policeHornOnEvent;
		private CName _policeHornOffEvent;
		private CName _trafficPanicHornOnEvent;
		private CName _trafficPanicHornOffEvent;
		private CName _sirenOnEvent;
		private CName _sirenOffEvent;
		private CName _rainStartEvent;
		private CName _rainStopEvent;
		private CName _waterStartEvent;
		private CName _waterStopEvent;
		private CName _tyreBurstEvent;
		private CName _skid;
		private CName _inclination;
		private CName _impactVelocity;
		private CName _impactGridCellRawChange;
		private CName _collisionSoundEvent;
		private CName _brakeApplyEvent;
		private CName _brakeReleaseEvent;
		private CName _handbrakeApplyEvent;
		private CName _handbrakeReleaseEvent;
		private CName _brakeLoopStartEvent;
		private CName _brakeLoopEndEvent;
		private CName _lightsOnEvent;
		private CName _lightsOffEvent;
		private CName _interiorReverbBus;
		private CName _acoustingIsolationFactor;
		private CName _dopplerShift;
		private audioVehicleDoorsSettingsMetadata _vehicleDoorsSettings;
		private audioVehicleInteriorParameterData _vehicleInteriorParameterData;
		private audioVehicleTemperatureSettings _vehicleTemperatureSettings;

		[Ordinal(0)] 
		[RED("revSoundbankName")] 
		public CName RevSoundbankName
		{
			get => GetProperty(ref _revSoundbankName);
			set => SetProperty(ref _revSoundbankName, value);
		}

		[Ordinal(1)] 
		[RED("revElectricSoundbankName")] 
		public CName RevElectricSoundbankName
		{
			get => GetProperty(ref _revElectricSoundbankName);
			set => SetProperty(ref _revElectricSoundbankName, value);
		}

		[Ordinal(2)] 
		[RED("reverbSoundbankName")] 
		public CName ReverbSoundbankName
		{
			get => GetProperty(ref _reverbSoundbankName);
			set => SetProperty(ref _reverbSoundbankName, value);
		}

		[Ordinal(3)] 
		[RED("enterVehicleEvent")] 
		public CName EnterVehicleEvent
		{
			get => GetProperty(ref _enterVehicleEvent);
			set => SetProperty(ref _enterVehicleEvent, value);
		}

		[Ordinal(4)] 
		[RED("exitVehicleEvent")] 
		public CName ExitVehicleEvent
		{
			get => GetProperty(ref _exitVehicleEvent);
			set => SetProperty(ref _exitVehicleEvent, value);
		}

		[Ordinal(5)] 
		[RED("ignitionStartEvent")] 
		public CName IgnitionStartEvent
		{
			get => GetProperty(ref _ignitionStartEvent);
			set => SetProperty(ref _ignitionStartEvent, value);
		}

		[Ordinal(6)] 
		[RED("ignitionEndEvent")] 
		public CName IgnitionEndEvent
		{
			get => GetProperty(ref _ignitionEndEvent);
			set => SetProperty(ref _ignitionEndEvent, value);
		}

		[Ordinal(7)] 
		[RED("UIStartEvent")] 
		public CName UIStartEvent
		{
			get => GetProperty(ref _uIStartEvent);
			set => SetProperty(ref _uIStartEvent, value);
		}

		[Ordinal(8)] 
		[RED("UIEndEvent")] 
		public CName UIEndEvent
		{
			get => GetProperty(ref _uIEndEvent);
			set => SetProperty(ref _uIEndEvent, value);
		}

		[Ordinal(9)] 
		[RED("hornOnEvent")] 
		public CName HornOnEvent
		{
			get => GetProperty(ref _hornOnEvent);
			set => SetProperty(ref _hornOnEvent, value);
		}

		[Ordinal(10)] 
		[RED("hornOffEvent")] 
		public CName HornOffEvent
		{
			get => GetProperty(ref _hornOffEvent);
			set => SetProperty(ref _hornOffEvent, value);
		}

		[Ordinal(11)] 
		[RED("policeHornOnEvent")] 
		public CName PoliceHornOnEvent
		{
			get => GetProperty(ref _policeHornOnEvent);
			set => SetProperty(ref _policeHornOnEvent, value);
		}

		[Ordinal(12)] 
		[RED("policeHornOffEvent")] 
		public CName PoliceHornOffEvent
		{
			get => GetProperty(ref _policeHornOffEvent);
			set => SetProperty(ref _policeHornOffEvent, value);
		}

		[Ordinal(13)] 
		[RED("trafficPanicHornOnEvent")] 
		public CName TrafficPanicHornOnEvent
		{
			get => GetProperty(ref _trafficPanicHornOnEvent);
			set => SetProperty(ref _trafficPanicHornOnEvent, value);
		}

		[Ordinal(14)] 
		[RED("trafficPanicHornOffEvent")] 
		public CName TrafficPanicHornOffEvent
		{
			get => GetProperty(ref _trafficPanicHornOffEvent);
			set => SetProperty(ref _trafficPanicHornOffEvent, value);
		}

		[Ordinal(15)] 
		[RED("sirenOnEvent")] 
		public CName SirenOnEvent
		{
			get => GetProperty(ref _sirenOnEvent);
			set => SetProperty(ref _sirenOnEvent, value);
		}

		[Ordinal(16)] 
		[RED("sirenOffEvent")] 
		public CName SirenOffEvent
		{
			get => GetProperty(ref _sirenOffEvent);
			set => SetProperty(ref _sirenOffEvent, value);
		}

		[Ordinal(17)] 
		[RED("rainStartEvent")] 
		public CName RainStartEvent
		{
			get => GetProperty(ref _rainStartEvent);
			set => SetProperty(ref _rainStartEvent, value);
		}

		[Ordinal(18)] 
		[RED("rainStopEvent")] 
		public CName RainStopEvent
		{
			get => GetProperty(ref _rainStopEvent);
			set => SetProperty(ref _rainStopEvent, value);
		}

		[Ordinal(19)] 
		[RED("waterStartEvent")] 
		public CName WaterStartEvent
		{
			get => GetProperty(ref _waterStartEvent);
			set => SetProperty(ref _waterStartEvent, value);
		}

		[Ordinal(20)] 
		[RED("waterStopEvent")] 
		public CName WaterStopEvent
		{
			get => GetProperty(ref _waterStopEvent);
			set => SetProperty(ref _waterStopEvent, value);
		}

		[Ordinal(21)] 
		[RED("tyreBurstEvent")] 
		public CName TyreBurstEvent
		{
			get => GetProperty(ref _tyreBurstEvent);
			set => SetProperty(ref _tyreBurstEvent, value);
		}

		[Ordinal(22)] 
		[RED("skid")] 
		public CName Skid
		{
			get => GetProperty(ref _skid);
			set => SetProperty(ref _skid, value);
		}

		[Ordinal(23)] 
		[RED("inclination")] 
		public CName Inclination
		{
			get => GetProperty(ref _inclination);
			set => SetProperty(ref _inclination, value);
		}

		[Ordinal(24)] 
		[RED("impactVelocity")] 
		public CName ImpactVelocity
		{
			get => GetProperty(ref _impactVelocity);
			set => SetProperty(ref _impactVelocity, value);
		}

		[Ordinal(25)] 
		[RED("impactGridCellRawChange")] 
		public CName ImpactGridCellRawChange
		{
			get => GetProperty(ref _impactGridCellRawChange);
			set => SetProperty(ref _impactGridCellRawChange, value);
		}

		[Ordinal(26)] 
		[RED("collisionSoundEvent")] 
		public CName CollisionSoundEvent
		{
			get => GetProperty(ref _collisionSoundEvent);
			set => SetProperty(ref _collisionSoundEvent, value);
		}

		[Ordinal(27)] 
		[RED("brakeApplyEvent")] 
		public CName BrakeApplyEvent
		{
			get => GetProperty(ref _brakeApplyEvent);
			set => SetProperty(ref _brakeApplyEvent, value);
		}

		[Ordinal(28)] 
		[RED("brakeReleaseEvent")] 
		public CName BrakeReleaseEvent
		{
			get => GetProperty(ref _brakeReleaseEvent);
			set => SetProperty(ref _brakeReleaseEvent, value);
		}

		[Ordinal(29)] 
		[RED("handbrakeApplyEvent")] 
		public CName HandbrakeApplyEvent
		{
			get => GetProperty(ref _handbrakeApplyEvent);
			set => SetProperty(ref _handbrakeApplyEvent, value);
		}

		[Ordinal(30)] 
		[RED("handbrakeReleaseEvent")] 
		public CName HandbrakeReleaseEvent
		{
			get => GetProperty(ref _handbrakeReleaseEvent);
			set => SetProperty(ref _handbrakeReleaseEvent, value);
		}

		[Ordinal(31)] 
		[RED("brakeLoopStartEvent")] 
		public CName BrakeLoopStartEvent
		{
			get => GetProperty(ref _brakeLoopStartEvent);
			set => SetProperty(ref _brakeLoopStartEvent, value);
		}

		[Ordinal(32)] 
		[RED("brakeLoopEndEvent")] 
		public CName BrakeLoopEndEvent
		{
			get => GetProperty(ref _brakeLoopEndEvent);
			set => SetProperty(ref _brakeLoopEndEvent, value);
		}

		[Ordinal(33)] 
		[RED("lightsOnEvent")] 
		public CName LightsOnEvent
		{
			get => GetProperty(ref _lightsOnEvent);
			set => SetProperty(ref _lightsOnEvent, value);
		}

		[Ordinal(34)] 
		[RED("lightsOffEvent")] 
		public CName LightsOffEvent
		{
			get => GetProperty(ref _lightsOffEvent);
			set => SetProperty(ref _lightsOffEvent, value);
		}

		[Ordinal(35)] 
		[RED("interiorReverbBus")] 
		public CName InteriorReverbBus
		{
			get => GetProperty(ref _interiorReverbBus);
			set => SetProperty(ref _interiorReverbBus, value);
		}

		[Ordinal(36)] 
		[RED("acoustingIsolationFactor")] 
		public CName AcoustingIsolationFactor
		{
			get => GetProperty(ref _acoustingIsolationFactor);
			set => SetProperty(ref _acoustingIsolationFactor, value);
		}

		[Ordinal(37)] 
		[RED("dopplerShift")] 
		public CName DopplerShift
		{
			get => GetProperty(ref _dopplerShift);
			set => SetProperty(ref _dopplerShift, value);
		}

		[Ordinal(38)] 
		[RED("vehicleDoorsSettings")] 
		public audioVehicleDoorsSettingsMetadata VehicleDoorsSettings
		{
			get => GetProperty(ref _vehicleDoorsSettings);
			set => SetProperty(ref _vehicleDoorsSettings, value);
		}

		[Ordinal(39)] 
		[RED("vehicleInteriorParameterData")] 
		public audioVehicleInteriorParameterData VehicleInteriorParameterData
		{
			get => GetProperty(ref _vehicleInteriorParameterData);
			set => SetProperty(ref _vehicleInteriorParameterData, value);
		}

		[Ordinal(40)] 
		[RED("vehicleTemperatureSettings")] 
		public audioVehicleTemperatureSettings VehicleTemperatureSettings
		{
			get => GetProperty(ref _vehicleTemperatureSettings);
			set => SetProperty(ref _vehicleTemperatureSettings, value);
		}

		public audioVehicleGeneralData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
