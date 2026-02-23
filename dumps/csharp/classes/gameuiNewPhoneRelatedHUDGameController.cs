using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiNewPhoneRelatedHUDGameController : gameuiHUDGameController
	{
		private CBool _isNewPhoneEnabled;
		private wCHandle<PlayerPuppet> _player;
		private CBool _isRemoteControllingVehicle;
		private CUInt32 _visibilityFact1ListenerId;
		private CUInt32 _visibilityFact2ListenerId;
		private CHandle<redCallbackObject> _remoteControlledVehicleDataCallback;

		[Ordinal(9)] 
		[RED("isNewPhoneEnabled")] 
		public CBool IsNewPhoneEnabled
		{
			get => GetProperty(ref _isNewPhoneEnabled);
			set => SetProperty(ref _isNewPhoneEnabled, value);
		}

		[Ordinal(10)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(11)] 
		[RED("isRemoteControllingVehicle")] 
		public CBool IsRemoteControllingVehicle
		{
			get => GetProperty(ref _isRemoteControllingVehicle);
			set => SetProperty(ref _isRemoteControllingVehicle, value);
		}

		[Ordinal(12)] 
		[RED("visibilityFact1ListenerId")] 
		public CUInt32 VisibilityFact1ListenerId
		{
			get => GetProperty(ref _visibilityFact1ListenerId);
			set => SetProperty(ref _visibilityFact1ListenerId, value);
		}

		[Ordinal(13)] 
		[RED("visibilityFact2ListenerId")] 
		public CUInt32 VisibilityFact2ListenerId
		{
			get => GetProperty(ref _visibilityFact2ListenerId);
			set => SetProperty(ref _visibilityFact2ListenerId, value);
		}

		[Ordinal(14)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetProperty(ref _remoteControlledVehicleDataCallback);
			set => SetProperty(ref _remoteControlledVehicleDataCallback, value);
		}

		public gameuiNewPhoneRelatedHUDGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
