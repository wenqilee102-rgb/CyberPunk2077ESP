using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformTeleportTo : redEvent
	{
		private NodeRef _destinationNode;

		[Ordinal(0)] 
		[RED("destinationNode")] 
		public NodeRef DestinationNode
		{
			get => GetProperty(ref _destinationNode);
			set => SetProperty(ref _destinationNode, value);
		}

		public gameMovingPlatformTeleportTo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
