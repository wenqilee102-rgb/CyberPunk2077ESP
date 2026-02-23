using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AutoDriveSystem : gameNativeAutodriveSystem
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<redCallbackObject> _playerVehicleStateCallbackHandle;
		private CHandle<redCallbackObject> _playerCombatStateCallbackHandle;
		private CHandle<redCallbackObject> _playerWeaponStateCallbackHandle;
		private CHandle<redCallbackObject> _playerMeleeWeaponStateCallbackHandle;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;
		private CHandle<AutodriveHealthChangeListener> _vehicleHealthListener;
		private CHandle<AutodriveQuestContentLockListener> _autodriveQuestContentLockListener;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("playerVehicleStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerVehicleStateCallbackHandle
		{
			get => GetProperty(ref _playerVehicleStateCallbackHandle);
			set => SetProperty(ref _playerVehicleStateCallbackHandle, value);
		}

		[Ordinal(2)] 
		[RED("playerCombatStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerCombatStateCallbackHandle
		{
			get => GetProperty(ref _playerCombatStateCallbackHandle);
			set => SetProperty(ref _playerCombatStateCallbackHandle, value);
		}

		[Ordinal(3)] 
		[RED("playerWeaponStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerWeaponStateCallbackHandle
		{
			get => GetProperty(ref _playerWeaponStateCallbackHandle);
			set => SetProperty(ref _playerWeaponStateCallbackHandle, value);
		}

		[Ordinal(4)] 
		[RED("playerMeleeWeaponStateCallbackHandle")] 
		public CHandle<redCallbackObject> PlayerMeleeWeaponStateCallbackHandle
		{
			get => GetProperty(ref _playerMeleeWeaponStateCallbackHandle);
			set => SetProperty(ref _playerMeleeWeaponStateCallbackHandle, value);
		}

		[Ordinal(5)] 
		[RED("playerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(6)] 
		[RED("playerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		[Ordinal(7)] 
		[RED("vehicleHealthListener")] 
		public CHandle<AutodriveHealthChangeListener> VehicleHealthListener
		{
			get => GetProperty(ref _vehicleHealthListener);
			set => SetProperty(ref _vehicleHealthListener, value);
		}

		[Ordinal(8)] 
		[RED("autodriveQuestContentLockListener")] 
		public CHandle<AutodriveQuestContentLockListener> AutodriveQuestContentLockListener
		{
			get => GetProperty(ref _autodriveQuestContentLockListener);
			set => SetProperty(ref _autodriveQuestContentLockListener, value);
		}

		public AutoDriveSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
