using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsAVSpawned : PreventionConditionAbstract
	{
		private CHandle<PoliceAgentRegistry> _agentRegistry;
		private CHandle<PreventionSystem> _prevSys;

		[Ordinal(0)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetProperty(ref _agentRegistry);
			set => SetProperty(ref _agentRegistry, value);
		}

		[Ordinal(1)] 
		[RED("prevSys")] 
		public CHandle<PreventionSystem> PrevSys
		{
			get => GetProperty(ref _prevSys);
			set => SetProperty(ref _prevSys, value);
		}

		public IsAVSpawned(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
