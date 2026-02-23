using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HardToKillDamageModificationEffector : ModifyAttackEffector
	{
		private CFloat _criticalHealthThreshold;

		[Ordinal(0)] 
		[RED("criticalHealthThreshold")] 
		public CFloat CriticalHealthThreshold
		{
			get => GetProperty(ref _criticalHealthThreshold);
			set => SetProperty(ref _criticalHealthThreshold, value);
		}

		public HardToKillDamageModificationEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
