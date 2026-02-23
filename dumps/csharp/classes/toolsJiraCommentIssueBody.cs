using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraCommentIssueBody : ISerializable
	{
		private CString _body;

		[Ordinal(0)] 
		[RED("body")] 
		public CString Body
		{
			get => GetProperty(ref _body);
			set => SetProperty(ref _body, value);
		}

		public toolsJiraCommentIssueBody(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
