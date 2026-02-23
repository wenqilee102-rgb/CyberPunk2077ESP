using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitReactionComponent : AIMandatoryComponents
	{
		private wCHandle<NPCPuppet> _ownerNPC;
		private wCHandle<ScriptedPuppet> _ownerPuppet;
		private wCHandle<gameweaponObject> _ownerWeapon;
		private entEntityID _ownerID;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _ownerIsMassive;
		private CFloat _impactDamageDuration;
		private CFloat _staggerDamageDuration;
		private CFloat _impactDamageDurationMelee;
		private CFloat _staggerDamageDurationMelee;
		private CFloat _knockdownDamageDuration;
		private CFloat _defeatedMinDuration;
		private CFloat _previousHitTime;
		private CEnum<animHitReactionType> _reactionType;
		private CHandle<animAnimFeature_HitReactionsData> _animHitReaction;
		private CHandle<animAnimFeature_HitReactionsData> _lastAnimHitReaction;
		private CHandle<ActionHitReactionScriptProxy> _hitReactionAction;
		private CArray<ScriptHitData> _previousAnimHitReactionArray;
		private CEnum<EAILastHitReactionPlayed> _lastHitReactionPlayed;
		private gameShapeData _hitShapeData;
		private CInt32 _animVariation;
		private CFloat _specificHitTimeout;
		private CFloat _quickMeleeCooldown;
		private CArray<CFloat> _dismembermentBodyPartDamageThreshold;
		private CArray<CFloat> _woundedBodyPartDamageThreshold;
		private CArray<CFloat> _defeatedBodyPartDamageThreshold;
		private CFloat _defeatedDamageThreshold;
		private CFloat _impactDamageThreshold;
		private CFloat _staggerDamageThreshold;
		private CFloat _knockdownDamageThreshold;
		private CFloat _knockdownImpulseThreshold;
		private CBool _immuneToKnockDown;
		private CFloat _hitComboReset;
		private CFloat _physicalImpulseReset;
		private CFloat _guardBreakImpulseReset;
		private CFloat _cumulatedDamages;
		private CArray<CFloat> _bodyPartWoundCumulatedDamages;
		private CArray<CFloat> _bodyPartDismemberCumulatedDamages;
		private CFloat _attackerWeaponKnockdownImpulse;
		private CFloat _attackerWeaponKnockdownImpulseForEvade;
		private CFloat _attackerWeaponKnockdownImpulseForEvadeCumulation;
		private CFloat _ownerWeaponKnockdownImpulseForEvade;
		private CFloat _cumulatedPhysicalImpulse;
		private CFloat _cumulatedGuardBreakImpulse;
		private CFloat _cumulatedEvadeBreakImpulse;
		private CFloat _ragdollImpulse;
		private CFloat _ragdollInfluenceRadius;
		private CEnum<EAIHitIntensity> _hitIntensity;
		private CFloat _previousMeleeHitTimeStamp;
		private CFloat _previousRangedHitTimeStamp;
		private CFloat _previousBlockTimeStamp;
		private CFloat _previousParryTimeStamp;
		private CFloat _previousDodgeTimeStamp;
		private CFloat _previousRagdollTimeStamp;
		private CFloat _previousHackStaggerTimeStamp;
		private CFloat _previousHackImpactTimeStamp;
		private CInt32 _blockCount;
		private CInt32 _parryCount;
		private CInt32 _dodgeCount;
		private CUInt32 _hitCount;
		private CBool _defeatedHasBeenPlayed;
		private CFloat _defeatedRegisteredTime;
		private CBool _deathHasBeenPlayed;
		private CFloat _deathRegisteredTime;
		private CFloat _extendedDeathRegisteredTime;
		private CFloat _extendedDeathDelayRegisteredTime;
		private CFloat _extendedHitReactionRegisteredTime;
		private CFloat _extendedHitReactionDelayRegisteredTime;
		private CBool _scatteredGuts;
		private CFloat _cumulativeDamageUpdateInterval;
		private CBool _cumulativeDamageUpdateRequested;
		private CUInt32 _currentStimId;
		private CHandle<gamedamageAttackData> _attackData;
		private CInt32 _attackDirectionToInt;
		private Vector4 _hitPosition;
		private Vector4 _hitDirection;
		private CInt32 _hitDirectionToInt;
		private CBool _overridenHitDirection;
		private CHandle<HitReactionBehaviorData> _lastHitReactionBehaviorData;
		private CName _lastStimName;
		private CName _deathStimName;
		private CInt32 _meleeHitCount;
		private CInt32 _strongMeleeHitCount;
		private CInt32 _meleeBaseMaxHitChain;
		private CInt32 _rangedBaseMaxHitChain;
		private CInt32 _maxHitChainForMelee;
		private CInt32 _maxHitChainForRanged;
		private CBool _isAlive;
		private CFloat _frameDamageHealthFactor;
		private CArrayFixedSize<CFloat> _hitCountData;
		private CInt32 _hitCountArrayEnd;
		private CInt32 _hitCountArrayCurrent;
		private CBool _allowDefeatedOnCompanion;
		private CFloat _baseCumulativeDamagesDecreaser;
		private CFloat _blockCountInterval;
		private CFloat _dodgeCountInterval;
		private CFloat _globalHitTimer;
		private CBool _hasMantisBladesinRecord;
		private CHandle<redCallbackObject> _indicatorEnabledBlackboardId;
		private CBool _hitIndicatorEnabled;
		private CBool _hasBeenWounded;
		private CBool _inWorkspot;
		private CBool _inCover;
		private CHandle<NPCHealthListener> _healthListener;
		private CHandle<NPCHitReactionComponentStatsListener> _hitReactionComponentStatsListener;
		private CFloat _currentHealth;
		private CFloat _totalHealth;
		private CFloat _totalStamina;
		private CFloat _currentCanDropWeapon;
		private CFloat _currentExtendedHitReactionImmunity;
		private CFloat _currentIsInvulnerable;
		private CFloat _currentDefeatedDamageThreshold;
		private CFloat _currentImpactDamageThreshold;
		private CFloat _currentImpactDamageThresholdInCover;
		private CFloat _currentKnockdownDamageThreshold;
		private CFloat _currentKnockdownDamageThresholdImpulse;
		private CFloat _currentKnockdownDamageThresholdInCover;
		private CFloat _currentKnockdownImmunity;
		private CFloat _currentMeleeHitReactionResistance;
		private CFloat _currentStaggerDamageThreshold;
		private CFloat _currentStaggerDamageThresholdInCover;
		private CFloat _currentCanBlock;
		private CFloat _currentHasKerenzikov;
		private Vector2 _dismemberExecuteHealthRange;
		private Vector2 _dismemberExecuteDistanceRange;
		private CBool _executeDismembered;
		private CBool _attackIsValidBodyPerk;
		private CBool _invalidForExecuteDismember;
		private CHandle<animAnimFeature_HitReactionsData> _hitReactionData;

		[Ordinal(5)] 
		[RED("ownerNPC")] 
		public wCHandle<NPCPuppet> OwnerNPC
		{
			get => GetProperty(ref _ownerNPC);
			set => SetProperty(ref _ownerNPC, value);
		}

		[Ordinal(6)] 
		[RED("ownerPuppet")] 
		public wCHandle<ScriptedPuppet> OwnerPuppet
		{
			get => GetProperty(ref _ownerPuppet);
			set => SetProperty(ref _ownerPuppet, value);
		}

		[Ordinal(7)] 
		[RED("ownerWeapon")] 
		public wCHandle<gameweaponObject> OwnerWeapon
		{
			get => GetProperty(ref _ownerWeapon);
			set => SetProperty(ref _ownerWeapon, value);
		}

		[Ordinal(8)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(9)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(10)] 
		[RED("ownerIsMassive")] 
		public CBool OwnerIsMassive
		{
			get => GetProperty(ref _ownerIsMassive);
			set => SetProperty(ref _ownerIsMassive, value);
		}

		[Ordinal(11)] 
		[RED("impactDamageDuration")] 
		public CFloat ImpactDamageDuration
		{
			get => GetProperty(ref _impactDamageDuration);
			set => SetProperty(ref _impactDamageDuration, value);
		}

		[Ordinal(12)] 
		[RED("staggerDamageDuration")] 
		public CFloat StaggerDamageDuration
		{
			get => GetProperty(ref _staggerDamageDuration);
			set => SetProperty(ref _staggerDamageDuration, value);
		}

		[Ordinal(13)] 
		[RED("impactDamageDurationMelee")] 
		public CFloat ImpactDamageDurationMelee
		{
			get => GetProperty(ref _impactDamageDurationMelee);
			set => SetProperty(ref _impactDamageDurationMelee, value);
		}

		[Ordinal(14)] 
		[RED("staggerDamageDurationMelee")] 
		public CFloat StaggerDamageDurationMelee
		{
			get => GetProperty(ref _staggerDamageDurationMelee);
			set => SetProperty(ref _staggerDamageDurationMelee, value);
		}

		[Ordinal(15)] 
		[RED("knockdownDamageDuration")] 
		public CFloat KnockdownDamageDuration
		{
			get => GetProperty(ref _knockdownDamageDuration);
			set => SetProperty(ref _knockdownDamageDuration, value);
		}

		[Ordinal(16)] 
		[RED("defeatedMinDuration")] 
		public CFloat DefeatedMinDuration
		{
			get => GetProperty(ref _defeatedMinDuration);
			set => SetProperty(ref _defeatedMinDuration, value);
		}

		[Ordinal(17)] 
		[RED("previousHitTime")] 
		public CFloat PreviousHitTime
		{
			get => GetProperty(ref _previousHitTime);
			set => SetProperty(ref _previousHitTime, value);
		}

		[Ordinal(18)] 
		[RED("reactionType")] 
		public CEnum<animHitReactionType> ReactionType
		{
			get => GetProperty(ref _reactionType);
			set => SetProperty(ref _reactionType, value);
		}

		[Ordinal(19)] 
		[RED("animHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> AnimHitReaction
		{
			get => GetProperty(ref _animHitReaction);
			set => SetProperty(ref _animHitReaction, value);
		}

		[Ordinal(20)] 
		[RED("lastAnimHitReaction")] 
		public CHandle<animAnimFeature_HitReactionsData> LastAnimHitReaction
		{
			get => GetProperty(ref _lastAnimHitReaction);
			set => SetProperty(ref _lastAnimHitReaction, value);
		}

		[Ordinal(21)] 
		[RED("hitReactionAction")] 
		public CHandle<ActionHitReactionScriptProxy> HitReactionAction
		{
			get => GetProperty(ref _hitReactionAction);
			set => SetProperty(ref _hitReactionAction, value);
		}

		[Ordinal(22)] 
		[RED("previousAnimHitReactionArray")] 
		public CArray<ScriptHitData> PreviousAnimHitReactionArray
		{
			get => GetProperty(ref _previousAnimHitReactionArray);
			set => SetProperty(ref _previousAnimHitReactionArray, value);
		}

		[Ordinal(23)] 
		[RED("lastHitReactionPlayed")] 
		public CEnum<EAILastHitReactionPlayed> LastHitReactionPlayed
		{
			get => GetProperty(ref _lastHitReactionPlayed);
			set => SetProperty(ref _lastHitReactionPlayed, value);
		}

		[Ordinal(24)] 
		[RED("hitShapeData")] 
		public gameShapeData HitShapeData
		{
			get => GetProperty(ref _hitShapeData);
			set => SetProperty(ref _hitShapeData, value);
		}

		[Ordinal(25)] 
		[RED("animVariation")] 
		public CInt32 AnimVariation
		{
			get => GetProperty(ref _animVariation);
			set => SetProperty(ref _animVariation, value);
		}

		[Ordinal(26)] 
		[RED("specificHitTimeout")] 
		public CFloat SpecificHitTimeout
		{
			get => GetProperty(ref _specificHitTimeout);
			set => SetProperty(ref _specificHitTimeout, value);
		}

		[Ordinal(27)] 
		[RED("quickMeleeCooldown")] 
		public CFloat QuickMeleeCooldown
		{
			get => GetProperty(ref _quickMeleeCooldown);
			set => SetProperty(ref _quickMeleeCooldown, value);
		}

		[Ordinal(28)] 
		[RED("dismembermentBodyPartDamageThreshold")] 
		public CArray<CFloat> DismembermentBodyPartDamageThreshold
		{
			get => GetProperty(ref _dismembermentBodyPartDamageThreshold);
			set => SetProperty(ref _dismembermentBodyPartDamageThreshold, value);
		}

		[Ordinal(29)] 
		[RED("woundedBodyPartDamageThreshold")] 
		public CArray<CFloat> WoundedBodyPartDamageThreshold
		{
			get => GetProperty(ref _woundedBodyPartDamageThreshold);
			set => SetProperty(ref _woundedBodyPartDamageThreshold, value);
		}

		[Ordinal(30)] 
		[RED("defeatedBodyPartDamageThreshold")] 
		public CArray<CFloat> DefeatedBodyPartDamageThreshold
		{
			get => GetProperty(ref _defeatedBodyPartDamageThreshold);
			set => SetProperty(ref _defeatedBodyPartDamageThreshold, value);
		}

		[Ordinal(31)] 
		[RED("defeatedDamageThreshold")] 
		public CFloat DefeatedDamageThreshold
		{
			get => GetProperty(ref _defeatedDamageThreshold);
			set => SetProperty(ref _defeatedDamageThreshold, value);
		}

		[Ordinal(32)] 
		[RED("impactDamageThreshold")] 
		public CFloat ImpactDamageThreshold
		{
			get => GetProperty(ref _impactDamageThreshold);
			set => SetProperty(ref _impactDamageThreshold, value);
		}

		[Ordinal(33)] 
		[RED("staggerDamageThreshold")] 
		public CFloat StaggerDamageThreshold
		{
			get => GetProperty(ref _staggerDamageThreshold);
			set => SetProperty(ref _staggerDamageThreshold, value);
		}

		[Ordinal(34)] 
		[RED("knockdownDamageThreshold")] 
		public CFloat KnockdownDamageThreshold
		{
			get => GetProperty(ref _knockdownDamageThreshold);
			set => SetProperty(ref _knockdownDamageThreshold, value);
		}

		[Ordinal(35)] 
		[RED("knockdownImpulseThreshold")] 
		public CFloat KnockdownImpulseThreshold
		{
			get => GetProperty(ref _knockdownImpulseThreshold);
			set => SetProperty(ref _knockdownImpulseThreshold, value);
		}

		[Ordinal(36)] 
		[RED("immuneToKnockDown")] 
		public CBool ImmuneToKnockDown
		{
			get => GetProperty(ref _immuneToKnockDown);
			set => SetProperty(ref _immuneToKnockDown, value);
		}

		[Ordinal(37)] 
		[RED("hitComboReset")] 
		public CFloat HitComboReset
		{
			get => GetProperty(ref _hitComboReset);
			set => SetProperty(ref _hitComboReset, value);
		}

		[Ordinal(38)] 
		[RED("physicalImpulseReset")] 
		public CFloat PhysicalImpulseReset
		{
			get => GetProperty(ref _physicalImpulseReset);
			set => SetProperty(ref _physicalImpulseReset, value);
		}

		[Ordinal(39)] 
		[RED("guardBreakImpulseReset")] 
		public CFloat GuardBreakImpulseReset
		{
			get => GetProperty(ref _guardBreakImpulseReset);
			set => SetProperty(ref _guardBreakImpulseReset, value);
		}

		[Ordinal(40)] 
		[RED("cumulatedDamages")] 
		public CFloat CumulatedDamages
		{
			get => GetProperty(ref _cumulatedDamages);
			set => SetProperty(ref _cumulatedDamages, value);
		}

		[Ordinal(41)] 
		[RED("bodyPartWoundCumulatedDamages")] 
		public CArray<CFloat> BodyPartWoundCumulatedDamages
		{
			get => GetProperty(ref _bodyPartWoundCumulatedDamages);
			set => SetProperty(ref _bodyPartWoundCumulatedDamages, value);
		}

		[Ordinal(42)] 
		[RED("bodyPartDismemberCumulatedDamages")] 
		public CArray<CFloat> BodyPartDismemberCumulatedDamages
		{
			get => GetProperty(ref _bodyPartDismemberCumulatedDamages);
			set => SetProperty(ref _bodyPartDismemberCumulatedDamages, value);
		}

		[Ordinal(43)] 
		[RED("attackerWeaponKnockdownImpulse")] 
		public CFloat AttackerWeaponKnockdownImpulse
		{
			get => GetProperty(ref _attackerWeaponKnockdownImpulse);
			set => SetProperty(ref _attackerWeaponKnockdownImpulse, value);
		}

		[Ordinal(44)] 
		[RED("attackerWeaponKnockdownImpulseForEvade")] 
		public CFloat AttackerWeaponKnockdownImpulseForEvade
		{
			get => GetProperty(ref _attackerWeaponKnockdownImpulseForEvade);
			set => SetProperty(ref _attackerWeaponKnockdownImpulseForEvade, value);
		}

		[Ordinal(45)] 
		[RED("attackerWeaponKnockdownImpulseForEvadeCumulation")] 
		public CFloat AttackerWeaponKnockdownImpulseForEvadeCumulation
		{
			get => GetProperty(ref _attackerWeaponKnockdownImpulseForEvadeCumulation);
			set => SetProperty(ref _attackerWeaponKnockdownImpulseForEvadeCumulation, value);
		}

		[Ordinal(46)] 
		[RED("ownerWeaponKnockdownImpulseForEvade")] 
		public CFloat OwnerWeaponKnockdownImpulseForEvade
		{
			get => GetProperty(ref _ownerWeaponKnockdownImpulseForEvade);
			set => SetProperty(ref _ownerWeaponKnockdownImpulseForEvade, value);
		}

		[Ordinal(47)] 
		[RED("cumulatedPhysicalImpulse")] 
		public CFloat CumulatedPhysicalImpulse
		{
			get => GetProperty(ref _cumulatedPhysicalImpulse);
			set => SetProperty(ref _cumulatedPhysicalImpulse, value);
		}

		[Ordinal(48)] 
		[RED("cumulatedGuardBreakImpulse")] 
		public CFloat CumulatedGuardBreakImpulse
		{
			get => GetProperty(ref _cumulatedGuardBreakImpulse);
			set => SetProperty(ref _cumulatedGuardBreakImpulse, value);
		}

		[Ordinal(49)] 
		[RED("cumulatedEvadeBreakImpulse")] 
		public CFloat CumulatedEvadeBreakImpulse
		{
			get => GetProperty(ref _cumulatedEvadeBreakImpulse);
			set => SetProperty(ref _cumulatedEvadeBreakImpulse, value);
		}

		[Ordinal(50)] 
		[RED("ragdollImpulse")] 
		public CFloat RagdollImpulse
		{
			get => GetProperty(ref _ragdollImpulse);
			set => SetProperty(ref _ragdollImpulse, value);
		}

		[Ordinal(51)] 
		[RED("ragdollInfluenceRadius")] 
		public CFloat RagdollInfluenceRadius
		{
			get => GetProperty(ref _ragdollInfluenceRadius);
			set => SetProperty(ref _ragdollInfluenceRadius, value);
		}

		[Ordinal(52)] 
		[RED("hitIntensity")] 
		public CEnum<EAIHitIntensity> HitIntensity
		{
			get => GetProperty(ref _hitIntensity);
			set => SetProperty(ref _hitIntensity, value);
		}

		[Ordinal(53)] 
		[RED("previousMeleeHitTimeStamp")] 
		public CFloat PreviousMeleeHitTimeStamp
		{
			get => GetProperty(ref _previousMeleeHitTimeStamp);
			set => SetProperty(ref _previousMeleeHitTimeStamp, value);
		}

		[Ordinal(54)] 
		[RED("previousRangedHitTimeStamp")] 
		public CFloat PreviousRangedHitTimeStamp
		{
			get => GetProperty(ref _previousRangedHitTimeStamp);
			set => SetProperty(ref _previousRangedHitTimeStamp, value);
		}

		[Ordinal(55)] 
		[RED("previousBlockTimeStamp")] 
		public CFloat PreviousBlockTimeStamp
		{
			get => GetProperty(ref _previousBlockTimeStamp);
			set => SetProperty(ref _previousBlockTimeStamp, value);
		}

		[Ordinal(56)] 
		[RED("previousParryTimeStamp")] 
		public CFloat PreviousParryTimeStamp
		{
			get => GetProperty(ref _previousParryTimeStamp);
			set => SetProperty(ref _previousParryTimeStamp, value);
		}

		[Ordinal(57)] 
		[RED("previousDodgeTimeStamp")] 
		public CFloat PreviousDodgeTimeStamp
		{
			get => GetProperty(ref _previousDodgeTimeStamp);
			set => SetProperty(ref _previousDodgeTimeStamp, value);
		}

		[Ordinal(58)] 
		[RED("previousRagdollTimeStamp")] 
		public CFloat PreviousRagdollTimeStamp
		{
			get => GetProperty(ref _previousRagdollTimeStamp);
			set => SetProperty(ref _previousRagdollTimeStamp, value);
		}

		[Ordinal(59)] 
		[RED("previousHackStaggerTimeStamp")] 
		public CFloat PreviousHackStaggerTimeStamp
		{
			get => GetProperty(ref _previousHackStaggerTimeStamp);
			set => SetProperty(ref _previousHackStaggerTimeStamp, value);
		}

		[Ordinal(60)] 
		[RED("previousHackImpactTimeStamp")] 
		public CFloat PreviousHackImpactTimeStamp
		{
			get => GetProperty(ref _previousHackImpactTimeStamp);
			set => SetProperty(ref _previousHackImpactTimeStamp, value);
		}

		[Ordinal(61)] 
		[RED("blockCount")] 
		public CInt32 BlockCount
		{
			get => GetProperty(ref _blockCount);
			set => SetProperty(ref _blockCount, value);
		}

		[Ordinal(62)] 
		[RED("parryCount")] 
		public CInt32 ParryCount
		{
			get => GetProperty(ref _parryCount);
			set => SetProperty(ref _parryCount, value);
		}

		[Ordinal(63)] 
		[RED("dodgeCount")] 
		public CInt32 DodgeCount
		{
			get => GetProperty(ref _dodgeCount);
			set => SetProperty(ref _dodgeCount, value);
		}

		[Ordinal(64)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetProperty(ref _hitCount);
			set => SetProperty(ref _hitCount, value);
		}

		[Ordinal(65)] 
		[RED("defeatedHasBeenPlayed")] 
		public CBool DefeatedHasBeenPlayed
		{
			get => GetProperty(ref _defeatedHasBeenPlayed);
			set => SetProperty(ref _defeatedHasBeenPlayed, value);
		}

		[Ordinal(66)] 
		[RED("defeatedRegisteredTime")] 
		public CFloat DefeatedRegisteredTime
		{
			get => GetProperty(ref _defeatedRegisteredTime);
			set => SetProperty(ref _defeatedRegisteredTime, value);
		}

		[Ordinal(67)] 
		[RED("deathHasBeenPlayed")] 
		public CBool DeathHasBeenPlayed
		{
			get => GetProperty(ref _deathHasBeenPlayed);
			set => SetProperty(ref _deathHasBeenPlayed, value);
		}

		[Ordinal(68)] 
		[RED("deathRegisteredTime")] 
		public CFloat DeathRegisteredTime
		{
			get => GetProperty(ref _deathRegisteredTime);
			set => SetProperty(ref _deathRegisteredTime, value);
		}

		[Ordinal(69)] 
		[RED("extendedDeathRegisteredTime")] 
		public CFloat ExtendedDeathRegisteredTime
		{
			get => GetProperty(ref _extendedDeathRegisteredTime);
			set => SetProperty(ref _extendedDeathRegisteredTime, value);
		}

		[Ordinal(70)] 
		[RED("extendedDeathDelayRegisteredTime")] 
		public CFloat ExtendedDeathDelayRegisteredTime
		{
			get => GetProperty(ref _extendedDeathDelayRegisteredTime);
			set => SetProperty(ref _extendedDeathDelayRegisteredTime, value);
		}

		[Ordinal(71)] 
		[RED("extendedHitReactionRegisteredTime")] 
		public CFloat ExtendedHitReactionRegisteredTime
		{
			get => GetProperty(ref _extendedHitReactionRegisteredTime);
			set => SetProperty(ref _extendedHitReactionRegisteredTime, value);
		}

		[Ordinal(72)] 
		[RED("extendedHitReactionDelayRegisteredTime")] 
		public CFloat ExtendedHitReactionDelayRegisteredTime
		{
			get => GetProperty(ref _extendedHitReactionDelayRegisteredTime);
			set => SetProperty(ref _extendedHitReactionDelayRegisteredTime, value);
		}

		[Ordinal(73)] 
		[RED("scatteredGuts")] 
		public CBool ScatteredGuts
		{
			get => GetProperty(ref _scatteredGuts);
			set => SetProperty(ref _scatteredGuts, value);
		}

		[Ordinal(74)] 
		[RED("cumulativeDamageUpdateInterval")] 
		public CFloat CumulativeDamageUpdateInterval
		{
			get => GetProperty(ref _cumulativeDamageUpdateInterval);
			set => SetProperty(ref _cumulativeDamageUpdateInterval, value);
		}

		[Ordinal(75)] 
		[RED("cumulativeDamageUpdateRequested")] 
		public CBool CumulativeDamageUpdateRequested
		{
			get => GetProperty(ref _cumulativeDamageUpdateRequested);
			set => SetProperty(ref _cumulativeDamageUpdateRequested, value);
		}

		[Ordinal(76)] 
		[RED("currentStimId")] 
		public CUInt32 CurrentStimId
		{
			get => GetProperty(ref _currentStimId);
			set => SetProperty(ref _currentStimId, value);
		}

		[Ordinal(77)] 
		[RED("attackData")] 
		public CHandle<gamedamageAttackData> AttackData
		{
			get => GetProperty(ref _attackData);
			set => SetProperty(ref _attackData, value);
		}

		[Ordinal(78)] 
		[RED("attackDirectionToInt")] 
		public CInt32 AttackDirectionToInt
		{
			get => GetProperty(ref _attackDirectionToInt);
			set => SetProperty(ref _attackDirectionToInt, value);
		}

		[Ordinal(79)] 
		[RED("hitPosition")] 
		public Vector4 HitPosition
		{
			get => GetProperty(ref _hitPosition);
			set => SetProperty(ref _hitPosition, value);
		}

		[Ordinal(80)] 
		[RED("hitDirection")] 
		public Vector4 HitDirection
		{
			get => GetProperty(ref _hitDirection);
			set => SetProperty(ref _hitDirection, value);
		}

		[Ordinal(81)] 
		[RED("hitDirectionToInt")] 
		public CInt32 HitDirectionToInt
		{
			get => GetProperty(ref _hitDirectionToInt);
			set => SetProperty(ref _hitDirectionToInt, value);
		}

		[Ordinal(82)] 
		[RED("overridenHitDirection")] 
		public CBool OverridenHitDirection
		{
			get => GetProperty(ref _overridenHitDirection);
			set => SetProperty(ref _overridenHitDirection, value);
		}

		[Ordinal(83)] 
		[RED("lastHitReactionBehaviorData")] 
		public CHandle<HitReactionBehaviorData> LastHitReactionBehaviorData
		{
			get => GetProperty(ref _lastHitReactionBehaviorData);
			set => SetProperty(ref _lastHitReactionBehaviorData, value);
		}

		[Ordinal(84)] 
		[RED("lastStimName")] 
		public CName LastStimName
		{
			get => GetProperty(ref _lastStimName);
			set => SetProperty(ref _lastStimName, value);
		}

		[Ordinal(85)] 
		[RED("deathStimName")] 
		public CName DeathStimName
		{
			get => GetProperty(ref _deathStimName);
			set => SetProperty(ref _deathStimName, value);
		}

		[Ordinal(86)] 
		[RED("meleeHitCount")] 
		public CInt32 MeleeHitCount
		{
			get => GetProperty(ref _meleeHitCount);
			set => SetProperty(ref _meleeHitCount, value);
		}

		[Ordinal(87)] 
		[RED("strongMeleeHitCount")] 
		public CInt32 StrongMeleeHitCount
		{
			get => GetProperty(ref _strongMeleeHitCount);
			set => SetProperty(ref _strongMeleeHitCount, value);
		}

		[Ordinal(88)] 
		[RED("meleeBaseMaxHitChain")] 
		public CInt32 MeleeBaseMaxHitChain
		{
			get => GetProperty(ref _meleeBaseMaxHitChain);
			set => SetProperty(ref _meleeBaseMaxHitChain, value);
		}

		[Ordinal(89)] 
		[RED("rangedBaseMaxHitChain")] 
		public CInt32 RangedBaseMaxHitChain
		{
			get => GetProperty(ref _rangedBaseMaxHitChain);
			set => SetProperty(ref _rangedBaseMaxHitChain, value);
		}

		[Ordinal(90)] 
		[RED("maxHitChainForMelee")] 
		public CInt32 MaxHitChainForMelee
		{
			get => GetProperty(ref _maxHitChainForMelee);
			set => SetProperty(ref _maxHitChainForMelee, value);
		}

		[Ordinal(91)] 
		[RED("maxHitChainForRanged")] 
		public CInt32 MaxHitChainForRanged
		{
			get => GetProperty(ref _maxHitChainForRanged);
			set => SetProperty(ref _maxHitChainForRanged, value);
		}

		[Ordinal(92)] 
		[RED("isAlive")] 
		public CBool IsAlive
		{
			get => GetProperty(ref _isAlive);
			set => SetProperty(ref _isAlive, value);
		}

		[Ordinal(93)] 
		[RED("frameDamageHealthFactor")] 
		public CFloat FrameDamageHealthFactor
		{
			get => GetProperty(ref _frameDamageHealthFactor);
			set => SetProperty(ref _frameDamageHealthFactor, value);
		}

		[Ordinal(94)] 
		[RED("hitCountData", 100)] 
		public CArrayFixedSize<CFloat> HitCountData
		{
			get => GetProperty(ref _hitCountData);
			set => SetProperty(ref _hitCountData, value);
		}

		[Ordinal(95)] 
		[RED("hitCountArrayEnd")] 
		public CInt32 HitCountArrayEnd
		{
			get => GetProperty(ref _hitCountArrayEnd);
			set => SetProperty(ref _hitCountArrayEnd, value);
		}

		[Ordinal(96)] 
		[RED("hitCountArrayCurrent")] 
		public CInt32 HitCountArrayCurrent
		{
			get => GetProperty(ref _hitCountArrayCurrent);
			set => SetProperty(ref _hitCountArrayCurrent, value);
		}

		[Ordinal(97)] 
		[RED("allowDefeatedOnCompanion")] 
		public CBool AllowDefeatedOnCompanion
		{
			get => GetProperty(ref _allowDefeatedOnCompanion);
			set => SetProperty(ref _allowDefeatedOnCompanion, value);
		}

		[Ordinal(98)] 
		[RED("baseCumulativeDamagesDecreaser")] 
		public CFloat BaseCumulativeDamagesDecreaser
		{
			get => GetProperty(ref _baseCumulativeDamagesDecreaser);
			set => SetProperty(ref _baseCumulativeDamagesDecreaser, value);
		}

		[Ordinal(99)] 
		[RED("blockCountInterval")] 
		public CFloat BlockCountInterval
		{
			get => GetProperty(ref _blockCountInterval);
			set => SetProperty(ref _blockCountInterval, value);
		}

		[Ordinal(100)] 
		[RED("dodgeCountInterval")] 
		public CFloat DodgeCountInterval
		{
			get => GetProperty(ref _dodgeCountInterval);
			set => SetProperty(ref _dodgeCountInterval, value);
		}

		[Ordinal(101)] 
		[RED("globalHitTimer")] 
		public CFloat GlobalHitTimer
		{
			get => GetProperty(ref _globalHitTimer);
			set => SetProperty(ref _globalHitTimer, value);
		}

		[Ordinal(102)] 
		[RED("hasMantisBladesinRecord")] 
		public CBool HasMantisBladesinRecord
		{
			get => GetProperty(ref _hasMantisBladesinRecord);
			set => SetProperty(ref _hasMantisBladesinRecord, value);
		}

		[Ordinal(103)] 
		[RED("indicatorEnabledBlackboardId")] 
		public CHandle<redCallbackObject> IndicatorEnabledBlackboardId
		{
			get => GetProperty(ref _indicatorEnabledBlackboardId);
			set => SetProperty(ref _indicatorEnabledBlackboardId, value);
		}

		[Ordinal(104)] 
		[RED("hitIndicatorEnabled")] 
		public CBool HitIndicatorEnabled
		{
			get => GetProperty(ref _hitIndicatorEnabled);
			set => SetProperty(ref _hitIndicatorEnabled, value);
		}

		[Ordinal(105)] 
		[RED("hasBeenWounded")] 
		public CBool HasBeenWounded
		{
			get => GetProperty(ref _hasBeenWounded);
			set => SetProperty(ref _hasBeenWounded, value);
		}

		[Ordinal(106)] 
		[RED("inWorkspot")] 
		public CBool InWorkspot
		{
			get => GetProperty(ref _inWorkspot);
			set => SetProperty(ref _inWorkspot, value);
		}

		[Ordinal(107)] 
		[RED("inCover")] 
		public CBool InCover
		{
			get => GetProperty(ref _inCover);
			set => SetProperty(ref _inCover, value);
		}

		[Ordinal(108)] 
		[RED("healthListener")] 
		public CHandle<NPCHealthListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(109)] 
		[RED("hitReactionComponentStatsListener")] 
		public CHandle<NPCHitReactionComponentStatsListener> HitReactionComponentStatsListener
		{
			get => GetProperty(ref _hitReactionComponentStatsListener);
			set => SetProperty(ref _hitReactionComponentStatsListener, value);
		}

		[Ordinal(110)] 
		[RED("currentHealth")] 
		public CFloat CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(111)] 
		[RED("totalHealth")] 
		public CFloat TotalHealth
		{
			get => GetProperty(ref _totalHealth);
			set => SetProperty(ref _totalHealth, value);
		}

		[Ordinal(112)] 
		[RED("totalStamina")] 
		public CFloat TotalStamina
		{
			get => GetProperty(ref _totalStamina);
			set => SetProperty(ref _totalStamina, value);
		}

		[Ordinal(113)] 
		[RED("currentCanDropWeapon")] 
		public CFloat CurrentCanDropWeapon
		{
			get => GetProperty(ref _currentCanDropWeapon);
			set => SetProperty(ref _currentCanDropWeapon, value);
		}

		[Ordinal(114)] 
		[RED("currentExtendedHitReactionImmunity")] 
		public CFloat CurrentExtendedHitReactionImmunity
		{
			get => GetProperty(ref _currentExtendedHitReactionImmunity);
			set => SetProperty(ref _currentExtendedHitReactionImmunity, value);
		}

		[Ordinal(115)] 
		[RED("currentIsInvulnerable")] 
		public CFloat CurrentIsInvulnerable
		{
			get => GetProperty(ref _currentIsInvulnerable);
			set => SetProperty(ref _currentIsInvulnerable, value);
		}

		[Ordinal(116)] 
		[RED("currentDefeatedDamageThreshold")] 
		public CFloat CurrentDefeatedDamageThreshold
		{
			get => GetProperty(ref _currentDefeatedDamageThreshold);
			set => SetProperty(ref _currentDefeatedDamageThreshold, value);
		}

		[Ordinal(117)] 
		[RED("currentImpactDamageThreshold")] 
		public CFloat CurrentImpactDamageThreshold
		{
			get => GetProperty(ref _currentImpactDamageThreshold);
			set => SetProperty(ref _currentImpactDamageThreshold, value);
		}

		[Ordinal(118)] 
		[RED("currentImpactDamageThresholdInCover")] 
		public CFloat CurrentImpactDamageThresholdInCover
		{
			get => GetProperty(ref _currentImpactDamageThresholdInCover);
			set => SetProperty(ref _currentImpactDamageThresholdInCover, value);
		}

		[Ordinal(119)] 
		[RED("currentKnockdownDamageThreshold")] 
		public CFloat CurrentKnockdownDamageThreshold
		{
			get => GetProperty(ref _currentKnockdownDamageThreshold);
			set => SetProperty(ref _currentKnockdownDamageThreshold, value);
		}

		[Ordinal(120)] 
		[RED("currentKnockdownDamageThresholdImpulse")] 
		public CFloat CurrentKnockdownDamageThresholdImpulse
		{
			get => GetProperty(ref _currentKnockdownDamageThresholdImpulse);
			set => SetProperty(ref _currentKnockdownDamageThresholdImpulse, value);
		}

		[Ordinal(121)] 
		[RED("currentKnockdownDamageThresholdInCover")] 
		public CFloat CurrentKnockdownDamageThresholdInCover
		{
			get => GetProperty(ref _currentKnockdownDamageThresholdInCover);
			set => SetProperty(ref _currentKnockdownDamageThresholdInCover, value);
		}

		[Ordinal(122)] 
		[RED("currentKnockdownImmunity")] 
		public CFloat CurrentKnockdownImmunity
		{
			get => GetProperty(ref _currentKnockdownImmunity);
			set => SetProperty(ref _currentKnockdownImmunity, value);
		}

		[Ordinal(123)] 
		[RED("currentMeleeHitReactionResistance")] 
		public CFloat CurrentMeleeHitReactionResistance
		{
			get => GetProperty(ref _currentMeleeHitReactionResistance);
			set => SetProperty(ref _currentMeleeHitReactionResistance, value);
		}

		[Ordinal(124)] 
		[RED("currentStaggerDamageThreshold")] 
		public CFloat CurrentStaggerDamageThreshold
		{
			get => GetProperty(ref _currentStaggerDamageThreshold);
			set => SetProperty(ref _currentStaggerDamageThreshold, value);
		}

		[Ordinal(125)] 
		[RED("currentStaggerDamageThresholdInCover")] 
		public CFloat CurrentStaggerDamageThresholdInCover
		{
			get => GetProperty(ref _currentStaggerDamageThresholdInCover);
			set => SetProperty(ref _currentStaggerDamageThresholdInCover, value);
		}

		[Ordinal(126)] 
		[RED("currentCanBlock")] 
		public CFloat CurrentCanBlock
		{
			get => GetProperty(ref _currentCanBlock);
			set => SetProperty(ref _currentCanBlock, value);
		}

		[Ordinal(127)] 
		[RED("currentHasKerenzikov")] 
		public CFloat CurrentHasKerenzikov
		{
			get => GetProperty(ref _currentHasKerenzikov);
			set => SetProperty(ref _currentHasKerenzikov, value);
		}

		[Ordinal(128)] 
		[RED("dismemberExecuteHealthRange")] 
		public Vector2 DismemberExecuteHealthRange
		{
			get => GetProperty(ref _dismemberExecuteHealthRange);
			set => SetProperty(ref _dismemberExecuteHealthRange, value);
		}

		[Ordinal(129)] 
		[RED("dismemberExecuteDistanceRange")] 
		public Vector2 DismemberExecuteDistanceRange
		{
			get => GetProperty(ref _dismemberExecuteDistanceRange);
			set => SetProperty(ref _dismemberExecuteDistanceRange, value);
		}

		[Ordinal(130)] 
		[RED("executeDismembered")] 
		public CBool ExecuteDismembered
		{
			get => GetProperty(ref _executeDismembered);
			set => SetProperty(ref _executeDismembered, value);
		}

		[Ordinal(131)] 
		[RED("attackIsValidBodyPerk")] 
		public CBool AttackIsValidBodyPerk
		{
			get => GetProperty(ref _attackIsValidBodyPerk);
			set => SetProperty(ref _attackIsValidBodyPerk, value);
		}

		[Ordinal(132)] 
		[RED("invalidForExecuteDismember")] 
		public CBool InvalidForExecuteDismember
		{
			get => GetProperty(ref _invalidForExecuteDismember);
			set => SetProperty(ref _invalidForExecuteDismember, value);
		}

		[Ordinal(133)] 
		[RED("hitReactionData")] 
		public CHandle<animAnimFeature_HitReactionsData> HitReactionData
		{
			get => GetProperty(ref _hitReactionData);
			set => SetProperty(ref _hitReactionData, value);
		}

		public HitReactionComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
