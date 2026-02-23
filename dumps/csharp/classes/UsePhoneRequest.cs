using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UsePhoneRequest : gameScriptableSystemRequest
	{
		private wCHandle<gameJournalEntry> _messageToOpen;

		[Ordinal(0)] 
		[RED("MessageToOpen")] 
		public wCHandle<gameJournalEntry> MessageToOpen
		{
			get => GetProperty(ref _messageToOpen);
			set => SetProperty(ref _messageToOpen, value);
		}

		public UsePhoneRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
