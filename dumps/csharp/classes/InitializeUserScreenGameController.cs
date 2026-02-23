using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InitializeUserScreenGameController : gameuiMenuGameController
	{
		private inkVideoWidgetReference _backgroundVideo;
		private inkCompoundWidgetReference _breachingContainer;
		private inkCompoundWidgetReference _progressBar;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;

		[Ordinal(3)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(4)] 
		[RED("breachingContainer")] 
		public inkCompoundWidgetReference BreachingContainer
		{
			get => GetProperty(ref _breachingContainer);
			set => SetProperty(ref _breachingContainer, value);
		}

		[Ordinal(5)] 
		[RED("progressBar")] 
		public inkCompoundWidgetReference ProgressBar
		{
			get => GetProperty(ref _progressBar);
			set => SetProperty(ref _progressBar, value);
		}

		[Ordinal(6)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(7)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		[Ordinal(8)] 
		[RED("progressBarController")] 
		public wCHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}

		public InitializeUserScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
