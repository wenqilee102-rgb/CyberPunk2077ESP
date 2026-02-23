using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStealthMappinController : gameuiInteractionMappinController
	{
		private inkImageWidgetReference _arrow;
		private inkWidgetReference _fill;
		private inkWidgetReference _eyeFillWhite;
		private inkWidgetReference _eyeFillBlack;
		private inkTextWidgetReference _markExclamation;
		private inkTextWidgetReference _distance;
		private inkWidgetReference _mainArt;
		private inkImageWidgetReference _frame;
		private CName _eliteFrameName;
		private Vector2 _eliteFrameSize;
		private inkWidgetReference _objectMarker;
		private inkImageWidgetReference _levelIcon;
		private inkWidgetReference _taggedContainer;
		private inkCompoundWidgetReference _background;
		private inkCompoundWidgetReference _contagiousQuickhackArrows;
		private inkWidgetReference _statusEffectMain;
		private inkImageWidgetReference _statusEffectIcon;
		private inkWidgetReference _statusEffectFill;
		private inkWidgetReference _statusEffectBackground;
		private wCHandle<gameObject> _ownerObject;
		private wCHandle<NPCPuppet> _ownerNPC;
		private wCHandle<Device> _ownerDevice;
		private wCHandle<gamemappinsStealthMappin> _mappin;
		private wCHandle<inkWidget> _root;
		private wCHandle<inkWidget> _canvas;
		private wCHandle<gameuiNpcNameplateGameController> _nameplateController;
		private CBool _isFriendly;
		private CBool _isFriendlyFromHack;
		private CBool _isHostile;
		private CBool _isAggressive;
		private CBool _isNCPD;
		private CBool _isDevice;
		private CBool _isDrone;
		private CBool _isMech;
		private CBool _isCamera;
		private CBool _isTurret;
		private CBool _isHiddenByQuest;
		private CBool _hideUIElements;
		private wCHandle<gameIBlackboard> _puppetStateBlackboard;
		private CEnum<gamedataNPCHighLevelState> _highLevelState;
		private CInt32 _numberOfCombatants;
		private CBool _waitingToExitCombat;
		private CEnum<gamedataOutput> _reaction;
		private CEnum<gamedataNPCHighLevelState> _lastState;
		private CEnum<gamedataOutput> _lastReaction;
		private CFloat _lastPercent;
		private CBool _canSeePlayer;
		private CBool _squadInCombat;
		private CName _archetypeTextureName;
		private CBool _isTagged;
		private CBool _canHaveObjectMarker;
		private CBool _canShowObjectMarker;
		private CBool _objectMarkerVisible;
		private CBool _nameplateVisible;
		private CBool _detectionVisible;
		private CBool _inNameplateMode;
		private CBool _objectMarkerFirstShowing;
		private CBool _statusEffectShowing;
		private CFloat _statusEffectCurrentPriority;
		private CBool _isInCombatWithPlayer;
		private CBool _animationIsPlaying;
		private CHandle<inkanimProxy> _animationProxy;
		private CHandle<inkanimProxy> _nameplateAnimationProxy;
		private CBool _nameplateAnimationIsPlaying;
		private CHandle<inkanimProxy> _reprimandAnimationProxy;
		private CBool _reprimandAnimationIsPlaying;
		private CEnum<gameReprimandMappinAnimationState> _reprimandAnimationState;
		private CHandle<inkanimProxy> _monowireHackAnimationProxy;
		private CEnum<gameEnemyStealthAwarenessState> _currentAnimState;
		private CFloat _c_emptyThreshold;
		private CFloat _c_awareToCombatThreshold;
		private CFloat _c_combatToAwareThreshold;
		private CFloat _c_deviceCombatToAwareThreshold;
		private CFloat _c_objectMarkerMaxDistance;
		private CFloat _c_objectMarkerMaxCameraDistance;
		private CFloat _statusEffectStartTime;
		private CString _statusEffectTextureName;

		[Ordinal(11)] 
		[RED("arrow")] 
		public inkImageWidgetReference Arrow
		{
			get => GetProperty(ref _arrow);
			set => SetProperty(ref _arrow, value);
		}

		[Ordinal(12)] 
		[RED("fill")] 
		public inkWidgetReference Fill
		{
			get => GetProperty(ref _fill);
			set => SetProperty(ref _fill, value);
		}

		[Ordinal(13)] 
		[RED("eyeFillWhite")] 
		public inkWidgetReference EyeFillWhite
		{
			get => GetProperty(ref _eyeFillWhite);
			set => SetProperty(ref _eyeFillWhite, value);
		}

		[Ordinal(14)] 
		[RED("eyeFillBlack")] 
		public inkWidgetReference EyeFillBlack
		{
			get => GetProperty(ref _eyeFillBlack);
			set => SetProperty(ref _eyeFillBlack, value);
		}

		[Ordinal(15)] 
		[RED("markExclamation")] 
		public inkTextWidgetReference MarkExclamation
		{
			get => GetProperty(ref _markExclamation);
			set => SetProperty(ref _markExclamation, value);
		}

		[Ordinal(16)] 
		[RED("distance")] 
		public inkTextWidgetReference Distance
		{
			get => GetProperty(ref _distance);
			set => SetProperty(ref _distance, value);
		}

		[Ordinal(17)] 
		[RED("mainArt")] 
		public inkWidgetReference MainArt
		{
			get => GetProperty(ref _mainArt);
			set => SetProperty(ref _mainArt, value);
		}

		[Ordinal(18)] 
		[RED("frame")] 
		public inkImageWidgetReference Frame
		{
			get => GetProperty(ref _frame);
			set => SetProperty(ref _frame, value);
		}

		[Ordinal(19)] 
		[RED("eliteFrameName")] 
		public CName EliteFrameName
		{
			get => GetProperty(ref _eliteFrameName);
			set => SetProperty(ref _eliteFrameName, value);
		}

		[Ordinal(20)] 
		[RED("eliteFrameSize")] 
		public Vector2 EliteFrameSize
		{
			get => GetProperty(ref _eliteFrameSize);
			set => SetProperty(ref _eliteFrameSize, value);
		}

		[Ordinal(21)] 
		[RED("objectMarker")] 
		public inkWidgetReference ObjectMarker
		{
			get => GetProperty(ref _objectMarker);
			set => SetProperty(ref _objectMarker, value);
		}

		[Ordinal(22)] 
		[RED("levelIcon")] 
		public inkImageWidgetReference LevelIcon
		{
			get => GetProperty(ref _levelIcon);
			set => SetProperty(ref _levelIcon, value);
		}

		[Ordinal(23)] 
		[RED("taggedContainer")] 
		public inkWidgetReference TaggedContainer
		{
			get => GetProperty(ref _taggedContainer);
			set => SetProperty(ref _taggedContainer, value);
		}

		[Ordinal(24)] 
		[RED("background")] 
		public inkCompoundWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(25)] 
		[RED("contagiousQuickhackArrows")] 
		public inkCompoundWidgetReference ContagiousQuickhackArrows
		{
			get => GetProperty(ref _contagiousQuickhackArrows);
			set => SetProperty(ref _contagiousQuickhackArrows, value);
		}

		[Ordinal(26)] 
		[RED("statusEffectMain")] 
		public inkWidgetReference StatusEffectMain
		{
			get => GetProperty(ref _statusEffectMain);
			set => SetProperty(ref _statusEffectMain, value);
		}

		[Ordinal(27)] 
		[RED("statusEffectIcon")] 
		public inkImageWidgetReference StatusEffectIcon
		{
			get => GetProperty(ref _statusEffectIcon);
			set => SetProperty(ref _statusEffectIcon, value);
		}

		[Ordinal(28)] 
		[RED("statusEffectFill")] 
		public inkWidgetReference StatusEffectFill
		{
			get => GetProperty(ref _statusEffectFill);
			set => SetProperty(ref _statusEffectFill, value);
		}

		[Ordinal(29)] 
		[RED("statusEffectBackground")] 
		public inkWidgetReference StatusEffectBackground
		{
			get => GetProperty(ref _statusEffectBackground);
			set => SetProperty(ref _statusEffectBackground, value);
		}

		[Ordinal(30)] 
		[RED("ownerObject")] 
		public wCHandle<gameObject> OwnerObject
		{
			get => GetProperty(ref _ownerObject);
			set => SetProperty(ref _ownerObject, value);
		}

		[Ordinal(31)] 
		[RED("ownerNPC")] 
		public wCHandle<NPCPuppet> OwnerNPC
		{
			get => GetProperty(ref _ownerNPC);
			set => SetProperty(ref _ownerNPC, value);
		}

		[Ordinal(32)] 
		[RED("ownerDevice")] 
		public wCHandle<Device> OwnerDevice
		{
			get => GetProperty(ref _ownerDevice);
			set => SetProperty(ref _ownerDevice, value);
		}

		[Ordinal(33)] 
		[RED("mappin")] 
		public wCHandle<gamemappinsStealthMappin> Mappin
		{
			get => GetProperty(ref _mappin);
			set => SetProperty(ref _mappin, value);
		}

		[Ordinal(34)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(35)] 
		[RED("canvas")] 
		public wCHandle<inkWidget> Canvas
		{
			get => GetProperty(ref _canvas);
			set => SetProperty(ref _canvas, value);
		}

		[Ordinal(36)] 
		[RED("nameplateController")] 
		public wCHandle<gameuiNpcNameplateGameController> NameplateController
		{
			get => GetProperty(ref _nameplateController);
			set => SetProperty(ref _nameplateController, value);
		}

		[Ordinal(37)] 
		[RED("isFriendly")] 
		public CBool IsFriendly
		{
			get => GetProperty(ref _isFriendly);
			set => SetProperty(ref _isFriendly, value);
		}

		[Ordinal(38)] 
		[RED("isFriendlyFromHack")] 
		public CBool IsFriendlyFromHack
		{
			get => GetProperty(ref _isFriendlyFromHack);
			set => SetProperty(ref _isFriendlyFromHack, value);
		}

		[Ordinal(39)] 
		[RED("isHostile")] 
		public CBool IsHostile
		{
			get => GetProperty(ref _isHostile);
			set => SetProperty(ref _isHostile, value);
		}

		[Ordinal(40)] 
		[RED("isAggressive")] 
		public CBool IsAggressive
		{
			get => GetProperty(ref _isAggressive);
			set => SetProperty(ref _isAggressive, value);
		}

		[Ordinal(41)] 
		[RED("isNCPD")] 
		public CBool IsNCPD
		{
			get => GetProperty(ref _isNCPD);
			set => SetProperty(ref _isNCPD, value);
		}

		[Ordinal(42)] 
		[RED("isDevice")] 
		public CBool IsDevice
		{
			get => GetProperty(ref _isDevice);
			set => SetProperty(ref _isDevice, value);
		}

		[Ordinal(43)] 
		[RED("isDrone")] 
		public CBool IsDrone
		{
			get => GetProperty(ref _isDrone);
			set => SetProperty(ref _isDrone, value);
		}

		[Ordinal(44)] 
		[RED("isMech")] 
		public CBool IsMech
		{
			get => GetProperty(ref _isMech);
			set => SetProperty(ref _isMech, value);
		}

		[Ordinal(45)] 
		[RED("isCamera")] 
		public CBool IsCamera
		{
			get => GetProperty(ref _isCamera);
			set => SetProperty(ref _isCamera, value);
		}

		[Ordinal(46)] 
		[RED("isTurret")] 
		public CBool IsTurret
		{
			get => GetProperty(ref _isTurret);
			set => SetProperty(ref _isTurret, value);
		}

		[Ordinal(47)] 
		[RED("isHiddenByQuest")] 
		public CBool IsHiddenByQuest
		{
			get => GetProperty(ref _isHiddenByQuest);
			set => SetProperty(ref _isHiddenByQuest, value);
		}

		[Ordinal(48)] 
		[RED("hideUIElements")] 
		public CBool HideUIElements
		{
			get => GetProperty(ref _hideUIElements);
			set => SetProperty(ref _hideUIElements, value);
		}

		[Ordinal(49)] 
		[RED("puppetStateBlackboard")] 
		public wCHandle<gameIBlackboard> PuppetStateBlackboard
		{
			get => GetProperty(ref _puppetStateBlackboard);
			set => SetProperty(ref _puppetStateBlackboard, value);
		}

		[Ordinal(50)] 
		[RED("highLevelState")] 
		public CEnum<gamedataNPCHighLevelState> HighLevelState
		{
			get => GetProperty(ref _highLevelState);
			set => SetProperty(ref _highLevelState, value);
		}

		[Ordinal(51)] 
		[RED("numberOfCombatants")] 
		public CInt32 NumberOfCombatants
		{
			get => GetProperty(ref _numberOfCombatants);
			set => SetProperty(ref _numberOfCombatants, value);
		}

		[Ordinal(52)] 
		[RED("waitingToExitCombat")] 
		public CBool WaitingToExitCombat
		{
			get => GetProperty(ref _waitingToExitCombat);
			set => SetProperty(ref _waitingToExitCombat, value);
		}

		[Ordinal(53)] 
		[RED("reaction")] 
		public CEnum<gamedataOutput> Reaction
		{
			get => GetProperty(ref _reaction);
			set => SetProperty(ref _reaction, value);
		}

		[Ordinal(54)] 
		[RED("lastState")] 
		public CEnum<gamedataNPCHighLevelState> LastState
		{
			get => GetProperty(ref _lastState);
			set => SetProperty(ref _lastState, value);
		}

		[Ordinal(55)] 
		[RED("lastReaction")] 
		public CEnum<gamedataOutput> LastReaction
		{
			get => GetProperty(ref _lastReaction);
			set => SetProperty(ref _lastReaction, value);
		}

		[Ordinal(56)] 
		[RED("lastPercent")] 
		public CFloat LastPercent
		{
			get => GetProperty(ref _lastPercent);
			set => SetProperty(ref _lastPercent, value);
		}

		[Ordinal(57)] 
		[RED("canSeePlayer")] 
		public CBool CanSeePlayer
		{
			get => GetProperty(ref _canSeePlayer);
			set => SetProperty(ref _canSeePlayer, value);
		}

		[Ordinal(58)] 
		[RED("squadInCombat")] 
		public CBool SquadInCombat
		{
			get => GetProperty(ref _squadInCombat);
			set => SetProperty(ref _squadInCombat, value);
		}

		[Ordinal(59)] 
		[RED("archetypeTextureName")] 
		public CName ArchetypeTextureName
		{
			get => GetProperty(ref _archetypeTextureName);
			set => SetProperty(ref _archetypeTextureName, value);
		}

		[Ordinal(60)] 
		[RED("isTagged")] 
		public CBool IsTagged
		{
			get => GetProperty(ref _isTagged);
			set => SetProperty(ref _isTagged, value);
		}

		[Ordinal(61)] 
		[RED("canHaveObjectMarker")] 
		public CBool CanHaveObjectMarker
		{
			get => GetProperty(ref _canHaveObjectMarker);
			set => SetProperty(ref _canHaveObjectMarker, value);
		}

		[Ordinal(62)] 
		[RED("canShowObjectMarker")] 
		public CBool CanShowObjectMarker
		{
			get => GetProperty(ref _canShowObjectMarker);
			set => SetProperty(ref _canShowObjectMarker, value);
		}

		[Ordinal(63)] 
		[RED("objectMarkerVisible")] 
		public CBool ObjectMarkerVisible
		{
			get => GetProperty(ref _objectMarkerVisible);
			set => SetProperty(ref _objectMarkerVisible, value);
		}

		[Ordinal(64)] 
		[RED("nameplateVisible")] 
		public CBool NameplateVisible
		{
			get => GetProperty(ref _nameplateVisible);
			set => SetProperty(ref _nameplateVisible, value);
		}

		[Ordinal(65)] 
		[RED("detectionVisible")] 
		public CBool DetectionVisible
		{
			get => GetProperty(ref _detectionVisible);
			set => SetProperty(ref _detectionVisible, value);
		}

		[Ordinal(66)] 
		[RED("inNameplateMode")] 
		public CBool InNameplateMode
		{
			get => GetProperty(ref _inNameplateMode);
			set => SetProperty(ref _inNameplateMode, value);
		}

		[Ordinal(67)] 
		[RED("objectMarkerFirstShowing")] 
		public CBool ObjectMarkerFirstShowing
		{
			get => GetProperty(ref _objectMarkerFirstShowing);
			set => SetProperty(ref _objectMarkerFirstShowing, value);
		}

		[Ordinal(68)] 
		[RED("statusEffectShowing")] 
		public CBool StatusEffectShowing
		{
			get => GetProperty(ref _statusEffectShowing);
			set => SetProperty(ref _statusEffectShowing, value);
		}

		[Ordinal(69)] 
		[RED("statusEffectCurrentPriority")] 
		public CFloat StatusEffectCurrentPriority
		{
			get => GetProperty(ref _statusEffectCurrentPriority);
			set => SetProperty(ref _statusEffectCurrentPriority, value);
		}

		[Ordinal(70)] 
		[RED("isInCombatWithPlayer")] 
		public CBool IsInCombatWithPlayer
		{
			get => GetProperty(ref _isInCombatWithPlayer);
			set => SetProperty(ref _isInCombatWithPlayer, value);
		}

		[Ordinal(71)] 
		[RED("animationIsPlaying")] 
		public CBool AnimationIsPlaying
		{
			get => GetProperty(ref _animationIsPlaying);
			set => SetProperty(ref _animationIsPlaying, value);
		}

		[Ordinal(72)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(73)] 
		[RED("nameplateAnimationProxy")] 
		public CHandle<inkanimProxy> NameplateAnimationProxy
		{
			get => GetProperty(ref _nameplateAnimationProxy);
			set => SetProperty(ref _nameplateAnimationProxy, value);
		}

		[Ordinal(74)] 
		[RED("nameplateAnimationIsPlaying")] 
		public CBool NameplateAnimationIsPlaying
		{
			get => GetProperty(ref _nameplateAnimationIsPlaying);
			set => SetProperty(ref _nameplateAnimationIsPlaying, value);
		}

		[Ordinal(75)] 
		[RED("reprimandAnimationProxy")] 
		public CHandle<inkanimProxy> ReprimandAnimationProxy
		{
			get => GetProperty(ref _reprimandAnimationProxy);
			set => SetProperty(ref _reprimandAnimationProxy, value);
		}

		[Ordinal(76)] 
		[RED("reprimandAnimationIsPlaying")] 
		public CBool ReprimandAnimationIsPlaying
		{
			get => GetProperty(ref _reprimandAnimationIsPlaying);
			set => SetProperty(ref _reprimandAnimationIsPlaying, value);
		}

		[Ordinal(77)] 
		[RED("reprimandAnimationState")] 
		public CEnum<gameReprimandMappinAnimationState> ReprimandAnimationState
		{
			get => GetProperty(ref _reprimandAnimationState);
			set => SetProperty(ref _reprimandAnimationState, value);
		}

		[Ordinal(78)] 
		[RED("monowireHackAnimationProxy")] 
		public CHandle<inkanimProxy> MonowireHackAnimationProxy
		{
			get => GetProperty(ref _monowireHackAnimationProxy);
			set => SetProperty(ref _monowireHackAnimationProxy, value);
		}

		[Ordinal(79)] 
		[RED("currentAnimState")] 
		public CEnum<gameEnemyStealthAwarenessState> CurrentAnimState
		{
			get => GetProperty(ref _currentAnimState);
			set => SetProperty(ref _currentAnimState, value);
		}

		[Ordinal(80)] 
		[RED("c_emptyThreshold")] 
		public CFloat C_emptyThreshold
		{
			get => GetProperty(ref _c_emptyThreshold);
			set => SetProperty(ref _c_emptyThreshold, value);
		}

		[Ordinal(81)] 
		[RED("c_awareToCombatThreshold")] 
		public CFloat C_awareToCombatThreshold
		{
			get => GetProperty(ref _c_awareToCombatThreshold);
			set => SetProperty(ref _c_awareToCombatThreshold, value);
		}

		[Ordinal(82)] 
		[RED("c_combatToAwareThreshold")] 
		public CFloat C_combatToAwareThreshold
		{
			get => GetProperty(ref _c_combatToAwareThreshold);
			set => SetProperty(ref _c_combatToAwareThreshold, value);
		}

		[Ordinal(83)] 
		[RED("c_deviceCombatToAwareThreshold")] 
		public CFloat C_deviceCombatToAwareThreshold
		{
			get => GetProperty(ref _c_deviceCombatToAwareThreshold);
			set => SetProperty(ref _c_deviceCombatToAwareThreshold, value);
		}

		[Ordinal(84)] 
		[RED("c_objectMarkerMaxDistance")] 
		public CFloat C_objectMarkerMaxDistance
		{
			get => GetProperty(ref _c_objectMarkerMaxDistance);
			set => SetProperty(ref _c_objectMarkerMaxDistance, value);
		}

		[Ordinal(85)] 
		[RED("c_objectMarkerMaxCameraDistance")] 
		public CFloat C_objectMarkerMaxCameraDistance
		{
			get => GetProperty(ref _c_objectMarkerMaxCameraDistance);
			set => SetProperty(ref _c_objectMarkerMaxCameraDistance, value);
		}

		[Ordinal(86)] 
		[RED("statusEffectStartTime")] 
		public CFloat StatusEffectStartTime
		{
			get => GetProperty(ref _statusEffectStartTime);
			set => SetProperty(ref _statusEffectStartTime, value);
		}

		[Ordinal(87)] 
		[RED("statusEffectTextureName")] 
		public CString StatusEffectTextureName
		{
			get => GetProperty(ref _statusEffectTextureName);
			set => SetProperty(ref _statusEffectTextureName, value);
		}

		public gameuiStealthMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
