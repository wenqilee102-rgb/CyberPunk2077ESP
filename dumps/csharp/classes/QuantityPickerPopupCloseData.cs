using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuantityPickerPopupCloseData : inkGameNotificationData
	{
		private CInt32 _choosenQuantity;
		private gameInventoryItemData _itemData;
		private wCHandle<UIInventoryItem> _inventoryItem;
		private CEnum<QuantityPickerActionType> _actionType;
		private CBool _isBuyback;

		[Ordinal(7)] 
		[RED("choosenQuantity")] 
		public CInt32 ChoosenQuantity
		{
			get => GetProperty(ref _choosenQuantity);
			set => SetProperty(ref _choosenQuantity, value);
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
		[RED("actionType")] 
		public CEnum<QuantityPickerActionType> ActionType
		{
			get => GetProperty(ref _actionType);
			set => SetProperty(ref _actionType, value);
		}

		[Ordinal(11)] 
		[RED("isBuyback")] 
		public CBool IsBuyback
		{
			get => GetProperty(ref _isBuyback);
			set => SetProperty(ref _isBuyback, value);
		}

		public QuantityPickerPopupCloseData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
