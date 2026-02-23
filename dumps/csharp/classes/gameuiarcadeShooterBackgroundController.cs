using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterBackgroundController : inkWidgetLogicController
	{
		private CArray<gameuiarcadeShooterLayerInfo> _layerInfo;
		private CBool _allowMarginTranslation;
		private CArray<gameuiarcadeShooterExplodingPlatformsImageWidgetDetail> _expPlatformImageDetails;

		[Ordinal(1)] 
		[RED("layerInfo")] 
		public CArray<gameuiarcadeShooterLayerInfo> LayerInfo
		{
			get => GetProperty(ref _layerInfo);
			set => SetProperty(ref _layerInfo, value);
		}

		[Ordinal(2)] 
		[RED("allowMarginTranslation")] 
		public CBool AllowMarginTranslation
		{
			get => GetProperty(ref _allowMarginTranslation);
			set => SetProperty(ref _allowMarginTranslation, value);
		}

		[Ordinal(3)] 
		[RED("expPlatformImageDetails")] 
		public CArray<gameuiarcadeShooterExplodingPlatformsImageWidgetDetail> ExpPlatformImageDetails
		{
			get => GetProperty(ref _expPlatformImageDetails);
			set => SetProperty(ref _expPlatformImageDetails, value);
		}

		public gameuiarcadeShooterBackgroundController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
