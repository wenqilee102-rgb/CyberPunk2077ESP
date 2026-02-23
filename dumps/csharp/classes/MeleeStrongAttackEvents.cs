using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeStrongAttackEvents : MeleeAttackGenericEvents
	{
		private CBool _slowMoSet;
		private CBool _crouchedAfterLeapAttack;

		[Ordinal(15)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get => GetProperty(ref _slowMoSet);
			set => SetProperty(ref _slowMoSet, value);
		}

		[Ordinal(16)] 
		[RED("crouchedAfterLeapAttack")] 
		public CBool CrouchedAfterLeapAttack
		{
			get => GetProperty(ref _crouchedAfterLeapAttack);
			set => SetProperty(ref _crouchedAfterLeapAttack, value);
		}

		public MeleeStrongAttackEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
