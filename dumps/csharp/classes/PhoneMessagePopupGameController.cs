using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneMessagePopupGameController : gameuiNewPhoneRelatedGameController
	{
		private inkWidgetReference _content;
		private inkTextWidgetReference _title;
		private inkImageWidgetReference _avatarImage;
		private inkWidgetReference _menuBackgrouns;
		private inkWidgetReference _hintsContainer;
		private inkWidgetReference _hintTrack;
		private inkWidgetReference _hintClose;
		private inkWidgetReference _hintReply;
		private inkWidgetReference _scrollReply;
		private inkWidgetReference _hintMessenger;
		private inkWidgetReference _hintCall;
		private inkWidgetReference _scrollSlider;
		private inkWidgetReference _contactsPath;
		private inkWidgetReference _messagesPath;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_ComDeviceDef> _blackboardDef;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<gameObject> _player;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<PhoneSystem> _phoneSystem;
		private CHandle<JournalNotificationData> _data;
		private wCHandle<gameJournalPhoneMessage> _entry;
		private wCHandle<gameJournalContact> _contactEntry;
		private wCHandle<gameJournalEntry> _attachment;
		private CEnum<gameJournalEntryState> _attachmentState;
		private CUInt32 _attachmentHash;
		private wCHandle<gameJournalEntry> _activeEntry;
		private wCHandle<MessengerDialogViewController> _dialogViewController;
		private CInt32 _journalEntryHash;
		private CHandle<inkanimProxy> _proxy;
		private CBool _isFocused;
		private CBool _isHubVisiale;

		[Ordinal(3)] 
		[RED("content")] 
		public inkWidgetReference Content
		{
			get => GetProperty(ref _content);
			set => SetProperty(ref _content, value);
		}

		[Ordinal(4)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(5)] 
		[RED("avatarImage")] 
		public inkImageWidgetReference AvatarImage
		{
			get => GetProperty(ref _avatarImage);
			set => SetProperty(ref _avatarImage, value);
		}

		[Ordinal(6)] 
		[RED("menuBackgrouns")] 
		public inkWidgetReference MenuBackgrouns
		{
			get => GetProperty(ref _menuBackgrouns);
			set => SetProperty(ref _menuBackgrouns, value);
		}

		[Ordinal(7)] 
		[RED("hintsContainer")] 
		public inkWidgetReference HintsContainer
		{
			get => GetProperty(ref _hintsContainer);
			set => SetProperty(ref _hintsContainer, value);
		}

		[Ordinal(8)] 
		[RED("hintTrack")] 
		public inkWidgetReference HintTrack
		{
			get => GetProperty(ref _hintTrack);
			set => SetProperty(ref _hintTrack, value);
		}

		[Ordinal(9)] 
		[RED("hintClose")] 
		public inkWidgetReference HintClose
		{
			get => GetProperty(ref _hintClose);
			set => SetProperty(ref _hintClose, value);
		}

		[Ordinal(10)] 
		[RED("hintReply")] 
		public inkWidgetReference HintReply
		{
			get => GetProperty(ref _hintReply);
			set => SetProperty(ref _hintReply, value);
		}

		[Ordinal(11)] 
		[RED("scrollReply")] 
		public inkWidgetReference ScrollReply
		{
			get => GetProperty(ref _scrollReply);
			set => SetProperty(ref _scrollReply, value);
		}

		[Ordinal(12)] 
		[RED("hintMessenger")] 
		public inkWidgetReference HintMessenger
		{
			get => GetProperty(ref _hintMessenger);
			set => SetProperty(ref _hintMessenger, value);
		}

		[Ordinal(13)] 
		[RED("hintCall")] 
		public inkWidgetReference HintCall
		{
			get => GetProperty(ref _hintCall);
			set => SetProperty(ref _hintCall, value);
		}

		[Ordinal(14)] 
		[RED("scrollSlider")] 
		public inkWidgetReference ScrollSlider
		{
			get => GetProperty(ref _scrollSlider);
			set => SetProperty(ref _scrollSlider, value);
		}

		[Ordinal(15)] 
		[RED("contactsPath")] 
		public inkWidgetReference ContactsPath
		{
			get => GetProperty(ref _contactsPath);
			set => SetProperty(ref _contactsPath, value);
		}

		[Ordinal(16)] 
		[RED("messagesPath")] 
		public inkWidgetReference MessagesPath
		{
			get => GetProperty(ref _messagesPath);
			set => SetProperty(ref _messagesPath, value);
		}

		[Ordinal(17)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(18)] 
		[RED("blackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(19)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(20)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(21)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(22)] 
		[RED("phoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(23)] 
		[RED("data")] 
		public CHandle<JournalNotificationData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(24)] 
		[RED("entry")] 
		public wCHandle<gameJournalPhoneMessage> Entry
		{
			get => GetProperty(ref _entry);
			set => SetProperty(ref _entry, value);
		}

		[Ordinal(25)] 
		[RED("contactEntry")] 
		public wCHandle<gameJournalContact> ContactEntry
		{
			get => GetProperty(ref _contactEntry);
			set => SetProperty(ref _contactEntry, value);
		}

		[Ordinal(26)] 
		[RED("attachment")] 
		public wCHandle<gameJournalEntry> Attachment
		{
			get => GetProperty(ref _attachment);
			set => SetProperty(ref _attachment, value);
		}

		[Ordinal(27)] 
		[RED("attachmentState")] 
		public CEnum<gameJournalEntryState> AttachmentState
		{
			get => GetProperty(ref _attachmentState);
			set => SetProperty(ref _attachmentState, value);
		}

		[Ordinal(28)] 
		[RED("attachmentHash")] 
		public CUInt32 AttachmentHash
		{
			get => GetProperty(ref _attachmentHash);
			set => SetProperty(ref _attachmentHash, value);
		}

		[Ordinal(29)] 
		[RED("activeEntry")] 
		public wCHandle<gameJournalEntry> ActiveEntry
		{
			get => GetProperty(ref _activeEntry);
			set => SetProperty(ref _activeEntry, value);
		}

		[Ordinal(30)] 
		[RED("dialogViewController")] 
		public wCHandle<MessengerDialogViewController> DialogViewController
		{
			get => GetProperty(ref _dialogViewController);
			set => SetProperty(ref _dialogViewController, value);
		}

		[Ordinal(31)] 
		[RED("journalEntryHash")] 
		public CInt32 JournalEntryHash
		{
			get => GetProperty(ref _journalEntryHash);
			set => SetProperty(ref _journalEntryHash, value);
		}

		[Ordinal(32)] 
		[RED("proxy")] 
		public CHandle<inkanimProxy> Proxy
		{
			get => GetProperty(ref _proxy);
			set => SetProperty(ref _proxy, value);
		}

		[Ordinal(33)] 
		[RED("isFocused")] 
		public CBool IsFocused
		{
			get => GetProperty(ref _isFocused);
			set => SetProperty(ref _isFocused, value);
		}

		[Ordinal(34)] 
		[RED("isHubVisiale")] 
		public CBool IsHubVisiale
		{
			get => GetProperty(ref _isHubVisiale);
			set => SetProperty(ref _isHubVisiale, value);
		}

		public PhoneMessagePopupGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
