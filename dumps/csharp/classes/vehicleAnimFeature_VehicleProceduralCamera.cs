using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleAnimFeature_VehicleProceduralCamera : animAnimFeature
	{
		private Vector4 _cameraTranslationVS;
		private Quaternion _cameraOrientationVS;
		private CFloat _cameraTargetWeight;

		[Ordinal(0)] 
		[RED("cameraTranslationVS")] 
		public Vector4 CameraTranslationVS
		{
			get => GetProperty(ref _cameraTranslationVS);
			set => SetProperty(ref _cameraTranslationVS, value);
		}

		[Ordinal(1)] 
		[RED("cameraOrientationVS")] 
		public Quaternion CameraOrientationVS
		{
			get => GetProperty(ref _cameraOrientationVS);
			set => SetProperty(ref _cameraOrientationVS, value);
		}

		[Ordinal(2)] 
		[RED("cameraTargetWeight")] 
		public CFloat CameraTargetWeight
		{
			get => GetProperty(ref _cameraTargetWeight);
			set => SetProperty(ref _cameraTargetWeight, value);
		}

		public vehicleAnimFeature_VehicleProceduralCamera(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
