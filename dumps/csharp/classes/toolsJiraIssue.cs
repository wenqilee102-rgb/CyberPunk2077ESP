using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraIssue : CVariable
	{
		private CString _id;
		private CString _self;
		private CString _key;
		private toolsJiraIssueFields _fields;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("self")] 
		public CString Self
		{
			get => GetProperty(ref _self);
			set => SetProperty(ref _self, value);
		}

		[Ordinal(2)] 
		[RED("key")] 
		public CString Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(3)] 
		[RED("fields")] 
		public toolsJiraIssueFields Fields
		{
			get => GetProperty(ref _fields);
			set => SetProperty(ref _fields, value);
		}

		public toolsJiraIssue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
