using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questResetContainers_NodeTypeParams : CVariable
	{
		private NodeRef _containerNodeRef;
		private CBool _clearReinitData;

		[Ordinal(0)] 
		[RED("containerNodeRef")] 
		public NodeRef ContainerNodeRef
		{
			get => GetProperty(ref _containerNodeRef);
			set => SetProperty(ref _containerNodeRef, value);
		}

		[Ordinal(1)] 
		[RED("clearReinitData")] 
		public CBool ClearReinitData
		{
			get => GetProperty(ref _clearReinitData);
			set => SetProperty(ref _clearReinitData, value);
		}

		public questResetContainers_NodeTypeParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
