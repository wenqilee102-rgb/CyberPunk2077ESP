using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectFilter_NearestWeakspotIfAny : gameEffectObjectGroupFilter
	{

		public gameEffectObjectFilter_NearestWeakspotIfAny(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
