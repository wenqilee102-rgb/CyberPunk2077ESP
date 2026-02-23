using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiCrosshairBaseGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _details;
		private CBool _isActive;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private wCHandle<gameIBlackboard> _targetBB;
		private wCHandle<gameIBlackboard> _weaponBB;
		private wCHandle<entEntity> _targetEntity;
		private wCHandle<entEntity> _raycastTargetEntity;
		private wCHandle<gameObject> _playerPuppet;
		private CEnum<gamePSMCrosshairStates> _crosshairState;
		private CEnum<gamePSMVision> _visionState;
		private CHandle<redCallbackObject> _crosshairStateBlackboardId;
		private CHandle<redCallbackObject> _bulletSpreedBlackboardId;
		private CBool _isTargetDead;
		private CUInt64 _lastGUIStateUpdateFrame;
		private CHandle<redCallbackObject> _currentAimTargetBBID;
		private CHandle<redCallbackObject> _currentRaycastTargetBBID;
		private CHandle<redCallbackObject> _targetDistanceBBID;
		private CHandle<redCallbackObject> _targetAttitudeBBID;
		private CHandle<CrosshairHealthChangeListener> _healthListener;
		private inkWidgetReference _deadEyeWidget;
		private CHandle<inkanimProxy> _deadEyeAnimProxy;
		private CBool _hasDeadEye;
		private CBool _isCamoActiveOnPlayer;
		private CHandle<redCallbackObject> _staminaChangedCallback;
		private CHandle<CrosshairStaminaListener> _staminaListener;
		private CHandle<OpticalCamoListener> _opticalCamoListener;

		[Ordinal(2)] 
		[RED("details")] 
		public inkWidgetReference Details
		{
			get => GetProperty(ref _details);
			set => SetProperty(ref _details, value);
		}

		[Ordinal(3)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(4)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(5)] 
		[RED("psmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(6)] 
		[RED("targetBB")] 
		public wCHandle<gameIBlackboard> TargetBB
		{
			get => GetProperty(ref _targetBB);
			set => SetProperty(ref _targetBB, value);
		}

		[Ordinal(7)] 
		[RED("weaponBB")] 
		public wCHandle<gameIBlackboard> WeaponBB
		{
			get => GetProperty(ref _weaponBB);
			set => SetProperty(ref _weaponBB, value);
		}

		[Ordinal(8)] 
		[RED("targetEntity")] 
		public wCHandle<entEntity> TargetEntity
		{
			get => GetProperty(ref _targetEntity);
			set => SetProperty(ref _targetEntity, value);
		}

		[Ordinal(9)] 
		[RED("raycastTargetEntity")] 
		public wCHandle<entEntity> RaycastTargetEntity
		{
			get => GetProperty(ref _raycastTargetEntity);
			set => SetProperty(ref _raycastTargetEntity, value);
		}

		[Ordinal(10)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(11)] 
		[RED("crosshairState")] 
		public CEnum<gamePSMCrosshairStates> CrosshairState
		{
			get => GetProperty(ref _crosshairState);
			set => SetProperty(ref _crosshairState, value);
		}

		[Ordinal(12)] 
		[RED("visionState")] 
		public CEnum<gamePSMVision> VisionState
		{
			get => GetProperty(ref _visionState);
			set => SetProperty(ref _visionState, value);
		}

		[Ordinal(13)] 
		[RED("crosshairStateBlackboardId")] 
		public CHandle<redCallbackObject> CrosshairStateBlackboardId
		{
			get => GetProperty(ref _crosshairStateBlackboardId);
			set => SetProperty(ref _crosshairStateBlackboardId, value);
		}

		[Ordinal(14)] 
		[RED("bulletSpreedBlackboardId")] 
		public CHandle<redCallbackObject> BulletSpreedBlackboardId
		{
			get => GetProperty(ref _bulletSpreedBlackboardId);
			set => SetProperty(ref _bulletSpreedBlackboardId, value);
		}

		[Ordinal(15)] 
		[RED("isTargetDead")] 
		public CBool IsTargetDead
		{
			get => GetProperty(ref _isTargetDead);
			set => SetProperty(ref _isTargetDead, value);
		}

		[Ordinal(16)] 
		[RED("lastGUIStateUpdateFrame")] 
		public CUInt64 LastGUIStateUpdateFrame
		{
			get => GetProperty(ref _lastGUIStateUpdateFrame);
			set => SetProperty(ref _lastGUIStateUpdateFrame, value);
		}

		[Ordinal(17)] 
		[RED("currentAimTargetBBID")] 
		public CHandle<redCallbackObject> CurrentAimTargetBBID
		{
			get => GetProperty(ref _currentAimTargetBBID);
			set => SetProperty(ref _currentAimTargetBBID, value);
		}

		[Ordinal(18)] 
		[RED("currentRaycastTargetBBID")] 
		public CHandle<redCallbackObject> CurrentRaycastTargetBBID
		{
			get => GetProperty(ref _currentRaycastTargetBBID);
			set => SetProperty(ref _currentRaycastTargetBBID, value);
		}

		[Ordinal(19)] 
		[RED("targetDistanceBBID")] 
		public CHandle<redCallbackObject> TargetDistanceBBID
		{
			get => GetProperty(ref _targetDistanceBBID);
			set => SetProperty(ref _targetDistanceBBID, value);
		}

		[Ordinal(20)] 
		[RED("targetAttitudeBBID")] 
		public CHandle<redCallbackObject> TargetAttitudeBBID
		{
			get => GetProperty(ref _targetAttitudeBBID);
			set => SetProperty(ref _targetAttitudeBBID, value);
		}

		[Ordinal(21)] 
		[RED("healthListener")] 
		public CHandle<CrosshairHealthChangeListener> HealthListener
		{
			get => GetProperty(ref _healthListener);
			set => SetProperty(ref _healthListener, value);
		}

		[Ordinal(22)] 
		[RED("deadEyeWidget")] 
		public inkWidgetReference DeadEyeWidget
		{
			get => GetProperty(ref _deadEyeWidget);
			set => SetProperty(ref _deadEyeWidget, value);
		}

		[Ordinal(23)] 
		[RED("deadEyeAnimProxy")] 
		public CHandle<inkanimProxy> DeadEyeAnimProxy
		{
			get => GetProperty(ref _deadEyeAnimProxy);
			set => SetProperty(ref _deadEyeAnimProxy, value);
		}

		[Ordinal(24)] 
		[RED("hasDeadEye")] 
		public CBool HasDeadEye
		{
			get => GetProperty(ref _hasDeadEye);
			set => SetProperty(ref _hasDeadEye, value);
		}

		[Ordinal(25)] 
		[RED("isCamoActiveOnPlayer")] 
		public CBool IsCamoActiveOnPlayer
		{
			get => GetProperty(ref _isCamoActiveOnPlayer);
			set => SetProperty(ref _isCamoActiveOnPlayer, value);
		}

		[Ordinal(26)] 
		[RED("staminaChangedCallback")] 
		public CHandle<redCallbackObject> StaminaChangedCallback
		{
			get => GetProperty(ref _staminaChangedCallback);
			set => SetProperty(ref _staminaChangedCallback, value);
		}

		[Ordinal(27)] 
		[RED("staminaListener")] 
		public CHandle<CrosshairStaminaListener> StaminaListener
		{
			get => GetProperty(ref _staminaListener);
			set => SetProperty(ref _staminaListener, value);
		}

		[Ordinal(28)] 
		[RED("opticalCamoListener")] 
		public CHandle<OpticalCamoListener> OpticalCamoListener
		{
			get => GetProperty(ref _opticalCamoListener);
			set => SetProperty(ref _opticalCamoListener, value);
		}

		public gameuiCrosshairBaseGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
