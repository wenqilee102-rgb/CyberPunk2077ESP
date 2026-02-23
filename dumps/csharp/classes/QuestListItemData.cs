using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListItemData : IScriptable
	{
		private CEnum<QuestListItemType> _questType;
		private GameTime _lastUpdateTimestamp;
		private CBool _isTrackedQuest;
		private CBool _isOpenedQuest;
		private wCHandle<gameJournalQuest> _questData;
		private wCHandle<gameJournalManager> _journalManager;
		private CInt32 _playerLevel;
		private CInt32 _recommendedLevel;
		private CEnum<gameJournalEntryState> _state;
		private CFloat _distance;
		private CBool _distancesFetched;
		private CArray<CHandle<QuestListDistanceData>> _objectivesDistances;

		[Ordinal(0)] 
		[RED("questType")] 
		public CEnum<QuestListItemType> QuestType
		{
			get => GetProperty(ref _questType);
			set => SetProperty(ref _questType, value);
		}

		[Ordinal(1)] 
		[RED("lastUpdateTimestamp")] 
		public GameTime LastUpdateTimestamp
		{
			get => GetProperty(ref _lastUpdateTimestamp);
			set => SetProperty(ref _lastUpdateTimestamp, value);
		}

		[Ordinal(2)] 
		[RED("isTrackedQuest")] 
		public CBool IsTrackedQuest
		{
			get => GetProperty(ref _isTrackedQuest);
			set => SetProperty(ref _isTrackedQuest, value);
		}

		[Ordinal(3)] 
		[RED("isOpenedQuest")] 
		public CBool IsOpenedQuest
		{
			get => GetProperty(ref _isOpenedQuest);
			set => SetProperty(ref _isOpenedQuest, value);
		}

		[Ordinal(4)] 
		[RED("questData")] 
		public wCHandle<gameJournalQuest> QuestData
		{
			get => GetProperty(ref _questData);
			set => SetProperty(ref _questData, value);
		}

		[Ordinal(5)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(6)] 
		[RED("playerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(7)] 
		[RED("recommendedLevel")] 
		public CInt32 RecommendedLevel
		{
			get => GetProperty(ref _recommendedLevel);
			set => SetProperty(ref _recommendedLevel, value);
		}

		[Ordinal(8)] 
		[RED("State")] 
		public CEnum<gameJournalEntryState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(9)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(10)] 
		[RED("distancesFetched")] 
		public CBool DistancesFetched
		{
			get => GetProperty(ref _distancesFetched);
			set => SetProperty(ref _distancesFetched, value);
		}

		[Ordinal(11)] 
		[RED("objectivesDistances")] 
		public CArray<CHandle<QuestListDistanceData>> ObjectivesDistances
		{
			get => GetProperty(ref _objectivesDistances);
			set => SetProperty(ref _objectivesDistances, value);
		}

		public QuestListItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
