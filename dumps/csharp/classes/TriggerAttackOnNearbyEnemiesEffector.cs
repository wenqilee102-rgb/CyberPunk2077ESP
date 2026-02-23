using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TriggerAttackOnNearbyEnemiesEffector : gameEffector
	{
		private wCHandle<gameObject> _owner;
		private wCHandle<gamedataAttack_Record> _attackRecord;
		private CInt32 _targetHowManyEnemies;
		private CFloat _targetMaxDistance;
		private CFloat _targetMinDistance;
		private CBool _ignoreCivilians;
		private ScriptGameInstance _gameInstance;
		private CName _playVFXOnHitTargets;
		private wCHandle<gamedataStatusEffect_Record> _statusEffectRecord;
		private CName _enemySlotTransform;

		[Ordinal(0)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(1)] 
		[RED("attackRecord")] 
		public wCHandle<gamedataAttack_Record> AttackRecord
		{
			get => GetProperty(ref _attackRecord);
			set => SetProperty(ref _attackRecord, value);
		}

		[Ordinal(2)] 
		[RED("targetHowManyEnemies")] 
		public CInt32 TargetHowManyEnemies
		{
			get => GetProperty(ref _targetHowManyEnemies);
			set => SetProperty(ref _targetHowManyEnemies, value);
		}

		[Ordinal(3)] 
		[RED("targetMaxDistance")] 
		public CFloat TargetMaxDistance
		{
			get => GetProperty(ref _targetMaxDistance);
			set => SetProperty(ref _targetMaxDistance, value);
		}

		[Ordinal(4)] 
		[RED("targetMinDistance")] 
		public CFloat TargetMinDistance
		{
			get => GetProperty(ref _targetMinDistance);
			set => SetProperty(ref _targetMinDistance, value);
		}

		[Ordinal(5)] 
		[RED("ignoreCivilians")] 
		public CBool IgnoreCivilians
		{
			get => GetProperty(ref _ignoreCivilians);
			set => SetProperty(ref _ignoreCivilians, value);
		}

		[Ordinal(6)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(7)] 
		[RED("playVFXOnHitTargets")] 
		public CName PlayVFXOnHitTargets
		{
			get => GetProperty(ref _playVFXOnHitTargets);
			set => SetProperty(ref _playVFXOnHitTargets, value);
		}

		[Ordinal(8)] 
		[RED("statusEffectRecord")] 
		public wCHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetProperty(ref _statusEffectRecord);
			set => SetProperty(ref _statusEffectRecord, value);
		}

		[Ordinal(9)] 
		[RED("enemySlotTransform")] 
		public CName EnemySlotTransform
		{
			get => GetProperty(ref _enemySlotTransform);
			set => SetProperty(ref _enemySlotTransform, value);
		}

		public TriggerAttackOnNearbyEnemiesEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
