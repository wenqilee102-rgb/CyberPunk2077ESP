using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questUpdateEntityHealthListeners_NodeType : questIUIManagerNodeType
	{
		private gameEntityReference _entityRef;

		[Ordinal(0)] 
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get => GetProperty(ref _entityRef);
			set => SetProperty(ref _entityRef, value);
		}

		public questUpdateEntityHealthListeners_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
