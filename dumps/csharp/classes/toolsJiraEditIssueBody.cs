using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraEditIssueBody : ISerializable
	{
		private toolsJiraIssueFields _fields;

		[Ordinal(0)] 
		[RED("fields")] 
		public toolsJiraIssueFields Fields
		{
			get => GetProperty(ref _fields);
			set => SetProperty(ref _fields, value);
		}

		public toolsJiraEditIssueBody(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
