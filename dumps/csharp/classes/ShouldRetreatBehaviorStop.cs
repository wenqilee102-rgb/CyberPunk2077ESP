using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShouldRetreatBehaviorStop : PreventionConditionAbstract
	{
		private CHandle<PoliceAgentRegistry> _agentRegistry;

		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetProperty(ref _agentRegistry);
			set => SetProperty(ref _agentRegistry, value);
		}

		public ShouldRetreatBehaviorStop(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
