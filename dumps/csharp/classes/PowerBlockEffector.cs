using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PowerBlockEffector : ModifyAttackEffector
	{
		private CFloat _damageReduction;

		[Ordinal(0)] 
		[RED("damageReduction")] 
		public CFloat DamageReduction
		{
			get => GetProperty(ref _damageReduction);
			set => SetProperty(ref _damageReduction, value);
		}

		public PowerBlockEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
