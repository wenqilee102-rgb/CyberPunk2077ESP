using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class attrToggleBtn : attrAttribute
	{
		private CString _nLabel;

		[Ordinal(0)] 
		[RED("nLabel")] 
		public CString NLabel
		{
			get => GetProperty(ref _nLabel);
			set => SetProperty(ref _nLabel, value);
		}

		public attrToggleBtn(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
