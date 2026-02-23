using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPerfectChargePerkSounds : CVariable
	{
		private CName _perfectChargeChargingSound;
		private CName _perfectChargeChargedSound;
		private CName _perfectChargeShootingSound;

		[Ordinal(0)] 
		[RED("perfectChargeChargingSound")] 
		public CName PerfectChargeChargingSound
		{
			get => GetProperty(ref _perfectChargeChargingSound);
			set => SetProperty(ref _perfectChargeChargingSound, value);
		}

		[Ordinal(1)] 
		[RED("perfectChargeChargedSound")] 
		public CName PerfectChargeChargedSound
		{
			get => GetProperty(ref _perfectChargeChargedSound);
			set => SetProperty(ref _perfectChargeChargedSound, value);
		}

		[Ordinal(2)] 
		[RED("perfectChargeShootingSound")] 
		public CName PerfectChargeShootingSound
		{
			get => GetProperty(ref _perfectChargeShootingSound);
			set => SetProperty(ref _perfectChargeShootingSound, value);
		}

		public audioPerfectChargePerkSounds(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
