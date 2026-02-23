using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkHUDScalingMarginAdjustment : inkInitializedWidgetUserData
	{
		private inkMargin _adjustmentMargin;

		[Ordinal(0)] 
		[RED("adjustmentMargin")] 
		public inkMargin AdjustmentMargin
		{
			get => GetProperty(ref _adjustmentMargin);
			set => SetProperty(ref _adjustmentMargin, value);
		}

		public inkHUDScalingMarginAdjustment(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
