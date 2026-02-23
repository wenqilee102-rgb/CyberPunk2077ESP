using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleComponentPS : ScriptableDeviceComponentPS
	{
		private CBool _defaultStateSet;
		private CBool _stateModifiedByQuest;
		private CBool _playerVehicle;
		private CArray<CName> _npcOccupiedSlots;
		private CBool _isDestroyed;
		private CBool _isStolen;
		private CBool _crystalDomeQuestModified;
		private CBool _crystalDomeQuestState;
		private CBool _crystalDomeState;
		private CBool _visualDestructionSet;
		private CBool _visualDestructionNeeded;
		private CBool _exploded;
		private CBool _submerged;
		private CBool _sirenOn;
		private CBool _sirenSoundOn;
		private CBool _sirenLightsOn;
		private CBool _isDefaultLightToggleSet;
		private CBool _anyDoorOpen;
		private CArray<TemporaryDoorState> _previousInteractionState;
		private CBool _thrusterState;
		private CBool _uiQuestModified;
		private CBool _uiState;
		private CHandle<EngDemoContainer> _vehicleSkillChecks;
		private CBool _controlStimShouldBeActive;
		private CBool _controlStimRunning;
		private CBool _vehicleApperanceCustomizationActive;
		private CBool _vehicleApperanceCustomizationInDistanceTermination;
		private CBool _vehicleAppearanceCustomizationBlockedByDamage;
		private SavedVehicleVisualCustomizationTemplate _vehicleVisualCustomizationTemplate;
		private vehicleVisualModdingDefinition _vehicleApperanceDefinition;
		private CBool _ready;
		private CBool _isPlayerPerformingBodyDisposal;
		private CFloat _submergedTimestamp;
		private CBool _shouldForceExitDelamain;
		private CEnum<gamedataMappinVariant> _customMappin;
		private CBool _hornEnabled;
		private CHandle<vehicleControllerPS> _vehicleControllerPS;

		[Ordinal(107)] 
		[RED("defaultStateSet")] 
		public CBool DefaultStateSet
		{
			get => GetProperty(ref _defaultStateSet);
			set => SetProperty(ref _defaultStateSet, value);
		}

		[Ordinal(108)] 
		[RED("stateModifiedByQuest")] 
		public CBool StateModifiedByQuest
		{
			get => GetProperty(ref _stateModifiedByQuest);
			set => SetProperty(ref _stateModifiedByQuest, value);
		}

		[Ordinal(109)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get => GetProperty(ref _playerVehicle);
			set => SetProperty(ref _playerVehicle, value);
		}

		[Ordinal(110)] 
		[RED("npcOccupiedSlots")] 
		public CArray<CName> NpcOccupiedSlots
		{
			get => GetProperty(ref _npcOccupiedSlots);
			set => SetProperty(ref _npcOccupiedSlots, value);
		}

		[Ordinal(111)] 
		[RED("isDestroyed")] 
		public CBool IsDestroyed
		{
			get => GetProperty(ref _isDestroyed);
			set => SetProperty(ref _isDestroyed, value);
		}

		[Ordinal(112)] 
		[RED("isStolen")] 
		public CBool IsStolen
		{
			get => GetProperty(ref _isStolen);
			set => SetProperty(ref _isStolen, value);
		}

		[Ordinal(113)] 
		[RED("crystalDomeQuestModified")] 
		public CBool CrystalDomeQuestModified
		{
			get => GetProperty(ref _crystalDomeQuestModified);
			set => SetProperty(ref _crystalDomeQuestModified, value);
		}

		[Ordinal(114)] 
		[RED("crystalDomeQuestState")] 
		public CBool CrystalDomeQuestState
		{
			get => GetProperty(ref _crystalDomeQuestState);
			set => SetProperty(ref _crystalDomeQuestState, value);
		}

		[Ordinal(115)] 
		[RED("crystalDomeState")] 
		public CBool CrystalDomeState
		{
			get => GetProperty(ref _crystalDomeState);
			set => SetProperty(ref _crystalDomeState, value);
		}

		[Ordinal(116)] 
		[RED("visualDestructionSet")] 
		public CBool VisualDestructionSet
		{
			get => GetProperty(ref _visualDestructionSet);
			set => SetProperty(ref _visualDestructionSet, value);
		}

		[Ordinal(117)] 
		[RED("visualDestructionNeeded")] 
		public CBool VisualDestructionNeeded
		{
			get => GetProperty(ref _visualDestructionNeeded);
			set => SetProperty(ref _visualDestructionNeeded, value);
		}

		[Ordinal(118)] 
		[RED("exploded")] 
		public CBool Exploded
		{
			get => GetProperty(ref _exploded);
			set => SetProperty(ref _exploded, value);
		}

		[Ordinal(119)] 
		[RED("submerged")] 
		public CBool Submerged
		{
			get => GetProperty(ref _submerged);
			set => SetProperty(ref _submerged, value);
		}

		[Ordinal(120)] 
		[RED("sirenOn")] 
		public CBool SirenOn
		{
			get => GetProperty(ref _sirenOn);
			set => SetProperty(ref _sirenOn, value);
		}

		[Ordinal(121)] 
		[RED("sirenSoundOn")] 
		public CBool SirenSoundOn
		{
			get => GetProperty(ref _sirenSoundOn);
			set => SetProperty(ref _sirenSoundOn, value);
		}

		[Ordinal(122)] 
		[RED("sirenLightsOn")] 
		public CBool SirenLightsOn
		{
			get => GetProperty(ref _sirenLightsOn);
			set => SetProperty(ref _sirenLightsOn, value);
		}

		[Ordinal(123)] 
		[RED("isDefaultLightToggleSet")] 
		public CBool IsDefaultLightToggleSet
		{
			get => GetProperty(ref _isDefaultLightToggleSet);
			set => SetProperty(ref _isDefaultLightToggleSet, value);
		}

		[Ordinal(124)] 
		[RED("anyDoorOpen")] 
		public CBool AnyDoorOpen
		{
			get => GetProperty(ref _anyDoorOpen);
			set => SetProperty(ref _anyDoorOpen, value);
		}

		[Ordinal(125)] 
		[RED("previousInteractionState")] 
		public CArray<TemporaryDoorState> PreviousInteractionState
		{
			get => GetProperty(ref _previousInteractionState);
			set => SetProperty(ref _previousInteractionState, value);
		}

		[Ordinal(126)] 
		[RED("thrusterState")] 
		public CBool ThrusterState
		{
			get => GetProperty(ref _thrusterState);
			set => SetProperty(ref _thrusterState, value);
		}

		[Ordinal(127)] 
		[RED("uiQuestModified")] 
		public CBool UiQuestModified
		{
			get => GetProperty(ref _uiQuestModified);
			set => SetProperty(ref _uiQuestModified, value);
		}

		[Ordinal(128)] 
		[RED("uiState")] 
		public CBool UiState
		{
			get => GetProperty(ref _uiState);
			set => SetProperty(ref _uiState, value);
		}

		[Ordinal(129)] 
		[RED("vehicleSkillChecks")] 
		public CHandle<EngDemoContainer> VehicleSkillChecks
		{
			get => GetProperty(ref _vehicleSkillChecks);
			set => SetProperty(ref _vehicleSkillChecks, value);
		}

		[Ordinal(130)] 
		[RED("controlStimShouldBeActive")] 
		public CBool ControlStimShouldBeActive
		{
			get => GetProperty(ref _controlStimShouldBeActive);
			set => SetProperty(ref _controlStimShouldBeActive, value);
		}

		[Ordinal(131)] 
		[RED("controlStimRunning")] 
		public CBool ControlStimRunning
		{
			get => GetProperty(ref _controlStimRunning);
			set => SetProperty(ref _controlStimRunning, value);
		}

		[Ordinal(132)] 
		[RED("vehicleApperanceCustomizationActive")] 
		public CBool VehicleApperanceCustomizationActive
		{
			get => GetProperty(ref _vehicleApperanceCustomizationActive);
			set => SetProperty(ref _vehicleApperanceCustomizationActive, value);
		}

		[Ordinal(133)] 
		[RED("vehicleApperanceCustomizationInDistanceTermination")] 
		public CBool VehicleApperanceCustomizationInDistanceTermination
		{
			get => GetProperty(ref _vehicleApperanceCustomizationInDistanceTermination);
			set => SetProperty(ref _vehicleApperanceCustomizationInDistanceTermination, value);
		}

		[Ordinal(134)] 
		[RED("vehicleAppearanceCustomizationBlockedByDamage")] 
		public CBool VehicleAppearanceCustomizationBlockedByDamage
		{
			get => GetProperty(ref _vehicleAppearanceCustomizationBlockedByDamage);
			set => SetProperty(ref _vehicleAppearanceCustomizationBlockedByDamage, value);
		}

		[Ordinal(135)] 
		[RED("vehicleVisualCustomizationTemplate")] 
		public SavedVehicleVisualCustomizationTemplate VehicleVisualCustomizationTemplate
		{
			get => GetProperty(ref _vehicleVisualCustomizationTemplate);
			set => SetProperty(ref _vehicleVisualCustomizationTemplate, value);
		}

		[Ordinal(136)] 
		[RED("vehicleApperanceDefinition")] 
		public vehicleVisualModdingDefinition VehicleApperanceDefinition
		{
			get => GetProperty(ref _vehicleApperanceDefinition);
			set => SetProperty(ref _vehicleApperanceDefinition, value);
		}

		[Ordinal(137)] 
		[RED("ready")] 
		public CBool Ready
		{
			get => GetProperty(ref _ready);
			set => SetProperty(ref _ready, value);
		}

		[Ordinal(138)] 
		[RED("isPlayerPerformingBodyDisposal")] 
		public CBool IsPlayerPerformingBodyDisposal
		{
			get => GetProperty(ref _isPlayerPerformingBodyDisposal);
			set => SetProperty(ref _isPlayerPerformingBodyDisposal, value);
		}

		[Ordinal(139)] 
		[RED("submergedTimestamp")] 
		public CFloat SubmergedTimestamp
		{
			get => GetProperty(ref _submergedTimestamp);
			set => SetProperty(ref _submergedTimestamp, value);
		}

		[Ordinal(140)] 
		[RED("shouldForceExitDelamain")] 
		public CBool ShouldForceExitDelamain
		{
			get => GetProperty(ref _shouldForceExitDelamain);
			set => SetProperty(ref _shouldForceExitDelamain, value);
		}

		[Ordinal(141)] 
		[RED("customMappin")] 
		public CEnum<gamedataMappinVariant> CustomMappin
		{
			get => GetProperty(ref _customMappin);
			set => SetProperty(ref _customMappin, value);
		}

		[Ordinal(142)] 
		[RED("hornEnabled")] 
		public CBool HornEnabled
		{
			get => GetProperty(ref _hornEnabled);
			set => SetProperty(ref _hornEnabled, value);
		}

		[Ordinal(143)] 
		[RED("vehicleControllerPS")] 
		public CHandle<vehicleControllerPS> VehicleControllerPS
		{
			get => GetProperty(ref _vehicleControllerPS);
			set => SetProperty(ref _vehicleControllerPS, value);
		}

		public VehicleComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
