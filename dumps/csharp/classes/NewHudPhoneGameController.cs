using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewHudPhoneGameController : gameuiNewHudPhoneGameController
	{
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gameJournalManager> _journalMgr;
		private wCHandle<questQuestsSystem> _questsSystem;
		private wCHandle<gameuiGameSystemUI> _uiSystem;
		private CUInt32 _fact1ListenerId;
		private CUInt32 _fact2ListenerId;
		private CUInt32 _fact3ListenerId;
		private CHandle<redCallbackObject> _onNotificationsQueueChanged;
		private CInt32 _currActiveQueueId;
		private CEnum<EHudPhoneFunction> _currentFunction;
		private CArray<CName> _gameplayRestrictions;
		private CBool _buttonPressed;
		private CBool _repeatingScrollActionEnabled;
		private CFloat _timeoutPeroid;
		private CUInt32 _activePhoneElements;
		private wCHandle<gameBlackboardSystem> _bbSystem;
		private CHandle<UI_SystemDef> _bbUiSystemDef;
		private wCHandle<gameIBlackboard> _bbUiSystem;
		private CHandle<redCallbackObject> _isInMenuCallback;
		private CHandle<UI_ComDeviceDef> _bbUiComDeviceDef;
		private wCHandle<gameIBlackboard> _bbUiComDevice;
		private CHandle<redCallbackObject> _phoneCallInformationCallback;
		private CHandle<redCallbackObject> _phoneStatusChangedCallback;
		private CHandle<redCallbackObject> _phoneMinimizedCallback;
		private CHandle<redCallbackObject> _contactsActiveCallback;
		private CHandle<redCallbackObject> _messageToOpenCallback;
		private CHandle<redCallbackObject> _phoneEnabledBBId;
		private CHandle<UI_QuickSlotsDataDef> _bbUiQuickSlotsDataDef;
		private wCHandle<gameIBlackboard> _bbUiQuickSlotsData;
		private CHandle<UI_PlayerStatsDef> _bbUiPlayerStatsDef;
		private wCHandle<gameIBlackboard> _bbUiPlayerStats;
		private wCHandle<gameDelaySystem> _delaySystem;
		private gameDelayID _delayedTimeoutCallbackId;
		private wCHandle<PhoneSystem> _phoneSystem;
		private questPhoneCallInformation _currentCallInformation;
		private wCHandle<gameJournalContact> _currentPhoneCallContact;
		private wCHandle<HoloAudioCallLogicController> _holoAudioCallLogicController;
		private wCHandle<PhoneDialerLogicController> _contactListLogicController;
		private CHandle<inkanimProxy> _phoneIconAnimProxy;
		private CHandle<inkanimProxy> _backgroundAnimProxy;
		private CEnum<PhoneScreenType> _screenType;
		private CBool _messagesPanelVisible;
		private CBool _messagesPanelSpawned;
		private CBool _threadsVisible;
		private CInt32 _messageToOpenHash;
		private CUInt32 _indexToSelect;
		private CBool _isSingleThread;
		private CBool _isShowingAllMessages;
		private CBool _keepOpenWhenInHubMenu;
		private wCHandle<gameGameAudioSystem> _audioSystem;
		private CBool _isRemoteControllingDevice;
		private CHandle<redCallbackObject> _psmIsControllingDeviceCallback;
		private CHandle<redCallbackObject> _vehicleEnterCallback;

		[Ordinal(17)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(18)] 
		[RED("journalMgr")] 
		public wCHandle<gameJournalManager> JournalMgr
		{
			get => GetProperty(ref _journalMgr);
			set => SetProperty(ref _journalMgr, value);
		}

		[Ordinal(19)] 
		[RED("questsSystem")] 
		public wCHandle<questQuestsSystem> QuestsSystem
		{
			get => GetProperty(ref _questsSystem);
			set => SetProperty(ref _questsSystem, value);
		}

		[Ordinal(20)] 
		[RED("uiSystem")] 
		public wCHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(21)] 
		[RED("fact1ListenerId")] 
		public CUInt32 Fact1ListenerId
		{
			get => GetProperty(ref _fact1ListenerId);
			set => SetProperty(ref _fact1ListenerId, value);
		}

		[Ordinal(22)] 
		[RED("fact2ListenerId")] 
		public CUInt32 Fact2ListenerId
		{
			get => GetProperty(ref _fact2ListenerId);
			set => SetProperty(ref _fact2ListenerId, value);
		}

		[Ordinal(23)] 
		[RED("fact3ListenerId")] 
		public CUInt32 Fact3ListenerId
		{
			get => GetProperty(ref _fact3ListenerId);
			set => SetProperty(ref _fact3ListenerId, value);
		}

		[Ordinal(24)] 
		[RED("onNotificationsQueueChanged")] 
		public CHandle<redCallbackObject> OnNotificationsQueueChanged
		{
			get => GetProperty(ref _onNotificationsQueueChanged);
			set => SetProperty(ref _onNotificationsQueueChanged, value);
		}

		[Ordinal(25)] 
		[RED("currActiveQueueId")] 
		public CInt32 CurrActiveQueueId
		{
			get => GetProperty(ref _currActiveQueueId);
			set => SetProperty(ref _currActiveQueueId, value);
		}

		[Ordinal(26)] 
		[RED("CurrentFunction")] 
		public CEnum<EHudPhoneFunction> CurrentFunction
		{
			get => GetProperty(ref _currentFunction);
			set => SetProperty(ref _currentFunction, value);
		}

		[Ordinal(27)] 
		[RED("gameplayRestrictions")] 
		public CArray<CName> GameplayRestrictions
		{
			get => GetProperty(ref _gameplayRestrictions);
			set => SetProperty(ref _gameplayRestrictions, value);
		}

		[Ordinal(28)] 
		[RED("buttonPressed")] 
		public CBool ButtonPressed
		{
			get => GetProperty(ref _buttonPressed);
			set => SetProperty(ref _buttonPressed, value);
		}

		[Ordinal(29)] 
		[RED("repeatingScrollActionEnabled")] 
		public CBool RepeatingScrollActionEnabled
		{
			get => GetProperty(ref _repeatingScrollActionEnabled);
			set => SetProperty(ref _repeatingScrollActionEnabled, value);
		}

		[Ordinal(30)] 
		[RED("TimeoutPeroid")] 
		public CFloat TimeoutPeroid
		{
			get => GetProperty(ref _timeoutPeroid);
			set => SetProperty(ref _timeoutPeroid, value);
		}

		[Ordinal(31)] 
		[RED("activePhoneElements")] 
		public CUInt32 ActivePhoneElements
		{
			get => GetProperty(ref _activePhoneElements);
			set => SetProperty(ref _activePhoneElements, value);
		}

		[Ordinal(32)] 
		[RED("bbSystem")] 
		public wCHandle<gameBlackboardSystem> BbSystem
		{
			get => GetProperty(ref _bbSystem);
			set => SetProperty(ref _bbSystem, value);
		}

		[Ordinal(33)] 
		[RED("bbUiSystemDef")] 
		public CHandle<UI_SystemDef> BbUiSystemDef
		{
			get => GetProperty(ref _bbUiSystemDef);
			set => SetProperty(ref _bbUiSystemDef, value);
		}

		[Ordinal(34)] 
		[RED("bbUiSystem")] 
		public wCHandle<gameIBlackboard> BbUiSystem
		{
			get => GetProperty(ref _bbUiSystem);
			set => SetProperty(ref _bbUiSystem, value);
		}

		[Ordinal(35)] 
		[RED("isInMenuCallback")] 
		public CHandle<redCallbackObject> IsInMenuCallback
		{
			get => GetProperty(ref _isInMenuCallback);
			set => SetProperty(ref _isInMenuCallback, value);
		}

		[Ordinal(36)] 
		[RED("bbUiComDeviceDef")] 
		public CHandle<UI_ComDeviceDef> BbUiComDeviceDef
		{
			get => GetProperty(ref _bbUiComDeviceDef);
			set => SetProperty(ref _bbUiComDeviceDef, value);
		}

		[Ordinal(37)] 
		[RED("bbUiComDevice")] 
		public wCHandle<gameIBlackboard> BbUiComDevice
		{
			get => GetProperty(ref _bbUiComDevice);
			set => SetProperty(ref _bbUiComDevice, value);
		}

		[Ordinal(38)] 
		[RED("phoneCallInformationCallback")] 
		public CHandle<redCallbackObject> PhoneCallInformationCallback
		{
			get => GetProperty(ref _phoneCallInformationCallback);
			set => SetProperty(ref _phoneCallInformationCallback, value);
		}

		[Ordinal(39)] 
		[RED("phoneStatusChangedCallback")] 
		public CHandle<redCallbackObject> PhoneStatusChangedCallback
		{
			get => GetProperty(ref _phoneStatusChangedCallback);
			set => SetProperty(ref _phoneStatusChangedCallback, value);
		}

		[Ordinal(40)] 
		[RED("phoneMinimizedCallback")] 
		public CHandle<redCallbackObject> PhoneMinimizedCallback
		{
			get => GetProperty(ref _phoneMinimizedCallback);
			set => SetProperty(ref _phoneMinimizedCallback, value);
		}

		[Ordinal(41)] 
		[RED("contactsActiveCallback")] 
		public CHandle<redCallbackObject> ContactsActiveCallback
		{
			get => GetProperty(ref _contactsActiveCallback);
			set => SetProperty(ref _contactsActiveCallback, value);
		}

		[Ordinal(42)] 
		[RED("messageToOpenCallback")] 
		public CHandle<redCallbackObject> MessageToOpenCallback
		{
			get => GetProperty(ref _messageToOpenCallback);
			set => SetProperty(ref _messageToOpenCallback, value);
		}

		[Ordinal(43)] 
		[RED("phoneEnabledBBId")] 
		public CHandle<redCallbackObject> PhoneEnabledBBId
		{
			get => GetProperty(ref _phoneEnabledBBId);
			set => SetProperty(ref _phoneEnabledBBId, value);
		}

		[Ordinal(44)] 
		[RED("bbUiQuickSlotsDataDef")] 
		public CHandle<UI_QuickSlotsDataDef> BbUiQuickSlotsDataDef
		{
			get => GetProperty(ref _bbUiQuickSlotsDataDef);
			set => SetProperty(ref _bbUiQuickSlotsDataDef, value);
		}

		[Ordinal(45)] 
		[RED("bbUiQuickSlotsData")] 
		public wCHandle<gameIBlackboard> BbUiQuickSlotsData
		{
			get => GetProperty(ref _bbUiQuickSlotsData);
			set => SetProperty(ref _bbUiQuickSlotsData, value);
		}

		[Ordinal(46)] 
		[RED("bbUiPlayerStatsDef")] 
		public CHandle<UI_PlayerStatsDef> BbUiPlayerStatsDef
		{
			get => GetProperty(ref _bbUiPlayerStatsDef);
			set => SetProperty(ref _bbUiPlayerStatsDef, value);
		}

		[Ordinal(47)] 
		[RED("bbUiPlayerStats")] 
		public wCHandle<gameIBlackboard> BbUiPlayerStats
		{
			get => GetProperty(ref _bbUiPlayerStats);
			set => SetProperty(ref _bbUiPlayerStats, value);
		}

		[Ordinal(48)] 
		[RED("DelaySystem")] 
		public wCHandle<gameDelaySystem> DelaySystem
		{
			get => GetProperty(ref _delaySystem);
			set => SetProperty(ref _delaySystem, value);
		}

		[Ordinal(49)] 
		[RED("DelayedTimeoutCallbackId")] 
		public gameDelayID DelayedTimeoutCallbackId
		{
			get => GetProperty(ref _delayedTimeoutCallbackId);
			set => SetProperty(ref _delayedTimeoutCallbackId, value);
		}

		[Ordinal(50)] 
		[RED("PhoneSystem")] 
		public wCHandle<PhoneSystem> PhoneSystem
		{
			get => GetProperty(ref _phoneSystem);
			set => SetProperty(ref _phoneSystem, value);
		}

		[Ordinal(51)] 
		[RED("CurrentCallInformation")] 
		public questPhoneCallInformation CurrentCallInformation
		{
			get => GetProperty(ref _currentCallInformation);
			set => SetProperty(ref _currentCallInformation, value);
		}

		[Ordinal(52)] 
		[RED("CurrentPhoneCallContact")] 
		public wCHandle<gameJournalContact> CurrentPhoneCallContact
		{
			get => GetProperty(ref _currentPhoneCallContact);
			set => SetProperty(ref _currentPhoneCallContact, value);
		}

		[Ordinal(53)] 
		[RED("holoAudioCallLogicController")] 
		public wCHandle<HoloAudioCallLogicController> HoloAudioCallLogicController
		{
			get => GetProperty(ref _holoAudioCallLogicController);
			set => SetProperty(ref _holoAudioCallLogicController, value);
		}

		[Ordinal(54)] 
		[RED("contactListLogicController")] 
		public wCHandle<PhoneDialerLogicController> ContactListLogicController
		{
			get => GetProperty(ref _contactListLogicController);
			set => SetProperty(ref _contactListLogicController, value);
		}

		[Ordinal(55)] 
		[RED("phoneIconAnimProxy")] 
		public CHandle<inkanimProxy> PhoneIconAnimProxy
		{
			get => GetProperty(ref _phoneIconAnimProxy);
			set => SetProperty(ref _phoneIconAnimProxy, value);
		}

		[Ordinal(56)] 
		[RED("backgroundAnimProxy")] 
		public CHandle<inkanimProxy> BackgroundAnimProxy
		{
			get => GetProperty(ref _backgroundAnimProxy);
			set => SetProperty(ref _backgroundAnimProxy, value);
		}

		[Ordinal(57)] 
		[RED("screenType")] 
		public CEnum<PhoneScreenType> ScreenType
		{
			get => GetProperty(ref _screenType);
			set => SetProperty(ref _screenType, value);
		}

		[Ordinal(58)] 
		[RED("messagesPanelVisible")] 
		public CBool MessagesPanelVisible
		{
			get => GetProperty(ref _messagesPanelVisible);
			set => SetProperty(ref _messagesPanelVisible, value);
		}

		[Ordinal(59)] 
		[RED("messagesPanelSpawned")] 
		public CBool MessagesPanelSpawned
		{
			get => GetProperty(ref _messagesPanelSpawned);
			set => SetProperty(ref _messagesPanelSpawned, value);
		}

		[Ordinal(60)] 
		[RED("threadsVisible")] 
		public CBool ThreadsVisible
		{
			get => GetProperty(ref _threadsVisible);
			set => SetProperty(ref _threadsVisible, value);
		}

		[Ordinal(61)] 
		[RED("messageToOpenHash")] 
		public CInt32 MessageToOpenHash
		{
			get => GetProperty(ref _messageToOpenHash);
			set => SetProperty(ref _messageToOpenHash, value);
		}

		[Ordinal(62)] 
		[RED("indexToSelect")] 
		public CUInt32 IndexToSelect
		{
			get => GetProperty(ref _indexToSelect);
			set => SetProperty(ref _indexToSelect, value);
		}

		[Ordinal(63)] 
		[RED("isSingleThread")] 
		public CBool IsSingleThread
		{
			get => GetProperty(ref _isSingleThread);
			set => SetProperty(ref _isSingleThread, value);
		}

		[Ordinal(64)] 
		[RED("isShowingAllMessages")] 
		public CBool IsShowingAllMessages
		{
			get => GetProperty(ref _isShowingAllMessages);
			set => SetProperty(ref _isShowingAllMessages, value);
		}

		[Ordinal(65)] 
		[RED("keepOpenWhenInHubMenu")] 
		public CBool KeepOpenWhenInHubMenu
		{
			get => GetProperty(ref _keepOpenWhenInHubMenu);
			set => SetProperty(ref _keepOpenWhenInHubMenu, value);
		}

		[Ordinal(66)] 
		[RED("audioSystem")] 
		public wCHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetProperty(ref _audioSystem);
			set => SetProperty(ref _audioSystem, value);
		}

		[Ordinal(67)] 
		[RED("isRemoteControllingDevice")] 
		public CBool IsRemoteControllingDevice
		{
			get => GetProperty(ref _isRemoteControllingDevice);
			set => SetProperty(ref _isRemoteControllingDevice, value);
		}

		[Ordinal(68)] 
		[RED("psmIsControllingDeviceCallback")] 
		public CHandle<redCallbackObject> PsmIsControllingDeviceCallback
		{
			get => GetProperty(ref _psmIsControllingDeviceCallback);
			set => SetProperty(ref _psmIsControllingDeviceCallback, value);
		}

		[Ordinal(69)] 
		[RED("vehicleEnterCallback")] 
		public CHandle<redCallbackObject> VehicleEnterCallback
		{
			get => GetProperty(ref _vehicleEnterCallback);
			set => SetProperty(ref _vehicleEnterCallback, value);
		}

		public NewHudPhoneGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
