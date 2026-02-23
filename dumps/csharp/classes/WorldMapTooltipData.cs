using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipData : CVariable
	{
		private wCHandle<gameuiBaseWorldMapMappinController> _controller;
		private wCHandle<gamemappinsIMappin> _mappin;
		private wCHandle<gameJournalEntry> _journalEntry;
		private CBool _fastTravelEnabled;
		private CBool _delamainTaxiEnabled;
		private CInt32 _travelCost;
		private CInt32 _playerMoney;
		private CBool _readJournal;
		private CBool _moreInfo;
		private CBool _isCollection;

		[Ordinal(0)] 
		[RED("controller")] 
		public wCHandle<gameuiBaseWorldMapMappinController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(1)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsIMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(2)] 
		[RED("journalEntry")] 
		public wCHandle<gameJournalEntry> JournalEntry
		{
			get => GetProperty(ref _journalEntry);
			set => SetProperty(ref _journalEntry, value);
		}

		[Ordinal(3)] 
		[RED("fastTravelEnabled")] 
		public CBool FastTravelEnabled
		{
			get => GetProperty(ref _fastTravelEnabled);
			set => SetProperty(ref _fastTravelEnabled, value);
		}

		[Ordinal(4)] 
		[RED("delamainTaxiEnabled")] 
		public CBool DelamainTaxiEnabled
		{
			get => GetProperty(ref _delamainTaxiEnabled);
			set => SetProperty(ref _delamainTaxiEnabled, value);
		}

		[Ordinal(5)] 
		[RED("travelCost")] 
		public CInt32 TravelCost
		{
			get => GetProperty(ref _travelCost);
			set => SetProperty(ref _travelCost, value);
		}

		[Ordinal(6)] 
		[RED("playerMoney")] 
		public CInt32 PlayerMoney
		{
			get => GetProperty(ref _playerMoney);
			set => SetProperty(ref _playerMoney, value);
		}

		[Ordinal(7)] 
		[RED("readJournal")] 
		public CBool ReadJournal
		{
			get => GetProperty(ref _readJournal);
			set => SetProperty(ref _readJournal, value);
		}

		[Ordinal(8)] 
		[RED("moreInfo")] 
		public CBool MoreInfo
		{
			get => GetProperty(ref _moreInfo);
			set => SetProperty(ref _moreInfo, value);
		}

		[Ordinal(9)] 
		[RED("isCollection")] 
		public CBool IsCollection
		{
			get => GetProperty(ref _isCollection);
			set => SetProperty(ref _isCollection, value);
		}

		public WorldMapTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
