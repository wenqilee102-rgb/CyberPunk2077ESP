using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudSightseeingBinocularsController : CustomAnimationsHudGameController
	{
		private CFloat _pitch_min;
		private CFloat _pitch_max;
		private CFloat _yaw_min;
		private CFloat _yaw_max;
		private CFloat _tele_min;
		private CFloat _tele_max;
		private CFloat _tele_scale;
		private CFloat _max_zoom_level;
		private inkCanvasWidgetReference _background;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private wCHandle<gameIBlackboard> _tcsBlackboard;
		private CHandle<redCallbackObject> _pSM_BBID;
		private CHandle<redCallbackObject> _tcs_BBID;
		private CHandle<redCallbackObject> _deviceChain_BBID;
		private CFloat _currentZoom;
		private wCHandle<gameObject> _controlledObjectRef;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private wCHandle<gameObject> _ownerObject;
		private CInt32 _maxZoomLevel;

		[Ordinal(19)] 
		[RED("pitch_min")] 
		public CFloat Pitch_min
		{
			get => GetProperty(ref _pitch_min);
			set => SetProperty(ref _pitch_min, value);
		}

		[Ordinal(20)] 
		[RED("pitch_max")] 
		public CFloat Pitch_max
		{
			get => GetProperty(ref _pitch_max);
			set => SetProperty(ref _pitch_max, value);
		}

		[Ordinal(21)] 
		[RED("yaw_min")] 
		public CFloat Yaw_min
		{
			get => GetProperty(ref _yaw_min);
			set => SetProperty(ref _yaw_min, value);
		}

		[Ordinal(22)] 
		[RED("yaw_max")] 
		public CFloat Yaw_max
		{
			get => GetProperty(ref _yaw_max);
			set => SetProperty(ref _yaw_max, value);
		}

		[Ordinal(23)] 
		[RED("tele_min")] 
		public CFloat Tele_min
		{
			get => GetProperty(ref _tele_min);
			set => SetProperty(ref _tele_min, value);
		}

		[Ordinal(24)] 
		[RED("tele_max")] 
		public CFloat Tele_max
		{
			get => GetProperty(ref _tele_max);
			set => SetProperty(ref _tele_max, value);
		}

		[Ordinal(25)] 
		[RED("tele_scale")] 
		public CFloat Tele_scale
		{
			get => GetProperty(ref _tele_scale);
			set => SetProperty(ref _tele_scale, value);
		}

		[Ordinal(26)] 
		[RED("max_zoom_level")] 
		public CFloat Max_zoom_level
		{
			get => GetProperty(ref _max_zoom_level);
			set => SetProperty(ref _max_zoom_level, value);
		}

		[Ordinal(27)] 
		[RED("background")] 
		public inkCanvasWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(28)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(29)] 
		[RED("tcsBlackboard")] 
		public wCHandle<gameIBlackboard> TcsBlackboard
		{
			get => GetProperty(ref _tcsBlackboard);
			set => SetProperty(ref _tcsBlackboard, value);
		}

		[Ordinal(30)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(31)] 
		[RED("tcs_BBID")] 
		public CHandle<redCallbackObject> Tcs_BBID
		{
			get => GetProperty(ref _tcs_BBID);
			set => SetProperty(ref _tcs_BBID, value);
		}

		[Ordinal(32)] 
		[RED("deviceChain_BBID")] 
		public CHandle<redCallbackObject> DeviceChain_BBID
		{
			get => GetProperty(ref _deviceChain_BBID);
			set => SetProperty(ref _deviceChain_BBID, value);
		}

		[Ordinal(33)] 
		[RED("currentZoom")] 
		public CFloat CurrentZoom
		{
			get => GetProperty(ref _currentZoom);
			set => SetProperty(ref _currentZoom, value);
		}

		[Ordinal(34)] 
		[RED("controlledObjectRef")] 
		public wCHandle<gameObject> ControlledObjectRef
		{
			get => GetProperty(ref _controlledObjectRef);
			set => SetProperty(ref _controlledObjectRef, value);
		}

		[Ordinal(35)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(36)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(37)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(38)] 
		[RED("ownerObject")] 
		public wCHandle<gameObject> OwnerObject
		{
			get => GetProperty(ref _ownerObject);
			set => SetProperty(ref _ownerObject, value);
		}

		[Ordinal(39)] 
		[RED("maxZoomLevel")] 
		public CInt32 MaxZoomLevel
		{
			get => GetProperty(ref _maxZoomLevel);
			set => SetProperty(ref _maxZoomLevel, value);
		}

		public hudSightseeingBinocularsController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
