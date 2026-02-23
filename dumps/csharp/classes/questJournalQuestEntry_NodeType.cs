using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalQuestEntry_NodeType : questIJournal_NodeType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _sendNotification;
		private CBool _trackQuest;
		private CBool _optional;
		private CEnum<questJournalQuestEntry_NodeTypeNodeVersion> _version;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("sendNotification")] 
		public CBool SendNotification
		{
			get => GetProperty(ref _sendNotification);
			set => SetProperty(ref _sendNotification, value);
		}

		[Ordinal(2)] 
		[RED("trackQuest")] 
		public CBool TrackQuest
		{
			get => GetProperty(ref _trackQuest);
			set => SetProperty(ref _trackQuest, value);
		}

		[Ordinal(3)] 
		[RED("optional")] 
		public CBool Optional
		{
			get => GetProperty(ref _optional);
			set => SetProperty(ref _optional, value);
		}

		[Ordinal(4)] 
		[RED("version")] 
		public CEnum<questJournalQuestEntry_NodeTypeNodeVersion> Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public questJournalQuestEntry_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
