using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExpansionPopupGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _popupCanvasAnchor;
		private CName _expansionScreenName;
		private CName _thankYouScreenName;
		private CName _reloadingScreenName;
		private CName _preOrderScreenName;
		private inkWidgetReference _closeButtonRef;
		private CName _introAnimationName;
		private CHandle<gameuiGameSystemUI> _uiSystem;
		private CHandle<ExpansionPopupData> _data;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;
		private CBool _showThankYouPanel;
		private CHandle<inkanimProxy> _introAnimProxy;
		private wCHandle<FeaturesExpansionPopupController> _featuresExpansionPopupController;
		private wCHandle<PreOrderPopupController> _preOrderPopupController;
		private wCHandle<ReloadingExpansionPopupController> _reloadingPopupController;
		private inkWidgetReference _buyButton;
		private inkWidgetReference _preOrderButton;
		private CBool _isProcessingPurchase;

		[Ordinal(2)] 
		[RED("popupCanvasAnchor")] 
		public inkWidgetReference PopupCanvasAnchor
		{
			get => GetProperty(ref _popupCanvasAnchor);
			set => SetProperty(ref _popupCanvasAnchor, value);
		}

		[Ordinal(3)] 
		[RED("expansionScreenName")] 
		public CName ExpansionScreenName
		{
			get => GetProperty(ref _expansionScreenName);
			set => SetProperty(ref _expansionScreenName, value);
		}

		[Ordinal(4)] 
		[RED("thankYouScreenName")] 
		public CName ThankYouScreenName
		{
			get => GetProperty(ref _thankYouScreenName);
			set => SetProperty(ref _thankYouScreenName, value);
		}

		[Ordinal(5)] 
		[RED("reloadingScreenName")] 
		public CName ReloadingScreenName
		{
			get => GetProperty(ref _reloadingScreenName);
			set => SetProperty(ref _reloadingScreenName, value);
		}

		[Ordinal(6)] 
		[RED("preOrderScreenName")] 
		public CName PreOrderScreenName
		{
			get => GetProperty(ref _preOrderScreenName);
			set => SetProperty(ref _preOrderScreenName, value);
		}

		[Ordinal(7)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetProperty(ref _closeButtonRef);
			set => SetProperty(ref _closeButtonRef, value);
		}

		[Ordinal(8)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(9)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(10)] 
		[RED("data")] 
		public CHandle<ExpansionPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(11)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		[Ordinal(12)] 
		[RED("showThankYouPanel")] 
		public CBool ShowThankYouPanel
		{
			get => GetProperty(ref _showThankYouPanel);
			set => SetProperty(ref _showThankYouPanel, value);
		}

		[Ordinal(13)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(14)] 
		[RED("featuresExpansionPopupController")] 
		public wCHandle<FeaturesExpansionPopupController> FeaturesExpansionPopupController
		{
			get => GetProperty(ref _featuresExpansionPopupController);
			set => SetProperty(ref _featuresExpansionPopupController, value);
		}

		[Ordinal(15)] 
		[RED("preOrderPopupController")] 
		public wCHandle<PreOrderPopupController> PreOrderPopupController
		{
			get => GetProperty(ref _preOrderPopupController);
			set => SetProperty(ref _preOrderPopupController, value);
		}

		[Ordinal(16)] 
		[RED("reloadingPopupController")] 
		public wCHandle<ReloadingExpansionPopupController> ReloadingPopupController
		{
			get => GetProperty(ref _reloadingPopupController);
			set => SetProperty(ref _reloadingPopupController, value);
		}

		[Ordinal(17)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get => GetProperty(ref _buyButton);
			set => SetProperty(ref _buyButton, value);
		}

		[Ordinal(18)] 
		[RED("preOrderButton")] 
		public inkWidgetReference PreOrderButton
		{
			get => GetProperty(ref _preOrderButton);
			set => SetProperty(ref _preOrderButton, value);
		}

		[Ordinal(19)] 
		[RED("isProcessingPurchase")] 
		public CBool IsProcessingPurchase
		{
			get => GetProperty(ref _isProcessingPurchase);
			set => SetProperty(ref _isProcessingPurchase, value);
		}

		public ExpansionPopupGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
