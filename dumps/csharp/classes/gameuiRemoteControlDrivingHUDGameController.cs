using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiRemoteControlDrivingHUDGameController : gameuiHUDGameController
	{
		private inkWidgetReference _overlay;
		private inkImageWidgetReference _vehicleManufacturer;
		private inkWidgetReference _containerSignalStrength;
		private inkWidgetReference _signalStrengthBarFill;
		private CHandle<inkanimProxy> _containerSignalStrengthIntroOutroAnimProxy;
		private CHandle<inkanimProxy> _weakSignalStrengthAnimProxy;
		private CHandle<redCallbackObject> _remoteControlledVehicleDataCallback;
		private CHandle<redCallbackObject> _remoteControlledVehicleCameraChangedToTPPCallback;
		private wCHandle<vehicleBaseObject> _remoteControlledVehicle;
		private CFloat _maxRemoteControlDrivingRange;
		private gameNewMappinID _mappinID;

		[Ordinal(9)] 
		[RED("overlay")] 
		public inkWidgetReference Overlay
		{
			get => GetProperty(ref _overlay);
			set => SetProperty(ref _overlay, value);
		}

		[Ordinal(10)] 
		[RED("vehicleManufacturer")] 
		public inkImageWidgetReference VehicleManufacturer
		{
			get => GetProperty(ref _vehicleManufacturer);
			set => SetProperty(ref _vehicleManufacturer, value);
		}

		[Ordinal(11)] 
		[RED("containerSignalStrength")] 
		public inkWidgetReference ContainerSignalStrength
		{
			get => GetProperty(ref _containerSignalStrength);
			set => SetProperty(ref _containerSignalStrength, value);
		}

		[Ordinal(12)] 
		[RED("signalStrengthBarFill")] 
		public inkWidgetReference SignalStrengthBarFill
		{
			get => GetProperty(ref _signalStrengthBarFill);
			set => SetProperty(ref _signalStrengthBarFill, value);
		}

		[Ordinal(13)] 
		[RED("containerSignalStrengthIntroOutroAnimProxy")] 
		public CHandle<inkanimProxy> ContainerSignalStrengthIntroOutroAnimProxy
		{
			get => GetProperty(ref _containerSignalStrengthIntroOutroAnimProxy);
			set => SetProperty(ref _containerSignalStrengthIntroOutroAnimProxy, value);
		}

		[Ordinal(14)] 
		[RED("weakSignalStrengthAnimProxy")] 
		public CHandle<inkanimProxy> WeakSignalStrengthAnimProxy
		{
			get => GetProperty(ref _weakSignalStrengthAnimProxy);
			set => SetProperty(ref _weakSignalStrengthAnimProxy, value);
		}

		[Ordinal(15)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetProperty(ref _remoteControlledVehicleDataCallback);
			set => SetProperty(ref _remoteControlledVehicleDataCallback, value);
		}

		[Ordinal(16)] 
		[RED("remoteControlledVehicleCameraChangedToTPPCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleCameraChangedToTPPCallback
		{
			get => GetProperty(ref _remoteControlledVehicleCameraChangedToTPPCallback);
			set => SetProperty(ref _remoteControlledVehicleCameraChangedToTPPCallback, value);
		}

		[Ordinal(17)] 
		[RED("remoteControlledVehicle")] 
		public wCHandle<vehicleBaseObject> RemoteControlledVehicle
		{
			get => GetProperty(ref _remoteControlledVehicle);
			set => SetProperty(ref _remoteControlledVehicle, value);
		}

		[Ordinal(18)] 
		[RED("maxRemoteControlDrivingRange")] 
		public CFloat MaxRemoteControlDrivingRange
		{
			get => GetProperty(ref _maxRemoteControlDrivingRange);
			set => SetProperty(ref _maxRemoteControlDrivingRange, value);
		}

		[Ordinal(19)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		public gameuiRemoteControlDrivingHUDGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
