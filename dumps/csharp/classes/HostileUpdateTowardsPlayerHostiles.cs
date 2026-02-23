using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HostileUpdateTowardsPlayerHostiles : redEvent
	{

		public HostileUpdateTowardsPlayerHostiles(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
