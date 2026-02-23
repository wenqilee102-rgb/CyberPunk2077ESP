using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileResource : resStreamedResource
	{
		private Box _localBoundingBox;
		private CArray<worldNavigationTileData> _tilesData;
		private CArray<DataBuffer> _tileBuffers;
		private CEnum<NavGenAgentSize> _agentSize;

		[Ordinal(1)] 
		[RED("localBoundingBox")] 
		public Box LocalBoundingBox
		{
			get => GetProperty(ref _localBoundingBox);
			set => SetProperty(ref _localBoundingBox, value);
		}

		[Ordinal(2)] 
		[RED("tilesData")] 
		public CArray<worldNavigationTileData> TilesData
		{
			get => GetProperty(ref _tilesData);
			set => SetProperty(ref _tilesData, value);
		}

		[Ordinal(3)] 
		[RED("tileBuffers")] 
		public CArray<DataBuffer> TileBuffers
		{
			get => GetProperty(ref _tileBuffers);
			set => SetProperty(ref _tileBuffers, value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetProperty(ref _agentSize);
			set => SetProperty(ref _agentSize, value);
		}

		public worldNavigationTileResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
