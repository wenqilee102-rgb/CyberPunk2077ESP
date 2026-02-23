using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraEditIssueResult : ISerializable
	{
		private CArray<CString> _errorMessages;
		private toolsJiraIssueFieldsResult _errors;

		[Ordinal(0)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetProperty(ref _errorMessages);
			set => SetProperty(ref _errorMessages, value);
		}

		[Ordinal(1)] 
		[RED("errors")] 
		public toolsJiraIssueFieldsResult Errors
		{
			get => GetProperty(ref _errors);
			set => SetProperty(ref _errors, value);
		}

		public toolsJiraEditIssueResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
