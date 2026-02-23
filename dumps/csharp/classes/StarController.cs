using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StarController : inkWidgetLogicController
	{
		private CHandle<inkanimProxy> _animIntroProxy;
		private inkanimPlaybackOptions _animIntroOptions;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkanimDefinition> _animBlink;
		private CHandle<inkanimProxy> _animBlinkProxy;
		private inkanimPlaybackOptions _animBlinkOptions;
		private CArrayFixedSize<CUInt32> _animBlinkLoops;
		private CInt32 _animBlinkLastStage;
		private CEnum<inkanimLoopType> _blinkAnimLoopType;
		private CFloat _blinkDuration;
		private inkWidgetReference _bountyBadgeWidget;
		private CFloat _blinkSpeed1;
		private CFloat _blinkSpeed2;
		private CFloat _blinkSpeed3;
		private CEnum<inkanimInterpolationMode> _blinkAnimInterpolationMode;
		private CEnum<inkanimInterpolationType> _blinkAnimInterpolationType;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _iconBg;
		private CName _ncpdIconName;
		private CName _ncpdIconBgName;
		private CName _dogtownIconName;
		private CName _dogtownIconBgName;

		[Ordinal(1)] 
		[RED("animIntroProxy")] 
		public CHandle<inkanimProxy> AnimIntroProxy
		{
			get => GetProperty(ref _animIntroProxy);
			set => SetProperty(ref _animIntroProxy, value);
		}

		[Ordinal(2)] 
		[RED("animIntroOptions")] 
		public inkanimPlaybackOptions AnimIntroOptions
		{
			get => GetProperty(ref _animIntroOptions);
			set => SetProperty(ref _animIntroOptions, value);
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(4)] 
		[RED("animBlink")] 
		public CHandle<inkanimDefinition> AnimBlink
		{
			get => GetProperty(ref _animBlink);
			set => SetProperty(ref _animBlink, value);
		}

		[Ordinal(5)] 
		[RED("animBlinkProxy")] 
		public CHandle<inkanimProxy> AnimBlinkProxy
		{
			get => GetProperty(ref _animBlinkProxy);
			set => SetProperty(ref _animBlinkProxy, value);
		}

		[Ordinal(6)] 
		[RED("animBlinkOptions")] 
		public inkanimPlaybackOptions AnimBlinkOptions
		{
			get => GetProperty(ref _animBlinkOptions);
			set => SetProperty(ref _animBlinkOptions, value);
		}

		[Ordinal(7)] 
		[RED("animBlinkLoops", 3)] 
		public CArrayFixedSize<CUInt32> AnimBlinkLoops
		{
			get => GetProperty(ref _animBlinkLoops);
			set => SetProperty(ref _animBlinkLoops, value);
		}

		[Ordinal(8)] 
		[RED("animBlinkLastStage")] 
		public CInt32 AnimBlinkLastStage
		{
			get => GetProperty(ref _animBlinkLastStage);
			set => SetProperty(ref _animBlinkLastStage, value);
		}

		[Ordinal(9)] 
		[RED("blinkAnimLoopType")] 
		public CEnum<inkanimLoopType> BlinkAnimLoopType
		{
			get => GetProperty(ref _blinkAnimLoopType);
			set => SetProperty(ref _blinkAnimLoopType, value);
		}

		[Ordinal(10)] 
		[RED("blinkDuration")] 
		public CFloat BlinkDuration
		{
			get => GetProperty(ref _blinkDuration);
			set => SetProperty(ref _blinkDuration, value);
		}

		[Ordinal(11)] 
		[RED("bountyBadgeWidget")] 
		public inkWidgetReference BountyBadgeWidget
		{
			get => GetProperty(ref _bountyBadgeWidget);
			set => SetProperty(ref _bountyBadgeWidget, value);
		}

		[Ordinal(12)] 
		[RED("blinkSpeed1")] 
		public CFloat BlinkSpeed1
		{
			get => GetProperty(ref _blinkSpeed1);
			set => SetProperty(ref _blinkSpeed1, value);
		}

		[Ordinal(13)] 
		[RED("blinkSpeed2")] 
		public CFloat BlinkSpeed2
		{
			get => GetProperty(ref _blinkSpeed2);
			set => SetProperty(ref _blinkSpeed2, value);
		}

		[Ordinal(14)] 
		[RED("blinkSpeed3")] 
		public CFloat BlinkSpeed3
		{
			get => GetProperty(ref _blinkSpeed3);
			set => SetProperty(ref _blinkSpeed3, value);
		}

		[Ordinal(15)] 
		[RED("blinkAnimInterpolationMode")] 
		public CEnum<inkanimInterpolationMode> BlinkAnimInterpolationMode
		{
			get => GetProperty(ref _blinkAnimInterpolationMode);
			set => SetProperty(ref _blinkAnimInterpolationMode, value);
		}

		[Ordinal(16)] 
		[RED("blinkAnimInterpolationType")] 
		public CEnum<inkanimInterpolationType> BlinkAnimInterpolationType
		{
			get => GetProperty(ref _blinkAnimInterpolationType);
			set => SetProperty(ref _blinkAnimInterpolationType, value);
		}

		[Ordinal(17)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(18)] 
		[RED("iconBg")] 
		public inkImageWidgetReference IconBg
		{
			get => GetProperty(ref _iconBg);
			set => SetProperty(ref _iconBg, value);
		}

		[Ordinal(19)] 
		[RED("ncpdIconName")] 
		public CName NcpdIconName
		{
			get => GetProperty(ref _ncpdIconName);
			set => SetProperty(ref _ncpdIconName, value);
		}

		[Ordinal(20)] 
		[RED("ncpdIconBgName")] 
		public CName NcpdIconBgName
		{
			get => GetProperty(ref _ncpdIconBgName);
			set => SetProperty(ref _ncpdIconBgName, value);
		}

		[Ordinal(21)] 
		[RED("dogtownIconName")] 
		public CName DogtownIconName
		{
			get => GetProperty(ref _dogtownIconName);
			set => SetProperty(ref _dogtownIconName, value);
		}

		[Ordinal(22)] 
		[RED("dogtownIconBgName")] 
		public CName DogtownIconBgName
		{
			get => GetProperty(ref _dogtownIconBgName);
			set => SetProperty(ref _dogtownIconBgName, value);
		}

		public StarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
