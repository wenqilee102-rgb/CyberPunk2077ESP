using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldNodeEditorData : ISerializable
	{
		private CUInt64 _id;
		private CName _name;
		private CString _globalName;
		private CString _alternativeGlobalName;
		private CBool _isGlobalNameLocked;
		private CBool _isAlternativeGlobalNameLocked;
		private CBool _isDestructibleNode;
		private CBool _shouldSkipStreamingInEditor;
		private CBool _excludeOnConsole;
		private CBool _excludeOnNextGenConsoles;
		private CEnum<worldProxyMeshDependencyMode> _proxyMeshDependency;
		private worldNodeTransform _transform;
		private Transform _pivotTransform;
		private CUInt32 _variantId;
		private CUInt64 _questPrefabRefHash;
		private CBool _isInterior;
		private CBool _isDiscarded;
		private CBool _isSnapTarget;
		private CBool _isSnapSource;
		private CFloat _maxStreamingDistance;
		private CString _initialGlobalNameHash;

		[Ordinal(0)] 
		[RED("id")] 
		public CUInt64 Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(2)] 
		[RED("globalName")] 
		public CString GlobalName
		{
			get => GetProperty(ref _globalName);
			set => SetProperty(ref _globalName, value);
		}

		[Ordinal(3)] 
		[RED("alternativeGlobalName")] 
		public CString AlternativeGlobalName
		{
			get => GetProperty(ref _alternativeGlobalName);
			set => SetProperty(ref _alternativeGlobalName, value);
		}

		[Ordinal(4)] 
		[RED("isGlobalNameLocked")] 
		public CBool IsGlobalNameLocked
		{
			get => GetProperty(ref _isGlobalNameLocked);
			set => SetProperty(ref _isGlobalNameLocked, value);
		}

		[Ordinal(5)] 
		[RED("isAlternativeGlobalNameLocked")] 
		public CBool IsAlternativeGlobalNameLocked
		{
			get => GetProperty(ref _isAlternativeGlobalNameLocked);
			set => SetProperty(ref _isAlternativeGlobalNameLocked, value);
		}

		[Ordinal(6)] 
		[RED("isDestructibleNode")] 
		public CBool IsDestructibleNode
		{
			get => GetProperty(ref _isDestructibleNode);
			set => SetProperty(ref _isDestructibleNode, value);
		}

		[Ordinal(7)] 
		[RED("shouldSkipStreamingInEditor")] 
		public CBool ShouldSkipStreamingInEditor
		{
			get => GetProperty(ref _shouldSkipStreamingInEditor);
			set => SetProperty(ref _shouldSkipStreamingInEditor, value);
		}

		[Ordinal(8)] 
		[RED("excludeOnConsole")] 
		public CBool ExcludeOnConsole
		{
			get => GetProperty(ref _excludeOnConsole);
			set => SetProperty(ref _excludeOnConsole, value);
		}

		[Ordinal(9)] 
		[RED("excludeOnNextGenConsoles")] 
		public CBool ExcludeOnNextGenConsoles
		{
			get => GetProperty(ref _excludeOnNextGenConsoles);
			set => SetProperty(ref _excludeOnNextGenConsoles, value);
		}

		[Ordinal(10)] 
		[RED("proxyMeshDependency")] 
		public CEnum<worldProxyMeshDependencyMode> ProxyMeshDependency
		{
			get => GetProperty(ref _proxyMeshDependency);
			set => SetProperty(ref _proxyMeshDependency, value);
		}

		[Ordinal(11)] 
		[RED("transform")] 
		public worldNodeTransform Transform
		{
			get => GetProperty(ref _transform);
			set => SetProperty(ref _transform, value);
		}

		[Ordinal(12)] 
		[RED("pivotTransform")] 
		public Transform PivotTransform
		{
			get => GetProperty(ref _pivotTransform);
			set => SetProperty(ref _pivotTransform, value);
		}

		[Ordinal(13)] 
		[RED("variantId")] 
		public CUInt32 VariantId
		{
			get => GetProperty(ref _variantId);
			set => SetProperty(ref _variantId, value);
		}

		[Ordinal(14)] 
		[RED("questPrefabRefHash")] 
		public CUInt64 QuestPrefabRefHash
		{
			get => GetProperty(ref _questPrefabRefHash);
			set => SetProperty(ref _questPrefabRefHash, value);
		}

		[Ordinal(15)] 
		[RED("isInterior")] 
		public CBool IsInterior
		{
			get => GetProperty(ref _isInterior);
			set => SetProperty(ref _isInterior, value);
		}

		[Ordinal(16)] 
		[RED("isDiscarded")] 
		public CBool IsDiscarded
		{
			get => GetProperty(ref _isDiscarded);
			set => SetProperty(ref _isDiscarded, value);
		}

		[Ordinal(17)] 
		[RED("isSnapTarget")] 
		public CBool IsSnapTarget
		{
			get => GetProperty(ref _isSnapTarget);
			set => SetProperty(ref _isSnapTarget, value);
		}

		[Ordinal(18)] 
		[RED("isSnapSource")] 
		public CBool IsSnapSource
		{
			get => GetProperty(ref _isSnapSource);
			set => SetProperty(ref _isSnapSource, value);
		}

		[Ordinal(19)] 
		[RED("maxStreamingDistance")] 
		public CFloat MaxStreamingDistance
		{
			get => GetProperty(ref _maxStreamingDistance);
			set => SetProperty(ref _maxStreamingDistance, value);
		}

		[Ordinal(20)] 
		[RED("initialGlobalNameHash")] 
		public CString InitialGlobalNameHash
		{
			get => GetProperty(ref _initialGlobalNameHash);
			set => SetProperty(ref _initialGlobalNameHash, value);
		}

		public worldNodeEditorData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
