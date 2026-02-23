using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiResolutionSensitiveWidget : CVariable
	{
		private inkWidgetReference _widget;
		private inkMargin _marginToScalecorrectOverride;

		[Ordinal(0)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("marginToScalecorrectOverride")] 
		public inkMargin MarginToScalecorrectOverride
		{
			get => GetProperty(ref _marginToScalecorrectOverride);
			set => SetProperty(ref _marginToScalecorrectOverride, value);
		}

		public gameuiResolutionSensitiveWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
