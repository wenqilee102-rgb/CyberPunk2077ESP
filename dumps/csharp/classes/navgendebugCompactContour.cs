using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugCompactContour : CVariable
	{
		private CArray<CInt32> _rawVertices;
		private CArray<CInt32> _simplifiedVertices;
		private CArray<CInt32> _innerPoints;
		private CUInt16 _region;
		private CUInt8 _area;
		private Box _box;

		[Ordinal(0)] 
		[RED("rawVertices")] 
		public CArray<CInt32> RawVertices
		{
			get => GetProperty(ref _rawVertices);
			set => SetProperty(ref _rawVertices, value);
		}

		[Ordinal(1)] 
		[RED("simplifiedVertices")] 
		public CArray<CInt32> SimplifiedVertices
		{
			get => GetProperty(ref _simplifiedVertices);
			set => SetProperty(ref _simplifiedVertices, value);
		}

		[Ordinal(2)] 
		[RED("innerPoints")] 
		public CArray<CInt32> InnerPoints
		{
			get => GetProperty(ref _innerPoints);
			set => SetProperty(ref _innerPoints, value);
		}

		[Ordinal(3)] 
		[RED("region")] 
		public CUInt16 Region
		{
			get => GetProperty(ref _region);
			set => SetProperty(ref _region, value);
		}

		[Ordinal(4)] 
		[RED("area")] 
		public CUInt8 Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(5)] 
		[RED("box")] 
		public Box Box
		{
			get => GetProperty(ref _box);
			set => SetProperty(ref _box, value);
		}

		public navgendebugCompactContour(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
