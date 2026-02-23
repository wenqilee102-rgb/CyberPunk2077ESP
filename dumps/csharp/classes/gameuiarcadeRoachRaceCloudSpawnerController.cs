using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRaceCloudSpawnerController : gameuiarcadeArcadeSpawnerController
	{
		private CFloat _minCloudRelativeVelocity;
		private CFloat _maxCloudRelativeVelocity;
		private CFloat _cloudSpawnTime;

		[Ordinal(3)] 
		[RED("minCloudRelativeVelocity")] 
		public CFloat MinCloudRelativeVelocity
		{
			get => GetProperty(ref _minCloudRelativeVelocity);
			set => SetProperty(ref _minCloudRelativeVelocity, value);
		}

		[Ordinal(4)] 
		[RED("maxCloudRelativeVelocity")] 
		public CFloat MaxCloudRelativeVelocity
		{
			get => GetProperty(ref _maxCloudRelativeVelocity);
			set => SetProperty(ref _maxCloudRelativeVelocity, value);
		}

		[Ordinal(5)] 
		[RED("cloudSpawnTime")] 
		public CFloat CloudSpawnTime
		{
			get => GetProperty(ref _cloudSpawnTime);
			set => SetProperty(ref _cloudSpawnTime, value);
		}

		public gameuiarcadeRoachRaceCloudSpawnerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
