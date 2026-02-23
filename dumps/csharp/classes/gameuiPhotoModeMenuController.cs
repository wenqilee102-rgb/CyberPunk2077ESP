using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiPhotoModeMenuController : gameuiMenuGameController
	{
		private gameuiSetPhotoModeKeyEnabledCallback _setAttributeOptionEnabled;
		private gameuiSetPhotoModeKeyEnabledCallback _setCategoryEnabled;
		private gameuiStickerImageCallback _setStickerImage;
		private gameuiNpcImageCallback _setNpcImage;
		private gameuiChangeAspectRatioCallback _changeAspectRatio;
		private inkWidgetReference _menuListRoot;
		private inkWidgetReference _additionalListRoot;
		private inkCompoundWidgetReference _radioButtons;
		private CName _listContainerId;
		private CName _addtionalContainerID;
		private inkWidgetReference _menuArea;
		private inkWidgetReference _additionalMenuArea;
		private inkWidgetReference _inputCameraGlobalControlKbd;
		private inkWidgetReference _inputCameraMovementControlKbd;
		private inkWidgetReference _inputCameraZoomControlKbd;
		private inkWidgetReference _inputCameraKbd;
		private inkWidgetReference _inputCameraGlobalControlPad;
		private inkWidgetReference _inputCameraMovementControlPad;
		private inkWidgetReference _inputCameraZoomControlPad;
		private inkWidgetReference _inputCameraPad;
		private inkWidgetReference _inputLightControlKbd;
		private inkWidgetReference _inputLightKbd;
		private inkWidgetReference _inputLightControlPad;
		private inkWidgetReference _inputLightPad;
		private inkWidgetReference _inputStickersKbd;
		private inkWidgetReference _inputStickersPad;
		private inkWidgetReference _inputSaveLoadKbd;
		private inkWidgetReference _inputSaveLoadPad;
		private inkWidgetReference _inputExit;
		private inkWidgetReference _inputScreenshot;
		private inkWidgetReference _cameraLocation;
		private inkHorizontalPanelWidgetReference _inputBottomRoot;
		private inkWidgetReference _lightIndicator;
		private inkRichTextBoxWidgetReference _tabTitleText;
		private inkImageWidgetReference _tabTitleIcon;
		private inkWidgetReference _aspectRatioPanel;
		private inkWidgetReference _leftBlackBar;
		private inkWidgetReference _rightBlackBar;
		private inkWidgetReference _topBlackBar;
		private inkWidgetReference _bottomBlackBar;
		private CName _ps4InputLibraryId;
		private CName _xboxInputLibraryId;
		private CName _stadiaInputLibraryId;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private wCHandle<inkWidget> _ps4InputWidget;
		private wCHandle<inkWidget> _xboxInputWidget;
		private wCHandle<inkWidget> _stadiaInputWidget;
		private CArray<wCHandle<inkWidget>> _menuPages;
		private wCHandle<PhotoModeTopBarController> _topButtonsController;
		private wCHandle<PhotoModeCameraLocation> _cameraLocationController;
		private CUInt32 _currentPage;
		private CBool _isHoverOver;
		private CBool _holdSafeguard;
		private CHandle<inkGameNotificationData> _notificationUserData;
		private CHandle<inkGameNotificationToken> _notificationToken;
		private CHandle<inkanimProxy> _loopAnimproxy;
		private CHandle<inkanimProxy> _uiVisiblityFadeAnim;
		private CInt32 _currentNpc;
		private CHandle<inkGameNotificationToken> _exitConfirmationToken;
		private inkWidgetReference _horizontalLineUp;
		private inkWidgetReference _horizontalLineDown;
		private inkWidgetReference _verticalLineLeft;
		private inkWidgetReference _verticalLineRight;
		private wCHandle<PlayerPuppet> _fakePlayer;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private CBool _anyOptionChanged;

		[Ordinal(3)] 
		[RED("SetAttributeOptionEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetAttributeOptionEnabled
		{
			get => GetProperty(ref _setAttributeOptionEnabled);
			set => SetProperty(ref _setAttributeOptionEnabled, value);
		}

		[Ordinal(4)] 
		[RED("SetCategoryEnabled")] 
		public gameuiSetPhotoModeKeyEnabledCallback SetCategoryEnabled
		{
			get => GetProperty(ref _setCategoryEnabled);
			set => SetProperty(ref _setCategoryEnabled, value);
		}

		[Ordinal(5)] 
		[RED("SetStickerImage")] 
		public gameuiStickerImageCallback SetStickerImage
		{
			get => GetProperty(ref _setStickerImage);
			set => SetProperty(ref _setStickerImage, value);
		}

		[Ordinal(6)] 
		[RED("SetNpcImage")] 
		public gameuiNpcImageCallback SetNpcImage
		{
			get => GetProperty(ref _setNpcImage);
			set => SetProperty(ref _setNpcImage, value);
		}

		[Ordinal(7)] 
		[RED("ChangeAspectRatio")] 
		public gameuiChangeAspectRatioCallback ChangeAspectRatio
		{
			get => GetProperty(ref _changeAspectRatio);
			set => SetProperty(ref _changeAspectRatio, value);
		}

		[Ordinal(8)] 
		[RED("menuListRoot")] 
		public inkWidgetReference MenuListRoot
		{
			get => GetProperty(ref _menuListRoot);
			set => SetProperty(ref _menuListRoot, value);
		}

		[Ordinal(9)] 
		[RED("additionalListRoot")] 
		public inkWidgetReference AdditionalListRoot
		{
			get => GetProperty(ref _additionalListRoot);
			set => SetProperty(ref _additionalListRoot, value);
		}

		[Ordinal(10)] 
		[RED("radioButtons")] 
		public inkCompoundWidgetReference RadioButtons
		{
			get => GetProperty(ref _radioButtons);
			set => SetProperty(ref _radioButtons, value);
		}

		[Ordinal(11)] 
		[RED("listContainerId")] 
		public CName ListContainerId
		{
			get => GetProperty(ref _listContainerId);
			set => SetProperty(ref _listContainerId, value);
		}

		[Ordinal(12)] 
		[RED("addtionalContainerID")] 
		public CName AddtionalContainerID
		{
			get => GetProperty(ref _addtionalContainerID);
			set => SetProperty(ref _addtionalContainerID, value);
		}

		[Ordinal(13)] 
		[RED("menuArea")] 
		public inkWidgetReference MenuArea
		{
			get => GetProperty(ref _menuArea);
			set => SetProperty(ref _menuArea, value);
		}

		[Ordinal(14)] 
		[RED("additionalMenuArea")] 
		public inkWidgetReference AdditionalMenuArea
		{
			get => GetProperty(ref _additionalMenuArea);
			set => SetProperty(ref _additionalMenuArea, value);
		}

		[Ordinal(15)] 
		[RED("inputCameraGlobalControlKbd")] 
		public inkWidgetReference InputCameraGlobalControlKbd
		{
			get => GetProperty(ref _inputCameraGlobalControlKbd);
			set => SetProperty(ref _inputCameraGlobalControlKbd, value);
		}

		[Ordinal(16)] 
		[RED("inputCameraMovementControlKbd")] 
		public inkWidgetReference InputCameraMovementControlKbd
		{
			get => GetProperty(ref _inputCameraMovementControlKbd);
			set => SetProperty(ref _inputCameraMovementControlKbd, value);
		}

		[Ordinal(17)] 
		[RED("inputCameraZoomControlKbd")] 
		public inkWidgetReference InputCameraZoomControlKbd
		{
			get => GetProperty(ref _inputCameraZoomControlKbd);
			set => SetProperty(ref _inputCameraZoomControlKbd, value);
		}

		[Ordinal(18)] 
		[RED("inputCameraKbd")] 
		public inkWidgetReference InputCameraKbd
		{
			get => GetProperty(ref _inputCameraKbd);
			set => SetProperty(ref _inputCameraKbd, value);
		}

		[Ordinal(19)] 
		[RED("inputCameraGlobalControlPad")] 
		public inkWidgetReference InputCameraGlobalControlPad
		{
			get => GetProperty(ref _inputCameraGlobalControlPad);
			set => SetProperty(ref _inputCameraGlobalControlPad, value);
		}

		[Ordinal(20)] 
		[RED("inputCameraMovementControlPad")] 
		public inkWidgetReference InputCameraMovementControlPad
		{
			get => GetProperty(ref _inputCameraMovementControlPad);
			set => SetProperty(ref _inputCameraMovementControlPad, value);
		}

		[Ordinal(21)] 
		[RED("inputCameraZoomControlPad")] 
		public inkWidgetReference InputCameraZoomControlPad
		{
			get => GetProperty(ref _inputCameraZoomControlPad);
			set => SetProperty(ref _inputCameraZoomControlPad, value);
		}

		[Ordinal(22)] 
		[RED("inputCameraPad")] 
		public inkWidgetReference InputCameraPad
		{
			get => GetProperty(ref _inputCameraPad);
			set => SetProperty(ref _inputCameraPad, value);
		}

		[Ordinal(23)] 
		[RED("inputLightControlKbd")] 
		public inkWidgetReference InputLightControlKbd
		{
			get => GetProperty(ref _inputLightControlKbd);
			set => SetProperty(ref _inputLightControlKbd, value);
		}

		[Ordinal(24)] 
		[RED("inputLightKbd")] 
		public inkWidgetReference InputLightKbd
		{
			get => GetProperty(ref _inputLightKbd);
			set => SetProperty(ref _inputLightKbd, value);
		}

		[Ordinal(25)] 
		[RED("inputLightControlPad")] 
		public inkWidgetReference InputLightControlPad
		{
			get => GetProperty(ref _inputLightControlPad);
			set => SetProperty(ref _inputLightControlPad, value);
		}

		[Ordinal(26)] 
		[RED("inputLightPad")] 
		public inkWidgetReference InputLightPad
		{
			get => GetProperty(ref _inputLightPad);
			set => SetProperty(ref _inputLightPad, value);
		}

		[Ordinal(27)] 
		[RED("inputStickersKbd")] 
		public inkWidgetReference InputStickersKbd
		{
			get => GetProperty(ref _inputStickersKbd);
			set => SetProperty(ref _inputStickersKbd, value);
		}

		[Ordinal(28)] 
		[RED("inputStickersPad")] 
		public inkWidgetReference InputStickersPad
		{
			get => GetProperty(ref _inputStickersPad);
			set => SetProperty(ref _inputStickersPad, value);
		}

		[Ordinal(29)] 
		[RED("inputSaveLoadKbd")] 
		public inkWidgetReference InputSaveLoadKbd
		{
			get => GetProperty(ref _inputSaveLoadKbd);
			set => SetProperty(ref _inputSaveLoadKbd, value);
		}

		[Ordinal(30)] 
		[RED("inputSaveLoadPad")] 
		public inkWidgetReference InputSaveLoadPad
		{
			get => GetProperty(ref _inputSaveLoadPad);
			set => SetProperty(ref _inputSaveLoadPad, value);
		}

		[Ordinal(31)] 
		[RED("inputExit")] 
		public inkWidgetReference InputExit
		{
			get => GetProperty(ref _inputExit);
			set => SetProperty(ref _inputExit, value);
		}

		[Ordinal(32)] 
		[RED("inputScreenshot")] 
		public inkWidgetReference InputScreenshot
		{
			get => GetProperty(ref _inputScreenshot);
			set => SetProperty(ref _inputScreenshot, value);
		}

		[Ordinal(33)] 
		[RED("cameraLocation")] 
		public inkWidgetReference CameraLocation
		{
			get => GetProperty(ref _cameraLocation);
			set => SetProperty(ref _cameraLocation, value);
		}

		[Ordinal(34)] 
		[RED("inputBottomRoot")] 
		public inkHorizontalPanelWidgetReference InputBottomRoot
		{
			get => GetProperty(ref _inputBottomRoot);
			set => SetProperty(ref _inputBottomRoot, value);
		}

		[Ordinal(35)] 
		[RED("lightIndicator")] 
		public inkWidgetReference LightIndicator
		{
			get => GetProperty(ref _lightIndicator);
			set => SetProperty(ref _lightIndicator, value);
		}

		[Ordinal(36)] 
		[RED("tabTitleText")] 
		public inkRichTextBoxWidgetReference TabTitleText
		{
			get => GetProperty(ref _tabTitleText);
			set => SetProperty(ref _tabTitleText, value);
		}

		[Ordinal(37)] 
		[RED("tabTitleIcon")] 
		public inkImageWidgetReference TabTitleIcon
		{
			get => GetProperty(ref _tabTitleIcon);
			set => SetProperty(ref _tabTitleIcon, value);
		}

		[Ordinal(38)] 
		[RED("aspectRatioPanel")] 
		public inkWidgetReference AspectRatioPanel
		{
			get => GetProperty(ref _aspectRatioPanel);
			set => SetProperty(ref _aspectRatioPanel, value);
		}

		[Ordinal(39)] 
		[RED("LeftBlackBar")] 
		public inkWidgetReference LeftBlackBar
		{
			get => GetProperty(ref _leftBlackBar);
			set => SetProperty(ref _leftBlackBar, value);
		}

		[Ordinal(40)] 
		[RED("RightBlackBar")] 
		public inkWidgetReference RightBlackBar
		{
			get => GetProperty(ref _rightBlackBar);
			set => SetProperty(ref _rightBlackBar, value);
		}

		[Ordinal(41)] 
		[RED("TopBlackBar")] 
		public inkWidgetReference TopBlackBar
		{
			get => GetProperty(ref _topBlackBar);
			set => SetProperty(ref _topBlackBar, value);
		}

		[Ordinal(42)] 
		[RED("BottomBlackBar")] 
		public inkWidgetReference BottomBlackBar
		{
			get => GetProperty(ref _bottomBlackBar);
			set => SetProperty(ref _bottomBlackBar, value);
		}

		[Ordinal(43)] 
		[RED("ps4InputLibraryId")] 
		public CName Ps4InputLibraryId
		{
			get => GetProperty(ref _ps4InputLibraryId);
			set => SetProperty(ref _ps4InputLibraryId, value);
		}

		[Ordinal(44)] 
		[RED("xboxInputLibraryId")] 
		public CName XboxInputLibraryId
		{
			get => GetProperty(ref _xboxInputLibraryId);
			set => SetProperty(ref _xboxInputLibraryId, value);
		}

		[Ordinal(45)] 
		[RED("stadiaInputLibraryId")] 
		public CName StadiaInputLibraryId
		{
			get => GetProperty(ref _stadiaInputLibraryId);
			set => SetProperty(ref _stadiaInputLibraryId, value);
		}

		[Ordinal(46)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(47)] 
		[RED("ps4InputWidget")] 
		public wCHandle<inkWidget> Ps4InputWidget
		{
			get => GetProperty(ref _ps4InputWidget);
			set => SetProperty(ref _ps4InputWidget, value);
		}

		[Ordinal(48)] 
		[RED("xboxInputWidget")] 
		public wCHandle<inkWidget> XboxInputWidget
		{
			get => GetProperty(ref _xboxInputWidget);
			set => SetProperty(ref _xboxInputWidget, value);
		}

		[Ordinal(49)] 
		[RED("stadiaInputWidget")] 
		public wCHandle<inkWidget> StadiaInputWidget
		{
			get => GetProperty(ref _stadiaInputWidget);
			set => SetProperty(ref _stadiaInputWidget, value);
		}

		[Ordinal(50)] 
		[RED("menuPages")] 
		public CArray<wCHandle<inkWidget>> MenuPages
		{
			get => GetProperty(ref _menuPages);
			set => SetProperty(ref _menuPages, value);
		}

		[Ordinal(51)] 
		[RED("topButtonsController")] 
		public wCHandle<PhotoModeTopBarController> TopButtonsController
		{
			get => GetProperty(ref _topButtonsController);
			set => SetProperty(ref _topButtonsController, value);
		}

		[Ordinal(52)] 
		[RED("cameraLocationController")] 
		public wCHandle<PhotoModeCameraLocation> CameraLocationController
		{
			get => GetProperty(ref _cameraLocationController);
			set => SetProperty(ref _cameraLocationController, value);
		}

		[Ordinal(53)] 
		[RED("currentPage")] 
		public CUInt32 CurrentPage
		{
			get => GetProperty(ref _currentPage);
			set => SetProperty(ref _currentPage, value);
		}

		[Ordinal(54)] 
		[RED("IsHoverOver")] 
		public CBool IsHoverOver
		{
			get => GetProperty(ref _isHoverOver);
			set => SetProperty(ref _isHoverOver, value);
		}

		[Ordinal(55)] 
		[RED("holdSafeguard")] 
		public CBool HoldSafeguard
		{
			get => GetProperty(ref _holdSafeguard);
			set => SetProperty(ref _holdSafeguard, value);
		}

		[Ordinal(56)] 
		[RED("notificationUserData")] 
		public CHandle<inkGameNotificationData> NotificationUserData
		{
			get => GetProperty(ref _notificationUserData);
			set => SetProperty(ref _notificationUserData, value);
		}

		[Ordinal(57)] 
		[RED("notificationToken")] 
		public CHandle<inkGameNotificationToken> NotificationToken
		{
			get => GetProperty(ref _notificationToken);
			set => SetProperty(ref _notificationToken, value);
		}

		[Ordinal(58)] 
		[RED("loopAnimproxy")] 
		public CHandle<inkanimProxy> LoopAnimproxy
		{
			get => GetProperty(ref _loopAnimproxy);
			set => SetProperty(ref _loopAnimproxy, value);
		}

		[Ordinal(59)] 
		[RED("uiVisiblityFadeAnim")] 
		public CHandle<inkanimProxy> UiVisiblityFadeAnim
		{
			get => GetProperty(ref _uiVisiblityFadeAnim);
			set => SetProperty(ref _uiVisiblityFadeAnim, value);
		}

		[Ordinal(60)] 
		[RED("currentNpc")] 
		public CInt32 CurrentNpc
		{
			get => GetProperty(ref _currentNpc);
			set => SetProperty(ref _currentNpc, value);
		}

		[Ordinal(61)] 
		[RED("exitConfirmationToken")] 
		public CHandle<inkGameNotificationToken> ExitConfirmationToken
		{
			get => GetProperty(ref _exitConfirmationToken);
			set => SetProperty(ref _exitConfirmationToken, value);
		}

		[Ordinal(62)] 
		[RED("horizontalLineUp")] 
		public inkWidgetReference HorizontalLineUp
		{
			get => GetProperty(ref _horizontalLineUp);
			set => SetProperty(ref _horizontalLineUp, value);
		}

		[Ordinal(63)] 
		[RED("horizontalLineDown")] 
		public inkWidgetReference HorizontalLineDown
		{
			get => GetProperty(ref _horizontalLineDown);
			set => SetProperty(ref _horizontalLineDown, value);
		}

		[Ordinal(64)] 
		[RED("verticalLineLeft")] 
		public inkWidgetReference VerticalLineLeft
		{
			get => GetProperty(ref _verticalLineLeft);
			set => SetProperty(ref _verticalLineLeft, value);
		}

		[Ordinal(65)] 
		[RED("verticalLineRight")] 
		public inkWidgetReference VerticalLineRight
		{
			get => GetProperty(ref _verticalLineRight);
			set => SetProperty(ref _verticalLineRight, value);
		}

		[Ordinal(66)] 
		[RED("fakePlayer")] 
		public wCHandle<PlayerPuppet> FakePlayer
		{
			get => GetProperty(ref _fakePlayer);
			set => SetProperty(ref _fakePlayer, value);
		}

		[Ordinal(67)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(68)] 
		[RED("anyOptionChanged")] 
		public CBool AnyOptionChanged
		{
			get => GetProperty(ref _anyOptionChanged);
			set => SetProperty(ref _anyOptionChanged, value);
		}

		public gameuiPhotoModeMenuController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
