using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVisualCustomizationHotkeyController : GenericHotkeyController
	{
		private inkImageWidgetReference _questMarker;
		private wCHandle<gameIBlackboard> _vehicleBB;
		private CHandle<redCallbackObject> _vehicleEnterListener;
		private CHandle<redCallbackObject> _cinematicCameraListener;
		private CHandle<redCallbackObject> _delamainTaxiListener;
		private CUInt32 _factListener;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkGameNotificationToken> _carColorSelectorToken;
		private CBool _isInDefaultState;
		private CBool _phoneMenuActive;
		private CBool _driving;
		private CBool _cinematicCamera;
		private CBool _delamainTaxi;
		private CUInt32 _mq058_done_factListener;
		private CUInt32 _sq024_done_factListener;
		private CUInt32 _mq057_done_factListener;
		private CUInt32 _mq058_update_applied_factListener;
		private CUInt32 _mq058_playerFailedToOpenVVC_factListener;
		private CEnum<gamePSMCombat> _currentCombatState;
		private CHandle<redCallbackObject> _combatStateCallback;
		private CHandle<redCallbackObject> _phoneStateCallback;

		[Ordinal(25)] 
		[RED("questMarker")] 
		public inkImageWidgetReference QuestMarker
		{
			get => GetProperty(ref _questMarker);
			set => SetProperty(ref _questMarker, value);
		}

		[Ordinal(26)] 
		[RED("vehicleBB")] 
		public wCHandle<gameIBlackboard> VehicleBB
		{
			get => GetProperty(ref _vehicleBB);
			set => SetProperty(ref _vehicleBB, value);
		}

		[Ordinal(27)] 
		[RED("vehicleEnterListener")] 
		public CHandle<redCallbackObject> VehicleEnterListener
		{
			get => GetProperty(ref _vehicleEnterListener);
			set => SetProperty(ref _vehicleEnterListener, value);
		}

		[Ordinal(28)] 
		[RED("cinematicCameraListener")] 
		public CHandle<redCallbackObject> CinematicCameraListener
		{
			get => GetProperty(ref _cinematicCameraListener);
			set => SetProperty(ref _cinematicCameraListener, value);
		}

		[Ordinal(29)] 
		[RED("delamainTaxiListener")] 
		public CHandle<redCallbackObject> DelamainTaxiListener
		{
			get => GetProperty(ref _delamainTaxiListener);
			set => SetProperty(ref _delamainTaxiListener, value);
		}

		[Ordinal(30)] 
		[RED("factListener")] 
		public CUInt32 FactListener
		{
			get => GetProperty(ref _factListener);
			set => SetProperty(ref _factListener, value);
		}

		[Ordinal(31)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(32)] 
		[RED("carColorSelectorToken")] 
		public CHandle<inkGameNotificationToken> CarColorSelectorToken
		{
			get => GetProperty(ref _carColorSelectorToken);
			set => SetProperty(ref _carColorSelectorToken, value);
		}

		[Ordinal(33)] 
		[RED("isInDefaultState")] 
		public CBool IsInDefaultState
		{
			get => GetProperty(ref _isInDefaultState);
			set => SetProperty(ref _isInDefaultState, value);
		}

		[Ordinal(34)] 
		[RED("phoneMenuActive")] 
		public CBool PhoneMenuActive
		{
			get => GetProperty(ref _phoneMenuActive);
			set => SetProperty(ref _phoneMenuActive, value);
		}

		[Ordinal(35)] 
		[RED("driving")] 
		public CBool Driving
		{
			get => GetProperty(ref _driving);
			set => SetProperty(ref _driving, value);
		}

		[Ordinal(36)] 
		[RED("cinematicCamera")] 
		public CBool CinematicCamera
		{
			get => GetProperty(ref _cinematicCamera);
			set => SetProperty(ref _cinematicCamera, value);
		}

		[Ordinal(37)] 
		[RED("delamainTaxi")] 
		public CBool DelamainTaxi
		{
			get => GetProperty(ref _delamainTaxi);
			set => SetProperty(ref _delamainTaxi, value);
		}

		[Ordinal(38)] 
		[RED("mq058_done_factListener")] 
		public CUInt32 Mq058_done_factListener
		{
			get => GetProperty(ref _mq058_done_factListener);
			set => SetProperty(ref _mq058_done_factListener, value);
		}

		[Ordinal(39)] 
		[RED("sq024_done_factListener")] 
		public CUInt32 Sq024_done_factListener
		{
			get => GetProperty(ref _sq024_done_factListener);
			set => SetProperty(ref _sq024_done_factListener, value);
		}

		[Ordinal(40)] 
		[RED("mq057_done_factListener")] 
		public CUInt32 Mq057_done_factListener
		{
			get => GetProperty(ref _mq057_done_factListener);
			set => SetProperty(ref _mq057_done_factListener, value);
		}

		[Ordinal(41)] 
		[RED("mq058_update_applied_factListener")] 
		public CUInt32 Mq058_update_applied_factListener
		{
			get => GetProperty(ref _mq058_update_applied_factListener);
			set => SetProperty(ref _mq058_update_applied_factListener, value);
		}

		[Ordinal(42)] 
		[RED("mq058_playerFailedToOpenVVC_factListener")] 
		public CUInt32 Mq058_playerFailedToOpenVVC_factListener
		{
			get => GetProperty(ref _mq058_playerFailedToOpenVVC_factListener);
			set => SetProperty(ref _mq058_playerFailedToOpenVVC_factListener, value);
		}

		[Ordinal(43)] 
		[RED("currentCombatState")] 
		public CEnum<gamePSMCombat> CurrentCombatState
		{
			get => GetProperty(ref _currentCombatState);
			set => SetProperty(ref _currentCombatState, value);
		}

		[Ordinal(44)] 
		[RED("combatStateCallback")] 
		public CHandle<redCallbackObject> CombatStateCallback
		{
			get => GetProperty(ref _combatStateCallback);
			set => SetProperty(ref _combatStateCallback, value);
		}

		[Ordinal(45)] 
		[RED("phoneStateCallback")] 
		public CHandle<redCallbackObject> PhoneStateCallback
		{
			get => GetProperty(ref _phoneStateCallback);
			set => SetProperty(ref _phoneStateCallback, value);
		}

		public vehicleVisualCustomizationHotkeyController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
