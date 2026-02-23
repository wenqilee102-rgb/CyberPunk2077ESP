using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugHeightfield : ISerializable
	{
		private Box _bounds;
		private CFloat _cellSize;
		private CFloat _cellHeight;
		private CUInt16 _width;
		private CUInt16 _height;
		private navgendebugSpansData _rawSpans;
		private navgendebugSpansData _compactSpans;
		private CArray<navgendebugCompactCell> _cells;
		private CArray<CUInt16> _regions;
		private CArray<CUInt16> _distancefield;
		private CUInt16 _maxDistancefieldValue;

		[Ordinal(0)] 
		[RED("bounds")] 
		public Box Bounds
		{
			get => GetProperty(ref _bounds);
			set => SetProperty(ref _bounds, value);
		}

		[Ordinal(1)] 
		[RED("cellSize")] 
		public CFloat CellSize
		{
			get => GetProperty(ref _cellSize);
			set => SetProperty(ref _cellSize, value);
		}

		[Ordinal(2)] 
		[RED("cellHeight")] 
		public CFloat CellHeight
		{
			get => GetProperty(ref _cellHeight);
			set => SetProperty(ref _cellHeight, value);
		}

		[Ordinal(3)] 
		[RED("width")] 
		public CUInt16 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(4)] 
		[RED("height")] 
		public CUInt16 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(5)] 
		[RED("rawSpans")] 
		public navgendebugSpansData RawSpans
		{
			get => GetProperty(ref _rawSpans);
			set => SetProperty(ref _rawSpans, value);
		}

		[Ordinal(6)] 
		[RED("compactSpans")] 
		public navgendebugSpansData CompactSpans
		{
			get => GetProperty(ref _compactSpans);
			set => SetProperty(ref _compactSpans, value);
		}

		[Ordinal(7)] 
		[RED("cells")] 
		public CArray<navgendebugCompactCell> Cells
		{
			get => GetProperty(ref _cells);
			set => SetProperty(ref _cells, value);
		}

		[Ordinal(8)] 
		[RED("regions")] 
		public CArray<CUInt16> Regions
		{
			get => GetProperty(ref _regions);
			set => SetProperty(ref _regions, value);
		}

		[Ordinal(9)] 
		[RED("distancefield")] 
		public CArray<CUInt16> Distancefield
		{
			get => GetProperty(ref _distancefield);
			set => SetProperty(ref _distancefield, value);
		}

		[Ordinal(10)] 
		[RED("maxDistancefieldValue")] 
		public CUInt16 MaxDistancefieldValue
		{
			get => GetProperty(ref _maxDistancefieldValue);
			set => SetProperty(ref _maxDistancefieldValue, value);
		}

		public navgendebugHeightfield(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
