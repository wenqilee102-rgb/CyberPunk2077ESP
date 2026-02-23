using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraIssueFields : CVariable
	{
		private toolsJiraProject _project;
		private toolsJiraStatus _status;
		private toolsJiraResolution _resolution;
		private CString _summary;
		private toolsJiraIssueType _issuetype;
		private toolsJiraPriority _priority;
		private CArray<CString> _labels;
		private toolsJiraCustomFieldName _assignee;
		private CString _description;
		private CArray<toolsJiraCustomFieldId> _versions;
		private CArray<toolsJiraFixVersion> _fixVersions;
		private CString _flagPosition;
		private CArray<toolsJiraCustomFieldName> _components;
		private CArray<toolsJiraAttachment> _attachment;
		private toolsJiraCustomFieldId _customfield_17400;
		private CString _customfield_18373;
		private toolsJiraCustomFieldValue _customfield_34100;
		private CArray<toolsJiraCustomFieldValue> _customfield_15306;
		private CString _customfield_13009;
		private CString _customfield_10013;
		private CString _customfield_10503;
		private CString _customfield_10502;
		private CArray<toolsJiraCustomFieldValue> _customfield_34718;
		private CArray<toolsJiraCustomFieldValue> _customfield_36106;
		private CString _customfield_10006;
		private toolsJiraCustomFieldValue _customfield_10505;
		private CArray<toolsJiraCustomFieldValue> _customfield_10603;
		private CString _customfield_24700;
		private CArray<toolsJiraCustomFieldValue> _customfield_34706;
		private toolsJiraCustomFieldValue _customfield_25500;
		private CArray<toolsJiraCustomFieldValue> _customfield_15808;
		private CString _customfield_33701;
		private CString _customfield_18006;
		private toolsJiraCustomFieldValue _customfield_29900;
		private CString _customfield_10005;
		private CString _customfield_10606;
		private CString _customfield_31700;

		[Ordinal(0)] 
		[RED("project")] 
		public toolsJiraProject Project
		{
			get => GetProperty(ref _project);
			set => SetProperty(ref _project, value);
		}

		[Ordinal(1)] 
		[RED("status")] 
		public toolsJiraStatus Status
		{
			get => GetProperty(ref _status);
			set => SetProperty(ref _status, value);
		}

		[Ordinal(2)] 
		[RED("resolution")] 
		public toolsJiraResolution Resolution
		{
			get => GetProperty(ref _resolution);
			set => SetProperty(ref _resolution, value);
		}

		[Ordinal(3)] 
		[RED("summary")] 
		public CString Summary
		{
			get => GetProperty(ref _summary);
			set => SetProperty(ref _summary, value);
		}

		[Ordinal(4)] 
		[RED("issuetype")] 
		public toolsJiraIssueType Issuetype
		{
			get => GetProperty(ref _issuetype);
			set => SetProperty(ref _issuetype, value);
		}

		[Ordinal(5)] 
		[RED("priority")] 
		public toolsJiraPriority Priority
		{
			get => GetProperty(ref _priority);
			set => SetProperty(ref _priority, value);
		}

		[Ordinal(6)] 
		[RED("labels")] 
		public CArray<CString> Labels
		{
			get => GetProperty(ref _labels);
			set => SetProperty(ref _labels, value);
		}

		[Ordinal(7)] 
		[RED("assignee")] 
		public toolsJiraCustomFieldName Assignee
		{
			get => GetProperty(ref _assignee);
			set => SetProperty(ref _assignee, value);
		}

		[Ordinal(8)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(9)] 
		[RED("versions")] 
		public CArray<toolsJiraCustomFieldId> Versions
		{
			get => GetProperty(ref _versions);
			set => SetProperty(ref _versions, value);
		}

		[Ordinal(10)] 
		[RED("fixVersions")] 
		public CArray<toolsJiraFixVersion> FixVersions
		{
			get => GetProperty(ref _fixVersions);
			set => SetProperty(ref _fixVersions, value);
		}

		[Ordinal(11)] 
		[RED("flagPosition")] 
		public CString FlagPosition
		{
			get => GetProperty(ref _flagPosition);
			set => SetProperty(ref _flagPosition, value);
		}

		[Ordinal(12)] 
		[RED("components")] 
		public CArray<toolsJiraCustomFieldName> Components
		{
			get => GetProperty(ref _components);
			set => SetProperty(ref _components, value);
		}

		[Ordinal(13)] 
		[RED("attachment")] 
		public CArray<toolsJiraAttachment> Attachment
		{
			get => GetProperty(ref _attachment);
			set => SetProperty(ref _attachment, value);
		}

		[Ordinal(14)] 
		[RED("customfield_17400")] 
		public toolsJiraCustomFieldId Customfield_17400
		{
			get => GetProperty(ref _customfield_17400);
			set => SetProperty(ref _customfield_17400, value);
		}

		[Ordinal(15)] 
		[RED("customfield_18373")] 
		public CString Customfield_18373
		{
			get => GetProperty(ref _customfield_18373);
			set => SetProperty(ref _customfield_18373, value);
		}

		[Ordinal(16)] 
		[RED("customfield_34100")] 
		public toolsJiraCustomFieldValue Customfield_34100
		{
			get => GetProperty(ref _customfield_34100);
			set => SetProperty(ref _customfield_34100, value);
		}

		[Ordinal(17)] 
		[RED("customfield_15306")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_15306
		{
			get => GetProperty(ref _customfield_15306);
			set => SetProperty(ref _customfield_15306, value);
		}

		[Ordinal(18)] 
		[RED("customfield_13009")] 
		public CString Customfield_13009
		{
			get => GetProperty(ref _customfield_13009);
			set => SetProperty(ref _customfield_13009, value);
		}

		[Ordinal(19)] 
		[RED("customfield_10013")] 
		public CString Customfield_10013
		{
			get => GetProperty(ref _customfield_10013);
			set => SetProperty(ref _customfield_10013, value);
		}

		[Ordinal(20)] 
		[RED("customfield_10503")] 
		public CString Customfield_10503
		{
			get => GetProperty(ref _customfield_10503);
			set => SetProperty(ref _customfield_10503, value);
		}

		[Ordinal(21)] 
		[RED("customfield_10502")] 
		public CString Customfield_10502
		{
			get => GetProperty(ref _customfield_10502);
			set => SetProperty(ref _customfield_10502, value);
		}

		[Ordinal(22)] 
		[RED("customfield_34718")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_34718
		{
			get => GetProperty(ref _customfield_34718);
			set => SetProperty(ref _customfield_34718, value);
		}

		[Ordinal(23)] 
		[RED("customfield_36106")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_36106
		{
			get => GetProperty(ref _customfield_36106);
			set => SetProperty(ref _customfield_36106, value);
		}

		[Ordinal(24)] 
		[RED("customfield_10006")] 
		public CString Customfield_10006
		{
			get => GetProperty(ref _customfield_10006);
			set => SetProperty(ref _customfield_10006, value);
		}

		[Ordinal(25)] 
		[RED("customfield_10505")] 
		public toolsJiraCustomFieldValue Customfield_10505
		{
			get => GetProperty(ref _customfield_10505);
			set => SetProperty(ref _customfield_10505, value);
		}

		[Ordinal(26)] 
		[RED("customfield_10603")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_10603
		{
			get => GetProperty(ref _customfield_10603);
			set => SetProperty(ref _customfield_10603, value);
		}

		[Ordinal(27)] 
		[RED("customfield_24700")] 
		public CString Customfield_24700
		{
			get => GetProperty(ref _customfield_24700);
			set => SetProperty(ref _customfield_24700, value);
		}

		[Ordinal(28)] 
		[RED("customfield_34706")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_34706
		{
			get => GetProperty(ref _customfield_34706);
			set => SetProperty(ref _customfield_34706, value);
		}

		[Ordinal(29)] 
		[RED("customfield_25500")] 
		public toolsJiraCustomFieldValue Customfield_25500
		{
			get => GetProperty(ref _customfield_25500);
			set => SetProperty(ref _customfield_25500, value);
		}

		[Ordinal(30)] 
		[RED("customfield_15808")] 
		public CArray<toolsJiraCustomFieldValue> Customfield_15808
		{
			get => GetProperty(ref _customfield_15808);
			set => SetProperty(ref _customfield_15808, value);
		}

		[Ordinal(31)] 
		[RED("customfield_33701")] 
		public CString Customfield_33701
		{
			get => GetProperty(ref _customfield_33701);
			set => SetProperty(ref _customfield_33701, value);
		}

		[Ordinal(32)] 
		[RED("customfield_18006")] 
		public CString Customfield_18006
		{
			get => GetProperty(ref _customfield_18006);
			set => SetProperty(ref _customfield_18006, value);
		}

		[Ordinal(33)] 
		[RED("customfield_29900")] 
		public toolsJiraCustomFieldValue Customfield_29900
		{
			get => GetProperty(ref _customfield_29900);
			set => SetProperty(ref _customfield_29900, value);
		}

		[Ordinal(34)] 
		[RED("customfield_10005")] 
		public CString Customfield_10005
		{
			get => GetProperty(ref _customfield_10005);
			set => SetProperty(ref _customfield_10005, value);
		}

		[Ordinal(35)] 
		[RED("customfield_10606")] 
		public CString Customfield_10606
		{
			get => GetProperty(ref _customfield_10606);
			set => SetProperty(ref _customfield_10606, value);
		}

		[Ordinal(36)] 
		[RED("customfield_31700")] 
		public CString Customfield_31700
		{
			get => GetProperty(ref _customfield_31700);
			set => SetProperty(ref _customfield_31700, value);
		}

		public toolsJiraIssueFields(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
