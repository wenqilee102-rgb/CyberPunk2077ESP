using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorUIInventoryItemData : WrappedInventoryItemData
	{
		private CFloat _itemPrice;
		private CBool _isVendorItem;
		private CBool _isBuybackStack;
		private CBool _isEnoughMoney;
		private CBool _isDLCAddedActiveItem;
		private CBool _isNotInWardrobe;

		[Ordinal(11)] 
		[RED("ItemPrice")] 
		public CFloat ItemPrice
		{
			get => GetProperty(ref _itemPrice);
			set => SetProperty(ref _itemPrice, value);
		}

		[Ordinal(12)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetProperty(ref _isVendorItem);
			set => SetProperty(ref _isVendorItem, value);
		}

		[Ordinal(13)] 
		[RED("IsBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		[Ordinal(14)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetProperty(ref _isEnoughMoney);
			set => SetProperty(ref _isEnoughMoney, value);
		}

		[Ordinal(15)] 
		[RED("IsDLCAddedActiveItem")] 
		public CBool IsDLCAddedActiveItem
		{
			get => GetProperty(ref _isDLCAddedActiveItem);
			set => SetProperty(ref _isDLCAddedActiveItem, value);
		}

		[Ordinal(16)] 
		[RED("IsNotInWardrobe")] 
		public CBool IsNotInWardrobe
		{
			get => GetProperty(ref _isNotInWardrobe);
			set => SetProperty(ref _isNotInWardrobe, value);
		}

		public VendorUIInventoryItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
