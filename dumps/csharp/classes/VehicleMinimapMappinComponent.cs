using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleMinimapMappinComponent : IScriptable
	{
		private wCHandle<MinimapPOIMappinController> _minimapPOIMappinController;
		private wCHandle<vehicleBaseObject> _vehicle;
		private wCHandle<gameIBlackboard> _uiVehicleBB;
		private CHandle<VehicleDef> _vehicleBBDef;
		private CHandle<redCallbackObject> _deleteAnimCallback;
		private CBool _destroyMappinOnAnimEnd;
		private CBool _vehicleIsLatestSummoned;
		private entEntityID _vehicleEntityID;
		private CHandle<VehicleSummonDataDef> _vehicleSummonDataDef;
		private wCHandle<gameIBlackboard> _vehicleSummonDataBB;
		private CHandle<redCallbackObject> _vehicleSummonStateCallback;

		[Ordinal(0)] 
		[RED("minimapPOIMappinController")] 
		public wCHandle<MinimapPOIMappinController> MinimapPOIMappinController
		{
			get => GetProperty(ref _minimapPOIMappinController);
			set => SetProperty(ref _minimapPOIMappinController, value);
		}

		[Ordinal(1)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(2)] 
		[RED("uiVehicleBB")] 
		public wCHandle<gameIBlackboard> UiVehicleBB
		{
			get => GetProperty(ref _uiVehicleBB);
			set => SetProperty(ref _uiVehicleBB, value);
		}

		[Ordinal(3)] 
		[RED("vehicleBBDef")] 
		public CHandle<VehicleDef> VehicleBBDef
		{
			get => GetProperty(ref _vehicleBBDef);
			set => SetProperty(ref _vehicleBBDef, value);
		}

		[Ordinal(4)] 
		[RED("deleteAnimCallback")] 
		public CHandle<redCallbackObject> DeleteAnimCallback
		{
			get => GetProperty(ref _deleteAnimCallback);
			set => SetProperty(ref _deleteAnimCallback, value);
		}

		[Ordinal(5)] 
		[RED("destroyMappinOnAnimEnd")] 
		public CBool DestroyMappinOnAnimEnd
		{
			get => GetProperty(ref _destroyMappinOnAnimEnd);
			set => SetProperty(ref _destroyMappinOnAnimEnd, value);
		}

		[Ordinal(6)] 
		[RED("vehicleIsLatestSummoned")] 
		public CBool VehicleIsLatestSummoned
		{
			get => GetProperty(ref _vehicleIsLatestSummoned);
			set => SetProperty(ref _vehicleIsLatestSummoned, value);
		}

		[Ordinal(7)] 
		[RED("vehicleEntityID")] 
		public entEntityID VehicleEntityID
		{
			get => GetProperty(ref _vehicleEntityID);
			set => SetProperty(ref _vehicleEntityID, value);
		}

		[Ordinal(8)] 
		[RED("vehicleSummonDataDef")] 
		public CHandle<VehicleSummonDataDef> VehicleSummonDataDef
		{
			get => GetProperty(ref _vehicleSummonDataDef);
			set => SetProperty(ref _vehicleSummonDataDef, value);
		}

		[Ordinal(9)] 
		[RED("vehicleSummonDataBB")] 
		public wCHandle<gameIBlackboard> VehicleSummonDataBB
		{
			get => GetProperty(ref _vehicleSummonDataBB);
			set => SetProperty(ref _vehicleSummonDataBB, value);
		}

		[Ordinal(10)] 
		[RED("vehicleSummonStateCallback")] 
		public CHandle<redCallbackObject> VehicleSummonStateCallback
		{
			get => GetProperty(ref _vehicleSummonStateCallback);
			set => SetProperty(ref _vehicleSummonStateCallback, value);
		}

		public VehicleMinimapMappinComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
