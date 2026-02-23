using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleRemoteControlEvent : gameActionEvent
	{
		private CBool _remoteControl;
		private CBool _shouldUnseatPassengers;
		private CBool _shouldModifyInteractionState;
		private CBool _isDistanceDisconnect;

		[Ordinal(4)] 
		[RED("remoteControl")] 
		public CBool RemoteControl
		{
			get => GetProperty(ref _remoteControl);
			set => SetProperty(ref _remoteControl, value);
		}

		[Ordinal(5)] 
		[RED("shouldUnseatPassengers")] 
		public CBool ShouldUnseatPassengers
		{
			get => GetProperty(ref _shouldUnseatPassengers);
			set => SetProperty(ref _shouldUnseatPassengers, value);
		}

		[Ordinal(6)] 
		[RED("shouldModifyInteractionState")] 
		public CBool ShouldModifyInteractionState
		{
			get => GetProperty(ref _shouldModifyInteractionState);
			set => SetProperty(ref _shouldModifyInteractionState, value);
		}

		[Ordinal(7)] 
		[RED("isDistanceDisconnect")] 
		public CBool IsDistanceDisconnect
		{
			get => GetProperty(ref _isDistanceDisconnect);
			set => SetProperty(ref _isDistanceDisconnect, value);
		}

		public vehicleRemoteControlEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
