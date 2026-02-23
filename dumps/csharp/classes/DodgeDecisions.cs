using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DodgeDecisions : LocomotionGroundDecisions
	{
		private CBool _shouldDisableEnterCondition;

		[Ordinal(3)] 
		[RED("shouldDisableEnterCondition")] 
		public CBool ShouldDisableEnterCondition
		{
			get => GetProperty(ref _shouldDisableEnterCondition);
			set => SetProperty(ref _shouldDisableEnterCondition, value);
		}

		public DodgeDecisions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
