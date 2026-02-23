using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraShotStopCondition_VehicleDistanceFromCamera : vehicleCinematicCameraShotStopCondition
	{
		private CFloat _maxDistanceFromCamera;

		[Ordinal(0)] 
		[RED("maxDistanceFromCamera")] 
		public CFloat MaxDistanceFromCamera
		{
			get => GetProperty(ref _maxDistanceFromCamera);
			set => SetProperty(ref _maxDistanceFromCamera, value);
		}

		public vehicleCinematicCameraShotStopCondition_VehicleDistanceFromCamera(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
