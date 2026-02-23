using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileData : CVariable
	{
		private CInt32 _tileX;
		private CInt32 _tileY;
		private CUInt32 _tileIndex;
		private CUInt32 _bufferIndex;
		private CEnum<NavGenAgentSize> _agentSize;
		private worldOffMeshConnectionsData _offMeshConnections;
		private CUInt64 _tileRef;
		private CArray<CUInt32> _activeVariantIDs;
		private CArray<CUInt32> _allVariantIDs;

		[Ordinal(0)] 
		[RED("tileX")] 
		public CInt32 TileX
		{
			get => GetProperty(ref _tileX);
			set => SetProperty(ref _tileX, value);
		}

		[Ordinal(1)] 
		[RED("tileY")] 
		public CInt32 TileY
		{
			get => GetProperty(ref _tileY);
			set => SetProperty(ref _tileY, value);
		}

		[Ordinal(2)] 
		[RED("tileIndex")] 
		public CUInt32 TileIndex
		{
			get => GetProperty(ref _tileIndex);
			set => SetProperty(ref _tileIndex, value);
		}

		[Ordinal(3)] 
		[RED("bufferIndex")] 
		public CUInt32 BufferIndex
		{
			get => GetProperty(ref _bufferIndex);
			set => SetProperty(ref _bufferIndex, value);
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get => GetProperty(ref _agentSize);
			set => SetProperty(ref _agentSize, value);
		}

		[Ordinal(5)] 
		[RED("offMeshConnections")] 
		public worldOffMeshConnectionsData OffMeshConnections
		{
			get => GetProperty(ref _offMeshConnections);
			set => SetProperty(ref _offMeshConnections, value);
		}

		[Ordinal(6)] 
		[RED("tileRef")] 
		public CUInt64 TileRef
		{
			get => GetProperty(ref _tileRef);
			set => SetProperty(ref _tileRef, value);
		}

		[Ordinal(7)] 
		[RED("activeVariantIDs")] 
		public CArray<CUInt32> ActiveVariantIDs
		{
			get => GetProperty(ref _activeVariantIDs);
			set => SetProperty(ref _activeVariantIDs, value);
		}

		[Ordinal(8)] 
		[RED("allVariantIDs")] 
		public CArray<CUInt32> AllVariantIDs
		{
			get => GetProperty(ref _allVariantIDs);
			set => SetProperty(ref _allVariantIDs, value);
		}

		public worldNavigationTileData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
