using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterTransporterSpawnerController : inkWidgetLogicController
	{
		private CFloat _spawnDelay;
		private CBool _isRandomSpawn;
		private CArray<gameuiarcadeShooterTransporterSpawnData> _choosenMounts;
		private CArray<gameuiarcadeShooterTransporterSpawnData> _choosenOnes;

		[Ordinal(1)] 
		[RED("spawnDelay")] 
		public CFloat SpawnDelay
		{
			get => GetProperty(ref _spawnDelay);
			set => SetProperty(ref _spawnDelay, value);
		}

		[Ordinal(2)] 
		[RED("isRandomSpawn")] 
		public CBool IsRandomSpawn
		{
			get => GetProperty(ref _isRandomSpawn);
			set => SetProperty(ref _isRandomSpawn, value);
		}

		[Ordinal(3)] 
		[RED("choosenMounts")] 
		public CArray<gameuiarcadeShooterTransporterSpawnData> ChoosenMounts
		{
			get => GetProperty(ref _choosenMounts);
			set => SetProperty(ref _choosenMounts, value);
		}

		[Ordinal(4)] 
		[RED("choosenOnes")] 
		public CArray<gameuiarcadeShooterTransporterSpawnData> ChoosenOnes
		{
			get => GetProperty(ref _choosenOnes);
			set => SetProperty(ref _choosenOnes, value);
		}

		public gameuiarcadeShooterTransporterSpawnerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
