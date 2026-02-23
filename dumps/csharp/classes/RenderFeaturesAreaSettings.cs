using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RenderFeaturesAreaSettings : IAreaSettings
	{
		private CBool _allowGlobalIllumination;
		private CBool _allowScreenSpaceReflections;
		private CBool _allowVolumetricFog;

		[Ordinal(2)] 
		[RED("allowGlobalIllumination")] 
		public CBool AllowGlobalIllumination
		{
			get => GetProperty(ref _allowGlobalIllumination);
			set => SetProperty(ref _allowGlobalIllumination, value);
		}

		[Ordinal(3)] 
		[RED("allowScreenSpaceReflections")] 
		public CBool AllowScreenSpaceReflections
		{
			get => GetProperty(ref _allowScreenSpaceReflections);
			set => SetProperty(ref _allowScreenSpaceReflections, value);
		}

		[Ordinal(4)] 
		[RED("allowVolumetricFog")] 
		public CBool AllowVolumetricFog
		{
			get => GetProperty(ref _allowVolumetricFog);
			set => SetProperty(ref _allowVolumetricFog, value);
		}

		public RenderFeaturesAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
