using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleOfferLogicController : BaseButtonView
	{
		private inkImageWidgetReference _vehicleImage;
		private inkWidgetReference _border;
		private inkWidgetReference _ownedIndicator;
		private inkTextWidgetReference _nameText;
		private inkImageWidgetReference _gunImage;
		private inkImageWidgetReference _rocketImage;
		private inkImageWidgetReference _custoImage;
		private inkWidgetReference _priceTextWrapper;
		private inkTextWidgetReference _priceText;
		private inkWidgetReference _originalPriceTextWrapper;
		private inkTextWidgetReference _originalPriceText;
		private inkWidgetReference _discountedPriceTextWrapper;
		private inkTextWidgetReference _discountedPriceText;
		private inkWidgetReference _discountWrapper;
		private inkTextWidgetReference _discountText;
		private inkWidgetReference _discoutImage;
		private wCHandle<gamedataVehicleOffer_Record> _offerRecord;
		private CEnum<EVehicleOfferState> _state;
		private wCHandle<inkWidget> _styleWidget;
		private CFloat _discount;
		private CBool _discountApplicable;

		[Ordinal(5)] 
		[RED("vehicleImage")] 
		public inkImageWidgetReference VehicleImage
		{
			get => GetProperty(ref _vehicleImage);
			set => SetProperty(ref _vehicleImage, value);
		}

		[Ordinal(6)] 
		[RED("border")] 
		public inkWidgetReference Border
		{
			get => GetProperty(ref _border);
			set => SetProperty(ref _border, value);
		}

		[Ordinal(7)] 
		[RED("ownedIndicator")] 
		public inkWidgetReference OwnedIndicator
		{
			get => GetProperty(ref _ownedIndicator);
			set => SetProperty(ref _ownedIndicator, value);
		}

		[Ordinal(8)] 
		[RED("nameText")] 
		public inkTextWidgetReference NameText
		{
			get => GetProperty(ref _nameText);
			set => SetProperty(ref _nameText, value);
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
		[RED("priceTextWrapper")] 
		public inkWidgetReference PriceTextWrapper
		{
			get => GetProperty(ref _priceTextWrapper);
			set => SetProperty(ref _priceTextWrapper, value);
		}

		[Ordinal(13)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}

		[Ordinal(14)] 
		[RED("originalPriceTextWrapper")] 
		public inkWidgetReference OriginalPriceTextWrapper
		{
			get => GetProperty(ref _originalPriceTextWrapper);
			set => SetProperty(ref _originalPriceTextWrapper, value);
		}

		[Ordinal(15)] 
		[RED("originalPriceText")] 
		public inkTextWidgetReference OriginalPriceText
		{
			get => GetProperty(ref _originalPriceText);
			set => SetProperty(ref _originalPriceText, value);
		}

		[Ordinal(16)] 
		[RED("discountedPriceTextWrapper")] 
		public inkWidgetReference DiscountedPriceTextWrapper
		{
			get => GetProperty(ref _discountedPriceTextWrapper);
			set => SetProperty(ref _discountedPriceTextWrapper, value);
		}

		[Ordinal(17)] 
		[RED("discountedPriceText")] 
		public inkTextWidgetReference DiscountedPriceText
		{
			get => GetProperty(ref _discountedPriceText);
			set => SetProperty(ref _discountedPriceText, value);
		}

		[Ordinal(18)] 
		[RED("discountWrapper")] 
		public inkWidgetReference DiscountWrapper
		{
			get => GetProperty(ref _discountWrapper);
			set => SetProperty(ref _discountWrapper, value);
		}

		[Ordinal(19)] 
		[RED("discountText")] 
		public inkTextWidgetReference DiscountText
		{
			get => GetProperty(ref _discountText);
			set => SetProperty(ref _discountText, value);
		}

		[Ordinal(20)] 
		[RED("discoutImage")] 
		public inkWidgetReference DiscoutImage
		{
			get => GetProperty(ref _discoutImage);
			set => SetProperty(ref _discoutImage, value);
		}

		[Ordinal(21)] 
		[RED("offerRecord")] 
		public wCHandle<gamedataVehicleOffer_Record> OfferRecord
		{
			get => GetProperty(ref _offerRecord);
			set => SetProperty(ref _offerRecord, value);
		}

		[Ordinal(22)] 
		[RED("state")] 
		public CEnum<EVehicleOfferState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(23)] 
		[RED("styleWidget")] 
		public wCHandle<inkWidget> StyleWidget
		{
			get => GetProperty(ref _styleWidget);
			set => SetProperty(ref _styleWidget, value);
		}

		[Ordinal(24)] 
		[RED("discount")] 
		public CFloat Discount
		{
			get => GetProperty(ref _discount);
			set => SetProperty(ref _discount, value);
		}

		[Ordinal(25)] 
		[RED("discountApplicable")] 
		public CBool DiscountApplicable
		{
			get => GetProperty(ref _discountApplicable);
			set => SetProperty(ref _discountApplicable, value);
		}

		public VehicleOfferLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
