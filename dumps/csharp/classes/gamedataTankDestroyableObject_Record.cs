using WolvenKit.RED4.CR2W.Reflection;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamedataTankDestroyableObject_Record : gamedataArcadeCollidableObject_Record
	{

		public gamedataTankDestroyableObject_Record(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
