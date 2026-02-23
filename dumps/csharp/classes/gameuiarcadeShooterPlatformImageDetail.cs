using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterPlatformImageDetail : CVariable
	{
		private inkWidgetReference _platformImage;

		[Ordinal(0)] 
		[RED("platformImage")] 
		public inkWidgetReference PlatformImage
		{
			get => GetProperty(ref _platformImage);
			set => SetProperty(ref _platformImage, value);
		}

		public gameuiarcadeShooterPlatformImageDetail(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
