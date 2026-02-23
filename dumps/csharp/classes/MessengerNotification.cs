using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerNotification : GenericNotificationController
	{
		private inkTextWidgetReference _messageText;
		private inkImageWidgetReference _avatar;
		private inkTextWidgetReference _descriptionText;
		private inkImageWidgetReference _mappinIcon;
		private inkWidgetReference _envelopIcon;
		private wCHandle<gameIBlackboard> _interactionsBlackboard;
		private wCHandle<gameIBlackboard> _deviceBlackboard;
		private CHandle<redCallbackObject> _contactsActiveCallback;
		private CHandle<gameuiPhoneMessageNotificationViewData> _messageData;
		private CHandle<inkanimProxy> _animProxy;
		private CInt32 _textSizeLimit;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<gamemappinsMappinSystem> _mappinSystem;

		[Ordinal(16)] 
		[RED("messageText")] 
		public inkTextWidgetReference MessageText
		{
			get => GetProperty(ref _messageText);
			set => SetProperty(ref _messageText, value);
		}

		[Ordinal(17)] 
		[RED("avatar")] 
		public inkImageWidgetReference Avatar
		{
			get => GetProperty(ref _avatar);
			set => SetProperty(ref _avatar, value);
		}

		[Ordinal(18)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(19)] 
		[RED("mappinIcon")] 
		public inkImageWidgetReference MappinIcon
		{
			get => GetProperty(ref _mappinIcon);
			set => SetProperty(ref _mappinIcon, value);
		}

		[Ordinal(20)] 
		[RED("envelopIcon")] 
		public inkWidgetReference EnvelopIcon
		{
			get => GetProperty(ref _envelopIcon);
			set => SetProperty(ref _envelopIcon, value);
		}

		[Ordinal(21)] 
		[RED("interactionsBlackboard")] 
		public wCHandle<gameIBlackboard> InteractionsBlackboard
		{
			get => GetProperty(ref _interactionsBlackboard);
			set => SetProperty(ref _interactionsBlackboard, value);
		}

		[Ordinal(22)] 
		[RED("deviceBlackboard")] 
		public wCHandle<gameIBlackboard> DeviceBlackboard
		{
			get => GetProperty(ref _deviceBlackboard);
			set => SetProperty(ref _deviceBlackboard, value);
		}

		[Ordinal(23)] 
		[RED("contactsActiveCallback")] 
		public CHandle<redCallbackObject> ContactsActiveCallback
		{
			get => GetProperty(ref _contactsActiveCallback);
			set => SetProperty(ref _contactsActiveCallback, value);
		}

		[Ordinal(24)] 
		[RED("messageData")] 
		public CHandle<gameuiPhoneMessageNotificationViewData> MessageData
		{
			get => GetProperty(ref _messageData);
			set => SetProperty(ref _messageData, value);
		}

		[Ordinal(25)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(26)] 
		[RED("textSizeLimit")] 
		public CInt32 TextSizeLimit
		{
			get => GetProperty(ref _textSizeLimit);
			set => SetProperty(ref _textSizeLimit, value);
		}

		[Ordinal(27)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(28)] 
		[RED("mappinSystem")] 
		public wCHandle<gamemappinsMappinSystem> MappinSystem
		{
			get => GetProperty(ref _mappinSystem);
			set => SetProperty(ref _mappinSystem, value);
		}

		public MessengerNotification(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
