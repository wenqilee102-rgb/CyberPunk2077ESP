using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolBasedTimeBankEffector : gameContinuousEffector
	{
		private CFloat _timeBankValue;
		private CFloat _maxStatPoolValue;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private wCHandle<gameObject> _player;
		private CHandle<gameStatPoolsSystem> _statPoolSystem;
		private CHandle<TimeBankValueListener> _timeBankListener;
		private CHandle<StatPoolValueListener> _statPoolListener;
		private entEntityID _playerEntityID;
		private ScriptGameInstance _gameInstance;
		private gameStatPoolModifier _regenMod;

		[Ordinal(0)] 
		[RED("TimeBankValue")] 
		public CFloat TimeBankValue
		{
			get => GetProperty(ref _timeBankValue);
			set => SetProperty(ref _timeBankValue, value);
		}

		[Ordinal(1)] 
		[RED("maxStatPoolValue")] 
		public CFloat MaxStatPoolValue
		{
			get => GetProperty(ref _maxStatPoolValue);
			set => SetProperty(ref _maxStatPoolValue, value);
		}

		[Ordinal(2)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(3)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("statPoolSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolSystem
		{
			get => GetProperty(ref _statPoolSystem);
			set => SetProperty(ref _statPoolSystem, value);
		}

		[Ordinal(5)] 
		[RED("TimeBankListener")] 
		public CHandle<TimeBankValueListener> TimeBankListener
		{
			get => GetProperty(ref _timeBankListener);
			set => SetProperty(ref _timeBankListener, value);
		}

		[Ordinal(6)] 
		[RED("StatPoolListener")] 
		public CHandle<StatPoolValueListener> StatPoolListener
		{
			get => GetProperty(ref _statPoolListener);
			set => SetProperty(ref _statPoolListener, value);
		}

		[Ordinal(7)] 
		[RED("playerEntityID")] 
		public entEntityID PlayerEntityID
		{
			get => GetProperty(ref _playerEntityID);
			set => SetProperty(ref _playerEntityID, value);
		}

		[Ordinal(8)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(9)] 
		[RED("regenMod")] 
		public gameStatPoolModifier RegenMod
		{
			get => GetProperty(ref _regenMod);
			set => SetProperty(ref _regenMod, value);
		}

		public StatPoolBasedTimeBankEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
