using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DataTermDeviceBlackboardDef : DeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _fastTravelPoint;
		private gamebbScriptID_Bool _triggerWorldMap;
		private gamebbScriptID_Int32 _passengerCount;
		private gamebbScriptID_Bool _subwayGateOpen;

		[Ordinal(7)] 
		[RED("fastTravelPoint")] 
		public gamebbScriptID_Variant FastTravelPoint
		{
			get => GetProperty(ref _fastTravelPoint);
			set => SetProperty(ref _fastTravelPoint, value);
		}

		[Ordinal(8)] 
		[RED("triggerWorldMap")] 
		public gamebbScriptID_Bool TriggerWorldMap
		{
			get => GetProperty(ref _triggerWorldMap);
			set => SetProperty(ref _triggerWorldMap, value);
		}

		[Ordinal(9)] 
		[RED("passengerCount")] 
		public gamebbScriptID_Int32 PassengerCount
		{
			get => GetProperty(ref _passengerCount);
			set => SetProperty(ref _passengerCount, value);
		}

		[Ordinal(10)] 
		[RED("subwayGateOpen")] 
		public gamebbScriptID_Bool SubwayGateOpen
		{
			get => GetProperty(ref _subwayGateOpen);
			set => SetProperty(ref _subwayGateOpen, value);
		}

		public DataTermDeviceBlackboardDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
