using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRaceSceneryObjectSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		private CFloat _sceneryObjectSpawnTime;

		[Ordinal(3)] 
		[RED("sceneryObjectSpawnTime")] 
		public CFloat SceneryObjectSpawnTime
		{
			get => GetProperty(ref _sceneryObjectSpawnTime);
			set => SetProperty(ref _sceneryObjectSpawnTime, value);
		}

		public gameuiarcadeRoachRaceSceneryObjectSpawnerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
