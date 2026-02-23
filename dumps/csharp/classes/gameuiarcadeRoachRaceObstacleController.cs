using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeRoachRaceObstacleController : gameuiarcadeArcadeObjectController
	{
		private gameuiarcadeBoundingRect _collider;

		[Ordinal(3)] 
		[RED("collider")] 
		public gameuiarcadeBoundingRect Collider
		{
			get => GetProperty(ref _collider);
			set => SetProperty(ref _collider, value);
		}

		public gameuiarcadeRoachRaceObstacleController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
