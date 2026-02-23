using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryScreenshotFullPreview : gameuiWidgetGameController
	{
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _screenshotContainer;
		private inkWidgetReference _screenshotMask;
		private inkImageWidgetReference _screenshotPreview;
		private inkWidgetReference _container;
		private inkWidgetReference _windowWrapper;
		private inkWidgetReference _favoriteIcon;
		private wCHandle<inkCompoundWidget> _preloader;
		private wCHandle<inkISystemRequestsHandler> _systemHandler;
		private CHandle<GalleryScreenshotPreviewData> _data;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<inkGameNotificationToken> _deleteConfirmationToken;

		[Ordinal(2)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(3)] 
		[RED("screenshotContainer")] 
		public inkWidgetReference ScreenshotContainer
		{
			get => GetProperty(ref _screenshotContainer);
			set => SetProperty(ref _screenshotContainer, value);
		}

		[Ordinal(4)] 
		[RED("screenshotMask")] 
		public inkWidgetReference ScreenshotMask
		{
			get => GetProperty(ref _screenshotMask);
			set => SetProperty(ref _screenshotMask, value);
		}

		[Ordinal(5)] 
		[RED("screenshotPreview")] 
		public inkImageWidgetReference ScreenshotPreview
		{
			get => GetProperty(ref _screenshotPreview);
			set => SetProperty(ref _screenshotPreview, value);
		}

		[Ordinal(6)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(7)] 
		[RED("windowWrapper")] 
		public inkWidgetReference WindowWrapper
		{
			get => GetProperty(ref _windowWrapper);
			set => SetProperty(ref _windowWrapper, value);
		}

		[Ordinal(8)] 
		[RED("favoriteIcon")] 
		public inkWidgetReference FavoriteIcon
		{
			get => GetProperty(ref _favoriteIcon);
			set => SetProperty(ref _favoriteIcon, value);
		}

		[Ordinal(9)] 
		[RED("preloader")] 
		public wCHandle<inkCompoundWidget> Preloader
		{
			get => GetProperty(ref _preloader);
			set => SetProperty(ref _preloader, value);
		}

		[Ordinal(10)] 
		[RED("systemHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetProperty(ref _systemHandler);
			set => SetProperty(ref _systemHandler, value);
		}

		[Ordinal(11)] 
		[RED("data")] 
		public CHandle<GalleryScreenshotPreviewData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(13)] 
		[RED("deleteConfirmationToken")] 
		public CHandle<inkGameNotificationToken> DeleteConfirmationToken
		{
			get => GetProperty(ref _deleteConfirmationToken);
			set => SetProperty(ref _deleteConfirmationToken, value);
		}

		public GalleryScreenshotFullPreview(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
