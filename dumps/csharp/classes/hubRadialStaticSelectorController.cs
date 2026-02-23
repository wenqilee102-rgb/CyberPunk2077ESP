using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class hubRadialStaticSelectorController : inkSelectorController
	{
		private inkWidgetReference _leftArrowWidget;
		private inkWidgetReference _rightArrowWidget;
		private inkWidgetReference _container;
		private inkWidgetReference _line;
		private wCHandle<inkInputDisplayController> _leftArrowController;
		private wCHandle<inkInputDisplayController> _rightArrowController;
		private CArray<MenuData> _data;
		private CArray<wCHandle<HubMenuLabelContentContainer>> _widgetsControllers;
		private CInt32 _currentIndex;
		private CInt32 _currentParent;
		private CArray<MenuData> _currentData;
		private CHandle<inkanimProxy> _lineTranslationAnimProxy;
		private CHandle<inkanimProxy> _lineSizeAnimProxy;
		private CBool _instantLineUpdateRequested;
		private CFloat _animationsRetryDiv;
		private inkTextWidgetReference _debugText;

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
		public inkWidgetReference Container
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
		[RED("data")] 
		public CArray<MenuData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(22)] 
		[RED("widgetsControllers")] 
		public CArray<wCHandle<HubMenuLabelContentContainer>> WidgetsControllers
		{
			get => GetProperty(ref _widgetsControllers);
			set => SetProperty(ref _widgetsControllers, value);
		}

		[Ordinal(23)] 
		[RED("currentIndex")] 
		public CInt32 CurrentIndex
		{
			get => GetProperty(ref _currentIndex);
			set => SetProperty(ref _currentIndex, value);
		}

		[Ordinal(24)] 
		[RED("currentParent")] 
		public CInt32 CurrentParent
		{
			get => GetProperty(ref _currentParent);
			set => SetProperty(ref _currentParent, value);
		}

		[Ordinal(25)] 
		[RED("currentData")] 
		public CArray<MenuData> CurrentData
		{
			get => GetProperty(ref _currentData);
			set => SetProperty(ref _currentData, value);
		}

		[Ordinal(26)] 
		[RED("lineTranslationAnimProxy")] 
		public CHandle<inkanimProxy> LineTranslationAnimProxy
		{
			get => GetProperty(ref _lineTranslationAnimProxy);
			set => SetProperty(ref _lineTranslationAnimProxy, value);
		}

		[Ordinal(27)] 
		[RED("lineSizeAnimProxy")] 
		public CHandle<inkanimProxy> LineSizeAnimProxy
		{
			get => GetProperty(ref _lineSizeAnimProxy);
			set => SetProperty(ref _lineSizeAnimProxy, value);
		}

		[Ordinal(28)] 
		[RED("instantLineUpdateRequested")] 
		public CBool InstantLineUpdateRequested
		{
			get => GetProperty(ref _instantLineUpdateRequested);
			set => SetProperty(ref _instantLineUpdateRequested, value);
		}

		[Ordinal(29)] 
		[RED("animationsRetryDiv")] 
		public CFloat AnimationsRetryDiv
		{
			get => GetProperty(ref _animationsRetryDiv);
			set => SetProperty(ref _animationsRetryDiv, value);
		}

		[Ordinal(30)] 
		[RED("debugText")] 
		public inkTextWidgetReference DebugText
		{
			get => GetProperty(ref _debugText);
			set => SetProperty(ref _debugText, value);
		}

		public hubRadialStaticSelectorController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
