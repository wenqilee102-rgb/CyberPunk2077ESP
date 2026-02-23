using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CinematicCameraData : CVariable
	{
		private CHandle<vehicleCinematicCameraComponent> _cameraComponent;
		private CHandle<vehicleCinematicCameraShot> _currentShot;
		private WorldTransform _shotInitialTransform;
		private WorldTransform _vehicleInitialTransform;
		private Box _referenceLocalBoundingBox;
		private Box _currentLocalBoundingBox;
		private CFloat _shotStartTime;
		private WorldTransform _shotRootTransform;
		private WorldTransform _shotSpaceTransform;
		private WorldTransform _vehicleTransform;
		private CFloat _vehicleSpeed;
		private CFloat _currentTime;
		private CFloat _deltaTime;

		[Ordinal(0)] 
		[RED("cameraComponent")] 
		public CHandle<vehicleCinematicCameraComponent> CameraComponent
		{
			get => GetProperty(ref _cameraComponent);
			set => SetProperty(ref _cameraComponent, value);
		}

		[Ordinal(1)] 
		[RED("currentShot")] 
		public CHandle<vehicleCinematicCameraShot> CurrentShot
		{
			get => GetProperty(ref _currentShot);
			set => SetProperty(ref _currentShot, value);
		}

		[Ordinal(2)] 
		[RED("shotInitialTransform")] 
		public WorldTransform ShotInitialTransform
		{
			get => GetProperty(ref _shotInitialTransform);
			set => SetProperty(ref _shotInitialTransform, value);
		}

		[Ordinal(3)] 
		[RED("vehicleInitialTransform")] 
		public WorldTransform VehicleInitialTransform
		{
			get => GetProperty(ref _vehicleInitialTransform);
			set => SetProperty(ref _vehicleInitialTransform, value);
		}

		[Ordinal(4)] 
		[RED("referenceLocalBoundingBox")] 
		public Box ReferenceLocalBoundingBox
		{
			get => GetProperty(ref _referenceLocalBoundingBox);
			set => SetProperty(ref _referenceLocalBoundingBox, value);
		}

		[Ordinal(5)] 
		[RED("currentLocalBoundingBox")] 
		public Box CurrentLocalBoundingBox
		{
			get => GetProperty(ref _currentLocalBoundingBox);
			set => SetProperty(ref _currentLocalBoundingBox, value);
		}

		[Ordinal(6)] 
		[RED("shotStartTime")] 
		public CFloat ShotStartTime
		{
			get => GetProperty(ref _shotStartTime);
			set => SetProperty(ref _shotStartTime, value);
		}

		[Ordinal(7)] 
		[RED("shotRootTransform")] 
		public WorldTransform ShotRootTransform
		{
			get => GetProperty(ref _shotRootTransform);
			set => SetProperty(ref _shotRootTransform, value);
		}

		[Ordinal(8)] 
		[RED("shotSpaceTransform")] 
		public WorldTransform ShotSpaceTransform
		{
			get => GetProperty(ref _shotSpaceTransform);
			set => SetProperty(ref _shotSpaceTransform, value);
		}

		[Ordinal(9)] 
		[RED("vehicleTransform")] 
		public WorldTransform VehicleTransform
		{
			get => GetProperty(ref _vehicleTransform);
			set => SetProperty(ref _vehicleTransform, value);
		}

		[Ordinal(10)] 
		[RED("vehicleSpeed")] 
		public CFloat VehicleSpeed
		{
			get => GetProperty(ref _vehicleSpeed);
			set => SetProperty(ref _vehicleSpeed, value);
		}

		[Ordinal(11)] 
		[RED("currentTime")] 
		public CFloat CurrentTime
		{
			get => GetProperty(ref _currentTime);
			set => SetProperty(ref _currentTime, value);
		}

		[Ordinal(12)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get => GetProperty(ref _deltaTime);
			set => SetProperty(ref _deltaTime, value);
		}

		public CinematicCameraData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
