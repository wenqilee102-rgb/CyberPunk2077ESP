using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRaceGameplayController : gameuiarcadeArcadeGameplayController
	{
		private CFloat _defaultWorldVelocity;
		private CFloat _cycleWorldVelocityMultiplier;
		private CFloat _carrotPowerupPointsPerSecond;
		private CFloat _carrotPowerupTime;
		private CFloat _carrotPowerupWorldVelocityMultiplier;
		private CName _collisionSFX;
		private CName _powerupPickupSFX;
		private inkWidgetReference _player;
		private inkWidgetReference _obstacleSpawner;
		private inkWidgetReference _background;
		private inkTextWidgetReference _currentLevelAndCycleText;
		private inkTextWidgetReference _pointsBoostPickupText;
		private inkWidgetReference _dummy;
		private inkWidgetReference _invincibilityCooldownIndicator;

		[Ordinal(3)] 
		[RED("defaultWorldVelocity")] 
		public CFloat DefaultWorldVelocity
		{
			get => GetProperty(ref _defaultWorldVelocity);
			set => SetProperty(ref _defaultWorldVelocity, value);
		}

		[Ordinal(4)] 
		[RED("cycleWorldVelocityMultiplier")] 
		public CFloat CycleWorldVelocityMultiplier
		{
			get => GetProperty(ref _cycleWorldVelocityMultiplier);
			set => SetProperty(ref _cycleWorldVelocityMultiplier, value);
		}

		[Ordinal(5)] 
		[RED("carrotPowerupPointsPerSecond")] 
		public CFloat CarrotPowerupPointsPerSecond
		{
			get => GetProperty(ref _carrotPowerupPointsPerSecond);
			set => SetProperty(ref _carrotPowerupPointsPerSecond, value);
		}

		[Ordinal(6)] 
		[RED("carrotPowerupTime")] 
		public CFloat CarrotPowerupTime
		{
			get => GetProperty(ref _carrotPowerupTime);
			set => SetProperty(ref _carrotPowerupTime, value);
		}

		[Ordinal(7)] 
		[RED("carrotPowerupWorldVelocityMultiplier")] 
		public CFloat CarrotPowerupWorldVelocityMultiplier
		{
			get => GetProperty(ref _carrotPowerupWorldVelocityMultiplier);
			set => SetProperty(ref _carrotPowerupWorldVelocityMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("collisionSFX")] 
		public CName CollisionSFX
		{
			get => GetProperty(ref _collisionSFX);
			set => SetProperty(ref _collisionSFX, value);
		}

		[Ordinal(9)] 
		[RED("powerupPickupSFX")] 
		public CName PowerupPickupSFX
		{
			get => GetProperty(ref _powerupPickupSFX);
			set => SetProperty(ref _powerupPickupSFX, value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public inkWidgetReference Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(11)] 
		[RED("obstacleSpawner")] 
		public inkWidgetReference ObstacleSpawner
		{
			get => GetProperty(ref _obstacleSpawner);
			set => SetProperty(ref _obstacleSpawner, value);
		}

		[Ordinal(12)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(13)] 
		[RED("currentLevelAndCycleText")] 
		public inkTextWidgetReference CurrentLevelAndCycleText
		{
			get => GetProperty(ref _currentLevelAndCycleText);
			set => SetProperty(ref _currentLevelAndCycleText, value);
		}

		[Ordinal(14)] 
		[RED("pointsBoostPickupText")] 
		public inkTextWidgetReference PointsBoostPickupText
		{
			get => GetProperty(ref _pointsBoostPickupText);
			set => SetProperty(ref _pointsBoostPickupText, value);
		}

		[Ordinal(15)] 
		[RED("dummy")] 
		public inkWidgetReference Dummy
		{
			get => GetProperty(ref _dummy);
			set => SetProperty(ref _dummy, value);
		}

		[Ordinal(16)] 
		[RED("invincibilityCooldownIndicator")] 
		public inkWidgetReference InvincibilityCooldownIndicator
		{
			get => GetProperty(ref _invincibilityCooldownIndicator);
			set => SetProperty(ref _invincibilityCooldownIndicator, value);
		}

		public gameuiarcadeRoachRaceGameplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
