using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldMinimapConfigAreaNode : worldAreaShapeNode
	{
		private CFloat _streamingRadius;

		[Ordinal(6)] 
		[RED("streamingRadius")] 
		public CFloat StreamingRadius
		{
			get => GetProperty(ref _streamingRadius);
			set => SetProperty(ref _streamingRadius, value);
		}

		public worldMinimapConfigAreaNode(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
