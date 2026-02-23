using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeBodySlamAttackEvents : MeleeEventsTransition
	{
		private CHandle<gameEffectInstance> _effect;
		private CHandle<gameStatModifierData_Deprecated> _speedModifier;
		private CHandle<gameStatModifierData_Deprecated> _stunModifier;
		private CInt32 _chargeStage;
		private CFloat _attackSpawnDelay;
		private CFloat _timeToFullAttack;
		private CFloat _nextAttackRefresh;
		private CBool _playBumpSFX;
		private CHandle<redCallbackObject> _bumpCallback;
		private CFloat _delayBetweenBumpSFX;
		private CFloat _bumpSFXCooldown;
		private CFloat _staminaCost;
		private CInt32 _fullAttackIndex;
		private CInt32 _weakAttackIndex;

		[Ordinal(2)] 
		[RED("effect")] 
		public CHandle<gameEffectInstance> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(3)] 
		[RED("speedModifier")] 
		public CHandle<gameStatModifierData_Deprecated> SpeedModifier
		{
			get => GetProperty(ref _speedModifier);
			set => SetProperty(ref _speedModifier, value);
		}

		[Ordinal(4)] 
		[RED("stunModifier")] 
		public CHandle<gameStatModifierData_Deprecated> StunModifier
		{
			get => GetProperty(ref _stunModifier);
			set => SetProperty(ref _stunModifier, value);
		}

		[Ordinal(5)] 
		[RED("chargeStage")] 
		public CInt32 ChargeStage
		{
			get => GetProperty(ref _chargeStage);
			set => SetProperty(ref _chargeStage, value);
		}

		[Ordinal(6)] 
		[RED("attackSpawnDelay")] 
		public CFloat AttackSpawnDelay
		{
			get => GetProperty(ref _attackSpawnDelay);
			set => SetProperty(ref _attackSpawnDelay, value);
		}

		[Ordinal(7)] 
		[RED("timeToFullAttack")] 
		public CFloat TimeToFullAttack
		{
			get => GetProperty(ref _timeToFullAttack);
			set => SetProperty(ref _timeToFullAttack, value);
		}

		[Ordinal(8)] 
		[RED("nextAttackRefresh")] 
		public CFloat NextAttackRefresh
		{
			get => GetProperty(ref _nextAttackRefresh);
			set => SetProperty(ref _nextAttackRefresh, value);
		}

		[Ordinal(9)] 
		[RED("playBumpSFX")] 
		public CBool PlayBumpSFX
		{
			get => GetProperty(ref _playBumpSFX);
			set => SetProperty(ref _playBumpSFX, value);
		}

		[Ordinal(10)] 
		[RED("bumpCallback")] 
		public CHandle<redCallbackObject> BumpCallback
		{
			get => GetProperty(ref _bumpCallback);
			set => SetProperty(ref _bumpCallback, value);
		}

		[Ordinal(11)] 
		[RED("delayBetweenBumpSFX")] 
		public CFloat DelayBetweenBumpSFX
		{
			get => GetProperty(ref _delayBetweenBumpSFX);
			set => SetProperty(ref _delayBetweenBumpSFX, value);
		}

		[Ordinal(12)] 
		[RED("bumpSFXCooldown")] 
		public CFloat BumpSFXCooldown
		{
			get => GetProperty(ref _bumpSFXCooldown);
			set => SetProperty(ref _bumpSFXCooldown, value);
		}

		[Ordinal(13)] 
		[RED("staminaCost")] 
		public CFloat StaminaCost
		{
			get => GetProperty(ref _staminaCost);
			set => SetProperty(ref _staminaCost, value);
		}

		[Ordinal(14)] 
		[RED("fullAttackIndex")] 
		public CInt32 FullAttackIndex
		{
			get => GetProperty(ref _fullAttackIndex);
			set => SetProperty(ref _fullAttackIndex, value);
		}

		[Ordinal(15)] 
		[RED("weakAttackIndex")] 
		public CInt32 WeakAttackIndex
		{
			get => GetProperty(ref _weakAttackIndex);
			set => SetProperty(ref _weakAttackIndex, value);
		}

		public MeleeBodySlamAttackEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
