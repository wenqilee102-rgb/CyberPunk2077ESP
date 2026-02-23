using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldPrefabProxyMeshNode : worldMeshNode
	{
		private CFloat _nearAutoHideDistance;
		private CUInt32 _nbNodesUnderProxy;

		[Ordinal(18)] 
		[RED("nearAutoHideDistance")] 
		public CFloat NearAutoHideDistance
		{
			get => GetProperty(ref _nearAutoHideDistance);
			set => SetProperty(ref _nearAutoHideDistance, value);
		}

		[Ordinal(19)] 
		[RED("nbNodesUnderProxy")] 
		public CUInt32 NbNodesUnderProxy
		{
			get => GetProperty(ref _nbNodesUnderProxy);
			set => SetProperty(ref _nbNodesUnderProxy, value);
		}

		public worldPrefabProxyMeshNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
