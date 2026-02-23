using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RTXDIAreaSettings : IAreaSettings
	{
		private CFloat _diffuseSkyScale;
		private CFloat _specularSkyScale;

		[Ordinal(2)] 
		[RED("diffuseSkyScale")] 
		public CFloat DiffuseSkyScale
		{
			get => GetProperty(ref _diffuseSkyScale);
			set => SetProperty(ref _diffuseSkyScale, value);
		}

		[Ordinal(3)] 
		[RED("specularSkyScale")] 
		public CFloat SpecularSkyScale
		{
			get => GetProperty(ref _specularSkyScale);
			set => SetProperty(ref _specularSkyScale, value);
		}

		public RTXDIAreaSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
