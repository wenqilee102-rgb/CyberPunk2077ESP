using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitFlagHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<hitFlag> _hitFlag;
		private CBool _invertHitFlag;

		[Ordinal(3)] 
		[RED("hitFlag")] 
		public CEnum<hitFlag> HitFlag
		{
			get => GetProperty(ref _hitFlag);
			set => SetProperty(ref _hitFlag, value);
		}

		[Ordinal(4)] 
		[RED("invertHitFlag")] 
		public CBool InvertHitFlag
		{
			get => GetProperty(ref _invertHitFlag);
			set => SetProperty(ref _invertHitFlag, value);
		}

		public HitFlagHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
