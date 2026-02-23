using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterExplodingPlatformsImageWidgetDetail : CVariable
	{
		private CName _platformName;
		private CArray<gameuiarcadeShooterPlatformImageDetail> _platformImageDetails;

		[Ordinal(0)] 
		[RED("platformName")] 
		public CName PlatformName
		{
			get => GetProperty(ref _platformName);
			set => SetProperty(ref _platformName, value);
		}

		[Ordinal(1)] 
		[RED("platformImageDetails")] 
		public CArray<gameuiarcadeShooterPlatformImageDetail> PlatformImageDetails
		{
			get => GetProperty(ref _platformImageDetails);
			set => SetProperty(ref _platformImageDetails, value);
		}

		public gameuiarcadeShooterExplodingPlatformsImageWidgetDetail(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
