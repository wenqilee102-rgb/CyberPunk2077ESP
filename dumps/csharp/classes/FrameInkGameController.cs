using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FrameInkGameController : gameuiWidgetGameController
	{
		private inkImageWidgetReference _screenshotWidget;
		private inkImageWidgetReference _defaultScreenshotWidget;

		[Ordinal(2)] 
		[RED("screenshotWidget")] 
		public inkImageWidgetReference ScreenshotWidget
		{
			get => GetProperty(ref _screenshotWidget);
			set => SetProperty(ref _screenshotWidget, value);
		}

		[Ordinal(3)] 
		[RED("defaultScreenshotWidget")] 
		public inkImageWidgetReference DefaultScreenshotWidget
		{
			get => GetProperty(ref _defaultScreenshotWidget);
			set => SetProperty(ref _defaultScreenshotWidget, value);
		}

		public FrameInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
