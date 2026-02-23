using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleBrandFilterLogicController : BaseButtonView
	{
		private inkImageWidgetReference _brandLogo;
		private inkTextWidgetReference _brandText;
		private CName _brand;
		private CString _brandAsString;
		private CEnum<EVehicleBrandState> _state;
		private CBool _isHovered;
		private wCHandle<inkWidget> _styleWidget;
		private CArray<CName> _newOffers;

		[Ordinal(5)] 
		[RED("brandLogo")] 
		public inkImageWidgetReference BrandLogo
		{
			get => GetProperty(ref _brandLogo);
			set => SetProperty(ref _brandLogo, value);
		}

		[Ordinal(6)] 
		[RED("brandText")] 
		public inkTextWidgetReference BrandText
		{
			get => GetProperty(ref _brandText);
			set => SetProperty(ref _brandText, value);
		}

		[Ordinal(7)] 
		[RED("brand")] 
		public CName Brand
		{
			get => GetProperty(ref _brand);
			set => SetProperty(ref _brand, value);
		}

		[Ordinal(8)] 
		[RED("brandAsString")] 
		public CString BrandAsString
		{
			get => GetProperty(ref _brandAsString);
			set => SetProperty(ref _brandAsString, value);
		}

		[Ordinal(9)] 
		[RED("state")] 
		public CEnum<EVehicleBrandState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(10)] 
		[RED("isHovered")] 
		public CBool IsHovered
		{
			get => GetProperty(ref _isHovered);
			set => SetProperty(ref _isHovered, value);
		}

		[Ordinal(11)] 
		[RED("styleWidget")] 
		public wCHandle<inkWidget> StyleWidget
		{
			get => GetProperty(ref _styleWidget);
			set => SetProperty(ref _styleWidget, value);
		}

		[Ordinal(12)] 
		[RED("newOffers")] 
		public CArray<CName> NewOffers
		{
			get => GetProperty(ref _newOffers);
			set => SetProperty(ref _newOffers, value);
		}

		public VehicleBrandFilterLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
