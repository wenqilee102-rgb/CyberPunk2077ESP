using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleSmartBullet : BaseProjectile
	{
		private CHandle<entIComponent> _meshComponent;
		private gameEffectRef _effect;
		private CFloat _countTime;
		private CFloat _startVelocity;
		private CFloat _lifetime_448;
		private CFloat _bendTimeRatio;
		private CFloat _bendFactor;
		private CBool _useParabolicPhase;
		private CFloat _parabolicVelocityMin;
		private CFloat _parabolicVelocityMax;
		private CFloat _parabolicDuration;
		private Vector4 _parabolicGravity;
		private CHandle<gameprojectileSpiralParams> _spiralParams;
		private CBool _useSpiralParams;
		private CBool _alive;
		private CBool _hit;
		private CName _trailName;
		private CHandle<gameStatsSystem> _statsSystem;
		private entEntityID _weaponID;
		private CHandle<gameprojectileParabolicTrajectoryParams> _parabolicPhaseParams;
		private CHandle<gameprojectileFollowCurveTrajectoryParams> _followPhaseParams;
		private CHandle<gameprojectileLinearTrajectoryParams> _linearPhaseParams;
		private CBool _targeted;
		private CBool _trailStarted;
		private CEnum<ESmartBulletPhase> _phase;
		private CFloat _timeInPhase;
		private CFloat _randStartVelocity;
		private CFloat _smartGunMissDelay;
		private CFloat _smartGunHitProbability;
		private CFloat _smartGunMissRadius;
		private CFloat _randomWeaponMissChance;
		private CFloat _randomTargetMissChance;
		private CBool _readyToMiss;
		private CBool _stopAndDropOnTargetingDisruption;
		private CBool _shouldStopAndDrop;
		private entEntityID _targetID;
		private entEntityID _ignoredTargetID;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameObject> _weapon;
		private Vector4 _startPosition;
		private CBool _hasExploded;
		private CHandle<gameIAttack> _attack;
		private CHandle<BulletCollisionEvaluator> _bulletCollisionEvaluator;
		private wCHandle<gameTargetingComponent> _trackedTargetComponent;

		[Ordinal(48)] 
		[RED("meshComponent")] 
		public CHandle<entIComponent> MeshComponent
		{
			get => GetProperty(ref _meshComponent);
			set => SetProperty(ref _meshComponent, value);
		}

		[Ordinal(49)] 
		[RED("effect")] 
		public gameEffectRef Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(50)] 
		[RED("countTime")] 
		public CFloat CountTime
		{
			get => GetProperty(ref _countTime);
			set => SetProperty(ref _countTime, value);
		}

		[Ordinal(51)] 
		[RED("startVelocity")] 
		public CFloat StartVelocity
		{
			get => GetProperty(ref _startVelocity);
			set => SetProperty(ref _startVelocity, value);
		}

		[Ordinal(52)] 
		[RED("lifetime")] 
		public CFloat Lifetime_448
		{
			get => GetProperty(ref _lifetime_448);
			set => SetProperty(ref _lifetime_448, value);
		}

		[Ordinal(53)] 
		[RED("bendTimeRatio")] 
		public CFloat BendTimeRatio
		{
			get => GetProperty(ref _bendTimeRatio);
			set => SetProperty(ref _bendTimeRatio, value);
		}

		[Ordinal(54)] 
		[RED("bendFactor")] 
		public CFloat BendFactor
		{
			get => GetProperty(ref _bendFactor);
			set => SetProperty(ref _bendFactor, value);
		}

		[Ordinal(55)] 
		[RED("useParabolicPhase")] 
		public CBool UseParabolicPhase
		{
			get => GetProperty(ref _useParabolicPhase);
			set => SetProperty(ref _useParabolicPhase, value);
		}

		[Ordinal(56)] 
		[RED("parabolicVelocityMin")] 
		public CFloat ParabolicVelocityMin
		{
			get => GetProperty(ref _parabolicVelocityMin);
			set => SetProperty(ref _parabolicVelocityMin, value);
		}

		[Ordinal(57)] 
		[RED("parabolicVelocityMax")] 
		public CFloat ParabolicVelocityMax
		{
			get => GetProperty(ref _parabolicVelocityMax);
			set => SetProperty(ref _parabolicVelocityMax, value);
		}

		[Ordinal(58)] 
		[RED("parabolicDuration")] 
		public CFloat ParabolicDuration
		{
			get => GetProperty(ref _parabolicDuration);
			set => SetProperty(ref _parabolicDuration, value);
		}

		[Ordinal(59)] 
		[RED("parabolicGravity")] 
		public Vector4 ParabolicGravity
		{
			get => GetProperty(ref _parabolicGravity);
			set => SetProperty(ref _parabolicGravity, value);
		}

		[Ordinal(60)] 
		[RED("spiralParams")] 
		public CHandle<gameprojectileSpiralParams> SpiralParams
		{
			get => GetProperty(ref _spiralParams);
			set => SetProperty(ref _spiralParams, value);
		}

		[Ordinal(61)] 
		[RED("useSpiralParams")] 
		public CBool UseSpiralParams
		{
			get => GetProperty(ref _useSpiralParams);
			set => SetProperty(ref _useSpiralParams, value);
		}

		[Ordinal(62)] 
		[RED("alive")] 
		public CBool Alive
		{
			get => GetProperty(ref _alive);
			set => SetProperty(ref _alive, value);
		}

		[Ordinal(63)] 
		[RED("hit")] 
		public CBool Hit
		{
			get => GetProperty(ref _hit);
			set => SetProperty(ref _hit, value);
		}

		[Ordinal(64)] 
		[RED("trailName")] 
		public CName TrailName
		{
			get => GetProperty(ref _trailName);
			set => SetProperty(ref _trailName, value);
		}

		[Ordinal(65)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(66)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(67)] 
		[RED("parabolicPhaseParams")] 
		public CHandle<gameprojectileParabolicTrajectoryParams> ParabolicPhaseParams
		{
			get => GetProperty(ref _parabolicPhaseParams);
			set => SetProperty(ref _parabolicPhaseParams, value);
		}

		[Ordinal(68)] 
		[RED("followPhaseParams")] 
		public CHandle<gameprojectileFollowCurveTrajectoryParams> FollowPhaseParams
		{
			get => GetProperty(ref _followPhaseParams);
			set => SetProperty(ref _followPhaseParams, value);
		}

		[Ordinal(69)] 
		[RED("linearPhaseParams")] 
		public CHandle<gameprojectileLinearTrajectoryParams> LinearPhaseParams
		{
			get => GetProperty(ref _linearPhaseParams);
			set => SetProperty(ref _linearPhaseParams, value);
		}

		[Ordinal(70)] 
		[RED("targeted")] 
		public CBool Targeted
		{
			get => GetProperty(ref _targeted);
			set => SetProperty(ref _targeted, value);
		}

		[Ordinal(71)] 
		[RED("trailStarted")] 
		public CBool TrailStarted
		{
			get => GetProperty(ref _trailStarted);
			set => SetProperty(ref _trailStarted, value);
		}

		[Ordinal(72)] 
		[RED("phase")] 
		public CEnum<ESmartBulletPhase> Phase
		{
			get => GetProperty(ref _phase);
			set => SetProperty(ref _phase, value);
		}

		[Ordinal(73)] 
		[RED("timeInPhase")] 
		public CFloat TimeInPhase
		{
			get => GetProperty(ref _timeInPhase);
			set => SetProperty(ref _timeInPhase, value);
		}

		[Ordinal(74)] 
		[RED("randStartVelocity")] 
		public CFloat RandStartVelocity
		{
			get => GetProperty(ref _randStartVelocity);
			set => SetProperty(ref _randStartVelocity, value);
		}

		[Ordinal(75)] 
		[RED("smartGunMissDelay")] 
		public CFloat SmartGunMissDelay
		{
			get => GetProperty(ref _smartGunMissDelay);
			set => SetProperty(ref _smartGunMissDelay, value);
		}

		[Ordinal(76)] 
		[RED("smartGunHitProbability")] 
		public CFloat SmartGunHitProbability
		{
			get => GetProperty(ref _smartGunHitProbability);
			set => SetProperty(ref _smartGunHitProbability, value);
		}

		[Ordinal(77)] 
		[RED("smartGunMissRadius")] 
		public CFloat SmartGunMissRadius
		{
			get => GetProperty(ref _smartGunMissRadius);
			set => SetProperty(ref _smartGunMissRadius, value);
		}

		[Ordinal(78)] 
		[RED("randomWeaponMissChance")] 
		public CFloat RandomWeaponMissChance
		{
			get => GetProperty(ref _randomWeaponMissChance);
			set => SetProperty(ref _randomWeaponMissChance, value);
		}

		[Ordinal(79)] 
		[RED("randomTargetMissChance")] 
		public CFloat RandomTargetMissChance
		{
			get => GetProperty(ref _randomTargetMissChance);
			set => SetProperty(ref _randomTargetMissChance, value);
		}

		[Ordinal(80)] 
		[RED("readyToMiss")] 
		public CBool ReadyToMiss
		{
			get => GetProperty(ref _readyToMiss);
			set => SetProperty(ref _readyToMiss, value);
		}

		[Ordinal(81)] 
		[RED("stopAndDropOnTargetingDisruption")] 
		public CBool StopAndDropOnTargetingDisruption
		{
			get => GetProperty(ref _stopAndDropOnTargetingDisruption);
			set => SetProperty(ref _stopAndDropOnTargetingDisruption, value);
		}

		[Ordinal(82)] 
		[RED("shouldStopAndDrop")] 
		public CBool ShouldStopAndDrop
		{
			get => GetProperty(ref _shouldStopAndDrop);
			set => SetProperty(ref _shouldStopAndDrop, value);
		}

		[Ordinal(83)] 
		[RED("targetID")] 
		public entEntityID TargetID
		{
			get => GetProperty(ref _targetID);
			set => SetProperty(ref _targetID, value);
		}

		[Ordinal(84)] 
		[RED("ignoredTargetID")] 
		public entEntityID IgnoredTargetID
		{
			get => GetProperty(ref _ignoredTargetID);
			set => SetProperty(ref _ignoredTargetID, value);
		}

		[Ordinal(85)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(86)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(87)] 
		[RED("startPosition")] 
		public Vector4 StartPosition
		{
			get => GetProperty(ref _startPosition);
			set => SetProperty(ref _startPosition, value);
		}

		[Ordinal(88)] 
		[RED("hasExploded")] 
		public CBool HasExploded
		{
			get => GetProperty(ref _hasExploded);
			set => SetProperty(ref _hasExploded, value);
		}

		[Ordinal(89)] 
		[RED("attack")] 
		public CHandle<gameIAttack> Attack
		{
			get => GetProperty(ref _attack);
			set => SetProperty(ref _attack, value);
		}

		[Ordinal(90)] 
		[RED("BulletCollisionEvaluator")] 
		public CHandle<BulletCollisionEvaluator> BulletCollisionEvaluator
		{
			get => GetProperty(ref _bulletCollisionEvaluator);
			set => SetProperty(ref _bulletCollisionEvaluator, value);
		}

		[Ordinal(91)] 
		[RED("trackedTargetComponent")] 
		public wCHandle<gameTargetingComponent> TrackedTargetComponent
		{
			get => GetProperty(ref _trackedTargetComponent);
			set => SetProperty(ref _trackedTargetComponent, value);
		}

		public sampleSmartBullet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
