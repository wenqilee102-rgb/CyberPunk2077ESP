using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartDoorScreenInkController : NcartTrainInkControllerBase
	{
		private CArray<ncartDoorScreenLineDataDef> _linesList;
		private CName _activeLineFactName;
		private CName _nextStationFactName;
		private CName _metroStoppingFactName;
		private wCHandle<inkCompoundWidget> _root;
		private wCHandle<questQuestsSystem> _questsSystem;
		private CUInt32 _stopListenerId;
		private CUInt32 _nextStationListenerId;
		private CHandle<redCallbackObject> _gameTimeCallback;
		private inkImageWidgetReference _ncartTextLogo;
		private inkTextWidgetReference _timeWidget;
		private inkTextWidgetReference _stationNameWidget;
		private inkTextWidgetReference _stationStatusWidget;
		private inkTextWidgetReference _districtNameWidget;
		private inkImageWidgetReference _stationDistrictBackgroundColor;
		private inkWidgetReference _sun_moon_container;
		private inkImageWidgetReference _weather_sun_widget;
		private inkImageWidgetReference _weather_moon_widget;
		private inkImageWidgetReference _weather_cloud_a_widget;
		private inkImageWidgetReference _weather_cloud_b_widget;
		private inkImageWidgetReference _weather_rain_widget;
		private inkTextWidgetReference _speed_display;
		private inkImageWidgetReference _speed_display_deco_1;
		private inkImageWidgetReference _speed_display_deco_2;
		private inkImageWidgetReference _speed_display_deco_3;
		private inkImageWidgetReference _speed_display_deco_4;
		private CInt32 _cachedActiveLine;
		private CInt32 _cachedNextStation;
		private CEnum<ENcartDistricts> _cachedDistrict;
		private CBool _updateDistrictName;
		private wCHandle<vehicleBaseObject> _ownerObject;
		private wCHandle<gameIBlackboard> _vehicleBlackboard;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<redCallbackObject> _speedListner;
		private CFloat _speedLastValue;

		[Ordinal(16)] 
		[RED("LinesList")] 
		public CArray<ncartDoorScreenLineDataDef> LinesList
		{
			get => GetProperty(ref _linesList);
			set => SetProperty(ref _linesList, value);
		}

		[Ordinal(17)] 
		[RED("ActiveLineFactName")] 
		public CName ActiveLineFactName
		{
			get => GetProperty(ref _activeLineFactName);
			set => SetProperty(ref _activeLineFactName, value);
		}

		[Ordinal(18)] 
		[RED("NextStationFactName")] 
		public CName NextStationFactName
		{
			get => GetProperty(ref _nextStationFactName);
			set => SetProperty(ref _nextStationFactName, value);
		}

		[Ordinal(19)] 
		[RED("MetroStoppingFactName")] 
		public CName MetroStoppingFactName
		{
			get => GetProperty(ref _metroStoppingFactName);
			set => SetProperty(ref _metroStoppingFactName, value);
		}

		[Ordinal(20)] 
		[RED("root")] 
		public wCHandle<inkCompoundWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(21)] 
		[RED("questsSystem")] 
		public wCHandle<questQuestsSystem> QuestsSystem
		{
			get => GetProperty(ref _questsSystem);
			set => SetProperty(ref _questsSystem, value);
		}

		[Ordinal(22)] 
		[RED("StopListenerId")] 
		public CUInt32 StopListenerId
		{
			get => GetProperty(ref _stopListenerId);
			set => SetProperty(ref _stopListenerId, value);
		}

		[Ordinal(23)] 
		[RED("NextStationListenerId")] 
		public CUInt32 NextStationListenerId
		{
			get => GetProperty(ref _nextStationListenerId);
			set => SetProperty(ref _nextStationListenerId, value);
		}

		[Ordinal(24)] 
		[RED("gameTimeCallback")] 
		public CHandle<redCallbackObject> GameTimeCallback
		{
			get => GetProperty(ref _gameTimeCallback);
			set => SetProperty(ref _gameTimeCallback, value);
		}

		[Ordinal(25)] 
		[RED("ncartTextLogo")] 
		public inkImageWidgetReference NcartTextLogo
		{
			get => GetProperty(ref _ncartTextLogo);
			set => SetProperty(ref _ncartTextLogo, value);
		}

		[Ordinal(26)] 
		[RED("timeWidget")] 
		public inkTextWidgetReference TimeWidget
		{
			get => GetProperty(ref _timeWidget);
			set => SetProperty(ref _timeWidget, value);
		}

		[Ordinal(27)] 
		[RED("stationNameWidget")] 
		public inkTextWidgetReference StationNameWidget
		{
			get => GetProperty(ref _stationNameWidget);
			set => SetProperty(ref _stationNameWidget, value);
		}

		[Ordinal(28)] 
		[RED("stationStatusWidget")] 
		public inkTextWidgetReference StationStatusWidget
		{
			get => GetProperty(ref _stationStatusWidget);
			set => SetProperty(ref _stationStatusWidget, value);
		}

		[Ordinal(29)] 
		[RED("districtNameWidget")] 
		public inkTextWidgetReference DistrictNameWidget
		{
			get => GetProperty(ref _districtNameWidget);
			set => SetProperty(ref _districtNameWidget, value);
		}

		[Ordinal(30)] 
		[RED("stationDistrictBackgroundColor")] 
		public inkImageWidgetReference StationDistrictBackgroundColor
		{
			get => GetProperty(ref _stationDistrictBackgroundColor);
			set => SetProperty(ref _stationDistrictBackgroundColor, value);
		}

		[Ordinal(31)] 
		[RED("sun_moon_container")] 
		public inkWidgetReference Sun_moon_container
		{
			get => GetProperty(ref _sun_moon_container);
			set => SetProperty(ref _sun_moon_container, value);
		}

		[Ordinal(32)] 
		[RED("weather_sun_widget")] 
		public inkImageWidgetReference Weather_sun_widget
		{
			get => GetProperty(ref _weather_sun_widget);
			set => SetProperty(ref _weather_sun_widget, value);
		}

		[Ordinal(33)] 
		[RED("weather_moon_widget")] 
		public inkImageWidgetReference Weather_moon_widget
		{
			get => GetProperty(ref _weather_moon_widget);
			set => SetProperty(ref _weather_moon_widget, value);
		}

		[Ordinal(34)] 
		[RED("weather_cloud_a_widget")] 
		public inkImageWidgetReference Weather_cloud_a_widget
		{
			get => GetProperty(ref _weather_cloud_a_widget);
			set => SetProperty(ref _weather_cloud_a_widget, value);
		}

		[Ordinal(35)] 
		[RED("weather_cloud_b_widget")] 
		public inkImageWidgetReference Weather_cloud_b_widget
		{
			get => GetProperty(ref _weather_cloud_b_widget);
			set => SetProperty(ref _weather_cloud_b_widget, value);
		}

		[Ordinal(36)] 
		[RED("weather_rain_widget")] 
		public inkImageWidgetReference Weather_rain_widget
		{
			get => GetProperty(ref _weather_rain_widget);
			set => SetProperty(ref _weather_rain_widget, value);
		}

		[Ordinal(37)] 
		[RED("speed_display")] 
		public inkTextWidgetReference Speed_display
		{
			get => GetProperty(ref _speed_display);
			set => SetProperty(ref _speed_display, value);
		}

		[Ordinal(38)] 
		[RED("speed_display_deco_1")] 
		public inkImageWidgetReference Speed_display_deco_1
		{
			get => GetProperty(ref _speed_display_deco_1);
			set => SetProperty(ref _speed_display_deco_1, value);
		}

		[Ordinal(39)] 
		[RED("speed_display_deco_2")] 
		public inkImageWidgetReference Speed_display_deco_2
		{
			get => GetProperty(ref _speed_display_deco_2);
			set => SetProperty(ref _speed_display_deco_2, value);
		}

		[Ordinal(40)] 
		[RED("speed_display_deco_3")] 
		public inkImageWidgetReference Speed_display_deco_3
		{
			get => GetProperty(ref _speed_display_deco_3);
			set => SetProperty(ref _speed_display_deco_3, value);
		}

		[Ordinal(41)] 
		[RED("speed_display_deco_4")] 
		public inkImageWidgetReference Speed_display_deco_4
		{
			get => GetProperty(ref _speed_display_deco_4);
			set => SetProperty(ref _speed_display_deco_4, value);
		}

		[Ordinal(42)] 
		[RED("cachedActiveLine")] 
		public CInt32 CachedActiveLine
		{
			get => GetProperty(ref _cachedActiveLine);
			set => SetProperty(ref _cachedActiveLine, value);
		}

		[Ordinal(43)] 
		[RED("cachedNextStation")] 
		public CInt32 CachedNextStation
		{
			get => GetProperty(ref _cachedNextStation);
			set => SetProperty(ref _cachedNextStation, value);
		}

		[Ordinal(44)] 
		[RED("cachedDistrict")] 
		public CEnum<ENcartDistricts> CachedDistrict
		{
			get => GetProperty(ref _cachedDistrict);
			set => SetProperty(ref _cachedDistrict, value);
		}

		[Ordinal(45)] 
		[RED("updateDistrictName")] 
		public CBool UpdateDistrictName
		{
			get => GetProperty(ref _updateDistrictName);
			set => SetProperty(ref _updateDistrictName, value);
		}

		[Ordinal(46)] 
		[RED("ownerObject")] 
		public wCHandle<vehicleBaseObject> OwnerObject
		{
			get => GetProperty(ref _ownerObject);
			set => SetProperty(ref _ownerObject, value);
		}

		[Ordinal(47)] 
		[RED("vehicleBlackboard")] 
		public wCHandle<gameIBlackboard> VehicleBlackboard
		{
			get => GetProperty(ref _vehicleBlackboard);
			set => SetProperty(ref _vehicleBlackboard, value);
		}

		[Ordinal(48)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(49)] 
		[RED("speedListner")] 
		public CHandle<redCallbackObject> SpeedListner
		{
			get => GetProperty(ref _speedListner);
			set => SetProperty(ref _speedListner, value);
		}

		[Ordinal(50)] 
		[RED("speedLastValue")] 
		public CFloat SpeedLastValue
		{
			get => GetProperty(ref _speedLastValue);
			set => SetProperty(ref _speedLastValue, value);
		}

		public NcartDoorScreenInkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
