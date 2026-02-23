using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformSavedData : CVariable
	{
		private Vector4 _currentLocalPosition;
		private CHandle<gameIMovingPlatformMovement> _movement;
		private CName _destinationName;
		private CInt32 _destinationData;
		private CFloat _time;
		private CFloat _maxTime;
		private CUInt32 _mountedPlayerEntityID;
		private CBool _isPaused;

		[Ordinal(0)] 
		[RED("currentLocalPosition")] 
		public Vector4 CurrentLocalPosition
		{
			get => GetProperty(ref _currentLocalPosition);
			set => SetProperty(ref _currentLocalPosition, value);
		}

		[Ordinal(1)] 
		[RED("movement")] 
		public CHandle<gameIMovingPlatformMovement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}

		[Ordinal(2)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetProperty(ref _destinationName);
			set => SetProperty(ref _destinationName, value);
		}

		[Ordinal(3)] 
		[RED("destinationData")] 
		public CInt32 DestinationData
		{
			get => GetProperty(ref _destinationData);
			set => SetProperty(ref _destinationData, value);
		}

		[Ordinal(4)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetProperty(ref _time);
			set => SetProperty(ref _time, value);
		}

		[Ordinal(5)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetProperty(ref _maxTime);
			set => SetProperty(ref _maxTime, value);
		}

		[Ordinal(6)] 
		[RED("mountedPlayerEntityID")] 
		public CUInt32 MountedPlayerEntityID
		{
			get => GetProperty(ref _mountedPlayerEntityID);
			set => SetProperty(ref _mountedPlayerEntityID, value);
		}

		[Ordinal(7)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetProperty(ref _isPaused);
			set => SetProperty(ref _isPaused, value);
		}

		public gameMovingPlatformSavedData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
