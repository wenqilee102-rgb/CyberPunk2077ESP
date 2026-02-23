using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootContainerAccessPointControllerPS : AccessPointControllerPS
	{
		private NodeRef _objRef;

		[Ordinal(115)] 
		[RED("objRef")] 
		public NodeRef ObjRef
		{
			get => GetProperty(ref _objRef);
			set => SetProperty(ref _objRef, value);
		}

		public LootContainerAccessPointControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
