using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SimpleShouldEvadeCondition : AIbehaviorconditionScript
	{
		private CHandle<HitReactionComponent> _hitReactionComponent;

		[Ordinal(0)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get => GetProperty(ref _hitReactionComponent);
			set => SetProperty(ref _hitReactionComponent, value);
		}

		public SimpleShouldEvadeCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
