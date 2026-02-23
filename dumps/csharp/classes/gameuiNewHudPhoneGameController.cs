using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewHudPhoneGameController : gameuiGenericNotificationGameController
	{
		private gameuiLocalPhoneElement _holoAudioCallElement;
		private gameuiLocalPhoneElement _incomingCallElement;
		private gameuiLocalPhoneElement _contactsElement;
		private gameuiExternalPhoneElement _smsMessengerElement;
		private gameuiPhoneElementVisibility _notificationsElement;
		private gameuiLocalPhoneElement _phoneIconElement;
		private CArray<gameuiResolutionSensitiveWidget> _resolutionSensitiveWidgets;
		private CArray<gameuiHudScalingSensitiveWidget> _hudScalingSensitiveWidgets;
		private inkWidgetReference _phoneIconMarker;
		private inkWidgetReference _phoneIconVehicleMarker;
		private inkWidgetReference _callMarker;
		private inkWidgetReference _contactsMarker;
		private inkWidgetReference _notificationMarker;

		[Ordinal(4)] 
		[RED("holoAudioCallElement")] 
		public gameuiLocalPhoneElement HoloAudioCallElement
		{
			get => GetProperty(ref _holoAudioCallElement);
			set => SetProperty(ref _holoAudioCallElement, value);
		}

		[Ordinal(5)] 
		[RED("incomingCallElement")] 
		public gameuiLocalPhoneElement IncomingCallElement
		{
			get => GetProperty(ref _incomingCallElement);
			set => SetProperty(ref _incomingCallElement, value);
		}

		[Ordinal(6)] 
		[RED("contactsElement")] 
		public gameuiLocalPhoneElement ContactsElement
		{
			get => GetProperty(ref _contactsElement);
			set => SetProperty(ref _contactsElement, value);
		}

		[Ordinal(7)] 
		[RED("smsMessengerElement")] 
		public gameuiExternalPhoneElement SmsMessengerElement
		{
			get => GetProperty(ref _smsMessengerElement);
			set => SetProperty(ref _smsMessengerElement, value);
		}

		[Ordinal(8)] 
		[RED("notificationsElement")] 
		public gameuiPhoneElementVisibility NotificationsElement
		{
			get => GetProperty(ref _notificationsElement);
			set => SetProperty(ref _notificationsElement, value);
		}

		[Ordinal(9)] 
		[RED("phoneIconElement")] 
		public gameuiLocalPhoneElement PhoneIconElement
		{
			get => GetProperty(ref _phoneIconElement);
			set => SetProperty(ref _phoneIconElement, value);
		}

		[Ordinal(10)] 
		[RED("resolutionSensitiveWidgets")] 
		public CArray<gameuiResolutionSensitiveWidget> ResolutionSensitiveWidgets
		{
			get => GetProperty(ref _resolutionSensitiveWidgets);
			set => SetProperty(ref _resolutionSensitiveWidgets, value);
		}

		[Ordinal(11)] 
		[RED("hudScalingSensitiveWidgets")] 
		public CArray<gameuiHudScalingSensitiveWidget> HudScalingSensitiveWidgets
		{
			get => GetProperty(ref _hudScalingSensitiveWidgets);
			set => SetProperty(ref _hudScalingSensitiveWidgets, value);
		}

		[Ordinal(12)] 
		[RED("phoneIconMarker")] 
		public inkWidgetReference PhoneIconMarker
		{
			get => GetProperty(ref _phoneIconMarker);
			set => SetProperty(ref _phoneIconMarker, value);
		}

		[Ordinal(13)] 
		[RED("phoneIconVehicleMarker")] 
		public inkWidgetReference PhoneIconVehicleMarker
		{
			get => GetProperty(ref _phoneIconVehicleMarker);
			set => SetProperty(ref _phoneIconVehicleMarker, value);
		}

		[Ordinal(14)] 
		[RED("callMarker")] 
		public inkWidgetReference CallMarker
		{
			get => GetProperty(ref _callMarker);
			set => SetProperty(ref _callMarker, value);
		}

		[Ordinal(15)] 
		[RED("contactsMarker")] 
		public inkWidgetReference ContactsMarker
		{
			get => GetProperty(ref _contactsMarker);
			set => SetProperty(ref _contactsMarker, value);
		}

		[Ordinal(16)] 
		[RED("notificationMarker")] 
		public inkWidgetReference NotificationMarker
		{
			get => GetProperty(ref _notificationMarker);
			set => SetProperty(ref _notificationMarker, value);
		}

		public gameuiNewHudPhoneGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
