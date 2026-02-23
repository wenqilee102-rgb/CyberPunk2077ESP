using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraCreateIssueResult : ISerializable
	{
		private CString _id;
		private CString _key;
		private CArray<CString> _errorMessages;
		private toolsJiraIssueFieldsResult _errors;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("key")] 
		public CString Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(2)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetProperty(ref _errorMessages);
			set => SetProperty(ref _errorMessages, value);
		}

		[Ordinal(3)] 
		[RED("errors")] 
		public toolsJiraIssueFieldsResult Errors
		{
			get => GetProperty(ref _errors);
			set => SetProperty(ref _errors, value);
		}

		public toolsJiraCreateIssueResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
