using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterEventManager : inkWidgetLogicController
	{
		private Vector2 _nextLevelThreshold;
		private CFloat _levelEndCheckDelay;
		private CFloat _eventFinishDelay;
		private CInt32 _eventId;
		private CArray<gameuiarcadeShooterEventData> _eventList;

		[Ordinal(1)] 
		[RED("nextLevelThreshold")] 
		public Vector2 NextLevelThreshold
		{
			get => GetProperty(ref _nextLevelThreshold);
			set => SetProperty(ref _nextLevelThreshold, value);
		}

		[Ordinal(2)] 
		[RED("levelEndCheckDelay")] 
		public CFloat LevelEndCheckDelay
		{
			get => GetProperty(ref _levelEndCheckDelay);
			set => SetProperty(ref _levelEndCheckDelay, value);
		}

		[Ordinal(3)] 
		[RED("eventFinishDelay")] 
		public CFloat EventFinishDelay
		{
			get => GetProperty(ref _eventFinishDelay);
			set => SetProperty(ref _eventFinishDelay, value);
		}

		[Ordinal(4)] 
		[RED("eventId")] 
		public CInt32 EventId
		{
			get => GetProperty(ref _eventId);
			set => SetProperty(ref _eventId, value);
		}

		[Ordinal(5)] 
		[RED("eventList")] 
		public CArray<gameuiarcadeShooterEventData> EventList
		{
			get => GetProperty(ref _eventList);
			set => SetProperty(ref _eventList, value);
		}

		public gameuiarcadeShooterEventManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
