using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ShouldNPCRetreatFromMaxTacEncounter : PreventionConditionAbstract
	{
		private CHandle<PoliceAgentRegistry> _agentRegistry;
		private AITrackedLocation _threatLocation;

		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetProperty(ref _agentRegistry);
			set => SetProperty(ref _agentRegistry, value);
		}

		[Ordinal(1)] 
		[RED("threatLocation")] 
		public AITrackedLocation ThreatLocation
		{
			get => GetProperty(ref _threatLocation);
			set => SetProperty(ref _threatLocation, value);
		}

		public ShouldNPCRetreatFromMaxTacEncounter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
