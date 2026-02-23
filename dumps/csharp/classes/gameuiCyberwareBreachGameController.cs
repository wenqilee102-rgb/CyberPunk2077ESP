using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCyberwareBreachGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _strokeHealthDepleation;
		private Vector2 _adjustedScreenPosition;
		private CFloat _maxHealth;
		private CFloat _currentHealth;
		private CFloat _lastHealth;
		private Vector2 _currentSway;
		private inkWidgetReference _breachCanvasWRef;
		private inkBorderWidgetReference _strokeFgRef;
		private inkBorderWidgetReference _strokeBgRef;
		private inkBorderWidgetReference _waveStrokeRef;
		private inkWidgetReference _fillRef;
		private inkCompoundWidgetReference _textScaleWidgetRef;
		private inkTextWidgetReference _xTextRef;
		private inkTextWidgetReference _yTextRef;
		private inkTextWidgetReference _errorTextRef;
		private CFloat _strokeThicknessPercent;
		private CFloat _minThickness;
		private CFloat _maxThickness;
		private CFloat _minTextScale;
		private CFloat _maxTextScale;
		private CFloat _maxRadius;
		private CFloat _minRadiusForFluff;
		private CBool _previousAlmostTimeout;
		private CHandle<redCallbackObject> _cwBreachCallbackHandle;
		private CHandle<redCallbackObject> _weaponSwayCallbackHandle;
		private CHandle<inkanimProxy> _introAnimationProxy;
		private CHandle<inkanimProxy> _showAnimationProxy;
		private CHandle<inkanimProxy> _timeoutAnimationProxy;

		[Ordinal(2)] 
		[RED("strokeHealthDepleation")] 
		public inkWidgetReference StrokeHealthDepleation
		{
			get => GetProperty(ref _strokeHealthDepleation);
			set => SetProperty(ref _strokeHealthDepleation, value);
		}

		[Ordinal(3)] 
		[RED("adjustedScreenPosition")] 
		public Vector2 AdjustedScreenPosition
		{
			get => GetProperty(ref _adjustedScreenPosition);
			set => SetProperty(ref _adjustedScreenPosition, value);
		}

		[Ordinal(4)] 
		[RED("maxHealth")] 
		public CFloat MaxHealth
		{
			get => GetProperty(ref _maxHealth);
			set => SetProperty(ref _maxHealth, value);
		}

		[Ordinal(5)] 
		[RED("currentHealth")] 
		public CFloat CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(6)] 
		[RED("lastHealth")] 
		public CFloat LastHealth
		{
			get => GetProperty(ref _lastHealth);
			set => SetProperty(ref _lastHealth, value);
		}

		[Ordinal(7)] 
		[RED("currentSway")] 
		public Vector2 CurrentSway
		{
			get => GetProperty(ref _currentSway);
			set => SetProperty(ref _currentSway, value);
		}

		[Ordinal(8)] 
		[RED("breachCanvasWRef")] 
		public inkWidgetReference BreachCanvasWRef
		{
			get => GetProperty(ref _breachCanvasWRef);
			set => SetProperty(ref _breachCanvasWRef, value);
		}

		[Ordinal(9)] 
		[RED("strokeFgRef")] 
		public inkBorderWidgetReference StrokeFgRef
		{
			get => GetProperty(ref _strokeFgRef);
			set => SetProperty(ref _strokeFgRef, value);
		}

		[Ordinal(10)] 
		[RED("strokeBgRef")] 
		public inkBorderWidgetReference StrokeBgRef
		{
			get => GetProperty(ref _strokeBgRef);
			set => SetProperty(ref _strokeBgRef, value);
		}

		[Ordinal(11)] 
		[RED("waveStrokeRef")] 
		public inkBorderWidgetReference WaveStrokeRef
		{
			get => GetProperty(ref _waveStrokeRef);
			set => SetProperty(ref _waveStrokeRef, value);
		}

		[Ordinal(12)] 
		[RED("fillRef")] 
		public inkWidgetReference FillRef
		{
			get => GetProperty(ref _fillRef);
			set => SetProperty(ref _fillRef, value);
		}

		[Ordinal(13)] 
		[RED("textScaleWidgetRef")] 
		public inkCompoundWidgetReference TextScaleWidgetRef
		{
			get => GetProperty(ref _textScaleWidgetRef);
			set => SetProperty(ref _textScaleWidgetRef, value);
		}

		[Ordinal(14)] 
		[RED("xTextRef")] 
		public inkTextWidgetReference XTextRef
		{
			get => GetProperty(ref _xTextRef);
			set => SetProperty(ref _xTextRef, value);
		}

		[Ordinal(15)] 
		[RED("yTextRef")] 
		public inkTextWidgetReference YTextRef
		{
			get => GetProperty(ref _yTextRef);
			set => SetProperty(ref _yTextRef, value);
		}

		[Ordinal(16)] 
		[RED("errorTextRef")] 
		public inkTextWidgetReference ErrorTextRef
		{
			get => GetProperty(ref _errorTextRef);
			set => SetProperty(ref _errorTextRef, value);
		}

		[Ordinal(17)] 
		[RED("strokeThicknessPercent")] 
		public CFloat StrokeThicknessPercent
		{
			get => GetProperty(ref _strokeThicknessPercent);
			set => SetProperty(ref _strokeThicknessPercent, value);
		}

		[Ordinal(18)] 
		[RED("minThickness")] 
		public CFloat MinThickness
		{
			get => GetProperty(ref _minThickness);
			set => SetProperty(ref _minThickness, value);
		}

		[Ordinal(19)] 
		[RED("maxThickness")] 
		public CFloat MaxThickness
		{
			get => GetProperty(ref _maxThickness);
			set => SetProperty(ref _maxThickness, value);
		}

		[Ordinal(20)] 
		[RED("minTextScale")] 
		public CFloat MinTextScale
		{
			get => GetProperty(ref _minTextScale);
			set => SetProperty(ref _minTextScale, value);
		}

		[Ordinal(21)] 
		[RED("maxTextScale")] 
		public CFloat MaxTextScale
		{
			get => GetProperty(ref _maxTextScale);
			set => SetProperty(ref _maxTextScale, value);
		}

		[Ordinal(22)] 
		[RED("maxRadius")] 
		public CFloat MaxRadius
		{
			get => GetProperty(ref _maxRadius);
			set => SetProperty(ref _maxRadius, value);
		}

		[Ordinal(23)] 
		[RED("minRadiusForFluff")] 
		public CFloat MinRadiusForFluff
		{
			get => GetProperty(ref _minRadiusForFluff);
			set => SetProperty(ref _minRadiusForFluff, value);
		}

		[Ordinal(24)] 
		[RED("previousAlmostTimeout")] 
		public CBool PreviousAlmostTimeout
		{
			get => GetProperty(ref _previousAlmostTimeout);
			set => SetProperty(ref _previousAlmostTimeout, value);
		}

		[Ordinal(25)] 
		[RED("cwBreachCallbackHandle")] 
		public CHandle<redCallbackObject> CwBreachCallbackHandle
		{
			get => GetProperty(ref _cwBreachCallbackHandle);
			set => SetProperty(ref _cwBreachCallbackHandle, value);
		}

		[Ordinal(26)] 
		[RED("weaponSwayCallbackHandle")] 
		public CHandle<redCallbackObject> WeaponSwayCallbackHandle
		{
			get => GetProperty(ref _weaponSwayCallbackHandle);
			set => SetProperty(ref _weaponSwayCallbackHandle, value);
		}

		[Ordinal(27)] 
		[RED("introAnimationProxy")] 
		public CHandle<inkanimProxy> IntroAnimationProxy
		{
			get => GetProperty(ref _introAnimationProxy);
			set => SetProperty(ref _introAnimationProxy, value);
		}

		[Ordinal(28)] 
		[RED("showAnimationProxy")] 
		public CHandle<inkanimProxy> ShowAnimationProxy
		{
			get => GetProperty(ref _showAnimationProxy);
			set => SetProperty(ref _showAnimationProxy, value);
		}

		[Ordinal(29)] 
		[RED("timeoutAnimationProxy")] 
		public CHandle<inkanimProxy> TimeoutAnimationProxy
		{
			get => GetProperty(ref _timeoutAnimationProxy);
			set => SetProperty(ref _timeoutAnimationProxy, value);
		}

		public gameuiCyberwareBreachGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
