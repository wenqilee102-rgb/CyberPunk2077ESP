using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHudScalingSensitiveWidget : CVariable
	{
		private inkWidgetReference _widget;
		private CBool _adjustScale;
		private CBool _adjustTranslation;
		private CBool _adjustMargin;
		private inkMargin _targetMarginAtDoubleScale;
		private inkMargin _marginToScalecorrectOverride;

		[Ordinal(0)] 
		[RED("widget")] 
		public inkWidgetReference Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		[Ordinal(1)] 
		[RED("adjustScale")] 
		public CBool AdjustScale
		{
			get => GetProperty(ref _adjustScale);
			set => SetProperty(ref _adjustScale, value);
		}

		[Ordinal(2)] 
		[RED("adjustTranslation")] 
		public CBool AdjustTranslation
		{
			get => GetProperty(ref _adjustTranslation);
			set => SetProperty(ref _adjustTranslation, value);
		}

		[Ordinal(3)] 
		[RED("adjustMargin")] 
		public CBool AdjustMargin
		{
			get => GetProperty(ref _adjustMargin);
			set => SetProperty(ref _adjustMargin, value);
		}

		[Ordinal(4)] 
		[RED("targetMarginAtDoubleScale")] 
		public inkMargin TargetMarginAtDoubleScale
		{
			get => GetProperty(ref _targetMarginAtDoubleScale);
			set => SetProperty(ref _targetMarginAtDoubleScale, value);
		}

		[Ordinal(5)] 
		[RED("marginToScalecorrectOverride")] 
		public inkMargin MarginToScalecorrectOverride
		{
			get => GetProperty(ref _marginToScalecorrectOverride);
			set => SetProperty(ref _marginToScalecorrectOverride, value);
		}

		public gameuiHudScalingSensitiveWidget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
