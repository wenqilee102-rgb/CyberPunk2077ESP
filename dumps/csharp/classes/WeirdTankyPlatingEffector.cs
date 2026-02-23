using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeirdTankyPlatingEffector : ModifyAttackEffector
	{
		private CFloat _armorMultiplier;

		[Ordinal(0)] 
		[RED("armorMultiplier")] 
		public CFloat ArmorMultiplier
		{
			get => GetProperty(ref _armorMultiplier);
			set => SetProperty(ref _armorMultiplier, value);
		}

		public WeirdTankyPlatingEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
