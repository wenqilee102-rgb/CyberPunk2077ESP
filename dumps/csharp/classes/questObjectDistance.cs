using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questObjectDistance : questIDistance
	{
		private CHandle<questUniversalRef> _entityRef;
		private gameEntityReference _nodeRef2;

		[Ordinal(0)] 
		[RED("entityRef")] 
		public CHandle<questUniversalRef> EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		[Ordinal(1)] 
		[RED("nodeRef2")] 
		public gameEntityReference NodeRef2
		{
			get => GetProperty(ref _nodeRef2);
			set => SetProperty(ref _nodeRef2, value);
		}

		public questObjectDistance(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
