using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeLeapAttackObjectTagger : IScriptable
	{
		private ScriptGameInstance _game;
		private wCHandle<gameObject> _playerPuppet;
		private wCHandle<PlayerDevelopmentData> _playerDevelopmentData;
		private wCHandle<gameVisionModeSystem> _visionModeSystem;
		private wCHandle<gameObject> _target;
		private CFloat _minDistanceToTarget;

		[Ordinal(0)] 
		[RED("game")] 
		public ScriptGameInstance Game
		{
			get => GetProperty(ref _game);
			set => SetProperty(ref _game, value);
		}

		[Ordinal(1)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		[Ordinal(2)] 
		[RED("playerDevelopmentData")] 
		public wCHandle<PlayerDevelopmentData> PlayerDevelopmentData
		{
			get => GetProperty(ref _playerDevelopmentData);
			set => SetProperty(ref _playerDevelopmentData, value);
		}

		[Ordinal(3)] 
		[RED("visionModeSystem")] 
		public wCHandle<gameVisionModeSystem> VisionModeSystem
		{
			get => GetProperty(ref _visionModeSystem);
			set => SetProperty(ref _visionModeSystem, value);
		}

		[Ordinal(4)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(5)] 
		[RED("minDistanceToTarget")] 
		public CFloat MinDistanceToTarget
		{
			get => GetProperty(ref _minDistanceToTarget);
			set => SetProperty(ref _minDistanceToTarget, value);
		}

		public MeleeLeapAttackObjectTagger(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
