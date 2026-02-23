using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlatformControllerPS : ScriptableDeviceComponentPS
	{
		private CArray<NodeRef> _floors;
		private CInt32 _startingFloor;
		private CFloat _speed;
		private CName _curve;
		private CString _errorMSG;
		private CInt32 _nextFloor;
		private CInt32 _prevFloor;
		private CInt32 _destinationFloor;
		private CInt32 _currentFloor;
		private CBool _isPlayerOnPlatform;
		private CBool _isMoving;
		private CBool _paused;
		private CFloat _pausingTime;

		[Ordinal(107)] 
		[RED("floors")] 
		public CArray<NodeRef> Floors
		{
			get => GetProperty(ref _floors);
			set => SetProperty(ref _floors, value);
		}

		[Ordinal(108)] 
		[RED("startingFloor")] 
		public CInt32 StartingFloor
		{
			get => GetProperty(ref _startingFloor);
			set => SetProperty(ref _startingFloor, value);
		}

		[Ordinal(109)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetProperty(ref _speed);
			set => SetProperty(ref _speed, value);
		}

		[Ordinal(110)] 
		[RED("curve")] 
		public CName Curve
		{
			get => GetProperty(ref _curve);
			set => SetProperty(ref _curve, value);
		}

		[Ordinal(111)] 
		[RED("errorMSG")] 
		public CString ErrorMSG
		{
			get => GetProperty(ref _errorMSG);
			set => SetProperty(ref _errorMSG, value);
		}

		[Ordinal(112)] 
		[RED("nextFloor")] 
		public CInt32 NextFloor
		{
			get => GetProperty(ref _nextFloor);
			set => SetProperty(ref _nextFloor, value);
		}

		[Ordinal(113)] 
		[RED("prevFloor")] 
		public CInt32 PrevFloor
		{
			get => GetProperty(ref _prevFloor);
			set => SetProperty(ref _prevFloor, value);
		}

		[Ordinal(114)] 
		[RED("destinationFloor")] 
		public CInt32 DestinationFloor
		{
			get => GetProperty(ref _destinationFloor);
			set => SetProperty(ref _destinationFloor, value);
		}

		[Ordinal(115)] 
		[RED("currentFloor")] 
		public CInt32 CurrentFloor
		{
			get => GetProperty(ref _currentFloor);
			set => SetProperty(ref _currentFloor, value);
		}

		[Ordinal(116)] 
		[RED("isPlayerOnPlatform")] 
		public CBool IsPlayerOnPlatform
		{
			get => GetProperty(ref _isPlayerOnPlatform);
			set => SetProperty(ref _isPlayerOnPlatform, value);
		}

		[Ordinal(117)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetProperty(ref _isMoving);
			set => SetProperty(ref _isMoving, value);
		}

		[Ordinal(118)] 
		[RED("paused")] 
		public CBool Paused
		{
			get => GetProperty(ref _paused);
			set => SetProperty(ref _paused, value);
		}

		[Ordinal(119)] 
		[RED("pausingTime")] 
		public CFloat PausingTime
		{
			get => GetProperty(ref _pausingTime);
			set => SetProperty(ref _pausingTime, value);
		}

		public PlatformControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
