using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FeaturesExpansionPopupController : inkWidgetLogicController
	{
		private CName _hoverAnimationName;
		private inkImageWidgetReference _hoverArrow;
		private inkWidgetReference _buyButtonRef;
		private inkTextWidgetReference _buyButtonText;
		private inkWidgetReference _buyButtonInputIcon;
		private inkWidgetReference _buyButtonSpinner;
		private CName _locKey_Buy;
		private CName _locKey_PreOrder;
		private inkWidgetReference _slectorContainerRef;
		private inkWidgetReference _slectorArrowLeftRef;
		private inkWidgetReference _slectorArrowRightRef;
		private inkWidgetReference _videoCarouselRef;
		private inkWidgetReference _videoContainerRef;
		private CArray<VideoCarouselData> _videoCarouselData;
		private wCHandle<VideoCarouselController> _videoCarouselController;
		private wCHandle<inkButtonController> _buyButtonController;
		private CHandle<inkanimProxy> _hoverAnimation;
		private inkanimPlaybackOptions _hoverAnimationOptions;
		private CBool _isEp1Released;

		[Ordinal(1)] 
		[RED("hoverAnimationName")] 
		public CName HoverAnimationName
		{
			get => GetProperty(ref _hoverAnimationName);
			set => SetProperty(ref _hoverAnimationName, value);
		}

		[Ordinal(2)] 
		[RED("hoverArrow")] 
		public inkImageWidgetReference HoverArrow
		{
			get => GetProperty(ref _hoverArrow);
			set => SetProperty(ref _hoverArrow, value);
		}

		[Ordinal(3)] 
		[RED("buyButtonRef")] 
		public inkWidgetReference BuyButtonRef
		{
			get => GetProperty(ref _buyButtonRef);
			set => SetProperty(ref _buyButtonRef, value);
		}

		[Ordinal(4)] 
		[RED("buyButtonText")] 
		public inkTextWidgetReference BuyButtonText
		{
			get => GetProperty(ref _buyButtonText);
			set => SetProperty(ref _buyButtonText, value);
		}

		[Ordinal(5)] 
		[RED("buyButtonInputIcon")] 
		public inkWidgetReference BuyButtonInputIcon
		{
			get => GetProperty(ref _buyButtonInputIcon);
			set => SetProperty(ref _buyButtonInputIcon, value);
		}

		[Ordinal(6)] 
		[RED("buyButtonSpinner")] 
		public inkWidgetReference BuyButtonSpinner
		{
			get => GetProperty(ref _buyButtonSpinner);
			set => SetProperty(ref _buyButtonSpinner, value);
		}

		[Ordinal(7)] 
		[RED("locKey_Buy")] 
		public CName LocKey_Buy
		{
			get => GetProperty(ref _locKey_Buy);
			set => SetProperty(ref _locKey_Buy, value);
		}

		[Ordinal(8)] 
		[RED("locKey_PreOrder")] 
		public CName LocKey_PreOrder
		{
			get => GetProperty(ref _locKey_PreOrder);
			set => SetProperty(ref _locKey_PreOrder, value);
		}

		[Ordinal(9)] 
		[RED("slectorContainerRef")] 
		public inkWidgetReference SlectorContainerRef
		{
			get => GetProperty(ref _slectorContainerRef);
			set => SetProperty(ref _slectorContainerRef, value);
		}

		[Ordinal(10)] 
		[RED("slectorArrowLeftRef")] 
		public inkWidgetReference SlectorArrowLeftRef
		{
			get => GetProperty(ref _slectorArrowLeftRef);
			set => SetProperty(ref _slectorArrowLeftRef, value);
		}

		[Ordinal(11)] 
		[RED("slectorArrowRightRef")] 
		public inkWidgetReference SlectorArrowRightRef
		{
			get => GetProperty(ref _slectorArrowRightRef);
			set => SetProperty(ref _slectorArrowRightRef, value);
		}

		[Ordinal(12)] 
		[RED("videoCarouselRef")] 
		public inkWidgetReference VideoCarouselRef
		{
			get => GetProperty(ref _videoCarouselRef);
			set => SetProperty(ref _videoCarouselRef, value);
		}

		[Ordinal(13)] 
		[RED("videoContainerRef")] 
		public inkWidgetReference VideoContainerRef
		{
			get => GetProperty(ref _videoContainerRef);
			set => SetProperty(ref _videoContainerRef, value);
		}

		[Ordinal(14)] 
		[RED("videoCarouselData")] 
		public CArray<VideoCarouselData> VideoCarouselData
		{
			get => GetProperty(ref _videoCarouselData);
			set => SetProperty(ref _videoCarouselData, value);
		}

		[Ordinal(15)] 
		[RED("videoCarouselController")] 
		public wCHandle<VideoCarouselController> VideoCarouselController
		{
			get => GetProperty(ref _videoCarouselController);
			set => SetProperty(ref _videoCarouselController, value);
		}

		[Ordinal(16)] 
		[RED("buyButtonController")] 
		public wCHandle<inkButtonController> BuyButtonController
		{
			get => GetProperty(ref _buyButtonController);
			set => SetProperty(ref _buyButtonController, value);
		}

		[Ordinal(17)] 
		[RED("hoverAnimation")] 
		public CHandle<inkanimProxy> HoverAnimation
		{
			get => GetProperty(ref _hoverAnimation);
			set => SetProperty(ref _hoverAnimation, value);
		}

		[Ordinal(18)] 
		[RED("hoverAnimationOptions")] 
		public inkanimPlaybackOptions HoverAnimationOptions
		{
			get => GetProperty(ref _hoverAnimationOptions);
			set => SetProperty(ref _hoverAnimationOptions, value);
		}

		[Ordinal(19)] 
		[RED("isEp1Released")] 
		public CBool IsEp1Released
		{
			get => GetProperty(ref _isEp1Released);
			set => SetProperty(ref _isEp1Released, value);
		}

		public FeaturesExpansionPopupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
