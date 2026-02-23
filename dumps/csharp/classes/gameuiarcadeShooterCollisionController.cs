using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterCollisionController : inkWidgetLogicController
	{
		private CFloat _explosionPlatformDelay;
		private CArray<gameuiarcadeShooterExplodingPlatformSpawnDetail> _respawnPlatformDetails;

		[Ordinal(1)] 
		[RED("explosionPlatformDelay")] 
		public CFloat ExplosionPlatformDelay
		{
			get => GetProperty(ref _explosionPlatformDelay);
			set => SetProperty(ref _explosionPlatformDelay, value);
		}

		[Ordinal(2)] 
		[RED("respawnPlatformDetails")] 
		public CArray<gameuiarcadeShooterExplodingPlatformSpawnDetail> RespawnPlatformDetails
		{
			get => GetProperty(ref _respawnPlatformDetails);
			set => SetProperty(ref _respawnPlatformDetails, value);
		}

		public gameuiarcadeShooterCollisionController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
