using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryScreenshotItem : inkWidgetLogicController
	{
		private inkWidgetReference _screenshotPreview;
		private inkWidgetReference _container;
		private inkWidgetReference _hoverFrame;
		private inkWidgetReference _favoriteIcon;
		private inkWidgetReference _emptyBackground;
		private inkWidgetReference _errorVisual;
		private inkWidgetReference _selectedBorder;
		private wCHandle<GalleryMenuGameController> _galleryMenuGameController;
		private wCHandle<inkCompoundWidget> _preloader;
		private Vector2 _basePreviewSize;
		private CHandle<GalleryScreenshotPreviewData> _screenshotData;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CBool _isHovered;
		private CBool _canBeHoveredOver;

		[Ordinal(1)] 
		[RED("screenshotPreview")] 
		public inkWidgetReference ScreenshotPreview
		{
			get => GetProperty(ref _screenshotPreview);
			set => SetProperty(ref _screenshotPreview, value);
		}

		[Ordinal(2)] 
		[RED("container")] 
		public inkWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(3)] 
		[RED("hoverFrame")] 
		public inkWidgetReference HoverFrame
		{
			get => GetProperty(ref _hoverFrame);
			set => SetProperty(ref _hoverFrame, value);
		}

		[Ordinal(4)] 
		[RED("favoriteIcon")] 
		public inkWidgetReference FavoriteIcon
		{
			get => GetProperty(ref _favoriteIcon);
			set => SetProperty(ref _favoriteIcon, value);
		}

		[Ordinal(5)] 
		[RED("emptyBackground")] 
		public inkWidgetReference EmptyBackground
		{
			get => GetProperty(ref _emptyBackground);
			set => SetProperty(ref _emptyBackground, value);
		}

		[Ordinal(6)] 
		[RED("errorVisual")] 
		public inkWidgetReference ErrorVisual
		{
			get => GetProperty(ref _errorVisual);
			set => SetProperty(ref _errorVisual, value);
		}

		[Ordinal(7)] 
		[RED("selectedBorder")] 
		public inkWidgetReference SelectedBorder
		{
			get => GetProperty(ref _selectedBorder);
			set => SetProperty(ref _selectedBorder, value);
		}

		[Ordinal(8)] 
		[RED("galleryMenuGameController")] 
		public wCHandle<GalleryMenuGameController> GalleryMenuGameController
		{
			get => GetProperty(ref _galleryMenuGameController);
			set => SetProperty(ref _galleryMenuGameController, value);
		}

		[Ordinal(9)] 
		[RED("preloader")] 
		public wCHandle<inkCompoundWidget> Preloader
		{
			get => GetProperty(ref _preloader);
			set => SetProperty(ref _preloader, value);
		}

		[Ordinal(10)] 
		[RED("basePreviewSize")] 
		public Vector2 BasePreviewSize
		{
			get => GetProperty(ref _basePreviewSize);
			set => SetProperty(ref _basePreviewSize, value);
		}

		[Ordinal(11)] 
		[RED("screenshotData")] 
		public CHandle<GalleryScreenshotPreviewData> ScreenshotData
		{
			get => GetProperty(ref _screenshotData);
			set => SetProperty(ref _screenshotData, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(13)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		[Ordinal(14)] 
		[RED("canBeHoveredOver")] 
		public CBool CanBeHoveredOver
		{
			get => GetProperty(ref _canBeHoveredOver);
			set => SetProperty(ref _canBeHoveredOver, value);
		}

		public GalleryScreenshotItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
