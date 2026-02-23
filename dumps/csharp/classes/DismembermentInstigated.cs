using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DismembermentInstigated : redEvent
	{
		private wCHandle<gameObject> _target;
		private Vector4 _targetPosition;
		private Vector4 _attackPosition;
		private CEnum<EHitReactionZone> _bodyPart;
		private CHandle<gamedataWeaponItem_Record> _weaponRecord;
		private CEnum<gamedataAttackType> _attackType;
		private CEnum<gamedataAttackSubtype> _attackSubtype;
		private CFloat _timeSinceDeath;
		private CFloat _timeSinceDefeat;
		private CBool _targetIsDead;
		private CBool _targetIsDefeated;
		private CBool _attackIsExplosion;

		[Ordinal(0)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(1)] 
		[RED("targetPosition")] 
		public Vector4 TargetPosition
		{
			get => GetProperty(ref _targetPosition);
			set => SetProperty(ref _targetPosition, value);
		}

		[Ordinal(2)] 
		[RED("attackPosition")] 
		public Vector4 AttackPosition
		{
			get => GetProperty(ref _attackPosition);
			set => SetProperty(ref _attackPosition, value);
		}

		[Ordinal(3)] 
		[RED("bodyPart")] 
		public CEnum<EHitReactionZone> BodyPart
		{
			get => GetProperty(ref _bodyPart);
			set => SetProperty(ref _bodyPart, value);
		}

		[Ordinal(4)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetProperty(ref _weaponRecord);
			set => SetProperty(ref _weaponRecord, value);
		}

		[Ordinal(5)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(6)] 
		[RED("attackSubtype")] 
		public CEnum<gamedataAttackSubtype> AttackSubtype
		{
			get => GetProperty(ref _attackSubtype);
			set => SetProperty(ref _attackSubtype, value);
		}

		[Ordinal(7)] 
		[RED("timeSinceDeath")] 
		public CFloat TimeSinceDeath
		{
			get => GetProperty(ref _timeSinceDeath);
			set => SetProperty(ref _timeSinceDeath, value);
		}

		[Ordinal(8)] 
		[RED("timeSinceDefeat")] 
		public CFloat TimeSinceDefeat
		{
			get => GetProperty(ref _timeSinceDefeat);
			set => SetProperty(ref _timeSinceDefeat, value);
		}

		[Ordinal(9)] 
		[RED("targetIsDead")] 
		public CBool TargetIsDead
		{
			get => GetProperty(ref _targetIsDead);
			set => SetProperty(ref _targetIsDead, value);
		}

		[Ordinal(10)] 
		[RED("targetIsDefeated")] 
		public CBool TargetIsDefeated
		{
			get => GetProperty(ref _targetIsDefeated);
			set => SetProperty(ref _targetIsDefeated, value);
		}

		[Ordinal(11)] 
		[RED("attackIsExplosion")] 
		public CBool AttackIsExplosion
		{
			get => GetProperty(ref _attackIsExplosion);
			set => SetProperty(ref _attackIsExplosion, value);
		}

		public DismembermentInstigated(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
