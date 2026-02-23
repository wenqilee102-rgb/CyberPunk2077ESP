using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GalleryMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _favoriteManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _globalWrapper;
		private inkCompoundWidgetReference _screenshotsGrid;
		private inkWidgetReference _filtersGrid;
		private inkCompoundWidgetReference _paginationWidget;
		private inkWidgetReference _globalPreloaderContainer;
		private CInt32 _screenshotsPerPage;
		private inkWidgetReference _noPermissionWidget;
		private wCHandle<GalleryPopup> _noPermissionController;
		private wCHandle<inkWidget> _globalPreloader;
		private wCHandle<PaginationController> _paginationController;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkISystemRequestsHandler> _systemHandler;
		private ScriptGameInstance _gameInstance;
		private CArray<inkGameScreenshotInfo> _screenshotInfos;
		private CArray<inkGameScreenshotInfo> _sortedScreenshotInfos;
		private CHandle<inkGameNotificationToken> _screenshotFullPreviewPopupToken;
		private CArray<CEnum<inkGameScreenshotSortMode>> _filterTypes;
		private wCHandle<GalleryFilterController> _activeSort;
		private CBool _isFavoriteFiltering;
		private CArray<wCHandle<GalleryScreenshotItem>> _screenshotItems;
		private CInt32 _pageCount;
		private CInt32 _currentPage;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private wCHandle<GalleryFavoriteManager> _favoriteManager;
		private CHandle<redCallbackObject> _onInputDeviceChangedCallbackID;
		private CHandle<inkGameNotificationToken> _deleteConfirmationToken;
		private CInt32 _deleteScreenshotId;
		private CName _visualStateName;
		private CBool _isSecondaryActionEnabled;
		private CArray<wCHandle<GalleryFilterController>> _filterButtons;
		private CBool _canInteract;
		private wCHandle<gameObject> _playerObj;
		private CInt32 _pageToDisplayOnLoad;

		[Ordinal(3)] 
		[RED("tooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("favoriteManagerRef")] 
		public inkWidgetReference FavoriteManagerRef
		{
			get => GetProperty(ref _favoriteManagerRef);
			set => SetProperty(ref _favoriteManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("globalWrapper")] 
		public inkWidgetReference GlobalWrapper
		{
			get => GetProperty(ref _globalWrapper);
			set => SetProperty(ref _globalWrapper, value);
		}

		[Ordinal(7)] 
		[RED("screenshotsGrid")] 
		public inkCompoundWidgetReference ScreenshotsGrid
		{
			get => GetProperty(ref _screenshotsGrid);
			set => SetProperty(ref _screenshotsGrid, value);
		}

		[Ordinal(8)] 
		[RED("filtersGrid")] 
		public inkWidgetReference FiltersGrid
		{
			get => GetProperty(ref _filtersGrid);
			set => SetProperty(ref _filtersGrid, value);
		}

		[Ordinal(9)] 
		[RED("paginationWidget")] 
		public inkCompoundWidgetReference PaginationWidget
		{
			get => GetProperty(ref _paginationWidget);
			set => SetProperty(ref _paginationWidget, value);
		}

		[Ordinal(10)] 
		[RED("globalPreloaderContainer")] 
		public inkWidgetReference GlobalPreloaderContainer
		{
			get => GetProperty(ref _globalPreloaderContainer);
			set => SetProperty(ref _globalPreloaderContainer, value);
		}

		[Ordinal(11)] 
		[RED("screenshotsPerPage")] 
		public CInt32 ScreenshotsPerPage
		{
			get => GetProperty(ref _screenshotsPerPage);
			set => SetProperty(ref _screenshotsPerPage, value);
		}

		[Ordinal(12)] 
		[RED("noPermissionWidget")] 
		public inkWidgetReference NoPermissionWidget
		{
			get => GetProperty(ref _noPermissionWidget);
			set => SetProperty(ref _noPermissionWidget, value);
		}

		[Ordinal(13)] 
		[RED("noPermissionController")] 
		public wCHandle<GalleryPopup> NoPermissionController
		{
			get => GetProperty(ref _noPermissionController);
			set => SetProperty(ref _noPermissionController, value);
		}

		[Ordinal(14)] 
		[RED("globalPreloader")] 
		public wCHandle<inkWidget> GlobalPreloader
		{
			get => GetProperty(ref _globalPreloader);
			set => SetProperty(ref _globalPreloader, value);
		}

		[Ordinal(15)] 
		[RED("paginationController")] 
		public wCHandle<PaginationController> PaginationController
		{
			get => GetProperty(ref _paginationController);
			set => SetProperty(ref _paginationController, value);
		}

		[Ordinal(16)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(17)] 
		[RED("systemHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetProperty(ref _systemHandler);
			set => SetProperty(ref _systemHandler, value);
		}

		[Ordinal(18)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(19)] 
		[RED("screenshotInfos")] 
		public CArray<inkGameScreenshotInfo> ScreenshotInfos
		{
			get => GetProperty(ref _screenshotInfos);
			set => SetProperty(ref _screenshotInfos, value);
		}

		[Ordinal(20)] 
		[RED("sortedScreenshotInfos")] 
		public CArray<inkGameScreenshotInfo> SortedScreenshotInfos
		{
			get => GetProperty(ref _sortedScreenshotInfos);
			set => SetProperty(ref _sortedScreenshotInfos, value);
		}

		[Ordinal(21)] 
		[RED("screenshotFullPreviewPopupToken")] 
		public CHandle<inkGameNotificationToken> ScreenshotFullPreviewPopupToken
		{
			get => GetProperty(ref _screenshotFullPreviewPopupToken);
			set => SetProperty(ref _screenshotFullPreviewPopupToken, value);
		}

		[Ordinal(22)] 
		[RED("filterTypes")] 
		public CArray<CEnum<inkGameScreenshotSortMode>> FilterTypes
		{
			get => GetProperty(ref _filterTypes);
			set => SetProperty(ref _filterTypes, value);
		}

		[Ordinal(23)] 
		[RED("activeSort")] 
		public wCHandle<GalleryFilterController> ActiveSort
		{
			get => GetProperty(ref _activeSort);
			set => SetProperty(ref _activeSort, value);
		}

		[Ordinal(24)] 
		[RED("isFavoriteFiltering")] 
		public CBool IsFavoriteFiltering
		{
			get => GetProperty(ref _isFavoriteFiltering);
			set => SetProperty(ref _isFavoriteFiltering, value);
		}

		[Ordinal(25)] 
		[RED("screenshotItems")] 
		public CArray<wCHandle<GalleryScreenshotItem>> ScreenshotItems
		{
			get => GetProperty(ref _screenshotItems);
			set => SetProperty(ref _screenshotItems, value);
		}

		[Ordinal(26)] 
		[RED("pageCount")] 
		public CInt32 PageCount
		{
			get => GetProperty(ref _pageCount);
			set => SetProperty(ref _pageCount, value);
		}

		[Ordinal(27)] 
		[RED("currentPage")] 
		public CInt32 CurrentPage
		{
			get => GetProperty(ref _currentPage);
			set => SetProperty(ref _currentPage, value);
		}

		[Ordinal(28)] 
		[RED("tooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(29)] 
		[RED("favoriteManager")] 
		public wCHandle<GalleryFavoriteManager> FavoriteManager
		{
			get => GetProperty(ref _favoriteManager);
			set => SetProperty(ref _favoriteManager, value);
		}

		[Ordinal(30)] 
		[RED("onInputDeviceChangedCallbackID")] 
		public CHandle<redCallbackObject> OnInputDeviceChangedCallbackID
		{
			get => GetProperty(ref _onInputDeviceChangedCallbackID);
			set => SetProperty(ref _onInputDeviceChangedCallbackID, value);
		}

		[Ordinal(31)] 
		[RED("deleteConfirmationToken")] 
		public CHandle<inkGameNotificationToken> DeleteConfirmationToken
		{
			get => GetProperty(ref _deleteConfirmationToken);
			set => SetProperty(ref _deleteConfirmationToken, value);
		}

		[Ordinal(32)] 
		[RED("deleteScreenshotId")] 
		public CInt32 DeleteScreenshotId
		{
			get => GetProperty(ref _deleteScreenshotId);
			set => SetProperty(ref _deleteScreenshotId, value);
		}

		[Ordinal(33)] 
		[RED("visualStateName")] 
		public CName VisualStateName
		{
			get => GetProperty(ref _visualStateName);
			set => SetProperty(ref _visualStateName, value);
		}

		[Ordinal(34)] 
		[RED("isSecondaryActionEnabled")] 
		public CBool IsSecondaryActionEnabled
		{
			get => GetProperty(ref _isSecondaryActionEnabled);
			set => SetProperty(ref _isSecondaryActionEnabled, value);
		}

		[Ordinal(35)] 
		[RED("filterButtons")] 
		public CArray<wCHandle<GalleryFilterController>> FilterButtons
		{
			get => GetProperty(ref _filterButtons);
			set => SetProperty(ref _filterButtons, value);
		}

		[Ordinal(36)] 
		[RED("canInteract")] 
		public CBool CanInteract
		{
			get => GetProperty(ref _canInteract);
			set => SetProperty(ref _canInteract, value);
		}

		[Ordinal(37)] 
		[RED("playerObj")] 
		public wCHandle<gameObject> PlayerObj
		{
			get => GetProperty(ref _playerObj);
			set => SetProperty(ref _playerObj, value);
		}

		[Ordinal(38)] 
		[RED("pageToDisplayOnLoad")] 
		public CInt32 PageToDisplayOnLoad
		{
			get => GetProperty(ref _pageToDisplayOnLoad);
			set => SetProperty(ref _pageToDisplayOnLoad, value);
		}

		public GalleryMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
