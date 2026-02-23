using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scannerDetailsGameController : gameuiHUDGameController
	{
		private inkCompoundWidgetReference _scannerCountainer;
		private inkCompoundWidgetReference _cluesContainer;
		private inkCompoundWidgetReference _quickhackContainer;
		private inkCompoundWidgetReference _twintoneContainer;
		private inkWidgetReference _toggleDescirptionHackPart;
		private inkWidgetReference _toggleDescriptionTwintonePart;
		private inkWidgetReference _kiroshiLogo;
		private inkWidgetReference _bottomFluff;
		private inkWidgetReference _twintoneNoModelAvailable;
		private inkWidgetReference _twintoneSaveButtonHints;
		private inkWidgetReference _twintoneApplyButtonHints;
		private inkWidgetReference _changeTabButtonHints;
		private inkWidgetReference _changeTabInlineHint;
		private inkWidgetReference _spaceTab01;
		private inkWidgetReference _spaceTab02;
		private inkWidgetReference _twotabs01BottomLine;
		private inkWidgetReference _twotabs02BottomLine;
		private inkWidgetReference _threetabs01BottomLine;
		private inkWidgetReference _threetabs02BottomLine;
		private inkWidgetReference _threetabs03BottomLine;
		private CEnum<ScannerDetailTab> _lastOpenTab;
		private wCHandle<gameObject> _player;
		private wCHandle<gameObject> _scannedObject;
		private CEnum<gameScanningState> _scanningState;
		private CEnum<ScannerObjectType> _scannedObjectType;
		private CEnum<ScannerDetailTab> _currentTab;
		private CBool _isQuickHackAble;
		private CBool _isQuickHackPanelOpenedOrBlocked;
		private CBool _isQuickHackPanelOpened;
		private CBool _isQuickHackPanelBlocked;
		private CBool _twintoneAvailable;
		private CBool _twintoneApplyAvailable;
		private CBool _twintoneNoModelApplicable;
		private CArray<wCHandle<inkAsyncSpawnRequest>> _asyncSpawnRequests;
		private CHandle<redCallbackObject> _uiScannedObjectTypeChangedCallbackID;
		private CHandle<redCallbackObject> _uiScanningStateChangedCallbackID;
		private CHandle<redCallbackObject> _uiScannedObjectChangedCallbackID;
		private CHandle<redCallbackObject> _twintoneAvailableCallbackID;
		private CHandle<redCallbackObject> _twintoneApplyAvailableCallbackID;
		private CHandle<redCallbackObject> _twintoneNoModelAvailableCallbackID;
		private CHandle<redCallbackObject> _uiQHPanelOpenedCallbackID;
		private CHandle<redCallbackObject> _uiQHPanelBlockedCallbackID;
		private CHandle<redCallbackObject> _uiSystemIsInMenuCallbackID;
		private CUInt32 _twintoneFactListenerId;
		private CUInt32 _possessedByJohnnyFactListenerId;
		private CHandle<inkanimProxy> _introAnimProxy;
		private CHandle<inkanimProxy> _outroAnimProxy;
		private CHandle<inkanimProxy> _scannerToggleTabOpenAnimProxy;
		private CHandle<inkanimProxy> _scannerToggleTabCloseAnimProxy;

		[Ordinal(9)] 
		[RED("scannerCountainer")] 
		public inkCompoundWidgetReference ScannerCountainer
		{
			get => GetProperty(ref _scannerCountainer);
			set => SetProperty(ref _scannerCountainer, value);
		}

		[Ordinal(10)] 
		[RED("cluesContainer")] 
		public inkCompoundWidgetReference CluesContainer
		{
			get => GetProperty(ref _cluesContainer);
			set => SetProperty(ref _cluesContainer, value);
		}

		[Ordinal(11)] 
		[RED("quickhackContainer")] 
		public inkCompoundWidgetReference QuickhackContainer
		{
			get => GetProperty(ref _quickhackContainer);
			set => SetProperty(ref _quickhackContainer, value);
		}

		[Ordinal(12)] 
		[RED("twintoneContainer")] 
		public inkCompoundWidgetReference TwintoneContainer
		{
			get => GetProperty(ref _twintoneContainer);
			set => SetProperty(ref _twintoneContainer, value);
		}

		[Ordinal(13)] 
		[RED("toggleDescirptionHackPart")] 
		public inkWidgetReference ToggleDescirptionHackPart
		{
			get => GetProperty(ref _toggleDescirptionHackPart);
			set => SetProperty(ref _toggleDescirptionHackPart, value);
		}

		[Ordinal(14)] 
		[RED("toggleDescriptionTwintonePart")] 
		public inkWidgetReference ToggleDescriptionTwintonePart
		{
			get => GetProperty(ref _toggleDescriptionTwintonePart);
			set => SetProperty(ref _toggleDescriptionTwintonePart, value);
		}

		[Ordinal(15)] 
		[RED("kiroshiLogo")] 
		public inkWidgetReference KiroshiLogo
		{
			get => GetProperty(ref _kiroshiLogo);
			set => SetProperty(ref _kiroshiLogo, value);
		}

		[Ordinal(16)] 
		[RED("bottomFluff")] 
		public inkWidgetReference BottomFluff
		{
			get => GetProperty(ref _bottomFluff);
			set => SetProperty(ref _bottomFluff, value);
		}

		[Ordinal(17)] 
		[RED("twintoneNoModelAvailable")] 
		public inkWidgetReference TwintoneNoModelAvailable
		{
			get => GetProperty(ref _twintoneNoModelAvailable);
			set => SetProperty(ref _twintoneNoModelAvailable, value);
		}

		[Ordinal(18)] 
		[RED("twintoneSaveButtonHints")] 
		public inkWidgetReference TwintoneSaveButtonHints
		{
			get => GetProperty(ref _twintoneSaveButtonHints);
			set => SetProperty(ref _twintoneSaveButtonHints, value);
		}

		[Ordinal(19)] 
		[RED("twintoneApplyButtonHints")] 
		public inkWidgetReference TwintoneApplyButtonHints
		{
			get => GetProperty(ref _twintoneApplyButtonHints);
			set => SetProperty(ref _twintoneApplyButtonHints, value);
		}

		[Ordinal(20)] 
		[RED("changeTabButtonHints")] 
		public inkWidgetReference ChangeTabButtonHints
		{
			get => GetProperty(ref _changeTabButtonHints);
			set => SetProperty(ref _changeTabButtonHints, value);
		}

		[Ordinal(21)] 
		[RED("changeTabInlineHint")] 
		public inkWidgetReference ChangeTabInlineHint
		{
			get => GetProperty(ref _changeTabInlineHint);
			set => SetProperty(ref _changeTabInlineHint, value);
		}

		[Ordinal(22)] 
		[RED("spaceTab01")] 
		public inkWidgetReference SpaceTab01
		{
			get => GetProperty(ref _spaceTab01);
			set => SetProperty(ref _spaceTab01, value);
		}

		[Ordinal(23)] 
		[RED("spaceTab02")] 
		public inkWidgetReference SpaceTab02
		{
			get => GetProperty(ref _spaceTab02);
			set => SetProperty(ref _spaceTab02, value);
		}

		[Ordinal(24)] 
		[RED("twotabs01BottomLine")] 
		public inkWidgetReference Twotabs01BottomLine
		{
			get => GetProperty(ref _twotabs01BottomLine);
			set => SetProperty(ref _twotabs01BottomLine, value);
		}

		[Ordinal(25)] 
		[RED("twotabs02BottomLine")] 
		public inkWidgetReference Twotabs02BottomLine
		{
			get => GetProperty(ref _twotabs02BottomLine);
			set => SetProperty(ref _twotabs02BottomLine, value);
		}

		[Ordinal(26)] 
		[RED("threetabs01BottomLine")] 
		public inkWidgetReference Threetabs01BottomLine
		{
			get => GetProperty(ref _threetabs01BottomLine);
			set => SetProperty(ref _threetabs01BottomLine, value);
		}

		[Ordinal(27)] 
		[RED("threetabs02BottomLine")] 
		public inkWidgetReference Threetabs02BottomLine
		{
			get => GetProperty(ref _threetabs02BottomLine);
			set => SetProperty(ref _threetabs02BottomLine, value);
		}

		[Ordinal(28)] 
		[RED("threetabs03BottomLine")] 
		public inkWidgetReference Threetabs03BottomLine
		{
			get => GetProperty(ref _threetabs03BottomLine);
			set => SetProperty(ref _threetabs03BottomLine, value);
		}

		[Ordinal(29)] 
		[RED("lastOpenTab")] 
		public CEnum<ScannerDetailTab> LastOpenTab
		{
			get => GetProperty(ref _lastOpenTab);
			set => SetProperty(ref _lastOpenTab, value);
		}

		[Ordinal(30)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(31)] 
		[RED("scannedObject")] 
		public wCHandle<gameObject> ScannedObject
		{
			get => GetProperty(ref _scannedObject);
			set => SetProperty(ref _scannedObject, value);
		}

		[Ordinal(32)] 
		[RED("scanningState")] 
		public CEnum<gameScanningState> ScanningState
		{
			get => GetProperty(ref _scanningState);
			set => SetProperty(ref _scanningState, value);
		}

		[Ordinal(33)] 
		[RED("scannedObjectType")] 
		public CEnum<ScannerObjectType> ScannedObjectType
		{
			get => GetProperty(ref _scannedObjectType);
			set => SetProperty(ref _scannedObjectType, value);
		}

		[Ordinal(34)] 
		[RED("currentTab")] 
		public CEnum<ScannerDetailTab> CurrentTab
		{
			get => GetProperty(ref _currentTab);
			set => SetProperty(ref _currentTab, value);
		}

		[Ordinal(35)] 
		[RED("isQuickHackAble")] 
		public CBool IsQuickHackAble
		{
			get => GetProperty(ref _isQuickHackAble);
			set => SetProperty(ref _isQuickHackAble, value);
		}

		[Ordinal(36)] 
		[RED("isQuickHackPanelOpenedOrBlocked")] 
		public CBool IsQuickHackPanelOpenedOrBlocked
		{
			get => GetProperty(ref _isQuickHackPanelOpenedOrBlocked);
			set => SetProperty(ref _isQuickHackPanelOpenedOrBlocked, value);
		}

		[Ordinal(37)] 
		[RED("isQuickHackPanelOpened")] 
		public CBool IsQuickHackPanelOpened
		{
			get => GetProperty(ref _isQuickHackPanelOpened);
			set => SetProperty(ref _isQuickHackPanelOpened, value);
		}

		[Ordinal(38)] 
		[RED("isQuickHackPanelBlocked")] 
		public CBool IsQuickHackPanelBlocked
		{
			get => GetProperty(ref _isQuickHackPanelBlocked);
			set => SetProperty(ref _isQuickHackPanelBlocked, value);
		}

		[Ordinal(39)] 
		[RED("twintoneAvailable")] 
		public CBool TwintoneAvailable
		{
			get => GetProperty(ref _twintoneAvailable);
			set => SetProperty(ref _twintoneAvailable, value);
		}

		[Ordinal(40)] 
		[RED("twintoneApplyAvailable")] 
		public CBool TwintoneApplyAvailable
		{
			get => GetProperty(ref _twintoneApplyAvailable);
			set => SetProperty(ref _twintoneApplyAvailable, value);
		}

		[Ordinal(41)] 
		[RED("twintoneNoModelApplicable")] 
		public CBool TwintoneNoModelApplicable
		{
			get => GetProperty(ref _twintoneNoModelApplicable);
			set => SetProperty(ref _twintoneNoModelApplicable, value);
		}

		[Ordinal(42)] 
		[RED("asyncSpawnRequests")] 
		public CArray<wCHandle<inkAsyncSpawnRequest>> AsyncSpawnRequests
		{
			get => GetProperty(ref _asyncSpawnRequests);
			set => SetProperty(ref _asyncSpawnRequests, value);
		}

		[Ordinal(43)] 
		[RED("uiScannedObjectTypeChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScannedObjectTypeChangedCallbackID
		{
			get => GetProperty(ref _uiScannedObjectTypeChangedCallbackID);
			set => SetProperty(ref _uiScannedObjectTypeChangedCallbackID, value);
		}

		[Ordinal(44)] 
		[RED("uiScanningStateChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScanningStateChangedCallbackID
		{
			get => GetProperty(ref _uiScanningStateChangedCallbackID);
			set => SetProperty(ref _uiScanningStateChangedCallbackID, value);
		}

		[Ordinal(45)] 
		[RED("uiScannedObjectChangedCallbackID")] 
		public CHandle<redCallbackObject> UiScannedObjectChangedCallbackID
		{
			get => GetProperty(ref _uiScannedObjectChangedCallbackID);
			set => SetProperty(ref _uiScannedObjectChangedCallbackID, value);
		}

		[Ordinal(46)] 
		[RED("twintoneAvailableCallbackID")] 
		public CHandle<redCallbackObject> TwintoneAvailableCallbackID
		{
			get => GetProperty(ref _twintoneAvailableCallbackID);
			set => SetProperty(ref _twintoneAvailableCallbackID, value);
		}

		[Ordinal(47)] 
		[RED("twintoneApplyAvailableCallbackID")] 
		public CHandle<redCallbackObject> TwintoneApplyAvailableCallbackID
		{
			get => GetProperty(ref _twintoneApplyAvailableCallbackID);
			set => SetProperty(ref _twintoneApplyAvailableCallbackID, value);
		}

		[Ordinal(48)] 
		[RED("twintoneNoModelAvailableCallbackID")] 
		public CHandle<redCallbackObject> TwintoneNoModelAvailableCallbackID
		{
			get => GetProperty(ref _twintoneNoModelAvailableCallbackID);
			set => SetProperty(ref _twintoneNoModelAvailableCallbackID, value);
		}

		[Ordinal(49)] 
		[RED("uiQHPanelOpenedCallbackID")] 
		public CHandle<redCallbackObject> UiQHPanelOpenedCallbackID
		{
			get => GetProperty(ref _uiQHPanelOpenedCallbackID);
			set => SetProperty(ref _uiQHPanelOpenedCallbackID, value);
		}

		[Ordinal(50)] 
		[RED("uiQHPanelBlockedCallbackID")] 
		public CHandle<redCallbackObject> UiQHPanelBlockedCallbackID
		{
			get => GetProperty(ref _uiQHPanelBlockedCallbackID);
			set => SetProperty(ref _uiQHPanelBlockedCallbackID, value);
		}

		[Ordinal(51)] 
		[RED("uiSystemIsInMenuCallbackID")] 
		public CHandle<redCallbackObject> UiSystemIsInMenuCallbackID
		{
			get => GetProperty(ref _uiSystemIsInMenuCallbackID);
			set => SetProperty(ref _uiSystemIsInMenuCallbackID, value);
		}

		[Ordinal(52)] 
		[RED("twintoneFactListenerId")] 
		public CUInt32 TwintoneFactListenerId
		{
			get => GetProperty(ref _twintoneFactListenerId);
			set => SetProperty(ref _twintoneFactListenerId, value);
		}

		[Ordinal(53)] 
		[RED("possessedByJohnnyFactListenerId")] 
		public CUInt32 PossessedByJohnnyFactListenerId
		{
			get => GetProperty(ref _possessedByJohnnyFactListenerId);
			set => SetProperty(ref _possessedByJohnnyFactListenerId, value);
		}

		[Ordinal(54)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(55)] 
		[RED("outroAnimProxy")] 
		public CHandle<inkanimProxy> OutroAnimProxy
		{
			get => GetProperty(ref _outroAnimProxy);
			set => SetProperty(ref _outroAnimProxy, value);
		}

		[Ordinal(56)] 
		[RED("scannerToggleTabOpenAnimProxy")] 
		public CHandle<inkanimProxy> ScannerToggleTabOpenAnimProxy
		{
			get => GetProperty(ref _scannerToggleTabOpenAnimProxy);
			set => SetProperty(ref _scannerToggleTabOpenAnimProxy, value);
		}

		[Ordinal(57)] 
		[RED("scannerToggleTabCloseAnimProxy")] 
		public CHandle<inkanimProxy> ScannerToggleTabCloseAnimProxy
		{
			get => GetProperty(ref _scannerToggleTabCloseAnimProxy);
			set => SetProperty(ref _scannerToggleTabCloseAnimProxy, value);
		}

		public scannerDetailsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
