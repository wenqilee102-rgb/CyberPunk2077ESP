using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkWorldLayerDefinition : inkLayerDefinition
	{
		private Vector2 _projectionPlaneSize;
		private CEnum<ERenderingPlane> _renderingPlane;
		private CBool _isAlwaysVisible;
		private CBool _isInteractableFromBehind;
		private CFloat _maxInteractionDistance;
		private CBool _overrideMaxInteractionDistance;
		private CBool _useCustomFaceVector;
		private Vector3 _faceVector;

		[Ordinal(8)] 
		[RED("projectionPlaneSize")] 
		public Vector2 ProjectionPlaneSize
		{
			get => GetProperty(ref _projectionPlaneSize);
			set => SetProperty(ref _projectionPlaneSize, value);
		}

		[Ordinal(9)] 
		[RED("renderingPlane")] 
		public CEnum<ERenderingPlane> RenderingPlane
		{
			get => GetProperty(ref _renderingPlane);
			set => SetProperty(ref _renderingPlane, value);
		}

		[Ordinal(10)] 
		[RED("isAlwaysVisible")] 
		public CBool IsAlwaysVisible
		{
			get => GetProperty(ref _isAlwaysVisible);
			set => SetProperty(ref _isAlwaysVisible, value);
		}

		[Ordinal(11)] 
		[RED("isInteractableFromBehind")] 
		public CBool IsInteractableFromBehind
		{
			get => GetProperty(ref _isInteractableFromBehind);
			set => SetProperty(ref _isInteractableFromBehind, value);
		}

		[Ordinal(12)] 
		[RED("maxInteractionDistance")] 
		public CFloat MaxInteractionDistance
		{
			get => GetProperty(ref _maxInteractionDistance);
			set => SetProperty(ref _maxInteractionDistance, value);
		}

		[Ordinal(13)] 
		[RED("overrideMaxInteractionDistance")] 
		public CBool OverrideMaxInteractionDistance
		{
			get => GetProperty(ref _overrideMaxInteractionDistance);
			set => SetProperty(ref _overrideMaxInteractionDistance, value);
		}

		[Ordinal(14)] 
		[RED("useCustomFaceVector")] 
		public CBool UseCustomFaceVector
		{
			get => GetProperty(ref _useCustomFaceVector);
			set => SetProperty(ref _useCustomFaceVector, value);
		}

		[Ordinal(15)] 
		[RED("faceVector")] 
		public Vector3 FaceVector
		{
			get => GetProperty(ref _faceVector);
			set => SetProperty(ref _faceVector, value);
		}

		public inkWorldLayerDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
