using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArcadeMachineControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<redResourceReferenceScriptToken> _gameVideosPaths;
		private CBool _dEBUG_enableArcadeMinigames;
		private CEnum<ArcadeMinigame> _minigame;
		private CHandle<redCallbackObject> _combatStateListener;

		[Ordinal(107)] 
		[RED("gameVideosPaths")] 
		public CArray<redResourceReferenceScriptToken> GameVideosPaths
		{
			get => GetProperty(ref _gameVideosPaths);
			set => SetProperty(ref _gameVideosPaths, value);
		}

		[Ordinal(108)] 
		[RED("DEBUG_enableArcadeMinigames")] 
		public CBool DEBUG_enableArcadeMinigames
		{
			get => GetProperty(ref _dEBUG_enableArcadeMinigames);
			set => SetProperty(ref _dEBUG_enableArcadeMinigames, value);
		}

		[Ordinal(109)] 
		[RED("minigame")] 
		public CEnum<ArcadeMinigame> Minigame
		{
			get => GetProperty(ref _minigame);
			set => SetProperty(ref _minigame, value);
		}

		[Ordinal(110)] 
		[RED("combatStateListener")] 
		public CHandle<redCallbackObject> CombatStateListener
		{
			get => GetProperty(ref _combatStateListener);
			set => SetProperty(ref _combatStateListener, value);
		}

		public ArcadeMachineControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
