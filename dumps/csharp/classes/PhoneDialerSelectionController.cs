using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneDialerSelectionController : inkSelectorController
	{
		private inkWidgetReference _leftArrowWidget;
		private inkWidgetReference _rightArrowWidget;
		private inkCompoundWidgetReference _container;
		private inkWidgetReference _line;
		private wCHandle<inkInputDisplayController> _leftArrowController;
		private wCHandle<inkInputDisplayController> _rightArrowController;
		private CArray<wCHandle<HubMenuLabelContentContainer>> _widgetsControllers;
		private CHandle<inkanimProxy> _lineTranslationAnimProxy;
		private CHandle<inkanimProxy> _lineSizeAnimProxy;
		private CFloat _animationsRetryDiv;
		private CBool _highlightInitialized;
		private CInt32 _currentIndex;

		[Ordinal(15)] 
		[RED("leftArrowWidget")] 
		public inkWidgetReference LeftArrowWidget
		{
			get => GetProperty(ref _leftArrowWidget);
			set => SetProperty(ref _leftArrowWidget, value);
		}

		[Ordinal(16)] 
		[RED("rightArrowWidget")] 
		public inkWidgetReference RightArrowWidget
		{
			get => GetProperty(ref _rightArrowWidget);
			set => SetProperty(ref _rightArrowWidget, value);
		}

		[Ordinal(17)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(18)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetProperty(ref _line);
			set => SetProperty(ref _line, value);
		}

		[Ordinal(19)] 
		[RED("leftArrowController")] 
		public wCHandle<inkInputDisplayController> LeftArrowController
		{
			get => GetProperty(ref _leftArrowController);
			set => SetProperty(ref _leftArrowController, value);
		}

		[Ordinal(20)] 
		[RED("rightArrowController")] 
		public wCHandle<inkInputDisplayController> RightArrowController
		{
			get => GetProperty(ref _rightArrowController);
			set => SetProperty(ref _rightArrowController, value);
		}

		[Ordinal(21)] 
		[RED("widgetsControllers")] 
		public CArray<wCHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get => GetProperty(ref _widgetsControllers);
			set => SetProperty(ref _widgetsControllers, value);
		}

		[Ordinal(22)] 
		[RED("lineTranslationAnimProxy")] 
		public CHandle<inkanimProxy> LineTranslationAnimProxy
		{
			get => GetProperty(ref _lineTranslationAnimProxy);
			set => SetProperty(ref _lineTranslationAnimProxy, value);
		}

		[Ordinal(23)] 
		[RED("lineSizeAnimProxy")] 
		public CHandle<inkanimProxy> LineSizeAnimProxy
		{
			get => GetProperty(ref _lineSizeAnimProxy);
			set => SetProperty(ref _lineSizeAnimProxy, value);
		}

		[Ordinal(24)] 
		[RED("animationsRetryDiv")] 
		public CFloat AnimationsRetryDiv
		{
			get => GetProperty(ref _animationsRetryDiv);
			set => SetProperty(ref _animationsRetryDiv, value);
		}

		[Ordinal(25)] 
		[RED("highlightInitialized")] 
		public CBool HighlightInitialized
		{
			get => GetProperty(ref _highlightInitialized);
			set => SetProperty(ref _highlightInitialized, value);
		}

		[Ordinal(26)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}

		public PhoneDialerSelectionController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
