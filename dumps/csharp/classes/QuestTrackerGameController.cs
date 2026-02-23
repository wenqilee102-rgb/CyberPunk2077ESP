using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestTrackerGameController : gameuiHUDGameController
	{
		private inkWidgetReference _questTrackerContainer;
		private inkTextWidgetReference _questTitle;
		private inkCompoundWidgetReference _objectiveContainer;
		private inkTextWidgetReference _trackedMappinTitle;
		private inkWidgetReference _trackedMappinContainer;
		private inkCompoundWidgetReference _trackedMappinObjectiveContainer;
		private wCHandle<gameObject> _player;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalQuestObjective> _bufferedEntry;
		private wCHandle<gameJournalQuestPhase> _bufferedPhase;
		private wCHandle<gameJournalQuest> _bufferedQuest;
		private wCHandle<inkWidget> _root;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_SystemDef> _uiSystemBB;
		private CHandle<redCallbackObject> _uiSystemId;
		private CHandle<redCallbackObject> _trackedMappinId;
		private wCHandle<inkAsyncSpawnRequest> _trackedMappinSpawnRequest;
		private wCHandle<gamemappinsIMappin> _currentMappin;

		[Ordinal(9)] 
		[RED("questTrackerContainer")] 
		public inkWidgetReference QuestTrackerContainer
		{
			get => GetProperty(ref _questTrackerContainer);
			set => SetProperty(ref _questTrackerContainer, value);
		}

		[Ordinal(10)] 
		[RED("QuestTitle")] 
		public inkTextWidgetReference QuestTitle
		{
			get => GetProperty(ref _questTitle);
			set => SetProperty(ref _questTitle, value);
		}

		[Ordinal(11)] 
		[RED("ObjectiveContainer")] 
		public inkCompoundWidgetReference ObjectiveContainer
		{
			get => GetProperty(ref _objectiveContainer);
			set => SetProperty(ref _objectiveContainer, value);
		}

		[Ordinal(12)] 
		[RED("TrackedMappinTitle")] 
		public inkTextWidgetReference TrackedMappinTitle
		{
			get => GetProperty(ref _trackedMappinTitle);
			set => SetProperty(ref _trackedMappinTitle, value);
		}

		[Ordinal(13)] 
		[RED("TrackedMappinContainer")] 
		public inkWidgetReference TrackedMappinContainer
		{
			get => GetProperty(ref _trackedMappinContainer);
			set => SetProperty(ref _trackedMappinContainer, value);
		}

		[Ordinal(14)] 
		[RED("TrackedMappinObjectiveContainer")] 
		public inkCompoundWidgetReference TrackedMappinObjectiveContainer
		{
			get => GetProperty(ref _trackedMappinObjectiveContainer);
			set => SetProperty(ref _trackedMappinObjectiveContainer, value);
		}

		[Ordinal(15)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(16)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		[Ordinal(17)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(18)] 
		[RED("bufferedEntry")] 
		public wCHandle<gameJournalQuestObjective> BufferedEntry
		{
			get => GetProperty(ref _bufferedEntry);
			set => SetProperty(ref _bufferedEntry, value);
		}

		[Ordinal(19)] 
		[RED("bufferedPhase")] 
		public wCHandle<gameJournalQuestPhase> BufferedPhase
		{
			get => GetProperty(ref _bufferedPhase);
			set => SetProperty(ref _bufferedPhase, value);
		}

		[Ordinal(20)] 
		[RED("bufferedQuest")] 
		public wCHandle<gameJournalQuest> BufferedQuest
		{
			get => GetProperty(ref _bufferedQuest);
			set => SetProperty(ref _bufferedQuest, value);
		}

		[Ordinal(21)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(22)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(23)] 
		[RED("uiSystemBB")] 
		public CHandle<UI_SystemDef> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(24)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		[Ordinal(25)] 
		[RED("trackedMappinId")] 
		public CHandle<redCallbackObject> TrackedMappinId
		{
			get => GetProperty(ref _trackedMappinId);
			set => SetProperty(ref _trackedMappinId, value);
		}

		[Ordinal(26)] 
		[RED("trackedMappinSpawnRequest")] 
		public wCHandle<inkAsyncSpawnRequest> TrackedMappinSpawnRequest
		{
			get => GetProperty(ref _trackedMappinSpawnRequest);
			set => SetProperty(ref _trackedMappinSpawnRequest, value);
		}

		[Ordinal(27)] 
		[RED("currentMappin")] 
		public wCHandle<gamemappinsIMappin> CurrentMappin
		{
			get => GetProperty(ref _currentMappin);
			set => SetProperty(ref _currentMappin, value);
		}

		public QuestTrackerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
