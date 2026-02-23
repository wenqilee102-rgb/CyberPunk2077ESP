using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WorldMapTooltipController : WorldMapTooltipBaseController
	{
		private inkTextWidgetReference _titleText;
		private inkImageWidgetReference _fixerIcon;
		private inkTextWidgetReference _descText;
		private inkTextWidgetReference _warningText;
		private inkTextWidgetReference _additionalDescText;
		private inkWidgetReference _lineBreak;
		private inkImageWidgetReference _icon;
		private inkImageWidgetReference _ep1Icon;
		private inkCompoundWidgetReference _inputOpenJournalContainer;
		private inkCompoundWidgetReference _inputInteractContainer;
		private inkCompoundWidgetReference _inputMoreInfoContainer;
		private inkCompoundWidgetReference _inputDelamainTaxiContainer;
		private inkCompoundWidgetReference _travelCostContainer;
		private inkTextWidgetReference _travelCostText;
		private inkWidgetReference _threatLevelPanel;
		private inkTextWidgetReference _threatLevelValue;
		private inkWidgetReference _fixerPanel;
		private inkImageWidgetReference _linkImage;
		private CFloat _gigProgress;
		private inkWidgetReference _bar;
		private CHandle<inkanimProxy> _barAnimationProxy;
		private CHandle<inkanimProxy> _animationProxy;
		private inkTextWidgetReference _gigBarCompletedText;
		private inkTextWidgetReference _gigBarTotalText;

		[Ordinal(5)] 
		[RED("titleText")] 
		public inkTextWidgetReference TitleText
		{
			get => GetProperty(ref _titleText);
			set => SetProperty(ref _titleText, value);
		}

		[Ordinal(6)] 
		[RED("fixerIcon")] 
		public inkImageWidgetReference FixerIcon
		{
			get => GetProperty(ref _fixerIcon);
			set => SetProperty(ref _fixerIcon, value);
		}

		[Ordinal(7)] 
		[RED("descText")] 
		public inkTextWidgetReference DescText
		{
			get => GetProperty(ref _descText);
			set => SetProperty(ref _descText, value);
		}

		[Ordinal(8)] 
		[RED("warningText")] 
		public inkTextWidgetReference WarningText
		{
			get => GetProperty(ref _warningText);
			set => SetProperty(ref _warningText, value);
		}

		[Ordinal(9)] 
		[RED("additionalDescText")] 
		public inkTextWidgetReference AdditionalDescText
		{
			get => GetProperty(ref _additionalDescText);
			set => SetProperty(ref _additionalDescText, value);
		}

		[Ordinal(10)] 
		[RED("lineBreak")] 
		public inkWidgetReference LineBreak
		{
			get => GetProperty(ref _lineBreak);
			set => SetProperty(ref _lineBreak, value);
		}

		[Ordinal(11)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(12)] 
		[RED("ep1Icon")] 
		public inkImageWidgetReference Ep1Icon
		{
			get => GetProperty(ref _ep1Icon);
			set => SetProperty(ref _ep1Icon, value);
		}

		[Ordinal(13)] 
		[RED("inputOpenJournalContainer")] 
		public inkCompoundWidgetReference InputOpenJournalContainer
		{
			get => GetProperty(ref _inputOpenJournalContainer);
			set => SetProperty(ref _inputOpenJournalContainer, value);
		}

		[Ordinal(14)] 
		[RED("inputInteractContainer")] 
		public inkCompoundWidgetReference InputInteractContainer
		{
			get => GetProperty(ref _inputInteractContainer);
			set => SetProperty(ref _inputInteractContainer, value);
		}

		[Ordinal(15)] 
		[RED("inputMoreInfoContainer")] 
		public inkCompoundWidgetReference InputMoreInfoContainer
		{
			get => GetProperty(ref _inputMoreInfoContainer);
			set => SetProperty(ref _inputMoreInfoContainer, value);
		}

		[Ordinal(16)] 
		[RED("inputDelamainTaxiContainer")] 
		public inkCompoundWidgetReference InputDelamainTaxiContainer
		{
			get => GetProperty(ref _inputDelamainTaxiContainer);
			set => SetProperty(ref _inputDelamainTaxiContainer, value);
		}

		[Ordinal(17)] 
		[RED("travelCostContainer")] 
		public inkCompoundWidgetReference TravelCostContainer
		{
			get => GetProperty(ref _travelCostContainer);
			set => SetProperty(ref _travelCostContainer, value);
		}

		[Ordinal(18)] 
		[RED("travelCostText")] 
		public inkTextWidgetReference TravelCostText
		{
			get => GetProperty(ref _travelCostText);
			set => SetProperty(ref _travelCostText, value);
		}

		[Ordinal(19)] 
		[RED("threatLevelPanel")] 
		public inkWidgetReference ThreatLevelPanel
		{
			get => GetProperty(ref _threatLevelPanel);
			set => SetProperty(ref _threatLevelPanel, value);
		}

		[Ordinal(20)] 
		[RED("threatLevelValue")] 
		public inkTextWidgetReference ThreatLevelValue
		{
			get => GetProperty(ref _threatLevelValue);
			set => SetProperty(ref _threatLevelValue, value);
		}

		[Ordinal(21)] 
		[RED("fixerPanel")] 
		public inkWidgetReference FixerPanel
		{
			get => GetProperty(ref _fixerPanel);
			set => SetProperty(ref _fixerPanel, value);
		}

		[Ordinal(22)] 
		[RED("linkImage")] 
		public inkImageWidgetReference LinkImage
		{
			get => GetProperty(ref _linkImage);
			set => SetProperty(ref _linkImage, value);
		}

		[Ordinal(23)] 
		[RED("gigProgress")] 
		public CFloat GigProgress
		{
			get => GetProperty(ref _gigProgress);
			set => SetProperty(ref _gigProgress, value);
		}

		[Ordinal(24)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(25)] 
		[RED("barAnimationProxy")] 
		public CHandle<inkanimProxy> BarAnimationProxy
		{
			get => GetProperty(ref _barAnimationProxy);
			set => SetProperty(ref _barAnimationProxy, value);
		}

		[Ordinal(26)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(27)] 
		[RED("gigBarCompletedText")] 
		public inkTextWidgetReference GigBarCompletedText
		{
			get => GetProperty(ref _gigBarCompletedText);
			set => SetProperty(ref _gigBarCompletedText, value);
		}

		[Ordinal(28)] 
		[RED("gigBarTotalText")] 
		public inkTextWidgetReference GigBarTotalText
		{
			get => GetProperty(ref _gigBarTotalText);
			set => SetProperty(ref _gigBarTotalText, value);
		}

		public WorldMapTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
