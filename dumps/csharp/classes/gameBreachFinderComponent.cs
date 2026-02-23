using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameBreachFinderComponent : entIComponent
	{
		private wCHandle<gameObject> _owner;
		private CHandle<gameGameAudioSystem> _audioSystem;
		private CHandle<gameStatsSystem> _statsSystem;
		private CInt32 _hitCount;
		private CBool _almostTimeout;
		private CFloat _breachDurationMin;
		private CFloat _breachDurationMax;
		private CFloat _breachDurationIncreasePerStreak;
		private CFloat _breachDurationIncreaseForAnyStreak;
		private CFloat _breachDurationIncreaseOnFirstLookat;
		private CFloat _breachDurationIncreaseOnFirstHit;
		private CFloat _breachCooldownMin;
		private CFloat _breachCooldownMax;
		private CFloat _breachCooldownDecreasePerStreak;
		private CHandle<gamedataAttack_GameEffect_Record> _onBreachDestroyedAttackRecord;
		private CFloat _onBreachDestroyedHealthToDamage;
		private CFloat _onBreachDestroyedHealthToDamageBoss;
		private CFloat _desiredBreachDuration;
		private CFloat _cooldownAfterBreach;

		[Ordinal(3)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(4)] 
		[RED("audioSystem")] 
		public CHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetProperty(ref _audioSystem);
			set => SetProperty(ref _audioSystem, value);
		}

		[Ordinal(5)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(6)] 
		[RED("hitCount")] 
		public CInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(7)] 
		[RED("almostTimeout")] 
		public CBool AlmostTimeout
		{
			get => GetProperty(ref _almostTimeout);
			set => SetProperty(ref _almostTimeout, value);
		}

		[Ordinal(8)] 
		[RED("breachDurationMin")] 
		public CFloat BreachDurationMin
		{
			get => GetProperty(ref _breachDurationMin);
			set => SetProperty(ref _breachDurationMin, value);
		}

		[Ordinal(9)] 
		[RED("breachDurationMax")] 
		public CFloat BreachDurationMax
		{
			get => GetProperty(ref _breachDurationMax);
			set => SetProperty(ref _breachDurationMax, value);
		}

		[Ordinal(10)] 
		[RED("breachDurationIncreasePerStreak")] 
		public CFloat BreachDurationIncreasePerStreak
		{
			get => GetProperty(ref _breachDurationIncreasePerStreak);
			set => SetProperty(ref _breachDurationIncreasePerStreak, value);
		}

		[Ordinal(11)] 
		[RED("breachDurationIncreaseForAnyStreak")] 
		public CFloat BreachDurationIncreaseForAnyStreak
		{
			get => GetProperty(ref _breachDurationIncreaseForAnyStreak);
			set => SetProperty(ref _breachDurationIncreaseForAnyStreak, value);
		}

		[Ordinal(12)] 
		[RED("breachDurationIncreaseOnFirstLookat")] 
		public CFloat BreachDurationIncreaseOnFirstLookat
		{
			get => GetProperty(ref _breachDurationIncreaseOnFirstLookat);
			set => SetProperty(ref _breachDurationIncreaseOnFirstLookat, value);
		}

		[Ordinal(13)] 
		[RED("breachDurationIncreaseOnFirstHit")] 
		public CFloat BreachDurationIncreaseOnFirstHit
		{
			get => GetProperty(ref _breachDurationIncreaseOnFirstHit);
			set => SetProperty(ref _breachDurationIncreaseOnFirstHit, value);
		}

		[Ordinal(14)] 
		[RED("breachCooldownMin")] 
		public CFloat BreachCooldownMin
		{
			get => GetProperty(ref _breachCooldownMin);
			set => SetProperty(ref _breachCooldownMin, value);
		}

		[Ordinal(15)] 
		[RED("breachCooldownMax")] 
		public CFloat BreachCooldownMax
		{
			get => GetProperty(ref _breachCooldownMax);
			set => SetProperty(ref _breachCooldownMax, value);
		}

		[Ordinal(16)] 
		[RED("breachCooldownDecreasePerStreak")] 
		public CFloat BreachCooldownDecreasePerStreak
		{
			get => GetProperty(ref _breachCooldownDecreasePerStreak);
			set => SetProperty(ref _breachCooldownDecreasePerStreak, value);
		}

		[Ordinal(17)] 
		[RED("onBreachDestroyedAttackRecord")] 
		public CHandle<gamedataAttack_GameEffect_Record> OnBreachDestroyedAttackRecord
		{
			get => GetProperty(ref _onBreachDestroyedAttackRecord);
			set => SetProperty(ref _onBreachDestroyedAttackRecord, value);
		}

		[Ordinal(18)] 
		[RED("onBreachDestroyedHealthToDamage")] 
		public CFloat OnBreachDestroyedHealthToDamage
		{
			get => GetProperty(ref _onBreachDestroyedHealthToDamage);
			set => SetProperty(ref _onBreachDestroyedHealthToDamage, value);
		}

		[Ordinal(19)] 
		[RED("onBreachDestroyedHealthToDamageBoss")] 
		public CFloat OnBreachDestroyedHealthToDamageBoss
		{
			get => GetProperty(ref _onBreachDestroyedHealthToDamageBoss);
			set => SetProperty(ref _onBreachDestroyedHealthToDamageBoss, value);
		}

		[Ordinal(20)] 
		[RED("desiredBreachDuration")] 
		public CFloat DesiredBreachDuration
		{
			get => GetProperty(ref _desiredBreachDuration);
			set => SetProperty(ref _desiredBreachDuration, value);
		}

		[Ordinal(21)] 
		[RED("cooldownAfterBreach")] 
		public CFloat CooldownAfterBreach
		{
			get => GetProperty(ref _cooldownAfterBreach);
			set => SetProperty(ref _cooldownAfterBreach, value);
		}

		public gameBreachFinderComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
