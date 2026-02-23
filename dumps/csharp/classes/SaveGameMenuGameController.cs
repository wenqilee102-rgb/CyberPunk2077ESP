using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SaveGameMenuGameController : gameuiSaveHandlingController
	{
		private inkCompoundWidgetReference _list;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _gogButtonWidgetRef;
		private inkWidgetReference _gogContainer;
		private inkWidgetReference _scrollbar;
		private wCHandle<inkMenuEventDispatcher> _eventDispatcher;
		private wCHandle<inkISystemRequestsHandler> _handler;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CHandle<inkSaveMetadataInfo> _saveInfo;
		private CArray<CString> _saves;
		private CBool _pendingRegistration;
		private CBool _hasEmptySlot;
		private CBool _saveInProgress;
		private CBool _loadComplete;
		private CBool _saveFilesReady;
		private CBool _cloudSynced;
		private wCHandle<LoadListItem> _emptySlotController;
		private CBool _isEp1Enabled;

		[Ordinal(3)] 
		[RED("list")] 
		public inkCompoundWidgetReference List
		{
			get => GetProperty(ref _list);
			set => SetProperty(ref _list, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("gogButtonWidgetRef")] 
		public inkWidgetReference GogButtonWidgetRef
		{
			get => GetProperty(ref _gogButtonWidgetRef);
			set => SetProperty(ref _gogButtonWidgetRef, value);
		}

		[Ordinal(6)] 
		[RED("gogContainer")] 
		public inkWidgetReference GogContainer
		{
			get => GetProperty(ref _gogContainer);
			set => SetProperty(ref _gogContainer, value);
		}

		[Ordinal(7)] 
		[RED("scrollbar")] 
		public inkWidgetReference Scrollbar
		{
			get => GetProperty(ref _scrollbar);
			set => SetProperty(ref _scrollbar, value);
		}

		[Ordinal(8)] 
		[RED("eventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> EventDispatcher
		{
			get => GetProperty(ref _eventDispatcher);
			set => SetProperty(ref _eventDispatcher, value);
		}

		[Ordinal(9)] 
		[RED("handler")] 
		public wCHandle<inkISystemRequestsHandler> Handler
		{
			get => GetProperty(ref _handler);
			set => SetProperty(ref _handler, value);
		}

		[Ordinal(10)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(11)] 
		[RED("saveInfo")] 
		public CHandle<inkSaveMetadataInfo> SaveInfo
		{
			get => GetProperty(ref _saveInfo);
			set => SetProperty(ref _saveInfo, value);
		}

		[Ordinal(12)] 
		[RED("saves")] 
		public CArray<CString> Saves
		{
			get => GetProperty(ref _saves);
			set => SetProperty(ref _saves, value);
		}

		[Ordinal(13)] 
		[RED("pendingRegistration")] 
		public CBool PendingRegistration
		{
			get => GetProperty(ref _pendingRegistration);
			set => SetProperty(ref _pendingRegistration, value);
		}

		[Ordinal(14)] 
		[RED("hasEmptySlot")] 
		public CBool HasEmptySlot
		{
			get => GetProperty(ref _hasEmptySlot);
			set => SetProperty(ref _hasEmptySlot, value);
		}

		[Ordinal(15)] 
		[RED("saveInProgress")] 
		public CBool SaveInProgress
		{
			get => GetProperty(ref _saveInProgress);
			set => SetProperty(ref _saveInProgress, value);
		}

		[Ordinal(16)] 
		[RED("loadComplete")] 
		public CBool LoadComplete
		{
			get => GetProperty(ref _loadComplete);
			set => SetProperty(ref _loadComplete, value);
		}

		[Ordinal(17)] 
		[RED("saveFilesReady")] 
		public CBool SaveFilesReady
		{
			get => GetProperty(ref _saveFilesReady);
			set => SetProperty(ref _saveFilesReady, value);
		}

		[Ordinal(18)] 
		[RED("cloudSynced")] 
		public CBool CloudSynced
		{
			get => GetProperty(ref _cloudSynced);
			set => SetProperty(ref _cloudSynced, value);
		}

		[Ordinal(19)] 
		[RED("emptySlotController")] 
		public wCHandle<LoadListItem> EmptySlotController
		{
			get => GetProperty(ref _emptySlotController);
			set => SetProperty(ref _emptySlotController, value);
		}

		[Ordinal(20)] 
		[RED("isEp1Enabled")] 
		public CBool IsEp1Enabled
		{
			get => GetProperty(ref _isEp1Enabled);
			set => SetProperty(ref _isEp1Enabled, value);
		}

		public SaveGameMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
