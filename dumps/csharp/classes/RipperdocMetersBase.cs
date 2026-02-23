using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocMetersBase : inkWidgetLogicController
	{
		private inkWidgetReference _barAnchor;
		private inkWidgetReference _hoverArea;
		private CName _barWidgetLibraryName;
		private CFloat _barGapSize;
		private CFloat _slopeLengthModifier;
		private CFloat _barIntroAnimDuration;
		private CFloat _barsHeigh;
		private CFloat _barsMargin;
		private CInt32 _bAR_COUNT;
		private CInt32 _bAR_SLOPE_COUNT;
		private CFloat _bAR_ANIM_DURATION;
		private CFloat _bAR_DELAY_OFFSET;
		private CFloat _pulseAnimtopOpacity;
		private CFloat _pulseAnimbottomOpacity;
		private CFloat _pulseAnimpulseRate;
		private CFloat _pulseAnimdelay;
		private PulseAnimationParams _pulseAnimationParams;
		private CArray<wCHandle<RipperdocNewMeterBar>> _bars;
		private CArray<CInt32> _barGaps;
		private CHandle<RipperdocBarTooltipTooltipData> _tooltipData;
		private CHandle<inkanimDefinition> _barIntroAnimDef;
		private CHandle<inkanimProxy> _barIntroAnimProxy;
		private CBool _isIntroPlayed;

		[Ordinal(1)] 
		[RED("barAnchor")] 
		public inkWidgetReference BarAnchor
		{
			get => GetProperty(ref _barAnchor);
			set => SetProperty(ref _barAnchor, value);
		}

		[Ordinal(2)] 
		[RED("hoverArea")] 
		public inkWidgetReference HoverArea
		{
			get => GetProperty(ref _hoverArea);
			set => SetProperty(ref _hoverArea, value);
		}

		[Ordinal(3)] 
		[RED("barWidgetLibraryName")] 
		public CName BarWidgetLibraryName
		{
			get => GetProperty(ref _barWidgetLibraryName);
			set => SetProperty(ref _barWidgetLibraryName, value);
		}

		[Ordinal(4)] 
		[RED("barGapSize")] 
		public CFloat BarGapSize
		{
			get => GetProperty(ref _barGapSize);
			set => SetProperty(ref _barGapSize, value);
		}

		[Ordinal(5)] 
		[RED("slopeLengthModifier")] 
		public CFloat SlopeLengthModifier
		{
			get => GetProperty(ref _slopeLengthModifier);
			set => SetProperty(ref _slopeLengthModifier, value);
		}

		[Ordinal(6)] 
		[RED("barIntroAnimDuration")] 
		public CFloat BarIntroAnimDuration
		{
			get => GetProperty(ref _barIntroAnimDuration);
			set => SetProperty(ref _barIntroAnimDuration, value);
		}

		[Ordinal(7)] 
		[RED("barsHeigh")] 
		public CFloat BarsHeigh
		{
			get => GetProperty(ref _barsHeigh);
			set => SetProperty(ref _barsHeigh, value);
		}

		[Ordinal(8)] 
		[RED("barsMargin")] 
		public CFloat BarsMargin
		{
			get => GetProperty(ref _barsMargin);
			set => SetProperty(ref _barsMargin, value);
		}

		[Ordinal(9)] 
		[RED("BAR_COUNT")] 
		public CInt32 BAR_COUNT
		{
			get => GetProperty(ref _bAR_COUNT);
			set => SetProperty(ref _bAR_COUNT, value);
		}

		[Ordinal(10)] 
		[RED("BAR_SLOPE_COUNT")] 
		public CInt32 BAR_SLOPE_COUNT
		{
			get => GetProperty(ref _bAR_SLOPE_COUNT);
			set => SetProperty(ref _bAR_SLOPE_COUNT, value);
		}

		[Ordinal(11)] 
		[RED("BAR_ANIM_DURATION")] 
		public CFloat BAR_ANIM_DURATION
		{
			get => GetProperty(ref _bAR_ANIM_DURATION);
			set => SetProperty(ref _bAR_ANIM_DURATION, value);
		}

		[Ordinal(12)] 
		[RED("BAR_DELAY_OFFSET")] 
		public CFloat BAR_DELAY_OFFSET
		{
			get => GetProperty(ref _bAR_DELAY_OFFSET);
			set => SetProperty(ref _bAR_DELAY_OFFSET, value);
		}

		[Ordinal(13)] 
		[RED("pulseAnimtopOpacity")] 
		public CFloat PulseAnimtopOpacity
		{
			get => GetProperty(ref _pulseAnimtopOpacity);
			set => SetProperty(ref _pulseAnimtopOpacity, value);
		}

		[Ordinal(14)] 
		[RED("pulseAnimbottomOpacity")] 
		public CFloat PulseAnimbottomOpacity
		{
			get => GetProperty(ref _pulseAnimbottomOpacity);
			set => SetProperty(ref _pulseAnimbottomOpacity, value);
		}

		[Ordinal(15)] 
		[RED("pulseAnimpulseRate")] 
		public CFloat PulseAnimpulseRate
		{
			get => GetProperty(ref _pulseAnimpulseRate);
			set => SetProperty(ref _pulseAnimpulseRate, value);
		}

		[Ordinal(16)] 
		[RED("pulseAnimdelay")] 
		public CFloat PulseAnimdelay
		{
			get => GetProperty(ref _pulseAnimdelay);
			set => SetProperty(ref _pulseAnimdelay, value);
		}

		[Ordinal(17)] 
		[RED("pulseAnimationParams")] 
		public PulseAnimationParams PulseAnimationParams
		{
			get => GetProperty(ref _pulseAnimationParams);
			set => SetProperty(ref _pulseAnimationParams, value);
		}

		[Ordinal(18)] 
		[RED("bars")] 
		public CArray<wCHandle<RipperdocNewMeterBar>> Bars
		{
			get => GetProperty(ref _bars);
			set => SetProperty(ref _bars, value);
		}

		[Ordinal(19)] 
		[RED("barGaps")] 
		public CArray<CInt32> BarGaps
		{
			get => GetProperty(ref _barGaps);
			set => SetProperty(ref _barGaps, value);
		}

		[Ordinal(20)] 
		[RED("tooltipData")] 
		public CHandle<RipperdocBarTooltipTooltipData> TooltipData
		{
			get => GetProperty(ref _tooltipData);
			set => SetProperty(ref _tooltipData, value);
		}

		[Ordinal(21)] 
		[RED("barIntroAnimDef")] 
		public CHandle<inkanimDefinition> BarIntroAnimDef
		{
			get => GetProperty(ref _barIntroAnimDef);
			set => SetProperty(ref _barIntroAnimDef, value);
		}

		[Ordinal(22)] 
		[RED("barIntroAnimProxy")] 
		public CHandle<inkanimProxy> BarIntroAnimProxy
		{
			get => GetProperty(ref _barIntroAnimProxy);
			set => SetProperty(ref _barIntroAnimProxy, value);
		}

		[Ordinal(23)] 
		[RED("isIntroPlayed")] 
		public CBool IsIntroPlayed
		{
			get => GetProperty(ref _isIntroPlayed);
			set => SetProperty(ref _isIntroPlayed, value);
		}

		public RipperdocMetersBase(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
