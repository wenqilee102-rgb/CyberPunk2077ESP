using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutoDriveController : gameuiHUDGameController
	{
		private inkWidgetReference _inputHintContainer;
		private inkWidgetReference _autoDriveContentContainer;
		private inkWidgetReference _countersContainer;
		private inkWidgetReference _freeRoamHeaderContainer;
		private inkWidgetReference _remainingDistanceCounterContainer;
		private inkTextWidgetReference _remainingDistanceCounterText;
		private inkWidgetReference _remainingTimeCounterContainer;
		private inkTextWidgetReference _remainingTimeCounterText;
		private ScriptGameInstance _gameInstance;
		private wCHandle<AutoDriveSystem> _autoDriveSystem;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gameIBlackboard> _autodriveBB;
		private CHandle<UI_AutodriveDataDef> _autodriveBBDef;
		private wCHandle<gameIBlackboard> _quickslotBB;
		private CHandle<UI_QuickSlotsDataDef> _quickslotBBDef;
		private CHandle<inkanimProxy> _fakeUpdateProxy;
		private CHandle<redCallbackObject> _autoDriveEnabledCallbackHandle;
		private CHandle<redCallbackObject> _cinematicCameraCallbackHandle;
		private CHandle<redCallbackObject> _autoDriveAvailableCallbackHandle;
		private CHandle<redCallbackObject> _freeRoamEnabledCallbackHandle;
		private CHandle<redCallbackObject> _radialWheelCallbackHandle;
		private CHandle<redCallbackObject> _playerVehicleStateCallbackHandle;
		private CUInt32 _q000StartedListenerId;
		private CUInt32 _dpadHintsVisibilityEnabledListenerId;
		private CHandle<textTextParameterSet> _remainingDistanceCounterTextParams;
		private CHandle<textTextParameterSet> _remainingTimeCounterTextParams;
		private CHandle<inkanimProxy> _inputHintVisibilityAnimProxy;
		private CBool _inputHintVisible;
		private CHandle<inkanimProxy> _wheelIconAnimProxy;
		private CBool _wheelAnimationEnabled;
		private CBool _isHoldingDirectionInput;
		private CHandle<inkanimProxy> _slowCloseAnimProxy;
		private CBool _slowCloseAnimIsReversed;
		private CHandle<inkanimProxy> _containerAnimProxy;
		private CBool _containerVisible;
		private CBool _containerAnimationPlaying;
		private CHandle<inkanimProxy> _rootAnimProxy;
		private CBool _rootVisible;
		private CEnum<AutoDriveDriveType> _activeDriveType;
		private CHandle<inkanimProxy> _headerAnimProxy;
		private CHandle<inkanimProxy> _inputHintDriveTypeAnimProxy;

		[Ordinal(9)] 
		[RED("inputHintContainer")] 
		public inkWidgetReference InputHintContainer
		{
			get => GetProperty(ref _inputHintContainer);
			set => SetProperty(ref _inputHintContainer, value);
		}

		[Ordinal(10)] 
		[RED("autoDriveContentContainer")] 
		public inkWidgetReference AutoDriveContentContainer
		{
			get => GetProperty(ref _autoDriveContentContainer);
			set => SetProperty(ref _autoDriveContentContainer, value);
		}

		[Ordinal(11)] 
		[RED("countersContainer")] 
		public inkWidgetReference CountersContainer
		{
			get => GetProperty(ref _countersContainer);
			set => SetProperty(ref _countersContainer, value);
		}

		[Ordinal(12)] 
		[RED("freeRoamHeaderContainer")] 
		public inkWidgetReference FreeRoamHeaderContainer
		{
			get => GetProperty(ref _freeRoamHeaderContainer);
			set => SetProperty(ref _freeRoamHeaderContainer, value);
		}

		[Ordinal(13)] 
		[RED("remainingDistanceCounterContainer")] 
		public inkWidgetReference RemainingDistanceCounterContainer
		{
			get => GetProperty(ref _remainingDistanceCounterContainer);
			set => SetProperty(ref _remainingDistanceCounterContainer, value);
		}

		[Ordinal(14)] 
		[RED("remainingDistanceCounterText")] 
		public inkTextWidgetReference RemainingDistanceCounterText
		{
			get => GetProperty(ref _remainingDistanceCounterText);
			set => SetProperty(ref _remainingDistanceCounterText, value);
		}

		[Ordinal(15)] 
		[RED("remainingTimeCounterContainer")] 
		public inkWidgetReference RemainingTimeCounterContainer
		{
			get => GetProperty(ref _remainingTimeCounterContainer);
			set => SetProperty(ref _remainingTimeCounterContainer, value);
		}

		[Ordinal(16)] 
		[RED("remainingTimeCounterText")] 
		public inkTextWidgetReference RemainingTimeCounterText
		{
			get => GetProperty(ref _remainingTimeCounterText);
			set => SetProperty(ref _remainingTimeCounterText, value);
		}

		[Ordinal(17)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(18)] 
		[RED("autoDriveSystem")] 
		public wCHandle<AutoDriveSystem> AutoDriveSystem
		{
			get => GetProperty(ref _autoDriveSystem);
			set => SetProperty(ref _autoDriveSystem, value);
		}

		[Ordinal(19)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(20)] 
		[RED("autodriveBB")] 
		public wCHandle<gameIBlackboard> AutodriveBB
		{
			get => GetProperty(ref _autodriveBB);
			set => SetProperty(ref _autodriveBB, value);
		}

		[Ordinal(21)] 
		[RED("autodriveBBDef")] 
		public CHandle<UI_AutodriveDataDef> AutodriveBBDef
		{
			get => GetProperty(ref _autodriveBBDef);
			set => SetProperty(ref _autodriveBBDef, value);
		}

		[Ordinal(22)] 
		[RED("quickslotBB")] 
		public wCHandle<gameIBlackboard> QuickslotBB
		{
			get => GetProperty(ref _quickslotBB);
			set => SetProperty(ref _quickslotBB, value);
		}

		[Ordinal(23)] 
		[RED("quickslotBBDef")] 
		public CHandle<UI_QuickSlotsDataDef> QuickslotBBDef
		{
			get => GetProperty(ref _quickslotBBDef);
			set => SetProperty(ref _quickslotBBDef, value);
		}

		[Ordinal(24)] 
		[RED("fakeUpdateProxy")] 
		public CHandle<inkanimProxy> FakeUpdateProxy
		{
			get => GetProperty(ref _fakeUpdateProxy);
			set => SetProperty(ref _fakeUpdateProxy, value);
		}

		[Ordinal(25)] 
		[RED("autoDriveEnabledCallbackHandle")] 
		public CHandle<redCallbackObject> AutoDriveEnabledCallbackHandle
		{
			get => GetProperty(ref _autoDriveEnabledCallbackHandle);
			set => SetProperty(ref _autoDriveEnabledCallbackHandle, value);
		}

		[Ordinal(26)] 
		[RED("cinematicCameraCallbackHandle")] 
		public CHandle<redCallbackObject> CinematicCameraCallbackHandle
		{
			get => GetProperty(ref _cinematicCameraCallbackHandle);
			set => SetProperty(ref _cinematicCameraCallbackHandle, value);
		}

		[Ordinal(27)] 
		[RED("autoDriveAvailableCallbackHandle")] 
		public CHandle<redCallbackObject> AutoDriveAvailableCallbackHandle
		{
			get => GetProperty(ref _autoDriveAvailableCallbackHandle);
			set => SetProperty(ref _autoDriveAvailableCallbackHandle, value);
		}

		[Ordinal(28)] 
		[RED("freeRoamEnabledCallbackHandle")] 
		public CHandle<redCallbackObject> FreeRoamEnabledCallbackHandle
		{
			get => GetProperty(ref _freeRoamEnabledCallbackHandle);
			set => SetProperty(ref _freeRoamEnabledCallbackHandle, value);
		}

		[Ordinal(29)] 
		[RED("radialWheelCallbackHandle")] 
		public CHandle<redCallbackObject> RadialWheelCallbackHandle
		{
			get => GetProperty(ref _radialWheelCallbackHandle);
			set => SetProperty(ref _radialWheelCallbackHandle, value);
		}

		[Ordinal(30)] 
		[RED("playerVehicleStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerVehicleStateCallbackHandle
		{
			get => GetProperty(ref _playerVehicleStateCallbackHandle);
			set => SetProperty(ref _playerVehicleStateCallbackHandle, value);
		}

		[Ordinal(31)] 
		[RED("q000StartedListenerId")] 
		public CUInt32 Q000StartedListenerId
		{
			get => GetProperty(ref _q000StartedListenerId);
			set => SetProperty(ref _q000StartedListenerId, value);
		}

		[Ordinal(32)] 
		[RED("dpadHintsVisibilityEnabledListenerId")] 
		public CUInt32 DpadHintsVisibilityEnabledListenerId
		{
			get => GetProperty(ref _dpadHintsVisibilityEnabledListenerId);
			set => SetProperty(ref _dpadHintsVisibilityEnabledListenerId, value);
		}

		[Ordinal(33)] 
		[RED("remainingDistanceCounterTextParams")] 
		public CHandle<textTextParameterSet> RemainingDistanceCounterTextParams
		{
			get => GetProperty(ref _remainingDistanceCounterTextParams);
			set => SetProperty(ref _remainingDistanceCounterTextParams, value);
		}

		[Ordinal(34)] 
		[RED("remainingTimeCounterTextParams")] 
		public CHandle<textTextParameterSet> RemainingTimeCounterTextParams
		{
			get => GetProperty(ref _remainingTimeCounterTextParams);
			set => SetProperty(ref _remainingTimeCounterTextParams, value);
		}

		[Ordinal(35)] 
		[RED("inputHintVisibilityAnimProxy")] 
		public CHandle<inkanimProxy> InputHintVisibilityAnimProxy
		{
			get => GetProperty(ref _inputHintVisibilityAnimProxy);
			set => SetProperty(ref _inputHintVisibilityAnimProxy, value);
		}

		[Ordinal(36)] 
		[RED("inputHintVisible")] 
		public CBool InputHintVisible
		{
			get => GetProperty(ref _inputHintVisible);
			set => SetProperty(ref _inputHintVisible, value);
		}

		[Ordinal(37)] 
		[RED("wheelIconAnimProxy")] 
		public CHandle<inkanimProxy> WheelIconAnimProxy
		{
			get => GetProperty(ref _wheelIconAnimProxy);
			set => SetProperty(ref _wheelIconAnimProxy, value);
		}

		[Ordinal(38)] 
		[RED("wheelAnimationEnabled")] 
		public CBool WheelAnimationEnabled
		{
			get => GetProperty(ref _wheelAnimationEnabled);
			set => SetProperty(ref _wheelAnimationEnabled, value);
		}

		[Ordinal(39)] 
		[RED("isHoldingDirectionInput")] 
		public CBool IsHoldingDirectionInput
		{
			get => GetProperty(ref _isHoldingDirectionInput);
			set => SetProperty(ref _isHoldingDirectionInput, value);
		}

		[Ordinal(40)] 
		[RED("slowCloseAnimProxy")] 
		public CHandle<inkanimProxy> SlowCloseAnimProxy
		{
			get => GetProperty(ref _slowCloseAnimProxy);
			set => SetProperty(ref _slowCloseAnimProxy, value);
		}

		[Ordinal(41)] 
		[RED("slowCloseAnimIsReversed")] 
		public CBool SlowCloseAnimIsReversed
		{
			get => GetProperty(ref _slowCloseAnimIsReversed);
			set => SetProperty(ref _slowCloseAnimIsReversed, value);
		}

		[Ordinal(42)] 
		[RED("containerAnimProxy")] 
		public CHandle<inkanimProxy> ContainerAnimProxy
		{
			get => GetProperty(ref _containerAnimProxy);
			set => SetProperty(ref _containerAnimProxy, value);
		}

		[Ordinal(43)] 
		[RED("containerVisible")] 
		public CBool ContainerVisible
		{
			get => GetProperty(ref _containerVisible);
			set => SetProperty(ref _containerVisible, value);
		}

		[Ordinal(44)] 
		[RED("containerAnimationPlaying")] 
		public CBool ContainerAnimationPlaying
		{
			get => GetProperty(ref _containerAnimationPlaying);
			set => SetProperty(ref _containerAnimationPlaying, value);
		}

		[Ordinal(45)] 
		[RED("rootAnimProxy")] 
		public CHandle<inkanimProxy> RootAnimProxy
		{
			get => GetProperty(ref _rootAnimProxy);
			set => SetProperty(ref _rootAnimProxy, value);
		}

		[Ordinal(46)] 
		[RED("rootVisible")] 
		public CBool RootVisible
		{
			get => GetProperty(ref _rootVisible);
			set => SetProperty(ref _rootVisible, value);
		}

		[Ordinal(47)] 
		[RED("activeDriveType")] 
		public CEnum<AutoDriveDriveType> ActiveDriveType
		{
			get => GetProperty(ref _activeDriveType);
			set => SetProperty(ref _activeDriveType, value);
		}

		[Ordinal(48)] 
		[RED("headerAnimProxy")] 
		public CHandle<inkanimProxy> HeaderAnimProxy
		{
			get => GetProperty(ref _headerAnimProxy);
			set => SetProperty(ref _headerAnimProxy, value);
		}

		[Ordinal(49)] 
		[RED("inputHintDriveTypeAnimProxy")] 
		public CHandle<inkanimProxy> InputHintDriveTypeAnimProxy
		{
			get => GetProperty(ref _inputHintDriveTypeAnimProxy);
			set => SetProperty(ref _inputHintDriveTypeAnimProxy, value);
		}

		public AutoDriveController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
