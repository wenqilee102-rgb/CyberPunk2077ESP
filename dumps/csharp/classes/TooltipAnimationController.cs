using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TooltipAnimationController : inkWidgetLogicController
	{
		private inkWidgetReference _tooltipContainer;
		private CHandle<inkanimDefinition> _tooltipAnimHideDef;
		private CHandle<inkanimDefinition> _tooltipDelayedShowDef;
		private CHandle<inkanimProxy> _tooltipAnimHide;
		private CHandle<inkanimProxy> _tooltipDelayedShow;
		private CFloat _axisDataThreshold;
		private CFloat _mouseDataThreshold;
		private CBool _isHidden;

		[Ordinal(1)] 
		[RED("tooltipContainer")] 
		public inkWidgetReference TooltipContainer
		{
			get => GetProperty(ref _tooltipContainer);
			set => SetProperty(ref _tooltipContainer, value);
		}

		[Ordinal(2)] 
		[RED("tooltipAnimHideDef")] 
		public CHandle<inkanimDefinition> TooltipAnimHideDef
		{
			get => GetProperty(ref _tooltipAnimHideDef);
			set => SetProperty(ref _tooltipAnimHideDef, value);
		}

		[Ordinal(3)] 
		[RED("tooltipDelayedShowDef")] 
		public CHandle<inkanimDefinition> TooltipDelayedShowDef
		{
			get => GetProperty(ref _tooltipDelayedShowDef);
			set => SetProperty(ref _tooltipDelayedShowDef, value);
		}

		[Ordinal(4)] 
		[RED("tooltipAnimHide")] 
		public CHandle<inkanimProxy> TooltipAnimHide
		{
			get => GetProperty(ref _tooltipAnimHide);
			set => SetProperty(ref _tooltipAnimHide, value);
		}

		[Ordinal(5)] 
		[RED("tooltipDelayedShow")] 
		public CHandle<inkanimProxy> TooltipDelayedShow
		{
			get => GetProperty(ref _tooltipDelayedShow);
			set => SetProperty(ref _tooltipDelayedShow, value);
		}

		[Ordinal(6)] 
		[RED("axisDataThreshold")] 
		public CFloat AxisDataThreshold
		{
			get => GetProperty(ref _axisDataThreshold);
			set => SetProperty(ref _axisDataThreshold, value);
		}

		[Ordinal(7)] 
		[RED("mouseDataThreshold")] 
		public CFloat MouseDataThreshold
		{
			get => GetProperty(ref _mouseDataThreshold);
			set => SetProperty(ref _mouseDataThreshold, value);
		}

		[Ordinal(8)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		public TooltipAnimationController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
