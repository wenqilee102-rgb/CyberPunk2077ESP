using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NcartStationMarker : gameObject
	{
		private CEnum<ENcartStations> _station;
		private CBool _callBackOnlyIfMatchesDestination;
		private CBool _setAsNewActive;
		private CName _onTrainApproachingFact;
		private CName _trainGlobalRef;

		[Ordinal(36)] 
		[RED("station")] 
		public CEnum<ENcartStations> Station
		{
			get => GetProperty(ref _station);
			set => SetProperty(ref _station, value);
		}

		[Ordinal(37)] 
		[RED("callBackOnlyIfMatchesDestination")] 
		public CBool CallBackOnlyIfMatchesDestination
		{
			get => GetProperty(ref _callBackOnlyIfMatchesDestination);
			set => SetProperty(ref _callBackOnlyIfMatchesDestination, value);
		}

		[Ordinal(38)] 
		[RED("setAsNewActive")] 
		public CBool SetAsNewActive
		{
			get => GetProperty(ref _setAsNewActive);
			set => SetProperty(ref _setAsNewActive, value);
		}

		[Ordinal(39)] 
		[RED("onTrainApproachingFact")] 
		public CName OnTrainApproachingFact
		{
			get => GetProperty(ref _onTrainApproachingFact);
			set => SetProperty(ref _onTrainApproachingFact, value);
		}

		[Ordinal(40)] 
		[RED("TrainGlobalRef")] 
		public CName TrainGlobalRef
		{
			get => GetProperty(ref _trainGlobalRef);
			set => SetProperty(ref _trainGlobalRef, value);
		}

		public NcartStationMarker(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
