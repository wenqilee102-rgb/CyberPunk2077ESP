using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotUpdateContext : CVariable
	{
		private CHandle<vehicleCinematicCameraComponent> _cameraComponent;
		private CEnum<gamedataVehicleType> _vehicleType;
		private WorldTransform _vehicleTransform;
		private Box _vehicleBoundingBox;
		private CFloat _vehicleSpeed;
		private CFloat _engineTime;
		private CFloat _deltaTime;

		[Ordinal(0)] 
		[RED("cameraComponent")] 
		public CHandle<vehicleCinematicCameraComponent> CameraComponent
		{
			get => GetProperty(ref _cameraComponent);
			set => SetProperty(ref _cameraComponent, value);
		}

		[Ordinal(1)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(2)] 
		[RED("vehicleTransform")] 
		public WorldTransform VehicleTransform
		{
			get => GetProperty(ref _vehicleTransform);
			set => SetProperty(ref _vehicleTransform, value);
		}

		[Ordinal(3)] 
		[RED("vehicleBoundingBox")] 
		public Box VehicleBoundingBox
		{
			get => GetProperty(ref _vehicleBoundingBox);
			set => SetProperty(ref _vehicleBoundingBox, value);
		}

		[Ordinal(4)] 
		[RED("vehicleSpeed")] 
		public CFloat VehicleSpeed
		{
			get => GetProperty(ref _vehicleSpeed);
			set => SetProperty(ref _vehicleSpeed, value);
		}

		[Ordinal(5)] 
		[RED("engineTime")] 
		public CFloat EngineTime
		{
			get => GetProperty(ref _engineTime);
			set => SetProperty(ref _engineTime, value);
		}

		[Ordinal(6)] 
		[RED("deltaTime")] 
		public CFloat DeltaTime
		{
			get => GetProperty(ref _deltaTime);
			set => SetProperty(ref _deltaTime, value);
		}

		public vehicleCinematicCameraShotUpdateContext(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
