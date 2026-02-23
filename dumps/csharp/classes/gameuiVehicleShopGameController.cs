using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiVehicleShopGameController : gameuiWidgetGameController
	{
		private inkWidgetReference _homePage;
		private inkTextWidgetReference _homePageMainText;
		private inkWidgetReference _rightSidePanel;
		private inkWidgetReference _headerImage;
		private inkWidgetReference _offersCanvas;
		private inkWidgetReference _detailsCanvas;
		private inkCompoundWidgetReference _brandsListWidget;
		private inkCompoundWidgetReference _offersGridWidget;
		private inkTextWidgetReference _headerText;
		private inkWidgetReference _scrollControllerWidget;
		private inkTextWidgetReference _playerBalanceText;
		private wCHandle<MoneyLabelController> _playerBalanceAnimator;
		private CHandle<VehicleShopPlayerBalanceCallback> _callback;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private CArray<wCHandle<VehicleBrandFilterLogicController>> _brandButtons;
		private CArray<wCHandle<VehicleOfferLogicController>> _offerButtons;
		private wCHandle<VehicleDetailsLogicController> _detailsController;
		private wCHandle<VehicleBrandFilterLogicController> _currentBrandController;
		private CFloat _discount;
		private TweakDBID _c_discountFactTDBID;
		private TweakDBID _c_discountValuesTDBID;

		[Ordinal(2)] 
		[RED("homePage")] 
		public inkWidgetReference HomePage
		{
			get => GetProperty(ref _homePage);
			set => SetProperty(ref _homePage, value);
		}

		[Ordinal(3)] 
		[RED("homePageMainText")] 
		public inkTextWidgetReference HomePageMainText
		{
			get => GetProperty(ref _homePageMainText);
			set => SetProperty(ref _homePageMainText, value);
		}

		[Ordinal(4)] 
		[RED("rightSidePanel")] 
		public inkWidgetReference RightSidePanel
		{
			get => GetProperty(ref _rightSidePanel);
			set => SetProperty(ref _rightSidePanel, value);
		}

		[Ordinal(5)] 
		[RED("headerImage")] 
		public inkWidgetReference HeaderImage
		{
			get => GetProperty(ref _headerImage);
			set => SetProperty(ref _headerImage, value);
		}

		[Ordinal(6)] 
		[RED("offersCanvas")] 
		public inkWidgetReference OffersCanvas
		{
			get => GetProperty(ref _offersCanvas);
			set => SetProperty(ref _offersCanvas, value);
		}

		[Ordinal(7)] 
		[RED("detailsCanvas")] 
		public inkWidgetReference DetailsCanvas
		{
			get => GetProperty(ref _detailsCanvas);
			set => SetProperty(ref _detailsCanvas, value);
		}

		[Ordinal(8)] 
		[RED("brandsListWidget")] 
		public inkCompoundWidgetReference BrandsListWidget
		{
			get => GetProperty(ref _brandsListWidget);
			set => SetProperty(ref _brandsListWidget, value);
		}

		[Ordinal(9)] 
		[RED("offersGridWidget")] 
		public inkCompoundWidgetReference OffersGridWidget
		{
			get => GetProperty(ref _offersGridWidget);
			set => SetProperty(ref _offersGridWidget, value);
		}

		[Ordinal(10)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetProperty(ref _headerText);
			set => SetProperty(ref _headerText, value);
		}

		[Ordinal(11)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(12)] 
		[RED("playerBalanceText")] 
		public inkTextWidgetReference PlayerBalanceText
		{
			get => GetProperty(ref _playerBalanceText);
			set => SetProperty(ref _playerBalanceText, value);
		}

		[Ordinal(13)] 
		[RED("playerBalanceAnimator")] 
		public wCHandle<MoneyLabelController> PlayerBalanceAnimator
		{
			get => GetProperty(ref _playerBalanceAnimator);
			set => SetProperty(ref _playerBalanceAnimator, value);
		}

		[Ordinal(14)] 
		[RED("callback")] 
		public CHandle<VehicleShopPlayerBalanceCallback> Callback
		{
			get => GetProperty(ref _callback);
			set => SetProperty(ref _callback, value);
		}

		[Ordinal(15)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(16)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(17)] 
		[RED("brandButtons")] 
		public CArray<wCHandle<VehicleBrandFilterLogicController>> BrandButtons
		{
			get => GetProperty(ref _brandButtons);
			set => SetProperty(ref _brandButtons, value);
		}

		[Ordinal(18)] 
		[RED("offerButtons")] 
		public CArray<wCHandle<VehicleOfferLogicController>> OfferButtons
		{
			get => GetProperty(ref _offerButtons);
			set => SetProperty(ref _offerButtons, value);
		}

		[Ordinal(19)] 
		[RED("detailsController")] 
		public wCHandle<VehicleDetailsLogicController> DetailsController
		{
			get => GetProperty(ref _detailsController);
			set => SetProperty(ref _detailsController, value);
		}

		[Ordinal(20)] 
		[RED("currentBrandController")] 
		public wCHandle<VehicleBrandFilterLogicController> CurrentBrandController
		{
			get => GetProperty(ref _currentBrandController);
			set => SetProperty(ref _currentBrandController, value);
		}

		[Ordinal(21)] 
		[RED("discount")] 
		public CFloat Discount
		{
			get => GetProperty(ref _discount);
			set => SetProperty(ref _discount, value);
		}

		[Ordinal(22)] 
		[RED("c_discountFactTDBID")] 
		public TweakDBID C_discountFactTDBID
		{
			get => GetProperty(ref _c_discountFactTDBID);
			set => SetProperty(ref _c_discountFactTDBID, value);
		}

		[Ordinal(23)] 
		[RED("c_discountValuesTDBID")] 
		public TweakDBID C_discountValuesTDBID
		{
			get => GetProperty(ref _c_discountValuesTDBID);
			set => SetProperty(ref _c_discountValuesTDBID, value);
		}

		public gameuiVehicleShopGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
