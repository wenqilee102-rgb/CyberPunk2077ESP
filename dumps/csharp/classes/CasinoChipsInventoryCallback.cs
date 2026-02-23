using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CasinoChipsInventoryCallback : gameInventoryScriptCallback
	{
		private wCHandle<CasinoTableGameController> _casinoTableGameController;
		private CEnum<CasinoTableSlot> _slot;

		[Ordinal(1)] 
		[RED("casinoTableGameController")] 
		public wCHandle<CasinoTableGameController> CasinoTableGameController
		{
			get => GetProperty(ref _casinoTableGameController);
			set => SetProperty(ref _casinoTableGameController, value);
		}

		[Ordinal(2)] 
		[RED("slot")] 
		public CEnum<CasinoTableSlot> Slot
		{
			get => GetProperty(ref _slot);
			set => SetProperty(ref _slot, value);
		}

		public CasinoChipsInventoryCallback(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
