using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkEnableHUDScaleOverride : inkInitializedWidgetUserData
	{
		private CFloat _scalingInterpolationValue;

		[Ordinal(0)] 
		[RED("scalingInterpolationValue")] 
		public CFloat ScalingInterpolationValue
		{
			get => GetProperty(ref _scalingInterpolationValue);
			set => SetProperty(ref _scalingInterpolationValue, value);
		}

		public inkEnableHUDScaleOverride(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
