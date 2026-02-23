using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugPolyMesh : ISerializable
	{
		private CArray<Vector3> _vertices;
		private CArray<navgendebugCompactPolygon> _polygons;
		private Box _bounds;
		private CFloat _cellSize;
		private CFloat _cellHeight;
		private CInt32 _borderSize;
		private CFloat _maxEdgeError;
		private CInt32 _maxVerticesPerPolygon;

		[Ordinal(0)] 
		[RED("vertices")] 
		public CArray<Vector3> Vertices
		{
			get => GetProperty(ref _vertices);
			set => SetProperty(ref _vertices, value);
		}

		[Ordinal(1)] 
		[RED("polygons")] 
		public CArray<navgendebugCompactPolygon> Polygons
		{
			get => GetProperty(ref _polygons);
			set => SetProperty(ref _polygons, value);
		}

		[Ordinal(2)] 
		[RED("bounds")] 
		public Box Bounds
		{
			get => GetProperty(ref _bounds);
			set => SetProperty(ref _bounds, value);
		}

		[Ordinal(3)] 
		[RED("cellSize")] 
		public CFloat CellSize
		{
			get => GetProperty(ref _cellSize);
			set => SetProperty(ref _cellSize, value);
		}

		[Ordinal(4)] 
		[RED("cellHeight")] 
		public CFloat CellHeight
		{
			get => GetProperty(ref _cellHeight);
			set => SetProperty(ref _cellHeight, value);
		}

		[Ordinal(5)] 
		[RED("borderSize")] 
		public CInt32 BorderSize
		{
			get => GetProperty(ref _borderSize);
			set => SetProperty(ref _borderSize, value);
		}

		[Ordinal(6)] 
		[RED("maxEdgeError")] 
		public CFloat MaxEdgeError
		{
			get => GetProperty(ref _maxEdgeError);
			set => SetProperty(ref _maxEdgeError, value);
		}

		[Ordinal(7)] 
		[RED("maxVerticesPerPolygon")] 
		public CInt32 MaxVerticesPerPolygon
		{
			get => GetProperty(ref _maxVerticesPerPolygon);
			set => SetProperty(ref _maxVerticesPerPolygon, value);
		}

		public navgendebugPolyMesh(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
