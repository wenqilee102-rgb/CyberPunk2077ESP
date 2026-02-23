using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_QueryShockwave : gameEffectObjectProvider_QuerySphere
	{

		public gameEffectObjectProvider_QueryShockwave(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
