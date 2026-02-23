using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WrappedInventoryItemData : IScriptable
	{
		private gameInventoryItemData _itemData;
		private CEnum<gameItemComparisonState> _comparisonState;
		private CBool _isNew;
		private CBool _isPlayerFavourite;
		private CUInt32 _itemTemplate;
		private CEnum<gameItemDisplayContext> _displayContext;
		private CHandle<ImmediateNotificationListener> _notificationListener;
		private CHandle<UIInventoryItem> _item;
		private wCHandle<ItemDisplayContextData> _displayContextData;
		private CInt32 _overrideQuantity;
		private CBool _isQuestBought;

		[Ordinal(0)] 
		[RED("ItemData")] 
		public gameInventoryItemData ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(1)] 
		[RED("ComparisonState")] 
		public CEnum<gameItemComparisonState> ComparisonState
		{
			get => GetProperty(ref _comparisonState);
			set => SetProperty(ref _comparisonState, value);
		}

		[Ordinal(2)] 
		[RED("IsNew")] 
		public CBool IsNew
		{
			get => GetProperty(ref _isNew);
			set => SetProperty(ref _isNew, value);
		}

		[Ordinal(3)] 
		[RED("IsPlayerFavourite")] 
		public CBool IsPlayerFavourite
		{
			get => GetProperty(ref _isPlayerFavourite);
			set => SetProperty(ref _isPlayerFavourite, value);
		}

		[Ordinal(4)] 
		[RED("ItemTemplate")] 
		public CUInt32 ItemTemplate
		{
			get => GetProperty(ref _itemTemplate);
			set => SetProperty(ref _itemTemplate, value);
		}

		[Ordinal(5)] 
		[RED("DisplayContext")] 
		public CEnum<gameItemDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(6)] 
		[RED("NotificationListener")] 
		public CHandle<ImmediateNotificationListener> NotificationListener
		{
			get => GetProperty(ref _notificationListener);
			set => SetProperty(ref _notificationListener, value);
		}

		[Ordinal(7)] 
		[RED("Item")] 
		public CHandle<UIInventoryItem> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(8)] 
		[RED("DisplayContextData")] 
		public wCHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		[Ordinal(9)] 
		[RED("OverrideQuantity")] 
		public CInt32 OverrideQuantity
		{
			get => GetProperty(ref _overrideQuantity);
			set => SetProperty(ref _overrideQuantity, value);
		}

		[Ordinal(10)] 
		[RED("IsQuestBought")] 
		public CBool IsQuestBought
		{
			get => GetProperty(ref _isQuestBought);
			set => SetProperty(ref _isQuestBought, value);
		}

		public WrappedInventoryItemData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
