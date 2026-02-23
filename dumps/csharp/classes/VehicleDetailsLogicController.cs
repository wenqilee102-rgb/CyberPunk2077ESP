using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleDetailsLogicController : inkWidgetLogicController
	{
		private inkWidgetReference _backButton;
		private inkWidgetReference _purchaseButton;
		private inkWidgetReference _ownedWidget;
		private inkWidgetReference _insufficientMoneyWidget;
		private inkImageWidgetReference _detailsImage;
		private inkTextWidgetReference _vehicleNameText;
		private inkTextWidgetReference _detailsText;
		private inkWidgetReference _scrollControllerWidget;
		private inkImageWidgetReference _gunImage;
		private inkImageWidgetReference _rocketImage;
		private inkImageWidgetReference _custoImage;
		private inkWidgetReference _priceWrapper;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _discountWrapper;
		private inkTextWidgetReference _discountText;
		private inkWidgetReference _originalPriceWrapper;
		private inkTextWidgetReference _originalPriceText;
		private inkWidgetReference _discountImageWrapper;
		private inkWidgetReference _howToUnlockWrapper;
		private inkTextWidgetReference _howToUnlockText;
		private wCHandle<gamedataVehicleOffer_Record> _offerRecord;
		private CInt32 _price;
		private CFloat _discount;

		[Ordinal(1)] 
		[RED("backButton")] 
		public inkWidgetReference BackButton
		{
			get => GetProperty(ref _backButton);
			set => SetProperty(ref _backButton, value);
		}

		[Ordinal(2)] 
		[RED("purchaseButton")] 
		public inkWidgetReference PurchaseButton
		{
			get => GetProperty(ref _purchaseButton);
			set => SetProperty(ref _purchaseButton, value);
		}

		[Ordinal(3)] 
		[RED("ownedWidget")] 
		public inkWidgetReference OwnedWidget
		{
			get => GetProperty(ref _ownedWidget);
			set => SetProperty(ref _ownedWidget, value);
		}

		[Ordinal(4)] 
		[RED("insufficientMoneyWidget")] 
		public inkWidgetReference InsufficientMoneyWidget
		{
			get => GetProperty(ref _insufficientMoneyWidget);
			set => SetProperty(ref _insufficientMoneyWidget, value);
		}

		[Ordinal(5)] 
		[RED("detailsImage")] 
		public inkImageWidgetReference DetailsImage
		{
			get => GetProperty(ref _detailsImage);
			set => SetProperty(ref _detailsImage, value);
		}

		[Ordinal(6)] 
		[RED("vehicleNameText")] 
		public inkTextWidgetReference VehicleNameText
		{
			get => GetProperty(ref _vehicleNameText);
			set => SetProperty(ref _vehicleNameText, value);
		}

		[Ordinal(7)] 
		[RED("detailsText")] 
		public inkTextWidgetReference DetailsText
		{
			get => GetProperty(ref _detailsText);
			set => SetProperty(ref _detailsText, value);
		}

		[Ordinal(8)] 
		[RED("scrollControllerWidget")] 
		public inkWidgetReference ScrollControllerWidget
		{
			get => GetProperty(ref _scrollControllerWidget);
			set => SetProperty(ref _scrollControllerWidget, value);
		}

		[Ordinal(9)] 
		[RED("gunImage")] 
		public inkImageWidgetReference GunImage
		{
			get => GetProperty(ref _gunImage);
			set => SetProperty(ref _gunImage, value);
		}

		[Ordinal(10)] 
		[RED("rocketImage")] 
		public inkImageWidgetReference RocketImage
		{
			get => GetProperty(ref _rocketImage);
			set => SetProperty(ref _rocketImage, value);
		}

		[Ordinal(11)] 
		[RED("custoImage")] 
		public inkImageWidgetReference CustoImage
		{
			get => GetProperty(ref _custoImage);
			set => SetProperty(ref _custoImage, value);
		}

		[Ordinal(12)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetProperty(ref _priceWrapper);
			set => SetProperty(ref _priceWrapper, value);
		}

		[Ordinal(13)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(14)] 
		[RED("discountWrapper")] 
		public inkWidgetReference DiscountWrapper
		{
			get => GetProperty(ref _discountWrapper);
			set => SetProperty(ref _discountWrapper, value);
		}

		[Ordinal(15)] 
		[RED("discountText")] 
		public inkTextWidgetReference DiscountText
		{
			get => GetProperty(ref _discountText);
			set => SetProperty(ref _discountText, value);
		}

		[Ordinal(16)] 
		[RED("originalPriceWrapper")] 
		public inkWidgetReference OriginalPriceWrapper
		{
			get => GetProperty(ref _originalPriceWrapper);
			set => SetProperty(ref _originalPriceWrapper, value);
		}

		[Ordinal(17)] 
		[RED("originalPriceText")] 
		public inkTextWidgetReference OriginalPriceText
		{
			get => GetProperty(ref _originalPriceText);
			set => SetProperty(ref _originalPriceText, value);
		}

		[Ordinal(18)] 
		[RED("discountImageWrapper")] 
		public inkWidgetReference DiscountImageWrapper
		{
			get => GetProperty(ref _discountImageWrapper);
			set => SetProperty(ref _discountImageWrapper, value);
		}

		[Ordinal(19)] 
		[RED("howToUnlockWrapper")] 
		public inkWidgetReference HowToUnlockWrapper
		{
			get => GetProperty(ref _howToUnlockWrapper);
			set => SetProperty(ref _howToUnlockWrapper, value);
		}

		[Ordinal(20)] 
		[RED("howToUnlockText")] 
		public inkTextWidgetReference HowToUnlockText
		{
			get => GetProperty(ref _howToUnlockText);
			set => SetProperty(ref _howToUnlockText, value);
		}

		[Ordinal(21)] 
		[RED("offerRecord")] 
		public wCHandle<gamedataVehicleOffer_Record> OfferRecord
		{
			get => GetProperty(ref _offerRecord);
			set => SetProperty(ref _offerRecord, value);
		}

		[Ordinal(22)] 
		[RED("price")] 
		public CInt32 Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(23)] 
		[RED("discount")] 
		public CFloat Discount
		{
			get => GetProperty(ref _discount);
			set => SetProperty(ref _discount, value);
		}

		public VehicleDetailsLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
