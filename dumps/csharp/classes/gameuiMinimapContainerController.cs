using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapContainerController : gameuiMappinsContainerController
	{
		private CHandle<gameMinimapSettings> _settings;
		private inkCompoundWidgetReference _clampedMappinContainer;
		private inkCompoundWidgetReference _unclampedMappinContainer;
		private inkMaskWidgetReference _maskWidget;
		private inkWidgetReference _playerIconWidget;
		private inkWidgetReference _compassWidget;
		private inkCanvasWidgetReference _worldGeometryContainer;
		private inkCacheWidgetReference _worldGeometryCache;
		private CName _geometryLibraryID;
		private inkCompoundWidgetReference _timeDisplayWidget;
		private wCHandle<inkWidget> _rootZoneSafety;
		private inkTextWidgetReference _locationTextWidget;
		private inkTextWidgetReference _fluffText1;
		private inkWidgetReference _securityAreaVignetteWidget;
		private inkTextWidgetReference _securityAreaText;
		private inkWidgetReference _combatModeHighlight;
		private inkWidgetReference _courierTimerContainer;
		private inkTextWidgetReference _courierTimerText;
		private inkWidgetReference _alternativeIconContainer;
		private inkWidgetReference _autoDriveModeHighlight;
		private inkWidgetLibraryReference _autoDriveIconRef;
		private wCHandle<inkWidget> _rootWidget;
		private CHandle<inkanimProxy> _zoneVignetteAnimProxy;
		private CBool _inPublicOrRestrictedZone;
		private CInt32 _fluffTextCount;
		private CHandle<inkanimProxy> _alternativePlayerIconAnimProxy;
		private CBool _hasOverridenPlayerIcon;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private wCHandle<gameIBlackboard> _mapBlackboard;
		private CHandle<UI_MapDef> _mapDefinition;
		private CHandle<redCallbackObject> _locationDataCallback;
		private CHandle<redCallbackObject> _highlightRequestCallback;
		private wCHandle<gameIBlackboard> _countdownTimerBlackboard;
		private CHandle<UI_HUDCountdownTimerDef> _countdownTimerDefinition;
		private CHandle<redCallbackObject> _countdownTimerActiveCallback;
		private CHandle<redCallbackObject> _countdownTimerTimeCallback;
		private CHandle<redCallbackObject> _securityBlackBoardID;
		private CHandle<redCallbackObject> _remoteControlledVehicleDataCallback;
		private CHandle<redCallbackObject> _remoteControlledVehicleCameraChangedToTPPCallback;
		private CHandle<inkanimProxy> _combatAnimation;
		private CHandle<UI_AutodriveDataDef> _autodriveDataDefinition;
		private wCHandle<gameIBlackboard> _autodriveDataBlackboard;
		private CHandle<redCallbackObject> _autoDriveEnabledCallback;
		private CBool _autoDriveEnabled;
		private CHandle<inkanimProxy> _autoDriveAnimation;
		private CBool _playerInCombat;
		private CEnum<ESecurityAreaType> _currentZoneType;
		private wCHandle<inkCompoundWidget> _messageCounterController;

		[Ordinal(18)] 
		[RED("settings")] 
		public CHandle<gameMinimapSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(19)] 
		[RED("clampedMappinContainer")] 
		public inkCompoundWidgetReference ClampedMappinContainer
		{
			get => GetProperty(ref _clampedMappinContainer);
			set => SetProperty(ref _clampedMappinContainer, value);
		}

		[Ordinal(20)] 
		[RED("unclampedMappinContainer")] 
		public inkCompoundWidgetReference UnclampedMappinContainer
		{
			get => GetProperty(ref _unclampedMappinContainer);
			set => SetProperty(ref _unclampedMappinContainer, value);
		}

		[Ordinal(21)] 
		[RED("maskWidget")] 
		public inkMaskWidgetReference MaskWidget
		{
			get => GetProperty(ref _maskWidget);
			set => SetProperty(ref _maskWidget, value);
		}

		[Ordinal(22)] 
		[RED("playerIconWidget")] 
		public inkWidgetReference PlayerIconWidget
		{
			get => GetProperty(ref _playerIconWidget);
			set => SetProperty(ref _playerIconWidget, value);
		}

		[Ordinal(23)] 
		[RED("compassWidget")] 
		public inkWidgetReference CompassWidget
		{
			get => GetProperty(ref _compassWidget);
			set => SetProperty(ref _compassWidget, value);
		}

		[Ordinal(24)] 
		[RED("worldGeometryContainer")] 
		public inkCanvasWidgetReference WorldGeometryContainer
		{
			get => GetProperty(ref _worldGeometryContainer);
			set => SetProperty(ref _worldGeometryContainer, value);
		}

		[Ordinal(25)] 
		[RED("worldGeometryCache")] 
		public inkCacheWidgetReference WorldGeometryCache
		{
			get => GetProperty(ref _worldGeometryCache);
			set => SetProperty(ref _worldGeometryCache, value);
		}

		[Ordinal(26)] 
		[RED("geometryLibraryID")] 
		public CName GeometryLibraryID
		{
			get => GetProperty(ref _geometryLibraryID);
			set => SetProperty(ref _geometryLibraryID, value);
		}

		[Ordinal(27)] 
		[RED("timeDisplayWidget")] 
		public inkCompoundWidgetReference TimeDisplayWidget
		{
			get => GetProperty(ref _timeDisplayWidget);
			set => SetProperty(ref _timeDisplayWidget, value);
		}

		[Ordinal(28)] 
		[RED("rootZoneSafety")] 
		public wCHandle<inkWidget> RootZoneSafety
		{
			get => GetProperty(ref _rootZoneSafety);
			set => SetProperty(ref _rootZoneSafety, value);
		}

		[Ordinal(29)] 
		[RED("locationTextWidget")] 
		public inkTextWidgetReference LocationTextWidget
		{
			get => GetProperty(ref _locationTextWidget);
			set => SetProperty(ref _locationTextWidget, value);
		}

		[Ordinal(30)] 
		[RED("fluffText1")] 
		public inkTextWidgetReference FluffText1
		{
			get => GetProperty(ref _fluffText1);
			set => SetProperty(ref _fluffText1, value);
		}

		[Ordinal(31)] 
		[RED("securityAreaVignetteWidget")] 
		public inkWidgetReference SecurityAreaVignetteWidget
		{
			get => GetProperty(ref _securityAreaVignetteWidget);
			set => SetProperty(ref _securityAreaVignetteWidget, value);
		}

		[Ordinal(32)] 
		[RED("securityAreaText")] 
		public inkTextWidgetReference SecurityAreaText
		{
			get => GetProperty(ref _securityAreaText);
			set => SetProperty(ref _securityAreaText, value);
		}

		[Ordinal(33)] 
		[RED("combatModeHighlight")] 
		public inkWidgetReference CombatModeHighlight
		{
			get => GetProperty(ref _combatModeHighlight);
			set => SetProperty(ref _combatModeHighlight, value);
		}

		[Ordinal(34)] 
		[RED("courierTimerContainer")] 
		public inkWidgetReference CourierTimerContainer
		{
			get => GetProperty(ref _courierTimerContainer);
			set => SetProperty(ref _courierTimerContainer, value);
		}

		[Ordinal(35)] 
		[RED("courierTimerText")] 
		public inkTextWidgetReference CourierTimerText
		{
			get => GetProperty(ref _courierTimerText);
			set => SetProperty(ref _courierTimerText, value);
		}

		[Ordinal(36)] 
		[RED("alternativeIconContainer")] 
		public inkWidgetReference AlternativeIconContainer
		{
			get => GetProperty(ref _alternativeIconContainer);
			set => SetProperty(ref _alternativeIconContainer, value);
		}

		[Ordinal(37)] 
		[RED("autoDriveModeHighlight")] 
		public inkWidgetReference AutoDriveModeHighlight
		{
			get => GetProperty(ref _autoDriveModeHighlight);
			set => SetProperty(ref _autoDriveModeHighlight, value);
		}

		[Ordinal(38)] 
		[RED("autoDriveIconRef")] 
		public inkWidgetLibraryReference AutoDriveIconRef
		{
			get => GetProperty(ref _autoDriveIconRef);
			set => SetProperty(ref _autoDriveIconRef, value);
		}

		[Ordinal(39)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(40)] 
		[RED("zoneVignetteAnimProxy")] 
		public CHandle<inkanimProxy> ZoneVignetteAnimProxy
		{
			get => GetProperty(ref _zoneVignetteAnimProxy);
			set => SetProperty(ref _zoneVignetteAnimProxy, value);
		}

		[Ordinal(41)] 
		[RED("inPublicOrRestrictedZone")] 
		public CBool InPublicOrRestrictedZone
		{
			get => GetProperty(ref _inPublicOrRestrictedZone);
			set => SetProperty(ref _inPublicOrRestrictedZone, value);
		}

		[Ordinal(42)] 
		[RED("fluffTextCount")] 
		public CInt32 FluffTextCount
		{
			get => GetProperty(ref _fluffTextCount);
			set => SetProperty(ref _fluffTextCount, value);
		}

		[Ordinal(43)] 
		[RED("alternativePlayerIconAnimProxy")] 
		public CHandle<inkanimProxy> AlternativePlayerIconAnimProxy
		{
			get => GetProperty(ref _alternativePlayerIconAnimProxy);
			set => SetProperty(ref _alternativePlayerIconAnimProxy, value);
		}

		[Ordinal(44)] 
		[RED("hasOverridenPlayerIcon")] 
		public CBool HasOverridenPlayerIcon
		{
			get => GetProperty(ref _hasOverridenPlayerIcon);
			set => SetProperty(ref _hasOverridenPlayerIcon, value);
		}

		[Ordinal(45)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(46)] 
		[RED("mapBlackboard")] 
		public wCHandle<gameIBlackboard> MapBlackboard
		{
			get => GetProperty(ref _mapBlackboard);
			set => SetProperty(ref _mapBlackboard, value);
		}

		[Ordinal(47)] 
		[RED("mapDefinition")] 
		public CHandle<UI_MapDef> MapDefinition
		{
			get => GetProperty(ref _mapDefinition);
			set => SetProperty(ref _mapDefinition, value);
		}

		[Ordinal(48)] 
		[RED("locationDataCallback")] 
		public CHandle<redCallbackObject> LocationDataCallback
		{
			get => GetProperty(ref _locationDataCallback);
			set => SetProperty(ref _locationDataCallback, value);
		}

		[Ordinal(49)] 
		[RED("highlightRequestCallback")] 
		public CHandle<redCallbackObject> HighlightRequestCallback
		{
			get => GetProperty(ref _highlightRequestCallback);
			set => SetProperty(ref _highlightRequestCallback, value);
		}

		[Ordinal(50)] 
		[RED("countdownTimerBlackboard")] 
		public wCHandle<gameIBlackboard> CountdownTimerBlackboard
		{
			get => GetProperty(ref _countdownTimerBlackboard);
			set => SetProperty(ref _countdownTimerBlackboard, value);
		}

		[Ordinal(51)] 
		[RED("countdownTimerDefinition")] 
		public CHandle<UI_HUDCountdownTimerDef> CountdownTimerDefinition
		{
			get => GetProperty(ref _countdownTimerDefinition);
			set => SetProperty(ref _countdownTimerDefinition, value);
		}

		[Ordinal(52)] 
		[RED("countdownTimerActiveCallback")] 
		public CHandle<redCallbackObject> CountdownTimerActiveCallback
		{
			get => GetProperty(ref _countdownTimerActiveCallback);
			set => SetProperty(ref _countdownTimerActiveCallback, value);
		}

		[Ordinal(53)] 
		[RED("countdownTimerTimeCallback")] 
		public CHandle<redCallbackObject> CountdownTimerTimeCallback
		{
			get => GetProperty(ref _countdownTimerTimeCallback);
			set => SetProperty(ref _countdownTimerTimeCallback, value);
		}

		[Ordinal(54)] 
		[RED("securityBlackBoardID")] 
		public CHandle<redCallbackObject> SecurityBlackBoardID
		{
			get => GetProperty(ref _securityBlackBoardID);
			set => SetProperty(ref _securityBlackBoardID, value);
		}

		[Ordinal(55)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetProperty(ref _remoteControlledVehicleDataCallback);
			set => SetProperty(ref _remoteControlledVehicleDataCallback, value);
		}

		[Ordinal(56)] 
		[RED("remoteControlledVehicleCameraChangedToTPPCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleCameraChangedToTPPCallback
		{
			get => GetProperty(ref _remoteControlledVehicleCameraChangedToTPPCallback);
			set => SetProperty(ref _remoteControlledVehicleCameraChangedToTPPCallback, value);
		}

		[Ordinal(57)] 
		[RED("combatAnimation")] 
		public CHandle<inkanimProxy> CombatAnimation
		{
			get => GetProperty(ref _combatAnimation);
			set => SetProperty(ref _combatAnimation, value);
		}

		[Ordinal(58)] 
		[RED("autodriveDataDefinition")] 
		public CHandle<UI_AutodriveDataDef> AutodriveDataDefinition
		{
			get => GetProperty(ref _autodriveDataDefinition);
			set => SetProperty(ref _autodriveDataDefinition, value);
		}

		[Ordinal(59)] 
		[RED("autodriveDataBlackboard")] 
		public wCHandle<gameIBlackboard> AutodriveDataBlackboard
		{
			get => GetProperty(ref _autodriveDataBlackboard);
			set => SetProperty(ref _autodriveDataBlackboard, value);
		}

		[Ordinal(60)] 
		[RED("autoDriveEnabledCallback")] 
		public CHandle<redCallbackObject> AutoDriveEnabledCallback
		{
			get => GetProperty(ref _autoDriveEnabledCallback);
			set => SetProperty(ref _autoDriveEnabledCallback, value);
		}

		[Ordinal(61)] 
		[RED("autoDriveEnabled")] 
		public CBool AutoDriveEnabled
		{
			get => GetProperty(ref _autoDriveEnabled);
			set => SetProperty(ref _autoDriveEnabled, value);
		}

		[Ordinal(62)] 
		[RED("autoDriveAnimation")] 
		public CHandle<inkanimProxy> AutoDriveAnimation
		{
			get => GetProperty(ref _autoDriveAnimation);
			set => SetProperty(ref _autoDriveAnimation, value);
		}

		[Ordinal(63)] 
		[RED("playerInCombat")] 
		public CBool PlayerInCombat
		{
			get => GetProperty(ref _playerInCombat);
			set => SetProperty(ref _playerInCombat, value);
		}

		[Ordinal(64)] 
		[RED("currentZoneType")] 
		public CEnum<ESecurityAreaType> CurrentZoneType
		{
			get => GetProperty(ref _currentZoneType);
			set => SetProperty(ref _currentZoneType, value);
		}

		[Ordinal(65)] 
		[RED("messageCounterController")] 
		public wCHandle<inkCompoundWidget> MessageCounterController
		{
			get => GetProperty(ref _messageCounterController);
			set => SetProperty(ref _messageCounterController, value);
		}

		public gameuiMinimapContainerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
