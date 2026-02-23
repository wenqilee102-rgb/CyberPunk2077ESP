using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleRemoteControlDrivingUIData : CVariable
	{
		private wCHandle<vehicleBaseObject> _remoteControlledVehicle;
		private CBool _isDistanceDisconnect;

		[Ordinal(0)] 
		[RED("remoteControlledVehicle")] 
		public wCHandle<vehicleBaseObject> RemoteControlledVehicle
		{
			get => GetProperty(ref _remoteControlledVehicle);
			set => SetProperty(ref _remoteControlledVehicle, value);
		}

		[Ordinal(1)] 
		[RED("isDistanceDisconnect")] 
		public CBool IsDistanceDisconnect
		{
			get => GetProperty(ref _isDistanceDisconnect);
			set => SetProperty(ref _isDistanceDisconnect, value);
		}

		public vehicleRemoteControlDrivingUIData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
