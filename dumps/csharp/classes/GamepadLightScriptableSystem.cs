using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GamepadLightScriptableSystem : gameScriptableSystem
	{
		private Vector3 _controllerCurrentColor;
		private Vector3 _controllerStartColor;
		private Vector3 _controllerTargetColor;
		private CFloat _currentProgress;
		private CBool _useExponentialCurve;
		private CFloat _prevTime;
		private CEnum<ELightState> _currentState;
		private CEnum<ELightState> _prevState;
		private CFloat _timeLimit;
		private gameDelayID _currrentId;

		[Ordinal(0)] 
		[RED("controllerCurrentColor")] 
		public Vector3 ControllerCurrentColor
		{
			get => GetProperty(ref _controllerCurrentColor);
			set => SetProperty(ref _controllerCurrentColor, value);
		}

		[Ordinal(1)] 
		[RED("controllerStartColor")] 
		public Vector3 ControllerStartColor
		{
			get => GetProperty(ref _controllerStartColor);
			set => SetProperty(ref _controllerStartColor, value);
		}

		[Ordinal(2)] 
		[RED("controllerTargetColor")] 
		public Vector3 ControllerTargetColor
		{
			get => GetProperty(ref _controllerTargetColor);
			set => SetProperty(ref _controllerTargetColor, value);
		}

		[Ordinal(3)] 
		[RED("currentProgress")] 
		public CFloat CurrentProgress
		{
			get => GetProperty(ref _currentProgress);
			set => SetProperty(ref _currentProgress, value);
		}

		[Ordinal(4)] 
		[RED("useExponentialCurve")] 
		public CBool UseExponentialCurve
		{
			get => GetProperty(ref _useExponentialCurve);
			set => SetProperty(ref _useExponentialCurve, value);
		}

		[Ordinal(5)] 
		[RED("prevTime")] 
		public CFloat PrevTime
		{
			get => GetProperty(ref _prevTime);
			set => SetProperty(ref _prevTime, value);
		}

		[Ordinal(6)] 
		[RED("currentState")] 
		public CEnum<ELightState> CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		[Ordinal(7)] 
		[RED("prevState")] 
		public CEnum<ELightState> PrevState
		{
			get => GetProperty(ref _prevState);
			set => SetProperty(ref _prevState, value);
		}

		[Ordinal(8)] 
		[RED("timeLimit")] 
		public CFloat TimeLimit
		{
			get => GetProperty(ref _timeLimit);
			set => SetProperty(ref _timeLimit, value);
		}

		[Ordinal(9)] 
		[RED("currrentId")] 
		public gameDelayID CurrrentId
		{
			get => GetProperty(ref _currrentId);
			set => SetProperty(ref _currrentId, value);
		}

		public GamepadLightScriptableSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
