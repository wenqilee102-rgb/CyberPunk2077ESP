using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalNotificationData : inkGameNotificationData
	{
		private wCHandle<gameJournalEntry> _journalEntry;
		private CEnum<gameJournalEntryState> _journalEntryState;
		private CName _className;
		private CEnum<JournalNotificationMode> _mode;
		private CEnum<MessengerContactType> _type;
		private CName _contactNameLocKey;
		private CBool _openedFromPhone;
		private CEnum<PhoneScreenType> _source;

		[Ordinal(7)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(8)] 
		[RED("journalEntryState")] 
		public CEnum<gameJournalEntryState> JournalEntryState
		{
			get => GetProperty(ref _journalEntryState);
			set => SetProperty(ref _journalEntryState, value);
		}

		[Ordinal(9)] 
		[RED("className")] 
		public CName ClassName
		{
			get => GetProperty(ref _className);
			set => SetProperty(ref _className, value);
		}

		[Ordinal(10)] 
		[RED("mode")] 
		public CEnum<JournalNotificationMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(12)] 
		[RED("contactNameLocKey")] 
		public CName ContactNameLocKey
		{
			get => GetProperty(ref _contactNameLocKey);
			set => SetProperty(ref _contactNameLocKey, value);
		}

		[Ordinal(13)] 
		[RED("openedFromPhone")] 
		public CBool OpenedFromPhone
		{
			get => GetProperty(ref _openedFromPhone);
			set => SetProperty(ref _openedFromPhone, value);
		}

		[Ordinal(14)] 
		[RED("source")] 
		public CEnum<PhoneScreenType> Source
		{
			get => GetProperty(ref _source);
			set => SetProperty(ref _source, value);
		}

		public JournalNotificationData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
