using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PoliceAgentRegistry : IScriptable
	{
		private ScriptGameInstance _game;
		private CArray<CHandle<VehicleAgent>> _vehicleAgents;
		private CArray<CHandle<NPCAgent>> _npcAgents;
		private CArray<TicketData> _requestTickets;

		[Ordinal(0)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(1)] 
		[RED("vehicleAgents")] 
		public CArray<CHandle<VehicleAgent>> VehicleAgents
		{
			get => GetProperty(ref _vehicleAgents);
			set => SetProperty(ref _vehicleAgents, value);
		}

		[Ordinal(2)] 
		[RED("npcAgents")] 
		public CArray<CHandle<NPCAgent>> NpcAgents
		{
			get => GetProperty(ref _npcAgents);
			set => SetProperty(ref _npcAgents, value);
		}

		[Ordinal(3)] 
		[RED("requestTickets")] 
		public CArray<TicketData> RequestTickets
		{
			get => GetProperty(ref _requestTickets);
			set => SetProperty(ref _requestTickets, value);
		}

		public PoliceAgentRegistry(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
