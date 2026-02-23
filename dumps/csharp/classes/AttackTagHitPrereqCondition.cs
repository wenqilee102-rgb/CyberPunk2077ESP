using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AttackTagHitPrereqCondition : BaseHitPrereqCondition
	{
		private CName _attackTag;

		[Ordinal(3)] 
		[RED("attackTag")] 
		public CName AttackTag
		{
			get => GetProperty(ref _attackTag);
			set => SetProperty(ref _attackTag, value);
		}

		public AttackTagHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
