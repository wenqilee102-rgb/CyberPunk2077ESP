using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlayerWeaponSettings : audioWeaponSettings
	{
		private CName _fireSound;
		private CName _preFireSound;
		private CName _burstFireSound;
		private CName _autoFireSound;
		private CName _autoFireStop;
		private CFloat _timeLimitForAutoFireSingleShot;
		private CFloat _padVibrationGain;
		private CFloat _padVibrationReloadGain;
		private CName _tails;
		private CName _shellCasingsSettings;
		private CHandle<audioWeaponEventOverrides> _animEventOverrides;
		private CName _quickMeleeHitEvent;
		private CName _initEvent;
		private CName _shutdownEvent;
		private CName _aimEnterSound;
		private CName _aimExitSound;
		private CName _dryFireSound;
		private CName _reloadSound;
		private CName _triggerEffectSingle;
		private CName _triggerEffectAiming;
		private CName _triggerEffectAuto;
		private audioPerfectChargePerkSounds _perfectChargePerkSounds;

		[Ordinal(10)] 
		[RED("fireSound")] 
		public CName FireSound
		{
			get => GetProperty(ref _fireSound);
			set => SetProperty(ref _fireSound, value);
		}

		[Ordinal(11)] 
		[RED("preFireSound")] 
		public CName PreFireSound
		{
			get => GetProperty(ref _preFireSound);
			set => SetProperty(ref _preFireSound, value);
		}

		[Ordinal(12)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get => GetProperty(ref _burstFireSound);
			set => SetProperty(ref _burstFireSound, value);
		}

		[Ordinal(13)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get => GetProperty(ref _autoFireSound);
			set => SetProperty(ref _autoFireSound, value);
		}

		[Ordinal(14)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get => GetProperty(ref _autoFireStop);
			set => SetProperty(ref _autoFireStop, value);
		}

		[Ordinal(15)] 
		[RED("timeLimitForAutoFireSingleShot")] 
		public CFloat TimeLimitForAutoFireSingleShot
		{
			get => GetProperty(ref _timeLimitForAutoFireSingleShot);
			set => SetProperty(ref _timeLimitForAutoFireSingleShot, value);
		}

		[Ordinal(16)] 
		[RED("padVibrationGain")] 
		public CFloat PadVibrationGain
		{
			get => GetProperty(ref _padVibrationGain);
			set => SetProperty(ref _padVibrationGain, value);
		}

		[Ordinal(17)] 
		[RED("padVibrationReloadGain")] 
		public CFloat PadVibrationReloadGain
		{
			get => GetProperty(ref _padVibrationReloadGain);
			set => SetProperty(ref _padVibrationReloadGain, value);
		}

		[Ordinal(18)] 
		[RED("tails")] 
		public CName Tails
		{
			get => GetProperty(ref _tails);
			set => SetProperty(ref _tails, value);
		}

		[Ordinal(19)] 
		[RED("shellCasingsSettings")] 
		public CName ShellCasingsSettings
		{
			get => GetProperty(ref _shellCasingsSettings);
			set => SetProperty(ref _shellCasingsSettings, value);
		}

		[Ordinal(20)] 
		[RED("animEventOverrides")] 
		public CHandle<audioWeaponEventOverrides> AnimEventOverrides
		{
			get => GetProperty(ref _animEventOverrides);
			set => SetProperty(ref _animEventOverrides, value);
		}

		[Ordinal(21)] 
		[RED("quickMeleeHitEvent")] 
		public CName QuickMeleeHitEvent
		{
			get => GetProperty(ref _quickMeleeHitEvent);
			set => SetProperty(ref _quickMeleeHitEvent, value);
		}

		[Ordinal(22)] 
		[RED("initEvent")] 
		public CName InitEvent
		{
			get => GetProperty(ref _initEvent);
			set => SetProperty(ref _initEvent, value);
		}

		[Ordinal(23)] 
		[RED("shutdownEvent")] 
		public CName ShutdownEvent
		{
			get => GetProperty(ref _shutdownEvent);
			set => SetProperty(ref _shutdownEvent, value);
		}

		[Ordinal(24)] 
		[RED("aimEnterSound")] 
		public CName AimEnterSound
		{
			get => GetProperty(ref _aimEnterSound);
			set => SetProperty(ref _aimEnterSound, value);
		}

		[Ordinal(25)] 
		[RED("aimExitSound")] 
		public CName AimExitSound
		{
			get => GetProperty(ref _aimExitSound);
			set => SetProperty(ref _aimExitSound, value);
		}

		[Ordinal(26)] 
		[RED("dryFireSound")] 
		public CName DryFireSound
		{
			get => GetProperty(ref _dryFireSound);
			set => SetProperty(ref _dryFireSound, value);
		}

		[Ordinal(27)] 
		[RED("reloadSound")] 
		public CName ReloadSound
		{
			get => GetProperty(ref _reloadSound);
			set => SetProperty(ref _reloadSound, value);
		}

		[Ordinal(28)] 
		[RED("triggerEffectSingle")] 
		public CName TriggerEffectSingle
		{
			get => GetProperty(ref _triggerEffectSingle);
			set => SetProperty(ref _triggerEffectSingle, value);
		}

		[Ordinal(29)] 
		[RED("triggerEffectAiming")] 
		public CName TriggerEffectAiming
		{
			get => GetProperty(ref _triggerEffectAiming);
			set => SetProperty(ref _triggerEffectAiming, value);
		}

		[Ordinal(30)] 
		[RED("triggerEffectAuto")] 
		public CName TriggerEffectAuto
		{
			get => GetProperty(ref _triggerEffectAuto);
			set => SetProperty(ref _triggerEffectAuto, value);
		}

		[Ordinal(31)] 
		[RED("perfectChargePerkSounds")] 
		public audioPerfectChargePerkSounds PerfectChargePerkSounds
		{
			get => GetProperty(ref _perfectChargePerkSounds);
			set => SetProperty(ref _perfectChargePerkSounds, value);
		}

		public audioPlayerWeaponSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
