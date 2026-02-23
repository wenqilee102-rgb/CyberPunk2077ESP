using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class toolsJiraProject : CVariable
	{
		private CString _key;
		private CString _name;

		[Ordinal(0)] 
		[RED("key")] 
		public CString Key
		{
			get => GetProperty(ref _key);
			set => SetProperty(ref _key, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		public toolsJiraProject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
