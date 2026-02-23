using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestDetailsPanelController : inkWidgetLogicController
	{
		private inkTextWidgetReference _questTitle;
		private inkTextWidgetReference _questDescription;
		private inkTextWidgetReference _questLevel;
		private inkCompoundWidgetReference _activeObjectives;
		private inkCompoundWidgetReference _optionalObjectives;
		private inkCompoundWidgetReference _completedObjectives;
		private inkCompoundWidgetReference _codexLinksContainer;
		private inkCompoundWidgetReference _missionLinksContainer;
		private inkCompoundWidgetReference _fluffLinksContainer;
		private inkCompoundWidgetReference _mapLinksContainer;
		private inkCompoundWidgetReference _missionLinkLine;
		private inkCompoundWidgetReference _fluffShardLinkLine;
		private inkCompoundWidgetReference _codexLinkLine;
		private inkWidgetReference _contentContainer;
		private inkWidgetReference _scrollContainer;
		private inkWidgetReference _noSelectedQuestContainer;
		private inkWidgetReference _ep1Marker;
		private wCHandle<inkScrollController> _scrollContainerCtrl;
		private wCHandle<gameJournalQuest> _currentQuestData;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalOnscreen> _shardEntry;
		private wCHandle<PhoneSystem> _phoneSystem;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;
		private wCHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<gameJournalQuestObjective> _trackedObjective;
		private CBool _canUsePhone;
		private CFloat _objectiveOffset;
		private CFloat _objectiveActionOffset;
		private CInt32 _objectiveActionsCount;

		[Ordinal(1)] 
		[RED("questTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetProperty(ref _questTitle);
			set => SetProperty(ref _questTitle, value);
		}

		[Ordinal(2)] 
		[RED("questDescription")] 
		public inkTextWidgetReference QuestDescription
		{
			get => GetProperty(ref _questDescription);
			set => SetProperty(ref _questDescription, value);
		}

		[Ordinal(3)] 
		[RED("questLevel")] 
		public inkTextWidgetReference QuestLevel
		{
			get => GetProperty(ref _questLevel);
			set => SetProperty(ref _questLevel, value);
		}

		[Ordinal(4)] 
		[RED("activeObjectives")] 
		public inkCompoundWidgetReference ActiveObjectives
		{
			get => GetProperty(ref _activeObjectives);
			set => SetProperty(ref _activeObjectives, value);
		}

		[Ordinal(5)] 
		[RED("optionalObjectives")] 
		public inkCompoundWidgetReference OptionalObjectives
		{
			get => GetProperty(ref _optionalObjectives);
			set => SetProperty(ref _optionalObjectives, value);
		}

		[Ordinal(6)] 
		[RED("completedObjectives")] 
		public inkCompoundWidgetReference CompletedObjectives
		{
			get => GetProperty(ref _completedObjectives);
			set => SetProperty(ref _completedObjectives, value);
		}

		[Ordinal(7)] 
		[RED("codexLinksContainer")] 
		public inkCompoundWidgetReference CodexLinksContainer
		{
			get => GetProperty(ref _codexLinksContainer);
			set => SetProperty(ref _codexLinksContainer, value);
		}

		[Ordinal(8)] 
		[RED("missionLinksContainer")] 
		public inkCompoundWidgetReference MissionLinksContainer
		{
			get => GetProperty(ref _missionLinksContainer);
			set => SetProperty(ref _missionLinksContainer, value);
		}

		[Ordinal(9)] 
		[RED("fluffLinksContainer")] 
		public inkCompoundWidgetReference FluffLinksContainer
		{
			get => GetProperty(ref _fluffLinksContainer);
			set => SetProperty(ref _fluffLinksContainer, value);
		}

		[Ordinal(10)] 
		[RED("mapLinksContainer")] 
		public inkCompoundWidgetReference MapLinksContainer
		{
			get => GetProperty(ref _mapLinksContainer);
			set => SetProperty(ref _mapLinksContainer, value);
		}

		[Ordinal(11)] 
		[RED("missionLinkLine")] 
		public inkCompoundWidgetReference MissionLinkLine
		{
			get => GetProperty(ref _missionLinkLine);
			set => SetProperty(ref _missionLinkLine, value);
		}

		[Ordinal(12)] 
		[RED("fluffShardLinkLine")] 
		public inkCompoundWidgetReference FluffShardLinkLine
		{
			get => GetProperty(ref _fluffShardLinkLine);
			set => SetProperty(ref _fluffShardLinkLine, value);
		}

		[Ordinal(13)] 
		[RED("codexLinkLine")] 
		public inkCompoundWidgetReference CodexLinkLine
		{
			get => GetProperty(ref _codexLinkLine);
			set => SetProperty(ref _codexLinkLine, value);
		}

		[Ordinal(14)] 
		[RED("contentContainer")] 
		public inkWidgetReference ContentContainer
		{
			get => GetProperty(ref _contentContainer);
			set => SetProperty(ref _contentContainer, value);
		}

		[Ordinal(15)] 
		[RED("scrollContainer")] 
		public inkWidgetReference ScrollContainer
		{
			get => GetProperty(ref _scrollContainer);
			set => SetProperty(ref _scrollContainer, value);
		}

		[Ordinal(16)] 
		[RED("noSelectedQuestContainer")] 
		public inkWidgetReference NoSelectedQuestContainer
		{
			get => GetProperty(ref _noSelectedQuestContainer);
			set => SetProperty(ref _noSelectedQuestContainer, value);
		}

		[Ordinal(17)] 
		[RED("ep1Marker")] 
		public inkWidgetReference Ep1Marker
		{
			get => GetProperty(ref _ep1Marker);
			set => SetProperty(ref _ep1Marker, value);
		}

		[Ordinal(18)] 
		[RED("scrollContainerCtrl")] 
		public wCHandle<inkScrollController> ScrollContainerCtrl
		{
			get => GetProperty(ref _scrollContainerCtrl);
			set => SetProperty(ref _scrollContainerCtrl, value);
		}

		[Ordinal(19)] 
		[RED("currentQuestData")] 
		public wCHandle<gameJournalQuest> CurrentQuestData
		{
			get => GetProperty(ref _currentQuestData);
			set => SetProperty(ref _currentQuestData, value);
		}

		[Ordinal(20)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(21)] 
		[RED("shardEntry")] 
		public wCHandle<gameJournalOnscreen> ShardEntry
		{
			get => GetProperty(ref _shardEntry);
			set => SetProperty(ref _shardEntry, value);
		}

		[Ordinal(22)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(23)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		[Ordinal(24)] 
		[RED("uiSystem")] 
		public wCHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(25)] 
		[RED("trackedObjective")] 
		public wCHandle<gameJournalQuestObjective> TrackedObjective
		{
			get => GetProperty(ref _trackedObjective);
			set => SetProperty(ref _trackedObjective, value);
		}

		[Ordinal(26)] 
		[RED("canUsePhone")] 
		public CBool CanUsePhone
		{
			get => GetProperty(ref _canUsePhone);
			set => SetProperty(ref _canUsePhone, value);
		}

		[Ordinal(27)] 
		[RED("objectiveOffset")] 
		public CFloat ObjectiveOffset
		{
			get => GetProperty(ref _objectiveOffset);
			set => SetProperty(ref _objectiveOffset, value);
		}

		[Ordinal(28)] 
		[RED("objectiveActionOffset")] 
		public CFloat ObjectiveActionOffset
		{
			get => GetProperty(ref _objectiveActionOffset);
			set => SetProperty(ref _objectiveActionOffset, value);
		}

		[Ordinal(29)] 
		[RED("objectiveActionsCount")] 
		public CInt32 ObjectiveActionsCount
		{
			get => GetProperty(ref _objectiveActionsCount);
			set => SetProperty(ref _objectiveActionsCount, value);
		}

		public QuestDetailsPanelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
