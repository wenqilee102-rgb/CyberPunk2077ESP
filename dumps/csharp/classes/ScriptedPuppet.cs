using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppet : gamePuppet
	{
		private CHandle<AIHumanComponent> _aiController;
		private CHandle<movePoliciesComponent> _movePolicies;
		private CHandle<AIPhaseStateEventHandlerComponent> _aiStateHandlerComponent;
		private CHandle<HitReactionComponent> _hitReactionComponent;
		private CHandle<AISignalHandlerComponent> _signalHandlerComponent;
		private CHandle<ReactionManagerComponent> _reactionComponent;
		private CHandle<gameDismembermentComponent> _dismembermentComponent;
		private CHandle<entSlotComponent> _hitRepresantation;
		private CHandle<gameinteractionsComponent> _interactionComponent;
		private CHandle<entSlotComponent> _slotComponent;
		private CHandle<senseComponent> _sensesComponent;
		private CHandle<senseVisibleObjectComponent> _visibleObjectComponent;
		private CBool _visibleObjectPositionUpdated;
		private CHandle<senseSensorObjectComponent> _sensorObjectComponent;
		private CHandle<AITargetTrackerComponent> _targetTrackerComponent;
		private CArray<CHandle<gameTargetingComponent>> _targetingComponentsArray;
		private CHandle<NPCStatesComponent> _statesComponent;
		private CHandle<FxResourceMapperComponent> _fxResourceMapper;
		private LinkedStatusEffect _linkedStatusEffect;
		private CHandle<ResourceLibraryComponent> _resourceLibraryComponent;
		private CHandle<CrowdMemberBaseComponent> _crowdMemberComponent;
		private wCHandle<gameInventory> _inventoryComponent;
		private CHandle<AIObjectSelectionComponent> _objectSelectionComponent;
		private CHandle<entTransformHistoryComponent> _transformHistoryComponent;
		private CHandle<entAnimationControllerComponent> _animationControllerComponent;
		private CHandle<gameinfluenceBumpComponent> _bumpComponent;
		private CBool _isCrowd;
		private CBool _incapacitatedOnAttach;
		private CBool _isIconic;
		private CHandle<CombatHUDManager> _combatHUDManager;
		private CBool _exposePosition;
		private CHandle<gameIBlackboard> _puppetStateBlackboard;
		private CHandle<gameIBlackboard> _customBlackboard;
		private CUInt32 _securityAreaCallbackID;
		private CArray<CHandle<AICustomComponents>> _customAIComponents;
		private CArray<CHandle<PuppetListener>> _listeners;
		private CHandle<SecuritySupportListener> _securitySupportListener;
		private CHandle<RevealRequestsStorage> _shouldBeRevealedStorage;
		private CBool _inputProcessed;
		private CBool _shouldSpawnBloodPuddle;
		private CBool _bloodPuddleSpawned;
		private CBool _skipDeathAnimation;
		private CHandle<HitHistory> _hitHistory;
		private CArray<CName> _currentWorkspotTags;
		private CEnum<gamedataQuality> _lootQuality;
		private CBool _hasQuestItems;
		private CName _activeQualityRangeInteraction;
		private CBool _droppedWeapons;
		private CHandle<gameWeakspotComponent> _weakspotComponent;
		private CHandle<gameBreachControllerComponent> _breachControllerComponent;
		private CHandle<FocusForcedHighlightData> _highlightData;
		private CUInt32 _currentTagsStack;
		private wCHandle<entEntity> _killer;
		private CHandle<gameObjectActionsCallbackController> _objectActionsCallbackCtrl;
		private AIUtilsCachedBoolValue _isActiveCached;
		private CBool _isCyberpsycho;
		private CBool _isCivilian;
		private CBool _isPolice;
		private CBool _isGanger;
		private wCHandle<ScriptableDeviceAction> _currentlyUploadingAction;
		private wCHandle<GameplayRoleComponent> _gameplayRoleComponent;
		private CArray<CHandle<ScriptableDeviceAction>> _activeQuickhackActionHistory;
		private CArray<CHandle<ScriptableDeviceAction>> _completedQuickhackHistory;
		private CBool _isFinsherSoundPlayed;
		private CArray<gameItemID> _attemptedShards;

		[Ordinal(36)] 
		[RED("aiController")] 
		public CHandle<AIHumanComponent> AiController
		{
			get => GetProperty(ref _aiController);
			set => SetProperty(ref _aiController, value);
		}

		[Ordinal(37)] 
		[RED("movePolicies")] 
		public CHandle<movePoliciesComponent> MovePolicies
		{
			get => GetProperty(ref _movePolicies);
			set => SetProperty(ref _movePolicies, value);
		}

		[Ordinal(38)] 
		[RED("aiStateHandlerComponent")] 
		public CHandle<AIPhaseStateEventHandlerComponent> AiStateHandlerComponent
		{
			get => GetProperty(ref _aiStateHandlerComponent);
			set => SetProperty(ref _aiStateHandlerComponent, value);
		}

		[Ordinal(39)] 
		[RED("hitReactionComponent")] 
		public CHandle<HitReactionComponent> HitReactionComponent
		{
			get => GetProperty(ref _hitReactionComponent);
			set => SetProperty(ref _hitReactionComponent, value);
		}

		[Ordinal(40)] 
		[RED("signalHandlerComponent")] 
		public CHandle<AISignalHandlerComponent> SignalHandlerComponent
		{
			get => GetProperty(ref _signalHandlerComponent);
			set => SetProperty(ref _signalHandlerComponent, value);
		}

		[Ordinal(41)] 
		[RED("reactionComponent")] 
		public CHandle<ReactionManagerComponent> ReactionComponent
		{
			get => GetProperty(ref _reactionComponent);
			set => SetProperty(ref _reactionComponent, value);
		}

		[Ordinal(42)] 
		[RED("dismembermentComponent")] 
		public CHandle<gameDismembermentComponent> DismembermentComponent
		{
			get => GetProperty(ref _dismembermentComponent);
			set => SetProperty(ref _dismembermentComponent, value);
		}

		[Ordinal(43)] 
		[RED("hitRepresantation")] 
		public CHandle<entSlotComponent> HitRepresantation
		{
			get => GetProperty(ref _hitRepresantation);
			set => SetProperty(ref _hitRepresantation, value);
		}

		[Ordinal(44)] 
		[RED("interactionComponent")] 
		public CHandle<gameinteractionsComponent> InteractionComponent
		{
			get => GetProperty(ref _interactionComponent);
			set => SetProperty(ref _interactionComponent, value);
		}

		[Ordinal(45)] 
		[RED("slotComponent")] 
		public CHandle<entSlotComponent> SlotComponent
		{
			get => GetProperty(ref _slotComponent);
			set => SetProperty(ref _slotComponent, value);
		}

		[Ordinal(46)] 
		[RED("sensesComponent")] 
		public CHandle<senseComponent> SensesComponent
		{
			get => GetProperty(ref _sensesComponent);
			set => SetProperty(ref _sensesComponent, value);
		}

		[Ordinal(47)] 
		[RED("visibleObjectComponent")] 
		public CHandle<senseVisibleObjectComponent> VisibleObjectComponent
		{
			get => GetProperty(ref _visibleObjectComponent);
			set => SetProperty(ref _visibleObjectComponent, value);
		}

		[Ordinal(48)] 
		[RED("visibleObjectPositionUpdated")] 
		public CBool VisibleObjectPositionUpdated
		{
			get => GetProperty(ref _visibleObjectPositionUpdated);
			set => SetProperty(ref _visibleObjectPositionUpdated, value);
		}

		[Ordinal(49)] 
		[RED("sensorObjectComponent")] 
		public CHandle<senseSensorObjectComponent> SensorObjectComponent
		{
			get => GetProperty(ref _sensorObjectComponent);
			set => SetProperty(ref _sensorObjectComponent, value);
		}

		[Ordinal(50)] 
		[RED("targetTrackerComponent")] 
		public CHandle<AITargetTrackerComponent> TargetTrackerComponent
		{
			get => GetProperty(ref _targetTrackerComponent);
			set => SetProperty(ref _targetTrackerComponent, value);
		}

		[Ordinal(51)] 
		[RED("targetingComponentsArray")] 
		public CArray<CHandle<gameTargetingComponent>> TargetingComponentsArray
		{
			get => GetProperty(ref _targetingComponentsArray);
			set => SetProperty(ref _targetingComponentsArray, value);
		}

		[Ordinal(52)] 
		[RED("statesComponent")] 
		public CHandle<NPCStatesComponent> StatesComponent
		{
			get => GetProperty(ref _statesComponent);
			set => SetProperty(ref _statesComponent, value);
		}

		[Ordinal(53)] 
		[RED("fxResourceMapper")] 
		public CHandle<FxResourceMapperComponent> FxResourceMapper
		{
			get => GetProperty(ref _fxResourceMapper);
			set => SetProperty(ref _fxResourceMapper, value);
		}

		[Ordinal(54)] 
		[RED("linkedStatusEffect")] 
		public LinkedStatusEffect LinkedStatusEffect
		{
			get => GetProperty(ref _linkedStatusEffect);
			set => SetProperty(ref _linkedStatusEffect, value);
		}

		[Ordinal(55)] 
		[RED("resourceLibraryComponent")] 
		public CHandle<ResourceLibraryComponent> ResourceLibraryComponent
		{
			get => GetProperty(ref _resourceLibraryComponent);
			set => SetProperty(ref _resourceLibraryComponent, value);
		}

		[Ordinal(56)] 
		[RED("crowdMemberComponent")] 
		public CHandle<CrowdMemberBaseComponent> CrowdMemberComponent
		{
			get => GetProperty(ref _crowdMemberComponent);
			set => SetProperty(ref _crowdMemberComponent, value);
		}

		[Ordinal(57)] 
		[RED("inventoryComponent")] 
		public wCHandle<gameInventory> InventoryComponent
		{
			get => GetProperty(ref _inventoryComponent);
			set => SetProperty(ref _inventoryComponent, value);
		}

		[Ordinal(58)] 
		[RED("objectSelectionComponent")] 
		public CHandle<AIObjectSelectionComponent> ObjectSelectionComponent
		{
			get => GetProperty(ref _objectSelectionComponent);
			set => SetProperty(ref _objectSelectionComponent, value);
		}

		[Ordinal(59)] 
		[RED("transformHistoryComponent")] 
		public CHandle<entTransformHistoryComponent> TransformHistoryComponent
		{
			get => GetProperty(ref _transformHistoryComponent);
			set => SetProperty(ref _transformHistoryComponent, value);
		}

		[Ordinal(60)] 
		[RED("animationControllerComponent")] 
		public CHandle<entAnimationControllerComponent> AnimationControllerComponent
		{
			get => GetProperty(ref _animationControllerComponent);
			set => SetProperty(ref _animationControllerComponent, value);
		}

		[Ordinal(61)] 
		[RED("bumpComponent")] 
		public CHandle<gameinfluenceBumpComponent> BumpComponent
		{
			get => GetProperty(ref _bumpComponent);
			set => SetProperty(ref _bumpComponent, value);
		}

		[Ordinal(62)] 
		[RED("isCrowd")] 
		public CBool IsCrowd
		{
			get => GetProperty(ref _isCrowd);
			set => SetProperty(ref _isCrowd, value);
		}

		[Ordinal(63)] 
		[RED("incapacitatedOnAttach")] 
		public CBool IncapacitatedOnAttach
		{
			get => GetProperty(ref _incapacitatedOnAttach);
			set => SetProperty(ref _incapacitatedOnAttach, value);
		}

		[Ordinal(64)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(65)] 
		[RED("combatHUDManager")] 
		public CHandle<CombatHUDManager> CombatHUDManager
		{
			get => GetProperty(ref _combatHUDManager);
			set => SetProperty(ref _combatHUDManager, value);
		}

		[Ordinal(66)] 
		[RED("exposePosition")] 
		public CBool ExposePosition
		{
			get => GetProperty(ref _exposePosition);
			set => SetProperty(ref _exposePosition, value);
		}

		[Ordinal(67)] 
		[RED("puppetStateBlackboard")] 
		public CHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetProperty(ref _puppetStateBlackboard);
			set => SetProperty(ref _puppetStateBlackboard, value);
		}

		[Ordinal(68)] 
		[RED("customBlackboard")] 
		public CHandle<gameIBlackboard> CustomBlackboard
		{
			get => GetProperty(ref _customBlackboard);
			set => SetProperty(ref _customBlackboard, value);
		}

		[Ordinal(69)] 
		[RED("securityAreaCallbackID")] 
		public CUInt32 SecurityAreaCallbackID
		{
			get => GetProperty(ref _securityAreaCallbackID);
			set => SetProperty(ref _securityAreaCallbackID, value);
		}

		[Ordinal(70)] 
		[RED("customAIComponents")] 
		public CArray<CHandle<AICustomComponents>> CustomAIComponents
		{
			get => GetProperty(ref _customAIComponents);
			set => SetProperty(ref _customAIComponents, value);
		}

		[Ordinal(71)] 
		[RED("listeners")] 
		public CArray<CHandle<PuppetListener>> Listeners
		{
			get => GetProperty(ref _listeners);
			set => SetProperty(ref _listeners, value);
		}

		[Ordinal(72)] 
		[RED("securitySupportListener")] 
		public CHandle<SecuritySupportListener> SecuritySupportListener
		{
			get => GetProperty(ref _securitySupportListener);
			set => SetProperty(ref _securitySupportListener, value);
		}

		[Ordinal(73)] 
		[RED("shouldBeRevealedStorage")] 
		public CHandle<RevealRequestsStorage> ShouldBeRevealedStorage
		{
			get => GetProperty(ref _shouldBeRevealedStorage);
			set => SetProperty(ref _shouldBeRevealedStorage, value);
		}

		[Ordinal(74)] 
		[RED("inputProcessed")] 
		public CBool InputProcessed
		{
			get => GetProperty(ref _inputProcessed);
			set => SetProperty(ref _inputProcessed, value);
		}

		[Ordinal(75)] 
		[RED("shouldSpawnBloodPuddle")] 
		public CBool ShouldSpawnBloodPuddle
		{
			get => GetProperty(ref _shouldSpawnBloodPuddle);
			set => SetProperty(ref _shouldSpawnBloodPuddle, value);
		}

		[Ordinal(76)] 
		[RED("bloodPuddleSpawned")] 
		public CBool BloodPuddleSpawned
		{
			get => GetProperty(ref _bloodPuddleSpawned);
			set => SetProperty(ref _bloodPuddleSpawned, value);
		}

		[Ordinal(77)] 
		[RED("skipDeathAnimation")] 
		public CBool SkipDeathAnimation
		{
			get => GetProperty(ref _skipDeathAnimation);
			set => SetProperty(ref _skipDeathAnimation, value);
		}

		[Ordinal(78)] 
		[RED("hitHistory")] 
		public CHandle<HitHistory> HitHistory
		{
			get => GetProperty(ref _hitHistory);
			set => SetProperty(ref _hitHistory, value);
		}

		[Ordinal(79)] 
		[RED("currentWorkspotTags")] 
		public CArray<CName> CurrentWorkspotTags
		{
			get => GetProperty(ref _currentWorkspotTags);
			set => SetProperty(ref _currentWorkspotTags, value);
		}

		[Ordinal(80)] 
		[RED("lootQuality")] 
		public CEnum<gamedataQuality> LootQuality
		{
			get => GetProperty(ref _lootQuality);
			set => SetProperty(ref _lootQuality, value);
		}

		[Ordinal(81)] 
		[RED("hasQuestItems")] 
		public CBool HasQuestItems
		{
			get => GetProperty(ref _hasQuestItems);
			set => SetProperty(ref _hasQuestItems, value);
		}

		[Ordinal(82)] 
		[RED("activeQualityRangeInteraction")] 
		public CName ActiveQualityRangeInteraction
		{
			get => GetProperty(ref _activeQualityRangeInteraction);
			set => SetProperty(ref _activeQualityRangeInteraction, value);
		}

		[Ordinal(83)] 
		[RED("droppedWeapons")] 
		public CBool DroppedWeapons
		{
			get => GetProperty(ref _droppedWeapons);
			set => SetProperty(ref _droppedWeapons, value);
		}

		[Ordinal(84)] 
		[RED("weakspotComponent")] 
		public CHandle<gameWeakspotComponent> WeakspotComponent
		{
			get => GetProperty(ref _weakspotComponent);
			set => SetProperty(ref _weakspotComponent, value);
		}

		[Ordinal(85)] 
		[RED("breachControllerComponent")] 
		public CHandle<gameBreachControllerComponent> BreachControllerComponent
		{
			get => GetProperty(ref _breachControllerComponent);
			set => SetProperty(ref _breachControllerComponent, value);
		}

		[Ordinal(86)] 
		[RED("highlightData")] 
		public CHandle<FocusForcedHighlightData> HighlightData
		{
			get => GetProperty(ref _highlightData);
			set => SetProperty(ref _highlightData, value);
		}

		[Ordinal(87)] 
		[RED("currentTagsStack")] 
		public CUInt32 CurrentTagsStack
		{
			get => GetProperty(ref _currentTagsStack);
			set => SetProperty(ref _currentTagsStack, value);
		}

		[Ordinal(88)] 
		[RED("killer")] 
		public wCHandle<entEntity> Killer
		{
			get => GetProperty(ref _killer);
			set => SetProperty(ref _killer, value);
		}

		[Ordinal(89)] 
		[RED("objectActionsCallbackCtrl")] 
		public CHandle<gameObjectActionsCallbackController> ObjectActionsCallbackCtrl
		{
			get => GetProperty(ref _objectActionsCallbackCtrl);
			set => SetProperty(ref _objectActionsCallbackCtrl, value);
		}

		[Ordinal(90)] 
		[RED("isActiveCached")] 
		public AIUtilsCachedBoolValue IsActiveCached
		{
			get => GetProperty(ref _isActiveCached);
			set => SetProperty(ref _isActiveCached, value);
		}

		[Ordinal(91)] 
		[RED("isCyberpsycho")] 
		public CBool IsCyberpsycho
		{
			get => GetProperty(ref _isCyberpsycho);
			set => SetProperty(ref _isCyberpsycho, value);
		}

		[Ordinal(92)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetProperty(ref _isCivilian);
			set => SetProperty(ref _isCivilian, value);
		}

		[Ordinal(93)] 
		[RED("isPolice")] 
		public CBool IsPolice
		{
			get => GetProperty(ref _isPolice);
			set => SetProperty(ref _isPolice, value);
		}

		[Ordinal(94)] 
		[RED("isGanger")] 
		public CBool IsGanger
		{
			get => GetProperty(ref _isGanger);
			set => SetProperty(ref _isGanger, value);
		}

		[Ordinal(95)] 
		[RED("currentlyUploadingAction")] 
		public wCHandle<ScriptableDeviceAction> CurrentlyUploadingAction
		{
			get => GetProperty(ref _currentlyUploadingAction);
			set => SetProperty(ref _currentlyUploadingAction, value);
		}

		[Ordinal(96)] 
		[RED("gameplayRoleComponent")] 
		public wCHandle<GameplayRoleComponent> GameplayRoleComponent
		{
			get => GetProperty(ref _gameplayRoleComponent);
			set => SetProperty(ref _gameplayRoleComponent, value);
		}

		[Ordinal(97)] 
		[RED("activeQuickhackActionHistory")] 
		public CArray<CHandle<ScriptableDeviceAction>> ActiveQuickhackActionHistory
		{
			get => GetProperty(ref _activeQuickhackActionHistory);
			set => SetProperty(ref _activeQuickhackActionHistory, value);
		}

		[Ordinal(98)] 
		[RED("completedQuickhackHistory")] 
		public CArray<CHandle<ScriptableDeviceAction>> CompletedQuickhackHistory
		{
			get => GetProperty(ref _completedQuickhackHistory);
			set => SetProperty(ref _completedQuickhackHistory, value);
		}

		[Ordinal(99)] 
		[RED("isFinsherSoundPlayed")] 
		public CBool IsFinsherSoundPlayed
		{
			get => GetProperty(ref _isFinsherSoundPlayed);
			set => SetProperty(ref _isFinsherSoundPlayed, value);
		}

		[Ordinal(100)] 
		[RED("attemptedShards")] 
		public CArray<gameItemID> AttemptedShards
		{
			get => GetProperty(ref _attemptedShards);
			set => SetProperty(ref _attemptedShards, value);
		}

		public ScriptedPuppet(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
