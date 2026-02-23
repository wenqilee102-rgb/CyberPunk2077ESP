using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayClickEvent : redEvent
	{
		private gameInventoryItemData _itemData;
		private CEnum<gameItemDisplayContext> _displayContext;
		private wCHandle<InventoryItemDisplayController> _display;
		private CBool _isBuybackStack;
		private CBool _isQuestBought;
		private CBool _toggleVisibilityRequest;
		private gameItemID _transmogItem;
		private CHandle<UIInventoryItem> _uiInventoryItem;
		private wCHandle<ItemDisplayContextData> _displayContextData;
		private CHandle<IScriptable> _additionalData;
		private CHandle<inkPointerEvent> _evt;
		private CHandle<inkActionName> _actionName;

		[Ordinal(0)] 
		[RED("itemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("displayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(2)] 
		[RED("display")] 
		public wCHandle<InventoryItemDisplayController> Display
		{
			get => GetProperty(ref _display);
			set => SetProperty(ref _display, value);
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
		[RED("toggleVisibilityRequest")] 
		public CBool ToggleVisibilityRequest
		{
			get => GetProperty(ref _toggleVisibilityRequest);
			set => SetProperty(ref _toggleVisibilityRequest, value);
		}

		[Ordinal(6)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetProperty(ref _transmogItem);
			set => SetProperty(ref _transmogItem, value);
		}

		[Ordinal(7)] 
		[RED("uiInventoryItem")] 
		public CHandle<UIInventoryItem> UiInventoryItem
		{
			get => GetProperty(ref _uiInventoryItem);
			set => SetProperty(ref _uiInventoryItem, value);
		}

		[Ordinal(8)] 
		[RED("displayContextData")] 
		public wCHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		[Ordinal(9)] 
		[RED("additionalData")] 
		public CHandle<IScriptable> AdditionalData
		{
			get => GetProperty(ref _additionalData);
			set => SetProperty(ref _additionalData, value);
		}

		[Ordinal(10)] 
		[RED("evt")] 
		public CHandle<inkPointerEvent> Evt
		{
			get => GetProperty(ref _evt);
			set => SetProperty(ref _evt, value);
		}

		[Ordinal(11)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		public ItemDisplayClickEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
