using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatusEffectBasedTimeBankEffector : gameEffector
	{
		private wCHandle<gameObject> _player;
		private entEntityID _playerEntityID;
		private CHandle<TimeBankOnStatusEffectAppliedListener> _statusEffectListener;
		private ScriptGameInstance _gameInstance;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetProperty(ref _playerEntityID);
			set => SetProperty(ref _playerEntityID, value);
		}

		[Ordinal(2)] 
		[RED("statusEffectListener")] 
		public CHandle<TimeBankOnStatusEffectAppliedListener> StatusEffectListener
		{
			get => GetProperty(ref _statusEffectListener);
			set => SetProperty(ref _statusEffectListener, value);
		}

		[Ordinal(3)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		public StatusEffectBasedTimeBankEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
