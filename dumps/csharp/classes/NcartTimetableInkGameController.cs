using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartTimetableInkGameController : DeviceInkGameControllerBase
	{
		private wCHandle<inkCanvasWidget> _defaultUI;
		private wCHandle<inkVideoWidget> _mainDisplayWidget;
		private wCHandle<inkTextWidget> _counterWidget;
		private wCHandle<inkImageWidget> _trainImage;
		private CInt32 _cachedLine;
		private inkImageWidgetReference _lineAIcon;
		private inkImageWidgetReference _lineBIcon;
		private inkImageWidgetReference _lineCIcon;
		private inkImageWidgetReference _lineDIcon;
		private inkImageWidgetReference _lineEIcon;
		private CHandle<redCallbackObject> _onGlitchingStateChangedListener;
		private CHandle<redCallbackObject> _onTimeToDepartChangedListener;
		private CHandle<redCallbackObject> _onCurrentLineNumberChangedListener;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(16)] 
		[RED("defaultUI")] 
		public wCHandle<inkCanvasWidget> DefaultUI
		{
			get => GetProperty(ref _defaultUI);
			set => SetProperty(ref _defaultUI, value);
		}

		[Ordinal(17)] 
		[RED("mainDisplayWidget")] 
		public wCHandle<inkVideoWidget> MainDisplayWidget
		{
			get => GetProperty(ref _mainDisplayWidget);
			set => SetProperty(ref _mainDisplayWidget, value);
		}

		[Ordinal(18)] 
		[RED("counterWidget")] 
		public wCHandle<inkTextWidget> CounterWidget
		{
			get => GetProperty(ref _counterWidget);
			set => SetProperty(ref _counterWidget, value);
		}

		[Ordinal(19)] 
		[RED("trainImage")] 
		public wCHandle<inkImageWidget> TrainImage
		{
			get => GetProperty(ref _trainImage);
			set => SetProperty(ref _trainImage, value);
		}

		[Ordinal(20)] 
		[RED("cachedLine")] 
		public CInt32 CachedLine
		{
			get => GetProperty(ref _cachedLine);
			set => SetProperty(ref _cachedLine, value);
		}

		[Ordinal(21)] 
		[RED("lineAIcon")] 
		public inkImageWidgetReference LineAIcon
		{
			get => GetProperty(ref _lineAIcon);
			set => SetProperty(ref _lineAIcon, value);
		}

		[Ordinal(22)] 
		[RED("lineBIcon")] 
		public inkImageWidgetReference LineBIcon
		{
			get => GetProperty(ref _lineBIcon);
			set => SetProperty(ref _lineBIcon, value);
		}

		[Ordinal(23)] 
		[RED("lineCIcon")] 
		public inkImageWidgetReference LineCIcon
		{
			get => GetProperty(ref _lineCIcon);
			set => SetProperty(ref _lineCIcon, value);
		}

		[Ordinal(24)] 
		[RED("lineDIcon")] 
		public inkImageWidgetReference LineDIcon
		{
			get => GetProperty(ref _lineDIcon);
			set => SetProperty(ref _lineDIcon, value);
		}

		[Ordinal(25)] 
		[RED("lineEIcon")] 
		public inkImageWidgetReference LineEIcon
		{
			get => GetProperty(ref _lineEIcon);
			set => SetProperty(ref _lineEIcon, value);
		}

		[Ordinal(26)] 
		[RED("onGlitchingStateChangedListener")] 
		public CHandle<redCallbackObject> OnGlitchingStateChangedListener
		{
			get => GetProperty(ref _onGlitchingStateChangedListener);
			set => SetProperty(ref _onGlitchingStateChangedListener, value);
		}

		[Ordinal(27)] 
		[RED("onTimeToDepartChangedListener")] 
		public CHandle<redCallbackObject> OnTimeToDepartChangedListener
		{
			get => GetProperty(ref _onTimeToDepartChangedListener);
			set => SetProperty(ref _onTimeToDepartChangedListener, value);
		}

		[Ordinal(28)] 
		[RED("onCurrentLineNumberChangedListener")] 
		public CHandle<redCallbackObject> OnCurrentLineNumberChangedListener
		{
			get => GetProperty(ref _onCurrentLineNumberChangedListener);
			set => SetProperty(ref _onCurrentLineNumberChangedListener, value);
		}

		[Ordinal(29)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public NcartTimetableInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
