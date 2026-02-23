using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerYaibaShowroomController : gameuiWidgetGameController
	{
		private CName _orderedFact;
		private CName _toBuyPageAnim;
		private inkTextWidgetReference _modelText;
		private inkWidgetReference _homePage;
		private inkWidgetReference _buyButton;
		private inkWidgetReference _buyPage;
		private inkTextWidgetReference _playerBalanceText;
		private inkWidgetReference _detailsCanvas;
		private inkImageWidgetReference _speedometer;
		private inkWidgetReference _orderButton;
		private inkWidgetReference _backButton;
		private inkWidgetReference _wheelCoverCheckBox;
		private inkWidgetReference _wheelRimsCheckBox;
		private inkWidgetReference _brandingCheckBox;
		private inkWidgetReference _backRestCheckBox;
		private inkWidgetReference _wheelCoverPreview;
		private inkWidgetReference _wheelRimsPreview;
		private inkWidgetReference _brandingPreview;
		private inkWidgetReference _backRestPreview;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private wCHandle<YaibaButton> _orderButtonController;
		private wCHandle<YaibaButton> _backButtonController;
		private wCHandle<CheckYaibaOption> _wheelCoverCheckController;
		private wCHandle<CheckYaibaOption> _wheelRimsCheckController;
		private wCHandle<CheckYaibaOption> _brandingCheckController;
		private wCHandle<CheckYaibaOption> _backRestCheckController;
		private CName _wheelCoverFact;
		private CName _wheelRimsFact;
		private CName _brandingFact;
		private CName _backRestFact;
		private CBool _isAnimated;
		private CHandle<userSettingsUserSettings> _settings;

		[Ordinal(2)] 
		[RED("orderedFact")] 
		public CName OrderedFact
		{
			get => GetProperty(ref _orderedFact);
			set => SetProperty(ref _orderedFact, value);
		}

		[Ordinal(3)] 
		[RED("toBuyPageAnim")] 
		public CName ToBuyPageAnim
		{
			get => GetProperty(ref _toBuyPageAnim);
			set => SetProperty(ref _toBuyPageAnim, value);
		}

		[Ordinal(4)] 
		[RED("modelText")] 
		public inkTextWidgetReference ModelText
		{
			get => GetProperty(ref _modelText);
			set => SetProperty(ref _modelText, value);
		}

		[Ordinal(5)] 
		[RED("homePage")] 
		public inkWidgetReference HomePage
		{
			get => GetProperty(ref _homePage);
			set => SetProperty(ref _homePage, value);
		}

		[Ordinal(6)] 
		[RED("buyButton")] 
		public inkWidgetReference BuyButton
		{
			get => GetProperty(ref _buyButton);
			set => SetProperty(ref _buyButton, value);
		}

		[Ordinal(7)] 
		[RED("buyPage")] 
		public inkWidgetReference BuyPage
		{
			get => GetProperty(ref _buyPage);
			set => SetProperty(ref _buyPage, value);
		}

		[Ordinal(8)] 
		[RED("playerBalanceText")] 
		public inkTextWidgetReference PlayerBalanceText
		{
			get => GetProperty(ref _playerBalanceText);
			set => SetProperty(ref _playerBalanceText, value);
		}

		[Ordinal(9)] 
		[RED("detailsCanvas")] 
		public inkWidgetReference DetailsCanvas
		{
			get => GetProperty(ref _detailsCanvas);
			set => SetProperty(ref _detailsCanvas, value);
		}

		[Ordinal(10)] 
		[RED("speedometer")] 
		public inkImageWidgetReference Speedometer
		{
			get => GetProperty(ref _speedometer);
			set => SetProperty(ref _speedometer, value);
		}

		[Ordinal(11)] 
		[RED("orderButton")] 
		public inkWidgetReference OrderButton
		{
			get => GetProperty(ref _orderButton);
			set => SetProperty(ref _orderButton, value);
		}

		[Ordinal(12)] 
		[RED("backButton")] 
		public inkWidgetReference BackButton
		{
			get => GetProperty(ref _backButton);
			set => SetProperty(ref _backButton, value);
		}

		[Ordinal(13)] 
		[RED("wheelCoverCheckBox")] 
		public inkWidgetReference WheelCoverCheckBox
		{
			get => GetProperty(ref _wheelCoverCheckBox);
			set => SetProperty(ref _wheelCoverCheckBox, value);
		}

		[Ordinal(14)] 
		[RED("wheelRimsCheckBox")] 
		public inkWidgetReference WheelRimsCheckBox
		{
			get => GetProperty(ref _wheelRimsCheckBox);
			set => SetProperty(ref _wheelRimsCheckBox, value);
		}

		[Ordinal(15)] 
		[RED("brandingCheckBox")] 
		public inkWidgetReference BrandingCheckBox
		{
			get => GetProperty(ref _brandingCheckBox);
			set => SetProperty(ref _brandingCheckBox, value);
		}

		[Ordinal(16)] 
		[RED("backRestCheckBox")] 
		public inkWidgetReference BackRestCheckBox
		{
			get => GetProperty(ref _backRestCheckBox);
			set => SetProperty(ref _backRestCheckBox, value);
		}

		[Ordinal(17)] 
		[RED("wheelCoverPreview")] 
		public inkWidgetReference WheelCoverPreview
		{
			get => GetProperty(ref _wheelCoverPreview);
			set => SetProperty(ref _wheelCoverPreview, value);
		}

		[Ordinal(18)] 
		[RED("wheelRimsPreview")] 
		public inkWidgetReference WheelRimsPreview
		{
			get => GetProperty(ref _wheelRimsPreview);
			set => SetProperty(ref _wheelRimsPreview, value);
		}

		[Ordinal(19)] 
		[RED("brandingPreview")] 
		public inkWidgetReference BrandingPreview
		{
			get => GetProperty(ref _brandingPreview);
			set => SetProperty(ref _brandingPreview, value);
		}

		[Ordinal(20)] 
		[RED("backRestPreview")] 
		public inkWidgetReference BackRestPreview
		{
			get => GetProperty(ref _backRestPreview);
			set => SetProperty(ref _backRestPreview, value);
		}

		[Ordinal(21)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(22)] 
		[RED("orderButtonController")] 
		public wCHandle<YaibaButton> OrderButtonController
		{
			get => GetProperty(ref _orderButtonController);
			set => SetProperty(ref _orderButtonController, value);
		}

		[Ordinal(23)] 
		[RED("backButtonController")] 
		public wCHandle<YaibaButton> BackButtonController
		{
			get => GetProperty(ref _backButtonController);
			set => SetProperty(ref _backButtonController, value);
		}

		[Ordinal(24)] 
		[RED("wheelCoverCheckController")] 
		public wCHandle<CheckYaibaOption> WheelCoverCheckController
		{
			get => GetProperty(ref _wheelCoverCheckController);
			set => SetProperty(ref _wheelCoverCheckController, value);
		}

		[Ordinal(25)] 
		[RED("wheelRimsCheckController")] 
		public wCHandle<CheckYaibaOption> WheelRimsCheckController
		{
			get => GetProperty(ref _wheelRimsCheckController);
			set => SetProperty(ref _wheelRimsCheckController, value);
		}

		[Ordinal(26)] 
		[RED("brandingCheckController")] 
		public wCHandle<CheckYaibaOption> BrandingCheckController
		{
			get => GetProperty(ref _brandingCheckController);
			set => SetProperty(ref _brandingCheckController, value);
		}

		[Ordinal(27)] 
		[RED("backRestCheckController")] 
		public wCHandle<CheckYaibaOption> BackRestCheckController
		{
			get => GetProperty(ref _backRestCheckController);
			set => SetProperty(ref _backRestCheckController, value);
		}

		[Ordinal(28)] 
		[RED("wheelCoverFact")] 
		public CName WheelCoverFact
		{
			get => GetProperty(ref _wheelCoverFact);
			set => SetProperty(ref _wheelCoverFact, value);
		}

		[Ordinal(29)] 
		[RED("WheelRimsFact")] 
		public CName WheelRimsFact
		{
			get => GetProperty(ref _wheelRimsFact);
			set => SetProperty(ref _wheelRimsFact, value);
		}

		[Ordinal(30)] 
		[RED("BrandingFact")] 
		public CName BrandingFact
		{
			get => GetProperty(ref _brandingFact);
			set => SetProperty(ref _brandingFact, value);
		}

		[Ordinal(31)] 
		[RED("BackRestFact")] 
		public CName BackRestFact
		{
			get => GetProperty(ref _backRestFact);
			set => SetProperty(ref _backRestFact, value);
		}

		[Ordinal(32)] 
		[RED("isAnimated")] 
		public CBool IsAnimated
		{
			get => GetProperty(ref _isAnimated);
			set => SetProperty(ref _isAnimated, value);
		}

		[Ordinal(33)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		public ComputerYaibaShowroomController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
