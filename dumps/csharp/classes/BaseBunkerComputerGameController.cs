using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseBunkerComputerGameController : gameuiBaseBunkerComputerGameController
	{
		private BunkerSystemsFactsSet _factsSet;
		private CName _gateClosedFact;

		[Ordinal(2)] 
		[RED("factsSet")] 
		public BunkerSystemsFactsSet FactsSet
		{
			get => GetProperty(ref _factsSet);
			set => SetProperty(ref _factsSet, value);
		}

		[Ordinal(3)] 
		[RED("gateClosedFact")] 
		public CName GateClosedFact
		{
			get => GetProperty(ref _gateClosedFact);
			set => SetProperty(ref _gateClosedFact, value);
		}

		public BaseBunkerComputerGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
