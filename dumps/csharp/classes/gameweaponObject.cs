using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameweaponObject : gameItemObject
	{
		private rRef<gameEffectSet> _effect;
		private CBool _hasOverheat;
		private CHandle<worldEffectBlackboard> _overheatEffectBlackboard;
		private CHandle<OverheatStatListener> _overheatListener;
		private CBool _overheatDelaySent;
		private CHandle<worldEffectBlackboard> _chargeEffectBlackboard;
		private CHandle<WeaponChargeStatListener> _chargeStatListener;
		private CName _triggerEffectName;
		private CHandle<worldEffectBlackboard> _meleeHitEffectBlackboard;
		private CFloat _meleeHitEffectValue;
		private CHandle<DamageStatListener> _damageTypeListener;
		private CString _trailName;
		private CFloat _maxChargeThreshold;
		private CInt32 _animOwner;
		private CBool _perfectChargeStarted;
		private CBool _perfectChargeReached;
		private CBool _perfectChargeShot;
		private CBool _lowAmmoEffectActive;
		private CBool _hasSecondaryTriggerMode;
		private CHandle<gamedataWeaponItem_Record> _weaponRecord;
		private CBool _isHeavyWeapon;
		private CBool _isMeleeWeapon;
		private CBool _isRangedWeapon;
		private CBool _isShotgunWeapon;
		private CHandle<gameIBlackboard> _aIBlackboard;
		private CBool _isCharged;

		[Ordinal(40)] 
		[RED("effect")] 
		public rRef<gameEffectSet> Effect
		{
			get => GetProperty(ref _effect);
			set => SetProperty(ref _effect, value);
		}

		[Ordinal(41)] 
		[RED("hasOverheat")] 
		public CBool HasOverheat
		{
			get => GetProperty(ref _hasOverheat);
			set => SetProperty(ref _hasOverheat, value);
		}

		[Ordinal(42)] 
		[RED("overheatEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> OverheatEffectBlackboard
		{
			get => GetProperty(ref _overheatEffectBlackboard);
			set => SetProperty(ref _overheatEffectBlackboard, value);
		}

		[Ordinal(43)] 
		[RED("overheatListener")] 
		public CHandle<OverheatStatListener> OverheatListener
		{
			get => GetProperty(ref _overheatListener);
			set => SetProperty(ref _overheatListener, value);
		}

		[Ordinal(44)] 
		[RED("overheatDelaySent")] 
		public CBool OverheatDelaySent
		{
			get => GetProperty(ref _overheatDelaySent);
			set => SetProperty(ref _overheatDelaySent, value);
		}

		[Ordinal(45)] 
		[RED("chargeEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> ChargeEffectBlackboard
		{
			get => GetProperty(ref _chargeEffectBlackboard);
			set => SetProperty(ref _chargeEffectBlackboard, value);
		}

		[Ordinal(46)] 
		[RED("chargeStatListener")] 
		public CHandle<WeaponChargeStatListener> ChargeStatListener
		{
			get => GetProperty(ref _chargeStatListener);
			set => SetProperty(ref _chargeStatListener, value);
		}

		[Ordinal(47)] 
		[RED("triggerEffectName")] 
		public CName TriggerEffectName
		{
			get => GetProperty(ref _triggerEffectName);
			set => SetProperty(ref _triggerEffectName, value);
		}

		[Ordinal(48)] 
		[RED("meleeHitEffectBlackboard")] 
		public CHandle<worldEffectBlackboard> MeleeHitEffectBlackboard
		{
			get => GetProperty(ref _meleeHitEffectBlackboard);
			set => SetProperty(ref _meleeHitEffectBlackboard, value);
		}

		[Ordinal(49)] 
		[RED("meleeHitEffectValue")] 
		public CFloat MeleeHitEffectValue
		{
			get => GetProperty(ref _meleeHitEffectValue);
			set => SetProperty(ref _meleeHitEffectValue, value);
		}

		[Ordinal(50)] 
		[RED("damageTypeListener")] 
		public CHandle<DamageStatListener> DamageTypeListener
		{
			get => GetProperty(ref _damageTypeListener);
			set => SetProperty(ref _damageTypeListener, value);
		}

		[Ordinal(51)] 
		[RED("trailName")] 
		public CString TrailName
		{
			get => GetProperty(ref _trailName);
			set => SetProperty(ref _trailName, value);
		}

		[Ordinal(52)] 
		[RED("maxChargeThreshold")] 
		public CFloat MaxChargeThreshold
		{
			get => GetProperty(ref _maxChargeThreshold);
			set => SetProperty(ref _maxChargeThreshold, value);
		}

		[Ordinal(53)] 
		[RED("animOwner")] 
		public CInt32 AnimOwner
		{
			get => GetProperty(ref _animOwner);
			set => SetProperty(ref _animOwner, value);
		}

		[Ordinal(54)] 
		[RED("perfectChargeStarted")] 
		public CBool PerfectChargeStarted
		{
			get => GetProperty(ref _perfectChargeStarted);
			set => SetProperty(ref _perfectChargeStarted, value);
		}

		[Ordinal(55)] 
		[RED("perfectChargeReached")] 
		public CBool PerfectChargeReached
		{
			get => GetProperty(ref _perfectChargeReached);
			set => SetProperty(ref _perfectChargeReached, value);
		}

		[Ordinal(56)] 
		[RED("perfectChargeShot")] 
		public CBool PerfectChargeShot
		{
			get => GetProperty(ref _perfectChargeShot);
			set => SetProperty(ref _perfectChargeShot, value);
		}

		[Ordinal(57)] 
		[RED("lowAmmoEffectActive")] 
		public CBool LowAmmoEffectActive
		{
			get => GetProperty(ref _lowAmmoEffectActive);
			set => SetProperty(ref _lowAmmoEffectActive, value);
		}

		[Ordinal(58)] 
		[RED("hasSecondaryTriggerMode")] 
		public CBool HasSecondaryTriggerMode
		{
			get => GetProperty(ref _hasSecondaryTriggerMode);
			set => SetProperty(ref _hasSecondaryTriggerMode, value);
		}

		[Ordinal(59)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetProperty(ref _weaponRecord);
			set => SetProperty(ref _weaponRecord, value);
		}

		[Ordinal(60)] 
		[RED("isHeavyWeapon")] 
		public CBool IsHeavyWeapon
		{
			get => GetProperty(ref _isHeavyWeapon);
			set => SetProperty(ref _isHeavyWeapon, value);
		}

		[Ordinal(61)] 
		[RED("isMeleeWeapon")] 
		public CBool IsMeleeWeapon
		{
			get => GetProperty(ref _isMeleeWeapon);
			set => SetProperty(ref _isMeleeWeapon, value);
		}

		[Ordinal(62)] 
		[RED("isRangedWeapon")] 
		public CBool IsRangedWeapon
		{
			get => GetProperty(ref _isRangedWeapon);
			set => SetProperty(ref _isRangedWeapon, value);
		}

		[Ordinal(63)] 
		[RED("isShotgunWeapon")] 
		public CBool IsShotgunWeapon
		{
			get => GetProperty(ref _isShotgunWeapon);
			set => SetProperty(ref _isShotgunWeapon, value);
		}

		[Ordinal(64)] 
		[RED("AIBlackboard")] 
		public CHandle<gameIBlackboard> AIBlackboard
		{
			get => GetProperty(ref _aIBlackboard);
			set => SetProperty(ref _aIBlackboard, value);
		}

		[Ordinal(65)] 
		[RED("isCharged")] 
		public CBool IsCharged
		{
			get => GetProperty(ref _isCharged);
			set => SetProperty(ref _isCharged, value);
		}

		public gameweaponObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
