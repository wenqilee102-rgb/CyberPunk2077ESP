using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CCTVCamera : gameObject
	{
		private CHandle<entMeshComponent> _mesh;
		private CHandle<gameCameraComponent> _camera;
		private CBool _isControlled;
		private entEntityID _cachedPuppetID;

		[Ordinal(36)] 
		[RED("mesh")] 
		public CHandle<entMeshComponent> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(37)] 
		[RED("camera")] 
		public CHandle<gameCameraComponent> Camera
		{
			get => GetProperty(ref _camera);
			set => SetProperty(ref _camera, value);
		}

		[Ordinal(38)] 
		[RED("isControlled")] 
		public CBool IsControlled
		{
			get => GetProperty(ref _isControlled);
			set => SetProperty(ref _isControlled, value);
		}

		[Ordinal(39)] 
		[RED("cachedPuppetID")] 
		public entEntityID CachedPuppetID
		{
			get => GetProperty(ref _cachedPuppetID);
			set => SetProperty(ref _cachedPuppetID, value);
		}

		public CCTVCamera(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
