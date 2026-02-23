using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class attrMinMaxVector3 : attrAttribute
	{
		private Vector3 _n;
		private Vector3 _x;

		[Ordinal(0)] 
		[RED("n")] 
		public Vector3 N
		{
			get => GetProperty(ref _n);
			set => SetProperty(ref _n, value);
		}

		[Ordinal(1)] 
		[RED("x")] 
		public Vector3 X
		{
			get => GetProperty(ref _x);
			set => SetProperty(ref _x, value);
		}

		public attrMinMaxVector3(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
