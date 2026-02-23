using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMissionLinkController : BaseCodexLinkController
	{
		private inkWidgetReference _linkContainer;
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _description;
		private inkImageWidgetReference _icon;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalQuest> _questEntry;
		private CEnum<gameJournalEntryState> _questState;
		private CInt32 _questEntryHash;

		[Ordinal(6)] 
		[RED("linkContainer")] 
		public inkWidgetReference LinkContainer
		{
			get => GetProperty(ref _linkContainer);
			set => SetProperty(ref _linkContainer, value);
		}

		[Ordinal(7)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(9)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(11)] 
		[RED("questEntry")] 
		public wCHandle<gameJournalQuest> QuestEntry
		{
			get => GetProperty(ref _questEntry);
			set => SetProperty(ref _questEntry, value);
		}

		[Ordinal(12)] 
		[RED("questState")] 
		public CEnum<gameJournalEntryState> QuestState
		{
			get => GetProperty(ref _questState);
			set => SetProperty(ref _questState, value);
		}

		[Ordinal(13)] 
		[RED("questEntryHash")] 
		public CInt32 QuestEntryHash
		{
			get => GetProperty(ref _questEntryHash);
			set => SetProperty(ref _questEntryHash, value);
		}

		public QuestMissionLinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
