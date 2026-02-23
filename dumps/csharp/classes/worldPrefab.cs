using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefab : resStreamedResource
	{
		private CHandle<worldNodesGroup> _mainGroup;
		private CEnum<worldPrefabType> _type;
		private CEnum<worldPrefabOwnership> _teamOwnership;
		private CEnum<worldPrefabStreamingOcclusion> _streamingOcclusion;
		private CEnum<worldPrefabStreamingImportance> _streamingImportance;
		private CHandle<worldPrefabVariantsList> _defaultVariants;
		private CBool _isLocked;
		private Box _maxBounds;
		private raRef<worldEnvironmentDefinition> _environmentDefinition;
		private raRef<Multilayer_Setup> _terrainMultilayerSetup;
		private raRef<worldAutoFoliageMapping> _foliageBrushToTerrainLayerMapping;
		private CRUID _prefabUniqueId;
		private CArray<CHandle<worldPrefabMetadata>> _metadataArray;
		private CBool _isMerged;
		private worldProxyMeshBuildParams _proxyMeshBuildParams;
		private CBool _isProxyMeshOnly;
		private raRef<CMesh> _proxyMesh;
		private Vector3 _proxyScale;
		private CFloat _maxProxyStreamingDistance;
		private CFloat _proxyDistanceFactor;
		private CFloat _averageNodeDiagonal;
		private CBool _boostInnerNodesToProxyDistance;
		private CBool _overrideStreamingPosWithBBoxCenter;
		private CBool _ignoreMeshEmbeddedOccluders;
		private CBool _ignoreAllOccluders;
		private CBool _excludeOnConsole;
		private CBool _excludeOnNextGenConsoles;
		private CBool _isTerrainPrefab;
		private CEnum<worldPrefabMinimapContribution> _minimapContribution;
		private CEnum<worldPrefabInteriorMapContribution> _interiorMapContribution;
		private raRef<worldPrefab> _booleanProxyHelper;
		private raRef<worldPrefab> _proxyLimiterHelper;
		private raRef<CMesh> _customProxyMeshHelper;

		[Ordinal(1)] 
		[RED("mainGroup")] 
		public CHandle<worldNodesGroup> MainGroup
		{
			get => GetProperty(ref _mainGroup);
			set => SetProperty(ref _mainGroup, value);
		}

		[Ordinal(2)] 
		[RED("type")] 
		public CEnum<worldPrefabType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(3)] 
		[RED("teamOwnership")] 
		public CEnum<worldPrefabOwnership> TeamOwnership
		{
			get => GetProperty(ref _teamOwnership);
			set => SetProperty(ref _teamOwnership, value);
		}

		[Ordinal(4)] 
		[RED("streamingOcclusion")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion
		{
			get => GetProperty(ref _streamingOcclusion);
			set => SetProperty(ref _streamingOcclusion, value);
		}

		[Ordinal(5)] 
		[RED("streamingImportance")] 
		public CEnum<worldPrefabStreamingImportance> StreamingImportance
		{
			get => GetProperty(ref _streamingImportance);
			set => SetProperty(ref _streamingImportance, value);
		}

		[Ordinal(6)] 
		[RED("defaultVariants")] 
		public CHandle<worldPrefabVariantsList> DefaultVariants
		{
			get => GetProperty(ref _defaultVariants);
			set => SetProperty(ref _defaultVariants, value);
		}

		[Ordinal(7)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(8)] 
		[RED("maxBounds")] 
		public Box MaxBounds
		{
			get => GetProperty(ref _maxBounds);
			set => SetProperty(ref _maxBounds, value);
		}

		[Ordinal(9)] 
		[RED("environmentDefinition")] 
		public raRef<worldEnvironmentDefinition> EnvironmentDefinition
		{
			get => GetProperty(ref _environmentDefinition);
			set => SetProperty(ref _environmentDefinition, value);
		}

		[Ordinal(10)] 
		[RED("terrainMultilayerSetup")] 
		public raRef<Multilayer_Setup> TerrainMultilayerSetup
		{
			get => GetProperty(ref _terrainMultilayerSetup);
			set => SetProperty(ref _terrainMultilayerSetup, value);
		}

		[Ordinal(11)] 
		[RED("foliageBrushToTerrainLayerMapping")] 
		public raRef<worldAutoFoliageMapping> FoliageBrushToTerrainLayerMapping
		{
			get => GetProperty(ref _foliageBrushToTerrainLayerMapping);
			set => SetProperty(ref _foliageBrushToTerrainLayerMapping, value);
		}

		[Ordinal(12)] 
		[RED("prefabUniqueId")] 
		public CRUID PrefabUniqueId
		{
			get => GetProperty(ref _prefabUniqueId);
			set => SetProperty(ref _prefabUniqueId, value);
		}

		[Ordinal(13)] 
		[RED("metadataArray")] 
		public CArray<CHandle<worldPrefabMetadata>> MetadataArray
		{
			get => GetProperty(ref _metadataArray);
			set => SetProperty(ref _metadataArray, value);
		}

		[Ordinal(14)] 
		[RED("isMerged")] 
		public CBool IsMerged
		{
			get => GetProperty(ref _isMerged);
			set => SetProperty(ref _isMerged, value);
		}

		[Ordinal(15)] 
		[RED("proxyMeshBuildParams")] 
		public worldProxyMeshBuildParams ProxyMeshBuildParams
		{
			get => GetProperty(ref _proxyMeshBuildParams);
			set => SetProperty(ref _proxyMeshBuildParams, value);
		}

		[Ordinal(16)] 
		[RED("isProxyMeshOnly")] 
		public CBool IsProxyMeshOnly
		{
			get => GetProperty(ref _isProxyMeshOnly);
			set => SetProperty(ref _isProxyMeshOnly, value);
		}

		[Ordinal(17)] 
		[RED("proxyMesh")] 
		public raRef<CMesh> ProxyMesh
		{
			get => GetProperty(ref _proxyMesh);
			set => SetProperty(ref _proxyMesh, value);
		}

		[Ordinal(18)] 
		[RED("proxyScale")] 
		public Vector3 ProxyScale
		{
			get => GetProperty(ref _proxyScale);
			set => SetProperty(ref _proxyScale, value);
		}

		[Ordinal(19)] 
		[RED("maxProxyStreamingDistance")] 
		public CFloat MaxProxyStreamingDistance
		{
			get => GetProperty(ref _maxProxyStreamingDistance);
			set => SetProperty(ref _maxProxyStreamingDistance, value);
		}

		[Ordinal(20)] 
		[RED("proxyDistanceFactor")] 
		public CFloat ProxyDistanceFactor
		{
			get => GetProperty(ref _proxyDistanceFactor);
			set => SetProperty(ref _proxyDistanceFactor, value);
		}

		[Ordinal(21)] 
		[RED("averageNodeDiagonal")] 
		public CFloat AverageNodeDiagonal
		{
			get => GetProperty(ref _averageNodeDiagonal);
			set => SetProperty(ref _averageNodeDiagonal, value);
		}

		[Ordinal(22)] 
		[RED("boostInnerNodesToProxyDistance")] 
		public CBool BoostInnerNodesToProxyDistance
		{
			get => GetProperty(ref _boostInnerNodesToProxyDistance);
			set => SetProperty(ref _boostInnerNodesToProxyDistance, value);
		}

		[Ordinal(23)] 
		[RED("overrideStreamingPosWithBBoxCenter")] 
		public CBool OverrideStreamingPosWithBBoxCenter
		{
			get => GetProperty(ref _overrideStreamingPosWithBBoxCenter);
			set => SetProperty(ref _overrideStreamingPosWithBBoxCenter, value);
		}

		[Ordinal(24)] 
		[RED("ignoreMeshEmbeddedOccluders")] 
		public CBool IgnoreMeshEmbeddedOccluders
		{
			get => GetProperty(ref _ignoreMeshEmbeddedOccluders);
			set => SetProperty(ref _ignoreMeshEmbeddedOccluders, value);
		}

		[Ordinal(25)] 
		[RED("ignoreAllOccluders")] 
		public CBool IgnoreAllOccluders
		{
			get => GetProperty(ref _ignoreAllOccluders);
			set => SetProperty(ref _ignoreAllOccluders, value);
		}

		[Ordinal(26)] 
		[RED("excludeOnConsole")] 
		public CBool ExcludeOnConsole
		{
			get => GetProperty(ref _excludeOnConsole);
			set => SetProperty(ref _excludeOnConsole, value);
		}

		[Ordinal(27)] 
		[RED("excludeOnNextGenConsoles")] 
		public CBool ExcludeOnNextGenConsoles
		{
			get => GetProperty(ref _excludeOnNextGenConsoles);
			set => SetProperty(ref _excludeOnNextGenConsoles, value);
		}

		[Ordinal(28)] 
		[RED("isTerrainPrefab")] 
		public CBool IsTerrainPrefab
		{
			get => GetProperty(ref _isTerrainPrefab);
			set => SetProperty(ref _isTerrainPrefab, value);
		}

		[Ordinal(29)] 
		[RED("minimapContribution")] 
		public CEnum<worldPrefabMinimapContribution> MinimapContribution
		{
			get => GetProperty(ref _minimapContribution);
			set => SetProperty(ref _minimapContribution, value);
		}

		[Ordinal(30)] 
		[RED("interiorMapContribution")] 
		public CEnum<worldPrefabInteriorMapContribution> InteriorMapContribution
		{
			get => GetProperty(ref _interiorMapContribution);
			set => SetProperty(ref _interiorMapContribution, value);
		}

		[Ordinal(31)] 
		[RED("booleanProxyHelper")] 
		public raRef<worldPrefab> BooleanProxyHelper
		{
			get => GetProperty(ref _booleanProxyHelper);
			set => SetProperty(ref _booleanProxyHelper, value);
		}

		[Ordinal(32)] 
		[RED("proxyLimiterHelper")] 
		public raRef<worldPrefab> ProxyLimiterHelper
		{
			get => GetProperty(ref _proxyLimiterHelper);
			set => SetProperty(ref _proxyLimiterHelper, value);
		}

		[Ordinal(33)] 
		[RED("customProxyMeshHelper")] 
		public raRef<CMesh> CustomProxyMeshHelper
		{
			get => GetProperty(ref _customProxyMeshHelper);
			set => SetProperty(ref _customProxyMeshHelper, value);
		}

		public worldPrefab(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
