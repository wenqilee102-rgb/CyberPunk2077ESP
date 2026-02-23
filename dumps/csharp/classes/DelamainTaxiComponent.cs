using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelamainTaxiComponent : gameScriptableComponent
	{
		private CName _taxiStateFact;
		private CName _taxiSeatFact;
		private ScriptGameInstance _gameInstance;
		private wCHandle<DelamainTaxiSystem> _delamainTaxiSystem;
		private wCHandle<AutoDriveSystem> _autoDriveSystem;
		private CEnum<DelamainTaxiState> _currentState;
		private CUInt32 _callbackID;
		private CHandle<redCallbackObject> _vehicleSpeedCallbackID;
		private CBool _isActiveCab;

		[Ordinal(5)] 
		[RED("taxiStateFact")] 
		public CName TaxiStateFact
		{
			get => GetProperty(ref _taxiStateFact);
			set => SetProperty(ref _taxiStateFact, value);
		}

		[Ordinal(6)] 
		[RED("taxiSeatFact")] 
		public CName TaxiSeatFact
		{
			get => GetProperty(ref _taxiSeatFact);
			set => SetProperty(ref _taxiSeatFact, value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(8)] 
		[RED("delamainTaxiSystem")] 
		public wCHandle<DelamainTaxiSystem> DelamainTaxiSystem
		{
			get => GetProperty(ref _delamainTaxiSystem);
			set => SetProperty(ref _delamainTaxiSystem, value);
		}

		[Ordinal(9)] 
		[RED("autoDriveSystem")] 
		public wCHandle<AutoDriveSystem> AutoDriveSystem
		{
			get => GetProperty(ref _autoDriveSystem);
			set => SetProperty(ref _autoDriveSystem, value);
		}

		[Ordinal(10)] 
		[RED("currentState")] 
		public CEnum<DelamainTaxiState> CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		[Ordinal(11)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetProperty(ref _callbackID);
			set => SetProperty(ref _callbackID, value);
		}

		[Ordinal(12)] 
		[RED("vehicleSpeedCallbackID")] 
		public CHandle<redCallbackObject> VehicleSpeedCallbackID
		{
			get => GetProperty(ref _vehicleSpeedCallbackID);
			set => SetProperty(ref _vehicleSpeedCallbackID, value);
		}

		[Ordinal(13)] 
		[RED("isActiveCab")] 
		public CBool IsActiveCab
		{
			get => GetProperty(ref _isActiveCab);
			set => SetProperty(ref _isActiveCab, value);
		}

		public DelamainTaxiComponent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
