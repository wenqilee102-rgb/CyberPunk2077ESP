using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ThrowableKnifeNPC : BaseProjectile
	{
		private CHandle<entIComponent> _visualComponent;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private wCHandle<gameweaponObject> _weapon;
		private CHandle<gamedataAttack_Record> _attack_record;
		private CFloat _explosionRadius;
		private CHandle<gamedataGrenade_Record> _tweakRecord;
		private CBool _isActive;
		private CBool _hasHitWater;
		private CBool _projectileStopped;
		private CFloat _desiredLifetime;
		private CFloat _waterHeight;
		private CFloat _deactivationDepth;
		private CFloat _waterImpulseRadius;
		private CFloat _waterImpulseStrength;
		private CFloat _dbgCurrentLifetime;
		private CHandle<ThrowingMeleeCollisionEvaluator> _projectileCollisionEvaluator;

		[Ordinal(48)] 
		[RED("visualComponent")] 
		public CHandle<entIComponent> VisualComponent
		{
			get => GetProperty(ref _visualComponent);
			set => SetProperty(ref _visualComponent, value);
		}

		[Ordinal(49)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetProperty(ref _resourceLibraryComponent);
			set => SetProperty(ref _resourceLibraryComponent, value);
		}

		[Ordinal(50)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(51)] 
		[RED("attack_record")] 
		public CHandle<gamedataAttack_Record> Attack_record
		{
			get => GetProperty(ref _attack_record);
			set => SetProperty(ref _attack_record, value);
		}

		[Ordinal(52)] 
		[RED("explosionRadius")] 
		public CFloat ExplosionRadius
		{
			get => GetProperty(ref _explosionRadius);
			set => SetProperty(ref _explosionRadius, value);
		}

		[Ordinal(53)] 
		[RED("tweakRecord")] 
		public CHandle<gamedataGrenade_Record> TweakRecord
		{
			get => GetProperty(ref _tweakRecord);
			set => SetProperty(ref _tweakRecord, value);
		}

		[Ordinal(54)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(55)] 
		[RED("hasHitWater")] 
		public CBool HasHitWater
		{
			get => GetProperty(ref _hasHitWater);
			set => SetProperty(ref _hasHitWater, value);
		}

		[Ordinal(56)] 
		[RED("projectileStopped")] 
		public CBool ProjectileStopped
		{
			get => GetProperty(ref _projectileStopped);
			set => SetProperty(ref _projectileStopped, value);
		}

		[Ordinal(57)] 
		[RED("desiredLifetime")] 
		public CFloat DesiredLifetime
		{
			get => GetProperty(ref _desiredLifetime);
			set => SetProperty(ref _desiredLifetime, value);
		}

		[Ordinal(58)] 
		[RED("waterHeight")] 
		public CFloat WaterHeight
		{
			get => GetProperty(ref _waterHeight);
			set => SetProperty(ref _waterHeight, value);
		}

		[Ordinal(59)] 
		[RED("deactivationDepth")] 
		public CFloat DeactivationDepth
		{
			get => GetProperty(ref _deactivationDepth);
			set => SetProperty(ref _deactivationDepth, value);
		}

		[Ordinal(60)] 
		[RED("waterImpulseRadius")] 
		public CFloat WaterImpulseRadius
		{
			get => GetProperty(ref _waterImpulseRadius);
			set => SetProperty(ref _waterImpulseRadius, value);
		}

		[Ordinal(61)] 
		[RED("waterImpulseStrength")] 
		public CFloat WaterImpulseStrength
		{
			get => GetProperty(ref _waterImpulseStrength);
			set => SetProperty(ref _waterImpulseStrength, value);
		}

		[Ordinal(62)] 
		[RED("dbgCurrentLifetime")] 
		public CFloat DbgCurrentLifetime
		{
			get => GetProperty(ref _dbgCurrentLifetime);
			set => SetProperty(ref _dbgCurrentLifetime, value);
		}

		[Ordinal(63)] 
		[RED("projectileCollisionEvaluator")] 
		public CHandle<ThrowingMeleeCollisionEvaluator> ProjectileCollisionEvaluator
		{
			get => GetProperty(ref _projectileCollisionEvaluator);
			set => SetProperty(ref _projectileCollisionEvaluator, value);
		}

		public ThrowableKnifeNPC(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
