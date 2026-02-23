using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorInventoryItemData : WrappedInventoryItemData
	{
		private CBool _isVendorItem;
		private CBool _isEnoughMoney;
		private CBool _isBuybackStack;
		private CBool _isDLCAddedActiveItem;

		[Ordinal(11)] 
		[RED("IsVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetProperty(ref _isVendorItem);
			set => SetProperty(ref _isVendorItem, value);
		}

		[Ordinal(12)] 
		[RED("IsEnoughMoney")] 
		public CBool IsEnoughMoney
		{
			get => GetProperty(ref _isEnoughMoney);
			set => SetProperty(ref _isEnoughMoney, value);
		}

		[Ordinal(13)] 
		[RED("IsBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		[Ordinal(14)] 
		[RED("IsDLCAddedActiveItem")] 
		public CBool IsDLCAddedActiveItem
		{
			get => GetProperty(ref _isDLCAddedActiveItem);
			set => SetProperty(ref _isDLCAddedActiveItem, value);
		}

		public VendorInventoryItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
