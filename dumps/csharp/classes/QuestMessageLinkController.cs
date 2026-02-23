using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMessageLinkController : BaseCodexLinkController
	{
		private CHandle<gameJournalContact> _contactEntry;
		private CHandle<gameJournalPhoneMessage> _messageEntry;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameJournalEntry> _childEntry;
		private CHandle<gameJournalPhoneConversation> _conversation;
		private wCHandle<PhoneSystem> _phoneSystem;

		[Ordinal(6)] 
		[RED("contactEntry")] 
		public CHandle<gameJournalContact> ContactEntry
		{
			get => GetProperty(ref _contactEntry);
			set => SetProperty(ref _contactEntry, value);
		}

		[Ordinal(7)] 
		[RED("messageEntry")] 
		public CHandle<gameJournalPhoneMessage> MessageEntry
		{
			get => GetProperty(ref _messageEntry);
			set => SetProperty(ref _messageEntry, value);
		}

		[Ordinal(8)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(9)] 
		[RED("childEntry")] 
		public wCHandle<gameJournalEntry> ChildEntry
		{
			get => GetProperty(ref _childEntry);
			set => SetProperty(ref _childEntry, value);
		}

		[Ordinal(10)] 
		[RED("conversation")] 
		public CHandle<gameJournalPhoneConversation> Conversation
		{
			get => GetProperty(ref _conversation);
			set => SetProperty(ref _conversation, value);
		}

		[Ordinal(11)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		public QuestMessageLinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
