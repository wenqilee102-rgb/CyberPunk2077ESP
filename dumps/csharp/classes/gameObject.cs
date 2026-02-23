using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameObject : entGameEntity
	{
		private CHandle<gamePersistentState> _persistentState;
		private gamePlayerSocket _playerSocket;
		private CHandle<entSlotComponent> _uiSlotComponent;
		private redTagList _tags;
		private LocalizationString _displayName;
		private LocalizationString _displayDescription;
		private CName _audioResourceName;
		private CFloat _visibilityCheckDistance;
		private CBool _forceRegisterInHudManager;
		private CArray<CHandle<GameObjectListener>> _prereqListeners;
		private CArray<CHandle<StatusEffectTriggerListener>> _statusEffectListeners;
		private CFloat _lastEngineTime;
		private CFloat _accumulatedTimePasssed;
		private CHandle<gameScanningComponent> _scanningComponent;
		private CHandle<gameVisionModeComponent> _visionComponent;
		private CBool _isHighlightedInFocusMode;
		private CHandle<gameStatusEffectComponent> _statusEffectComponent;
		private CBool _markAsQuest;
		private CBool _e3ObjectRevealed;
		private CHandle<WorkspotMapperComponent> _workspotMapper;
		private CHandle<StimBroadcasterComponent> _stimBroadcaster;
		private CHandle<SquadMemberBaseComponent> _squadMemberComponent;
		private CHandle<gameSourceShootComponent> _sourceShootComponent;
		private CHandle<gameTargetShootComponent> _targetShootComponent;
		private CArray<DamageHistoryEntry> _receivedDamageHistory;
		private CBool _forceDefeatReward;
		private CBool _killRewardDisabled;
		private CBool _willDieSoon;
		private CBool _isScannerDataDirty;
		private CBool _hasVisibilityForcedInAnimSystem;
		private CBool _isDead;
		private entEntityID _lastHitInstigatorID;
		private gameDelayID _hitInstigatorCooldownID;
		private CBool _isTargetedWithSmartWeapon;

		[Ordinal(2)] 
		[RED("persistentState")] 
		public CHandle<gamePersistentState> PersistentState
		{
			get => GetProperty(ref _persistentState);
			set => SetProperty(ref _persistentState, value);
		}

		[Ordinal(3)] 
		[RED("playerSocket")] 
		public gamePlayerSocket PlayerSocket
		{
			get => GetProperty(ref _playerSocket);
			set => SetProperty(ref _playerSocket, value);
		}

		[Ordinal(4)] 
		[RED("uiSlotComponent")] 
		public CHandle<entSlotComponent> UiSlotComponent
		{
			get => GetProperty(ref _uiSlotComponent);
			set => SetProperty(ref _uiSlotComponent, value);
		}

		[Ordinal(5)] 
		[RED("tags")] 
		public redTagList Tags
		{
			get => GetProperty(ref _tags);
			set => SetProperty(ref _tags, value);
		}

		[Ordinal(6)] 
		[RED("displayName")] 
		public LocalizationString DisplayName
		{
			get => GetProperty(ref _displayName);
			set => SetProperty(ref _displayName, value);
		}

		[Ordinal(7)] 
		[RED("displayDescription")] 
		public LocalizationString DisplayDescription
		{
			get => GetProperty(ref _displayDescription);
			set => SetProperty(ref _displayDescription, value);
		}

		[Ordinal(8)] 
		[RED("audioResourceName")] 
		public CName AudioResourceName
		{
			get => GetProperty(ref _audioResourceName);
			set => SetProperty(ref _audioResourceName, value);
		}

		[Ordinal(9)] 
		[RED("visibilityCheckDistance")] 
		public CFloat VisibilityCheckDistance
		{
			get => GetProperty(ref _visibilityCheckDistance);
			set => SetProperty(ref _visibilityCheckDistance, value);
		}

		[Ordinal(10)] 
		[RED("forceRegisterInHudManager")] 
		public CBool ForceRegisterInHudManager
		{
			get => GetProperty(ref _forceRegisterInHudManager);
			set => SetProperty(ref _forceRegisterInHudManager, value);
		}

		[Ordinal(11)] 
		[RED("prereqListeners")] 
		public CArray<CHandle<GameObjectListener>> PrereqListeners
		{
			get => GetProperty(ref _prereqListeners);
			set => SetProperty(ref _prereqListeners, value);
		}

		[Ordinal(12)] 
		[RED("statusEffectListeners")] 
		public CArray<CHandle<StatusEffectTriggerListener>> StatusEffectListeners
		{
			get => GetProperty(ref _statusEffectListeners);
			set => SetProperty(ref _statusEffectListeners, value);
		}

		[Ordinal(13)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get => GetProperty(ref _lastEngineTime);
			set => SetProperty(ref _lastEngineTime, value);
		}

		[Ordinal(14)] 
		[RED("accumulatedTimePasssed")] 
		public CFloat AccumulatedTimePasssed
		{
			get => GetProperty(ref _accumulatedTimePasssed);
			set => SetProperty(ref _accumulatedTimePasssed, value);
		}

		[Ordinal(15)] 
		[RED("scanningComponent")] 
		public CHandle<gameScanningComponent> ScanningComponent
		{
			get => GetProperty(ref _scanningComponent);
			set => SetProperty(ref _scanningComponent, value);
		}

		[Ordinal(16)] 
		[RED("visionComponent")] 
		public CHandle<gameVisionModeComponent> VisionComponent
		{
			get => GetProperty(ref _visionComponent);
			set => SetProperty(ref _visionComponent, value);
		}

		[Ordinal(17)] 
		[RED("isHighlightedInFocusMode")] 
		public CBool IsHighlightedInFocusMode
		{
			get => GetProperty(ref _isHighlightedInFocusMode);
			set => SetProperty(ref _isHighlightedInFocusMode, value);
		}

		[Ordinal(18)] 
		[RED("statusEffectComponent")] 
		public CHandle<gameStatusEffectComponent> StatusEffectComponent
		{
			get => GetProperty(ref _statusEffectComponent);
			set => SetProperty(ref _statusEffectComponent, value);
		}

		[Ordinal(19)] 
		[RED("markAsQuest")] 
		public CBool MarkAsQuest
		{
			get => GetProperty(ref _markAsQuest);
			set => SetProperty(ref _markAsQuest, value);
		}

		[Ordinal(20)] 
		[RED("e3ObjectRevealed")] 
		public CBool E3ObjectRevealed
		{
			get => GetProperty(ref _e3ObjectRevealed);
			set => SetProperty(ref _e3ObjectRevealed, value);
		}

		[Ordinal(21)] 
		[RED("workspotMapper")] 
		public CHandle<WorkspotMapperComponent> WorkspotMapper
		{
			get => GetProperty(ref _workspotMapper);
			set => SetProperty(ref _workspotMapper, value);
		}

		[Ordinal(22)] 
		[RED("stimBroadcaster")] 
		public CHandle<StimBroadcasterComponent> StimBroadcaster
		{
			get => GetProperty(ref _stimBroadcaster);
			set => SetProperty(ref _stimBroadcaster, value);
		}

		[Ordinal(23)] 
		[RED("squadMemberComponent")] 
		public CHandle<SquadMemberBaseComponent> SquadMemberComponent
		{
			get => GetProperty(ref _squadMemberComponent);
			set => SetProperty(ref _squadMemberComponent, value);
		}

		[Ordinal(24)] 
		[RED("sourceShootComponent")] 
		public CHandle<gameSourceShootComponent> SourceShootComponent
		{
			get => GetProperty(ref _sourceShootComponent);
			set => SetProperty(ref _sourceShootComponent, value);
		}

		[Ordinal(25)] 
		[RED("targetShootComponent")] 
		public CHandle<gameTargetShootComponent> TargetShootComponent
		{
			get => GetProperty(ref _targetShootComponent);
			set => SetProperty(ref _targetShootComponent, value);
		}

		[Ordinal(26)] 
		[RED("receivedDamageHistory")] 
		public CArray<DamageHistoryEntry> ReceivedDamageHistory
		{
			get => GetProperty(ref _receivedDamageHistory);
			set => SetProperty(ref _receivedDamageHistory, value);
		}

		[Ordinal(27)] 
		[RED("forceDefeatReward")] 
		public CBool ForceDefeatReward
		{
			get => GetProperty(ref _forceDefeatReward);
			set => SetProperty(ref _forceDefeatReward, value);
		}

		[Ordinal(28)] 
		[RED("killRewardDisabled")] 
		public CBool KillRewardDisabled
		{
			get => GetProperty(ref _killRewardDisabled);
			set => SetProperty(ref _killRewardDisabled, value);
		}

		[Ordinal(29)] 
		[RED("willDieSoon")] 
		public CBool WillDieSoon
		{
			get => GetProperty(ref _willDieSoon);
			set => SetProperty(ref _willDieSoon, value);
		}

		[Ordinal(30)] 
		[RED("isScannerDataDirty")] 
		public CBool IsScannerDataDirty
		{
			get => GetProperty(ref _isScannerDataDirty);
			set => SetProperty(ref _isScannerDataDirty, value);
		}

		[Ordinal(31)] 
		[RED("hasVisibilityForcedInAnimSystem")] 
		public CBool HasVisibilityForcedInAnimSystem
		{
			get => GetProperty(ref _hasVisibilityForcedInAnimSystem);
			set => SetProperty(ref _hasVisibilityForcedInAnimSystem, value);
		}

		[Ordinal(32)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(33)] 
		[RED("lastHitInstigatorID")] 
		public entEntityID LastHitInstigatorID
		{
			get => GetProperty(ref _lastHitInstigatorID);
			set => SetProperty(ref _lastHitInstigatorID, value);
		}

		[Ordinal(34)] 
		[RED("hitInstigatorCooldownID")] 
		public gameDelayID HitInstigatorCooldownID
		{
			get => GetProperty(ref _hitInstigatorCooldownID);
			set => SetProperty(ref _hitInstigatorCooldownID, value);
		}

		[Ordinal(35)] 
		[RED("isTargetedWithSmartWeapon")] 
		public CBool IsTargetedWithSmartWeapon
		{
			get => GetProperty(ref _isTargetedWithSmartWeapon);
			set => SetProperty(ref _isTargetedWithSmartWeapon, value);
		}

		public gameObject(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
