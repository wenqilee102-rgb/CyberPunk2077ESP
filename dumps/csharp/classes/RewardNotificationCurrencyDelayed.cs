using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RewardNotificationCurrencyDelayed : gameDelaySystemScriptedDelayCallbackWrapper
	{
		private wCHandle<ItemsNotificationQueue> _notificationQueue;
		private gameuiGenericNotificationData _notificationData;

		[Ordinal(0)] 
		[RED("notificationQueue")] 
		public wCHandle<ItemsNotificationQueue> NotificationQueue
		{
			get => GetProperty(ref _notificationQueue);
			set => SetProperty(ref _notificationQueue, value);
		}

		[Ordinal(1)] 
		[RED("notificationData")] 
		public gameuiGenericNotificationData NotificationData
		{
			get => GetProperty(ref _notificationData);
			set => SetProperty(ref _notificationData, value);
		}

		public RewardNotificationCurrencyDelayed(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
