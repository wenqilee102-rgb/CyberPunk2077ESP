using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipStatBarController : inkWidgetLogicController
	{
		private inkWidgetReference _background;
		private inkWidgetReference _bar;
		private inkWidgetReference _comparisonBar;
		private inkTextWidgetReference _statName;
		private inkTextWidgetReference _overflow;
		private inkTextWidgetReference _statValue;
		private inkWidgetReference _comparisonArrow;
		private inkWidgetReference _separators;
		private CHandle<inkanimProxy> _barAnimProxy;
		private CHandle<inkanimProxy> _diffBarAnimProxy;
		private HDRColor _betterColor;
		private HDRColor _worseColor;
		private CFloat _width;

		[Ordinal(1)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(2)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(3)] 
		[RED("comparisonBar")] 
		public inkWidgetReference ComparisonBar
		{
			get => GetProperty(ref _comparisonBar);
			set => SetProperty(ref _comparisonBar, value);
		}

		[Ordinal(4)] 
		[RED("statName")] 
		public inkTextWidgetReference StatName
		{
			get => GetProperty(ref _statName);
			set => SetProperty(ref _statName, value);
		}

		[Ordinal(5)] 
		[RED("overflow")] 
		public inkTextWidgetReference Overflow
		{
			get => GetProperty(ref _overflow);
			set => SetProperty(ref _overflow, value);
		}

		[Ordinal(6)] 
		[RED("statValue")] 
		public inkTextWidgetReference StatValue
		{
			get => GetProperty(ref _statValue);
			set => SetProperty(ref _statValue, value);
		}

		[Ordinal(7)] 
		[RED("comparisonArrow")] 
		public inkWidgetReference ComparisonArrow
		{
			get => GetProperty(ref _comparisonArrow);
			set => SetProperty(ref _comparisonArrow, value);
		}

		[Ordinal(8)] 
		[RED("separators")] 
		public inkWidgetReference Separators
		{
			get => GetProperty(ref _separators);
			set => SetProperty(ref _separators, value);
		}

		[Ordinal(9)] 
		[RED("barAnimProxy")] 
		public CHandle<inkanimProxy> BarAnimProxy
		{
			get => GetProperty(ref _barAnimProxy);
			set => SetProperty(ref _barAnimProxy, value);
		}

		[Ordinal(10)] 
		[RED("diffBarAnimProxy")] 
		public CHandle<inkanimProxy> DiffBarAnimProxy
		{
			get => GetProperty(ref _diffBarAnimProxy);
			set => SetProperty(ref _diffBarAnimProxy, value);
		}

		[Ordinal(11)] 
		[RED("betterColor")] 
		public HDRColor BetterColor
		{
			get => GetProperty(ref _betterColor);
			set => SetProperty(ref _betterColor, value);
		}

		[Ordinal(12)] 
		[RED("worseColor")] 
		public HDRColor WorseColor
		{
			get => GetProperty(ref _worseColor);
			set => SetProperty(ref _worseColor, value);
		}

		[Ordinal(13)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		public NewItemTooltipStatBarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
