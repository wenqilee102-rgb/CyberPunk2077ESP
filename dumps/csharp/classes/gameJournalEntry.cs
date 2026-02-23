using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalEntry : IScriptable
	{
		private CString _id;
		private CArray<gameJournalEntryOverrideData> _journalEntryOverrideDataList;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("journalEntryOverrideDataList")] 
		public CArray<gameJournalEntryOverrideData> JournalEntryOverrideDataList
		{
			get => GetProperty(ref _journalEntryOverrideDataList);
			set => SetProperty(ref _journalEntryOverrideDataList, value);
		}

		public gameJournalEntry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
