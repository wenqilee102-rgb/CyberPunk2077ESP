using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleCinematicCameraComponent : gameCameraComponent
	{
		private CBool _teleportThisFrame;
		private WorldTransform _targetTransform;
		private CArray<vehicleCinematicCameraShotGroup> _groups;
		private CFloat _middleZoneSizeForShotSelection;
		private CInt32 _consecutiveStaticShotsProbabilityBonus;
		private CInt32 _consecutiveDynamicShotsProbabilityBonus;
		private CFloat _maxProbabilityBonusFromCameraProximityToShot;
		private CFloat _maxDistanceFromCameraToHaveProbabilityBonusForShot;
		private CFloat _lastChangeTime;
		private CBool _shotChangeRequested;
		private CHandle<vehicleCinematicCameraShot> _currentShot;
		private CHandle<vehicleCinematicCameraShot> _lastShot;

		[Ordinal(35)] 
		[RED("teleportThisFrame")] 
		public CBool TeleportThisFrame
		{
			get => GetProperty(ref _teleportThisFrame);
			set => SetProperty(ref _teleportThisFrame, value);
		}

		[Ordinal(36)] 
		[RED("targetTransform")] 
		public WorldTransform TargetTransform
		{
			get => GetProperty(ref _targetTransform);
			set => SetProperty(ref _targetTransform, value);
		}

		[Ordinal(37)] 
		[RED("groups")] 
		public CArray<vehicleCinematicCameraShotGroup> Groups
		{
			get => GetProperty(ref _groups);
			set => SetProperty(ref _groups, value);
		}

		[Ordinal(38)] 
		[RED("middleZoneSizeForShotSelection")] 
		public CFloat MiddleZoneSizeForShotSelection
		{
			get => GetProperty(ref _middleZoneSizeForShotSelection);
			set => SetProperty(ref _middleZoneSizeForShotSelection, value);
		}

		[Ordinal(39)] 
		[RED("consecutiveStaticShotsProbabilityBonus")] 
		public CInt32 ConsecutiveStaticShotsProbabilityBonus
		{
			get => GetProperty(ref _consecutiveStaticShotsProbabilityBonus);
			set => SetProperty(ref _consecutiveStaticShotsProbabilityBonus, value);
		}

		[Ordinal(40)] 
		[RED("consecutiveDynamicShotsProbabilityBonus")] 
		public CInt32 ConsecutiveDynamicShotsProbabilityBonus
		{
			get => GetProperty(ref _consecutiveDynamicShotsProbabilityBonus);
			set => SetProperty(ref _consecutiveDynamicShotsProbabilityBonus, value);
		}

		[Ordinal(41)] 
		[RED("maxProbabilityBonusFromCameraProximityToShot")] 
		public CFloat MaxProbabilityBonusFromCameraProximityToShot
		{
			get => GetProperty(ref _maxProbabilityBonusFromCameraProximityToShot);
			set => SetProperty(ref _maxProbabilityBonusFromCameraProximityToShot, value);
		}

		[Ordinal(42)] 
		[RED("maxDistanceFromCameraToHaveProbabilityBonusForShot")] 
		public CFloat MaxDistanceFromCameraToHaveProbabilityBonusForShot
		{
			get => GetProperty(ref _maxDistanceFromCameraToHaveProbabilityBonusForShot);
			set => SetProperty(ref _maxDistanceFromCameraToHaveProbabilityBonusForShot, value);
		}

		[Ordinal(43)] 
		[RED("lastChangeTime")] 
		public CFloat LastChangeTime
		{
			get => GetProperty(ref _lastChangeTime);
			set => SetProperty(ref _lastChangeTime, value);
		}

		[Ordinal(44)] 
		[RED("shotChangeRequested")] 
		public CBool ShotChangeRequested
		{
			get => GetProperty(ref _shotChangeRequested);
			set => SetProperty(ref _shotChangeRequested, value);
		}

		[Ordinal(45)] 
		[RED("currentShot")] 
		public CHandle<vehicleCinematicCameraShot> CurrentShot
		{
			get => GetProperty(ref _currentShot);
			set => SetProperty(ref _currentShot, value);
		}

		[Ordinal(46)] 
		[RED("lastShot")] 
		public CHandle<vehicleCinematicCameraShot> LastShot
		{
			get => GetProperty(ref _lastShot);
			set => SetProperty(ref _lastShot, value);
		}

		public vehicleCinematicCameraComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
