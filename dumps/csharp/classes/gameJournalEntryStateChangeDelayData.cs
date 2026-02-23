using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntryStateChangeDelayData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;
		private CName _entryType;
		private CEnum<gameJournalEntryState> _oldState;
		private CEnum<gameJournalEntryState> _newState;
		private CEnum<gameJournalNotifyOption> _notifyOption;
		private CEnum<gameJournalChangeType> _changeType;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetProperty(ref _entryPath);
			set => SetProperty(ref _entryPath, value);
		}

		[Ordinal(1)] 
		[RED("entryType")] 
		public CName EntryType
		{
			get => GetProperty(ref _entryType);
			set => SetProperty(ref _entryType, value);
		}

		[Ordinal(2)] 
		[RED("oldState")] 
		public CEnum<gameJournalEntryState> OldState
		{
			get => GetProperty(ref _oldState);
			set => SetProperty(ref _oldState, value);
		}

		[Ordinal(3)] 
		[RED("newState")] 
		public CEnum<gameJournalEntryState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		[Ordinal(4)] 
		[RED("notifyOption")] 
		public CEnum<gameJournalNotifyOption> NotifyOption
		{
			get => GetProperty(ref _notifyOption);
			set => SetProperty(ref _notifyOption, value);
		}

		[Ordinal(5)] 
		[RED("changeType")] 
		public CEnum<gameJournalChangeType> ChangeType
		{
			get => GetProperty(ref _changeType);
			set => SetProperty(ref _changeType, value);
		}

		[Ordinal(6)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public gameJournalEntryStateChangeDelayData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
