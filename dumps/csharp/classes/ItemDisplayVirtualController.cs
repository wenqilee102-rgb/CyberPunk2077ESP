using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayVirtualController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _itemDisplayWidget;
		private CName _widgetToSpawn;
		private CHandle<WrappedInventoryItemData> _wrappedData;
		private gameInventoryItemData _data;
		private wCHandle<inkWidget> _spawnedWidget;
		private CInt32 _notificationListenerID;
		private wCHandle<ImmediateNotificationListener> _immediateNotificationListener;

		[Ordinal(18)] 
		[RED("itemDisplayWidget")] 
		public inkWidgetReference ItemDisplayWidget
		{
			get => GetProperty(ref _itemDisplayWidget);
			set => SetProperty(ref _itemDisplayWidget, value);
		}

		[Ordinal(19)] 
		[RED("widgetToSpawn")] 
		public CName WidgetToSpawn
		{
			get => GetProperty(ref _widgetToSpawn);
			set => SetProperty(ref _widgetToSpawn, value);
		}

		[Ordinal(20)] 
		[RED("wrappedData")] 
		public CHandle<WrappedInventoryItemData> WrappedData
		{
			get => GetProperty(ref _wrappedData);
			set => SetProperty(ref _wrappedData, value);
		}

		[Ordinal(21)] 
		[RED("data")] 
		public gameInventoryItemData Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(22)] 
		[RED("spawnedWidget")] 
		public wCHandle<inkWidget> SpawnedWidget
		{
			get => GetProperty(ref _spawnedWidget);
			set => SetProperty(ref _spawnedWidget, value);
		}

		[Ordinal(23)] 
		[RED("notificationListenerID")] 
		public CInt32 NotificationListenerID
		{
			get => GetProperty(ref _notificationListenerID);
			set => SetProperty(ref _notificationListenerID, value);
		}

		[Ordinal(24)] 
		[RED("immediateNotificationListener")] 
		public wCHandle<ImmediateNotificationListener> ImmediateNotificationListener
		{
			get => GetProperty(ref _immediateNotificationListener);
			set => SetProperty(ref _immediateNotificationListener, value);
		}

		public ItemDisplayVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
