using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayHoldEvent : redEvent
	{
		private gameInventoryItemData _itemData;
		private wCHandle<InventoryItemDisplayController> _display;
		private CHandle<UIInventoryItem> _uiInventoryItem;
		private wCHandle<ItemDisplayContextData> _displayContextData;
		private CHandle<inkActionName> _actionName;

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
		[RED("uiInventoryItem")] 
		public CHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetProperty(ref _uiInventoryItem);
			set => SetProperty(ref _uiInventoryItem, value);
		}

		[Ordinal(3)] 
		[RED("displayContextData")] 
		public wCHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		[Ordinal(4)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		public ItemDisplayHoldEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
