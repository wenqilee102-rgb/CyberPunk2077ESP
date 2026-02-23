using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalChoiceEntryData : CVariable
	{
		private CHandle<gameJournalPath> _entryPath;

		[Ordinal(0)] 
		[RED("entryPath")] 
		public CHandle<gameJournalPath> EntryPath
		{
			get => GetProperty(ref _entryPath);
			set => SetProperty(ref _entryPath, value);
		}

		public gameJournalChoiceEntryData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
