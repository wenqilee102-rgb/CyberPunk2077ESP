using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnFlowControlNode : scnSceneGraphNode
	{
		private CBool _isOpen;
		private CUInt32 _opensAt;
		private CUInt32 _closesAt;

		[Ordinal(3)] 
		[RED("isOpen")] 
		public CBool IsOpen
		{
			get => GetProperty(ref _isOpen);
			set => SetProperty(ref _isOpen, value);
		}

		[Ordinal(4)] 
		[RED("opensAt")] 
		public CUInt32 OpensAt
		{
			get => GetProperty(ref _opensAt);
			set => SetProperty(ref _opensAt, value);
		}

		[Ordinal(5)] 
		[RED("closesAt")] 
		public CUInt32 ClosesAt
		{
			get => GetProperty(ref _closesAt);
			set => SetProperty(ref _closesAt, value);
		}

		public scnFlowControlNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
