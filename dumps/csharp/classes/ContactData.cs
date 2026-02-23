using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ContactData : IScriptable
	{
		private CString _id;
		private CString _localizedName;
		private CString _localizedPreview;
		private TweakDBID _avatarID;
		private CBool _questRelated;
		private CBool _hasQuestImportantReply;
		private CBool _hasMessages;
		private CInt32 _unreadMessegeCount;
		private CArray<CInt32> _unreadMessages;
		private CBool _playerCanReply;
		private CBool _playerIsLastSender;
		private CString _lastMesssagePreview;
		private wCHandle<MessengerContactSyncData> _activeDataSync;
		private CInt32 _threadsCount;
		private GameTime _timeStamp;
		private CInt32 _hash;
		private CInt32 _conversationHash;
		private CEnum<MessengerContactType> _type;
		private CBool _hasValidTitle;
		private CBool _isCallable;
		private CString _contactId;
		private CInt32 _messagesCount;
		private CInt32 _repliesCount;

		[Ordinal(0)] 
		[RED("id")] 
		public CString Id
		{
			get => GetProperty(ref _id);
			set => SetProperty(ref _id, value);
		}

		[Ordinal(1)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get => GetProperty(ref _localizedName);
			set => SetProperty(ref _localizedName, value);
		}

		[Ordinal(2)] 
		[RED("localizedPreview")] 
		public CString LocalizedPreview
		{
			get => GetProperty(ref _localizedPreview);
			set => SetProperty(ref _localizedPreview, value);
		}

		[Ordinal(3)] 
		[RED("avatarID")] 
		public TweakDBID AvatarID
		{
			get => GetProperty(ref _avatarID);
			set => SetProperty(ref _avatarID, value);
		}

		[Ordinal(4)] 
		[RED("questRelated")] 
		public CBool QuestRelated
		{
			get => GetProperty(ref _questRelated);
			set => SetProperty(ref _questRelated, value);
		}

		[Ordinal(5)] 
		[RED("hasQuestImportantReply")] 
		public CBool HasQuestImportantReply
		{
			get => GetProperty(ref _hasQuestImportantReply);
			set => SetProperty(ref _hasQuestImportantReply, value);
		}

		[Ordinal(6)] 
		[RED("hasMessages")] 
		public CBool HasMessages
		{
			get => GetProperty(ref _hasMessages);
			set => SetProperty(ref _hasMessages, value);
		}

		[Ordinal(7)] 
		[RED("unreadMessegeCount")] 
		public CInt32 UnreadMessegeCount
		{
			get => GetProperty(ref _unreadMessegeCount);
			set => SetProperty(ref _unreadMessegeCount, value);
		}

		[Ordinal(8)] 
		[RED("unreadMessages")] 
		public CArray<CInt32> UnreadMessages
		{
			get => GetProperty(ref _unreadMessages);
			set => SetProperty(ref _unreadMessages, value);
		}

		[Ordinal(9)] 
		[RED("playerCanReply")] 
		public CBool PlayerCanReply
		{
			get => GetProperty(ref _playerCanReply);
			set => SetProperty(ref _playerCanReply, value);
		}

		[Ordinal(10)] 
		[RED("playerIsLastSender")] 
		public CBool PlayerIsLastSender
		{
			get => GetProperty(ref _playerIsLastSender);
			set => SetProperty(ref _playerIsLastSender, value);
		}

		[Ordinal(11)] 
		[RED("lastMesssagePreview")] 
		public CString LastMesssagePreview
		{
			get => GetProperty(ref _lastMesssagePreview);
			set => SetProperty(ref _lastMesssagePreview, value);
		}

		[Ordinal(12)] 
		[RED("activeDataSync")] 
		public wCHandle<MessengerContactSyncData> ActiveDataSync
		{
			get => GetProperty(ref _activeDataSync);
			set => SetProperty(ref _activeDataSync, value);
		}

		[Ordinal(13)] 
		[RED("threadsCount")] 
		public CInt32 ThreadsCount
		{
			get => GetProperty(ref _threadsCount);
			set => SetProperty(ref _threadsCount, value);
		}

		[Ordinal(14)] 
		[RED("timeStamp")] 
		public GameTime TimeStamp
		{
			get => GetProperty(ref _timeStamp);
			set => SetProperty(ref _timeStamp, value);
		}

		[Ordinal(15)] 
		[RED("hash")] 
		public CInt32 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(16)] 
		[RED("conversationHash")] 
		public CInt32 ConversationHash
		{
			get => GetProperty(ref _conversationHash);
			set => SetProperty(ref _conversationHash, value);
		}

		[Ordinal(17)] 
		[RED("type")] 
		public CEnum<MessengerContactType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(18)] 
		[RED("hasValidTitle")] 
		public CBool HasValidTitle
		{
			get => GetProperty(ref _hasValidTitle);
			set => SetProperty(ref _hasValidTitle, value);
		}

		[Ordinal(19)] 
		[RED("isCallable")] 
		public CBool IsCallable
		{
			get => GetProperty(ref _isCallable);
			set => SetProperty(ref _isCallable, value);
		}

		[Ordinal(20)] 
		[RED("contactId")] 
		public CString ContactId
		{
			get => GetProperty(ref _contactId);
			set => SetProperty(ref _contactId, value);
		}

		[Ordinal(21)] 
		[RED("messagesCount")] 
		public CInt32 MessagesCount
		{
			get => GetProperty(ref _messagesCount);
			set => SetProperty(ref _messagesCount, value);
		}

		[Ordinal(22)] 
		[RED("repliesCount")] 
		public CInt32 RepliesCount
		{
			get => GetProperty(ref _repliesCount);
			set => SetProperty(ref _repliesCount, value);
		}

		public ContactData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
