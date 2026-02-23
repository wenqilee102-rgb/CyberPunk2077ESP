using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimingStateEvents : UpperBodyEventsTransition
	{
		private CHandle<gameweaponAnimFeature_AimPlayer> _aim;
		private CHandle<AnimFeature_ProceduralIronsightData> _posAnimFeature;
		private CHandle<DefaultTransitionStatusEffectListener> _statusEffectListener;
		private wCHandle<gameweaponObject> _weapon;
		private wCHandle<gameObject> _executionOwner;
		private wCHandle<gameIBlackboard> _localBlackboard;
		private CFloat _mouseZoomLevel;
		private CInt32 _zoomLevelNum;
		private CInt32 _numZoomLevels;
		private CInt32 _delayAimSnap;
		private CBool _isAiming;
		private CFloat _aimInTimeRemaining;
		private CBool _aimBroadcast;
		private CFloat _zoomLevel;
		private CFloat _finalZoomLevel;
		private CFloat _previousZoomLevel;
		private CFloat _currentZoomLevel;
		private CFloat _timeToBlendZoom;
		private CFloat _time;
		private CFloat _speed;
		private CBool _itemChanged;
		private CBool _firearmsNoUnequipNoSwitch;
		private CBool _shootingRangeCompetition;
		private CBool _weaponHasPerfectAim;
		private CHandle<gameStatsSystem> _statsSystem;
		private CHandle<gameStatusEffectSystem> _statusEffectSystem;
		private CHandle<gameAttachmentSlotsScriptListener> _attachmentSlotListener;
		private CFloat _prevDownwardsGravity;
		private CBool _downwardsGravityChanged;
		private CHandle<gameConstantStatModifierData_Deprecated> _accelerationMod;
		private CHandle<gameConstantStatModifierData_Deprecated> _decelerationMod;

		[Ordinal(6)] 
		[RED("aim")] 
		public CHandle<gameweaponAnimFeature_AimPlayer> Aim
		{
			get => GetProperty(ref _aim);
			set => SetProperty(ref _aim, value);
		}

		[Ordinal(7)] 
		[RED("posAnimFeature")] 
		public CHandle<AnimFeature_ProceduralIronsightData> PosAnimFeature
		{
			get => GetProperty(ref _posAnimFeature);
			set => SetProperty(ref _posAnimFeature, value);
		}

		[Ordinal(8)] 
		[RED("statusEffectListener")] 
		public CHandle<DefaultTransitionStatusEffectListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(9)] 
		[RED("weapon")] 
		public wCHandle<gameweaponObject> Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(10)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(11)] 
		[RED("localBlackboard")] 
		public wCHandle<gameIBlackboard> LocalBlackboard
		{
			get => GetProperty(ref _localBlackboard);
			set => SetProperty(ref _localBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("mouseZoomLevel")] 
		public CFloat MouseZoomLevel
		{
			get => GetProperty(ref _mouseZoomLevel);
			set => SetProperty(ref _mouseZoomLevel, value);
		}

		[Ordinal(13)] 
		[RED("zoomLevelNum")] 
		public CInt32 ZoomLevelNum
		{
			get => GetProperty(ref _zoomLevelNum);
			set => SetProperty(ref _zoomLevelNum, value);
		}

		[Ordinal(14)] 
		[RED("numZoomLevels")] 
		public CInt32 NumZoomLevels
		{
			get => GetProperty(ref _numZoomLevels);
			set => SetProperty(ref _numZoomLevels, value);
		}

		[Ordinal(15)] 
		[RED("delayAimSnap")] 
		public CInt32 DelayAimSnap
		{
			get => GetProperty(ref _delayAimSnap);
			set => SetProperty(ref _delayAimSnap, value);
		}

		[Ordinal(16)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(17)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetProperty(ref _aimInTimeRemaining);
			set => SetProperty(ref _aimInTimeRemaining, value);
		}

		[Ordinal(18)] 
		[RED("aimBroadcast")] 
		public CBool AimBroadcast
		{
			get => GetProperty(ref _aimBroadcast);
			set => SetProperty(ref _aimBroadcast, value);
		}

		[Ordinal(19)] 
		[RED("zoomLevel")] 
		public CFloat ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(20)] 
		[RED("finalZoomLevel")] 
		public CFloat FinalZoomLevel
		{
			get => GetProperty(ref _finalZoomLevel);
			set => SetProperty(ref _finalZoomLevel, value);
		}

		[Ordinal(21)] 
		[RED("previousZoomLevel")] 
		public CFloat PreviousZoomLevel
		{
			get => GetProperty(ref _previousZoomLevel);
			set => SetProperty(ref _previousZoomLevel, value);
		}

		[Ordinal(22)] 
		[RED("currentZoomLevel")] 
		public CFloat CurrentZoomLevel
		{
			get => GetProperty(ref _currentZoomLevel);
			set => SetProperty(ref _currentZoomLevel, value);
		}

		[Ordinal(23)] 
		[RED("timeToBlendZoom")] 
		public CFloat TimeToBlendZoom
		{
			get => GetProperty(ref _timeToBlendZoom);
			set => SetProperty(ref _timeToBlendZoom, value);
		}

		[Ordinal(24)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(25)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(26)] 
		[RED("itemChanged")] 
		public CBool ItemChanged
		{
			get => GetProperty(ref _itemChanged);
			set => SetProperty(ref _itemChanged, value);
		}

		[Ordinal(27)] 
		[RED("firearmsNoUnequipNoSwitch")] 
		public CBool FirearmsNoUnequipNoSwitch
		{
			get => GetProperty(ref _firearmsNoUnequipNoSwitch);
			set => SetProperty(ref _firearmsNoUnequipNoSwitch, value);
		}

		[Ordinal(28)] 
		[RED("shootingRangeCompetition")] 
		public CBool ShootingRangeCompetition
		{
			get => GetProperty(ref _shootingRangeCompetition);
			set => SetProperty(ref _shootingRangeCompetition, value);
		}

		[Ordinal(29)] 
		[RED("weaponHasPerfectAim")] 
		public CBool WeaponHasPerfectAim
		{
			get => GetProperty(ref _weaponHasPerfectAim);
			set => SetProperty(ref _weaponHasPerfectAim, value);
		}

		[Ordinal(30)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(31)] 
		[RED("statusEffectSystem")] 
		public CHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetProperty(ref _statusEffectSystem);
			set => SetProperty(ref _statusEffectSystem, value);
		}

		[Ordinal(32)] 
		[RED("attachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> AttachmentSlotListener
		{
			get => GetProperty(ref _attachmentSlotListener);
			set => SetProperty(ref _attachmentSlotListener, value);
		}

		[Ordinal(33)] 
		[RED("prevDownwardsGravity")] 
		public CFloat PrevDownwardsGravity
		{
			get => GetProperty(ref _prevDownwardsGravity);
			set => SetProperty(ref _prevDownwardsGravity, value);
		}

		[Ordinal(34)] 
		[RED("downwardsGravityChanged")] 
		public CBool DownwardsGravityChanged
		{
			get => GetProperty(ref _downwardsGravityChanged);
			set => SetProperty(ref _downwardsGravityChanged, value);
		}

		[Ordinal(35)] 
		[RED("accelerationMod")] 
		public CHandle<gameConstantStatModifierData_Deprecated> AccelerationMod
		{
			get => GetProperty(ref _accelerationMod);
			set => SetProperty(ref _accelerationMod, value);
		}

		[Ordinal(36)] 
		[RED("decelerationMod")] 
		public CHandle<gameConstantStatModifierData_Deprecated> DecelerationMod
		{
			get => GetProperty(ref _decelerationMod);
			set => SetProperty(ref _decelerationMod, value);
		}

		public AimingStateEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
