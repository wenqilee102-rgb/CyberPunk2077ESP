using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TargetCanGetKilledByDamagePrereqCondition : BaseHitPrereqCondition
	{
		private wCHandle<gameObject> _lastTarget;

		[Ordinal(3)] 
		[RED("lastTarget")] 
		public wCHandle<gameObject> LastTarget
		{
			get => GetProperty(ref _lastTarget);
			set => SetProperty(ref _lastTarget, value);
		}

		public TargetCanGetKilledByDamagePrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
