using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPopupsManager : gameuiWidgetGameController
	{
		private inkCompoundWidgetReference _bracketsContainer;
		private inkCompoundWidgetReference _tutorialOverlayContainer;
		private CName _bracketLibraryID;
		private wCHandle<gameIBlackboard> _blackboard;
		private CHandle<UIGameDataDef> _bbDefinition;
		private wCHandle<gameJournalManager> _journalManager;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<gameIBlackboard> _uiSystemBB;
		private CHandle<UI_SystemDef> _uiSystemBBDef;
		private CHandle<redCallbackObject> _uiSystemId;
		private CHandle<redCallbackObject> _isShownBbId;
		private CHandle<redCallbackObject> _dataBbId;
		private CHandle<redCallbackObject> _photomodeActiveId;
		private CHandle<redCallbackObject> _phoneActiveId;
		private CBool _tutorialOnHold;
		private gamePopupData _tutorialData;
		private gamePopupSettings _tutorialSettings;
		private CBool _phoneMessageOnHold;
		private CHandle<JournalNotificationData> _phoneMessageData;
		private CBool _shardReadOnHold;
		private CHandle<NotifyShardRead> _shardReadData;
		private CHandle<inkFrameNotificationData> _smartFrameData;
		private CHandle<inkGameNotificationData> _vehicleColorSelectorData;
		private CHandle<inkGameNotificationToken> _tutorialToken;
		private CHandle<inkGameNotificationToken> _phoneMessageToken;
		private CHandle<inkGameNotificationToken> _shardToken;
		private CHandle<inkGameNotificationToken> _vehiclesManagerToken;
		private CHandle<inkGameNotificationToken> _vehicleRadioToken;
		private CHandle<inkGameNotificationToken> _codexToken;
		private CHandle<inkGameNotificationToken> _ponrToken;
		private CHandle<inkGameNotificationToken> _twintoneOverride;
		private CHandle<inkGameNotificationToken> _expansionToken;
		private CHandle<inkGameNotificationToken> _expansionErrorToken;
		private CHandle<inkGameNotificationToken> _patchNotesToken;
		private CHandle<inkGameNotificationToken> _marketingConsentToken;
		private CHandle<inkGameNotificationToken> _signInToken;
		private CHandle<inkGameNotificationToken> _expansionStateToken;
		private CHandle<inkGameNotificationToken> _vehicleVisualCustomizationSelectorToken;
		private CHandle<inkGameNotificationToken> _frameSwitcherToken;
		private CBool _isInMenu;
		private CBool _isInPhotoMode;
		private CBool _isOnPhone;
		private CBool _isBlockingPopupOpened;
		private CArray<CHandle<inkGameNotificationData>> _popUpQueue;
		private CBool _activePopUp;

		[Ordinal(2)] 
		[RED("bracketsContainer")] 
		public inkCompoundWidgetReference BracketsContainer
		{
			get => GetProperty(ref _bracketsContainer);
			set => SetProperty(ref _bracketsContainer, value);
		}

		[Ordinal(3)] 
		[RED("tutorialOverlayContainer")] 
		public inkCompoundWidgetReference TutorialOverlayContainer
		{
			get => GetProperty(ref _tutorialOverlayContainer);
			set => SetProperty(ref _tutorialOverlayContainer, value);
		}

		[Ordinal(4)] 
		[RED("bracketLibraryID")] 
		public CName BracketLibraryID
		{
			get => GetProperty(ref _bracketLibraryID);
			set => SetProperty(ref _bracketLibraryID, value);
		}

		[Ordinal(5)] 
		[RED("blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(6)] 
		[RED("bbDefinition")] 
		public CHandle<UIGameDataDef> BbDefinition
		{
			get => GetProperty(ref _bbDefinition);
			set => SetProperty(ref _bbDefinition, value);
		}

		[Ordinal(7)] 
		[RED("journalManager")] 
		public wCHandle<gameJournalManager> JournalManager
		{
			get => GetProperty(ref _journalManager);
			set => SetProperty(ref _journalManager, value);
		}

		[Ordinal(8)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(9)] 
		[RED("uiSystemBB")] 
		public wCHandle<gameIBlackboard> UiSystemBB
		{
			get => GetProperty(ref _uiSystemBB);
			set => SetProperty(ref _uiSystemBB, value);
		}

		[Ordinal(10)] 
		[RED("uiSystemBBDef")] 
		public CHandle<UI_SystemDef> UiSystemBBDef
		{
			get => GetProperty(ref _uiSystemBBDef);
			set => SetProperty(ref _uiSystemBBDef, value);
		}

		[Ordinal(11)] 
		[RED("uiSystemId")] 
		public CHandle<redCallbackObject> UiSystemId
		{
			get => GetProperty(ref _uiSystemId);
			set => SetProperty(ref _uiSystemId, value);
		}

		[Ordinal(12)] 
		[RED("isShownBbId")] 
		public CHandle<redCallbackObject> IsShownBbId
		{
			get => GetProperty(ref _isShownBbId);
			set => SetProperty(ref _isShownBbId, value);
		}

		[Ordinal(13)] 
		[RED("dataBbId")] 
		public CHandle<redCallbackObject> DataBbId
		{
			get => GetProperty(ref _dataBbId);
			set => SetProperty(ref _dataBbId, value);
		}

		[Ordinal(14)] 
		[RED("photomodeActiveId")] 
		public CHandle<redCallbackObject> PhotomodeActiveId
		{
			get => GetProperty(ref _photomodeActiveId);
			set => SetProperty(ref _photomodeActiveId, value);
		}

		[Ordinal(15)] 
		[RED("phoneActiveId")] 
		public CHandle<redCallbackObject> PhoneActiveId
		{
			get => GetProperty(ref _phoneActiveId);
			set => SetProperty(ref _phoneActiveId, value);
		}

		[Ordinal(16)] 
		[RED("tutorialOnHold")] 
		public CBool TutorialOnHold
		{
			get => GetProperty(ref _tutorialOnHold);
			set => SetProperty(ref _tutorialOnHold, value);
		}

		[Ordinal(17)] 
		[RED("tutorialData")] 
		public gamePopupData TutorialData
		{
			get => GetProperty(ref _tutorialData);
			set => SetProperty(ref _tutorialData, value);
		}

		[Ordinal(18)] 
		[RED("tutorialSettings")] 
		public gamePopupSettings TutorialSettings
		{
			get => GetProperty(ref _tutorialSettings);
			set => SetProperty(ref _tutorialSettings, value);
		}

		[Ordinal(19)] 
		[RED("phoneMessageOnHold")] 
		public CBool PhoneMessageOnHold
		{
			get => GetProperty(ref _phoneMessageOnHold);
			set => SetProperty(ref _phoneMessageOnHold, value);
		}

		[Ordinal(20)] 
		[RED("phoneMessageData")] 
		public CHandle<JournalNotificationData> PhoneMessageData
		{
			get => GetProperty(ref _phoneMessageData);
			set => SetProperty(ref _phoneMessageData, value);
		}

		[Ordinal(21)] 
		[RED("shardReadOnHold")] 
		public CBool ShardReadOnHold
		{
			get => GetProperty(ref _shardReadOnHold);
			set => SetProperty(ref _shardReadOnHold, value);
		}

		[Ordinal(22)] 
		[RED("shardReadData")] 
		public CHandle<NotifyShardRead> ShardReadData
		{
			get => GetProperty(ref _shardReadData);
			set => SetProperty(ref _shardReadData, value);
		}

		[Ordinal(23)] 
		[RED("smartFrameData")] 
		public CHandle<inkFrameNotificationData> SmartFrameData
		{
			get => GetProperty(ref _smartFrameData);
			set => SetProperty(ref _smartFrameData, value);
		}

		[Ordinal(24)] 
		[RED("vehicleColorSelectorData")] 
		public CHandle<inkGameNotificationData> VehicleColorSelectorData
		{
			get => GetProperty(ref _vehicleColorSelectorData);
			set => SetProperty(ref _vehicleColorSelectorData, value);
		}

		[Ordinal(25)] 
		[RED("tutorialToken")] 
		public CHandle<inkGameNotificationToken> TutorialToken
		{
			get => GetProperty(ref _tutorialToken);
			set => SetProperty(ref _tutorialToken, value);
		}

		[Ordinal(26)] 
		[RED("phoneMessageToken")] 
		public CHandle<inkGameNotificationToken> PhoneMessageToken
		{
			get => GetProperty(ref _phoneMessageToken);
			set => SetProperty(ref _phoneMessageToken, value);
		}

		[Ordinal(27)] 
		[RED("shardToken")] 
		public CHandle<inkGameNotificationToken> ShardToken
		{
			get => GetProperty(ref _shardToken);
			set => SetProperty(ref _shardToken, value);
		}

		[Ordinal(28)] 
		[RED("vehiclesManagerToken")] 
		public CHandle<inkGameNotificationToken> VehiclesManagerToken
		{
			get => GetProperty(ref _vehiclesManagerToken);
			set => SetProperty(ref _vehiclesManagerToken, value);
		}

		[Ordinal(29)] 
		[RED("vehicleRadioToken")] 
		public CHandle<inkGameNotificationToken> VehicleRadioToken
		{
			get => GetProperty(ref _vehicleRadioToken);
			set => SetProperty(ref _vehicleRadioToken, value);
		}

		[Ordinal(30)] 
		[RED("codexToken")] 
		public CHandle<inkGameNotificationToken> CodexToken
		{
			get => GetProperty(ref _codexToken);
			set => SetProperty(ref _codexToken, value);
		}

		[Ordinal(31)] 
		[RED("ponrToken")] 
		public CHandle<inkGameNotificationToken> PonrToken
		{
			get => GetProperty(ref _ponrToken);
			set => SetProperty(ref _ponrToken, value);
		}

		[Ordinal(32)] 
		[RED("twintoneOverride")] 
		public CHandle<inkGameNotificationToken> TwintoneOverride
		{
			get => GetProperty(ref _twintoneOverride);
			set => SetProperty(ref _twintoneOverride, value);
		}

		[Ordinal(33)] 
		[RED("expansionToken")] 
		public CHandle<inkGameNotificationToken> ExpansionToken
		{
			get => GetProperty(ref _expansionToken);
			set => SetProperty(ref _expansionToken, value);
		}

		[Ordinal(34)] 
		[RED("expansionErrorToken")] 
		public CHandle<inkGameNotificationToken> ExpansionErrorToken
		{
			get => GetProperty(ref _expansionErrorToken);
			set => SetProperty(ref _expansionErrorToken, value);
		}

		[Ordinal(35)] 
		[RED("patchNotesToken")] 
		public CHandle<inkGameNotificationToken> PatchNotesToken
		{
			get => GetProperty(ref _patchNotesToken);
			set => SetProperty(ref _patchNotesToken, value);
		}

		[Ordinal(36)] 
		[RED("marketingConsentToken")] 
		public CHandle<inkGameNotificationToken> MarketingConsentToken
		{
			get => GetProperty(ref _marketingConsentToken);
			set => SetProperty(ref _marketingConsentToken, value);
		}

		[Ordinal(37)] 
		[RED("signInToken")] 
		public CHandle<inkGameNotificationToken> SignInToken
		{
			get => GetProperty(ref _signInToken);
			set => SetProperty(ref _signInToken, value);
		}

		[Ordinal(38)] 
		[RED("expansionStateToken")] 
		public CHandle<inkGameNotificationToken> ExpansionStateToken
		{
			get => GetProperty(ref _expansionStateToken);
			set => SetProperty(ref _expansionStateToken, value);
		}

		[Ordinal(39)] 
		[RED("vehicleVisualCustomizationSelectorToken")] 
		public CHandle<inkGameNotificationToken> VehicleVisualCustomizationSelectorToken
		{
			get => GetProperty(ref _vehicleVisualCustomizationSelectorToken);
			set => SetProperty(ref _vehicleVisualCustomizationSelectorToken, value);
		}

		[Ordinal(40)] 
		[RED("frameSwitcherToken")] 
		public CHandle<inkGameNotificationToken> FrameSwitcherToken
		{
			get => GetProperty(ref _frameSwitcherToken);
			set => SetProperty(ref _frameSwitcherToken, value);
		}

		[Ordinal(41)] 
		[RED("isInMenu")] 
		public CBool IsInMenu
		{
			get => GetProperty(ref _isInMenu);
			set => SetProperty(ref _isInMenu, value);
		}

		[Ordinal(42)] 
		[RED("isInPhotoMode")] 
		public CBool IsInPhotoMode
		{
			get => GetProperty(ref _isInPhotoMode);
			set => SetProperty(ref _isInPhotoMode, value);
		}

		[Ordinal(43)] 
		[RED("isOnPhone")] 
		public CBool IsOnPhone
		{
			get => GetProperty(ref _isOnPhone);
			set => SetProperty(ref _isOnPhone, value);
		}

		[Ordinal(44)] 
		[RED("isBlockingPopupOpened")] 
		public CBool IsBlockingPopupOpened
		{
			get => GetProperty(ref _isBlockingPopupOpened);
			set => SetProperty(ref _isBlockingPopupOpened, value);
		}

		[Ordinal(45)] 
		[RED("popUpQueue")] 
		public CArray<CHandle<inkGameNotificationData>> PopUpQueue
		{
			get => GetProperty(ref _popUpQueue);
			set => SetProperty(ref _popUpQueue, value);
		}

		[Ordinal(46)] 
		[RED("activePopUp")] 
		public CBool ActivePopUp
		{
			get => GetProperty(ref _activePopUp);
			set => SetProperty(ref _activePopUp, value);
		}

		public gameuiPopupsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
