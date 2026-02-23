using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleShopPurchaseEvent : redEvent
	{
		private wCHandle<gamedataVehicleOffer_Record> _offerRecord;

		[Ordinal(0)] 
		[RED("offerRecord")] 
		public wCHandle<gamedataVehicleOffer_Record> OfferRecord
		{
			get => GetProperty(ref _offerRecord);
			set => SetProperty(ref _offerRecord, value);
		}

		public VehicleShopPurchaseEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
