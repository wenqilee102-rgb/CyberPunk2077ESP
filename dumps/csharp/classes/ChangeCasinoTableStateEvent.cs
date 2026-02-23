using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChangeCasinoTableStateEvent : redEvent
	{
		private gameEntityReference _slotUser;
		private CEnum<CasinoTableSlot> _slot;
		private CEnum<CasinoTableState> _state;
		private BetData _betData;

		[Ordinal(0)] 
		[RED("slotUser")] 
		public gameEntityReference SlotUser
		{
			get => GetProperty(ref _slotUser);
			set => SetProperty(ref _slotUser, value);
		}

		[Ordinal(1)] 
		[RED("slot")] 
		public CEnum<CasinoTableSlot> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		[Ordinal(2)] 
		[RED("state")] 
		public CEnum<CasinoTableState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(3)] 
		[RED("betData")] 
		public BetData BetData
		{
			get => GetProperty(ref _betData);
			set => SetProperty(ref _betData, value);
		}

		public ChangeCasinoTableStateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
