using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexGroup : gameJournalContainerEntry
	{
		private LocalizationString _groupName;
		private CBool _isSorted;

		[Ordinal(3)] 
		[RED("groupName")] 
		public LocalizationString GroupName
		{
			get => GetProperty(ref _groupName);
			set => SetProperty(ref _groupName, value);
		}

		[Ordinal(4)] 
		[RED("isSorted")] 
		public CBool IsSorted
		{
			get => GetProperty(ref _isSorted);
			set => SetProperty(ref _isSorted, value);
		}

		public gameJournalCodexGroup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
