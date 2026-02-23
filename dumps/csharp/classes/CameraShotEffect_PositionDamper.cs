using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraShotEffect_PositionDamper : vehicleCinematicCameraShotEffect_VectorDamper
	{

		public CameraShotEffect_PositionDamper(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
