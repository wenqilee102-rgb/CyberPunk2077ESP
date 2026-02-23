using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraSearchIssuesResult : ISerializable
	{
		private CUInt32 _startAt;
		private CUInt32 _maxResults;
		private CUInt32 _total;
		private CArray<toolsJiraIssue> _issues;
		private CArray<CString> _errorMessages;
		private CArray<CString> _warningMessages;

		[Ordinal(0)] 
		[RED("startAt")] 
		public CUInt32 StartAt
		{
			get => GetProperty(ref _startAt);
			set => SetProperty(ref _startAt, value);
		}

		[Ordinal(1)] 
		[RED("maxResults")] 
		public CUInt32 MaxResults
		{
			get => GetProperty(ref _maxResults);
			set => SetProperty(ref _maxResults, value);
		}

		[Ordinal(2)] 
		[RED("total")] 
		public CUInt32 Total
		{
			get => GetProperty(ref _total);
			set => SetProperty(ref _total, value);
		}

		[Ordinal(3)] 
		[RED("issues")] 
		public CArray<toolsJiraIssue> Issues
		{
			get => GetProperty(ref _issues);
			set => SetProperty(ref _issues, value);
		}

		[Ordinal(4)] 
		[RED("errorMessages")] 
		public CArray<CString> ErrorMessages
		{
			get => GetProperty(ref _errorMessages);
			set => SetProperty(ref _errorMessages, value);
		}

		[Ordinal(5)] 
		[RED("warningMessages")] 
		public CArray<CString> WarningMessages
		{
			get => GetProperty(ref _warningMessages);
			set => SetProperty(ref _warningMessages, value);
		}

		public toolsJiraSearchIssuesResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
