using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeProjectile : BaseProjectile
	{
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private TweakDBID _throwCooldownSE;
		private CBool _collided;
		private CBool _wasPicked;
		private CBool _isActive;
		private CBool _hasHitWater;
		private CFloat _waterHeight;
		private CFloat _deactivationDepth;
		private CFloat _waterImpulseRadius;
		private CFloat _waterImpulseStrength;
		private CFloat _gravitySimulationMult;
		private wCHandle<gameObject> _weapon;
		private CHandle<ThrowingMeleeReloadListener> _throwingMeleeResourcePoolListener;
		private CHandle<ThrowingMeleeCollisionEvaluator> _projectileCollisionEvaluator;
		private CBool _projectileStopped;
		private CBool _isCollidedWithEnemy;

		[Ordinal(48)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetProperty(ref _resourceLibraryComponent);
			set => SetProperty(ref _resourceLibraryComponent, value);
		}

		[Ordinal(49)] 
		[RED("throwCooldownSE")] 
		public TweakDBID ThrowCooldownSE
		{
			get => GetProperty(ref _throwCooldownSE);
			set => SetProperty(ref _throwCooldownSE, value);
		}

		[Ordinal(50)] 
		[RED("collided")] 
		public CBool Collided
		{
			get => GetProperty(ref _collided);
			set => SetProperty(ref _collided, value);
		}

		[Ordinal(51)] 
		[RED("wasPicked")] 
		public CBool WasPicked
		{
			get => GetProperty(ref _wasPicked);
			set => SetProperty(ref _wasPicked, value);
		}

		[Ordinal(52)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(53)] 
		[RED("hasHitWater")] 
		public CBool HasHitWater
		{
			get => GetProperty(ref _hasHitWater);
			set => SetProperty(ref _hasHitWater, value);
		}

		[Ordinal(54)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetProperty(ref _waterHeight);
			set => SetProperty(ref _waterHeight, value);
		}

		[Ordinal(55)] 
		[RED("deactivationDepth")] 
		public CFloat DeactivationDepth
		{
			get => GetProperty(ref _deactivationDepth);
			set => SetProperty(ref _deactivationDepth, value);
		}

		[Ordinal(56)] 
		[RED("waterImpulseRadius")] 
		public CFloat WaterImpulseRadius
		{
			get => GetProperty(ref _waterImpulseRadius);
			set => SetProperty(ref _waterImpulseRadius, value);
		}

		[Ordinal(57)] 
		[RED("waterImpulseStrength")] 
		public CFloat WaterImpulseStrength
		{
			get => GetProperty(ref _waterImpulseStrength);
			set => SetProperty(ref _waterImpulseStrength, value);
		}

		[Ordinal(58)] 
		[RED("gravitySimulationMult")] 
		public CFloat GravitySimulationMult
		{
			get => GetProperty(ref _gravitySimulationMult);
			set => SetProperty(ref _gravitySimulationMult, value);
		}

		[Ordinal(59)] 
		[RED("weapon")] 
		public wCHandle<gameObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(60)] 
		[RED("throwingMeleeResourcePoolListener")] 
		public CHandle<ThrowingMeleeReloadListener> ThrowingMeleeResourcePoolListener
		{
			get => GetProperty(ref _throwingMeleeResourcePoolListener);
			set => SetProperty(ref _throwingMeleeResourcePoolListener, value);
		}

		[Ordinal(61)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ThrowingMeleeCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetProperty(ref _projectileCollisionEvaluator);
			set => SetProperty(ref _projectileCollisionEvaluator, value);
		}

		[Ordinal(62)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get => GetProperty(ref _projectileStopped);
			set => SetProperty(ref _projectileStopped, value);
		}

		[Ordinal(63)] 
		[RED("isCollidedWithEnemy")] 
		public CBool IsCollidedWithEnemy
		{
			get => GetProperty(ref _isCollidedWithEnemy);
			set => SetProperty(ref _isCollidedWithEnemy, value);
		}

		public MeleeProjectile(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
