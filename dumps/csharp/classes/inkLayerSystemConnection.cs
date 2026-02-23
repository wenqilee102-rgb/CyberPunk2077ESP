using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkLayerSystemConnection : CVariable
	{
		private CName _layerName;
		private CHandle<inkILayerSystemData> _system;

		[Ordinal(0)] 
		[RED("layerName")] 
		public CName LayerName
		{
			get => GetProperty(ref _layerName);
			set => SetProperty(ref _layerName, value);
		}

		[Ordinal(1)] 
		[RED("system")] 
		public CHandle<inkILayerSystemData> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		public inkLayerSystemConnection(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
