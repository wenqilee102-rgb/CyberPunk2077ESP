using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionSystem : gameScriptableSystem
	{
		private CHandle<DistrictManager> _districtManager;
		private CHandle<PoliceAgentRegistry> _agentRegistry;
		private CBool _ignoreSecurityAreasByQuest;
		private CBool _forceEternalGreyStars;
		private CBool _blockOnFootSpawnByQuest;
		private CBool _blockVehicleSpawnByQuest;
		private CBool _blockReconDroneSpawnByQuest;
		private CFloat _crimeScoreMultiplierByQuest;
		private CArray<CName> _preventionQuestEventSources;
		private CArray<CName> _systemLockSources;
		private CBool _systemEnabled;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gamedataDistrictPreventionData_Record> _preventionPreset;
		private wCHandle<gamedataPreventionHeatDataMatrix_Record> _preventionDataMatrix;
		private wCHandle<gamedataPreventionHeatTable_Record> _preventionDataTable;
		private CBool _systemLocked;
		private CArray<CName> _nodeEventSources;
		private CEnum<EPreventionHeatStage> _heatStage;
		private CString _heatChangeReason;
		private CBool _ignoreSecurityAreas;
		private CArray<gamePersistentID> _playerIsInSecurityArea;
		private CBool _playerIsInPreventionFreeArea;
		private CArray<gamePersistentID> _policeSecuritySystems;
		private CArray<CHandle<PreventionAgents>> _agentGroupsList;
		private Vector4 _lastKnownPosition;
		private wCHandle<vehicleBaseObject> _lastKnownVehicle;
		private CFloat _districtMultiplier;
		private CBool _shouldForceStarStateUIToActive;
		private CFloat _lastAttackTime;
		private CArray<entEntityID> _lastAttackTargetIDs;
		private CArray<wCHandle<gameObject>> _viewers;
		private CBool _hasViewers;
		private CEnum<EStarState> _starState;
		private CBool _starStateUIChanged;
		private CBool _isPlayerMounted;
		private CBool _policeKnowsPlayerLocation;
		private CBool _isInitialSearchState;
		private CBool _heatLevelChanged;
		private CBool _playerCrossedBufferDistance;
		private gameDelayID _crimescoreTimerDelayID;
		private gameDelayID _starStateBufferTimerDelayID;
		private gameDelayID _beliefAccuracyTimerDelayID;
		private gameDelayID _blinkingStatusDelayID;
		private gameDelayID _searchingStatusDelayID;
		private gameDelayID _transitionToGreyStateDelayID;
		private gameDelayID _policemenSpawnDelayID;
		private gameDelayID _securityAreaResetDelayID;
		private gameDelayID _inputlockDelayID;
		private gameDelayID _freeAreaResetDelayID;
		private CBool _securityAreaResetCheck;
		private CBool _hadOngoingSpawnRequest;
		private CFloat _totalCrimeScore;
		private CBool _canSpawnFallbackEarly;
		private TweakDBID _failsafePoliceRecordT1;
		private TweakDBID _failsafePoliceRecordT2;
		private TweakDBID _failsafePoliceRecordT3;
		private CArray<CName> _blinkReasonsStack;
		private wCHandle<gameIBlackboard> _wantedBarBlackboard;
		private CHandle<redCallbackObject> _onPlayerChoiceCallID;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CHandle<redCallbackObject> _playerHLSID;
		private CHandle<redCallbackObject> _playerVehicleStateID;
		private CEnum<gamePSMHighLevel> _playerHLS;
		private CEnum<gamePSMVehicle> _playerVehicleState;
		private CInt32 _unhandledInputsReceived;
		private CBool _preventionUnitKilledDuringLock;
		private entEntityID _previousHitTargetID;
		private CFloat _previousHitAttackTime;
		private CBool _reconPhaseEnabled;
		private CBool _reconDeployed;
		private CBool _reconDestroyed;
		private CEnum<EPreventionHeatStage> _minHeatLevel;
		private CEnum<EPreventionHeatStage> _maxHeatLevel;
		private CBool _defaultHeatLevels;
		private CEnum<EVehicleSpawnBlockSide> _vehicleSpawnBlockSide;
		private CFloat _damageToPlayerMultiplier;
		private CFloat _chaseMultiplier;
		private wCHandle<gameIBlackboard> _policeChaseBlackboard;
		private CBool _blockShootingFromVehicle;
		private CEnum<EPreventionDebugProcessReason> _debug_ProcessReason;
		private CEnum<gamedataAttackType> _debug_LastAttackType;
		private CFloat _debug_LastDamageDealt;
		private CFloat _debug_LastCrimeDistance;
		private Vector3 _debug_lastAVRequestedSpawnPosition;
		private CBool _temp_const_false;
		private CHandle<IntervalCaller> _preventionTickCaller;
		private CHandle<IntervalCaller> _roadblockadeRespawnTickCaller;
		private CUInt32 _maxtacTicketID;
		private CArray<Vector3> _avSpawnPointList;
		private CFloat _maxAllowedDistanceToPlayer;
		private CArray<Vector4> _lastAVRequestedSpawnPositionsArray;
		private CBool _shouldPreventionUnitsStartRetreating;
		private CInt32 _numberOfMaxtacSquadsSpawned;
		private CFloat _maxtacTroopBeingAliveTimeStamp;
		private CInt32 _civilianVehicleDestructionCount;
		private CFloat _lastCivilianVehicleDestructionTimeStamp;
		private CInt32 _civilianVehicleDestructionThreshold;
		private CFloat _civilianVehicleDestructionTimeout;
		private CHandle<IntervalCaller> _vehicleSpawnTickCaller;
		private CHandle<IntervalCaller> _ressuplyVehicleTicketCaller;
		private CBool _isVehicleDelayOver;
		private CInt32 _currentVehicleTicketCount;
		private CInt32 _failedVehicleSpawnAttempts;
		private CBool _codeRedReinforcement;
		private CFloat _lastStarChangeTimeStamp;
		private CFloat _firstStarTimeStamp;
		private CBool _setCallRejectionIncrement;

		[Ordinal(0)] 
		[RED("districtManager")] 
		public CHandle<DistrictManager> DistrictManager
		{
			get => GetProperty(ref _districtManager);
			set => SetProperty(ref _districtManager, value);
		}

		[Ordinal(1)] 
		[RED("agentRegistry")] 
		public CHandle<PoliceAgentRegistry> AgentRegistry
		{
			get => GetProperty(ref _agentRegistry);
			set => SetProperty(ref _agentRegistry, value);
		}

		[Ordinal(2)] 
		[RED("ignoreSecurityAreasByQuest")] 
		public CBool IgnoreSecurityAreasByQuest
		{
			get => GetProperty(ref _ignoreSecurityAreasByQuest);
			set => SetProperty(ref _ignoreSecurityAreasByQuest, value);
		}

		[Ordinal(3)] 
		[RED("forceEternalGreyStars")] 
		public CBool ForceEternalGreyStars
		{
			get => GetProperty(ref _forceEternalGreyStars);
			set => SetProperty(ref _forceEternalGreyStars, value);
		}

		[Ordinal(4)] 
		[RED("blockOnFootSpawnByQuest")] 
		public CBool BlockOnFootSpawnByQuest
		{
			get => GetProperty(ref _blockOnFootSpawnByQuest);
			set => SetProperty(ref _blockOnFootSpawnByQuest, value);
		}

		[Ordinal(5)] 
		[RED("blockVehicleSpawnByQuest")] 
		public CBool BlockVehicleSpawnByQuest
		{
			get => GetProperty(ref _blockVehicleSpawnByQuest);
			set => SetProperty(ref _blockVehicleSpawnByQuest, value);
		}

		[Ordinal(6)] 
		[RED("blockReconDroneSpawnByQuest")] 
		public CBool BlockReconDroneSpawnByQuest
		{
			get => GetProperty(ref _blockReconDroneSpawnByQuest);
			set => SetProperty(ref _blockReconDroneSpawnByQuest, value);
		}

		[Ordinal(7)] 
		[RED("crimeScoreMultiplierByQuest")] 
		public CFloat CrimeScoreMultiplierByQuest
		{
			get => GetProperty(ref _crimeScoreMultiplierByQuest);
			set => SetProperty(ref _crimeScoreMultiplierByQuest, value);
		}

		[Ordinal(8)] 
		[RED("preventionQuestEventSources")] 
		public CArray<CName> PreventionQuestEventSources
		{
			get => GetProperty(ref _preventionQuestEventSources);
			set => SetProperty(ref _preventionQuestEventSources, value);
		}

		[Ordinal(9)] 
		[RED("systemLockSources")] 
		public CArray<CName> SystemLockSources
		{
			get => GetProperty(ref _systemLockSources);
			set => SetProperty(ref _systemLockSources, value);
		}

		[Ordinal(10)] 
		[RED("systemEnabled")] 
		public CBool SystemEnabled
		{
			get => GetProperty(ref _systemEnabled);
			set => SetProperty(ref _systemEnabled, value);
		}

		[Ordinal(11)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(12)] 
		[RED("preventionPreset")] 
		public wCHandle<gamedataDistrictPreventionData_Record> PreventionPreset
		{
			get => GetProperty(ref _preventionPreset);
			set => SetProperty(ref _preventionPreset, value);
		}

		[Ordinal(13)] 
		[RED("preventionDataMatrix")] 
		public wCHandle<gamedataPreventionHeatDataMatrix_Record> PreventionDataMatrix
		{
			get => GetProperty(ref _preventionDataMatrix);
			set => SetProperty(ref _preventionDataMatrix, value);
		}

		[Ordinal(14)] 
		[RED("preventionDataTable")] 
		public wCHandle<gamedataPreventionHeatTable_Record> PreventionDataTable
		{
			get => GetProperty(ref _preventionDataTable);
			set => SetProperty(ref _preventionDataTable, value);
		}

		[Ordinal(15)] 
		[RED("systemLocked")] 
		public CBool SystemLocked
		{
			get => GetProperty(ref _systemLocked);
			set => SetProperty(ref _systemLocked, value);
		}

		[Ordinal(16)] 
		[RED("nodeEventSources")] 
		public CArray<CName> NodeEventSources
		{
			get => GetProperty(ref _nodeEventSources);
			set => SetProperty(ref _nodeEventSources, value);
		}

		[Ordinal(17)] 
		[RED("heatStage")] 
		public CEnum<EPreventionHeatStage> HeatStage
		{
			get => GetProperty(ref _heatStage);
			set => SetProperty(ref _heatStage, value);
		}

		[Ordinal(18)] 
		[RED("heatChangeReason")] 
		public CString HeatChangeReason
		{
			get => GetProperty(ref _heatChangeReason);
			set => SetProperty(ref _heatChangeReason, value);
		}

		[Ordinal(19)] 
		[RED("ignoreSecurityAreas")] 
		public CBool IgnoreSecurityAreas
		{
			get => GetProperty(ref _ignoreSecurityAreas);
			set => SetProperty(ref _ignoreSecurityAreas, value);
		}

		[Ordinal(20)] 
		[RED("playerIsInSecurityArea")] 
		public CArray<gamePersistentID> PlayerIsInSecurityArea
		{
			get => GetProperty(ref _playerIsInSecurityArea);
			set => SetProperty(ref _playerIsInSecurityArea, value);
		}

		[Ordinal(21)] 
		[RED("playerIsInPreventionFreeArea")] 
		public CBool PlayerIsInPreventionFreeArea
		{
			get => GetProperty(ref _playerIsInPreventionFreeArea);
			set => SetProperty(ref _playerIsInPreventionFreeArea, value);
		}

		[Ordinal(22)] 
		[RED("policeSecuritySystems")] 
		public CArray<gamePersistentID> PoliceSecuritySystems
		{
			get => GetProperty(ref _policeSecuritySystems);
			set => SetProperty(ref _policeSecuritySystems, value);
		}

		[Ordinal(23)] 
		[RED("agentGroupsList")] 
		public CArray<CHandle<PreventionAgents>> AgentGroupsList
		{
			get => GetProperty(ref _agentGroupsList);
			set => SetProperty(ref _agentGroupsList, value);
		}

		[Ordinal(24)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetProperty(ref _lastKnownPosition);
			set => SetProperty(ref _lastKnownPosition, value);
		}

		[Ordinal(25)] 
		[RED("lastKnownVehicle")] 
		public wCHandle<vehicleBaseObject> LastKnownVehicle
		{
			get => GetProperty(ref _lastKnownVehicle);
			set => SetProperty(ref _lastKnownVehicle, value);
		}

		[Ordinal(26)] 
		[RED("districtMultiplier")] 
		public CFloat DistrictMultiplier
		{
			get => GetProperty(ref _districtMultiplier);
			set => SetProperty(ref _districtMultiplier, value);
		}

		[Ordinal(27)] 
		[RED("shouldForceStarStateUIToActive")] 
		public CBool ShouldForceStarStateUIToActive
		{
			get => GetProperty(ref _shouldForceStarStateUIToActive);
			set => SetProperty(ref _shouldForceStarStateUIToActive, value);
		}

		[Ordinal(28)] 
		[RED("lastAttackTime")] 
		public CFloat LastAttackTime
		{
			get => GetProperty(ref _lastAttackTime);
			set => SetProperty(ref _lastAttackTime, value);
		}

		[Ordinal(29)] 
		[RED("lastAttackTargetIDs")] 
		public CArray<entEntityID> LastAttackTargetIDs
		{
			get => GetProperty(ref _lastAttackTargetIDs);
			set => SetProperty(ref _lastAttackTargetIDs, value);
		}

		[Ordinal(30)] 
		[RED("viewers")] 
		public CArray<wCHandle<gameObject>> Viewers
		{
			get => GetProperty(ref _viewers);
			set => SetProperty(ref _viewers, value);
		}

		[Ordinal(31)] 
		[RED("hasViewers")] 
		public CBool HasViewers
		{
			get => GetProperty(ref _hasViewers);
			set => SetProperty(ref _hasViewers, value);
		}

		[Ordinal(32)] 
		[RED("starState")] 
		public CEnum<EStarState> StarState
		{
			get => GetProperty(ref _starState);
			set => SetProperty(ref _starState, value);
		}

		[Ordinal(33)] 
		[RED("starStateUIChanged")] 
		public CBool StarStateUIChanged
		{
			get => GetProperty(ref _starStateUIChanged);
			set => SetProperty(ref _starStateUIChanged, value);
		}

		[Ordinal(34)] 
		[RED("isPlayerMounted")] 
		public CBool IsPlayerMounted
		{
			get => GetProperty(ref _isPlayerMounted);
			set => SetProperty(ref _isPlayerMounted, value);
		}

		[Ordinal(35)] 
		[RED("policeKnowsPlayerLocation")] 
		public CBool PoliceKnowsPlayerLocation
		{
			get => GetProperty(ref _policeKnowsPlayerLocation);
			set => SetProperty(ref _policeKnowsPlayerLocation, value);
		}

		[Ordinal(36)] 
		[RED("isInitialSearchState")] 
		public CBool IsInitialSearchState
		{
			get => GetProperty(ref _isInitialSearchState);
			set => SetProperty(ref _isInitialSearchState, value);
		}

		[Ordinal(37)] 
		[RED("heatLevelChanged")] 
		public CBool HeatLevelChanged
		{
			get => GetProperty(ref _heatLevelChanged);
			set => SetProperty(ref _heatLevelChanged, value);
		}

		[Ordinal(38)] 
		[RED("playerCrossedBufferDistance")] 
		public CBool PlayerCrossedBufferDistance
		{
			get => GetProperty(ref _playerCrossedBufferDistance);
			set => SetProperty(ref _playerCrossedBufferDistance, value);
		}

		[Ordinal(39)] 
		[RED("crimescoreTimerDelayID")] 
		public gameDelayID CrimescoreTimerDelayID
		{
			get => GetProperty(ref _crimescoreTimerDelayID);
			set => SetProperty(ref _crimescoreTimerDelayID, value);
		}

		[Ordinal(40)] 
		[RED("starStateBufferTimerDelayID")] 
		public gameDelayID StarStateBufferTimerDelayID
		{
			get => GetProperty(ref _starStateBufferTimerDelayID);
			set => SetProperty(ref _starStateBufferTimerDelayID, value);
		}

		[Ordinal(41)] 
		[RED("beliefAccuracyTimerDelayID")] 
		public gameDelayID BeliefAccuracyTimerDelayID
		{
			get => GetProperty(ref _beliefAccuracyTimerDelayID);
			set => SetProperty(ref _beliefAccuracyTimerDelayID, value);
		}

		[Ordinal(42)] 
		[RED("blinkingStatusDelayID")] 
		public gameDelayID BlinkingStatusDelayID
		{
			get => GetProperty(ref _blinkingStatusDelayID);
			set => SetProperty(ref _blinkingStatusDelayID, value);
		}

		[Ordinal(43)] 
		[RED("searchingStatusDelayID")] 
		public gameDelayID SearchingStatusDelayID
		{
			get => GetProperty(ref _searchingStatusDelayID);
			set => SetProperty(ref _searchingStatusDelayID, value);
		}

		[Ordinal(44)] 
		[RED("transitionToGreyStateDelayID")] 
		public gameDelayID TransitionToGreyStateDelayID
		{
			get => GetProperty(ref _transitionToGreyStateDelayID);
			set => SetProperty(ref _transitionToGreyStateDelayID, value);
		}

		[Ordinal(45)] 
		[RED("policemenSpawnDelayID")] 
		public gameDelayID PolicemenSpawnDelayID
		{
			get => GetProperty(ref _policemenSpawnDelayID);
			set => SetProperty(ref _policemenSpawnDelayID, value);
		}

		[Ordinal(46)] 
		[RED("securityAreaResetDelayID")] 
		public gameDelayID SecurityAreaResetDelayID
		{
			get => GetProperty(ref _securityAreaResetDelayID);
			set => SetProperty(ref _securityAreaResetDelayID, value);
		}

		[Ordinal(47)] 
		[RED("inputlockDelayID")] 
		public gameDelayID InputlockDelayID
		{
			get => GetProperty(ref _inputlockDelayID);
			set => SetProperty(ref _inputlockDelayID, value);
		}

		[Ordinal(48)] 
		[RED("freeAreaResetDelayID")] 
		public gameDelayID FreeAreaResetDelayID
		{
			get => GetProperty(ref _freeAreaResetDelayID);
			set => SetProperty(ref _freeAreaResetDelayID, value);
		}

		[Ordinal(49)] 
		[RED("securityAreaResetCheck")] 
		public CBool SecurityAreaResetCheck
		{
			get => GetProperty(ref _securityAreaResetCheck);
			set => SetProperty(ref _securityAreaResetCheck, value);
		}

		[Ordinal(50)] 
		[RED("hadOngoingSpawnRequest")] 
		public CBool HadOngoingSpawnRequest
		{
			get => GetProperty(ref _hadOngoingSpawnRequest);
			set => SetProperty(ref _hadOngoingSpawnRequest, value);
		}

		[Ordinal(51)] 
		[RED("totalCrimeScore")] 
		public CFloat TotalCrimeScore
		{
			get => GetProperty(ref _totalCrimeScore);
			set => SetProperty(ref _totalCrimeScore, value);
		}

		[Ordinal(52)] 
		[RED("canSpawnFallbackEarly")] 
		public CBool CanSpawnFallbackEarly
		{
			get => GetProperty(ref _canSpawnFallbackEarly);
			set => SetProperty(ref _canSpawnFallbackEarly, value);
		}

		[Ordinal(53)] 
		[RED("failsafePoliceRecordT1")] 
		public TweakDBID FailsafePoliceRecordT1
		{
			get => GetProperty(ref _failsafePoliceRecordT1);
			set => SetProperty(ref _failsafePoliceRecordT1, value);
		}

		[Ordinal(54)] 
		[RED("failsafePoliceRecordT2")] 
		public TweakDBID FailsafePoliceRecordT2
		{
			get => GetProperty(ref _failsafePoliceRecordT2);
			set => SetProperty(ref _failsafePoliceRecordT2, value);
		}

		[Ordinal(55)] 
		[RED("failsafePoliceRecordT3")] 
		public TweakDBID FailsafePoliceRecordT3
		{
			get => GetProperty(ref _failsafePoliceRecordT3);
			set => SetProperty(ref _failsafePoliceRecordT3, value);
		}

		[Ordinal(56)] 
		[RED("blinkReasonsStack")] 
		public CArray<CName> BlinkReasonsStack
		{
			get => GetProperty(ref _blinkReasonsStack);
			set => SetProperty(ref _blinkReasonsStack, value);
		}

		[Ordinal(57)] 
		[RED("wantedBarBlackboard")] 
		public wCHandle<gameIBlackboard> WantedBarBlackboard
		{
			get => GetProperty(ref _wantedBarBlackboard);
			set => SetProperty(ref _wantedBarBlackboard, value);
		}

		[Ordinal(58)] 
		[RED("onPlayerChoiceCallID")] 
		public CHandle<redCallbackObject> OnPlayerChoiceCallID
		{
			get => GetProperty(ref _onPlayerChoiceCallID);
			set => SetProperty(ref _onPlayerChoiceCallID, value);
		}

		[Ordinal(59)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(60)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(61)] 
		[RED("playerHLSID")] 
		public CHandle<redCallbackObject> PlayerHLSID
		{
			get => GetProperty(ref _playerHLSID);
			set => SetProperty(ref _playerHLSID, value);
		}

		[Ordinal(62)] 
		[RED("playerVehicleStateID")] 
		public CHandle<redCallbackObject> PlayerVehicleStateID
		{
			get => GetProperty(ref _playerVehicleStateID);
			set => SetProperty(ref _playerVehicleStateID, value);
		}

		[Ordinal(63)] 
		[RED("playerHLS")] 
		public CEnum<gamePSMHighLevel> PlayerHLS
		{
			get => GetProperty(ref _playerHLS);
			set => SetProperty(ref _playerHLS, value);
		}

		[Ordinal(64)] 
		[RED("playerVehicleState")] 
		public CEnum<gamePSMVehicle> PlayerVehicleState
		{
			get => GetProperty(ref _playerVehicleState);
			set => SetProperty(ref _playerVehicleState, value);
		}

		[Ordinal(65)] 
		[RED("unhandledInputsReceived")] 
		public CInt32 UnhandledInputsReceived
		{
			get => GetProperty(ref _unhandledInputsReceived);
			set => SetProperty(ref _unhandledInputsReceived, value);
		}

		[Ordinal(66)] 
		[RED("preventionUnitKilledDuringLock")] 
		public CBool PreventionUnitKilledDuringLock
		{
			get => GetProperty(ref _preventionUnitKilledDuringLock);
			set => SetProperty(ref _preventionUnitKilledDuringLock, value);
		}

		[Ordinal(67)] 
		[RED("previousHitTargetID")] 
		public entEntityID PreviousHitTargetID
		{
			get => GetProperty(ref _previousHitTargetID);
			set => SetProperty(ref _previousHitTargetID, value);
		}

		[Ordinal(68)] 
		[RED("previousHitAttackTime")] 
		public CFloat PreviousHitAttackTime
		{
			get => GetProperty(ref _previousHitAttackTime);
			set => SetProperty(ref _previousHitAttackTime, value);
		}

		[Ordinal(69)] 
		[RED("reconPhaseEnabled")] 
		public CBool ReconPhaseEnabled
		{
			get => GetProperty(ref _reconPhaseEnabled);
			set => SetProperty(ref _reconPhaseEnabled, value);
		}

		[Ordinal(70)] 
		[RED("reconDeployed")] 
		public CBool ReconDeployed
		{
			get => GetProperty(ref _reconDeployed);
			set => SetProperty(ref _reconDeployed, value);
		}

		[Ordinal(71)] 
		[RED("reconDestroyed")] 
		public CBool ReconDestroyed
		{
			get => GetProperty(ref _reconDestroyed);
			set => SetProperty(ref _reconDestroyed, value);
		}

		[Ordinal(72)] 
		[RED("minHeatLevel")] 
		public CEnum<EPreventionHeatStage> MinHeatLevel
		{
			get => GetProperty(ref _minHeatLevel);
			set => SetProperty(ref _minHeatLevel, value);
		}

		[Ordinal(73)] 
		[RED("maxHeatLevel")] 
		public CEnum<EPreventionHeatStage> MaxHeatLevel
		{
			get => GetProperty(ref _maxHeatLevel);
			set => SetProperty(ref _maxHeatLevel, value);
		}

		[Ordinal(74)] 
		[RED("defaultHeatLevels")] 
		public CBool DefaultHeatLevels
		{
			get => GetProperty(ref _defaultHeatLevels);
			set => SetProperty(ref _defaultHeatLevels, value);
		}

		[Ordinal(75)] 
		[RED("vehicleSpawnBlockSide")] 
		public CEnum<EVehicleSpawnBlockSide> VehicleSpawnBlockSide
		{
			get => GetProperty(ref _vehicleSpawnBlockSide);
			set => SetProperty(ref _vehicleSpawnBlockSide, value);
		}

		[Ordinal(76)] 
		[RED("damageToPlayerMultiplier")] 
		public CFloat DamageToPlayerMultiplier
		{
			get => GetProperty(ref _damageToPlayerMultiplier);
			set => SetProperty(ref _damageToPlayerMultiplier, value);
		}

		[Ordinal(77)] 
		[RED("chaseMultiplier")] 
		public CFloat ChaseMultiplier
		{
			get => GetProperty(ref _chaseMultiplier);
			set => SetProperty(ref _chaseMultiplier, value);
		}

		[Ordinal(78)] 
		[RED("policeChaseBlackboard")] 
		public wCHandle<gameIBlackboard> PoliceChaseBlackboard
		{
			get => GetProperty(ref _policeChaseBlackboard);
			set => SetProperty(ref _policeChaseBlackboard, value);
		}

		[Ordinal(79)] 
		[RED("blockShootingFromVehicle")] 
		public CBool BlockShootingFromVehicle
		{
			get => GetProperty(ref _blockShootingFromVehicle);
			set => SetProperty(ref _blockShootingFromVehicle, value);
		}

		[Ordinal(80)] 
		[RED("Debug_ProcessReason")] 
		public CEnum<EPreventionDebugProcessReason> Debug_ProcessReason
		{
			get => GetProperty(ref _debug_ProcessReason);
			set => SetProperty(ref _debug_ProcessReason, value);
		}

		[Ordinal(81)] 
		[RED("Debug_LastAttackType")] 
		public CEnum<gamedataAttackType> Debug_LastAttackType
		{
			get => GetProperty(ref _debug_LastAttackType);
			set => SetProperty(ref _debug_LastAttackType, value);
		}

		[Ordinal(82)] 
		[RED("Debug_LastDamageDealt")] 
		public CFloat Debug_LastDamageDealt
		{
			get => GetProperty(ref _debug_LastDamageDealt);
			set => SetProperty(ref _debug_LastDamageDealt, value);
		}

		[Ordinal(83)] 
		[RED("Debug_LastCrimeDistance")] 
		public CFloat Debug_LastCrimeDistance
		{
			get => GetProperty(ref _debug_LastCrimeDistance);
			set => SetProperty(ref _debug_LastCrimeDistance, value);
		}

		[Ordinal(84)] 
		[RED("Debug_lastAVRequestedSpawnPosition")] 
		public Vector3 Debug_lastAVRequestedSpawnPosition
		{
			get => GetProperty(ref _debug_lastAVRequestedSpawnPosition);
			set => SetProperty(ref _debug_lastAVRequestedSpawnPosition, value);
		}

		[Ordinal(85)] 
		[RED("temp_const_false")] 
		public CBool Temp_const_false
		{
			get => GetProperty(ref _temp_const_false);
			set => SetProperty(ref _temp_const_false, value);
		}

		[Ordinal(86)] 
		[RED("preventionTickCaller")] 
		public CHandle<IntervalCaller> PreventionTickCaller
		{
			get => GetProperty(ref _preventionTickCaller);
			set => SetProperty(ref _preventionTickCaller, value);
		}

		[Ordinal(87)] 
		[RED("roadblockadeRespawnTickCaller")] 
		public CHandle<IntervalCaller> RoadblockadeRespawnTickCaller
		{
			get => GetProperty(ref _roadblockadeRespawnTickCaller);
			set => SetProperty(ref _roadblockadeRespawnTickCaller, value);
		}

		[Ordinal(88)] 
		[RED("maxtacTicketID")] 
		public CUInt32 MaxtacTicketID
		{
			get => GetProperty(ref _maxtacTicketID);
			set => SetProperty(ref _maxtacTicketID, value);
		}

		[Ordinal(89)] 
		[RED("avSpawnPointList")] 
		public CArray<Vector3> AvSpawnPointList
		{
			get => GetProperty(ref _avSpawnPointList);
			set => SetProperty(ref _avSpawnPointList, value);
		}

		[Ordinal(90)] 
		[RED("maxAllowedDistanceToPlayer")] 
		public CFloat MaxAllowedDistanceToPlayer
		{
			get => GetProperty(ref _maxAllowedDistanceToPlayer);
			set => SetProperty(ref _maxAllowedDistanceToPlayer, value);
		}

		[Ordinal(91)] 
		[RED("lastAVRequestedSpawnPositionsArray")] 
		public CArray<Vector4> LastAVRequestedSpawnPositionsArray
		{
			get => GetProperty(ref _lastAVRequestedSpawnPositionsArray);
			set => SetProperty(ref _lastAVRequestedSpawnPositionsArray, value);
		}

		[Ordinal(92)] 
		[RED("shouldPreventionUnitsStartRetreating")] 
		public CBool ShouldPreventionUnitsStartRetreating
		{
			get => GetProperty(ref _shouldPreventionUnitsStartRetreating);
			set => SetProperty(ref _shouldPreventionUnitsStartRetreating, value);
		}

		[Ordinal(93)] 
		[RED("numberOfMaxtacSquadsSpawned")] 
		public CInt32 NumberOfMaxtacSquadsSpawned
		{
			get => GetProperty(ref _numberOfMaxtacSquadsSpawned);
			set => SetProperty(ref _numberOfMaxtacSquadsSpawned, value);
		}

		[Ordinal(94)] 
		[RED("maxtacTroopBeingAliveTimeStamp")] 
		public CFloat MaxtacTroopBeingAliveTimeStamp
		{
			get => GetProperty(ref _maxtacTroopBeingAliveTimeStamp);
			set => SetProperty(ref _maxtacTroopBeingAliveTimeStamp, value);
		}

		[Ordinal(95)] 
		[RED("civilianVehicleDestructionCount")] 
		public CInt32 CivilianVehicleDestructionCount
		{
			get => GetProperty(ref _civilianVehicleDestructionCount);
			set => SetProperty(ref _civilianVehicleDestructionCount, value);
		}

		[Ordinal(96)] 
		[RED("lastCivilianVehicleDestructionTimeStamp")] 
		public CFloat LastCivilianVehicleDestructionTimeStamp
		{
			get => GetProperty(ref _lastCivilianVehicleDestructionTimeStamp);
			set => SetProperty(ref _lastCivilianVehicleDestructionTimeStamp, value);
		}

		[Ordinal(97)] 
		[RED("civilianVehicleDestructionThreshold")] 
		public CInt32 CivilianVehicleDestructionThreshold
		{
			get => GetProperty(ref _civilianVehicleDestructionThreshold);
			set => SetProperty(ref _civilianVehicleDestructionThreshold, value);
		}

		[Ordinal(98)] 
		[RED("civilianVehicleDestructionTimeout")] 
		public CFloat CivilianVehicleDestructionTimeout
		{
			get => GetProperty(ref _civilianVehicleDestructionTimeout);
			set => SetProperty(ref _civilianVehicleDestructionTimeout, value);
		}

		[Ordinal(99)] 
		[RED("vehicleSpawnTickCaller")] 
		public CHandle<IntervalCaller> VehicleSpawnTickCaller
		{
			get => GetProperty(ref _vehicleSpawnTickCaller);
			set => SetProperty(ref _vehicleSpawnTickCaller, value);
		}

		[Ordinal(100)] 
		[RED("ressuplyVehicleTicketCaller")] 
		public CHandle<IntervalCaller> RessuplyVehicleTicketCaller
		{
			get => GetProperty(ref _ressuplyVehicleTicketCaller);
			set => SetProperty(ref _ressuplyVehicleTicketCaller, value);
		}

		[Ordinal(101)] 
		[RED("isVehicleDelayOver")] 
		public CBool IsVehicleDelayOver
		{
			get => GetProperty(ref _isVehicleDelayOver);
			set => SetProperty(ref _isVehicleDelayOver, value);
		}

		[Ordinal(102)] 
		[RED("currentVehicleTicketCount")] 
		public CInt32 CurrentVehicleTicketCount
		{
			get => GetProperty(ref _currentVehicleTicketCount);
			set => SetProperty(ref _currentVehicleTicketCount, value);
		}

		[Ordinal(103)] 
		[RED("failedVehicleSpawnAttempts")] 
		public CInt32 FailedVehicleSpawnAttempts
		{
			get => GetProperty(ref _failedVehicleSpawnAttempts);
			set => SetProperty(ref _failedVehicleSpawnAttempts, value);
		}

		[Ordinal(104)] 
		[RED("codeRedReinforcement")] 
		public CBool CodeRedReinforcement
		{
			get => GetProperty(ref _codeRedReinforcement);
			set => SetProperty(ref _codeRedReinforcement, value);
		}

		[Ordinal(105)] 
		[RED("lastStarChangeTimeStamp")] 
		public CFloat LastStarChangeTimeStamp
		{
			get => GetProperty(ref _lastStarChangeTimeStamp);
			set => SetProperty(ref _lastStarChangeTimeStamp, value);
		}

		[Ordinal(106)] 
		[RED("firstStarTimeStamp")] 
		public CFloat FirstStarTimeStamp
		{
			get => GetProperty(ref _firstStarTimeStamp);
			set => SetProperty(ref _firstStarTimeStamp, value);
		}

		[Ordinal(107)] 
		[RED("setCallRejectionIncrement")] 
		public CBool SetCallRejectionIncrement
		{
			get => GetProperty(ref _setCallRejectionIncrement);
			set => SetProperty(ref _setCallRejectionIncrement, value);
		}

		public PreventionSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
