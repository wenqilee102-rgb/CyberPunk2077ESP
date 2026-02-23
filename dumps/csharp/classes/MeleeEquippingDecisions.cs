using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeEquippingDecisions : MeleeIdleDecisions
	{
		private CBool _hasEquipAttack;

		[Ordinal(2)] 
		[RED("hasEquipAttack")] 
		public CBool HasEquipAttack
		{
			get => GetProperty(ref _hasEquipAttack);
			set => SetProperty(ref _hasEquipAttack, value);
		}

		public MeleeEquippingDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
