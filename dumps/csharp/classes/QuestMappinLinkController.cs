using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMappinLinkController : BaseCodexLinkController
	{
		private CHandle<gameJournalQuestMapPinBase> _mappinEntry;
		private CHandle<gameJournalQuestMapPinBase> _mappinEntryHash;
		private Vector3 _jumpTo;
		private CInt32 _hash;
		private CBool _isTracked;

		[Ordinal(6)] 
		[RED("mappinEntry")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntry
		{
			get => GetProperty(ref _mappinEntry);
			set => SetProperty(ref _mappinEntry, value);
		}

		[Ordinal(7)] 
		[RED("mappinEntryHash")] 
		public CHandle<gameJournalQuestMapPinBase> MappinEntryHash
		{
			get => GetProperty(ref _mappinEntryHash);
			set => SetProperty(ref _mappinEntryHash, value);
		}

		[Ordinal(8)] 
		[RED("jumpTo")] 
		public Vector3 JumpTo
		{
			get => GetProperty(ref _jumpTo);
			set => SetProperty(ref _jumpTo, value);
		}

		[Ordinal(9)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(10)] 
		[RED("isTracked")] 
		public CBool IsTracked
		{
			get => GetProperty(ref _isTracked);
			set => SetProperty(ref _isTracked, value);
		}

		public QuestMappinLinkController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
