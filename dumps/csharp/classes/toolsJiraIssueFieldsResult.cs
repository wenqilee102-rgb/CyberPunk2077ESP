using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraIssueFieldsResult : CVariable
	{
		private CString _project;
		private CString _summary;
		private CString _issuetype;
		private CString _priority;
		private CString _labels;
		private CString _assignee;
		private CString _description;
		private CString _versions;
		private CString _fixVersions;
		private CString _flagPosition;
		private CString _components;
		private CArray<toolsJiraAttachment> _attachments;
		private CString _customfield_17400;
		private CString _customfield_18373;
		private CString _customfield_34100;
		private CString _customfield_15306;
		private CString _customfield_13009;
		private CString _customfield_10013;
		private CString _customfield_10503;
		private CString _customfield_10502;
		private CString _customfield_34718;
		private CString _customfield_36106;
		private CString _customfield_10006;
		private CString _customfield_10505;
		private CString _customfield_10603;
		private CString _customfield_24700;
		private CString _customfield_34706;
		private CString _customfield_25500;
		private CString _customfield_15808;
		private CString _customfield_33701;
		private CString _customfield_18006;
		private CString _customfield_29900;
		private CString _customfield_10005;
		private CString _customfield_10606;
		private CString _customfield_10002;

		[Ordinal(0)] 
		[RED("project")] 
		public CString Project
		{
			get => GetProperty(ref _project);
			set => SetProperty(ref _project, value);
		}

		[Ordinal(1)] 
		[RED("summary")] 
		public CString Summary
		{
			get => GetProperty(ref _summary);
			set => SetProperty(ref _summary, value);
		}

		[Ordinal(2)] 
		[RED("issuetype")] 
		public CString Issuetype
		{
			get => GetProperty(ref _issuetype);
			set => SetProperty(ref _issuetype, value);
		}

		[Ordinal(3)] 
		[RED("priority")] 
		public CString Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(4)] 
		[RED("labels")] 
		public CString Labels
		{
			get => GetProperty(ref _labels);
			set => SetProperty(ref _labels, value);
		}

		[Ordinal(5)] 
		[RED("assignee")] 
		public CString Assignee
		{
			get => GetProperty(ref _assignee);
			set => SetProperty(ref _assignee, value);
		}

		[Ordinal(6)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(7)] 
		[RED("versions")] 
		public CString Versions
		{
			get => GetProperty(ref _versions);
			set => SetProperty(ref _versions, value);
		}

		[Ordinal(8)] 
		[RED("fixVersions")] 
		public CString FixVersions
		{
			get => GetProperty(ref _fixVersions);
			set => SetProperty(ref _fixVersions, value);
		}

		[Ordinal(9)] 
		[RED("flagPosition")] 
		public CString FlagPosition
		{
			get => GetProperty(ref _flagPosition);
			set => SetProperty(ref _flagPosition, value);
		}

		[Ordinal(10)] 
		[RED("components")] 
		public CString Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		[Ordinal(11)] 
		[RED("attachments")] 
		public CArray<toolsJiraAttachment> Attachments
		{
			get => GetProperty(ref _attachments);
			set => SetProperty(ref _attachments, value);
		}

		[Ordinal(12)] 
		[RED("customfield_17400")] 
		public CString Customfield_17400
		{
			get => GetProperty(ref _customfield_17400);
			set => SetProperty(ref _customfield_17400, value);
		}

		[Ordinal(13)] 
		[RED("customfield_18373")] 
		public CString Customfield_18373
		{
			get => GetProperty(ref _customfield_18373);
			set => SetProperty(ref _customfield_18373, value);
		}

		[Ordinal(14)] 
		[RED("customfield_34100")] 
		public CString Customfield_34100
		{
			get => GetProperty(ref _customfield_34100);
			set => SetProperty(ref _customfield_34100, value);
		}

		[Ordinal(15)] 
		[RED("customfield_15306")] 
		public CString Customfield_15306
		{
			get => GetProperty(ref _customfield_15306);
			set => SetProperty(ref _customfield_15306, value);
		}

		[Ordinal(16)] 
		[RED("customfield_13009")] 
		public CString Customfield_13009
		{
			get => GetProperty(ref _customfield_13009);
			set => SetProperty(ref _customfield_13009, value);
		}

		[Ordinal(17)] 
		[RED("customfield_10013")] 
		public CString Customfield_10013
		{
			get => GetProperty(ref _customfield_10013);
			set => SetProperty(ref _customfield_10013, value);
		}

		[Ordinal(18)] 
		[RED("customfield_10503")] 
		public CString Customfield_10503
		{
			get => GetProperty(ref _customfield_10503);
			set => SetProperty(ref _customfield_10503, value);
		}

		[Ordinal(19)] 
		[RED("customfield_10502")] 
		public CString Customfield_10502
		{
			get => GetProperty(ref _customfield_10502);
			set => SetProperty(ref _customfield_10502, value);
		}

		[Ordinal(20)] 
		[RED("customfield_34718")] 
		public CString Customfield_34718
		{
			get => GetProperty(ref _customfield_34718);
			set => SetProperty(ref _customfield_34718, value);
		}

		[Ordinal(21)] 
		[RED("customfield_36106")] 
		public CString Customfield_36106
		{
			get => GetProperty(ref _customfield_36106);
			set => SetProperty(ref _customfield_36106, value);
		}

		[Ordinal(22)] 
		[RED("customfield_10006")] 
		public CString Customfield_10006
		{
			get => GetProperty(ref _customfield_10006);
			set => SetProperty(ref _customfield_10006, value);
		}

		[Ordinal(23)] 
		[RED("customfield_10505")] 
		public CString Customfield_10505
		{
			get => GetProperty(ref _customfield_10505);
			set => SetProperty(ref _customfield_10505, value);
		}

		[Ordinal(24)] 
		[RED("customfield_10603")] 
		public CString Customfield_10603
		{
			get => GetProperty(ref _customfield_10603);
			set => SetProperty(ref _customfield_10603, value);
		}

		[Ordinal(25)] 
		[RED("customfield_24700")] 
		public CString Customfield_24700
		{
			get => GetProperty(ref _customfield_24700);
			set => SetProperty(ref _customfield_24700, value);
		}

		[Ordinal(26)] 
		[RED("customfield_34706")] 
		public CString Customfield_34706
		{
			get => GetProperty(ref _customfield_34706);
			set => SetProperty(ref _customfield_34706, value);
		}

		[Ordinal(27)] 
		[RED("customfield_25500")] 
		public CString Customfield_25500
		{
			get => GetProperty(ref _customfield_25500);
			set => SetProperty(ref _customfield_25500, value);
		}

		[Ordinal(28)] 
		[RED("customfield_15808")] 
		public CString Customfield_15808
		{
			get => GetProperty(ref _customfield_15808);
			set => SetProperty(ref _customfield_15808, value);
		}

		[Ordinal(29)] 
		[RED("customfield_33701")] 
		public CString Customfield_33701
		{
			get => GetProperty(ref _customfield_33701);
			set => SetProperty(ref _customfield_33701, value);
		}

		[Ordinal(30)] 
		[RED("customfield_18006")] 
		public CString Customfield_18006
		{
			get => GetProperty(ref _customfield_18006);
			set => SetProperty(ref _customfield_18006, value);
		}

		[Ordinal(31)] 
		[RED("customfield_29900")] 
		public CString Customfield_29900
		{
			get => GetProperty(ref _customfield_29900);
			set => SetProperty(ref _customfield_29900, value);
		}

		[Ordinal(32)] 
		[RED("customfield_10005")] 
		public CString Customfield_10005
		{
			get => GetProperty(ref _customfield_10005);
			set => SetProperty(ref _customfield_10005, value);
		}

		[Ordinal(33)] 
		[RED("customfield_10606")] 
		public CString Customfield_10606
		{
			get => GetProperty(ref _customfield_10606);
			set => SetProperty(ref _customfield_10606, value);
		}

		[Ordinal(34)] 
		[RED("customfield_10002")] 
		public CString Customfield_10002
		{
			get => GetProperty(ref _customfield_10002);
			set => SetProperty(ref _customfield_10002, value);
		}

		public toolsJiraIssueFieldsResult(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
