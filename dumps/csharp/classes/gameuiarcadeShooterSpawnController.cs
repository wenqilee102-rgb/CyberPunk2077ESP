using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterSpawnController : inkWidgetLogicController
	{
		private CEnum<gameuiarcadeShooterAIType> _enemyType;
		private CEnum<gameuiarcadeShooterSpawnerCondition> _spawnCondition;
		private CFloat _spawnDelay;
		private CUInt32 _spawnCount;
		private CFloat _offScreenSpawnExpiryTime;
		private CBool _skippable;
		private CFloat _skipOffset;
		private CBool _awaitPreviousUnitDead;
		private CString _enemyParameter;

		[Ordinal(1)] 
		[RED("enemyType")] 
		public CEnum<gameuiarcadeShooterAIType> EnemyType
		{
			get => GetProperty(ref _enemyType);
			set => SetProperty(ref _enemyType, value);
		}

		[Ordinal(2)] 
		[RED("spawnCondition")] 
		public CEnum<gameuiarcadeShooterSpawnerCondition> SpawnCondition
		{
			get => GetProperty(ref _spawnCondition);
			set => SetProperty(ref _spawnCondition, value);
		}

		[Ordinal(3)] 
		[RED("spawnDelay")] 
		public CFloat SpawnDelay
		{
			get => GetProperty(ref _spawnDelay);
			set => SetProperty(ref _spawnDelay, value);
		}

		[Ordinal(4)] 
		[RED("spawnCount")] 
		public CUInt32 SpawnCount
		{
			get => GetProperty(ref _spawnCount);
			set => SetProperty(ref _spawnCount, value);
		}

		[Ordinal(5)] 
		[RED("offScreenSpawnExpiryTime")] 
		public CFloat OffScreenSpawnExpiryTime
		{
			get => GetProperty(ref _offScreenSpawnExpiryTime);
			set => SetProperty(ref _offScreenSpawnExpiryTime, value);
		}

		[Ordinal(6)] 
		[RED("skippable")] 
		public CBool Skippable
		{
			get => GetProperty(ref _skippable);
			set => SetProperty(ref _skippable, value);
		}

		[Ordinal(7)] 
		[RED("skipOffset")] 
		public CFloat SkipOffset
		{
			get => GetProperty(ref _skipOffset);
			set => SetProperty(ref _skipOffset, value);
		}

		[Ordinal(8)] 
		[RED("awaitPreviousUnitDead")] 
		public CBool AwaitPreviousUnitDead
		{
			get => GetProperty(ref _awaitPreviousUnitDead);
			set => SetProperty(ref _awaitPreviousUnitDead, value);
		}

		[Ordinal(9)] 
		[RED("enemyParameter")] 
		public CString EnemyParameter
		{
			get => GetProperty(ref _enemyParameter);
			set => SetProperty(ref _enemyParameter, value);
		}

		public gameuiarcadeShooterSpawnController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
