using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReloadingExpansionPopupController : inkWidgetLogicController
	{
		private inkWidgetReference _progressBarRef;
		private inkTextWidgetReference _titleTextRef;
		private inkTextWidgetReference _descriptionTextRef;
		private inkTextWidgetReference _warningTextRef;
		private wCHandle<LoadingScreenProgressBarController> _progressBarController;
		private CHandle<inkanimProxy> _animProxy;

		[Ordinal(1)] 
		[RED("progressBarRef")] 
		public inkWidgetReference ProgressBarRef
		{
			get => GetProperty(ref _progressBarRef);
			set => SetProperty(ref _progressBarRef, value);
		}

		[Ordinal(2)] 
		[RED("titleTextRef")] 
		public inkTextWidgetReference TitleTextRef
		{
			get => GetProperty(ref _titleTextRef);
			set => SetProperty(ref _titleTextRef, value);
		}

		[Ordinal(3)] 
		[RED("descriptionTextRef")] 
		public inkTextWidgetReference DescriptionTextRef
		{
			get => GetProperty(ref _descriptionTextRef);
			set => SetProperty(ref _descriptionTextRef, value);
		}

		[Ordinal(4)] 
		[RED("warningTextRef")] 
		public inkTextWidgetReference WarningTextRef
		{
			get => GetProperty(ref _warningTextRef);
			set => SetProperty(ref _warningTextRef, value);
		}

		[Ordinal(5)] 
		[RED("progressBarController")] 
		public wCHandle<LoadingScreenProgressBarController> ProgressBarController
		{
			get => GetProperty(ref _progressBarController);
			set => SetProperty(ref _progressBarController, value);
		}

		[Ordinal(6)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		public ReloadingExpansionPopupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
