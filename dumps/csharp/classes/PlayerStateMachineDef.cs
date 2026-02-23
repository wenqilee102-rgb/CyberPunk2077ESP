using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerStateMachineDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Int32 _locomotion;
		private gamebbScriptID_Int32 _locomotionDetailed;
		private gamebbScriptID_Int32 _highLevel;
		private gamebbScriptID_Int32 _upperBody;
		private gamebbScriptID_Int32 _timeDilation;
		private gamebbScriptID_Int32 _weapon;
		private gamebbScriptID_Float _latestWeaponReloadTime;
		private gamebbScriptID_Int32 _melee;
		private gamebbScriptID_Int32 _uI;
		private gamebbScriptID_Int32 _crosshair;
		private gamebbScriptID_Int32 _reaction;
		private gamebbScriptID_Int32 _zones;
		private gamebbScriptID_Variant _securityZoneData;
		private gamebbScriptID_Int32 _vision;
		private gamebbScriptID_Int32 _visionDebug;
		private gamebbScriptID_Int32 _sceneTier;
		private gamebbScriptID_Int32 _combatGadget;
		private gamebbScriptID_Variant _lastCombatGadgetUsed;
		private gamebbScriptID_Int32 _consumable;
		private gamebbScriptID_Int32 _vehicle;
		private gamebbScriptID_Bool _mountedToVehicleInDriverSeat;
		private gamebbScriptID_Bool _mountedToCombatVehicle;
		private gamebbScriptID_Bool _mountedToVehicle;
		private gamebbScriptID_Bool _inArmoredVehicle;
		private gamebbScriptID_Float _zoomLevel;
		private gamebbScriptID_Int32 _maxZoomLevel;
		private gamebbScriptID_Bool _toggleFireMode;
		private gamebbScriptID_Bool _switchWeapon;
		private gamebbScriptID_Bool _isDoorInteractionActive;
		private gamebbScriptID_EntityID _finisherTarget;
		private gamebbScriptID_Bool _isInteractingWithDevice;
		private gamebbScriptID_Bool _isInteractingViaPersonalLink;
		private gamebbScriptID_Bool _isForceOpeningDoor;
		private gamebbScriptID_Bool _isControllingDevice;
		private gamebbScriptID_Bool _isControllingCamera;
		private gamebbScriptID_Bool _isUIZoomDevice;
		private gamebbScriptID_EntityID _uIZoomDeviceID;
		private gamebbScriptID_Bool _useUnarmed;
		private gamebbScriptID_Int32 _berserk;
		private gamebbScriptID_Int32 _activeCyberware;
		private gamebbScriptID_Int32 _whip;
		private gamebbScriptID_Bool _dEBUG_SilencedWeapon;
		private gamebbScriptID_Int32 _leftHandCyberware;
		private gamebbScriptID_Bool _useLeftHand;
		private gamebbScriptID_Int32 _meleeWeapon;
		private gamebbScriptID_Bool _carrying;
		private gamebbScriptID_Bool _carryingDisposal;
		private gamebbScriptID_Variant _currentElevator;
		private gamebbScriptID_Bool _isPlayerInsideElevator;
		private gamebbScriptID_Bool _isPlayerInsideMovingElevator;
		private gamebbScriptID_Int32 _combat;
		private gamebbScriptID_Int32 _stamina;
		private gamebbScriptID_Int32 _vitals;
		private gamebbScriptID_Int32 _takedown;
		private gamebbScriptID_EntityID _takedownTargetID;
		private gamebbScriptID_Int32 _fall;
		private gamebbScriptID_Int32 _landing;
		private gamebbScriptID_Bool _usingCover;
		private gamebbScriptID_Bool _isInMinigame;
		private gamebbScriptID_Variant _uploadingQuickHackIDs;
		private gamebbScriptID_Variant _costFreeActionID;
		private gamebbScriptID_Int32 _amountOfCostFreeActions;
		private gamebbScriptID_Variant _meleeSpreadableQuickhackActionID;
		private gamebbScriptID_EntityID _entityIDTargetingPlayer;
		private gamebbScriptID_EntityID _entityIDVehicleRemoteControlled;
		private gamebbScriptID_Bool _isVehicleRemoteControlCameraTPP;
		private gamebbScriptID_Int32 _swimming;
		private gamebbScriptID_Int32 _bodyCarrying;
		private gamebbScriptID_Int32 _bodyDisposalDetailed;
		private gamebbScriptID_Bool _displayDeathMenu;
		private gamebbScriptID_Bool _overrideQuickHackPanelDilation;
		private gamebbScriptID_Int32 _nanoWireLaunchMode;
		private gamebbScriptID_Bool _isMovingHorizontally;
		private gamebbScriptID_Bool _isMovingVertically;
		private gamebbScriptID_Bool _isOnGround;
		private gamebbScriptID_Float _minElevation;
		private gamebbScriptID_Float _maxElevation;
		private gamebbScriptID_Variant _actionRestriction;
		private gamebbScriptID_Bool _meleeLeap;
		private gamebbScriptID_Int32 _isInWorkspot;
		private gamebbScriptID_Bool _questForceShoot;
		private gamebbScriptID_Int32 _ladderCameraParams;
		private gamebbScriptID_Float _dodgeTimeStamp;
		private gamebbScriptID_Bool _canOnePunch;
		private gamebbScriptID_Bool _hasSmartGunLockedOnTarget;
		private gamebbScriptID_Bool _sceneAimForced;
		private gamebbScriptID_Bool _sceneSafeForced;
		private gamebbScriptID_Float _sceneWeaponLoweringSpeedOverride;
		private gamebbScriptID_Bool _scenePreventFirstEquip;
		private gamebbScriptID_Bool _mountedPreventFirstEquip;
		private gamebbScriptID_Float _ignoreBarbedWireStateEnterTime;
		private gamebbScriptID_Bool _isInLoreAnimationScene;
		private gamebbScriptID_Bool _felled;
		private gamebbScriptID_Bool _isVehicleInTPP;
		private gamebbScriptID_Bool _isDriverCombatInTPP;
		private gamebbScriptID_Int32 _driverCombatWeaponType;
		private gamebbScriptID_Variant _trackedTarget;
		private gamebbScriptID_Vector4 _tPPAimPosition;
		private gamebbScriptID_Int32 _bodySlamBump;
		private gamebbScriptID_Bool _isInBodySlamState;
		private gamebbScriptID_Float _aimInTimeRemaining;
		private gamebbScriptID_Float _aimInTime;
		private gamebbScriptID_Bool _canThrowCarriedNPC;
		private gamebbScriptID_Bool _isWeaponFirstEquip;
		private gamebbScriptID_Bool _isVisualCustomizationPhotomodeVehicleSlotTaken;

		[Ordinal(0)] 
		[RED("Locomotion")] 
		public gamebbScriptID_Int32 Locomotion
		{
			get => GetProperty(ref _locomotion);
			set => SetProperty(ref _locomotion, value);
		}

		[Ordinal(1)] 
		[RED("LocomotionDetailed")] 
		public gamebbScriptID_Int32 LocomotionDetailed
		{
			get => GetProperty(ref _locomotionDetailed);
			set => SetProperty(ref _locomotionDetailed, value);
		}

		[Ordinal(2)] 
		[RED("HighLevel")] 
		public gamebbScriptID_Int32 HighLevel
		{
			get => GetProperty(ref _highLevel);
			set => SetProperty(ref _highLevel, value);
		}

		[Ordinal(3)] 
		[RED("UpperBody")] 
		public gamebbScriptID_Int32 UpperBody
		{
			get => GetProperty(ref _upperBody);
			set => SetProperty(ref _upperBody, value);
		}

		[Ordinal(4)] 
		[RED("TimeDilation")] 
		public gamebbScriptID_Int32 TimeDilation
		{
			get => GetProperty(ref _timeDilation);
			set => SetProperty(ref _timeDilation, value);
		}

		[Ordinal(5)] 
		[RED("Weapon")] 
		public gamebbScriptID_Int32 Weapon
		{
			get => GetProperty(ref _weapon);
			set => SetProperty(ref _weapon, value);
		}

		[Ordinal(6)] 
		[RED("LatestWeaponReloadTime")] 
		public gamebbScriptID_Float LatestWeaponReloadTime
		{
			get => GetProperty(ref _latestWeaponReloadTime);
			set => SetProperty(ref _latestWeaponReloadTime, value);
		}

		[Ordinal(7)] 
		[RED("Melee")] 
		public gamebbScriptID_Int32 Melee
		{
			get => GetProperty(ref _melee);
			set => SetProperty(ref _melee, value);
		}

		[Ordinal(8)] 
		[RED("UI")] 
		public gamebbScriptID_Int32 UI
		{
			get => GetProperty(ref _uI);
			set => SetProperty(ref _uI, value);
		}

		[Ordinal(9)] 
		[RED("Crosshair")] 
		public gamebbScriptID_Int32 Crosshair
		{
			get => GetProperty(ref _crosshair);
			set => SetProperty(ref _crosshair, value);
		}

		[Ordinal(10)] 
		[RED("Reaction")] 
		public gamebbScriptID_Int32 Reaction
		{
			get => GetProperty(ref _reaction);
			set => SetProperty(ref _reaction, value);
		}

		[Ordinal(11)] 
		[RED("Zones")] 
		public gamebbScriptID_Int32 Zones
		{
			get => GetProperty(ref _zones);
			set => SetProperty(ref _zones, value);
		}

		[Ordinal(12)] 
		[RED("SecurityZoneData")] 
		public gamebbScriptID_Variant SecurityZoneData
		{
			get => GetProperty(ref _securityZoneData);
			set => SetProperty(ref _securityZoneData, value);
		}

		[Ordinal(13)] 
		[RED("Vision")] 
		public gamebbScriptID_Int32 Vision
		{
			get => GetProperty(ref _vision);
			set => SetProperty(ref _vision, value);
		}

		[Ordinal(14)] 
		[RED("VisionDebug")] 
		public gamebbScriptID_Int32 VisionDebug
		{
			get => GetProperty(ref _visionDebug);
			set => SetProperty(ref _visionDebug, value);
		}

		[Ordinal(15)] 
		[RED("SceneTier")] 
		public gamebbScriptID_Int32 SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(16)] 
		[RED("CombatGadget")] 
		public gamebbScriptID_Int32 CombatGadget
		{
			get => GetProperty(ref _combatGadget);
			set => SetProperty(ref _combatGadget, value);
		}

		[Ordinal(17)] 
		[RED("LastCombatGadgetUsed")] 
		public gamebbScriptID_Variant LastCombatGadgetUsed
		{
			get => GetProperty(ref _lastCombatGadgetUsed);
			set => SetProperty(ref _lastCombatGadgetUsed, value);
		}

		[Ordinal(18)] 
		[RED("Consumable")] 
		public gamebbScriptID_Int32 Consumable
		{
			get => GetProperty(ref _consumable);
			set => SetProperty(ref _consumable, value);
		}

		[Ordinal(19)] 
		[RED("Vehicle")] 
		public gamebbScriptID_Int32 Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(20)] 
		[RED("MountedToVehicleInDriverSeat")] 
		public gamebbScriptID_Bool MountedToVehicleInDriverSeat
		{
			get => GetProperty(ref _mountedToVehicleInDriverSeat);
			set => SetProperty(ref _mountedToVehicleInDriverSeat, value);
		}

		[Ordinal(21)] 
		[RED("MountedToCombatVehicle")] 
		public gamebbScriptID_Bool MountedToCombatVehicle
		{
			get => GetProperty(ref _mountedToCombatVehicle);
			set => SetProperty(ref _mountedToCombatVehicle, value);
		}

		[Ordinal(22)] 
		[RED("MountedToVehicle")] 
		public gamebbScriptID_Bool MountedToVehicle
		{
			get => GetProperty(ref _mountedToVehicle);
			set => SetProperty(ref _mountedToVehicle, value);
		}

		[Ordinal(23)] 
		[RED("InArmoredVehicle")] 
		public gamebbScriptID_Bool InArmoredVehicle
		{
			get => GetProperty(ref _inArmoredVehicle);
			set => SetProperty(ref _inArmoredVehicle, value);
		}

		[Ordinal(24)] 
		[RED("ZoomLevel")] 
		public gamebbScriptID_Float ZoomLevel
		{
			get => GetProperty(ref _zoomLevel);
			set => SetProperty(ref _zoomLevel, value);
		}

		[Ordinal(25)] 
		[RED("MaxZoomLevel")] 
		public gamebbScriptID_Int32 MaxZoomLevel
		{
			get => GetProperty(ref _maxZoomLevel);
			set => SetProperty(ref _maxZoomLevel, value);
		}

		[Ordinal(26)] 
		[RED("ToggleFireMode")] 
		public gamebbScriptID_Bool ToggleFireMode
		{
			get => GetProperty(ref _toggleFireMode);
			set => SetProperty(ref _toggleFireMode, value);
		}

		[Ordinal(27)] 
		[RED("SwitchWeapon")] 
		public gamebbScriptID_Bool SwitchWeapon
		{
			get => GetProperty(ref _switchWeapon);
			set => SetProperty(ref _switchWeapon, value);
		}

		[Ordinal(28)] 
		[RED("IsDoorInteractionActive")] 
		public gamebbScriptID_Bool IsDoorInteractionActive
		{
			get => GetProperty(ref _isDoorInteractionActive);
			set => SetProperty(ref _isDoorInteractionActive, value);
		}

		[Ordinal(29)] 
		[RED("FinisherTarget")] 
		public gamebbScriptID_EntityID FinisherTarget
		{
			get => GetProperty(ref _finisherTarget);
			set => SetProperty(ref _finisherTarget, value);
		}

		[Ordinal(30)] 
		[RED("IsInteractingWithDevice")] 
		public gamebbScriptID_Bool IsInteractingWithDevice
		{
			get => GetProperty(ref _isInteractingWithDevice);
			set => SetProperty(ref _isInteractingWithDevice, value);
		}

		[Ordinal(31)] 
		[RED("IsInteractingViaPersonalLink")] 
		public gamebbScriptID_Bool IsInteractingViaPersonalLink
		{
			get => GetProperty(ref _isInteractingViaPersonalLink);
			set => SetProperty(ref _isInteractingViaPersonalLink, value);
		}

		[Ordinal(32)] 
		[RED("IsForceOpeningDoor")] 
		public gamebbScriptID_Bool IsForceOpeningDoor
		{
			get => GetProperty(ref _isForceOpeningDoor);
			set => SetProperty(ref _isForceOpeningDoor, value);
		}

		[Ordinal(33)] 
		[RED("IsControllingDevice")] 
		public gamebbScriptID_Bool IsControllingDevice
		{
			get => GetProperty(ref _isControllingDevice);
			set => SetProperty(ref _isControllingDevice, value);
		}

		[Ordinal(34)] 
		[RED("IsControllingCamera")] 
		public gamebbScriptID_Bool IsControllingCamera
		{
			get => GetProperty(ref _isControllingCamera);
			set => SetProperty(ref _isControllingCamera, value);
		}

		[Ordinal(35)] 
		[RED("IsUIZoomDevice")] 
		public gamebbScriptID_Bool IsUIZoomDevice
		{
			get => GetProperty(ref _isUIZoomDevice);
			set => SetProperty(ref _isUIZoomDevice, value);
		}

		[Ordinal(36)] 
		[RED("UIZoomDeviceID")] 
		public gamebbScriptID_EntityID UIZoomDeviceID
		{
			get => GetProperty(ref _uIZoomDeviceID);
			set => SetProperty(ref _uIZoomDeviceID, value);
		}

		[Ordinal(37)] 
		[RED("UseUnarmed")] 
		public gamebbScriptID_Bool UseUnarmed
		{
			get => GetProperty(ref _useUnarmed);
			set => SetProperty(ref _useUnarmed, value);
		}

		[Ordinal(38)] 
		[RED("Berserk")] 
		public gamebbScriptID_Int32 Berserk
		{
			get => GetProperty(ref _berserk);
			set => SetProperty(ref _berserk, value);
		}

		[Ordinal(39)] 
		[RED("ActiveCyberware")] 
		public gamebbScriptID_Int32 ActiveCyberware
		{
			get => GetProperty(ref _activeCyberware);
			set => SetProperty(ref _activeCyberware, value);
		}

		[Ordinal(40)] 
		[RED("Whip")] 
		public gamebbScriptID_Int32 Whip
		{
			get => GetProperty(ref _whip);
			set => SetProperty(ref _whip, value);
		}

		[Ordinal(41)] 
		[RED("DEBUG_SilencedWeapon")] 
		public gamebbScriptID_Bool DEBUG_SilencedWeapon
		{
			get => GetProperty(ref _dEBUG_SilencedWeapon);
			set => SetProperty(ref _dEBUG_SilencedWeapon, value);
		}

		[Ordinal(42)] 
		[RED("LeftHandCyberware")] 
		public gamebbScriptID_Int32 LeftHandCyberware
		{
			get => GetProperty(ref _leftHandCyberware);
			set => SetProperty(ref _leftHandCyberware, value);
		}

		[Ordinal(43)] 
		[RED("UseLeftHand")] 
		public gamebbScriptID_Bool UseLeftHand
		{
			get => GetProperty(ref _useLeftHand);
			set => SetProperty(ref _useLeftHand, value);
		}

		[Ordinal(44)] 
		[RED("MeleeWeapon")] 
		public gamebbScriptID_Int32 MeleeWeapon
		{
			get => GetProperty(ref _meleeWeapon);
			set => SetProperty(ref _meleeWeapon, value);
		}

		[Ordinal(45)] 
		[RED("Carrying")] 
		public gamebbScriptID_Bool Carrying
		{
			get => GetProperty(ref _carrying);
			set => SetProperty(ref _carrying, value);
		}

		[Ordinal(46)] 
		[RED("CarryingDisposal")] 
		public gamebbScriptID_Bool CarryingDisposal
		{
			get => GetProperty(ref _carryingDisposal);
			set => SetProperty(ref _carryingDisposal, value);
		}

		[Ordinal(47)] 
		[RED("CurrentElevator")] 
		public gamebbScriptID_Variant CurrentElevator
		{
			get => GetProperty(ref _currentElevator);
			set => SetProperty(ref _currentElevator, value);
		}

		[Ordinal(48)] 
		[RED("IsPlayerInsideElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideElevator
		{
			get => GetProperty(ref _isPlayerInsideElevator);
			set => SetProperty(ref _isPlayerInsideElevator, value);
		}

		[Ordinal(49)] 
		[RED("IsPlayerInsideMovingElevator")] 
		public gamebbScriptID_Bool IsPlayerInsideMovingElevator
		{
			get => GetProperty(ref _isPlayerInsideMovingElevator);
			set => SetProperty(ref _isPlayerInsideMovingElevator, value);
		}

		[Ordinal(50)] 
		[RED("Combat")] 
		public gamebbScriptID_Int32 Combat
		{
			get => GetProperty(ref _combat);
			set => SetProperty(ref _combat, value);
		}

		[Ordinal(51)] 
		[RED("Stamina")] 
		public gamebbScriptID_Int32 Stamina
		{
			get => GetProperty(ref _stamina);
			set => SetProperty(ref _stamina, value);
		}

		[Ordinal(52)] 
		[RED("Vitals")] 
		public gamebbScriptID_Int32 Vitals
		{
			get => GetProperty(ref _vitals);
			set => SetProperty(ref _vitals, value);
		}

		[Ordinal(53)] 
		[RED("Takedown")] 
		public gamebbScriptID_Int32 Takedown
		{
			get => GetProperty(ref _takedown);
			set => SetProperty(ref _takedown, value);
		}

		[Ordinal(54)] 
		[RED("TakedownTargetID")] 
		public gamebbScriptID_EntityID TakedownTargetID
		{
			get => GetProperty(ref _takedownTargetID);
			set => SetProperty(ref _takedownTargetID, value);
		}

		[Ordinal(55)] 
		[RED("Fall")] 
		public gamebbScriptID_Int32 Fall
		{
			get => GetProperty(ref _fall);
			set => SetProperty(ref _fall, value);
		}

		[Ordinal(56)] 
		[RED("Landing")] 
		public gamebbScriptID_Int32 Landing
		{
			get => GetProperty(ref _landing);
			set => SetProperty(ref _landing, value);
		}

		[Ordinal(57)] 
		[RED("UsingCover")] 
		public gamebbScriptID_Bool UsingCover
		{
			get => GetProperty(ref _usingCover);
			set => SetProperty(ref _usingCover, value);
		}

		[Ordinal(58)] 
		[RED("IsInMinigame")] 
		public gamebbScriptID_Bool IsInMinigame
		{
			get => GetProperty(ref _isInMinigame);
			set => SetProperty(ref _isInMinigame, value);
		}

		[Ordinal(59)] 
		[RED("UploadingQuickHackIDs")] 
		public gamebbScriptID_Variant UploadingQuickHackIDs
		{
			get => GetProperty(ref _uploadingQuickHackIDs);
			set => SetProperty(ref _uploadingQuickHackIDs, value);
		}

		[Ordinal(60)] 
		[RED("CostFreeActionID")] 
		public gamebbScriptID_Variant CostFreeActionID
		{
			get => GetProperty(ref _costFreeActionID);
			set => SetProperty(ref _costFreeActionID, value);
		}

		[Ordinal(61)] 
		[RED("AmountOfCostFreeActions")] 
		public gamebbScriptID_Int32 AmountOfCostFreeActions
		{
			get => GetProperty(ref _amountOfCostFreeActions);
			set => SetProperty(ref _amountOfCostFreeActions, value);
		}

		[Ordinal(62)] 
		[RED("MeleeSpreadableQuickhackActionID")] 
		public gamebbScriptID_Variant MeleeSpreadableQuickhackActionID
		{
			get => GetProperty(ref _meleeSpreadableQuickhackActionID);
			set => SetProperty(ref _meleeSpreadableQuickhackActionID, value);
		}

		[Ordinal(63)] 
		[RED("EntityIDTargetingPlayer")] 
		public gamebbScriptID_EntityID EntityIDTargetingPlayer
		{
			get => GetProperty(ref _entityIDTargetingPlayer);
			set => SetProperty(ref _entityIDTargetingPlayer, value);
		}

		[Ordinal(64)] 
		[RED("EntityIDVehicleRemoteControlled")] 
		public gamebbScriptID_EntityID EntityIDVehicleRemoteControlled
		{
			get => GetProperty(ref _entityIDVehicleRemoteControlled);
			set => SetProperty(ref _entityIDVehicleRemoteControlled, value);
		}

		[Ordinal(65)] 
		[RED("IsVehicleRemoteControlCameraTPP")] 
		public gamebbScriptID_Bool IsVehicleRemoteControlCameraTPP
		{
			get => GetProperty(ref _isVehicleRemoteControlCameraTPP);
			set => SetProperty(ref _isVehicleRemoteControlCameraTPP, value);
		}

		[Ordinal(66)] 
		[RED("Swimming")] 
		public gamebbScriptID_Int32 Swimming
		{
			get => GetProperty(ref _swimming);
			set => SetProperty(ref _swimming, value);
		}

		[Ordinal(67)] 
		[RED("BodyCarrying")] 
		public gamebbScriptID_Int32 BodyCarrying
		{
			get => GetProperty(ref _bodyCarrying);
			set => SetProperty(ref _bodyCarrying, value);
		}

		[Ordinal(68)] 
		[RED("BodyDisposalDetailed")] 
		public gamebbScriptID_Int32 BodyDisposalDetailed
		{
			get => GetProperty(ref _bodyDisposalDetailed);
			set => SetProperty(ref _bodyDisposalDetailed, value);
		}

		[Ordinal(69)] 
		[RED("DisplayDeathMenu")] 
		public gamebbScriptID_Bool DisplayDeathMenu
		{
			get => GetProperty(ref _displayDeathMenu);
			set => SetProperty(ref _displayDeathMenu, value);
		}

		[Ordinal(70)] 
		[RED("OverrideQuickHackPanelDilation")] 
		public gamebbScriptID_Bool OverrideQuickHackPanelDilation
		{
			get => GetProperty(ref _overrideQuickHackPanelDilation);
			set => SetProperty(ref _overrideQuickHackPanelDilation, value);
		}

		[Ordinal(71)] 
		[RED("NanoWireLaunchMode")] 
		public gamebbScriptID_Int32 NanoWireLaunchMode
		{
			get => GetProperty(ref _nanoWireLaunchMode);
			set => SetProperty(ref _nanoWireLaunchMode, value);
		}

		[Ordinal(72)] 
		[RED("IsMovingHorizontally")] 
		public gamebbScriptID_Bool IsMovingHorizontally
		{
			get => GetProperty(ref _isMovingHorizontally);
			set => SetProperty(ref _isMovingHorizontally, value);
		}

		[Ordinal(73)] 
		[RED("IsMovingVertically")] 
		public gamebbScriptID_Bool IsMovingVertically
		{
			get => GetProperty(ref _isMovingVertically);
			set => SetProperty(ref _isMovingVertically, value);
		}

		[Ordinal(74)] 
		[RED("IsOnGround")] 
		public gamebbScriptID_Bool IsOnGround
		{
			get => GetProperty(ref _isOnGround);
			set => SetProperty(ref _isOnGround, value);
		}

		[Ordinal(75)] 
		[RED("MinElevation")] 
		public gamebbScriptID_Float MinElevation
		{
			get => GetProperty(ref _minElevation);
			set => SetProperty(ref _minElevation, value);
		}

		[Ordinal(76)] 
		[RED("MaxElevation")] 
		public gamebbScriptID_Float MaxElevation
		{
			get => GetProperty(ref _maxElevation);
			set => SetProperty(ref _maxElevation, value);
		}

		[Ordinal(77)] 
		[RED("ActionRestriction")] 
		public gamebbScriptID_Variant ActionRestriction
		{
			get => GetProperty(ref _actionRestriction);
			set => SetProperty(ref _actionRestriction, value);
		}

		[Ordinal(78)] 
		[RED("MeleeLeap")] 
		public gamebbScriptID_Bool MeleeLeap
		{
			get => GetProperty(ref _meleeLeap);
			set => SetProperty(ref _meleeLeap, value);
		}

		[Ordinal(79)] 
		[RED("IsInWorkspot")] 
		public gamebbScriptID_Int32 IsInWorkspot
		{
			get => GetProperty(ref _isInWorkspot);
			set => SetProperty(ref _isInWorkspot, value);
		}

		[Ordinal(80)] 
		[RED("QuestForceShoot")] 
		public gamebbScriptID_Bool QuestForceShoot
		{
			get => GetProperty(ref _questForceShoot);
			set => SetProperty(ref _questForceShoot, value);
		}

		[Ordinal(81)] 
		[RED("LadderCameraParams")] 
		public gamebbScriptID_Int32 LadderCameraParams
		{
			get => GetProperty(ref _ladderCameraParams);
			set => SetProperty(ref _ladderCameraParams, value);
		}

		[Ordinal(82)] 
		[RED("DodgeTimeStamp")] 
		public gamebbScriptID_Float DodgeTimeStamp
		{
			get => GetProperty(ref _dodgeTimeStamp);
			set => SetProperty(ref _dodgeTimeStamp, value);
		}

		[Ordinal(83)] 
		[RED("CanOnePunch")] 
		public gamebbScriptID_Bool CanOnePunch
		{
			get => GetProperty(ref _canOnePunch);
			set => SetProperty(ref _canOnePunch, value);
		}

		[Ordinal(84)] 
		[RED("HasSmartGunLockedOnTarget")] 
		public gamebbScriptID_Bool HasSmartGunLockedOnTarget
		{
			get => GetProperty(ref _hasSmartGunLockedOnTarget);
			set => SetProperty(ref _hasSmartGunLockedOnTarget, value);
		}

		[Ordinal(85)] 
		[RED("SceneAimForced")] 
		public gamebbScriptID_Bool SceneAimForced
		{
			get => GetProperty(ref _sceneAimForced);
			set => SetProperty(ref _sceneAimForced, value);
		}

		[Ordinal(86)] 
		[RED("SceneSafeForced")] 
		public gamebbScriptID_Bool SceneSafeForced
		{
			get => GetProperty(ref _sceneSafeForced);
			set => SetProperty(ref _sceneSafeForced, value);
		}

		[Ordinal(87)] 
		[RED("SceneWeaponLoweringSpeedOverride")] 
		public gamebbScriptID_Float SceneWeaponLoweringSpeedOverride
		{
			get => GetProperty(ref _sceneWeaponLoweringSpeedOverride);
			set => SetProperty(ref _sceneWeaponLoweringSpeedOverride, value);
		}

		[Ordinal(88)] 
		[RED("ScenePreventFirstEquip")] 
		public gamebbScriptID_Bool ScenePreventFirstEquip
		{
			get => GetProperty(ref _scenePreventFirstEquip);
			set => SetProperty(ref _scenePreventFirstEquip, value);
		}

		[Ordinal(89)] 
		[RED("MountedPreventFirstEquip")] 
		public gamebbScriptID_Bool MountedPreventFirstEquip
		{
			get => GetProperty(ref _mountedPreventFirstEquip);
			set => SetProperty(ref _mountedPreventFirstEquip, value);
		}

		[Ordinal(90)] 
		[RED("IgnoreBarbedWireStateEnterTime")] 
		public gamebbScriptID_Float IgnoreBarbedWireStateEnterTime
		{
			get => GetProperty(ref _ignoreBarbedWireStateEnterTime);
			set => SetProperty(ref _ignoreBarbedWireStateEnterTime, value);
		}

		[Ordinal(91)] 
		[RED("IsInLoreAnimationScene")] 
		public gamebbScriptID_Bool IsInLoreAnimationScene
		{
			get => GetProperty(ref _isInLoreAnimationScene);
			set => SetProperty(ref _isInLoreAnimationScene, value);
		}

		[Ordinal(92)] 
		[RED("Felled")] 
		public gamebbScriptID_Bool Felled
		{
			get => GetProperty(ref _felled);
			set => SetProperty(ref _felled, value);
		}

		[Ordinal(93)] 
		[RED("IsVehicleInTPP")] 
		public gamebbScriptID_Bool IsVehicleInTPP
		{
			get => GetProperty(ref _isVehicleInTPP);
			set => SetProperty(ref _isVehicleInTPP, value);
		}

		[Ordinal(94)] 
		[RED("IsDriverCombatInTPP")] 
		public gamebbScriptID_Bool IsDriverCombatInTPP
		{
			get => GetProperty(ref _isDriverCombatInTPP);
			set => SetProperty(ref _isDriverCombatInTPP, value);
		}

		[Ordinal(95)] 
		[RED("DriverCombatWeaponType")] 
		public gamebbScriptID_Int32 DriverCombatWeaponType
		{
			get => GetProperty(ref _driverCombatWeaponType);
			set => SetProperty(ref _driverCombatWeaponType, value);
		}

		[Ordinal(96)] 
		[RED("TrackedTarget")] 
		public gamebbScriptID_Variant TrackedTarget
		{
			get => GetProperty(ref _trackedTarget);
			set => SetProperty(ref _trackedTarget, value);
		}

		[Ordinal(97)] 
		[RED("TPPAimPosition")] 
		public gamebbScriptID_Vector4 TPPAimPosition
		{
			get => GetProperty(ref _tPPAimPosition);
			set => SetProperty(ref _tPPAimPosition, value);
		}

		[Ordinal(98)] 
		[RED("BodySlamBump")] 
		public gamebbScriptID_Int32 BodySlamBump
		{
			get => GetProperty(ref _bodySlamBump);
			set => SetProperty(ref _bodySlamBump, value);
		}

		[Ordinal(99)] 
		[RED("IsInBodySlamState")] 
		public gamebbScriptID_Bool IsInBodySlamState
		{
			get => GetProperty(ref _isInBodySlamState);
			set => SetProperty(ref _isInBodySlamState, value);
		}

		[Ordinal(100)] 
		[RED("AimInTimeRemaining")] 
		public gamebbScriptID_Float AimInTimeRemaining
		{
			get => GetProperty(ref _aimInTimeRemaining);
			set => SetProperty(ref _aimInTimeRemaining, value);
		}

		[Ordinal(101)] 
		[RED("AimInTime")] 
		public gamebbScriptID_Float AimInTime
		{
			get => GetProperty(ref _aimInTime);
			set => SetProperty(ref _aimInTime, value);
		}

		[Ordinal(102)] 
		[RED("CanThrowCarriedNPC")] 
		public gamebbScriptID_Bool CanThrowCarriedNPC
		{
			get => GetProperty(ref _canThrowCarriedNPC);
			set => SetProperty(ref _canThrowCarriedNPC, value);
		}

		[Ordinal(103)] 
		[RED("IsWeaponFirstEquip")] 
		public gamebbScriptID_Bool IsWeaponFirstEquip
		{
			get => GetProperty(ref _isWeaponFirstEquip);
			set => SetProperty(ref _isWeaponFirstEquip, value);
		}

		[Ordinal(104)] 
		[RED("IsVisualCustomizationPhotomodeVehicleSlotTaken")] 
		public gamebbScriptID_Bool IsVisualCustomizationPhotomodeVehicleSlotTaken
		{
			get => GetProperty(ref _isVisualCustomizationPhotomodeVehicleSlotTaken);
			set => SetProperty(ref _isVisualCustomizationPhotomodeVehicleSlotTaken, value);
		}

		public PlayerStateMachineDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
