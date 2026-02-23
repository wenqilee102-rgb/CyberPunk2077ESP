using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocInventoryItemData : IScriptable
	{
		private gameInventoryItemData _inventoryItem;
		private CBool _isVendor;
		private CBool _isBuyback;
		private CBool _isUpgraded;
		private CBool _isEnoughMoney;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("InventoryItem")] 
		public gameInventoryItemData InventoryItem
		{
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(1)] 
		[RED("IsVendor")] 
		public CBool IsVendor
		{
			get => GetProperty(ref _isVendor);
			set => SetProperty(ref _isVendor, value);
		}

		[Ordinal(2)] 
		[RED("IsBuyback")] 
		public CBool IsBuyback
		{
			get => GetProperty(ref _isBuyback);
			set => SetProperty(ref _isBuyback, value);
		}

		[Ordinal(3)] 
		[RED("IsUpgraded")] 
		public CBool IsUpgraded
		{
			get => GetProperty(ref _isUpgraded);
			set => SetProperty(ref _isUpgraded, value);
		}

		[Ordinal(4)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetProperty(ref _isEnoughMoney);
			set => SetProperty(ref _isEnoughMoney, value);
		}

		[Ordinal(5)] 
		[RED("Delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public RipperdocInventoryItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
