using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PreventionSystemHackerLoop : gameScriptableSystem
	{
		private wCHandle<vehicleBaseObject> _firstVehicle;
		private CEnum<EPreventionHackLoopState> _state;
		private CBool _shouldHackLoopBeEnabledOnThisStar;
		private CBool _showingHackingPopUp;
		private wCHandle<vehicleBaseObject> _currentVehicle;
		private wCHandle<vehicleBaseObject> _previousVehicle;
		private gameDelayID _curentHackDelayId;
		private gameDelayID _futureDelayedUpdateDelayId;
		private CArray<CHandle<VehiclePreventionHackState>> _hackedVehicles;
		private wCHandle<UploadFromNPCToPlayerListener> _otherProgressBar;
		private CBool _waitingForUpdate;

		[Ordinal(0)] 
		[RED("firstVehicle")] 
		public wCHandle<vehicleBaseObject> FirstVehicle
		{
			get => GetProperty(ref _firstVehicle);
			set => SetProperty(ref _firstVehicle, value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EPreventionHackLoopState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(2)] 
		[RED("shouldHackLoopBeEnabledOnThisStar")] 
		public CBool ShouldHackLoopBeEnabledOnThisStar
		{
			get => GetProperty(ref _shouldHackLoopBeEnabledOnThisStar);
			set => SetProperty(ref _shouldHackLoopBeEnabledOnThisStar, value);
		}

		[Ordinal(3)] 
		[RED("showingHackingPopUp")] 
		public CBool ShowingHackingPopUp
		{
			get => GetProperty(ref _showingHackingPopUp);
			set => SetProperty(ref _showingHackingPopUp, value);
		}

		[Ordinal(4)] 
		[RED("currentVehicle")] 
		public wCHandle<vehicleBaseObject> CurrentVehicle
		{
			get => GetProperty(ref _currentVehicle);
			set => SetProperty(ref _currentVehicle, value);
		}

		[Ordinal(5)] 
		[RED("previousVehicle")] 
		public wCHandle<vehicleBaseObject> PreviousVehicle
		{
			get => GetProperty(ref _previousVehicle);
			set => SetProperty(ref _previousVehicle, value);
		}

		[Ordinal(6)] 
		[RED("curentHackDelayId")] 
		public gameDelayID CurentHackDelayId
		{
			get => GetProperty(ref _curentHackDelayId);
			set => SetProperty(ref _curentHackDelayId, value);
		}

		[Ordinal(7)] 
		[RED("futureDelayedUpdateDelayId")] 
		public gameDelayID FutureDelayedUpdateDelayId
		{
			get => GetProperty(ref _futureDelayedUpdateDelayId);
			set => SetProperty(ref _futureDelayedUpdateDelayId, value);
		}

		[Ordinal(8)] 
		[RED("hackedVehicles")] 
		public CArray<CHandle<VehiclePreventionHackState>> HackedVehicles
		{
			get => GetProperty(ref _hackedVehicles);
			set => SetProperty(ref _hackedVehicles, value);
		}

		[Ordinal(9)] 
		[RED("otherProgressBar")] 
		public wCHandle<UploadFromNPCToPlayerListener> OtherProgressBar
		{
			get => GetProperty(ref _otherProgressBar);
			set => SetProperty(ref _otherProgressBar, value);
		}

		[Ordinal(10)] 
		[RED("waitingForUpdate")] 
		public CBool WaitingForUpdate
		{
			get => GetProperty(ref _waitingForUpdate);
			set => SetProperty(ref _waitingForUpdate, value);
		}

		public PreventionSystemHackerLoop(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
