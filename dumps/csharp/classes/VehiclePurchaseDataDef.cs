using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehiclePurchaseDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _purchasedVehicleRecordID;

		[Ordinal(0)] 
		[RED("PurchasedVehicleRecordID")] 
		public gamebbScriptID_Variant PurchasedVehicleRecordID
		{
			get => GetProperty(ref _purchasedVehicleRecordID);
			set => SetProperty(ref _purchasedVehicleRecordID, value);
		}

		public VehiclePurchaseDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
