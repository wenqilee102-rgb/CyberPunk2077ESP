using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugCompactPolygon : ISerializable
	{
		private CUInt16 _index;
		private CArray<CUInt16> _indices;
		private CArray<CUInt16> _neighbors;
		private CUInt8 _area;
		private CUInt16 _region;
		private CUInt16 _flags;

		[Ordinal(0)] 
		[RED("index")] 
		public CUInt16 Index
		{
			get => GetProperty(ref _index);
			set => SetProperty(ref _index, value);
		}

		[Ordinal(1)] 
		[RED("indices")] 
		public CArray<CUInt16> Indices
		{
			get => GetProperty(ref _indices);
			set => SetProperty(ref _indices, value);
		}

		[Ordinal(2)] 
		[RED("neighbors")] 
		public CArray<CUInt16> Neighbors
		{
			get => GetProperty(ref _neighbors);
			set => SetProperty(ref _neighbors, value);
		}

		[Ordinal(3)] 
		[RED("area")] 
		public CUInt8 Area
		{
			get => GetProperty(ref _area);
			set => SetProperty(ref _area, value);
		}

		[Ordinal(4)] 
		[RED("region")] 
		public CUInt16 Region
		{
			get => GetProperty(ref _region);
			set => SetProperty(ref _region, value);
		}

		[Ordinal(5)] 
		[RED("flags")] 
		public CUInt16 Flags
		{
			get => GetProperty(ref _flags);
			set => SetProperty(ref _flags, value);
		}

		public navgendebugCompactPolygon(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
