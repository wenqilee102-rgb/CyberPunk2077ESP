using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entMorphTargetSkinnedMeshComponent : entISkinTargetComponent
	{
		private raRef<MorphTargetMesh> _morphResource;
		private CName _meshAppearance;
		private CEnum<shadowsShadowCastingMode> _castShadows;
		private CEnum<shadowsShadowCastingMode> _castLocalShadows;
		private CBool _acceptDismemberment;
		private CUInt64 _chunkMask;
		private CName _renderingPlaneAnimationParam;
		private CName _visibilityAnimationParam;
		private CBool _isEnabled;
		private redTagList _tags;
		private CUInt8 _version;

		[Ordinal(10)] 
		[RED("morphResource")] 
		public raRef<MorphTargetMesh> MorphResource
		{
			get => GetProperty(ref _morphResource);
			set => SetProperty(ref _morphResource, value);
		}

		[Ordinal(11)] 
		[RED("meshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(12)] 
		[RED("castShadows")] 
		public CEnum<shadowsShadowCastingMode> CastShadows
		{
			get => GetProperty(ref _castShadows);
			set => SetProperty(ref _castShadows, value);
		}

		[Ordinal(13)] 
		[RED("castLocalShadows")] 
		public CEnum<shadowsShadowCastingMode> CastLocalShadows
		{
			get => GetProperty(ref _castLocalShadows);
			set => SetProperty(ref _castLocalShadows, value);
		}

		[Ordinal(14)] 
		[RED("acceptDismemberment")] 
		public CBool AcceptDismemberment
		{
			get => GetProperty(ref _acceptDismemberment);
			set => SetProperty(ref _acceptDismemberment, value);
		}

		[Ordinal(15)] 
		[RED("chunkMask")] 
		public CUInt64 ChunkMask
		{
			get => GetProperty(ref _chunkMask);
			set => SetProperty(ref _chunkMask, value);
		}

		[Ordinal(16)] 
		[RED("renderingPlaneAnimationParam")] 
		public CName RenderingPlaneAnimationParam
		{
			get => GetProperty(ref _renderingPlaneAnimationParam);
			set => SetProperty(ref _renderingPlaneAnimationParam, value);
		}

		[Ordinal(17)] 
		[RED("visibilityAnimationParam")] 
		public CName VisibilityAnimationParam
		{
			get => GetProperty(ref _visibilityAnimationParam);
			set => SetProperty(ref _visibilityAnimationParam, value);
		}

		[Ordinal(18)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}

		[Ordinal(19)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(20)] 
		[RED("version")] 
		public CUInt8 Version
		{
			get => GetProperty(ref _version);
			set => SetProperty(ref _version, value);
		}

		public entMorphTargetSkinnedMeshComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
