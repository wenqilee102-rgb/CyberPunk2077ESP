using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldStaticCollisionShapeCategories_CollisionNode : CVariable
	{
		private [5][6]Uint16 _arr;

		[Ordinal(0)] 
		[RED("arr")] 
		public [5][6]Uint16 Arr
		{
			get => GetProperty(ref _arr);
			set => SetProperty(ref _arr, value);
		}

		public worldStaticCollisionShapeCategories_CollisionNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
