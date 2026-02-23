using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehiclePlayerVehicle : CVariable
	{
		private CName _name;
		private TweakDBID _recordID;
		private CEnum<gamedataVehicleType> _vehicleType;
		private CBool _isUnlocked;
		private CInt32 _uiFavoriteIndex;
		private CBool _overrideDisplay;
		private CName _icon;
		private CName _defaultState;
		private CName _activeState;
		private CBool _forcedFavorite;
		private CBool _spawnOnlyOnValidRoad;
		private EngineTime _destructionTimeStamp;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public TweakDBID RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(2)] 
		[RED("vehicleType")] 
		public CEnum<gamedataVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(3)] 
		[RED("isUnlocked")] 
		public CBool IsUnlocked
		{
			get => GetProperty(ref _isUnlocked);
			set => SetProperty(ref _isUnlocked, value);
		}

		[Ordinal(4)] 
		[RED("uiFavoriteIndex")] 
		public CInt32 UiFavoriteIndex
		{
			get => GetProperty(ref _uiFavoriteIndex);
			set => SetProperty(ref _uiFavoriteIndex, value);
		}

		[Ordinal(5)] 
		[RED("overrideDisplay")] 
		public CBool OverrideDisplay
		{
			get => GetProperty(ref _overrideDisplay);
			set => SetProperty(ref _overrideDisplay, value);
		}

		[Ordinal(6)] 
		[RED("icon")] 
		public CName Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(7)] 
		[RED("defaultState")] 
		public CName DefaultState
		{
			get => GetProperty(ref _defaultState);
			set => SetProperty(ref _defaultState, value);
		}

		[Ordinal(8)] 
		[RED("activeState")] 
		public CName ActiveState
		{
			get => GetProperty(ref _activeState);
			set => SetProperty(ref _activeState, value);
		}

		[Ordinal(9)] 
		[RED("forcedFavorite")] 
		public CBool ForcedFavorite
		{
			get => GetProperty(ref _forcedFavorite);
			set => SetProperty(ref _forcedFavorite, value);
		}

		[Ordinal(10)] 
		[RED("spawnOnlyOnValidRoad")] 
		public CBool SpawnOnlyOnValidRoad
		{
			get => GetProperty(ref _spawnOnlyOnValidRoad);
			set => SetProperty(ref _spawnOnlyOnValidRoad, value);
		}

		[Ordinal(11)] 
		[RED("destructionTimeStamp")] 
		public EngineTime DestructionTimeStamp
		{
			get => GetProperty(ref _destructionTimeStamp);
			set => SetProperty(ref _destructionTimeStamp, value);
		}

		public vehiclePlayerVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
