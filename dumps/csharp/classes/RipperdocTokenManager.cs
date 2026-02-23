using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocTokenManager : IScriptable
	{
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gameIBlackboard> _tokenBlackboard;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("tokenBlackboard")] 
		public wCHandle<gameIBlackboard> TokenBlackboard
		{
			get => GetProperty(ref _tokenBlackboard);
			set => SetProperty(ref _tokenBlackboard, value);
		}

		[Ordinal(2)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public RipperdocTokenManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
