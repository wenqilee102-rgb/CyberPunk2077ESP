using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HudPhoneGameController : gameuiSongbirdAudioCallGameController
	{
		private CBool _isAudioCall;
		private inkWidgetReference _avatarControllerRef;
		private wCHandle<HudPhoneAvatarController> _avatarController;
		private wCHandle<inkWidget> _rootWidget;
		private inkWidgetReference _holder;
		private wCHandle<gameObject> _owner;
		private CEnum<EHudPhoneFunction> _currentFunction;
		private questPhoneCallInformation _currentCallInformation;
		private wCHandle<gameJournalContact> _currentPhoneCallContact;
		private wCHandle<gameDelaySystem> _delaySystem;
		private wCHandle<PhoneSystem> _phoneSystem;
		private wCHandle<gameJournalManager> _journalMgr;
		private CArray<CName> _gameplayRestrictions;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UI_ComDeviceDef> _blackboardDef;
		private CHandle<redCallbackObject> _callInformationBBID;
		private CHandle<redCallbackObject> _statusNameBBID;
		private CHandle<redCallbackObject> _minimizedListener;
		private gameDelayID _delayedCallbackId;
		private gameDelayID _delayedTimeoutCallbackId;
		private CFloat _timeoutPeroid;
		private CBool _buttonPressed;

		[Ordinal(13)] 
		[RED("isAudioCall")] 
		public CBool IsAudioCall
		{
			get => GetProperty(ref _isAudioCall);
			set => SetProperty(ref _isAudioCall, value);
		}

		[Ordinal(14)] 
		[RED("AvatarControllerRef")] 
		public inkWidgetReference AvatarControllerRef
		{
			get => GetProperty(ref _avatarControllerRef);
			set => SetProperty(ref _avatarControllerRef, value);
		}

		[Ordinal(15)] 
		[RED("AvatarController")] 
		public wCHandle<HudPhoneAvatarController> AvatarController
		{
			get => GetProperty(ref _avatarController);
			set => SetProperty(ref _avatarController, value);
		}

		[Ordinal(16)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(17)] 
		[RED("Holder")] 
		public inkWidgetReference Holder
		{
			get => GetProperty(ref _holder);
			set => SetProperty(ref _holder, value);
		}

		[Ordinal(18)] 
		[RED("Owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(19)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get => GetProperty(ref _currentFunction);
			set => SetProperty(ref _currentFunction, value);
		}

		[Ordinal(20)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get => GetProperty(ref _currentCallInformation);
			set => SetProperty(ref _currentCallInformation, value);
		}

		[Ordinal(21)] 
		[RED("CurrentPhoneCallContact")] 
		public wCHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get => GetProperty(ref _currentPhoneCallContact);
			set => SetProperty(ref _currentPhoneCallContact, value);
		}

		[Ordinal(22)] 
		[RED("DelaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(23)] 
		[RED("PhoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(24)] 
		[RED("JournalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(25)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get => GetProperty(ref _gameplayRestrictions);
			set => SetProperty(ref _gameplayRestrictions, value);
		}

		[Ordinal(26)] 
		[RED("Blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(27)] 
		[RED("BlackboardDef")] 
		public CHandle<UI_ComDeviceDef> BlackboardDef
		{
			get => GetProperty(ref _blackboardDef);
			set => SetProperty(ref _blackboardDef, value);
		}

		[Ordinal(28)] 
		[RED("CallInformationBBID")] 
		public CHandle<redCallbackObject> CallInformationBBID
		{
			get => GetProperty(ref _callInformationBBID);
			set => SetProperty(ref _callInformationBBID, value);
		}

		[Ordinal(29)] 
		[RED("StatusNameBBID")] 
		public CHandle<redCallbackObject> StatusNameBBID
		{
			get => GetProperty(ref _statusNameBBID);
			set => SetProperty(ref _statusNameBBID, value);
		}

		[Ordinal(30)] 
		[RED("MinimizedListener")] 
		public CHandle<redCallbackObject> MinimizedListener
		{
			get => GetProperty(ref _minimizedListener);
			set => SetProperty(ref _minimizedListener, value);
		}

		[Ordinal(31)] 
		[RED("DelayedCallbackId")] 
		public gameDelayID DelayedCallbackId
		{
			get => GetProperty(ref _delayedCallbackId);
			set => SetProperty(ref _delayedCallbackId, value);
		}

		[Ordinal(32)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetProperty(ref _delayedTimeoutCallbackId);
			set => SetProperty(ref _delayedTimeoutCallbackId, value);
		}

		[Ordinal(33)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetProperty(ref _timeoutPeroid);
			set => SetProperty(ref _timeoutPeroid, value);
		}

		[Ordinal(34)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get => GetProperty(ref _buttonPressed);
			set => SetProperty(ref _buttonPressed, value);
		}

		public HudPhoneGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
