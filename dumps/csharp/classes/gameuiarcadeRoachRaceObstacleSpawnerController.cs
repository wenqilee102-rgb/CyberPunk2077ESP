using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRaceObstacleSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		private CFloat _initialMinimumSpawnTime;
		private CFloat _initialDoubleSpawnChance;
		private CFloat _spawnRateIncreasePerCycle;
		private CFloat _doubleSpawnChanceIncreasePerLevel;
		private CFloat _doubleSpawnDelay;
		private CFloat _powerupSpawnTimeDelayMultiplier;
		private CFloat _appleSpawnTime;
		private CFloat _carrotSpawnTime;

		[Ordinal(3)] 
		[RED("initialMinimumSpawnTime")] 
		public CFloat InitialMinimumSpawnTime
		{
			get => GetProperty(ref _initialMinimumSpawnTime);
			set => SetProperty(ref _initialMinimumSpawnTime, value);
		}

		[Ordinal(4)] 
		[RED("initialDoubleSpawnChance")] 
		public CFloat InitialDoubleSpawnChance
		{
			get => GetProperty(ref _initialDoubleSpawnChance);
			set => SetProperty(ref _initialDoubleSpawnChance, value);
		}

		[Ordinal(5)] 
		[RED("spawnRateIncreasePerCycle")] 
		public CFloat SpawnRateIncreasePerCycle
		{
			get => GetProperty(ref _spawnRateIncreasePerCycle);
			set => SetProperty(ref _spawnRateIncreasePerCycle, value);
		}

		[Ordinal(6)] 
		[RED("doubleSpawnChanceIncreasePerLevel")] 
		public CFloat DoubleSpawnChanceIncreasePerLevel
		{
			get => GetProperty(ref _doubleSpawnChanceIncreasePerLevel);
			set => SetProperty(ref _doubleSpawnChanceIncreasePerLevel, value);
		}

		[Ordinal(7)] 
		[RED("doubleSpawnDelay")] 
		public CFloat DoubleSpawnDelay
		{
			get => GetProperty(ref _doubleSpawnDelay);
			set => SetProperty(ref _doubleSpawnDelay, value);
		}

		[Ordinal(8)] 
		[RED("powerupSpawnTimeDelayMultiplier")] 
		public CFloat PowerupSpawnTimeDelayMultiplier
		{
			get => GetProperty(ref _powerupSpawnTimeDelayMultiplier);
			set => SetProperty(ref _powerupSpawnTimeDelayMultiplier, value);
		}

		[Ordinal(9)] 
		[RED("appleSpawnTime")] 
		public CFloat AppleSpawnTime
		{
			get => GetProperty(ref _appleSpawnTime);
			set => SetProperty(ref _appleSpawnTime, value);
		}

		[Ordinal(10)] 
		[RED("carrotSpawnTime")] 
		public CFloat CarrotSpawnTime
		{
			get => GetProperty(ref _carrotSpawnTime);
			set => SetProperty(ref _carrotSpawnTime, value);
		}

		public gameuiarcadeRoachRaceObstacleSpawnerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
