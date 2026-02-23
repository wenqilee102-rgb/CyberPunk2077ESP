using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetAttackHitTypeEffector : ModifyAttackEffector
	{
		private CEnum<gameuiHitType> _hitType;

		[Ordinal(0)] 
		[RED("hitType")] 
		public CEnum<gameuiHitType> HitType
		{
			get => GetProperty(ref _hitType);
			set => SetProperty(ref _hitType, value);
		}

		public SetAttackHitTypeEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
