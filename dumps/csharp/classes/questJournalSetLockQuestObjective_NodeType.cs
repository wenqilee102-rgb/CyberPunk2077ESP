using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalSetLockQuestObjective_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _lock;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("lock")] 
		public CBool Lock
		{
			get => GetProperty(ref _lock);
			set => SetProperty(ref _lock, value);
		}

		public questJournalSetLockQuestObjective_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
