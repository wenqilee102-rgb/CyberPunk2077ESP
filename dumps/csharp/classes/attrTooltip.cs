using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class attrTooltip : attrAttribute
	{
		private CString _xt;

		[Ordinal(0)] 
		[RED("xt")] 
		public CString Xt
		{
			get => GetProperty(ref _xt);
			set => SetProperty(ref _xt, value);
		}

		public attrTooltip(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
