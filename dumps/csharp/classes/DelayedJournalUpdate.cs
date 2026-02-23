using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayedJournalUpdate : redEvent
	{
		private CBool _newMessageSpawned;
		private CBool _typing;
		private CFloat _delay;
		private CUInt32 _entryHash;
		private CInt32 _conversationHash;
		private CInt32 _contactHash;

		[Ordinal(0)] 
		[RED("newMessageSpawned")] 
		public CBool NewMessageSpawned
		{
			get => GetProperty(ref _newMessageSpawned);
			set => SetProperty(ref _newMessageSpawned, value);
		}

		[Ordinal(1)] 
		[RED("typing")] 
		public CBool Typing
		{
			get => GetProperty(ref _typing);
			set => SetProperty(ref _typing, value);
		}

		[Ordinal(2)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		[Ordinal(3)] 
		[RED("entryHash")] 
		public CUInt32 EntryHash
		{
			get => GetProperty(ref _entryHash);
			set => SetProperty(ref _entryHash, value);
		}

		[Ordinal(4)] 
		[RED("conversationHash")] 
		public CInt32 ConversationHash
		{
			get => GetProperty(ref _conversationHash);
			set => SetProperty(ref _conversationHash, value);
		}

		[Ordinal(5)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get => GetProperty(ref _contactHash);
			set => SetProperty(ref _contactHash, value);
		}

		public DelayedJournalUpdate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
