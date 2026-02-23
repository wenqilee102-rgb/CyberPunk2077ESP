using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformMoveTo : redEvent
	{
		private CHandle<gameIMovingPlatformMovement> _movement;
		private CName _destinationName;
		private CInt32 _data;
		private CBool _isElevator;

		[Ordinal(0)] 
		[RED("movement")] 
		public CHandle<gameIMovingPlatformMovement> Movement
		{
			get => GetProperty(ref _movement);
			set => SetProperty(ref _movement, value);
		}

		[Ordinal(1)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetProperty(ref _destinationName);
			set => SetProperty(ref _destinationName, value);
		}

		[Ordinal(2)] 
		[RED("data")] 
		public CInt32 Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(3)] 
		[RED("isElevator")] 
		public CBool IsElevator
		{
			get => GetProperty(ref _isElevator);
			set => SetProperty(ref _isElevator, value);
		}

		public gameMovingPlatformMoveTo(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
