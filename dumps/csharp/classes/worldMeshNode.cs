using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldMeshNode : worldNode
	{
		private raRef<CMesh> _mesh;
		private CName _meshAppearance;
		private CFloat _forceAutoHideDistance;
		private CEnum<visWorldOccluderType> _occluderType;
		private CUInt8 _occluderAutohideDistanceScale;
		private CEnum<shadowsShadowCastingMode> _castShadows;
		private CEnum<shadowsShadowCastingMode> _castLocalShadows;
		private CEnum<shadowsShadowCastingMode> _castRayTracedGlobalShadows;
		private CEnum<shadowsShadowCastingMode> _castRayTracedLocalShadows;
		private CBool _windImpulseEnabled;
		private CBool _removeFromRainMap;
		private CEnum<RenderSceneLayerMask> _renderSceneLayerMask;
		private CUInt32 _lodLevelScales;
		private CUInt8 _version;

		[Ordinal(4)] 
		[RED("mesh")] 
		public raRef<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(5)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(6)] 
		[RED("forceAutoHideDistance")] 
		public CFloat ForceAutoHideDistance
		{
			get => GetProperty(ref _forceAutoHideDistance);
			set => SetProperty(ref _forceAutoHideDistance, value);
		}

		[Ordinal(7)] 
		[RED("occluderType")] 
		public CEnum<visWorldOccluderType> OccluderType
		{
			get => GetProperty(ref _occluderType);
			set => SetProperty(ref _occluderType, value);
		}

		[Ordinal(8)] 
		[RED("occluderAutohideDistanceScale")] 
		public CUInt8 OccluderAutohideDistanceScale
		{
			get => GetProperty(ref _occluderAutohideDistanceScale);
			set => SetProperty(ref _occluderAutohideDistanceScale, value);
		}

		[Ordinal(9)] 
		[RED("castShadows")] 
		public CEnum<shadowsShadowCastingMode> CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(10)] 
		[RED("castLocalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(11)] 
		[RED("castRayTracedGlobalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastRayTracedGlobalShadows
		{
			get => GetProperty(ref _castRayTracedGlobalShadows);
			set => SetProperty(ref _castRayTracedGlobalShadows, value);
		}

		[Ordinal(12)] 
		[RED("castRayTracedLocalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastRayTracedLocalShadows
		{
			get => GetProperty(ref _castRayTracedLocalShadows);
			set => SetProperty(ref _castRayTracedLocalShadows, value);
		}

		[Ordinal(13)] 
		[RED("windImpulseEnabled")] 
		public CBool WindImpulseEnabled
		{
			get => GetProperty(ref _windImpulseEnabled);
			set => SetProperty(ref _windImpulseEnabled, value);
		}

		[Ordinal(14)] 
		[RED("removeFromRainMap")] 
		public CBool RemoveFromRainMap
		{
			get => GetProperty(ref _removeFromRainMap);
			set => SetProperty(ref _removeFromRainMap, value);
		}

		[Ordinal(15)] 
		[RED("renderSceneLayerMask")] 
		public CEnum<RenderSceneLayerMask> RenderSceneLayerMask
		{
			get => GetProperty(ref _renderSceneLayerMask);
			set => SetProperty(ref _renderSceneLayerMask, value);
		}

		[Ordinal(16)] 
		[RED("lodLevelScales")] 
		public CUInt32 LodLevelScales
		{
			get => GetProperty(ref _lodLevelScales);
			set => SetProperty(ref _lodLevelScales, value);
		}

		[Ordinal(17)] 
		[RED("version")] 
		public CUInt8 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public worldMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
