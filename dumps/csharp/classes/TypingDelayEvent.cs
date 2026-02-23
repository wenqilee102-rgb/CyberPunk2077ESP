using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TypingDelayEvent : redEvent
	{
		private CInt32 _conversationHash;
		private CInt32 _contactHash;

		[Ordinal(0)] 
		[RED("conversationHash")] 
		public CInt32 ConversationHash
		{
			get => GetProperty(ref _conversationHash);
			set => SetProperty(ref _conversationHash, value);
		}

		[Ordinal(1)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get => GetProperty(ref _contactHash);
			set => SetProperty(ref _contactHash, value);
		}

		public TypingDelayEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
