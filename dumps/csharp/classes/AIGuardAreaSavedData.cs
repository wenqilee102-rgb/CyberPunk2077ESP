using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIGuardAreaSavedData : CVariable
	{
		private entEntityID _puppetId;
		private NodeRef _nodeRef;

		[Ordinal(0)] 
		[RED("puppetId")] 
		public entEntityID PuppetId
		{
			get => GetProperty(ref _puppetId);
			set => SetProperty(ref _puppetId, value);
		}

		[Ordinal(1)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		public AIGuardAreaSavedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
