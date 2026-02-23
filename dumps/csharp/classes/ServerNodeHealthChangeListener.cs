using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ServerNodeHealthChangeListener : gameCustomValueStatPoolsListener
	{
		private wCHandle<ServerNode> _serverNode;

		[Ordinal(0)] 
		[RED("serverNode")] 
		public wCHandle<ServerNode> ServerNode
		{
			get => GetProperty(ref _serverNode);
			set => SetProperty(ref _serverNode, value);
		}

		public ServerNodeHealthChangeListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
