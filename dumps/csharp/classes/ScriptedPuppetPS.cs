using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScriptedPuppetPS : gamePuppetPS
	{
		private wCHandle<PuppetDeviceLinkPS> _deviceLink;
		private CHandle<CooldownStorage> _cooldownStorage;
		private CEnum<EBOOL> _isInitialized;
		private CBool _wasAttached;
		private CBool _wasRevealedInNetworkPing;
		private CInt32 _numberActions;
		private CBool _wasQuickHackAttempt;
		private CBool _hasDirectInteractionChoicesActive;
		private CBool _wasIncapacitated;
		private CBool _isBreached;
		private CBool _isDead;
		private CBool _isIncapacitated;
		private CBool _isAndroidTurnedOff;
		private CBool _isPreventionNotified;
		private SecuritySystemData _securitySystemData;
		private CArray<CEnum<gamedeviceRequestType>> _activeContexts;
		private CName _lastInteractionLayerTag;
		private CBool _quickHacksExposed;
		private CUInt32 _currentCooldownID;
		private TweakDBID _reactionPresetID;
		private CBool _isDefeatMechanicActive;
		private gameItemID _leftHandLoadout;
		private gameItemID _rightHandLoadout;
		private CArray<CachedItemLoadout> _customWeaponLoadout;
		private CachedItemLoadout _genericMeleeLoadout;
		private CachedItemLoadout _genericRangedLoadout;
		private TweakDBID _questForceScannerPreset;
		private TweakDBID _bountyID;
		private CArray<TweakDBID> _transgressions;

		[Ordinal(6)] 
		[RED("deviceLink")] 
		public wCHandle<PuppetDeviceLinkPS> DeviceLink
		{
			get => GetProperty(ref _deviceLink);
			set => SetProperty(ref _deviceLink, value);
		}

		[Ordinal(7)] 
		[RED("cooldownStorage")] 
		public CHandle<CooldownStorage> CooldownStorage
		{
			get => GetProperty(ref _cooldownStorage);
			set => SetProperty(ref _cooldownStorage, value);
		}

		[Ordinal(8)] 
		[RED("isInitialized")] 
		public CEnum<EBOOL> IsInitialized
		{
			get => GetProperty(ref _isInitialized);
			set => SetProperty(ref _isInitialized, value);
		}

		[Ordinal(9)] 
		[RED("wasAttached")] 
		public CBool WasAttached
		{
			get => GetProperty(ref _wasAttached);
			set => SetProperty(ref _wasAttached, value);
		}

		[Ordinal(10)] 
		[RED("wasRevealedInNetworkPing")] 
		public CBool WasRevealedInNetworkPing
		{
			get => GetProperty(ref _wasRevealedInNetworkPing);
			set => SetProperty(ref _wasRevealedInNetworkPing, value);
		}

		[Ordinal(11)] 
		[RED("numberActions")] 
		public CInt32 NumberActions
		{
			get => GetProperty(ref _numberActions);
			set => SetProperty(ref _numberActions, value);
		}

		[Ordinal(12)] 
		[RED("wasQuickHackAttempt")] 
		public CBool WasQuickHackAttempt
		{
			get => GetProperty(ref _wasQuickHackAttempt);
			set => SetProperty(ref _wasQuickHackAttempt, value);
		}

		[Ordinal(13)] 
		[RED("hasDirectInteractionChoicesActive")] 
		public CBool HasDirectInteractionChoicesActive
		{
			get => GetProperty(ref _hasDirectInteractionChoicesActive);
			set => SetProperty(ref _hasDirectInteractionChoicesActive, value);
		}

		[Ordinal(14)] 
		[RED("wasIncapacitated")] 
		public CBool WasIncapacitated
		{
			get => GetProperty(ref _wasIncapacitated);
			set => SetProperty(ref _wasIncapacitated, value);
		}

		[Ordinal(15)] 
		[RED("isBreached")] 
		public CBool IsBreached
		{
			get => GetProperty(ref _isBreached);
			set => SetProperty(ref _isBreached, value);
		}

		[Ordinal(16)] 
		[RED("isDead")] 
		public CBool IsDead
		{
			get => GetProperty(ref _isDead);
			set => SetProperty(ref _isDead, value);
		}

		[Ordinal(17)] 
		[RED("isIncapacitated")] 
		public CBool IsIncapacitated
		{
			get => GetProperty(ref _isIncapacitated);
			set => SetProperty(ref _isIncapacitated, value);
		}

		[Ordinal(18)] 
		[RED("isAndroidTurnedOff")] 
		public CBool IsAndroidTurnedOff
		{
			get => GetProperty(ref _isAndroidTurnedOff);
			set => SetProperty(ref _isAndroidTurnedOff, value);
		}

		[Ordinal(19)] 
		[RED("isPreventionNotified")] 
		public CBool IsPreventionNotified
		{
			get => GetProperty(ref _isPreventionNotified);
			set => SetProperty(ref _isPreventionNotified, value);
		}

		[Ordinal(20)] 
		[RED("securitySystemData")] 
		public SecuritySystemData SecuritySystemData
		{
			get => GetProperty(ref _securitySystemData);
			set => SetProperty(ref _securitySystemData, value);
		}

		[Ordinal(21)] 
		[RED("activeContexts")] 
		public CArray<CEnum<gamedeviceRequestType>> ActiveContexts
		{
			get => GetProperty(ref _activeContexts);
			set => SetProperty(ref _activeContexts, value);
		}

		[Ordinal(22)] 
		[RED("lastInteractionLayerTag")] 
		public CName LastInteractionLayerTag
		{
			get => GetProperty(ref _lastInteractionLayerTag);
			set => SetProperty(ref _lastInteractionLayerTag, value);
		}

		[Ordinal(23)] 
		[RED("quickHacksExposed")] 
		public CBool QuickHacksExposed
		{
			get => GetProperty(ref _quickHacksExposed);
			set => SetProperty(ref _quickHacksExposed, value);
		}

		[Ordinal(24)] 
		[RED("currentCooldownID")] 
		public CUInt32 CurrentCooldownID
		{
			get => GetProperty(ref _currentCooldownID);
			set => SetProperty(ref _currentCooldownID, value);
		}

		[Ordinal(25)] 
		[RED("reactionPresetID")] 
		public TweakDBID ReactionPresetID
		{
			get => GetProperty(ref _reactionPresetID);
			set => SetProperty(ref _reactionPresetID, value);
		}

		[Ordinal(26)] 
		[RED("isDefeatMechanicActive")] 
		public CBool IsDefeatMechanicActive
		{
			get => GetProperty(ref _isDefeatMechanicActive);
			set => SetProperty(ref _isDefeatMechanicActive, value);
		}

		[Ordinal(27)] 
		[RED("leftHandLoadout")] 
		public gameItemID LeftHandLoadout
		{
			get => GetProperty(ref _leftHandLoadout);
			set => SetProperty(ref _leftHandLoadout, value);
		}

		[Ordinal(28)] 
		[RED("rightHandLoadout")] 
		public gameItemID RightHandLoadout
		{
			get => GetProperty(ref _rightHandLoadout);
			set => SetProperty(ref _rightHandLoadout, value);
		}

		[Ordinal(29)] 
		[RED("customWeaponLoadout")] 
		public CArray<CachedItemLoadout> CustomWeaponLoadout
		{
			get => GetProperty(ref _customWeaponLoadout);
			set => SetProperty(ref _customWeaponLoadout, value);
		}

		[Ordinal(30)] 
		[RED("genericMeleeLoadout")] 
		public CachedItemLoadout GenericMeleeLoadout
		{
			get => GetProperty(ref _genericMeleeLoadout);
			set => SetProperty(ref _genericMeleeLoadout, value);
		}

		[Ordinal(31)] 
		[RED("genericRangedLoadout")] 
		public CachedItemLoadout GenericRangedLoadout
		{
			get => GetProperty(ref _genericRangedLoadout);
			set => SetProperty(ref _genericRangedLoadout, value);
		}

		[Ordinal(32)] 
		[RED("questForceScannerPreset")] 
		public TweakDBID QuestForceScannerPreset
		{
			get => GetProperty(ref _questForceScannerPreset);
			set => SetProperty(ref _questForceScannerPreset, value);
		}

		[Ordinal(33)] 
		[RED("bountyID")] 
		public TweakDBID BountyID
		{
			get => GetProperty(ref _bountyID);
			set => SetProperty(ref _bountyID, value);
		}

		[Ordinal(34)] 
		[RED("transgressions")] 
		public CArray<TweakDBID> Transgressions
		{
			get => GetProperty(ref _transgressions);
			set => SetProperty(ref _transgressions, value);
		}

		public ScriptedPuppetPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
