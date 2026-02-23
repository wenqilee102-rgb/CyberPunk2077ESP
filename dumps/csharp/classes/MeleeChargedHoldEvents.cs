using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeChargedHoldEvents : MeleeRumblingEvents
	{
		private CBool _clearWeaponCharge;
		private CHandle<gameStatModifierData_Deprecated> _effectiveRangeMod;

		[Ordinal(2)] 
		[RED("clearWeaponCharge")] 
		public CBool ClearWeaponCharge
		{
			get => GetProperty(ref _clearWeaponCharge);
			set => SetProperty(ref _clearWeaponCharge, value);
		}

		[Ordinal(3)] 
		[RED("effectiveRangeMod")] 
		public CHandle<gameStatModifierData_Deprecated> EffectiveRangeMod
		{
			get => GetProperty(ref _effectiveRangeMod);
			set => SetProperty(ref _effectiveRangeMod, value);
		}

		public MeleeChargedHoldEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
