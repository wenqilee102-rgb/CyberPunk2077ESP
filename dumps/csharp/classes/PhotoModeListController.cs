using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhotoModeListController : inkWidgetLogicController
	{
		private inkVerticalPanelWidgetReference _panel;
		private inkWidgetReference _sliderWidget;
		private inkScrollAreaWidgetReference _scrollArea;
		private wCHandle<gameuiMenuGameController> _menuController;
		private wCHandle<inkScrollController> _scrollController;
		private wCHandle<inkListController> _listController;
		private CHandle<inkanimProxy> _fadeAnim;
		private CBool _isAnimating;
		private CFloat _animationTime;
		private CFloat _animationTarget;
		private CFloat _elementsAnimationTime;
		private CFloat _elementsAnimationDelay;
		private CInt32 _currentElementAnimation;

		[Ordinal(1)] 
		[RED("Panel")] 
		public inkVerticalPanelWidgetReference Panel
		{
			get => GetProperty(ref _panel);
			set => SetProperty(ref _panel, value);
		}

		[Ordinal(2)] 
		[RED("sliderWidget")] 
		public inkWidgetReference SliderWidget
		{
			get => GetProperty(ref _sliderWidget);
			set => SetProperty(ref _sliderWidget, value);
		}

		[Ordinal(3)] 
		[RED("scrollArea")] 
		public inkScrollAreaWidgetReference ScrollArea
		{
			get => GetProperty(ref _scrollArea);
			set => SetProperty(ref _scrollArea, value);
		}

		[Ordinal(4)] 
		[RED("menuController")] 
		public wCHandle<gameuiMenuGameController> MenuController
		{
			get => GetProperty(ref _menuController);
			set => SetProperty(ref _menuController, value);
		}

		[Ordinal(5)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(6)] 
		[RED("listController")] 
		public wCHandle<inkListController> ListController
		{
			get => GetProperty(ref _listController);
			set => SetProperty(ref _listController, value);
		}

		[Ordinal(7)] 
		[RED("fadeAnim")] 
		public CHandle<inkanimProxy> FadeAnim
		{
			get => GetProperty(ref _fadeAnim);
			set => SetProperty(ref _fadeAnim, value);
		}

		[Ordinal(8)] 
		[RED("isAnimating")] 
		public CBool IsAnimating
		{
			get => GetProperty(ref _isAnimating);
			set => SetProperty(ref _isAnimating, value);
		}

		[Ordinal(9)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		[Ordinal(10)] 
		[RED("animationTarget")] 
		public CFloat AnimationTarget
		{
			get => GetProperty(ref _animationTarget);
			set => SetProperty(ref _animationTarget, value);
		}

		[Ordinal(11)] 
		[RED("elementsAnimationTime")] 
		public CFloat ElementsAnimationTime
		{
			get => GetProperty(ref _elementsAnimationTime);
			set => SetProperty(ref _elementsAnimationTime, value);
		}

		[Ordinal(12)] 
		[RED("elementsAnimationDelay")] 
		public CFloat ElementsAnimationDelay
		{
			get => GetProperty(ref _elementsAnimationDelay);
			set => SetProperty(ref _elementsAnimationDelay, value);
		}

		[Ordinal(13)] 
		[RED("currentElementAnimation")] 
		public CInt32 CurrentElementAnimation
		{
			get => GetProperty(ref _currentElementAnimation);
			set => SetProperty(ref _currentElementAnimation, value);
		}

		public PhotoModeListController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
