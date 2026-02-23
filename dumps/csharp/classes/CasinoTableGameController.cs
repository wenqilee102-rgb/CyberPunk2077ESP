using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CasinoTableGameController : gameuiWidgetGameController
	{
		private TweakDBID _casinoChipTDBID;
		private CUInt32 _multiplier;
		private CArrayFixedSize<CasinoTableSlotData> _slots;
		private gameItemID _casinoChipID;
		private wCHandle<gameObject> _player;
		private CHandle<gameTransactionSystem> _transactionSystem;

		[Ordinal(2)] 
		[RED("casinoChipTDBID")] 
		public TweakDBID CasinoChipTDBID
		{
			get => GetProperty(ref _casinoChipTDBID);
			set => SetProperty(ref _casinoChipTDBID, value);
		}

		[Ordinal(3)] 
		[RED("multiplier")] 
		public CUInt32 Multiplier
		{
			get => GetProperty(ref _multiplier);
			set => SetProperty(ref _multiplier, value);
		}

		[Ordinal(4)] 
		[RED("slots", 5)] 
		public CArrayFixedSize<CasinoTableSlotData> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		[Ordinal(5)] 
		[RED("casinoChipID")] 
		public gameItemID CasinoChipID
		{
			get => GetProperty(ref _casinoChipID);
			set => SetProperty(ref _casinoChipID, value);
		}

		[Ordinal(6)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(7)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		public CasinoTableGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
