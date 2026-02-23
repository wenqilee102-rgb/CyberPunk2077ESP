using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugInputGeometryTriangle : CVariable
	{
		private CArrayFixedSize<Vector3> _vertices;
		private CUInt8 _area;

		[Ordinal(0)] 
		[RED("vertices", 3)] 
		public CArrayFixedSize<Vector3> Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}

		[Ordinal(1)] 
		[RED("area")] 
		public CUInt8 Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		public navgendebugInputGeometryTriangle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
