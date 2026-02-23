using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldMinimapModeOverrideAreaNode : worldTriggerAreaNode
	{
		private CEnum<worldPrefabStreamingOcclusion> _streamingOcclusion;

		[Ordinal(7)] 
		[RED("streamingOcclusion")] 
		public CEnum<worldPrefabStreamingOcclusion> StreamingOcclusion
		{
			get => GetProperty(ref _streamingOcclusion);
			set => SetProperty(ref _streamingOcclusion, value);
		}

		public worldMinimapModeOverrideAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
