using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePreventionSystemDebugData : CVariable
	{
		private CFloat _totalCrimeScore;
		private CInt32 _heatStage;
		private CFloat _heatThreshold;
		private CFloat _heatMultiplierDistrict;
		private CFloat _heatMultiplierQuest;
		private CInt32 _totalVehiclesCount;
		private CInt32 _totalAVsCount;
		private CInt32 _totalBlockadesCount;
		private CInt32 _totalNPCCount;
		private CInt32 _currentVehicleTicketCount;
		private CInt32 _maxVehicleTicketCount;
		private CInt32 _maxTacNPCCount;
		private CInt32 _engagedVehiclesCount;
		private CInt32 _engagedVehiclesLimit;
		private CInt32 _supportVehiclesCount;
		private CInt32 _supportVehiclesLimit;
		private CFloat _maxAVPlayerDistance;
		private Vector3 _lastAVRequestedSpawnPosition;
		private CInt32 _totalNPCLimit;
		private CInt32 _externalNPCCount;
		private CInt32 _fallbackNPCCount;
		private CInt32 _registeredPendingTickets;
		private CUInt32 _awaitedAVSpawnPointsRequestID;
		private Vector4 _lastKnownPosition;
		private CString _heatChangeReason;
		private CBool _systemEnabled;
		private CArray<CString> _systemLockEventSources;

		[Ordinal(0)] 
		[RED("totalCrimeScore")] 
		public CFloat TotalCrimeScore
		{
			get => GetProperty(ref _totalCrimeScore);
			set => SetProperty(ref _totalCrimeScore, value);
		}

		[Ordinal(1)] 
		[RED("heatStage")] 
		public CInt32 HeatStage
		{
			get => GetProperty(ref _heatStage);
			set => SetProperty(ref _heatStage, value);
		}

		[Ordinal(2)] 
		[RED("heatThreshold")] 
		public CFloat HeatThreshold
		{
			get => GetProperty(ref _heatThreshold);
			set => SetProperty(ref _heatThreshold, value);
		}

		[Ordinal(3)] 
		[RED("heatMultiplierDistrict")] 
		public CFloat HeatMultiplierDistrict
		{
			get => GetProperty(ref _heatMultiplierDistrict);
			set => SetProperty(ref _heatMultiplierDistrict, value);
		}

		[Ordinal(4)] 
		[RED("heatMultiplierQuest")] 
		public CFloat HeatMultiplierQuest
		{
			get => GetProperty(ref _heatMultiplierQuest);
			set => SetProperty(ref _heatMultiplierQuest, value);
		}

		[Ordinal(5)] 
		[RED("totalVehiclesCount")] 
		public CInt32 TotalVehiclesCount
		{
			get => GetProperty(ref _totalVehiclesCount);
			set => SetProperty(ref _totalVehiclesCount, value);
		}

		[Ordinal(6)] 
		[RED("totalAVsCount")] 
		public CInt32 TotalAVsCount
		{
			get => GetProperty(ref _totalAVsCount);
			set => SetProperty(ref _totalAVsCount, value);
		}

		[Ordinal(7)] 
		[RED("totalBlockadesCount")] 
		public CInt32 TotalBlockadesCount
		{
			get => GetProperty(ref _totalBlockadesCount);
			set => SetProperty(ref _totalBlockadesCount, value);
		}

		[Ordinal(8)] 
		[RED("totalNPCCount")] 
		public CInt32 TotalNPCCount
		{
			get => GetProperty(ref _totalNPCCount);
			set => SetProperty(ref _totalNPCCount, value);
		}

		[Ordinal(9)] 
		[RED("currentVehicleTicketCount")] 
		public CInt32 CurrentVehicleTicketCount
		{
			get => GetProperty(ref _currentVehicleTicketCount);
			set => SetProperty(ref _currentVehicleTicketCount, value);
		}

		[Ordinal(10)] 
		[RED("maxVehicleTicketCount")] 
		public CInt32 MaxVehicleTicketCount
		{
			get => GetProperty(ref _maxVehicleTicketCount);
			set => SetProperty(ref _maxVehicleTicketCount, value);
		}

		[Ordinal(11)] 
		[RED("maxTacNPCCount")] 
		public CInt32 MaxTacNPCCount
		{
			get => GetProperty(ref _maxTacNPCCount);
			set => SetProperty(ref _maxTacNPCCount, value);
		}

		[Ordinal(12)] 
		[RED("engagedVehiclesCount")] 
		public CInt32 EngagedVehiclesCount
		{
			get => GetProperty(ref _engagedVehiclesCount);
			set => SetProperty(ref _engagedVehiclesCount, value);
		}

		[Ordinal(13)] 
		[RED("engagedVehiclesLimit")] 
		public CInt32 EngagedVehiclesLimit
		{
			get => GetProperty(ref _engagedVehiclesLimit);
			set => SetProperty(ref _engagedVehiclesLimit, value);
		}

		[Ordinal(14)] 
		[RED("supportVehiclesCount")] 
		public CInt32 SupportVehiclesCount
		{
			get => GetProperty(ref _supportVehiclesCount);
			set => SetProperty(ref _supportVehiclesCount, value);
		}

		[Ordinal(15)] 
		[RED("supportVehiclesLimit")] 
		public CInt32 SupportVehiclesLimit
		{
			get => GetProperty(ref _supportVehiclesLimit);
			set => SetProperty(ref _supportVehiclesLimit, value);
		}

		[Ordinal(16)] 
		[RED("maxAVPlayerDistance")] 
		public CFloat MaxAVPlayerDistance
		{
			get => GetProperty(ref _maxAVPlayerDistance);
			set => SetProperty(ref _maxAVPlayerDistance, value);
		}

		[Ordinal(17)] 
		[RED("lastAVRequestedSpawnPosition")] 
		public Vector3 LastAVRequestedSpawnPosition
		{
			get => GetProperty(ref _lastAVRequestedSpawnPosition);
			set => SetProperty(ref _lastAVRequestedSpawnPosition, value);
		}

		[Ordinal(18)] 
		[RED("totalNPCLimit")] 
		public CInt32 TotalNPCLimit
		{
			get => GetProperty(ref _totalNPCLimit);
			set => SetProperty(ref _totalNPCLimit, value);
		}

		[Ordinal(19)] 
		[RED("externalNPCCount")] 
		public CInt32 ExternalNPCCount
		{
			get => GetProperty(ref _externalNPCCount);
			set => SetProperty(ref _externalNPCCount, value);
		}

		[Ordinal(20)] 
		[RED("fallbackNPCCount")] 
		public CInt32 FallbackNPCCount
		{
			get => GetProperty(ref _fallbackNPCCount);
			set => SetProperty(ref _fallbackNPCCount, value);
		}

		[Ordinal(21)] 
		[RED("registeredPendingTickets")] 
		public CInt32 RegisteredPendingTickets
		{
			get => GetProperty(ref _registeredPendingTickets);
			set => SetProperty(ref _registeredPendingTickets, value);
		}

		[Ordinal(22)] 
		[RED("awaitedAVSpawnPointsRequestID")] 
		public CUInt32 AwaitedAVSpawnPointsRequestID
		{
			get => GetProperty(ref _awaitedAVSpawnPointsRequestID);
			set => SetProperty(ref _awaitedAVSpawnPointsRequestID, value);
		}

		[Ordinal(23)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetProperty(ref _lastKnownPosition);
			set => SetProperty(ref _lastKnownPosition, value);
		}

		[Ordinal(24)] 
		[RED("heatChangeReason")] 
		public CString HeatChangeReason
		{
			get => GetProperty(ref _heatChangeReason);
			set => SetProperty(ref _heatChangeReason, value);
		}

		[Ordinal(25)] 
		[RED("systemEnabled")] 
		public CBool SystemEnabled
		{
			get => GetProperty(ref _systemEnabled);
			set => SetProperty(ref _systemEnabled, value);
		}

		[Ordinal(26)] 
		[RED("systemLockEventSources")] 
		public CArray<CString> SystemLockEventSources
		{
			get => GetProperty(ref _systemLockEventSources);
			set => SetProperty(ref _systemLockEventSources, value);
		}

		public gamePreventionSystemDebugData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
