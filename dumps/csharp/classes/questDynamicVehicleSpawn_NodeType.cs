using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDynamicVehicleSpawn_NodeType : questIDynamicSpawnSystemType
	{
		private CArray<TweakDBID> _vehicleData;
		private CName _waveTag;
		private CEnum<questSpawnDirectionPreference> _spawnDirectionPreference;
		private Vector2 _distanceRange;

		[Ordinal(0)] 
		[RED("VehicleData")] 
		public CArray<TweakDBID> VehicleData
		{
			get => GetProperty(ref _vehicleData);
			set => SetProperty(ref _vehicleData, value);
		}

		[Ordinal(1)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetProperty(ref _waveTag);
			set => SetProperty(ref _waveTag, value);
		}

		[Ordinal(2)] 
		[RED("spawnDirectionPreference")] 
		public CEnum<questSpawnDirectionPreference> SpawnDirectionPreference
		{
			get => GetProperty(ref _spawnDirectionPreference);
			set => SetProperty(ref _spawnDirectionPreference, value);
		}

		[Ordinal(3)] 
		[RED("distanceRange")] 
		public Vector2 DistanceRange
		{
			get => GetProperty(ref _distanceRange);
			set => SetProperty(ref _distanceRange, value);
		}

		public questDynamicVehicleSpawn_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
