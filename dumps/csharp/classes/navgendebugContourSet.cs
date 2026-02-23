using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugContourSet : CVariable
	{
		private CArray<navgendebugCompactContour> _contours;
		private Box _boundingBox;
		private CFloat _cellSize;
		private CFloat _cellHeight;
		private CInt32 _width;
		private CInt32 _height;
		private CInt32 _borderSize;
		private CFloat _maxError;

		[Ordinal(0)] 
		[RED("contours")] 
		public CArray<navgendebugCompactContour> Contours
		{
			get => GetProperty(ref _contours);
			set => SetProperty(ref _contours, value);
		}

		[Ordinal(1)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetProperty(ref _boundingBox);
			set => SetProperty(ref _boundingBox, value);
		}

		[Ordinal(2)] 
		[RED("cellSize")] 
		public CFloat CellSize
		{
			get => GetProperty(ref _cellSize);
			set => SetProperty(ref _cellSize, value);
		}

		[Ordinal(3)] 
		[RED("cellHeight")] 
		public CFloat CellHeight
		{
			get => GetProperty(ref _cellHeight);
			set => SetProperty(ref _cellHeight, value);
		}

		[Ordinal(4)] 
		[RED("width")] 
		public CInt32 Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(5)] 
		[RED("height")] 
		public CInt32 Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(6)] 
		[RED("borderSize")] 
		public CInt32 BorderSize
		{
			get => GetProperty(ref _borderSize);
			set => SetProperty(ref _borderSize, value);
		}

		[Ordinal(7)] 
		[RED("maxError")] 
		public CFloat MaxError
		{
			get => GetProperty(ref _maxError);
			set => SetProperty(ref _maxError, value);
		}

		public navgendebugContourSet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
