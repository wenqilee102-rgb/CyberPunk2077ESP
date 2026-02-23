using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class attrChoice : attrAttribute
	{
		private CArray<CString> _tions;

		[Ordinal(0)] 
		[RED("tions")] 
		public CArray<CString> Tions
		{
			get => GetProperty(ref _tions);
			set => SetProperty(ref _tions, value);
		}

		public attrChoice(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
