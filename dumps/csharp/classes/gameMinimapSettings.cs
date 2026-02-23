using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMinimapSettings : IScriptable
	{
		private gameRange _globalVisionRadiusBounds;
		private gameRange _visionRadiusVehicle;
		private gameRange _visionRadiusCombat;
		private gameRange _visionRadiusQuestArea;
		private gameRange _visionRadiusSecurityArea;
		private gameRange _visionRadiusInterior;
		private gameRange _visionRadiusExterior;
		private gameRange _speedBoundsSprint;
		private gameRange _speedBoundsVehicle;
		private CFloat _smoothingStrengthOnZoomIn;
		private CFloat _smoothingStrengthOnZoomOut;
		private CFloat _playerMarkerTransitionSpeedOnVehicleMount;
		private CFloat _playerMarkerTransitionSpeedOnVehicleUnmount;
		private CBool _visionRadiusLocked;
		private CBool _dynamicVisionRadiusEnabled;
		private CBool _smoothingEnabled;

		[Ordinal(0)] 
		[RED("globalVisionRadiusBounds")] 
		public gameRange GlobalVisionRadiusBounds
		{
			get => GetProperty(ref _globalVisionRadiusBounds);
			set => SetProperty(ref _globalVisionRadiusBounds, value);
		}

		[Ordinal(1)] 
		[RED("visionRadiusVehicle")] 
		public gameRange VisionRadiusVehicle
		{
			get => GetProperty(ref _visionRadiusVehicle);
			set => SetProperty(ref _visionRadiusVehicle, value);
		}

		[Ordinal(2)] 
		[RED("visionRadiusCombat")] 
		public gameRange VisionRadiusCombat
		{
			get => GetProperty(ref _visionRadiusCombat);
			set => SetProperty(ref _visionRadiusCombat, value);
		}

		[Ordinal(3)] 
		[RED("visionRadiusQuestArea")] 
		public gameRange VisionRadiusQuestArea
		{
			get => GetProperty(ref _visionRadiusQuestArea);
			set => SetProperty(ref _visionRadiusQuestArea, value);
		}

		[Ordinal(4)] 
		[RED("visionRadiusSecurityArea")] 
		public gameRange VisionRadiusSecurityArea
		{
			get => GetProperty(ref _visionRadiusSecurityArea);
			set => SetProperty(ref _visionRadiusSecurityArea, value);
		}

		[Ordinal(5)] 
		[RED("visionRadiusInterior")] 
		public gameRange VisionRadiusInterior
		{
			get => GetProperty(ref _visionRadiusInterior);
			set => SetProperty(ref _visionRadiusInterior, value);
		}

		[Ordinal(6)] 
		[RED("visionRadiusExterior")] 
		public gameRange VisionRadiusExterior
		{
			get => GetProperty(ref _visionRadiusExterior);
			set => SetProperty(ref _visionRadiusExterior, value);
		}

		[Ordinal(7)] 
		[RED("speedBoundsSprint")] 
		public gameRange SpeedBoundsSprint
		{
			get => GetProperty(ref _speedBoundsSprint);
			set => SetProperty(ref _speedBoundsSprint, value);
		}

		[Ordinal(8)] 
		[RED("speedBoundsVehicle")] 
		public gameRange SpeedBoundsVehicle
		{
			get => GetProperty(ref _speedBoundsVehicle);
			set => SetProperty(ref _speedBoundsVehicle, value);
		}

		[Ordinal(9)] 
		[RED("smoothingStrengthOnZoomIn")] 
		public CFloat SmoothingStrengthOnZoomIn
		{
			get => GetProperty(ref _smoothingStrengthOnZoomIn);
			set => SetProperty(ref _smoothingStrengthOnZoomIn, value);
		}

		[Ordinal(10)] 
		[RED("smoothingStrengthOnZoomOut")] 
		public CFloat SmoothingStrengthOnZoomOut
		{
			get => GetProperty(ref _smoothingStrengthOnZoomOut);
			set => SetProperty(ref _smoothingStrengthOnZoomOut, value);
		}

		[Ordinal(11)] 
		[RED("playerMarkerTransitionSpeedOnVehicleMount")] 
		public CFloat PlayerMarkerTransitionSpeedOnVehicleMount
		{
			get => GetProperty(ref _playerMarkerTransitionSpeedOnVehicleMount);
			set => SetProperty(ref _playerMarkerTransitionSpeedOnVehicleMount, value);
		}

		[Ordinal(12)] 
		[RED("playerMarkerTransitionSpeedOnVehicleUnmount")] 
		public CFloat PlayerMarkerTransitionSpeedOnVehicleUnmount
		{
			get => GetProperty(ref _playerMarkerTransitionSpeedOnVehicleUnmount);
			set => SetProperty(ref _playerMarkerTransitionSpeedOnVehicleUnmount, value);
		}

		[Ordinal(13)] 
		[RED("visionRadiusLocked")] 
		public CBool VisionRadiusLocked
		{
			get => GetProperty(ref _visionRadiusLocked);
			set => SetProperty(ref _visionRadiusLocked, value);
		}

		[Ordinal(14)] 
		[RED("dynamicVisionRadiusEnabled")] 
		public CBool DynamicVisionRadiusEnabled
		{
			get => GetProperty(ref _dynamicVisionRadiusEnabled);
			set => SetProperty(ref _dynamicVisionRadiusEnabled, value);
		}

		[Ordinal(15)] 
		[RED("smoothingEnabled")] 
		public CBool SmoothingEnabled
		{
			get => GetProperty(ref _smoothingEnabled);
			set => SetProperty(ref _smoothingEnabled, value);
		}

		public gameMinimapSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
