using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CasinoTableSlotLogicController : inkWidgetLogicController
	{
		private CEnum<CasinoTableState> _state;
		private BetData _betData;
		private wCHandle<inkAsyncSpawnRequest> _spawnRequest;
		private wCHandle<inkWidget> _page;

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<CasinoTableState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("betData")] 
		public BetData BetData
		{
			get => GetProperty(ref _betData);
			set => SetProperty(ref _betData, value);
		}

		[Ordinal(3)] 
		[RED("spawnRequest")] 
		public wCHandle<inkAsyncSpawnRequest> SpawnRequest
		{
			get => GetProperty(ref _spawnRequest);
			set => SetProperty(ref _spawnRequest, value);
		}

		[Ordinal(4)] 
		[RED("page")] 
		public wCHandle<inkWidget> Page
		{
			get => GetProperty(ref _page);
			set => SetProperty(ref _page, value);
		}

		public CasinoTableSlotLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
