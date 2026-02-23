using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleAgent : AICAgent
	{
		private CBool _keepStrategyOnSearch;
		private CHandle<AIVehicleCommand> _initCmd;

		[Ordinal(4)] 
		[RED("keepStrategyOnSearch")] 
		public CBool KeepStrategyOnSearch
		{
			get => GetProperty(ref _keepStrategyOnSearch);
			set => SetProperty(ref _keepStrategyOnSearch, value);
		}

		[Ordinal(5)] 
		[RED("initCmd")] 
		public CHandle<AIVehicleCommand> InitCmd
		{
			get => GetProperty(ref _initCmd);
			set => SetProperty(ref _initCmd, value);
		}

		public AIVehicleAgent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
