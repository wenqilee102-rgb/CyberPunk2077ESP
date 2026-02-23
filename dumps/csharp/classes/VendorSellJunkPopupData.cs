using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorSellJunkPopupData : inkGameNotificationData
	{
		private CArray<wCHandle<gameItemData>> _items;
		private CArray<CHandle<VendorJunkSellItem>> _limitedItems;
		private CInt32 _itemsQuantity;
		private CInt32 _limitedItemsQuantity;
		private CFloat _totalPrice;
		private CInt32 _limitedTotalPrice;
		private CEnum<VendorSellJunkActionType> _actionType;

		[Ordinal(7)] 
		[RED("items")] 
		public CArray<wCHandle<gameItemData>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		[Ordinal(8)] 
		[RED("limitedItems")] 
		public CArray<CHandle<VendorJunkSellItem>> LimitedItems
		{
			get => GetProperty(ref _limitedItems);
			set => SetProperty(ref _limitedItems, value);
		}

		[Ordinal(9)] 
		[RED("itemsQuantity")] 
		public CInt32 ItemsQuantity
		{
			get => GetProperty(ref _itemsQuantity);
			set => SetProperty(ref _itemsQuantity, value);
		}

		[Ordinal(10)] 
		[RED("limitedItemsQuantity")] 
		public CInt32 LimitedItemsQuantity
		{
			get => GetProperty(ref _limitedItemsQuantity);
			set => SetProperty(ref _limitedItemsQuantity, value);
		}

		[Ordinal(11)] 
		[RED("totalPrice")] 
		public CFloat TotalPrice
		{
			get => GetProperty(ref _totalPrice);
			set => SetProperty(ref _totalPrice, value);
		}

		[Ordinal(12)] 
		[RED("limitedTotalPrice")] 
		public CInt32 LimitedTotalPrice
		{
			get => GetProperty(ref _limitedTotalPrice);
			set => SetProperty(ref _limitedTotalPrice, value);
		}

		[Ordinal(13)] 
		[RED("actionType")] 
		public CEnum<VendorSellJunkActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		public VendorSellJunkPopupData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
