using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldEnvironmentAreaParameters : CResource
	{
		private WorldRenderAreaSettings _renderAreaSettings;
		private CUInt8 _resourceVersion;

		[Ordinal(1)] 
		[RED("renderAreaSettings")] 
		public WorldRenderAreaSettings RenderAreaSettings
		{
			get => GetProperty(ref _renderAreaSettings);
			set => SetProperty(ref _renderAreaSettings, value);
		}

		[Ordinal(2)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetProperty(ref _resourceVersion);
			set => SetProperty(ref _resourceVersion, value);
		}

		public worldEnvironmentAreaParameters(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
