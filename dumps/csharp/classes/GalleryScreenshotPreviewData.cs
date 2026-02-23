using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryScreenshotPreviewData : inkGameNotificationData
	{
		private CInt32 _screenshotIndex;
		private CInt32 _screenshotWidth;
		private CInt32 _screenshotHeight;
		private CString _path;
		private CUInt32 _hash;
		private CUInt64 _creationDate;
		private CBool _isFavorite;
		private CBool _canBeDeleted;
		private wCHandle<GalleryScreenshotItem> _screenshotItem;
		private wCHandle<GalleryFavoriteManager> _favoriteManager;
		private wCHandle<GalleryMenuGameController> _galleryController;

		[Ordinal(7)] 
		[RED("screenshotIndex")] 
		public CInt32 ScreenshotIndex
		{
			get => GetProperty(ref _screenshotIndex);
			set => SetProperty(ref _screenshotIndex, value);
		}

		[Ordinal(8)] 
		[RED("screenshotWidth")] 
		public CInt32 ScreenshotWidth
		{
			get => GetProperty(ref _screenshotWidth);
			set => SetProperty(ref _screenshotWidth, value);
		}

		[Ordinal(9)] 
		[RED("screenshotHeight")] 
		public CInt32 ScreenshotHeight
		{
			get => GetProperty(ref _screenshotHeight);
			set => SetProperty(ref _screenshotHeight, value);
		}

		[Ordinal(10)] 
		[RED("Path")] 
		public CString Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(11)] 
		[RED("Hash")] 
		public CUInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(12)] 
		[RED("creationDate")] 
		public CUInt64 CreationDate
		{
			get => GetProperty(ref _creationDate);
			set => SetProperty(ref _creationDate, value);
		}

		[Ordinal(13)] 
		[RED("isFavorite")] 
		public CBool IsFavorite
		{
			get => GetProperty(ref _isFavorite);
			set => SetProperty(ref _isFavorite, value);
		}

		[Ordinal(14)] 
		[RED("canBeDeleted")] 
		public CBool CanBeDeleted
		{
			get => GetProperty(ref _canBeDeleted);
			set => SetProperty(ref _canBeDeleted, value);
		}

		[Ordinal(15)] 
		[RED("screenshotItem")] 
		public wCHandle<GalleryScreenshotItem> ScreenshotItem
		{
			get => GetProperty(ref _screenshotItem);
			set => SetProperty(ref _screenshotItem, value);
		}

		[Ordinal(16)] 
		[RED("favoriteManager")] 
		public wCHandle<GalleryFavoriteManager> FavoriteManager
		{
			get => GetProperty(ref _favoriteManager);
			set => SetProperty(ref _favoriteManager, value);
		}

		[Ordinal(17)] 
		[RED("galleryController")] 
		public wCHandle<GalleryMenuGameController> GalleryController
		{
			get => GetProperty(ref _galleryController);
			set => SetProperty(ref _galleryController, value);
		}

		public GalleryScreenshotPreviewData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
