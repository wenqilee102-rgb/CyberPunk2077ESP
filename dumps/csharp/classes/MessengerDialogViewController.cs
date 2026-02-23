using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MessengerDialogViewController : inkWidgetLogicController
	{
		private inkCompoundWidgetReference _messagesList;
		private inkCompoundWidgetReference _choicesList;
		private inkCompoundWidgetReference _replayFluff;
		private inkWidgetReference _typingFluff;
		private inkWidgetReference _typingIndicator;
		private wCHandle<JournalEntriesListController> _messagesListController;
		private wCHandle<JournalEntriesListController> _choicesListController;
		private wCHandle<inkScrollController> _scrollController;
		private wCHandle<MessengerTypingIndicator> _typingIndicatorController;
		private wCHandle<gameJournalManager> _journalManager;
		private wCHandle<gameObject> _playerObject;
		private wCHandle<gameDelaySystem> _delaySystem;
		private gameDelayID _delayedTypingCallbackId;
		private CArray<wCHandle<gameJournalEntry>> _replyOptions;
		private CArray<wCHandle<gameJournalEntry>> _messages;
		private wCHandle<gameJournalEntry> _parentEntry;
		private CInt32 _parentHash;
		private CInt32 _conversationHash;
		private CInt32 _contactHash;
		private CHandle<inkanimProxy> _typingAnimProxy;
		private CHandle<inkanimProxy> _delayTypingAnimProxy;
		private CBool _singleThreadMode;
		private CBool _hasFocus;
		private wCHandle<gameGameAudioSystem> _audioSystem;
		private CFloat _minimumTypingDelay;
		private CHandle<inkanimProxy> _breakingTypingAnimProxy;

		[Ordinal(1)] 
		[RED("messagesList")] 
		public inkCompoundWidgetReference MessagesList
		{
			get => GetProperty(ref _messagesList);
			set => SetProperty(ref _messagesList, value);
		}

		[Ordinal(2)] 
		[RED("choicesList")] 
		public inkCompoundWidgetReference ChoicesList
		{
			get => GetProperty(ref _choicesList);
			set => SetProperty(ref _choicesList, value);
		}

		[Ordinal(3)] 
		[RED("replayFluff")] 
		public inkCompoundWidgetReference ReplayFluff
		{
			get => GetProperty(ref _replayFluff);
			set => SetProperty(ref _replayFluff, value);
		}

		[Ordinal(4)] 
		[RED("typingFluff")] 
		public inkWidgetReference TypingFluff
		{
			get => GetProperty(ref _typingFluff);
			set => SetProperty(ref _typingFluff, value);
		}

		[Ordinal(5)] 
		[RED("typingIndicator")] 
		public inkWidgetReference TypingIndicator
		{
			get => GetProperty(ref _typingIndicator);
			set => SetProperty(ref _typingIndicator, value);
		}

		[Ordinal(6)] 
		[RED("messagesListController")] 
		public wCHandle<JournalEntriesListController> MessagesListController
		{
			get => GetProperty(ref _messagesListController);
			set => SetProperty(ref _messagesListController, value);
		}

		[Ordinal(7)] 
		[RED("choicesListController")] 
		public wCHandle<JournalEntriesListController> ChoicesListController
		{
			get => GetProperty(ref _choicesListController);
			set => SetProperty(ref _choicesListController, value);
		}

		[Ordinal(8)] 
		[RED("scrollController")] 
		public wCHandle<inkScrollController> ScrollController
		{
			get => GetProperty(ref _scrollController);
			set => SetProperty(ref _scrollController, value);
		}

		[Ordinal(9)] 
		[RED("typingIndicatorController")] 
		public wCHandle<MessengerTypingIndicator> TypingIndicatorController
		{
			get => GetProperty(ref _typingIndicatorController);
			set => SetProperty(ref _typingIndicatorController, value);
		}

		[Ordinal(10)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(11)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(12)] 
		[RED("delaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(13)] 
		[RED("delayedTypingCallbackId")] 
		public gameDelayID DelayedTypingCallbackId
		{
			get => GetProperty(ref _delayedTypingCallbackId);
			set => SetProperty(ref _delayedTypingCallbackId, value);
		}

		[Ordinal(14)] 
		[RED("replyOptions")] 
		public CArray<wCHandle<gameJournalEntry>> ReplyOptions
		{
			get => GetProperty(ref _replyOptions);
			set => SetProperty(ref _replyOptions, value);
		}

		[Ordinal(15)] 
		[RED("messages")] 
		public CArray<wCHandle<gameJournalEntry>> Messages
		{
			get => GetProperty(ref _messages);
			set => SetProperty(ref _messages, value);
		}

		[Ordinal(16)] 
		[RED("parentEntry")] 
		public wCHandle<gameJournalEntry> ParentEntry
		{
			get => GetProperty(ref _parentEntry);
			set => SetProperty(ref _parentEntry, value);
		}

		[Ordinal(17)] 
		[RED("parentHash")] 
		public CInt32 ParentHash
		{
			get => GetProperty(ref _parentHash);
			set => SetProperty(ref _parentHash, value);
		}

		[Ordinal(18)] 
		[RED("conversationHash")] 
		public CInt32 ConversationHash
		{
			get => GetProperty(ref _conversationHash);
			set => SetProperty(ref _conversationHash, value);
		}

		[Ordinal(19)] 
		[RED("contactHash")] 
		public CInt32 ContactHash
		{
			get => GetProperty(ref _contactHash);
			set => SetProperty(ref _contactHash, value);
		}

		[Ordinal(20)] 
		[RED("typingAnimProxy")] 
		public CHandle<inkanimProxy> TypingAnimProxy
		{
			get => GetProperty(ref _typingAnimProxy);
			set => SetProperty(ref _typingAnimProxy, value);
		}

		[Ordinal(21)] 
		[RED("delayTypingAnimProxy")] 
		public CHandle<inkanimProxy> DelayTypingAnimProxy
		{
			get => GetProperty(ref _delayTypingAnimProxy);
			set => SetProperty(ref _delayTypingAnimProxy, value);
		}

		[Ordinal(22)] 
		[RED("singleThreadMode")] 
		public CBool SingleThreadMode
		{
			get => GetProperty(ref _singleThreadMode);
			set => SetProperty(ref _singleThreadMode, value);
		}

		[Ordinal(23)] 
		[RED("hasFocus")] 
		public CBool HasFocus
		{
			get => GetProperty(ref _hasFocus);
			set => SetProperty(ref _hasFocus, value);
		}

		[Ordinal(24)] 
		[RED("audioSystem")] 
		public wCHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetProperty(ref _audioSystem);
			set => SetProperty(ref _audioSystem, value);
		}

		[Ordinal(25)] 
		[RED("minimumTypingDelay")] 
		public CFloat MinimumTypingDelay
		{
			get => GetProperty(ref _minimumTypingDelay);
			set => SetProperty(ref _minimumTypingDelay, value);
		}

		[Ordinal(26)] 
		[RED("breakingTypingAnimProxy")] 
		public CHandle<inkanimProxy> BreakingTypingAnimProxy
		{
			get => GetProperty(ref _breakingTypingAnimProxy);
			set => SetProperty(ref _breakingTypingAnimProxy, value);
		}

		public MessengerDialogViewController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
