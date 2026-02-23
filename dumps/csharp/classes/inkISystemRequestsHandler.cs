using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkISystemRequestsHandler : IScriptable
	{
		private inkSystemRequesResult _savesForSaveReady;
		private inkSystemRequesResult _savesForLoadReady;
		private inkSaveMetadataRequestResult _saveMetadataReady;
		private inkOnGogLoginStatusChangedResult _gogLoginStatusChanged;
		private inkDeleteRequestResult _saveDeleted;
		private inkSaveTransferRequestUpdate _saveTransferUpdate;
		private inkSystemServerRequesResult _serversSearchResult;
		private inkAdditionalContentPurchaseCallback _additionalContentPurchaseResult;
		private inkAdditionalContentInstallRequestedCallback _additionalContentInstallationRequestResult;
		private inkAdditionalContentInstalledCallback _additionalContentInstallationResult;
		private inkAdditionalContentStatusUpdateCallback _additionalContentStatusUpdateResult;
		private inkAdditionalContentDataReloadProgress _additionalContentDataReloadProgressCallback;
		private inkToggleBreachingCallback _toggleBreachingCallback;
		private inkUserIdResult _userChanged;
		private inkUserIdResult _userIdResult;
		private inkTrialVersionRemainingTimeUpdate _trialVersionRemainingTimeUpdated;
		private inkTrialOnBuyFullGame _boughtFullGame;
		private inkCloudSavesQueryStatusChange _cloudSavesQueryStatusChanged;
		private inkCloudSaveUploadFinish _cloudSaveUploadFinish;
		private inkGameScreenshotsRequestResult _screenshotsForLoadReady;
		private inkFavoriteLoadResult _favoritesLoadedReady;
		private inkDeleteScreenshotResult _deleteSreenshotComplete;
		private inkMarketingConsentPopupTypeResult _marketingConsentPopupTypeResult;

		[Ordinal(0)] 
		[RED("SavesForSaveReady")] 
		public inkSystemRequesResult SavesForSaveReady
		{
			get => GetProperty(ref _savesForSaveReady);
			set => SetProperty(ref _savesForSaveReady, value);
		}

		[Ordinal(1)] 
		[RED("SavesForLoadReady")] 
		public inkSystemRequesResult SavesForLoadReady
		{
			get => GetProperty(ref _savesForLoadReady);
			set => SetProperty(ref _savesForLoadReady, value);
		}

		[Ordinal(2)] 
		[RED("SaveMetadataReady")] 
		public inkSaveMetadataRequestResult SaveMetadataReady
		{
			get => GetProperty(ref _saveMetadataReady);
			set => SetProperty(ref _saveMetadataReady, value);
		}

		[Ordinal(3)] 
		[RED("GogLoginStatusChanged")] 
		public inkOnGogLoginStatusChangedResult GogLoginStatusChanged
		{
			get => GetProperty(ref _gogLoginStatusChanged);
			set => SetProperty(ref _gogLoginStatusChanged, value);
		}

		[Ordinal(4)] 
		[RED("SaveDeleted")] 
		public inkDeleteRequestResult SaveDeleted
		{
			get => GetProperty(ref _saveDeleted);
			set => SetProperty(ref _saveDeleted, value);
		}

		[Ordinal(5)] 
		[RED("SaveTransferUpdate")] 
		public inkSaveTransferRequestUpdate SaveTransferUpdate
		{
			get => GetProperty(ref _saveTransferUpdate);
			set => SetProperty(ref _saveTransferUpdate, value);
		}

		[Ordinal(6)] 
		[RED("ServersSearchResult")] 
		public inkSystemServerRequesResult ServersSearchResult
		{
			get => GetProperty(ref _serversSearchResult);
			set => SetProperty(ref _serversSearchResult, value);
		}

		[Ordinal(7)] 
		[RED("AdditionalContentPurchaseResult")] 
		public inkAdditionalContentPurchaseCallback AdditionalContentPurchaseResult
		{
			get => GetProperty(ref _additionalContentPurchaseResult);
			set => SetProperty(ref _additionalContentPurchaseResult, value);
		}

		[Ordinal(8)] 
		[RED("AdditionalContentInstallationRequestResult")] 
		public inkAdditionalContentInstallRequestedCallback AdditionalContentInstallationRequestResult
		{
			get => GetProperty(ref _additionalContentInstallationRequestResult);
			set => SetProperty(ref _additionalContentInstallationRequestResult, value);
		}

		[Ordinal(9)] 
		[RED("AdditionalContentInstallationResult")] 
		public inkAdditionalContentInstalledCallback AdditionalContentInstallationResult
		{
			get => GetProperty(ref _additionalContentInstallationResult);
			set => SetProperty(ref _additionalContentInstallationResult, value);
		}

		[Ordinal(10)] 
		[RED("AdditionalContentStatusUpdateResult")] 
		public inkAdditionalContentStatusUpdateCallback AdditionalContentStatusUpdateResult
		{
			get => GetProperty(ref _additionalContentStatusUpdateResult);
			set => SetProperty(ref _additionalContentStatusUpdateResult, value);
		}

		[Ordinal(11)] 
		[RED("AdditionalContentDataReloadProgressCallback")] 
		public inkAdditionalContentDataReloadProgress AdditionalContentDataReloadProgressCallback
		{
			get => GetProperty(ref _additionalContentDataReloadProgressCallback);
			set => SetProperty(ref _additionalContentDataReloadProgressCallback, value);
		}

		[Ordinal(12)] 
		[RED("ToggleBreachingCallback")] 
		public inkToggleBreachingCallback ToggleBreachingCallback
		{
			get => GetProperty(ref _toggleBreachingCallback);
			set => SetProperty(ref _toggleBreachingCallback, value);
		}

		[Ordinal(13)] 
		[RED("UserChanged")] 
		public inkUserIdResult UserChanged
		{
			get => GetProperty(ref _userChanged);
			set => SetProperty(ref _userChanged, value);
		}

		[Ordinal(14)] 
		[RED("UserIdResult")] 
		public inkUserIdResult UserIdResult
		{
			get => GetProperty(ref _userIdResult);
			set => SetProperty(ref _userIdResult, value);
		}

		[Ordinal(15)] 
		[RED("TrialVersionRemainingTimeUpdated")] 
		public inkTrialVersionRemainingTimeUpdate TrialVersionRemainingTimeUpdated
		{
			get => GetProperty(ref _trialVersionRemainingTimeUpdated);
			set => SetProperty(ref _trialVersionRemainingTimeUpdated, value);
		}

		[Ordinal(16)] 
		[RED("BoughtFullGame")] 
		public inkTrialOnBuyFullGame BoughtFullGame
		{
			get => GetProperty(ref _boughtFullGame);
			set => SetProperty(ref _boughtFullGame, value);
		}

		[Ordinal(17)] 
		[RED("CloudSavesQueryStatusChanged")] 
		public inkCloudSavesQueryStatusChange CloudSavesQueryStatusChanged
		{
			get => GetProperty(ref _cloudSavesQueryStatusChanged);
			set => SetProperty(ref _cloudSavesQueryStatusChanged, value);
		}

		[Ordinal(18)] 
		[RED("CloudSaveUploadFinish")] 
		public inkCloudSaveUploadFinish CloudSaveUploadFinish
		{
			get => GetProperty(ref _cloudSaveUploadFinish);
			set => SetProperty(ref _cloudSaveUploadFinish, value);
		}

		[Ordinal(19)] 
		[RED("ScreenshotsForLoadReady")] 
		public inkGameScreenshotsRequestResult ScreenshotsForLoadReady
		{
			get => GetProperty(ref _screenshotsForLoadReady);
			set => SetProperty(ref _screenshotsForLoadReady, value);
		}

		[Ordinal(20)] 
		[RED("FavoritesLoadedReady")] 
		public inkFavoriteLoadResult FavoritesLoadedReady
		{
			get => GetProperty(ref _favoritesLoadedReady);
			set => SetProperty(ref _favoritesLoadedReady, value);
		}

		[Ordinal(21)] 
		[RED("DeleteSreenshotComplete")] 
		public inkDeleteScreenshotResult DeleteSreenshotComplete
		{
			get => GetProperty(ref _deleteSreenshotComplete);
			set => SetProperty(ref _deleteSreenshotComplete, value);
		}

		[Ordinal(22)] 
		[RED("MarketingConsentPopupTypeResult")] 
		public inkMarketingConsentPopupTypeResult MarketingConsentPopupTypeResult
		{
			get => GetProperty(ref _marketingConsentPopupTypeResult);
			set => SetProperty(ref _marketingConsentPopupTypeResult, value);
		}

		public inkISystemRequestsHandler(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
