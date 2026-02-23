using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SSSRAreaSettings : IAreaSettings
	{
		private CFloat _depthFadeStart;
		private CFloat _depthFadeEnd;

		[Ordinal(2)] 
		[RED("depthFadeStart")] 
		public CFloat DepthFadeStart
		{
			get => GetProperty(ref _depthFadeStart);
			set => SetProperty(ref _depthFadeStart, value);
		}

		[Ordinal(3)] 
		[RED("depthFadeEnd")] 
		public CFloat DepthFadeEnd
		{
			get => GetProperty(ref _depthFadeEnd);
			set => SetProperty(ref _depthFadeEnd, value);
		}

		public SSSRAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
