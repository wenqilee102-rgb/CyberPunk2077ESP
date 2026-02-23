using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestShardLinkController : BaseCodexLinkController
	{
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalOnscreen> _journalEntry;

		[Ordinal(6)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(7)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalOnscreen> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		public QuestShardLinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
