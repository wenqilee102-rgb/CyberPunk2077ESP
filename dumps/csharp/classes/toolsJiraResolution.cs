using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraResolution : CVariable
	{
		private CString _name;
		private CString _id;

		[Ordinal(0)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		public toolsJiraResolution(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
