using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class attrIcon : attrAttribute
	{
		private CString _onName;

		[Ordinal(0)] 
		[RED("onName")] 
		public CString OnName
		{
			get => GetProperty(ref _onName);
			set => SetProperty(ref _onName, value);
		}

		public attrIcon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
