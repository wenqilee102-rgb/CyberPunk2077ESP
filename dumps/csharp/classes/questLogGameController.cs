using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLogGameController : gameuiMenuGameController
	{
		private inkWidgetReference _virtualList;
		private inkWidgetReference _detailsPanel;
		private inkWidgetReference _buttonHints;
		private inkWidgetReference _filtersList;
		private inkWidgetReference _questList;
		private ScriptGameInstance _game;
		private wCHandle<gameJournalManager> _journalManager;
		private CArray<wCHandle<gameJournalEntry>> _quests;
		private CArray<wCHandle<gameJournalEntry>> _resolvedQuests;
		private wCHandle<ButtonHints> _buttonHintsController;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<gameJournalQuest> _trackedQuest;
		private wCHandle<gameJournalQuest> _curreentQuest;
		private CInt32 _externallyOpenedQuestHash;
		private CInt32 _playerLevel;
		private CInt32 _recommendedLevel;
		private CHandle<inkanimProxy> _entryAnimProxy;
		private CBool _canUsePhone;
		private wCHandle<QuestDetailsPanelController> _detailsPanelCtrl;
		private wCHandle<QuestListVirtualController> _virtualListController;
		private CArray<wCHandle<QuestListFilterButtonController>> _filters;
		private wCHandle<QuestListFilterButtonController> _activeFilter;
		private CInt32 _currentCustomFilterIndex;
		private CFloat _axisDataThreshold;
		private CFloat _mouseDataThreshold;
		private CFloat _delayedShowDuration;
		private gameDelayID _delayedShow;
		private CBool _listPanelHoverd;
		private CBool _isDelayTicking;
		private CBool _firstInit;
		private CBool _filterSwich;
		private wCHandle<gameJournalQuest> _questData;
		private wCHandle<gameJournalQuest> _appliedQuestData;
		private CBool _skipAnimation;
		private CArray<CHandle<QuestListItemData>> _listData;
		private CArray<CEnum<QuestListItemType>> _questTypeList;
		private wCHandle<gameJournalQuest> _questToOpen;

		[Ordinal(3)] 
		[RED("virtualList")] 
		public inkWidgetReference VirtualList
		{
			get => GetProperty(ref _virtualList);
			set => SetProperty(ref _virtualList, value);
		}

		[Ordinal(4)] 
		[RED("detailsPanel")] 
		public inkWidgetReference DetailsPanel
		{
			get => GetProperty(ref _detailsPanel);
			set => SetProperty(ref _detailsPanel, value);
		}

		[Ordinal(5)] 
		[RED("buttonHints")] 
		public inkWidgetReference ButtonHints
		{
			get => GetProperty(ref _buttonHints);
			set => SetProperty(ref _buttonHints, value);
		}

		[Ordinal(6)] 
		[RED("filtersList")] 
		public inkWidgetReference FiltersList
		{
			get => GetProperty(ref _filtersList);
			set => SetProperty(ref _filtersList, value);
		}

		[Ordinal(7)] 
		[RED("questList")] 
		public inkWidgetReference QuestList
		{
			get => GetProperty(ref _questList);
			set => SetProperty(ref _questList, value);
		}

		[Ordinal(8)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(9)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(10)] 
		[RED("quests")] 
		public CArray<wCHandle<gameJournalEntry>> Quests
		{
			get => GetProperty(ref _quests);
			set => SetProperty(ref _quests, value);
		}

		[Ordinal(11)] 
		[RED("resolvedQuests")] 
		public CArray<wCHandle<gameJournalEntry>> ResolvedQuests
		{
			get => GetProperty(ref _resolvedQuests);
			set => SetProperty(ref _resolvedQuests, value);
		}

		[Ordinal(12)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(13)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(14)] 
		[RED("trackedQuest")] 
		public wCHandle<gameJournalQuest> TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(15)] 
		[RED("curreentQuest")] 
		public wCHandle<gameJournalQuest> CurreentQuest
		{
			get => GetProperty(ref _curreentQuest);
			set => SetProperty(ref _curreentQuest, value);
		}

		[Ordinal(16)] 
		[RED("externallyOpenedQuestHash")] 
		public CInt32 ExternallyOpenedQuestHash
		{
			get => GetProperty(ref _externallyOpenedQuestHash);
			set => SetProperty(ref _externallyOpenedQuestHash, value);
		}

		[Ordinal(17)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(18)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetProperty(ref _recommendedLevel);
			set => SetProperty(ref _recommendedLevel, value);
		}

		[Ordinal(19)] 
		[RED("entryAnimProxy")] 
		public CHandle<inkanimProxy> EntryAnimProxy
		{
			get => GetProperty(ref _entryAnimProxy);
			set => SetProperty(ref _entryAnimProxy, value);
		}

		[Ordinal(20)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetProperty(ref _canUsePhone);
			set => SetProperty(ref _canUsePhone, value);
		}

		[Ordinal(21)] 
		[RED("detailsPanelCtrl")] 
		public wCHandle<QuestDetailsPanelController> DetailsPanelCtrl
		{
			get => GetProperty(ref _detailsPanelCtrl);
			set => SetProperty(ref _detailsPanelCtrl, value);
		}

		[Ordinal(22)] 
		[RED("virtualListController")] 
		public wCHandle<QuestListVirtualController> VirtualListController
		{
			get => GetProperty(ref _virtualListController);
			set => SetProperty(ref _virtualListController, value);
		}

		[Ordinal(23)] 
		[RED("filters")] 
		public CArray<wCHandle<QuestListFilterButtonController>> Filters
		{
			get => GetProperty(ref _filters);
			set => SetProperty(ref _filters, value);
		}

		[Ordinal(24)] 
		[RED("activeFilter")] 
		public wCHandle<QuestListFilterButtonController> ActiveFilter
		{
			get => GetProperty(ref _activeFilter);
			set => SetProperty(ref _activeFilter, value);
		}

		[Ordinal(25)] 
		[RED("currentCustomFilterIndex")] 
		public CInt32 CurrentCustomFilterIndex
		{
			get => GetProperty(ref _currentCustomFilterIndex);
			set => SetProperty(ref _currentCustomFilterIndex, value);
		}

		[Ordinal(26)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get => GetProperty(ref _axisDataThreshold);
			set => SetProperty(ref _axisDataThreshold, value);
		}

		[Ordinal(27)] 
		[RED("mouseDataThreshold")] 
		public CFloat MouseDataThreshold
		{
			get => GetProperty(ref _mouseDataThreshold);
			set => SetProperty(ref _mouseDataThreshold, value);
		}

		[Ordinal(28)] 
		[RED("delayedShowDuration")] 
		public CFloat DelayedShowDuration
		{
			get => GetProperty(ref _delayedShowDuration);
			set => SetProperty(ref _delayedShowDuration, value);
		}

		[Ordinal(29)] 
		[RED("delayedShow")] 
		public gameDelayID DelayedShow
		{
			get => GetProperty(ref _delayedShow);
			set => SetProperty(ref _delayedShow, value);
		}

		[Ordinal(30)] 
		[RED("listPanelHoverd")] 
		public CBool ListPanelHoverd
		{
			get => GetProperty(ref _listPanelHoverd);
			set => SetProperty(ref _listPanelHoverd, value);
		}

		[Ordinal(31)] 
		[RED("isDelayTicking")] 
		public CBool IsDelayTicking
		{
			get => GetProperty(ref _isDelayTicking);
			set => SetProperty(ref _isDelayTicking, value);
		}

		[Ordinal(32)] 
		[RED("firstInit")] 
		public CBool FirstInit
		{
			get => GetProperty(ref _firstInit);
			set => SetProperty(ref _firstInit, value);
		}

		[Ordinal(33)] 
		[RED("filterSwich")] 
		public CBool FilterSwich
		{
			get => GetProperty(ref _filterSwich);
			set => SetProperty(ref _filterSwich, value);
		}

		[Ordinal(34)] 
		[RED("questData")] 
		public wCHandle<gameJournalQuest> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		[Ordinal(35)] 
		[RED("appliedQuestData")] 
		public wCHandle<gameJournalQuest> AppliedQuestData
		{
			get => GetProperty(ref _appliedQuestData);
			set => SetProperty(ref _appliedQuestData, value);
		}

		[Ordinal(36)] 
		[RED("skipAnimation")] 
		public CBool SkipAnimation
		{
			get => GetProperty(ref _skipAnimation);
			set => SetProperty(ref _skipAnimation, value);
		}

		[Ordinal(37)] 
		[RED("listData")] 
		public CArray<CHandle<QuestListItemData>> ListData
		{
			get => GetProperty(ref _listData);
			set => SetProperty(ref _listData, value);
		}

		[Ordinal(38)] 
		[RED("questTypeList")] 
		public CArray<CEnum<QuestListItemType>> QuestTypeList
		{
			get => GetProperty(ref _questTypeList);
			set => SetProperty(ref _questTypeList, value);
		}

		[Ordinal(39)] 
		[RED("questToOpen")] 
		public wCHandle<gameJournalQuest> QuestToOpen
		{
			get => GetProperty(ref _questToOpen);
			set => SetProperty(ref _questToOpen, value);
		}

		public questLogGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
