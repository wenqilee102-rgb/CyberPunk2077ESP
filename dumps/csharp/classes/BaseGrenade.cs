using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseGrenade : gameweaponGrenade
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private wCHandle<gameObject> _user;
		private Vector4 _projectileSpawnPoint;
		private CHandle<entSimpleColliderComponent> _shootCollision;
		private CHandle<entIComponent> _visualComponent;
		private CHandle<entIComponent> _stickyMeshComponent;
		private CHandle<entIComponent> _decalsStickyComponent;
		private CHandle<entIComponent> _homingMeshComponent;
		private CHandle<gameTargetingComponent> _targetingComponent;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private gameNewMappinID _mappinID;
		private CFloat _timeSinceLaunch;
		private CFloat _timeSinceExplosion;
		private CFloat _detonationTimer;
		private CFloat _stickyTrackerTimeout;
		private CFloat _timeOfFreezing;
		private gameDelayID _spawnBlinkEffectDelayID;
		private gameDelayID _detonateRequestDelayID;
		private gameDelayID _releaseRequestDelayID;
		private CFloat _delayToDetonate;
		private CBool _detonationTimerActive;
		private CBool _isAlive;
		private CBool _isSinking;
		private CBool _landedOnGround;
		private CBool _isStuck;
		private CBool _isTracking;
		private CBool _isLockingOn;
		private CBool _isLockedOn;
		private CBool _readyToTrack;
		private CBool _lockOnFailed;
		private CBool _canBeShot;
		private CBool _shotDownByThePlayer;
		private CBool _forceExplosion;
		private CBool _hasClearedIgnoredObject;
		private CBool _detonateOnImpact;
		private CBool _setStickyTracker;
		private CBool _isContinuousEffect;
		private CBool _additionalAttackOnDetonate;
		private CBool _additionalAttackOnCollision;
		private CBool _targetAcquired;
		private CBool _collidedWithNPC;
		private CBool _isBroadcastingStim;
		private CBool _playingFastBeep;
		private CBool _hasExploded;
		private CHandle<gameEffectInstance> _targetTracker;
		private CArray<GrenadePotentialHomingTarget> _potentialHomingTargets;
		private GrenadePotentialHomingTarget _homingGrenadeTarget;
		private CArray<CuttingGrenadePotentialTarget> _cuttingGrenadePotentialTargets;
		private Vector4 _drillTargetPosition;
		private CArray<CHandle<gameEffectInstance>> _attacksSpawned;
		private CHandle<gamedataGrenade_Record> _tweakRecord;
		private gameFxResource _additionalEffect;
		private CBool _landedCooldownActive;
		private CFloat _landedCooldownTimer;
		private CBool _hasHitWater;
		private CFloat _waterHeight;
		private CFloat _smokeEffectRadius;
		private CFloat _smokeEffectDuration;
		private CUInt32 _smokeVisionBlockerId;
		private CBool _isSmokeEffectActive;
		private CFloat _smokeVFXDeescalationOffset;
		private CFloat _cpoTimeBeforeRelease;

		[Ordinal(42)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetProperty(ref _projectileComponent);
			set => SetProperty(ref _projectileComponent, value);
		}

		[Ordinal(43)] 
		[RED("user")] 
		public wCHandle<gameObject> User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}

		[Ordinal(44)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetProperty(ref _projectileSpawnPoint);
			set => SetProperty(ref _projectileSpawnPoint, value);
		}

		[Ordinal(45)] 
		[RED("shootCollision")] 
		public CHandle<entSimpleColliderComponent> ShootCollision
		{
			get => GetProperty(ref _shootCollision);
			set => SetProperty(ref _shootCollision, value);
		}

		[Ordinal(46)] 
		[RED("visualComponent")] 
		public CHandle<entIComponent> VisualComponent
		{
			get => GetProperty(ref _visualComponent);
			set => SetProperty(ref _visualComponent, value);
		}

		[Ordinal(47)] 
		[RED("stickyMeshComponent")] 
		public CHandle<entIComponent> StickyMeshComponent
		{
			get => GetProperty(ref _stickyMeshComponent);
			set => SetProperty(ref _stickyMeshComponent, value);
		}

		[Ordinal(48)] 
		[RED("decalsStickyComponent")] 
		public CHandle<entIComponent> DecalsStickyComponent
		{
			get => GetProperty(ref _decalsStickyComponent);
			set => SetProperty(ref _decalsStickyComponent, value);
		}

		[Ordinal(49)] 
		[RED("homingMeshComponent")] 
		public CHandle<entIComponent> HomingMeshComponent
		{
			get => GetProperty(ref _homingMeshComponent);
			set => SetProperty(ref _homingMeshComponent, value);
		}

		[Ordinal(50)] 
		[RED("targetingComponent")] 
		public CHandle<gameTargetingComponent> TargetingComponent
		{
			get => GetProperty(ref _targetingComponent);
			set => SetProperty(ref _targetingComponent, value);
		}

		[Ordinal(51)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetProperty(ref _resourceLibraryComponent);
			set => SetProperty(ref _resourceLibraryComponent, value);
		}

		[Ordinal(52)] 
		[RED("mappinID")] 
		public gameNewMappinID MappinID
		{
			get => GetProperty(ref _mappinID);
			set => SetProperty(ref _mappinID, value);
		}

		[Ordinal(53)] 
		[RED("timeSinceLaunch")] 
		public CFloat TimeSinceLaunch
		{
			get => GetProperty(ref _timeSinceLaunch);
			set => SetProperty(ref _timeSinceLaunch, value);
		}

		[Ordinal(54)] 
		[RED("timeSinceExplosion")] 
		public CFloat TimeSinceExplosion
		{
			get => GetProperty(ref _timeSinceExplosion);
			set => SetProperty(ref _timeSinceExplosion, value);
		}

		[Ordinal(55)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetProperty(ref _detonationTimer);
			set => SetProperty(ref _detonationTimer, value);
		}

		[Ordinal(56)] 
		[RED("stickyTrackerTimeout")] 
		public CFloat StickyTrackerTimeout
		{
			get => GetProperty(ref _stickyTrackerTimeout);
			set => SetProperty(ref _stickyTrackerTimeout, value);
		}

		[Ordinal(57)] 
		[RED("timeOfFreezing")] 
		public CFloat TimeOfFreezing
		{
			get => GetProperty(ref _timeOfFreezing);
			set => SetProperty(ref _timeOfFreezing, value);
		}

		[Ordinal(58)] 
		[RED("spawnBlinkEffectDelayID")] 
		public gameDelayID SpawnBlinkEffectDelayID
		{
			get => GetProperty(ref _spawnBlinkEffectDelayID);
			set => SetProperty(ref _spawnBlinkEffectDelayID, value);
		}

		[Ordinal(59)] 
		[RED("detonateRequestDelayID")] 
		public gameDelayID DetonateRequestDelayID
		{
			get => GetProperty(ref _detonateRequestDelayID);
			set => SetProperty(ref _detonateRequestDelayID, value);
		}

		[Ordinal(60)] 
		[RED("releaseRequestDelayID")] 
		public gameDelayID ReleaseRequestDelayID
		{
			get => GetProperty(ref _releaseRequestDelayID);
			set => SetProperty(ref _releaseRequestDelayID, value);
		}

		[Ordinal(61)] 
		[RED("delayToDetonate")] 
		public CFloat DelayToDetonate
		{
			get => GetProperty(ref _delayToDetonate);
			set => SetProperty(ref _delayToDetonate, value);
		}

		[Ordinal(62)] 
		[RED("detonationTimerActive")] 
		public CBool DetonationTimerActive
		{
			get => GetProperty(ref _detonationTimerActive);
			set => SetProperty(ref _detonationTimerActive, value);
		}

		[Ordinal(63)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(64)] 
		[RED("isSinking")] 
		public CBool IsSinking
		{
			get => GetProperty(ref _isSinking);
			set => SetProperty(ref _isSinking, value);
		}

		[Ordinal(65)] 
		[RED("landedOnGround")] 
		public CBool LandedOnGround
		{
			get => GetProperty(ref _landedOnGround);
			set => SetProperty(ref _landedOnGround, value);
		}

		[Ordinal(66)] 
		[RED("isStuck")] 
		public CBool IsStuck
		{
			get => GetProperty(ref _isStuck);
			set => SetProperty(ref _isStuck, value);
		}

		[Ordinal(67)] 
		[RED("isTracking")] 
		public CBool IsTracking
		{
			get => GetProperty(ref _isTracking);
			set => SetProperty(ref _isTracking, value);
		}

		[Ordinal(68)] 
		[RED("isLockingOn")] 
		public CBool IsLockingOn
		{
			get => GetProperty(ref _isLockingOn);
			set => SetProperty(ref _isLockingOn, value);
		}

		[Ordinal(69)] 
		[RED("isLockedOn")] 
		public CBool IsLockedOn
		{
			get => GetProperty(ref _isLockedOn);
			set => SetProperty(ref _isLockedOn, value);
		}

		[Ordinal(70)] 
		[RED("readyToTrack")] 
		public CBool ReadyToTrack
		{
			get => GetProperty(ref _readyToTrack);
			set => SetProperty(ref _readyToTrack, value);
		}

		[Ordinal(71)] 
		[RED("lockOnFailed")] 
		public CBool LockOnFailed
		{
			get => GetProperty(ref _lockOnFailed);
			set => SetProperty(ref _lockOnFailed, value);
		}

		[Ordinal(72)] 
		[RED("canBeShot")] 
		public CBool CanBeShot
		{
			get => GetProperty(ref _canBeShot);
			set => SetProperty(ref _canBeShot, value);
		}

		[Ordinal(73)] 
		[RED("shotDownByThePlayer")] 
		public CBool ShotDownByThePlayer
		{
			get => GetProperty(ref _shotDownByThePlayer);
			set => SetProperty(ref _shotDownByThePlayer, value);
		}

		[Ordinal(74)] 
		[RED("forceExplosion")] 
		public CBool ForceExplosion
		{
			get => GetProperty(ref _forceExplosion);
			set => SetProperty(ref _forceExplosion, value);
		}

		[Ordinal(75)] 
		[RED("hasClearedIgnoredObject")] 
		public CBool HasClearedIgnoredObject
		{
			get => GetProperty(ref _hasClearedIgnoredObject);
			set => SetProperty(ref _hasClearedIgnoredObject, value);
		}

		[Ordinal(76)] 
		[RED("detonateOnImpact")] 
		public CBool DetonateOnImpact
		{
			get => GetProperty(ref _detonateOnImpact);
			set => SetProperty(ref _detonateOnImpact, value);
		}

		[Ordinal(77)] 
		[RED("setStickyTracker")] 
		public CBool SetStickyTracker
		{
			get => GetProperty(ref _setStickyTracker);
			set => SetProperty(ref _setStickyTracker, value);
		}

		[Ordinal(78)] 
		[RED("isContinuousEffect")] 
		public CBool IsContinuousEffect
		{
			get => GetProperty(ref _isContinuousEffect);
			set => SetProperty(ref _isContinuousEffect, value);
		}

		[Ordinal(79)] 
		[RED("additionalAttackOnDetonate")] 
		public CBool AdditionalAttackOnDetonate
		{
			get => GetProperty(ref _additionalAttackOnDetonate);
			set => SetProperty(ref _additionalAttackOnDetonate, value);
		}

		[Ordinal(80)] 
		[RED("additionalAttackOnCollision")] 
		public CBool AdditionalAttackOnCollision
		{
			get => GetProperty(ref _additionalAttackOnCollision);
			set => SetProperty(ref _additionalAttackOnCollision, value);
		}

		[Ordinal(81)] 
		[RED("targetAcquired")] 
		public CBool TargetAcquired
		{
			get => GetProperty(ref _targetAcquired);
			set => SetProperty(ref _targetAcquired, value);
		}

		[Ordinal(82)] 
		[RED("collidedWithNPC")] 
		public CBool CollidedWithNPC
		{
			get => GetProperty(ref _collidedWithNPC);
			set => SetProperty(ref _collidedWithNPC, value);
		}

		[Ordinal(83)] 
		[RED("isBroadcastingStim")] 
		public CBool IsBroadcastingStim
		{
			get => GetProperty(ref _isBroadcastingStim);
			set => SetProperty(ref _isBroadcastingStim, value);
		}

		[Ordinal(84)] 
		[RED("playingFastBeep")] 
		public CBool PlayingFastBeep
		{
			get => GetProperty(ref _playingFastBeep);
			set => SetProperty(ref _playingFastBeep, value);
		}

		[Ordinal(85)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetProperty(ref _hasExploded);
			set => SetProperty(ref _hasExploded, value);
		}

		[Ordinal(86)] 
		[RED("targetTracker")] 
		public CHandle<gameEffectInstance> TargetTracker
		{
			get => GetProperty(ref _targetTracker);
			set => SetProperty(ref _targetTracker, value);
		}

		[Ordinal(87)] 
		[RED("potentialHomingTargets")] 
		public CArray<GrenadePotentialHomingTarget> PotentialHomingTargets
		{
			get => GetProperty(ref _potentialHomingTargets);
			set => SetProperty(ref _potentialHomingTargets, value);
		}

		[Ordinal(88)] 
		[RED("homingGrenadeTarget")] 
		public GrenadePotentialHomingTarget HomingGrenadeTarget
		{
			get => GetProperty(ref _homingGrenadeTarget);
			set => SetProperty(ref _homingGrenadeTarget, value);
		}

		[Ordinal(89)] 
		[RED("cuttingGrenadePotentialTargets")] 
		public CArray<CuttingGrenadePotentialTarget> CuttingGrenadePotentialTargets
		{
			get => GetProperty(ref _cuttingGrenadePotentialTargets);
			set => SetProperty(ref _cuttingGrenadePotentialTargets, value);
		}

		[Ordinal(90)] 
		[RED("drillTargetPosition")] 
		public Vector4 DrillTargetPosition
		{
			get => GetProperty(ref _drillTargetPosition);
			set => SetProperty(ref _drillTargetPosition, value);
		}

		[Ordinal(91)] 
		[RED("attacksSpawned")] 
		public CArray<CHandle<gameEffectInstance>> AttacksSpawned
		{
			get => GetProperty(ref _attacksSpawned);
			set => SetProperty(ref _attacksSpawned, value);
		}

		[Ordinal(92)] 
		[RED("tweakRecord")] 
		public CHandle<gamedataGrenade_Record> TweakRecord
		{
			get => GetProperty(ref _tweakRecord);
			set => SetProperty(ref _tweakRecord, value);
		}

		[Ordinal(93)] 
		[RED("additionalEffect")] 
		public gameFxResource AdditionalEffect
		{
			get => GetProperty(ref _additionalEffect);
			set => SetProperty(ref _additionalEffect, value);
		}

		[Ordinal(94)] 
		[RED("landedCooldownActive")] 
		public CBool LandedCooldownActive
		{
			get => GetProperty(ref _landedCooldownActive);
			set => SetProperty(ref _landedCooldownActive, value);
		}

		[Ordinal(95)] 
		[RED("landedCooldownTimer")] 
		public CFloat LandedCooldownTimer
		{
			get => GetProperty(ref _landedCooldownTimer);
			set => SetProperty(ref _landedCooldownTimer, value);
		}

		[Ordinal(96)] 
		[RED("hasHitWater")] 
		public CBool HasHitWater
		{
			get => GetProperty(ref _hasHitWater);
			set => SetProperty(ref _hasHitWater, value);
		}

		[Ordinal(97)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetProperty(ref _waterHeight);
			set => SetProperty(ref _waterHeight, value);
		}

		[Ordinal(98)] 
		[RED("smokeEffectRadius")] 
		public CFloat SmokeEffectRadius
		{
			get => GetProperty(ref _smokeEffectRadius);
			set => SetProperty(ref _smokeEffectRadius, value);
		}

		[Ordinal(99)] 
		[RED("smokeEffectDuration")] 
		public CFloat SmokeEffectDuration
		{
			get => GetProperty(ref _smokeEffectDuration);
			set => SetProperty(ref _smokeEffectDuration, value);
		}

		[Ordinal(100)] 
		[RED("smokeVisionBlockerId")] 
		public CUInt32 SmokeVisionBlockerId
		{
			get => GetProperty(ref _smokeVisionBlockerId);
			set => SetProperty(ref _smokeVisionBlockerId, value);
		}

		[Ordinal(101)] 
		[RED("isSmokeEffectActive")] 
		public CBool IsSmokeEffectActive
		{
			get => GetProperty(ref _isSmokeEffectActive);
			set => SetProperty(ref _isSmokeEffectActive, value);
		}

		[Ordinal(102)] 
		[RED("smokeVFXDeescalationOffset")] 
		public CFloat SmokeVFXDeescalationOffset
		{
			get => GetProperty(ref _smokeVFXDeescalationOffset);
			set => SetProperty(ref _smokeVFXDeescalationOffset, value);
		}

		[Ordinal(103)] 
		[RED("cpoTimeBeforeRelease")] 
		public CFloat CpoTimeBeforeRelease
		{
			get => GetProperty(ref _cpoTimeBeforeRelease);
			set => SetProperty(ref _cpoTimeBeforeRelease, value);
		}

		public BaseGrenade(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
