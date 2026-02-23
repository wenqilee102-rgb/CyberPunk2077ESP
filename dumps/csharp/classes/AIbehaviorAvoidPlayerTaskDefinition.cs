using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAvoidPlayerTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _threatRadius;

		[Ordinal(1)] 
		[RED("threatRadius")] 
		public CHandle<AIArgumentMapping> ThreatRadius
		{
			get => GetProperty(ref _threatRadius);
			set => SetProperty(ref _threatRadius, value);
		}

		public AIbehaviorAvoidPlayerTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
