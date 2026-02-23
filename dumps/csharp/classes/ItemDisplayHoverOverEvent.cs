using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoverOverEvent : redEvent
	{
		private gameInventoryItemData _itemData;
		private wCHandle<InventoryItemDisplayController> _display;
		private wCHandle<inkWidget> _widget;
		private CBool _isBuybackStack;
		private CBool _isQuestBought;
		private CBool _toggleVisibilityControll;
		private CBool _isItemHidden;
		private gameItemID _transmogItem;
		private wCHandle<UIInventoryItem> _uiInventoryItem;
		private wCHandle<ItemDisplayContextData> _displayContextData;

		[Ordinal(0)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("display")] 
		public wCHandle<InventoryItemDisplayController> Display
		{
			get => GetProperty(ref _display);
			set => SetProperty(ref _display, value);
		}

		[Ordinal(2)] 
		[RED("widget")] 
		public wCHandle<inkWidget> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(3)] 
		[RED("isBuybackStack")] 
		public CBool IsBuybackStack
		{
			get => GetProperty(ref _isBuybackStack);
			set => SetProperty(ref _isBuybackStack, value);
		}

		[Ordinal(4)] 
		[RED("isQuestBought")] 
		public CBool IsQuestBought
		{
			get => GetProperty(ref _isQuestBought);
			set => SetProperty(ref _isQuestBought, value);
		}

		[Ordinal(5)] 
		[RED("toggleVisibilityControll")] 
		public CBool ToggleVisibilityControll
		{
			get => GetProperty(ref _toggleVisibilityControll);
			set => SetProperty(ref _toggleVisibilityControll, value);
		}

		[Ordinal(6)] 
		[RED("isItemHidden")] 
		public CBool IsItemHidden
		{
			get => GetProperty(ref _isItemHidden);
			set => SetProperty(ref _isItemHidden, value);
		}

		[Ordinal(7)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetProperty(ref _transmogItem);
			set => SetProperty(ref _transmogItem, value);
		}

		[Ordinal(8)] 
		[RED("uiInventoryItem")] 
		public wCHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetProperty(ref _uiInventoryItem);
			set => SetProperty(ref _uiInventoryItem, value);
		}

		[Ordinal(9)] 
		[RED("displayContextData")] 
		public wCHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		public ItemDisplayHoverOverEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
