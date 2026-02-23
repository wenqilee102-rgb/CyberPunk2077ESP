using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugInputGeometry : CVariable
	{
		private CArray<navgendebugInputGeometryTriangle> _triangles;
		private Box _tileBoundingBox;
		private Box _extrudedBoundingBox;

		[Ordinal(0)] 
		[RED("triangles")] 
		public CArray<navgendebugInputGeometryTriangle> Triangles
		{
			get => GetProperty(ref _triangles);
			set => SetProperty(ref _triangles, value);
		}

		[Ordinal(1)] 
		[RED("tileBoundingBox")] 
		public Box TileBoundingBox
		{
			get => GetProperty(ref _tileBoundingBox);
			set => SetProperty(ref _tileBoundingBox, value);
		}

		[Ordinal(2)] 
		[RED("extrudedBoundingBox")] 
		public Box ExtrudedBoundingBox
		{
			get => GetProperty(ref _extrudedBoundingBox);
			set => SetProperty(ref _extrudedBoundingBox, value);
		}

		public navgendebugInputGeometry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
