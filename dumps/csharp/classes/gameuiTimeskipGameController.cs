using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTimeskipGameController : gameuiWidgetGameController
	{
		private inkTextWidgetReference _currentTimeLabel;
		private inkTextWidgetReference _tragetTimeLabel;
		private inkTextWidgetReference _diffTimeLabel;
		private inkWidgetReference _rootContainerRef;
		private inkWidgetReference _currentTimePointerRef;
		private inkWidgetReference _targetTimePointerRef;
		private inkWidgetReference _timeBarRef;
		private inkWidgetReference _circleGradientRef;
		private inkWidgetReference _startCircleGradientRef;
		private inkWidgetReference _mouseHitTestRef;
		private inkWidgetReference _dayIconRef;
		private inkWidgetReference _nightIconRef;
		private inkWidgetReference _morningIconRef;
		private inkWidgetReference _eveningIconRef;
		private inkImageWidgetReference _weatherIcon;
		private CName _intoAnimation;
		private CName _outroCancelAnimation;
		private CName _outroFinishedAnimation;
		private CName _progressAnimation;
		private CName _finishingAnimation;
		private CName _loopAnimationMarkerFrom;
		private CName _loopAnimationMarkerTo;
		private CName _mouseHoverOverAnimation;
		private CName _mouseHoverOutAnimation;
		private CFloat _outroAnimDuration;
		private wCHandle<gameObject> _player;
		private CHandle<TimeSkipPopupData> _data;
		private ScriptGameInstance _gameInstance;
		private CHandle<gameTimeSystem> _timeSystem;
		private CHandle<textTextParameterSet> _currentTimeTextParams;
		private CHandle<textTextParameterSet> _targetTimeTextParams;
		private CHandle<textTextParameterSet> _diffTimeTextParams;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _progressAnimProxy;
		private CHandle<inkanimProxy> _hoverAnimProxy;
		private GameTime _currentTime;
		private CInt32 _hoursToSkip;
		private CFloat _currentTimeAngle;
		private CFloat _targetTimeAngle;
		private Vector2 _axisInputCache;
		private CBool _inputEnabled;
		private CFloat _radius;
		private CFloat _axisInputThreshold;
		private CFloat _animationDurationMin;
		private CFloat _animationDurationMax;
		private CFloat _diff;
		private CBool _timeSkipped;
		private CBool _mouseInputEnabled;
		private CHandle<TimeSkipFinishEvent> _scenarioEvt;
		private CBool _hoveredOver;

		[Ordinal(2)] 
		[RED("currentTimeLabel")] 
		public inkTextWidgetReference CurrentTimeLabel
		{
			get => GetProperty(ref _currentTimeLabel);
			set => SetProperty(ref _currentTimeLabel, value);
		}

		[Ordinal(3)] 
		[RED("tragetTimeLabel")] 
		public inkTextWidgetReference TragetTimeLabel
		{
			get => GetProperty(ref _tragetTimeLabel);
			set => SetProperty(ref _tragetTimeLabel, value);
		}

		[Ordinal(4)] 
		[RED("diffTimeLabel")] 
		public inkTextWidgetReference DiffTimeLabel
		{
			get => GetProperty(ref _diffTimeLabel);
			set => SetProperty(ref _diffTimeLabel, value);
		}

		[Ordinal(5)] 
		[RED("rootContainerRef")] 
		public inkWidgetReference RootContainerRef
		{
			get => GetProperty(ref _rootContainerRef);
			set => SetProperty(ref _rootContainerRef, value);
		}

		[Ordinal(6)] 
		[RED("currentTimePointerRef")] 
		public inkWidgetReference CurrentTimePointerRef
		{
			get => GetProperty(ref _currentTimePointerRef);
			set => SetProperty(ref _currentTimePointerRef, value);
		}

		[Ordinal(7)] 
		[RED("targetTimePointerRef")] 
		public inkWidgetReference TargetTimePointerRef
		{
			get => GetProperty(ref _targetTimePointerRef);
			set => SetProperty(ref _targetTimePointerRef, value);
		}

		[Ordinal(8)] 
		[RED("timeBarRef")] 
		public inkWidgetReference TimeBarRef
		{
			get => GetProperty(ref _timeBarRef);
			set => SetProperty(ref _timeBarRef, value);
		}

		[Ordinal(9)] 
		[RED("circleGradientRef")] 
		public inkWidgetReference CircleGradientRef
		{
			get => GetProperty(ref _circleGradientRef);
			set => SetProperty(ref _circleGradientRef, value);
		}

		[Ordinal(10)] 
		[RED("startCircleGradientRef")] 
		public inkWidgetReference StartCircleGradientRef
		{
			get => GetProperty(ref _startCircleGradientRef);
			set => SetProperty(ref _startCircleGradientRef, value);
		}

		[Ordinal(11)] 
		[RED("mouseHitTestRef")] 
		public inkWidgetReference MouseHitTestRef
		{
			get => GetProperty(ref _mouseHitTestRef);
			set => SetProperty(ref _mouseHitTestRef, value);
		}

		[Ordinal(12)] 
		[RED("dayIconRef")] 
		public inkWidgetReference DayIconRef
		{
			get => GetProperty(ref _dayIconRef);
			set => SetProperty(ref _dayIconRef, value);
		}

		[Ordinal(13)] 
		[RED("nightIconRef")] 
		public inkWidgetReference NightIconRef
		{
			get => GetProperty(ref _nightIconRef);
			set => SetProperty(ref _nightIconRef, value);
		}

		[Ordinal(14)] 
		[RED("morningIconRef")] 
		public inkWidgetReference MorningIconRef
		{
			get => GetProperty(ref _morningIconRef);
			set => SetProperty(ref _morningIconRef, value);
		}

		[Ordinal(15)] 
		[RED("eveningIconRef")] 
		public inkWidgetReference EveningIconRef
		{
			get => GetProperty(ref _eveningIconRef);
			set => SetProperty(ref _eveningIconRef, value);
		}

		[Ordinal(16)] 
		[RED("weatherIcon")] 
		public inkImageWidgetReference WeatherIcon
		{
			get => GetProperty(ref _weatherIcon);
			set => SetProperty(ref _weatherIcon, value);
		}

		[Ordinal(17)] 
		[RED("intoAnimation")] 
		public CName IntoAnimation
		{
			get => GetProperty(ref _intoAnimation);
			set => SetProperty(ref _intoAnimation, value);
		}

		[Ordinal(18)] 
		[RED("outroCancelAnimation")] 
		public CName OutroCancelAnimation
		{
			get => GetProperty(ref _outroCancelAnimation);
			set => SetProperty(ref _outroCancelAnimation, value);
		}

		[Ordinal(19)] 
		[RED("outroFinishedAnimation")] 
		public CName OutroFinishedAnimation
		{
			get => GetProperty(ref _outroFinishedAnimation);
			set => SetProperty(ref _outroFinishedAnimation, value);
		}

		[Ordinal(20)] 
		[RED("progressAnimation")] 
		public CName ProgressAnimation
		{
			get => GetProperty(ref _progressAnimation);
			set => SetProperty(ref _progressAnimation, value);
		}

		[Ordinal(21)] 
		[RED("finishingAnimation")] 
		public CName FinishingAnimation
		{
			get => GetProperty(ref _finishingAnimation);
			set => SetProperty(ref _finishingAnimation, value);
		}

		[Ordinal(22)] 
		[RED("loopAnimationMarkerFrom")] 
		public CName LoopAnimationMarkerFrom
		{
			get => GetProperty(ref _loopAnimationMarkerFrom);
			set => SetProperty(ref _loopAnimationMarkerFrom, value);
		}

		[Ordinal(23)] 
		[RED("loopAnimationMarkerTo")] 
		public CName LoopAnimationMarkerTo
		{
			get => GetProperty(ref _loopAnimationMarkerTo);
			set => SetProperty(ref _loopAnimationMarkerTo, value);
		}

		[Ordinal(24)] 
		[RED("mouseHoverOverAnimation")] 
		public CName MouseHoverOverAnimation
		{
			get => GetProperty(ref _mouseHoverOverAnimation);
			set => SetProperty(ref _mouseHoverOverAnimation, value);
		}

		[Ordinal(25)] 
		[RED("mouseHoverOutAnimation")] 
		public CName MouseHoverOutAnimation
		{
			get => GetProperty(ref _mouseHoverOutAnimation);
			set => SetProperty(ref _mouseHoverOutAnimation, value);
		}

		[Ordinal(26)] 
		[RED("outroAnimDuration")] 
		public CFloat OutroAnimDuration
		{
			get => GetProperty(ref _outroAnimDuration);
			set => SetProperty(ref _outroAnimDuration, value);
		}

		[Ordinal(27)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(28)] 
		[RED("data")] 
		public CHandle<TimeSkipPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(29)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(30)] 
		[RED("timeSystem")] 
		public CHandle<gameTimeSystem> TimeSystem
		{
			get => GetProperty(ref _timeSystem);
			set => SetProperty(ref _timeSystem, value);
		}

		[Ordinal(31)] 
		[RED("currentTimeTextParams")] 
		public CHandle<textTextParameterSet> CurrentTimeTextParams
		{
			get => GetProperty(ref _currentTimeTextParams);
			set => SetProperty(ref _currentTimeTextParams, value);
		}

		[Ordinal(32)] 
		[RED("targetTimeTextParams")] 
		public CHandle<textTextParameterSet> TargetTimeTextParams
		{
			get => GetProperty(ref _targetTimeTextParams);
			set => SetProperty(ref _targetTimeTextParams, value);
		}

		[Ordinal(33)] 
		[RED("diffTimeTextParams")] 
		public CHandle<textTextParameterSet> DiffTimeTextParams
		{
			get => GetProperty(ref _diffTimeTextParams);
			set => SetProperty(ref _diffTimeTextParams, value);
		}

		[Ordinal(34)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(35)] 
		[RED("progressAnimProxy")] 
		public CHandle<inkanimProxy> ProgressAnimProxy
		{
			get => GetProperty(ref _progressAnimProxy);
			set => SetProperty(ref _progressAnimProxy, value);
		}

		[Ordinal(36)] 
		[RED("hoverAnimProxy")] 
		public CHandle<inkanimProxy> HoverAnimProxy
		{
			get => GetProperty(ref _hoverAnimProxy);
			set => SetProperty(ref _hoverAnimProxy, value);
		}

		[Ordinal(37)] 
		[RED("currentTime")] 
		public GameTime CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(38)] 
		[RED("hoursToSkip")] 
		public CInt32 HoursToSkip
		{
			get => GetProperty(ref _hoursToSkip);
			set => SetProperty(ref _hoursToSkip, value);
		}

		[Ordinal(39)] 
		[RED("currentTimeAngle")] 
		public CFloat CurrentTimeAngle
		{
			get => GetProperty(ref _currentTimeAngle);
			set => SetProperty(ref _currentTimeAngle, value);
		}

		[Ordinal(40)] 
		[RED("targetTimeAngle")] 
		public CFloat TargetTimeAngle
		{
			get => GetProperty(ref _targetTimeAngle);
			set => SetProperty(ref _targetTimeAngle, value);
		}

		[Ordinal(41)] 
		[RED("axisInputCache")] 
		public Vector2 AxisInputCache
		{
			get => GetProperty(ref _axisInputCache);
			set => SetProperty(ref _axisInputCache, value);
		}

		[Ordinal(42)] 
		[RED("inputEnabled")] 
		public CBool InputEnabled
		{
			get => GetProperty(ref _inputEnabled);
			set => SetProperty(ref _inputEnabled, value);
		}

		[Ordinal(43)] 
		[RED("radius")] 
		public CFloat Radius
		{
			get => GetProperty(ref _radius);
			set => SetProperty(ref _radius, value);
		}

		[Ordinal(44)] 
		[RED("axisInputThreshold")] 
		public CFloat AxisInputThreshold
		{
			get => GetProperty(ref _axisInputThreshold);
			set => SetProperty(ref _axisInputThreshold, value);
		}

		[Ordinal(45)] 
		[RED("animationDurationMin")] 
		public CFloat AnimationDurationMin
		{
			get => GetProperty(ref _animationDurationMin);
			set => SetProperty(ref _animationDurationMin, value);
		}

		[Ordinal(46)] 
		[RED("animationDurationMax")] 
		public CFloat AnimationDurationMax
		{
			get => GetProperty(ref _animationDurationMax);
			set => SetProperty(ref _animationDurationMax, value);
		}

		[Ordinal(47)] 
		[RED("diff")] 
		public CFloat Diff
		{
			get => GetProperty(ref _diff);
			set => SetProperty(ref _diff, value);
		}

		[Ordinal(48)] 
		[RED("timeSkipped")] 
		public CBool TimeSkipped
		{
			get => GetProperty(ref _timeSkipped);
			set => SetProperty(ref _timeSkipped, value);
		}

		[Ordinal(49)] 
		[RED("mouseInputEnabled")] 
		public CBool MouseInputEnabled
		{
			get => GetProperty(ref _mouseInputEnabled);
			set => SetProperty(ref _mouseInputEnabled, value);
		}

		[Ordinal(50)] 
		[RED("scenarioEvt")] 
		public CHandle<TimeSkipFinishEvent> ScenarioEvt
		{
			get => GetProperty(ref _scenarioEvt);
			set => SetProperty(ref _scenarioEvt, value);
		}

		[Ordinal(51)] 
		[RED("hoveredOver")] 
		public CBool HoveredOver
		{
			get => GetProperty(ref _hoveredOver);
			set => SetProperty(ref _hoveredOver, value);
		}

		public gameuiTimeskipGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
