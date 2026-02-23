using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navgendebugTileGenerationDebugData : ISerializable
	{
		private CUInt32 _tileIndex;
		private navgendebugHeightfield _heightfield;
		private navgendebugContourSet _contours;
		private navgendebugPolyMesh _polyMesh;

		[Ordinal(0)] 
		[RED("tileIndex")] 
		public CUInt32 TileIndex
		{
			get => GetProperty(ref _tileIndex);
			set => SetProperty(ref _tileIndex, value);
		}

		[Ordinal(1)] 
		[RED("heightfield")] 
		public navgendebugHeightfield Heightfield
		{
			get => GetProperty(ref _heightfield);
			set => SetProperty(ref _heightfield, value);
		}

		[Ordinal(2)] 
		[RED("contours")] 
		public navgendebugContourSet Contours
		{
			get => GetProperty(ref _contours);
			set => SetProperty(ref _contours, value);
		}

		[Ordinal(3)] 
		[RED("polyMesh")] 
		public navgendebugPolyMesh PolyMesh
		{
			get => GetProperty(ref _polyMesh);
			set => SetProperty(ref _polyMesh, value);
		}

		public navgendebugTileGenerationDebugData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
