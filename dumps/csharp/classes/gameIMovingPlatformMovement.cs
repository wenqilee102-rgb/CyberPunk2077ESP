using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameIMovingPlatformMovement : IScriptable
	{
		private gameIMovingPlatformMovementInitData _initData;
		private NodeRef _endNode;

		[Ordinal(0)] 
		[RED("initData")] 
		public gameIMovingPlatformMovementInitData InitData
		{
			get => GetProperty(ref _initData);
			set => SetProperty(ref _initData, value);
		}

		[Ordinal(1)] 
		[RED("endNode")] 
		public NodeRef EndNode
		{
			get => GetProperty(ref _endNode);
			set => SetProperty(ref _endNode, value);
		}

		public gameIMovingPlatformMovement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
