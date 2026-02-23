using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProjectileLauncherRound : gameItemObject
	{
		private CHandle<gameprojectileComponent> _projectileComponent;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private wCHandle<gameObject> _user;
		private wCHandle<gameObject> _projectile;
		private wCHandle<gameweaponObject> _weapon;
		private Vector4 _projectileSpawnPoint;
		private CEnum<gamedataProjectileLaunchMode> _launchMode;
		private CFloat _initialLaunchVelocity;
		private gameItemID _installedProjectile;
		private CEnum<ELauncherActionType> _actionType;
		private CHandle<gamedataAttack_Record> _attackRecord;
		private gameDelayID _releaseRequestDelayID;
		private gameDelayID _detonateRequestDelayID;
		private CName _projectileTrailName;
		private CHandle<ProjectileLauncherRoundCollisionEvaluator> _projectileCollisionEvaluator;
		private CBool _isAlive;
		private CBool _isSinking;
		private CFloat _waterHeight;
		private CFloat _deepWaterDepth;
		private CFloat _sinkingDetonationDelay;
		private CFloat _waterSurfaceImpactImpulseRadius;
		private CFloat _waterSurfaceImpactImpulseStrength;
		private CFloat _waterDetonationImpulseRadius;
		private CFloat _waterDetonationImpulseStrength;

		[Ordinal(40)] 
		[RED("projectileComponent")] 
		public CHandle<gameprojectileComponent> ProjectileComponent
		{
			get => GetProperty(ref _projectileComponent);
			set => SetProperty(ref _projectileComponent, value);
		}

		[Ordinal(41)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetProperty(ref _resourceLibraryComponent);
			set => SetProperty(ref _resourceLibraryComponent, value);
		}

		[Ordinal(42)] 
		[RED("user")] 
		public wCHandle<gameObject> User
		{
			get => GetProperty(ref _user);
			set => SetProperty(ref _user, value);
		}

		[Ordinal(43)] 
		[RED("projectile")] 
		public wCHandle<gameObject> Projectile
		{
			get => GetProperty(ref _projectile);
			set => SetProperty(ref _projectile, value);
		}

		[Ordinal(44)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(45)] 
		[RED("projectileSpawnPoint")] 
		public Vector4 ProjectileSpawnPoint
		{
			get => GetProperty(ref _projectileSpawnPoint);
			set => SetProperty(ref _projectileSpawnPoint, value);
		}

		[Ordinal(46)] 
		[RED("launchMode")] 
		public CEnum<gamedataProjectileLaunchMode> LaunchMode
		{
			get => GetProperty(ref _launchMode);
			set => SetProperty(ref _launchMode, value);
		}

		[Ordinal(47)] 
		[RED("initialLaunchVelocity")] 
		public CFloat InitialLaunchVelocity
		{
			get => GetProperty(ref _initialLaunchVelocity);
			set => SetProperty(ref _initialLaunchVelocity, value);
		}

		[Ordinal(48)] 
		[RED("installedProjectile")] 
		public gameItemID InstalledProjectile
		{
			get => GetProperty(ref _installedProjectile);
			set => SetProperty(ref _installedProjectile, value);
		}

		[Ordinal(49)] 
		[RED("actionType")] 
		public CEnum<ELauncherActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(50)] 
		[RED("attackRecord")] 
		public CHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(51)] 
		[RED("releaseRequestDelayID")] 
		public gameDelayID ReleaseRequestDelayID
		{
			get => GetProperty(ref _releaseRequestDelayID);
			set => SetProperty(ref _releaseRequestDelayID, value);
		}

		[Ordinal(52)] 
		[RED("detonateRequestDelayID")] 
		public gameDelayID DetonateRequestDelayID
		{
			get => GetProperty(ref _detonateRequestDelayID);
			set => SetProperty(ref _detonateRequestDelayID, value);
		}

		[Ordinal(53)] 
		[RED("projectileTrailName")] 
		public CName ProjectileTrailName
		{
			get => GetProperty(ref _projectileTrailName);
			set => SetProperty(ref _projectileTrailName, value);
		}

		[Ordinal(54)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ProjectileLauncherRoundCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetProperty(ref _projectileCollisionEvaluator);
			set => SetProperty(ref _projectileCollisionEvaluator, value);
		}

		[Ordinal(55)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(56)] 
		[RED("isSinking")] 
		public CBool IsSinking
		{
			get => GetProperty(ref _isSinking);
			set => SetProperty(ref _isSinking, value);
		}

		[Ordinal(57)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetProperty(ref _waterHeight);
			set => SetProperty(ref _waterHeight, value);
		}

		[Ordinal(58)] 
		[RED("deepWaterDepth")] 
		public CFloat DeepWaterDepth
		{
			get => GetProperty(ref _deepWaterDepth);
			set => SetProperty(ref _deepWaterDepth, value);
		}

		[Ordinal(59)] 
		[RED("sinkingDetonationDelay")] 
		public CFloat SinkingDetonationDelay
		{
			get => GetProperty(ref _sinkingDetonationDelay);
			set => SetProperty(ref _sinkingDetonationDelay, value);
		}

		[Ordinal(60)] 
		[RED("waterSurfaceImpactImpulseRadius")] 
		public CFloat WaterSurfaceImpactImpulseRadius
		{
			get => GetProperty(ref _waterSurfaceImpactImpulseRadius);
			set => SetProperty(ref _waterSurfaceImpactImpulseRadius, value);
		}

		[Ordinal(61)] 
		[RED("waterSurfaceImpactImpulseStrength")] 
		public CFloat WaterSurfaceImpactImpulseStrength
		{
			get => GetProperty(ref _waterSurfaceImpactImpulseStrength);
			set => SetProperty(ref _waterSurfaceImpactImpulseStrength, value);
		}

		[Ordinal(62)] 
		[RED("waterDetonationImpulseRadius")] 
		public CFloat WaterDetonationImpulseRadius
		{
			get => GetProperty(ref _waterDetonationImpulseRadius);
			set => SetProperty(ref _waterDetonationImpulseRadius, value);
		}

		[Ordinal(63)] 
		[RED("waterDetonationImpulseStrength")] 
		public CFloat WaterDetonationImpulseStrength
		{
			get => GetProperty(ref _waterDetonationImpulseStrength);
			set => SetProperty(ref _waterDetonationImpulseStrength, value);
		}

		public ProjectileLauncherRound(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
