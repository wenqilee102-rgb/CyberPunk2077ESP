using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerPuppet : ScriptedPuppet
	{
		private CHandle<QuickSlotsManager> _quickSlotsManager;
		private CHandle<InspectionComponent> _inspectionComponent;
		private CHandle<gameEnvironmentDamageReceiverComponent> _enviroDamageRcvComponent;
		private wCHandle<vehicleBaseObject> _mountedVehicle;
		private CFloat _vehicleKnockdownTimestamp;
		private CHandle<PlayerPhone> _phone;
		private CHandle<gameFPPCameraComponent> _fppCameraComponent;
		private CHandle<gameTargetingComponent> _primaryTargetingComponent;
		private CHandle<gameBreachFinderComponent> _breachFinderComponent;
		private CHandle<gameChaseSpawnComponent> _chaseSpawnComponent;
		private CBool _isInFinisher;
		private CHandle<DEBUG_VisualizerComponent> _dEBUG_Visualizer;
		private CHandle<DEBUG_DamageInputReceiver> _debug_DamageInputRec;
		private CFloat _highDamageThreshold;
		private CFloat _medDamageThreshold;
		private CFloat _lowDamageThreshold;
		private CFloat _meleeHighDamageThreshold;
		private CFloat _meleeMedDamageThreshold;
		private CFloat _meleeLowDamageThreshold;
		private CFloat _explosionHighDamageThreshold;
		private CFloat _explosionMedDamageThreshold;
		private CFloat _explosionLowDamageThreshold;
		private CFloat _effectTimeStamp;
		private CFloat _curInventoryWeight;
		private CHandle<worldEffectBlackboard> _healthVfxBlackboard;
		private CHandle<worldEffectBlackboard> _laserTargettingVfxBlackboard;
		private wCHandle<gameIBlackboard> _itemLogBlackboard;
		private CHandle<redCallbackObject> _interactionDataListener;
		private CHandle<redCallbackObject> _popupIsModalListener;
		private CHandle<redCallbackObject> _uiVendorContextListener;
		private CHandle<redCallbackObject> _uiRadialContextistener;
		private CHandle<redCallbackObject> _contactsActiveListener;
		private CHandle<redCallbackObject> _smsMessengerActiveListener;
		private CHandle<redCallbackObject> _currentVisibleTargetListener;
		private wCHandle<gameObject> _lastScanTarget;
		private CBool _meleeSelectInputProcessed;
		private CBool _waitingForDelayEvent;
		private CFloat _randomizedTime;
		private CBool _isResetting;
		private gameDelayID _delayEventID;
		private gameDelayID _resetTickID;
		private CFloat _katanaAnimProgression;
		private CBool _coverModifierActive;
		private CBool _workspotDamageReductionActive;
		private CBool _workspotVisibilityReductionActive;
		private CArray<CName> _currentPlayerWorkspotTags;
		private CBool _incapacitated;
		private gameNewMappinID _remoteMappinId;
		private CHandle<CPOMissionDataState> _cPOMissionDataState;
		private CHandle<redCallbackObject> _cPOMissionDataBbId;
		private CHandle<VisibilityStatListener> _visibilityListener;
		private CHandle<SecondHeartStatListener> _secondHeartListener;
		private CHandle<ArmorStatListener> _armorStatListener;
		private CHandle<HealthStatListener> _healthStatListener;
		private CHandle<OxygenStatListener> _oxygenStatListener;
		private CHandle<AimAssistSettingsListener> _aimAssistListener;
		private CHandle<AutoRevealStatListener> _autoRevealListener;
		private CHandle<PlayerPuppetAllStatListener> _allStatsListener;
		private CHandle<gameAttachmentSlotsScriptListener> _rightHandAttachmentSlotListener;
		private CHandle<HealingItemsChargeStatListener> _healingItemsChargeStatListener;
		private CHandle<GrenadesChargeStatListener> _grenadesChargeStatListener;
		private CHandle<ProjectileLauncherChargeStatListener> _projectileLauncherChargeStatListener;
		private CHandle<OpticalCamoChargeStatListener> _opticalCamoChargeStatListener;
		private CHandle<OverclockChargeListener> _overclockChargeListener;
		private CHandle<AccessibilityControlsListener> _accessibilityControlsListener;
		private CBool _isTalkingOnPhone;
		private gameDelayID _dataDamageUpdateID;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CArray<CHandle<redCallbackObject>> _callbackHandles;
		private CInt32 _numberOfCombatants;
		private CName _equipmentMeshOverlayEffectName;
		private CName _equipmentMeshOverlayEffectTag;
		private CArray<TweakDBID> _equipmentMeshOverlaySlots;
		private CBool _coverVisibilityPerkBlocked;
		private CBool _behindCover;
		private CBool _inCombat;
		private CBool _isBeingRevealed;
		private CBool _hasBeenDetected;
		private CBool _inCrouch;
		private CBool _hasKiroshiOpticsFragment;
		private CBool _doingQuickMelee;
		private CEnum<gamePSMVehicle> _vehicleState;
		private CBool _inMountedWeaponVehicle;
		private CBool _inDriverCombatTPP;
		private CEnum<gamedataItemType> _driverCombatWeaponType;
		private CBool _isAiming;
		private CBool _focusModeActive;
		private CBool _customFastForwardPossible;
		private wCHandle<gameweaponObject> _equippedRightHandWeapon;
		private CBool _aimAssistUpdateQueued;
		private CInt32 _locomotionState;
		private CInt32 _leftHandCyberwareState;
		private CInt32 _meleeWeaponState;
		private CFloat _weaponZoomLevel;
		private entEntityID _controllingDeviceID;
		private CFloat _gunshotRange;
		private CFloat _explosionRange;
		private CBool _isInBodySlam;
		private CInt32 _combatGadgetState;
		private CEnum<GameplayTier> _sceneTier;
		private CInt32 _nextBufferModifier;
		private entEntityID _attackingNetrunnerID;
		private wCHandle<NPCPuppet> _nPCDeathInstigator;
		private wCHandle<gameweaponObject> _bestTargettingWeapon;
		private CFloat _bestTargettingDot;
		private CInt32 _targettingEnemies;
		private CBool _isAimingAtFriendly;
		private CBool _isAimingAtChild;
		private CFloat _distanceFromTargetSquared;
		private TweakDBID _coverRecordID;
		private TweakDBID _damageReductionRecordID;
		private TweakDBID _visReductionRecordID;
		private EngineTime _lastDmgInflicted;
		private CBool _critHealthRumblePlayed;
		private gameDelayID _critHealthRumbleDurationID;
		private CFloat _lastHealthUpdate;
		private CHandle<StaminaListener> _staminaListener;
		private CHandle<MemoryListener> _memoryListener;
		private CEnum<ESecurityAreaType> _securityAreaTypeE3HACK;
		private CArray<gamePersistentID> _overlappedSecurityZones;
		private InterestingFacts _interestingFacts;
		private InterestingFactsListenersIds _interestingFactsListenersIds;
		private InterestingFactsListenersFunctions _interestingFactsListenersFunctions;
		private CHandle<PlayerVisionModeController> _visionModeController;
		private CHandle<PlayerCombatController> _combatController;
		private CHandle<PlayerWeaponHandlingModifiers> _handlingModifiers;
		private CArray<TweakDBID> _cachedGameplayRestrictions;
		private gameDelayID _delayEndGracePeriodAfterSpawnEventID;
		private CBool _cWMaskInVehicleInputHeld;
		private ScriptReentrantRWLock _friendlyDevicesHostileToEnemiesLock;
		private CArray<entEntityID> _friendlyDevicesHostileToEnemies;
		private CHandle<PocketRadio> _pocketRadio;
		private CArray<CHandle<gameStatModifierData_Deprecated>> _noMovementModifierData;
		private CArray<FactCallbackData> _registeredFactListeners;
		private entEntityID _bossThatTargetsPlayer;
		private CUInt32 _choiceTokenTextLayerId;
		private CBool _choiceTokenTextDrawn;

		[Ordinal(101)] 
		[RED("quickSlotsManager")] 
		public CHandle<QuickSlotsManager> QuickSlotsManager
		{
			get => GetProperty(ref _quickSlotsManager);
			set => SetProperty(ref _quickSlotsManager, value);
		}

		[Ordinal(102)] 
		[RED("inspectionComponent")] 
		public CHandle<InspectionComponent> InspectionComponent
		{
			get => GetProperty(ref _inspectionComponent);
			set => SetProperty(ref _inspectionComponent, value);
		}

		[Ordinal(103)] 
		[RED("enviroDamageRcvComponent")] 
		public CHandle<gameEnvironmentDamageReceiverComponent> EnviroDamageRcvComponent
		{
			get => GetProperty(ref _enviroDamageRcvComponent);
			set => SetProperty(ref _enviroDamageRcvComponent, value);
		}

		[Ordinal(104)] 
		[RED("mountedVehicle")] 
		public wCHandle<vehicleBaseObject> MountedVehicle
		{
			get => GetProperty(ref _mountedVehicle);
			set => SetProperty(ref _mountedVehicle, value);
		}

		[Ordinal(105)] 
		[RED("vehicleKnockdownTimestamp")] 
		public CFloat VehicleKnockdownTimestamp
		{
			get => GetProperty(ref _vehicleKnockdownTimestamp);
			set => SetProperty(ref _vehicleKnockdownTimestamp, value);
		}

		[Ordinal(106)] 
		[RED("Phone")] 
		public CHandle<PlayerPhone> Phone
		{
			get => GetProperty(ref _phone);
			set => SetProperty(ref _phone, value);
		}

		[Ordinal(107)] 
		[RED("fppCameraComponent")] 
		public CHandle<gameFPPCameraComponent> FppCameraComponent
		{
			get => GetProperty(ref _fppCameraComponent);
			set => SetProperty(ref _fppCameraComponent, value);
		}

		[Ordinal(108)] 
		[RED("primaryTargetingComponent")] 
		public CHandle<gameTargetingComponent> PrimaryTargetingComponent
		{
			get => GetProperty(ref _primaryTargetingComponent);
			set => SetProperty(ref _primaryTargetingComponent, value);
		}

		[Ordinal(109)] 
		[RED("breachFinderComponent")] 
		public CHandle<gameBreachFinderComponent> BreachFinderComponent
		{
			get => GetProperty(ref _breachFinderComponent);
			set => SetProperty(ref _breachFinderComponent, value);
		}

		[Ordinal(110)] 
		[RED("chaseSpawnComponent")] 
		public CHandle<gameChaseSpawnComponent> ChaseSpawnComponent
		{
			get => GetProperty(ref _chaseSpawnComponent);
			set => SetProperty(ref _chaseSpawnComponent, value);
		}

		[Ordinal(111)] 
		[RED("isInFinisher")] 
		public CBool IsInFinisher
		{
			get => GetProperty(ref _isInFinisher);
			set => SetProperty(ref _isInFinisher, value);
		}

		[Ordinal(112)] 
		[RED("DEBUG_Visualizer")] 
		public CHandle<DEBUG_VisualizerComponent> DEBUG_Visualizer
		{
			get => GetProperty(ref _dEBUG_Visualizer);
			set => SetProperty(ref _dEBUG_Visualizer, value);
		}

		[Ordinal(113)] 
		[RED("Debug_DamageInputRec")] 
		public CHandle<DEBUG_DamageInputReceiver> Debug_DamageInputRec
		{
			get => GetProperty(ref _debug_DamageInputRec);
			set => SetProperty(ref _debug_DamageInputRec, value);
		}

		[Ordinal(114)] 
		[RED("highDamageThreshold")] 
		public CFloat HighDamageThreshold
		{
			get => GetProperty(ref _highDamageThreshold);
			set => SetProperty(ref _highDamageThreshold, value);
		}

		[Ordinal(115)] 
		[RED("medDamageThreshold")] 
		public CFloat MedDamageThreshold
		{
			get => GetProperty(ref _medDamageThreshold);
			set => SetProperty(ref _medDamageThreshold, value);
		}

		[Ordinal(116)] 
		[RED("lowDamageThreshold")] 
		public CFloat LowDamageThreshold
		{
			get => GetProperty(ref _lowDamageThreshold);
			set => SetProperty(ref _lowDamageThreshold, value);
		}

		[Ordinal(117)] 
		[RED("meleeHighDamageThreshold")] 
		public CFloat MeleeHighDamageThreshold
		{
			get => GetProperty(ref _meleeHighDamageThreshold);
			set => SetProperty(ref _meleeHighDamageThreshold, value);
		}

		[Ordinal(118)] 
		[RED("meleeMedDamageThreshold")] 
		public CFloat MeleeMedDamageThreshold
		{
			get => GetProperty(ref _meleeMedDamageThreshold);
			set => SetProperty(ref _meleeMedDamageThreshold, value);
		}

		[Ordinal(119)] 
		[RED("meleeLowDamageThreshold")] 
		public CFloat MeleeLowDamageThreshold
		{
			get => GetProperty(ref _meleeLowDamageThreshold);
			set => SetProperty(ref _meleeLowDamageThreshold, value);
		}

		[Ordinal(120)] 
		[RED("explosionHighDamageThreshold")] 
		public CFloat ExplosionHighDamageThreshold
		{
			get => GetProperty(ref _explosionHighDamageThreshold);
			set => SetProperty(ref _explosionHighDamageThreshold, value);
		}

		[Ordinal(121)] 
		[RED("explosionMedDamageThreshold")] 
		public CFloat ExplosionMedDamageThreshold
		{
			get => GetProperty(ref _explosionMedDamageThreshold);
			set => SetProperty(ref _explosionMedDamageThreshold, value);
		}

		[Ordinal(122)] 
		[RED("explosionLowDamageThreshold")] 
		public CFloat ExplosionLowDamageThreshold
		{
			get => GetProperty(ref _explosionLowDamageThreshold);
			set => SetProperty(ref _explosionLowDamageThreshold, value);
		}

		[Ordinal(123)] 
		[RED("effectTimeStamp")] 
		public CFloat EffectTimeStamp
		{
			get => GetProperty(ref _effectTimeStamp);
			set => SetProperty(ref _effectTimeStamp, value);
		}

		[Ordinal(124)] 
		[RED("curInventoryWeight")] 
		public CFloat CurInventoryWeight
		{
			get => GetProperty(ref _curInventoryWeight);
			set => SetProperty(ref _curInventoryWeight, value);
		}

		[Ordinal(125)] 
		[RED("healthVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> HealthVfxBlackboard
		{
			get => GetProperty(ref _healthVfxBlackboard);
			set => SetProperty(ref _healthVfxBlackboard, value);
		}

		[Ordinal(126)] 
		[RED("laserTargettingVfxBlackboard")] 
		public CHandle<worldEffectBlackboard> LaserTargettingVfxBlackboard
		{
			get => GetProperty(ref _laserTargettingVfxBlackboard);
			set => SetProperty(ref _laserTargettingVfxBlackboard, value);
		}

		[Ordinal(127)] 
		[RED("itemLogBlackboard")] 
		public wCHandle<gameIBlackboard> ItemLogBlackboard
		{
			get => GetProperty(ref _itemLogBlackboard);
			set => SetProperty(ref _itemLogBlackboard, value);
		}

		[Ordinal(128)] 
		[RED("interactionDataListener")] 
		public CHandle<redCallbackObject> InteractionDataListener
		{
			get => GetProperty(ref _interactionDataListener);
			set => SetProperty(ref _interactionDataListener, value);
		}

		[Ordinal(129)] 
		[RED("popupIsModalListener")] 
		public CHandle<redCallbackObject> PopupIsModalListener
		{
			get => GetProperty(ref _popupIsModalListener);
			set => SetProperty(ref _popupIsModalListener, value);
		}

		[Ordinal(130)] 
		[RED("uiVendorContextListener")] 
		public CHandle<redCallbackObject> UiVendorContextListener
		{
			get => GetProperty(ref _uiVendorContextListener);
			set => SetProperty(ref _uiVendorContextListener, value);
		}

		[Ordinal(131)] 
		[RED("uiRadialContextistener")] 
		public CHandle<redCallbackObject> UiRadialContextistener
		{
			get => GetProperty(ref _uiRadialContextistener);
			set => SetProperty(ref _uiRadialContextistener, value);
		}

		[Ordinal(132)] 
		[RED("contactsActiveListener")] 
		public CHandle<redCallbackObject> ContactsActiveListener
		{
			get => GetProperty(ref _contactsActiveListener);
			set => SetProperty(ref _contactsActiveListener, value);
		}

		[Ordinal(133)] 
		[RED("smsMessengerActiveListener")] 
		public CHandle<redCallbackObject> SmsMessengerActiveListener
		{
			get => GetProperty(ref _smsMessengerActiveListener);
			set => SetProperty(ref _smsMessengerActiveListener, value);
		}

		[Ordinal(134)] 
		[RED("currentVisibleTargetListener")] 
		public CHandle<redCallbackObject> CurrentVisibleTargetListener
		{
			get => GetProperty(ref _currentVisibleTargetListener);
			set => SetProperty(ref _currentVisibleTargetListener, value);
		}

		[Ordinal(135)] 
		[RED("lastScanTarget")] 
		public wCHandle<gameObject> LastScanTarget
		{
			get => GetProperty(ref _lastScanTarget);
			set => SetProperty(ref _lastScanTarget, value);
		}

		[Ordinal(136)] 
		[RED("meleeSelectInputProcessed")] 
		public CBool MeleeSelectInputProcessed
		{
			get => GetProperty(ref _meleeSelectInputProcessed);
			set => SetProperty(ref _meleeSelectInputProcessed, value);
		}

		[Ordinal(137)] 
		[RED("waitingForDelayEvent")] 
		public CBool WaitingForDelayEvent
		{
			get => GetProperty(ref _waitingForDelayEvent);
			set => SetProperty(ref _waitingForDelayEvent, value);
		}

		[Ordinal(138)] 
		[RED("randomizedTime")] 
		public CFloat RandomizedTime
		{
			get => GetProperty(ref _randomizedTime);
			set => SetProperty(ref _randomizedTime, value);
		}

		[Ordinal(139)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetProperty(ref _isResetting);
			set => SetProperty(ref _isResetting, value);
		}

		[Ordinal(140)] 
		[RED("delayEventID")] 
		public gameDelayID DelayEventID
		{
			get => GetProperty(ref _delayEventID);
			set => SetProperty(ref _delayEventID, value);
		}

		[Ordinal(141)] 
		[RED("resetTickID")] 
		public gameDelayID ResetTickID
		{
			get => GetProperty(ref _resetTickID);
			set => SetProperty(ref _resetTickID, value);
		}

		[Ordinal(142)] 
		[RED("katanaAnimProgression")] 
		public CFloat KatanaAnimProgression
		{
			get => GetProperty(ref _katanaAnimProgression);
			set => SetProperty(ref _katanaAnimProgression, value);
		}

		[Ordinal(143)] 
		[RED("coverModifierActive")] 
		public CBool CoverModifierActive
		{
			get => GetProperty(ref _coverModifierActive);
			set => SetProperty(ref _coverModifierActive, value);
		}

		[Ordinal(144)] 
		[RED("workspotDamageReductionActive")] 
		public CBool WorkspotDamageReductionActive
		{
			get => GetProperty(ref _workspotDamageReductionActive);
			set => SetProperty(ref _workspotDamageReductionActive, value);
		}

		[Ordinal(145)] 
		[RED("workspotVisibilityReductionActive")] 
		public CBool WorkspotVisibilityReductionActive
		{
			get => GetProperty(ref _workspotVisibilityReductionActive);
			set => SetProperty(ref _workspotVisibilityReductionActive, value);
		}

		[Ordinal(146)] 
		[RED("currentPlayerWorkspotTags")] 
		public CArray<CName> CurrentPlayerWorkspotTags
		{
			get => GetProperty(ref _currentPlayerWorkspotTags);
			set => SetProperty(ref _currentPlayerWorkspotTags, value);
		}

		[Ordinal(147)] 
		[RED("incapacitated")] 
		public CBool Incapacitated
		{
			get => GetProperty(ref _incapacitated);
			set => SetProperty(ref _incapacitated, value);
		}

		[Ordinal(148)] 
		[RED("remoteMappinId")] 
		public gameNewMappinID RemoteMappinId
		{
			get => GetProperty(ref _remoteMappinId);
			set => SetProperty(ref _remoteMappinId, value);
		}

		[Ordinal(149)] 
		[RED("CPOMissionDataState")] 
		public CHandle<CPOMissionDataState> CPOMissionDataState
		{
			get => GetProperty(ref _cPOMissionDataState);
			set => SetProperty(ref _cPOMissionDataState, value);
		}

		[Ordinal(150)] 
		[RED("CPOMissionDataBbId")] 
		public CHandle<redCallbackObject> CPOMissionDataBbId
		{
			get => GetProperty(ref _cPOMissionDataBbId);
			set => SetProperty(ref _cPOMissionDataBbId, value);
		}

		[Ordinal(151)] 
		[RED("visibilityListener")] 
		public CHandle<VisibilityStatListener> VisibilityListener
		{
			get => GetProperty(ref _visibilityListener);
			set => SetProperty(ref _visibilityListener, value);
		}

		[Ordinal(152)] 
		[RED("secondHeartListener")] 
		public CHandle<SecondHeartStatListener> SecondHeartListener
		{
			get => GetProperty(ref _secondHeartListener);
			set => SetProperty(ref _secondHeartListener, value);
		}

		[Ordinal(153)] 
		[RED("armorStatListener")] 
		public CHandle<ArmorStatListener> ArmorStatListener
		{
			get => GetProperty(ref _armorStatListener);
			set => SetProperty(ref _armorStatListener, value);
		}

		[Ordinal(154)] 
		[RED("healthStatListener")] 
		public CHandle<HealthStatListener> HealthStatListener
		{
			get => GetProperty(ref _healthStatListener);
			set => SetProperty(ref _healthStatListener, value);
		}

		[Ordinal(155)] 
		[RED("oxygenStatListener")] 
		public CHandle<OxygenStatListener> OxygenStatListener
		{
			get => GetProperty(ref _oxygenStatListener);
			set => SetProperty(ref _oxygenStatListener, value);
		}

		[Ordinal(156)] 
		[RED("aimAssistListener")] 
		public CHandle<AimAssistSettingsListener> AimAssistListener
		{
			get => GetProperty(ref _aimAssistListener);
			set => SetProperty(ref _aimAssistListener, value);
		}

		[Ordinal(157)] 
		[RED("autoRevealListener")] 
		public CHandle<AutoRevealStatListener> AutoRevealListener
		{
			get => GetProperty(ref _autoRevealListener);
			set => SetProperty(ref _autoRevealListener, value);
		}

		[Ordinal(158)] 
		[RED("allStatsListener")] 
		public CHandle<PlayerPuppetAllStatListener> AllStatsListener
		{
			get => GetProperty(ref _allStatsListener);
			set => SetProperty(ref _allStatsListener, value);
		}

		[Ordinal(159)] 
		[RED("rightHandAttachmentSlotListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> RightHandAttachmentSlotListener
		{
			get => GetProperty(ref _rightHandAttachmentSlotListener);
			set => SetProperty(ref _rightHandAttachmentSlotListener, value);
		}

		[Ordinal(160)] 
		[RED("HealingItemsChargeStatListener")] 
		public CHandle<HealingItemsChargeStatListener> HealingItemsChargeStatListener
		{
			get => GetProperty(ref _healingItemsChargeStatListener);
			set => SetProperty(ref _healingItemsChargeStatListener, value);
		}

		[Ordinal(161)] 
		[RED("GrenadesChargeStatListener")] 
		public CHandle<GrenadesChargeStatListener> GrenadesChargeStatListener
		{
			get => GetProperty(ref _grenadesChargeStatListener);
			set => SetProperty(ref _grenadesChargeStatListener, value);
		}

		[Ordinal(162)] 
		[RED("ProjectileLauncherChargeStatListener")] 
		public CHandle<ProjectileLauncherChargeStatListener> ProjectileLauncherChargeStatListener
		{
			get => GetProperty(ref _projectileLauncherChargeStatListener);
			set => SetProperty(ref _projectileLauncherChargeStatListener, value);
		}

		[Ordinal(163)] 
		[RED("OpticalCamoChargeStatListener")] 
		public CHandle<OpticalCamoChargeStatListener> OpticalCamoChargeStatListener
		{
			get => GetProperty(ref _opticalCamoChargeStatListener);
			set => SetProperty(ref _opticalCamoChargeStatListener, value);
		}

		[Ordinal(164)] 
		[RED("OverclockChargeListener")] 
		public CHandle<OverclockChargeListener> OverclockChargeListener
		{
			get => GetProperty(ref _overclockChargeListener);
			set => SetProperty(ref _overclockChargeListener, value);
		}

		[Ordinal(165)] 
		[RED("accessibilityControlsListener")] 
		public CHandle<AccessibilityControlsListener> AccessibilityControlsListener
		{
			get => GetProperty(ref _accessibilityControlsListener);
			set => SetProperty(ref _accessibilityControlsListener, value);
		}

		[Ordinal(166)] 
		[RED("isTalkingOnPhone")] 
		public CBool IsTalkingOnPhone
		{
			get => GetProperty(ref _isTalkingOnPhone);
			set => SetProperty(ref _isTalkingOnPhone, value);
		}

		[Ordinal(167)] 
		[RED("DataDamageUpdateID")] 
		public gameDelayID DataDamageUpdateID
		{
			get => GetProperty(ref _dataDamageUpdateID);
			set => SetProperty(ref _dataDamageUpdateID, value);
		}

		[Ordinal(168)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(169)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(170)] 
		[RED("callbackHandles")] 
		public CArray<CHandle<redCallbackObject>> CallbackHandles
		{
			get => GetProperty(ref _callbackHandles);
			set => SetProperty(ref _callbackHandles, value);
		}

		[Ordinal(171)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetProperty(ref _numberOfCombatants);
			set => SetProperty(ref _numberOfCombatants, value);
		}

		[Ordinal(172)] 
		[RED("equipmentMeshOverlayEffectName")] 
		public CName EquipmentMeshOverlayEffectName
		{
			get => GetProperty(ref _equipmentMeshOverlayEffectName);
			set => SetProperty(ref _equipmentMeshOverlayEffectName, value);
		}

		[Ordinal(173)] 
		[RED("equipmentMeshOverlayEffectTag")] 
		public CName EquipmentMeshOverlayEffectTag
		{
			get => GetProperty(ref _equipmentMeshOverlayEffectTag);
			set => SetProperty(ref _equipmentMeshOverlayEffectTag, value);
		}

		[Ordinal(174)] 
		[RED("equipmentMeshOverlaySlots")] 
		public CArray<TweakDBID> EquipmentMeshOverlaySlots
		{
			get => GetProperty(ref _equipmentMeshOverlaySlots);
			set => SetProperty(ref _equipmentMeshOverlaySlots, value);
		}

		[Ordinal(175)] 
		[RED("coverVisibilityPerkBlocked")] 
		public CBool CoverVisibilityPerkBlocked
		{
			get => GetProperty(ref _coverVisibilityPerkBlocked);
			set => SetProperty(ref _coverVisibilityPerkBlocked, value);
		}

		[Ordinal(176)] 
		[RED("behindCover")] 
		public CBool BehindCover
		{
			get => GetProperty(ref _behindCover);
			set => SetProperty(ref _behindCover, value);
		}

		[Ordinal(177)] 
		[RED("inCombat")] 
		public CBool InCombat
		{
			get => GetProperty(ref _inCombat);
			set => SetProperty(ref _inCombat, value);
		}

		[Ordinal(178)] 
		[RED("isBeingRevealed")] 
		public CBool IsBeingRevealed
		{
			get => GetProperty(ref _isBeingRevealed);
			set => SetProperty(ref _isBeingRevealed, value);
		}

		[Ordinal(179)] 
		[RED("hasBeenDetected")] 
		public CBool HasBeenDetected
		{
			get => GetProperty(ref _hasBeenDetected);
			set => SetProperty(ref _hasBeenDetected, value);
		}

		[Ordinal(180)] 
		[RED("inCrouch")] 
		public CBool InCrouch
		{
			get => GetProperty(ref _inCrouch);
			set => SetProperty(ref _inCrouch, value);
		}

		[Ordinal(181)] 
		[RED("hasKiroshiOpticsFragment")] 
		public CBool HasKiroshiOpticsFragment
		{
			get => GetProperty(ref _hasKiroshiOpticsFragment);
			set => SetProperty(ref _hasKiroshiOpticsFragment, value);
		}

		[Ordinal(182)] 
		[RED("doingQuickMelee")] 
		public CBool DoingQuickMelee
		{
			get => GetProperty(ref _doingQuickMelee);
			set => SetProperty(ref _doingQuickMelee, value);
		}

		[Ordinal(183)] 
		[RED("vehicleState")] 
		public CEnum<gamePSMVehicle> VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}

		[Ordinal(184)] 
		[RED("inMountedWeaponVehicle")] 
		public CBool InMountedWeaponVehicle
		{
			get => GetProperty(ref _inMountedWeaponVehicle);
			set => SetProperty(ref _inMountedWeaponVehicle, value);
		}

		[Ordinal(185)] 
		[RED("inDriverCombatTPP")] 
		public CBool InDriverCombatTPP
		{
			get => GetProperty(ref _inDriverCombatTPP);
			set => SetProperty(ref _inDriverCombatTPP, value);
		}

		[Ordinal(186)] 
		[RED("driverCombatWeaponType")] 
		public CEnum<gamedataItemType> DriverCombatWeaponType
		{
			get => GetProperty(ref _driverCombatWeaponType);
			set => SetProperty(ref _driverCombatWeaponType, value);
		}

		[Ordinal(187)] 
		[RED("isAiming")] 
		public CBool IsAiming
		{
			get => GetProperty(ref _isAiming);
			set => SetProperty(ref _isAiming, value);
		}

		[Ordinal(188)] 
		[RED("focusModeActive")] 
		public CBool FocusModeActive
		{
			get => GetProperty(ref _focusModeActive);
			set => SetProperty(ref _focusModeActive, value);
		}

		[Ordinal(189)] 
		[RED("customFastForwardPossible")] 
		public CBool CustomFastForwardPossible
		{
			get => GetProperty(ref _customFastForwardPossible);
			set => SetProperty(ref _customFastForwardPossible, value);
		}

		[Ordinal(190)] 
		[RED("equippedRightHandWeapon")] 
		public wCHandle<gameweaponObject> EquippedRightHandWeapon
		{
			get => GetProperty(ref _equippedRightHandWeapon);
			set => SetProperty(ref _equippedRightHandWeapon, value);
		}

		[Ordinal(191)] 
		[RED("aimAssistUpdateQueued")] 
		public CBool AimAssistUpdateQueued
		{
			get => GetProperty(ref _aimAssistUpdateQueued);
			set => SetProperty(ref _aimAssistUpdateQueued, value);
		}

		[Ordinal(192)] 
		[RED("locomotionState")] 
		public CInt32 LocomotionState
		{
			get => GetProperty(ref _locomotionState);
			set => SetProperty(ref _locomotionState, value);
		}

		[Ordinal(193)] 
		[RED("leftHandCyberwareState")] 
		public CInt32 LeftHandCyberwareState
		{
			get => GetProperty(ref _leftHandCyberwareState);
			set => SetProperty(ref _leftHandCyberwareState, value);
		}

		[Ordinal(194)] 
		[RED("meleeWeaponState")] 
		public CInt32 MeleeWeaponState
		{
			get => GetProperty(ref _meleeWeaponState);
			set => SetProperty(ref _meleeWeaponState, value);
		}

		[Ordinal(195)] 
		[RED("weaponZoomLevel")] 
		public CFloat WeaponZoomLevel
		{
			get => GetProperty(ref _weaponZoomLevel);
			set => SetProperty(ref _weaponZoomLevel, value);
		}

		[Ordinal(196)] 
		[RED("controllingDeviceID")] 
		public entEntityID ControllingDeviceID
		{
			get => GetProperty(ref _controllingDeviceID);
			set => SetProperty(ref _controllingDeviceID, value);
		}

		[Ordinal(197)] 
		[RED("gunshotRange")] 
		public CFloat GunshotRange
		{
			get => GetProperty(ref _gunshotRange);
			set => SetProperty(ref _gunshotRange, value);
		}

		[Ordinal(198)] 
		[RED("explosionRange")] 
		public CFloat ExplosionRange
		{
			get => GetProperty(ref _explosionRange);
			set => SetProperty(ref _explosionRange, value);
		}

		[Ordinal(199)] 
		[RED("isInBodySlam")] 
		public CBool IsInBodySlam
		{
			get => GetProperty(ref _isInBodySlam);
			set => SetProperty(ref _isInBodySlam, value);
		}

		[Ordinal(200)] 
		[RED("combatGadgetState")] 
		public CInt32 CombatGadgetState
		{
			get => GetProperty(ref _combatGadgetState);
			set => SetProperty(ref _combatGadgetState, value);
		}

		[Ordinal(201)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(202)] 
		[RED("nextBufferModifier")] 
		public CInt32 NextBufferModifier
		{
			get => GetProperty(ref _nextBufferModifier);
			set => SetProperty(ref _nextBufferModifier, value);
		}

		[Ordinal(203)] 
		[RED("attackingNetrunnerID")] 
		public entEntityID AttackingNetrunnerID
		{
			get => GetProperty(ref _attackingNetrunnerID);
			set => SetProperty(ref _attackingNetrunnerID, value);
		}

		[Ordinal(204)] 
		[RED("NPCDeathInstigator")] 
		public wCHandle<NPCPuppet> NPCDeathInstigator
		{
			get => GetProperty(ref _nPCDeathInstigator);
			set => SetProperty(ref _nPCDeathInstigator, value);
		}

		[Ordinal(205)] 
		[RED("bestTargettingWeapon")] 
		public wCHandle<gameweaponObject> BestTargettingWeapon
		{
			get => GetProperty(ref _bestTargettingWeapon);
			set => SetProperty(ref _bestTargettingWeapon, value);
		}

		[Ordinal(206)] 
		[RED("bestTargettingDot")] 
		public CFloat BestTargettingDot
		{
			get => GetProperty(ref _bestTargettingDot);
			set => SetProperty(ref _bestTargettingDot, value);
		}

		[Ordinal(207)] 
		[RED("targettingEnemies")] 
		public CInt32 TargettingEnemies
		{
			get => GetProperty(ref _targettingEnemies);
			set => SetProperty(ref _targettingEnemies, value);
		}

		[Ordinal(208)] 
		[RED("isAimingAtFriendly")] 
		public CBool IsAimingAtFriendly
		{
			get => GetProperty(ref _isAimingAtFriendly);
			set => SetProperty(ref _isAimingAtFriendly, value);
		}

		[Ordinal(209)] 
		[RED("isAimingAtChild")] 
		public CBool IsAimingAtChild
		{
			get => GetProperty(ref _isAimingAtChild);
			set => SetProperty(ref _isAimingAtChild, value);
		}

		[Ordinal(210)] 
		[RED("distanceFromTargetSquared")] 
		public CFloat DistanceFromTargetSquared
		{
			get => GetProperty(ref _distanceFromTargetSquared);
			set => SetProperty(ref _distanceFromTargetSquared, value);
		}

		[Ordinal(211)] 
		[RED("coverRecordID")] 
		public TweakDBID CoverRecordID
		{
			get => GetProperty(ref _coverRecordID);
			set => SetProperty(ref _coverRecordID, value);
		}

		[Ordinal(212)] 
		[RED("damageReductionRecordID")] 
		public TweakDBID DamageReductionRecordID
		{
			get => GetProperty(ref _damageReductionRecordID);
			set => SetProperty(ref _damageReductionRecordID, value);
		}

		[Ordinal(213)] 
		[RED("visReductionRecordID")] 
		public TweakDBID VisReductionRecordID
		{
			get => GetProperty(ref _visReductionRecordID);
			set => SetProperty(ref _visReductionRecordID, value);
		}

		[Ordinal(214)] 
		[RED("lastDmgInflicted")] 
		public EngineTime LastDmgInflicted
		{
			get => GetProperty(ref _lastDmgInflicted);
			set => SetProperty(ref _lastDmgInflicted, value);
		}

		[Ordinal(215)] 
		[RED("critHealthRumblePlayed")] 
		public CBool CritHealthRumblePlayed
		{
			get => GetProperty(ref _critHealthRumblePlayed);
			set => SetProperty(ref _critHealthRumblePlayed, value);
		}

		[Ordinal(216)] 
		[RED("critHealthRumbleDurationID")] 
		public gameDelayID CritHealthRumbleDurationID
		{
			get => GetProperty(ref _critHealthRumbleDurationID);
			set => SetProperty(ref _critHealthRumbleDurationID, value);
		}

		[Ordinal(217)] 
		[RED("lastHealthUpdate")] 
		public CFloat LastHealthUpdate
		{
			get => GetProperty(ref _lastHealthUpdate);
			set => SetProperty(ref _lastHealthUpdate, value);
		}

		[Ordinal(218)] 
		[RED("staminaListener")] 
		public CHandle<StaminaListener> StaminaListener
		{
			get => GetProperty(ref _staminaListener);
			set => SetProperty(ref _staminaListener, value);
		}

		[Ordinal(219)] 
		[RED("memoryListener")] 
		public CHandle<MemoryListener> MemoryListener
		{
			get => GetProperty(ref _memoryListener);
			set => SetProperty(ref _memoryListener, value);
		}

		[Ordinal(220)] 
		[RED("securityAreaTypeE3HACK")] 
		public CEnum<ESecurityAreaType> SecurityAreaTypeE3HACK
		{
			get => GetProperty(ref _securityAreaTypeE3HACK);
			set => SetProperty(ref _securityAreaTypeE3HACK, value);
		}

		[Ordinal(221)] 
		[RED("overlappedSecurityZones")] 
		public CArray<gamePersistentID> OverlappedSecurityZones
		{
			get => GetProperty(ref _overlappedSecurityZones);
			set => SetProperty(ref _overlappedSecurityZones, value);
		}

		[Ordinal(222)] 
		[RED("interestingFacts")] 
		public InterestingFacts InterestingFacts
		{
			get => GetProperty(ref _interestingFacts);
			set => SetProperty(ref _interestingFacts, value);
		}

		[Ordinal(223)] 
		[RED("interestingFactsListenersIds")] 
		public InterestingFactsListenersIds InterestingFactsListenersIds
		{
			get => GetProperty(ref _interestingFactsListenersIds);
			set => SetProperty(ref _interestingFactsListenersIds, value);
		}

		[Ordinal(224)] 
		[RED("interestingFactsListenersFunctions")] 
		public InterestingFactsListenersFunctions InterestingFactsListenersFunctions
		{
			get => GetProperty(ref _interestingFactsListenersFunctions);
			set => SetProperty(ref _interestingFactsListenersFunctions, value);
		}

		[Ordinal(225)] 
		[RED("visionModeController")] 
		public CHandle<PlayerVisionModeController> VisionModeController
		{
			get => GetProperty(ref _visionModeController);
			set => SetProperty(ref _visionModeController, value);
		}

		[Ordinal(226)] 
		[RED("combatController")] 
		public CHandle<PlayerCombatController> CombatController
		{
			get => GetProperty(ref _combatController);
			set => SetProperty(ref _combatController, value);
		}

		[Ordinal(227)] 
		[RED("handlingModifiers")] 
		public CHandle<PlayerWeaponHandlingModifiers> HandlingModifiers
		{
			get => GetProperty(ref _handlingModifiers);
			set => SetProperty(ref _handlingModifiers, value);
		}

		[Ordinal(228)] 
		[RED("cachedGameplayRestrictions")] 
		public CArray<TweakDBID> CachedGameplayRestrictions
		{
			get => GetProperty(ref _cachedGameplayRestrictions);
			set => SetProperty(ref _cachedGameplayRestrictions, value);
		}

		[Ordinal(229)] 
		[RED("delayEndGracePeriodAfterSpawnEventID")] 
		public gameDelayID DelayEndGracePeriodAfterSpawnEventID
		{
			get => GetProperty(ref _delayEndGracePeriodAfterSpawnEventID);
			set => SetProperty(ref _delayEndGracePeriodAfterSpawnEventID, value);
		}

		[Ordinal(230)] 
		[RED("CWMaskInVehicleInputHeld")] 
		public CBool CWMaskInVehicleInputHeld
		{
			get => GetProperty(ref _cWMaskInVehicleInputHeld);
			set => SetProperty(ref _cWMaskInVehicleInputHeld, value);
		}

		[Ordinal(231)] 
		[RED("friendlyDevicesHostileToEnemiesLock")] 
		public ScriptReentrantRWLock FriendlyDevicesHostileToEnemiesLock
		{
			get => GetProperty(ref _friendlyDevicesHostileToEnemiesLock);
			set => SetProperty(ref _friendlyDevicesHostileToEnemiesLock, value);
		}

		[Ordinal(232)] 
		[RED("friendlyDevicesHostileToEnemies")] 
		public CArray<entEntityID> FriendlyDevicesHostileToEnemies
		{
			get => GetProperty(ref _friendlyDevicesHostileToEnemies);
			set => SetProperty(ref _friendlyDevicesHostileToEnemies, value);
		}

		[Ordinal(233)] 
		[RED("pocketRadio")] 
		public CHandle<PocketRadio> PocketRadio
		{
			get => GetProperty(ref _pocketRadio);
			set => SetProperty(ref _pocketRadio, value);
		}

		[Ordinal(234)] 
		[RED("noMovementModifierData")] 
		public CArray<CHandle<gameStatModifierData_Deprecated>> NoMovementModifierData
		{
			get => GetProperty(ref _noMovementModifierData);
			set => SetProperty(ref _noMovementModifierData, value);
		}

		[Ordinal(235)] 
		[RED("registeredFactListeners")] 
		public CArray<FactCallbackData> RegisteredFactListeners
		{
			get => GetProperty(ref _registeredFactListeners);
			set => SetProperty(ref _registeredFactListeners, value);
		}

		[Ordinal(236)] 
		[RED("bossThatTargetsPlayer")] 
		public entEntityID BossThatTargetsPlayer
		{
			get => GetProperty(ref _bossThatTargetsPlayer);
			set => SetProperty(ref _bossThatTargetsPlayer, value);
		}

		[Ordinal(237)] 
		[RED("choiceTokenTextLayerId")] 
		public CUInt32 ChoiceTokenTextLayerId
		{
			get => GetProperty(ref _choiceTokenTextLayerId);
			set => SetProperty(ref _choiceTokenTextLayerId, value);
		}

		[Ordinal(238)] 
		[RED("choiceTokenTextDrawn")] 
		public CBool ChoiceTokenTextDrawn
		{
			get => GetProperty(ref _choiceTokenTextDrawn);
			set => SetProperty(ref _choiceTokenTextDrawn, value);
		}

		public PlayerPuppet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
