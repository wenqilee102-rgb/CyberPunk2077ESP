using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiGenericNotificationReceiverGameController : gameuiWidgetGameController
	{
		private inkEmptyCallback _itemChanged;
		private inkEmptyCallback _notificationPaused;
		private inkEmptyCallback _notificationResumed;

		[Ordinal(2)] 
		[RED("ItemChanged")] 
		public inkEmptyCallback ItemChanged
		{
			get => GetProperty(ref _itemChanged);
			set => SetProperty(ref _itemChanged, value);
		}

		[Ordinal(3)] 
		[RED("NotificationPaused")] 
		public inkEmptyCallback NotificationPaused
		{
			get => GetProperty(ref _notificationPaused);
			set => SetProperty(ref _notificationPaused, value);
		}

		[Ordinal(4)] 
		[RED("NotificationResumed")] 
		public inkEmptyCallback NotificationResumed
		{
			get => GetProperty(ref _notificationResumed);
			set => SetProperty(ref _notificationResumed, value);
		}

		public gameuiGenericNotificationReceiverGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
