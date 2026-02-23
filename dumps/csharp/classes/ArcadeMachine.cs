using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArcadeMachine : InteractiveDevice
	{
		private CEnum<ArcadeMachineType> _arcadeMachineType;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private redResourceReferenceScriptToken _currentGameVideo;
		private CName _currentGameAudio;
		private CName _currentGameAudioStop;
		private CName _meshAppearanceOn;
		private CName _meshAppearanceOff;
		private CHandle<workWorkspotResourceComponent> _arcadeMinigameComponent;
		private CEnum<ArcadeMinigame> _minigame;
		private CHandle<redCallbackObject> _combatStateListener;

		[Ordinal(98)] 
		[RED("arcadeMachineType")] 
		public CEnum<ArcadeMachineType> ArcadeMachineType
		{
			get => GetProperty(ref _arcadeMachineType);
			set => SetProperty(ref _arcadeMachineType, value);
		}

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get => GetProperty(ref _isShortGlitchActive);
			set => SetProperty(ref _isShortGlitchActive, value);
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get => GetProperty(ref _shortGlitchDelayID);
			set => SetProperty(ref _shortGlitchDelayID, value);
		}

		[Ordinal(101)] 
		[RED("currentGameVideo")] 
		public redResourceReferenceScriptToken CurrentGameVideo
		{
			get => GetProperty(ref _currentGameVideo);
			set => SetProperty(ref _currentGameVideo, value);
		}

		[Ordinal(102)] 
		[RED("currentGameAudio")] 
		public CName CurrentGameAudio
		{
			get => GetProperty(ref _currentGameAudio);
			set => SetProperty(ref _currentGameAudio, value);
		}

		[Ordinal(103)] 
		[RED("currentGameAudioStop")] 
		public CName CurrentGameAudioStop
		{
			get => GetProperty(ref _currentGameAudioStop);
			set => SetProperty(ref _currentGameAudioStop, value);
		}

		[Ordinal(104)] 
		[RED("meshAppearanceOn")] 
		public CName MeshAppearanceOn
		{
			get => GetProperty(ref _meshAppearanceOn);
			set => SetProperty(ref _meshAppearanceOn, value);
		}

		[Ordinal(105)] 
		[RED("meshAppearanceOff")] 
		public CName MeshAppearanceOff
		{
			get => GetProperty(ref _meshAppearanceOff);
			set => SetProperty(ref _meshAppearanceOff, value);
		}

		[Ordinal(106)] 
		[RED("arcadeMinigameComponent")] 
		public CHandle<workWorkspotResourceComponent> ArcadeMinigameComponent
		{
			get => GetProperty(ref _arcadeMinigameComponent);
			set => SetProperty(ref _arcadeMinigameComponent, value);
		}

		[Ordinal(107)] 
		[RED("minigame")] 
		public CEnum<ArcadeMinigame> Minigame
		{
			get => GetProperty(ref _minigame);
			set => SetProperty(ref _minigame, value);
		}

		[Ordinal(108)] 
		[RED("combatStateListener")] 
		public CHandle<redCallbackObject> CombatStateListener
		{
			get => GetProperty(ref _combatStateListener);
			set => SetProperty(ref _combatStateListener, value);
		}

		public ArcadeMachine(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
