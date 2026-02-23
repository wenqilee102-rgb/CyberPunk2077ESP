using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorConfirmationPopupCloseData : inkGameNotificationData
	{
		private CBool _confirm;
		private gameInventoryItemData _itemData;
		private wCHandle<UIInventoryItem> _inventoryItem;
		private CInt32 _quantity;
		private CEnum<VendorConfirmationPopupType> _type;

		[Ordinal(7)] 
		[RED("confirm")] 
		public CBool Confirm
		{
			get => GetProperty(ref _confirm);
			set => SetProperty(ref _confirm, value);
		}

		[Ordinal(8)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(9)] 
		[RED("inventoryItem")] 
		public wCHandle<UIInventoryItem> InventoryItem
		{
			get => GetProperty(ref _inventoryItem);
			set => SetProperty(ref _inventoryItem, value);
		}

		[Ordinal(10)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(11)] 
		[RED("type")] 
		public CEnum<VendorConfirmationPopupType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		public VendorConfirmationPopupCloseData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
