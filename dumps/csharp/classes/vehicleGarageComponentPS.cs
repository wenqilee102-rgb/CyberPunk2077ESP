using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentPS : gameComponentPS
	{
		private CArray<vehicleGarageComponentVehicleData> _spawnedVehiclesData;
		private CArray<vehicleGarageComponentVehicleData> _unregisteredVehiclesData;
		private CArray<vehicleGarageVehicleID> _unlockedVehicles;
		private CArray<vehicleUnlockedVehicle> _unlockedVehicleArray;
		private CArray<vehicleGarageVehicleID> _uiFavoritedVehicles;
		private CStatic<vehicleGarageVehicleID> _activeVehicles;
		private vehicleGarageComponentVehicleData _mountedVehicleData;
		private CBool _mountedVehicleStolen;

		[Ordinal(0)] 
		[RED("spawnedVehiclesData")] 
		public CArray<vehicleGarageComponentVehicleData> SpawnedVehiclesData
		{
			get => GetProperty(ref _spawnedVehiclesData);
			set => SetProperty(ref _spawnedVehiclesData, value);
		}

		[Ordinal(1)] 
		[RED("unregisteredVehiclesData")] 
		public CArray<vehicleGarageComponentVehicleData> UnregisteredVehiclesData
		{
			get => GetProperty(ref _unregisteredVehiclesData);
			set => SetProperty(ref _unregisteredVehiclesData, value);
		}

		[Ordinal(2)] 
		[RED("unlockedVehicles")] 
		public CArray<vehicleGarageVehicleID> UnlockedVehicles
		{
			get => GetProperty(ref _unlockedVehicles);
			set => SetProperty(ref _unlockedVehicles, value);
		}

		[Ordinal(3)] 
		[RED("unlockedVehicleArray")] 
		public CArray<vehicleUnlockedVehicle> UnlockedVehicleArray
		{
			get => GetProperty(ref _unlockedVehicleArray);
			set => SetProperty(ref _unlockedVehicleArray, value);
		}

		[Ordinal(4)] 
		[RED("uiFavoritedVehicles")] 
		public CArray<vehicleGarageVehicleID> UiFavoritedVehicles
		{
			get => GetProperty(ref _uiFavoritedVehicles);
			set => SetProperty(ref _uiFavoritedVehicles, value);
		}

		[Ordinal(5)] 
		[RED("activeVehicles", 3)] 
		public CStatic<vehicleGarageVehicleID> ActiveVehicles
		{
			get => GetProperty(ref _activeVehicles);
			set => SetProperty(ref _activeVehicles, value);
		}

		[Ordinal(6)] 
		[RED("mountedVehicleData")] 
		public vehicleGarageComponentVehicleData MountedVehicleData
		{
			get => GetProperty(ref _mountedVehicleData);
			set => SetProperty(ref _mountedVehicleData, value);
		}

		[Ordinal(7)] 
		[RED("mountedVehicleStolen")] 
		public CBool MountedVehicleStolen
		{
			get => GetProperty(ref _mountedVehicleStolen);
			set => SetProperty(ref _mountedVehicleStolen, value);
		}

		public vehicleGarageComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
