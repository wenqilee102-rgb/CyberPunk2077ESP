using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterExplodingPlatformSpawnDetail : CVariable
	{
		private CName _spawnPlatformName;
		private CArray<CName> _explodingPlatformsNames;

		[Ordinal(0)] 
		[RED("spawnPlatformName")] 
		public CName SpawnPlatformName
		{
			get => GetProperty(ref _spawnPlatformName);
			set => SetProperty(ref _spawnPlatformName, value);
		}

		[Ordinal(1)] 
		[RED("explodingPlatformsNames")] 
		public CArray<CName> ExplodingPlatformsNames
		{
			get => GetProperty(ref _explodingPlatformsNames);
			set => SetProperty(ref _explodingPlatformsNames, value);
		}

		public gameuiarcadeShooterExplodingPlatformSpawnDetail(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
