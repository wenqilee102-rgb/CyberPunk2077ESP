using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonWidgetGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _vehicleNameLabel;
		private inkImageWidgetReference _vehicleTypeIcon;
		private inkImageWidgetReference _vehicleManufactorIcon;
		private inkTextWidgetReference _distanceLabel;
		private inkTextWidgetReference _subText;
		private inkTextWidgetReference _radioStationName;
		private CUInt32 _loopCounter;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CHandle<gamedataVehicle_Record> _vehicleRecord;
		private ScriptGameInstance _gameInstance;
		private wCHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CHandle<redCallbackObject> _mountCallback;
		private CHandle<redCallbackObject> _vehicleSummonStateCallback;
		private CHandle<redCallbackObject> _vehiclePurchaseStateCallback;
		private CName _currentAnimation;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _animationCounterProxy;

		[Ordinal(9)] 
		[RED("vehicleNameLabel")] 
		public inkTextWidgetReference VehicleNameLabel
		{
			get => GetProperty(ref _vehicleNameLabel);
			set => SetProperty(ref _vehicleNameLabel, value);
		}

		[Ordinal(10)] 
		[RED("vehicleTypeIcon")] 
		public inkImageWidgetReference VehicleTypeIcon
		{
			get => GetProperty(ref _vehicleTypeIcon);
			set => SetProperty(ref _vehicleTypeIcon, value);
		}

		[Ordinal(11)] 
		[RED("vehicleManufactorIcon")] 
		public inkImageWidgetReference VehicleManufactorIcon
		{
			get => GetProperty(ref _vehicleManufactorIcon);
			set => SetProperty(ref _vehicleManufactorIcon, value);
		}

		[Ordinal(12)] 
		[RED("distanceLabel")] 
		public inkTextWidgetReference DistanceLabel
		{
			get => GetProperty(ref _distanceLabel);
			set => SetProperty(ref _distanceLabel, value);
		}

		[Ordinal(13)] 
		[RED("subText")] 
		public inkTextWidgetReference SubText
		{
			get => GetProperty(ref _subText);
			set => SetProperty(ref _subText, value);
		}

		[Ordinal(14)] 
		[RED("radioStationName")] 
		public inkTextWidgetReference RadioStationName
		{
			get => GetProperty(ref _radioStationName);
			set => SetProperty(ref _radioStationName, value);
		}

		[Ordinal(15)] 
		[RED("loopCounter")] 
		public CUInt32 LoopCounter
		{
			get => GetProperty(ref _loopCounter);
			set => SetProperty(ref _loopCounter, value);
		}

		[Ordinal(16)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(17)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(18)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(19)] 
		[RED("vehicleRecord")] 
		public CHandle<gamedataVehicle_Record> VehicleRecord
		{
			get => GetProperty(ref _vehicleRecord);
			set => SetProperty(ref _vehicleRecord, value);
		}

		[Ordinal(20)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(21)] 
		[RED("vehicleSummonDataBB")] 
		public wCHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetProperty(ref _vehicleSummonDataBB);
			set => SetProperty(ref _vehicleSummonDataBB, value);
		}

		[Ordinal(22)] 
		[RED("mountCallback")] 
		public CHandle<redCallbackObject> MountCallback
		{
			get => GetProperty(ref _mountCallback);
			set => SetProperty(ref _mountCallback, value);
		}

		[Ordinal(23)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetProperty(ref _vehicleSummonStateCallback);
			set => SetProperty(ref _vehicleSummonStateCallback, value);
		}

		[Ordinal(24)] 
		[RED("vehiclePurchaseStateCallback")] 
		public CHandle<redCallbackObject> VehiclePurchaseStateCallback
		{
			get => GetProperty(ref _vehiclePurchaseStateCallback);
			set => SetProperty(ref _vehiclePurchaseStateCallback, value);
		}

		[Ordinal(25)] 
		[RED("currentAnimation")] 
		public CName CurrentAnimation
		{
			get => GetProperty(ref _currentAnimation);
			set => SetProperty(ref _currentAnimation, value);
		}

		[Ordinal(26)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(27)] 
		[RED("animationCounterProxy")] 
		public CHandle<inkanimProxy> AnimationCounterProxy
		{
			get => GetProperty(ref _animationCounterProxy);
			set => SetProperty(ref _animationCounterProxy, value);
		}

		public VehicleSummonWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
