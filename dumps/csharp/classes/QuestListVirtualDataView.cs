using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestListVirtualDataView : inkScriptableDataViewWrapper
	{
		private CEnum<QuestListItemType> _filterType;
		private CHandle<CompareBuilder> _compareBuilder;
		private CEnum<QuestListSortType> _currentQuestSortType;

		[Ordinal(0)] 
		[RED("filterType")] 
		public CEnum<QuestListItemType> FilterType
		{
			get => GetProperty(ref _filterType);
			set => SetProperty(ref _filterType, value);
		}

		[Ordinal(1)] 
		[RED("compareBuilder")] 
		public CHandle<CompareBuilder> CompareBuilder
		{
			get => GetProperty(ref _compareBuilder);
			set => SetProperty(ref _compareBuilder, value);
		}

		[Ordinal(2)] 
		[RED("currentQuestSortType")] 
		public CEnum<QuestListSortType> CurrentQuestSortType
		{
			get => GetProperty(ref _currentQuestSortType);
			set => SetProperty(ref _currentQuestSortType, value);
		}

		public QuestListVirtualDataView(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
