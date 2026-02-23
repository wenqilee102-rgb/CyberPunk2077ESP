using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EngagementScreenGameController : gameuiMenuGameController
	{
		private inkVideoWidgetReference _backgroundVideo;
		private inkCompoundWidgetReference _proceedConfirmationContainer;
		private inkCompoundWidgetReference _progressBar;
		private inkWidgetReference _pressKeyWidget;
		private inkWidgetReference _breachingWidget;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;
		private CBool _breachingEnabled;

		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(4)] 
		[RED("proceedConfirmationContainer")] 
		public inkCompoundWidgetReference ProceedConfirmationContainer
		{
			get => GetProperty(ref _proceedConfirmationContainer);
			set => SetProperty(ref _proceedConfirmationContainer, value);
		}

		[Ordinal(5)] 
		[RED("progressBar")] 
		public inkCompoundWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(6)] 
		[RED("pressKeyWidget")] 
		public inkWidgetReference PressKeyWidget
		{
			get => GetProperty(ref _pressKeyWidget);
			set => SetProperty(ref _pressKeyWidget, value);
		}

		[Ordinal(7)] 
		[RED("breachingWidget")] 
		public inkWidgetReference BreachingWidget
		{
			get => GetProperty(ref _breachingWidget);
			set => SetProperty(ref _breachingWidget, value);
		}

		[Ordinal(8)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(9)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		[Ordinal(10)] 
		[RED("progressBarController")] 
		public wCHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}

		[Ordinal(11)] 
		[RED("breachingEnabled")] 
		public CBool BreachingEnabled
		{
			get => GetProperty(ref _breachingEnabled);
			set => SetProperty(ref _breachingEnabled, value);
		}

		public EngagementScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
