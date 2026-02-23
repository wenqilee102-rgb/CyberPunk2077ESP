using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gsmMainQuest : ISerializable
	{
		private raRef<questQuestResource> _questFile;
		private CBool _additionalContent;
		private CName _additionalContentName;

		[Ordinal(0)] 
		[RED("questFile")] 
		public raRef<questQuestResource> QuestFile
		{
			get => GetProperty(ref _questFile);
			set => SetProperty(ref _questFile, value);
		}

		[Ordinal(1)] 
		[RED("additionalContent")] 
		public CBool AdditionalContent
		{
			get => GetProperty(ref _additionalContent);
			set => SetProperty(ref _additionalContent, value);
		}

		[Ordinal(2)] 
		[RED("additionalContentName")] 
		public CName AdditionalContentName
		{
			get => GetProperty(ref _additionalContentName);
			set => SetProperty(ref _additionalContentName, value);
		}

		public gsmMainQuest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
