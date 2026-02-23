using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hudTurretController : gameuiHUDGameController
	{
		private inkTextWidgetReference _healthStatus;
		private inkTextWidgetReference _messageText;
		private inkTextWidgetReference _yawCounter;
		private inkTextWidgetReference _pitchCounter;
		private inkCanvasWidgetReference _pitch;
		private inkCanvasWidgetReference _yaw;
		private inkCanvasWidgetReference _turretIcon;
		private CFloat _pitch_min;
		private CFloat _pitch_max;
		private CFloat _yaw_min;
		private CFloat _yaw_max;
		private inkTextWidgetReference _zoomNumber;
		private inkTextWidgetReference _distanceNumber;
		private inkImageWidgetReference _distanceImageRuler;
		private inkImageWidgetReference _zoomMoveBracketL;
		private inkImageWidgetReference _zoomMoveBracketR;
		private wCHandle<gameIBlackboard> _bbPlayerStats;
		private CHandle<redCallbackObject> _bbPlayerEventId;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private wCHandle<gameObject> _playerObject;
		private wCHandle<gameObject> _playerPuppet;
		private wCHandle<gameObject> _controlledObjectRef;
		private ScriptGameInstance _gameInstance;
		private CHandle<inkanimProxy> _animationProxy;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private CHandle<redCallbackObject> _pSM_BBID;
		private CHandle<inkanimProxy> _zoomDownAnim;
		private CHandle<inkanimProxy> _zoomUpAnim;
		private CFloat _argZoomBuffered;
		private CHandle<OverclockHudListener> _overclockListener;
		private CBool _isOverclockActive;

		[Ordinal(9)] 
		[RED("healthStatus")] 
		public inkTextWidgetReference HealthStatus
		{
			get => GetProperty(ref _healthStatus);
			set => SetProperty(ref _healthStatus, value);
		}

		[Ordinal(10)] 
		[RED("MessageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		[Ordinal(11)] 
		[RED("yawCounter")] 
		public inkTextWidgetReference YawCounter
		{
			get => GetProperty(ref _yawCounter);
			set => SetProperty(ref _yawCounter, value);
		}

		[Ordinal(12)] 
		[RED("pitchCounter")] 
		public inkTextWidgetReference PitchCounter
		{
			get => GetProperty(ref _pitchCounter);
			set => SetProperty(ref _pitchCounter, value);
		}

		[Ordinal(13)] 
		[RED("pitch")] 
		public inkCanvasWidgetReference Pitch
		{
			get => GetProperty(ref _pitch);
			set => SetProperty(ref _pitch, value);
		}

		[Ordinal(14)] 
		[RED("yaw")] 
		public inkCanvasWidgetReference Yaw
		{
			get => GetProperty(ref _yaw);
			set => SetProperty(ref _yaw, value);
		}

		[Ordinal(15)] 
		[RED("turretIcon")] 
		public inkCanvasWidgetReference TurretIcon
		{
			get => GetProperty(ref _turretIcon);
			set => SetProperty(ref _turretIcon, value);
		}

		[Ordinal(16)] 
		[RED("pitch_min")] 
		public CFloat Pitch_min
		{
			get => GetProperty(ref _pitch_min);
			set => SetProperty(ref _pitch_min, value);
		}

		[Ordinal(17)] 
		[RED("pitch_max")] 
		public CFloat Pitch_max
		{
			get => GetProperty(ref _pitch_max);
			set => SetProperty(ref _pitch_max, value);
		}

		[Ordinal(18)] 
		[RED("yaw_min")] 
		public CFloat Yaw_min
		{
			get => GetProperty(ref _yaw_min);
			set => SetProperty(ref _yaw_min, value);
		}

		[Ordinal(19)] 
		[RED("yaw_max")] 
		public CFloat Yaw_max
		{
			get => GetProperty(ref _yaw_max);
			set => SetProperty(ref _yaw_max, value);
		}

		[Ordinal(20)] 
		[RED("ZoomNumber")] 
		public inkTextWidgetReference ZoomNumber
		{
			get => GetProperty(ref _zoomNumber);
			set => SetProperty(ref _zoomNumber, value);
		}

		[Ordinal(21)] 
		[RED("DistanceNumber")] 
		public inkTextWidgetReference DistanceNumber
		{
			get => GetProperty(ref _distanceNumber);
			set => SetProperty(ref _distanceNumber, value);
		}

		[Ordinal(22)] 
		[RED("DistanceImageRuler")] 
		public inkImageWidgetReference DistanceImageRuler
		{
			get => GetProperty(ref _distanceImageRuler);
			set => SetProperty(ref _distanceImageRuler, value);
		}

		[Ordinal(23)] 
		[RED("ZoomMoveBracketL")] 
		public inkImageWidgetReference ZoomMoveBracketL
		{
			get => GetProperty(ref _zoomMoveBracketL);
			set => SetProperty(ref _zoomMoveBracketL, value);
		}

		[Ordinal(24)] 
		[RED("ZoomMoveBracketR")] 
		public inkImageWidgetReference ZoomMoveBracketR
		{
			get => GetProperty(ref _zoomMoveBracketR);
			set => SetProperty(ref _zoomMoveBracketR, value);
		}

		[Ordinal(25)] 
		[RED("bbPlayerStats")] 
		public wCHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(26)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetProperty(ref _bbPlayerEventId);
			set => SetProperty(ref _bbPlayerEventId, value);
		}

		[Ordinal(27)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(28)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetProperty(ref _previousHealth);
			set => SetProperty(ref _previousHealth, value);
		}

		[Ordinal(29)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(30)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(31)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(32)] 
		[RED("controlledObjectRef")] 
		public wCHandle<gameObject> ControlledObjectRef
		{
			get => GetProperty(ref _controlledObjectRef);
			set => SetProperty(ref _controlledObjectRef, value);
		}

		[Ordinal(33)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(34)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(35)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(36)] 
		[RED("PSM_BBID")] 
		public CHandle<redCallbackObject> PSM_BBID
		{
			get => GetProperty(ref _pSM_BBID);
			set => SetProperty(ref _pSM_BBID, value);
		}

		[Ordinal(37)] 
		[RED("zoomDownAnim")] 
		public CHandle<inkanimProxy> ZoomDownAnim
		{
			get => GetProperty(ref _zoomDownAnim);
			set => SetProperty(ref _zoomDownAnim, value);
		}

		[Ordinal(38)] 
		[RED("zoomUpAnim")] 
		public CHandle<inkanimProxy> ZoomUpAnim
		{
			get => GetProperty(ref _zoomUpAnim);
			set => SetProperty(ref _zoomUpAnim, value);
		}

		[Ordinal(39)] 
		[RED("argZoomBuffered")] 
		public CFloat ArgZoomBuffered
		{
			get => GetProperty(ref _argZoomBuffered);
			set => SetProperty(ref _argZoomBuffered, value);
		}

		[Ordinal(40)] 
		[RED("overclockListener")] 
		public CHandle<OverclockHudListener> OverclockListener
		{
			get => GetProperty(ref _overclockListener);
			set => SetProperty(ref _overclockListener, value);
		}

		[Ordinal(41)] 
		[RED("isOverclockActive")] 
		public CBool IsOverclockActive
		{
			get => GetProperty(ref _isOverclockActive);
			set => SetProperty(ref _isOverclockActive, value);
		}

		public hudTurretController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
