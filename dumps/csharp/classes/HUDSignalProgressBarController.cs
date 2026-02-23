using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HUDSignalProgressBarController : gameuiHUDGameController
	{
		private inkWidgetReference _bar;
		private inkWidgetReference _signalBar;
		private inkWidgetReference _completed;
		private inkWidgetReference _signalLost;
		private inkTextWidgetReference _percent;
		private inkTextWidgetReference _signalPercent;
		private inkWidgetReference _signalLabel;
		private inkWidgetReference _signalWrapper;
		private CName _appearance;
		private CName _signalLostAnimationName;
		private CName _introAnimationName;
		private CName _outroAnimationName;
		private CName _inRangeAnimationName;
		private CName _outOfRangeAnimationName;
		private CBool _addPercentSign;
		private CBool _handleOnComplete;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<gameIBlackboard> _progressBarBB;
		private CHandle<UI_HUDSignalProgressBarDef> _progressBarDef;
		private CHandle<redCallbackObject> _stateBBID;
		private CHandle<redCallbackObject> _progressBBID;
		private CHandle<redCallbackObject> _signalStrengthBBID;
		private CHandle<redCallbackObject> _orientationBBID;
		private CHandle<redCallbackObject> _appearanceBBID;
		private HUDProgressBarData _data;
		private CHandle<inkanimProxy> _outroAnimation;
		private CHandle<inkanimProxy> _signalLostAnimation;
		private CHandle<inkanimProxy> _introAnimation;
		private CHandle<inkanimProxy> _orientationAnimation;
		private CHandle<inkanimDefinition> _alpha_fadein;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private CHandle<inkanimTransparencyInterpolator> _alphaInterpolator;
		private CFloat _tick;
		private CBool _isAppearanceMatch;
		private Vector2 _barSize;
		private Vector2 _signalBarSize;

		[Ordinal(9)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(10)] 
		[RED("signalBar")] 
		public inkWidgetReference SignalBar
		{
			get => GetProperty(ref _signalBar);
			set => SetProperty(ref _signalBar, value);
		}

		[Ordinal(11)] 
		[RED("completed")] 
		public inkWidgetReference Completed
		{
			get => GetProperty(ref _completed);
			set => SetProperty(ref _completed, value);
		}

		[Ordinal(12)] 
		[RED("signalLost")] 
		public inkWidgetReference SignalLost
		{
			get => GetProperty(ref _signalLost);
			set => SetProperty(ref _signalLost, value);
		}

		[Ordinal(13)] 
		[RED("percent")] 
		public inkTextWidgetReference Percent
		{
			get => GetProperty(ref _percent);
			set => SetProperty(ref _percent, value);
		}

		[Ordinal(14)] 
		[RED("signalPercent")] 
		public inkTextWidgetReference SignalPercent
		{
			get => GetProperty(ref _signalPercent);
			set => SetProperty(ref _signalPercent, value);
		}

		[Ordinal(15)] 
		[RED("signalLabel")] 
		public inkWidgetReference SignalLabel
		{
			get => GetProperty(ref _signalLabel);
			set => SetProperty(ref _signalLabel, value);
		}

		[Ordinal(16)] 
		[RED("signalWrapper")] 
		public inkWidgetReference SignalWrapper
		{
			get => GetProperty(ref _signalWrapper);
			set => SetProperty(ref _signalWrapper, value);
		}

		[Ordinal(17)] 
		[RED("appearance")] 
		public CName Appearance
		{
			get => GetProperty(ref _appearance);
			set => SetProperty(ref _appearance, value);
		}

		[Ordinal(18)] 
		[RED("SignalLostAnimationName")] 
		public CName SignalLostAnimationName
		{
			get => GetProperty(ref _signalLostAnimationName);
			set => SetProperty(ref _signalLostAnimationName, value);
		}

		[Ordinal(19)] 
		[RED("IntroAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(20)] 
		[RED("OutroAnimationName")] 
		public CName OutroAnimationName
		{
			get => GetProperty(ref _outroAnimationName);
			set => SetProperty(ref _outroAnimationName, value);
		}

		[Ordinal(21)] 
		[RED("InRangeAnimationName")] 
		public CName InRangeAnimationName
		{
			get => GetProperty(ref _inRangeAnimationName);
			set => SetProperty(ref _inRangeAnimationName, value);
		}

		[Ordinal(22)] 
		[RED("OutOfRangeAnimationName")] 
		public CName OutOfRangeAnimationName
		{
			get => GetProperty(ref _outOfRangeAnimationName);
			set => SetProperty(ref _outOfRangeAnimationName, value);
		}

		[Ordinal(23)] 
		[RED("addPercentSign")] 
		public CBool AddPercentSign
		{
			get => GetProperty(ref _addPercentSign);
			set => SetProperty(ref _addPercentSign, value);
		}

		[Ordinal(24)] 
		[RED("handleOnComplete")] 
		public CBool HandleOnComplete
		{
			get => GetProperty(ref _handleOnComplete);
			set => SetProperty(ref _handleOnComplete, value);
		}

		[Ordinal(25)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(26)] 
		[RED("progressBarBB")] 
		public wCHandle<gameIBlackboard> ProgressBarBB
		{
			get => GetProperty(ref _progressBarBB);
			set => SetProperty(ref _progressBarBB, value);
		}

		[Ordinal(27)] 
		[RED("progressBarDef")] 
		public CHandle<UI_HUDSignalProgressBarDef> ProgressBarDef
		{
			get => GetProperty(ref _progressBarDef);
			set => SetProperty(ref _progressBarDef, value);
		}

		[Ordinal(28)] 
		[RED("stateBBID")] 
		public CHandle<redCallbackObject> StateBBID
		{
			get => GetProperty(ref _stateBBID);
			set => SetProperty(ref _stateBBID, value);
		}

		[Ordinal(29)] 
		[RED("progressBBID")] 
		public CHandle<redCallbackObject> ProgressBBID
		{
			get => GetProperty(ref _progressBBID);
			set => SetProperty(ref _progressBBID, value);
		}

		[Ordinal(30)] 
		[RED("signalStrengthBBID")] 
		public CHandle<redCallbackObject> SignalStrengthBBID
		{
			get => GetProperty(ref _signalStrengthBBID);
			set => SetProperty(ref _signalStrengthBBID, value);
		}

		[Ordinal(31)] 
		[RED("orientationBBID")] 
		public CHandle<redCallbackObject> OrientationBBID
		{
			get => GetProperty(ref _orientationBBID);
			set => SetProperty(ref _orientationBBID, value);
		}

		[Ordinal(32)] 
		[RED("appearanceBBID")] 
		public CHandle<redCallbackObject> AppearanceBBID
		{
			get => GetProperty(ref _appearanceBBID);
			set => SetProperty(ref _appearanceBBID, value);
		}

		[Ordinal(33)] 
		[RED("data")] 
		public HUDProgressBarData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(34)] 
		[RED("OutroAnimation")] 
		public CHandle<inkanimProxy> OutroAnimation
		{
			get => GetProperty(ref _outroAnimation);
			set => SetProperty(ref _outroAnimation, value);
		}

		[Ordinal(35)] 
		[RED("SignalLostAnimation")] 
		public CHandle<inkanimProxy> SignalLostAnimation
		{
			get => GetProperty(ref _signalLostAnimation);
			set => SetProperty(ref _signalLostAnimation, value);
		}

		[Ordinal(36)] 
		[RED("IntroAnimation")] 
		public CHandle<inkanimProxy> IntroAnimation
		{
			get => GetProperty(ref _introAnimation);
			set => SetProperty(ref _introAnimation, value);
		}

		[Ordinal(37)] 
		[RED("OrientationAnimation")] 
		public CHandle<inkanimProxy> OrientationAnimation
		{
			get => GetProperty(ref _orientationAnimation);
			set => SetProperty(ref _orientationAnimation, value);
		}

		[Ordinal(38)] 
		[RED("alpha_fadein")] 
		public CHandle<inkanimDefinition> Alpha_fadein
		{
			get => GetProperty(ref _alpha_fadein);
			set => SetProperty(ref _alpha_fadein, value);
		}

		[Ordinal(39)] 
		[RED("AnimProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(40)] 
		[RED("AnimOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(41)] 
		[RED("alphaInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> AlphaInterpolator
		{
			get => GetProperty(ref _alphaInterpolator);
			set => SetProperty(ref _alphaInterpolator, value);
		}

		[Ordinal(42)] 
		[RED("tick")] 
		public CFloat Tick
		{
			get => GetProperty(ref _tick);
			set => SetProperty(ref _tick, value);
		}

		[Ordinal(43)] 
		[RED("isAppearanceMatch")] 
		public CBool IsAppearanceMatch
		{
			get => GetProperty(ref _isAppearanceMatch);
			set => SetProperty(ref _isAppearanceMatch, value);
		}

		[Ordinal(44)] 
		[RED("barSize")] 
		public Vector2 BarSize
		{
			get => GetProperty(ref _barSize);
			set => SetProperty(ref _barSize, value);
		}

		[Ordinal(45)] 
		[RED("signalBarSize")] 
		public Vector2 SignalBarSize
		{
			get => GetProperty(ref _signalBarSize);
			set => SetProperty(ref _signalBarSize, value);
		}

		public HUDSignalProgressBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
