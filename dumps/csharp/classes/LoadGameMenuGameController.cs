using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LoadGameMenuGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _noSavedGamesLabel;
		private inkWidgetReference _buttonHintsManagerRef;
		private CName _transitToLoadingAnimName;
		private CName _transitToLoadingSlotAnimName;
		private CFloat _animDelayBetweenSlots;
		private CFloat _animDelayForMainSlot;
		private CBool _enableLoadingTransition;
		private inkWidgetReference _gogButtonWidgetRef;
		private inkWidgetReference _gogContainer;
		private inkWidgetReference _laodingSpinner;
		private inkWidgetReference _scrollbar;
		private wCHandle<inkMenuEventDispatcher> _eventDispatcher;
		private CBool _loadComplete;
		private CHandle<inkSaveMetadataInfo> _saveInfo;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CInt32 _saveToLoadIndex;
		private CUInt64 _saveToLoadID;
		private CBool _isInputDisabled;
		private CHandle<inkGameNotificationToken> _saveTransferPopupToken;
		private CArray<CString> _saves;
		private CBool _saveFilesReady;
		private CBool _cloudSynced;
		private wCHandle<gameIOnlineSystem> _onlineSystem;
		private wCHandle<inkISystemRequestsHandler> _systemHandler;
		private CBool _pendingRegistration;
		private CBool _isEp1Enabled;
		private CHandle<inkanimProxy> _animProxy;
		private CInt32 _sourceIndex;

		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(4)] 
		[RED("noSavedGamesLabel")] 
		public inkWidgetReference NoSavedGamesLabel
		{
			get => GetProperty(ref _noSavedGamesLabel);
			set => SetProperty(ref _noSavedGamesLabel, value);
		}

		[Ordinal(5)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(6)] 
		[RED("transitToLoadingAnimName")] 
		public CName TransitToLoadingAnimName
		{
			get => GetProperty(ref _transitToLoadingAnimName);
			set => SetProperty(ref _transitToLoadingAnimName, value);
		}

		[Ordinal(7)] 
		[RED("transitToLoadingSlotAnimName")] 
		public CName TransitToLoadingSlotAnimName
		{
			get => GetProperty(ref _transitToLoadingSlotAnimName);
			set => SetProperty(ref _transitToLoadingSlotAnimName, value);
		}

		[Ordinal(8)] 
		[RED("animDelayBetweenSlots")] 
		public CFloat AnimDelayBetweenSlots
		{
			get => GetProperty(ref _animDelayBetweenSlots);
			set => SetProperty(ref _animDelayBetweenSlots, value);
		}

		[Ordinal(9)] 
		[RED("animDelayForMainSlot")] 
		public CFloat AnimDelayForMainSlot
		{
			get => GetProperty(ref _animDelayForMainSlot);
			set => SetProperty(ref _animDelayForMainSlot, value);
		}

		[Ordinal(10)] 
		[RED("enableLoadingTransition")] 
		public CBool EnableLoadingTransition
		{
			get => GetProperty(ref _enableLoadingTransition);
			set => SetProperty(ref _enableLoadingTransition, value);
		}

		[Ordinal(11)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetProperty(ref _gogButtonWidgetRef);
			set => SetProperty(ref _gogButtonWidgetRef, value);
		}

		[Ordinal(12)] 
		[RED("gogContainer")] 
		public inkWidgetReference GogContainer
		{
			get => GetProperty(ref _gogContainer);
			set => SetProperty(ref _gogContainer, value);
		}

		[Ordinal(13)] 
		[RED("laodingSpinner")] 
		public inkWidgetReference LaodingSpinner
		{
			get => GetProperty(ref _laodingSpinner);
			set => SetProperty(ref _laodingSpinner, value);
		}

		[Ordinal(14)] 
		[RED("scrollbar")] 
		public inkWidgetReference Scrollbar
		{
			get => GetProperty(ref _scrollbar);
			set => SetProperty(ref _scrollbar, value);
		}

		[Ordinal(15)] 
		[RED("eventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		[Ordinal(16)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetProperty(ref _loadComplete);
			set => SetProperty(ref _loadComplete, value);
		}

		[Ordinal(17)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetProperty(ref _saveInfo);
			set => SetProperty(ref _saveInfo, value);
		}

		[Ordinal(18)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(19)] 
		[RED("saveToLoadIndex")] 
		public CInt32 SaveToLoadIndex
		{
			get => GetProperty(ref _saveToLoadIndex);
			set => SetProperty(ref _saveToLoadIndex, value);
		}

		[Ordinal(20)] 
		[RED("saveToLoadID")] 
		public CUInt64 SaveToLoadID
		{
			get => GetProperty(ref _saveToLoadID);
			set => SetProperty(ref _saveToLoadID, value);
		}

		[Ordinal(21)] 
		[RED("isInputDisabled")] 
		public CBool IsInputDisabled
		{
			get => GetProperty(ref _isInputDisabled);
			set => SetProperty(ref _isInputDisabled, value);
		}

		[Ordinal(22)] 
		[RED("saveTransferPopupToken")] 
		public CHandle<inkGameNotificationToken> SaveTransferPopupToken
		{
			get => GetProperty(ref _saveTransferPopupToken);
			set => SetProperty(ref _saveTransferPopupToken, value);
		}

		[Ordinal(23)] 
		[RED("saves")] 
		public CArray<CString> Saves
		{
			get => GetProperty(ref _saves);
			set => SetProperty(ref _saves, value);
		}

		[Ordinal(24)] 
		[RED("saveFilesReady")] 
		public CBool SaveFilesReady
		{
			get => GetProperty(ref _saveFilesReady);
			set => SetProperty(ref _saveFilesReady, value);
		}

		[Ordinal(25)] 
		[RED("cloudSynced")] 
		public CBool CloudSynced
		{
			get => GetProperty(ref _cloudSynced);
			set => SetProperty(ref _cloudSynced, value);
		}

		[Ordinal(26)] 
		[RED("onlineSystem")] 
		public wCHandle<gameIOnlineSystem> OnlineSystem
		{
			get => GetProperty(ref _onlineSystem);
			set => SetProperty(ref _onlineSystem, value);
		}

		[Ordinal(27)] 
		[RED("systemHandler")] 
		public wCHandle<inkISystemRequestsHandler> SystemHandler
		{
			get => GetProperty(ref _systemHandler);
			set => SetProperty(ref _systemHandler, value);
		}

		[Ordinal(28)] 
		[RED("pendingRegistration")] 
		public CBool PendingRegistration
		{
			get => GetProperty(ref _pendingRegistration);
			set => SetProperty(ref _pendingRegistration, value);
		}

		[Ordinal(29)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetProperty(ref _isEp1Enabled);
			set => SetProperty(ref _isEp1Enabled, value);
		}

		[Ordinal(30)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(31)] 
		[RED("sourceIndex")] 
		public CInt32 SourceIndex
		{
			get => GetProperty(ref _sourceIndex);
			set => SetProperty(ref _sourceIndex, value);
		}

		public LoadGameMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
