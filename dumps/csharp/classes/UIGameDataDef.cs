using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIGameDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _breachUIParams;
		private gamebbScriptID_Variant _interactionData;
		private gamebbScriptID_Variant _showDialogLine;
		private gamebbScriptID_Variant _hideDialogLine;
		private gamebbScriptID_Variant _hideDialogLineByData;
		private gamebbScriptID_String _showSceneComment;
		private gamebbScriptID_Bool _hideSceneComment;
		private gamebbScriptID_Bool _showSubtitlesBackground;
		private gamebbScriptID_Bool _popup_IsModal;
		private gamebbScriptID_Bool _popup_IsShown;
		private gamebbScriptID_Variant _popup_Data;
		private gamebbScriptID_Variant _popup_Settings;
		private gamebbScriptID_Bool _controller_Disconnected;
		private gamebbScriptID_Variant _activityLog;
		private gamebbScriptID_Variant _rightWeaponRecordID;
		private gamebbScriptID_Variant _leftWeaponRecordID;
		private gamebbScriptID_Bool _uIVendorContextRequest;
		private gamebbScriptID_Variant _uIjailbreakData;
		private gamebbScriptID_Float _questTimerInitialDuration;
		private gamebbScriptID_Float _questTimerCurrentDuration;
		private gamebbScriptID_Bool _tutorial_EnableHighlight;
		private gamebbScriptID_Variant _tutorial_EntityRefToHighlight;
		private gamebbScriptID_Vector2 _weaponSway;
		private gamebbScriptID_Bool _applyWeaponSwayToCamera;
		private gamebbScriptID_Vector2 _normalizedWeaponSway;
		private gamebbScriptID_Variant _driverCombatCrosshairReticle;
		private gamebbScriptID_Int32 _notificationJournalHash;
		private gamebbScriptID_Bool _isBriefingActive;
		private gamebbScriptID_Variant _muppetStats;
		private gamebbScriptID_Int32 _activeNotificationsQueue;
		private gamebbScriptID_Bool _berserkActive;
		private gamebbScriptID_Bool _popup_VehiclesManager_IsShown;
		private gamebbScriptID_Bool _popup_Radio_IsShown;
		private gamebbScriptID_Bool _popup_Radio_Enabled;
		private gamebbScriptID_Bool _popup_CarColorPicker_IsShown;
		private gamebbScriptID_Bool _popup_TwintoneOverride_IsShown;
		private gamebbScriptID_Bool _popup_FrameSwitcher_IsShown;

		[Ordinal(0)] 
		[RED("BreachUIParams")] 
		public gamebbScriptID_Variant BreachUIParams
		{
			get => GetProperty(ref _breachUIParams);
			set => SetProperty(ref _breachUIParams, value);
		}

		[Ordinal(1)] 
		[RED("InteractionData")] 
		public gamebbScriptID_Variant InteractionData
		{
			get => GetProperty(ref _interactionData);
			set => SetProperty(ref _interactionData, value);
		}

		[Ordinal(2)] 
		[RED("ShowDialogLine")] 
		public gamebbScriptID_Variant ShowDialogLine
		{
			get => GetProperty(ref _showDialogLine);
			set => SetProperty(ref _showDialogLine, value);
		}

		[Ordinal(3)] 
		[RED("HideDialogLine")] 
		public gamebbScriptID_Variant HideDialogLine
		{
			get => GetProperty(ref _hideDialogLine);
			set => SetProperty(ref _hideDialogLine, value);
		}

		[Ordinal(4)] 
		[RED("HideDialogLineByData")] 
		public gamebbScriptID_Variant HideDialogLineByData
		{
			get => GetProperty(ref _hideDialogLineByData);
			set => SetProperty(ref _hideDialogLineByData, value);
		}

		[Ordinal(5)] 
		[RED("ShowSceneComment")] 
		public gamebbScriptID_String ShowSceneComment
		{
			get => GetProperty(ref _showSceneComment);
			set => SetProperty(ref _showSceneComment, value);
		}

		[Ordinal(6)] 
		[RED("HideSceneComment")] 
		public gamebbScriptID_Bool HideSceneComment
		{
			get => GetProperty(ref _hideSceneComment);
			set => SetProperty(ref _hideSceneComment, value);
		}

		[Ordinal(7)] 
		[RED("ShowSubtitlesBackground")] 
		public gamebbScriptID_Bool ShowSubtitlesBackground
		{
			get => GetProperty(ref _showSubtitlesBackground);
			set => SetProperty(ref _showSubtitlesBackground, value);
		}

		[Ordinal(8)] 
		[RED("Popup_IsModal")] 
		public gamebbScriptID_Bool Popup_IsModal
		{
			get => GetProperty(ref _popup_IsModal);
			set => SetProperty(ref _popup_IsModal, value);
		}

		[Ordinal(9)] 
		[RED("Popup_IsShown")] 
		public gamebbScriptID_Bool Popup_IsShown
		{
			get => GetProperty(ref _popup_IsShown);
			set => SetProperty(ref _popup_IsShown, value);
		}

		[Ordinal(10)] 
		[RED("Popup_Data")] 
		public gamebbScriptID_Variant Popup_Data
		{
			get => GetProperty(ref _popup_Data);
			set => SetProperty(ref _popup_Data, value);
		}

		[Ordinal(11)] 
		[RED("Popup_Settings")] 
		public gamebbScriptID_Variant Popup_Settings
		{
			get => GetProperty(ref _popup_Settings);
			set => SetProperty(ref _popup_Settings, value);
		}

		[Ordinal(12)] 
		[RED("Controller_Disconnected")] 
		public gamebbScriptID_Bool Controller_Disconnected
		{
			get => GetProperty(ref _controller_Disconnected);
			set => SetProperty(ref _controller_Disconnected, value);
		}

		[Ordinal(13)] 
		[RED("ActivityLog")] 
		public gamebbScriptID_Variant ActivityLog
		{
			get => GetProperty(ref _activityLog);
			set => SetProperty(ref _activityLog, value);
		}

		[Ordinal(14)] 
		[RED("RightWeaponRecordID")] 
		public gamebbScriptID_Variant RightWeaponRecordID
		{
			get => GetProperty(ref _rightWeaponRecordID);
			set => SetProperty(ref _rightWeaponRecordID, value);
		}

		[Ordinal(15)] 
		[RED("LeftWeaponRecordID")] 
		public gamebbScriptID_Variant LeftWeaponRecordID
		{
			get => GetProperty(ref _leftWeaponRecordID);
			set => SetProperty(ref _leftWeaponRecordID, value);
		}

		[Ordinal(16)] 
		[RED("UIVendorContextRequest")] 
		public gamebbScriptID_Bool UIVendorContextRequest
		{
			get => GetProperty(ref _uIVendorContextRequest);
			set => SetProperty(ref _uIVendorContextRequest, value);
		}

		[Ordinal(17)] 
		[RED("UIjailbreakData")] 
		public gamebbScriptID_Variant UIjailbreakData
		{
			get => GetProperty(ref _uIjailbreakData);
			set => SetProperty(ref _uIjailbreakData, value);
		}

		[Ordinal(18)] 
		[RED("QuestTimerInitialDuration")] 
		public gamebbScriptID_Float QuestTimerInitialDuration
		{
			get => GetProperty(ref _questTimerInitialDuration);
			set => SetProperty(ref _questTimerInitialDuration, value);
		}

		[Ordinal(19)] 
		[RED("QuestTimerCurrentDuration")] 
		public gamebbScriptID_Float QuestTimerCurrentDuration
		{
			get => GetProperty(ref _questTimerCurrentDuration);
			set => SetProperty(ref _questTimerCurrentDuration, value);
		}

		[Ordinal(20)] 
		[RED("Tutorial_EnableHighlight")] 
		public gamebbScriptID_Bool Tutorial_EnableHighlight
		{
			get => GetProperty(ref _tutorial_EnableHighlight);
			set => SetProperty(ref _tutorial_EnableHighlight, value);
		}

		[Ordinal(21)] 
		[RED("Tutorial_EntityRefToHighlight")] 
		public gamebbScriptID_Variant Tutorial_EntityRefToHighlight
		{
			get => GetProperty(ref _tutorial_EntityRefToHighlight);
			set => SetProperty(ref _tutorial_EntityRefToHighlight, value);
		}

		[Ordinal(22)] 
		[RED("WeaponSway")] 
		public gamebbScriptID_Vector2 WeaponSway
		{
			get => GetProperty(ref _weaponSway);
			set => SetProperty(ref _weaponSway, value);
		}

		[Ordinal(23)] 
		[RED("ApplyWeaponSwayToCamera")] 
		public gamebbScriptID_Bool ApplyWeaponSwayToCamera
		{
			get => GetProperty(ref _applyWeaponSwayToCamera);
			set => SetProperty(ref _applyWeaponSwayToCamera, value);
		}

		[Ordinal(24)] 
		[RED("NormalizedWeaponSway")] 
		public gamebbScriptID_Vector2 NormalizedWeaponSway
		{
			get => GetProperty(ref _normalizedWeaponSway);
			set => SetProperty(ref _normalizedWeaponSway, value);
		}

		[Ordinal(25)] 
		[RED("DriverCombatCrosshairReticle")] 
		public gamebbScriptID_Variant DriverCombatCrosshairReticle
		{
			get => GetProperty(ref _driverCombatCrosshairReticle);
			set => SetProperty(ref _driverCombatCrosshairReticle, value);
		}

		[Ordinal(26)] 
		[RED("NotificationJournalHash")] 
		public gamebbScriptID_Int32 NotificationJournalHash
		{
			get => GetProperty(ref _notificationJournalHash);
			set => SetProperty(ref _notificationJournalHash, value);
		}

		[Ordinal(27)] 
		[RED("IsBriefingActive")] 
		public gamebbScriptID_Bool IsBriefingActive
		{
			get => GetProperty(ref _isBriefingActive);
			set => SetProperty(ref _isBriefingActive, value);
		}

		[Ordinal(28)] 
		[RED("MuppetStats")] 
		public gamebbScriptID_Variant MuppetStats
		{
			get => GetProperty(ref _muppetStats);
			set => SetProperty(ref _muppetStats, value);
		}

		[Ordinal(29)] 
		[RED("ActiveNotificationsQueue")] 
		public gamebbScriptID_Int32 ActiveNotificationsQueue
		{
			get => GetProperty(ref _activeNotificationsQueue);
			set => SetProperty(ref _activeNotificationsQueue, value);
		}

		[Ordinal(30)] 
		[RED("BerserkActive")] 
		public gamebbScriptID_Bool BerserkActive
		{
			get => GetProperty(ref _berserkActive);
			set => SetProperty(ref _berserkActive, value);
		}

		[Ordinal(31)] 
		[RED("Popup_VehiclesManager_IsShown")] 
		public gamebbScriptID_Bool Popup_VehiclesManager_IsShown
		{
			get => GetProperty(ref _popup_VehiclesManager_IsShown);
			set => SetProperty(ref _popup_VehiclesManager_IsShown, value);
		}

		[Ordinal(32)] 
		[RED("Popup_Radio_IsShown")] 
		public gamebbScriptID_Bool Popup_Radio_IsShown
		{
			get => GetProperty(ref _popup_Radio_IsShown);
			set => SetProperty(ref _popup_Radio_IsShown, value);
		}

		[Ordinal(33)] 
		[RED("Popup_Radio_Enabled")] 
		public gamebbScriptID_Bool Popup_Radio_Enabled
		{
			get => GetProperty(ref _popup_Radio_Enabled);
			set => SetProperty(ref _popup_Radio_Enabled, value);
		}

		[Ordinal(34)] 
		[RED("Popup_CarColorPicker_IsShown")] 
		public gamebbScriptID_Bool Popup_CarColorPicker_IsShown
		{
			get => GetProperty(ref _popup_CarColorPicker_IsShown);
			set => SetProperty(ref _popup_CarColorPicker_IsShown, value);
		}

		[Ordinal(35)] 
		[RED("Popup_TwintoneOverride_IsShown")] 
		public gamebbScriptID_Bool Popup_TwintoneOverride_IsShown
		{
			get => GetProperty(ref _popup_TwintoneOverride_IsShown);
			set => SetProperty(ref _popup_TwintoneOverride_IsShown, value);
		}

		[Ordinal(36)] 
		[RED("Popup_FrameSwitcher_IsShown")] 
		public gamebbScriptID_Bool Popup_FrameSwitcher_IsShown
		{
			get => GetProperty(ref _popup_FrameSwitcher_IsShown);
			set => SetProperty(ref _popup_FrameSwitcher_IsShown, value);
		}

		public UIGameDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
