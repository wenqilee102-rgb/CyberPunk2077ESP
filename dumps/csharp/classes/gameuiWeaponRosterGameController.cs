using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiWeaponRosterGameController : gameuiHUDGameController
	{
		private inkTextWidgetReference _weaponName;
		private inkImageWidgetReference _weaponIcon;
		private inkTextWidgetReference _weaponCurrentAmmo;
		private inkTextWidgetReference _weaponTotalAmmo;
		private inkWidgetReference _weaponAmmoWrapper;
		private inkWidgetReference _onFootContainer;
		private inkWidgetReference _weaponizedVehicleContainer;
		private inkWidgetReference _weaponizedVehicleMissileLauncherContainer;
		private inkWidgetReference _weaponizedVehicleMachinegunContainer;
		private inkTextWidgetReference _machinegunAmmo;
		private inkWidgetReference _machinegunReloadingProgressBar;
		private inkWidgetReference _machinegunReloadingProgressBarFill;
		private inkTextWidgetReference _missileLauncherAmmo;
		private inkWidgetReference _missileLauncherReloadingProgressBar;
		private inkWidgetReference _missileLauncherReloadingProgressBarFill;
		private inkCompoundWidgetReference _smartLinkFirmwareOnline;
		private inkCompoundWidgetReference _smartLinkFirmwareOffline;
		private wCHandle<gameIBlackboard> _uiEquipmentDataBlackboard;
		private CHandle<redCallbackObject> _ammoHackedListenerId;
		private CHandle<redCallbackObject> _bBWeaponList;
		private CHandle<redCallbackObject> _bBAmmoLooted;
		private CHandle<redCallbackObject> _dataListenerId;
		private CHandle<redCallbackObject> _onMagazineAmmoCount;
		private CHandle<redCallbackObject> _remoteControlledVehicleDataCallback;
		private CHandle<redCallbackObject> _psmWeaponStateChangedCallback;
		private CHandle<redCallbackObject> _visionStateBlackboardId;
		private CHandle<redCallbackObject> _weaponParamsListenerId;
		private CHandle<redCallbackObject> _weaponizedVehicleMachineGunAmmoChangedCallback;
		private CHandle<redCallbackObject> _weaponizedVehicleMissileLauncherChargesChangedCallback;
		private CHandle<gamedataWeaponItem_Record> _weaponRecord;
		private gameSlotWeaponData _activeWeapon;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gameMuppet> _playerMuppet;
		private CHandle<inkanimProxy> _transitionAnimProxy;
		private CHandle<inkanimProxy> _outOfAmmoAnim;
		private CBool _folded;
		private CBool _isUnholstered;
		private CBool _inVehicle;
		private CBool _inWeaponizedVehicle;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private gameInventoryItemData _weaponItemData;
		private CFloat _weaponizedVehiclePowerWeaponReloadTime;
		private CFloat _weaponizedVehiclePowerWeaponReloadElapsedTime;
		private CUInt32 _weaponizedVehicleMissileLauncherMaxCharges;
		private CFloat _weaponizedVehicleMissileLauncherRechargeTime;
		private CFloat _weaponizedVehicleMissileLauncherRechargeElapsedTime;

		[Ordinal(9)] 
		[RED("weaponName")] 
		public inkTextWidgetReference WeaponName
		{
			get => GetProperty(ref _weaponName);
			set => SetProperty(ref _weaponName, value);
		}

		[Ordinal(10)] 
		[RED("weaponIcon")] 
		public inkImageWidgetReference WeaponIcon
		{
			get => GetProperty(ref _weaponIcon);
			set => SetProperty(ref _weaponIcon, value);
		}

		[Ordinal(11)] 
		[RED("weaponCurrentAmmo")] 
		public inkTextWidgetReference WeaponCurrentAmmo
		{
			get => GetProperty(ref _weaponCurrentAmmo);
			set => SetProperty(ref _weaponCurrentAmmo, value);
		}

		[Ordinal(12)] 
		[RED("weaponTotalAmmo")] 
		public inkTextWidgetReference WeaponTotalAmmo
		{
			get => GetProperty(ref _weaponTotalAmmo);
			set => SetProperty(ref _weaponTotalAmmo, value);
		}

		[Ordinal(13)] 
		[RED("weaponAmmoWrapper")] 
		public inkWidgetReference WeaponAmmoWrapper
		{
			get => GetProperty(ref _weaponAmmoWrapper);
			set => SetProperty(ref _weaponAmmoWrapper, value);
		}

		[Ordinal(14)] 
		[RED("onFootContainer")] 
		public inkWidgetReference OnFootContainer
		{
			get => GetProperty(ref _onFootContainer);
			set => SetProperty(ref _onFootContainer, value);
		}

		[Ordinal(15)] 
		[RED("weaponizedVehicleContainer")] 
		public inkWidgetReference WeaponizedVehicleContainer
		{
			get => GetProperty(ref _weaponizedVehicleContainer);
			set => SetProperty(ref _weaponizedVehicleContainer, value);
		}

		[Ordinal(16)] 
		[RED("weaponizedVehicleMissileLauncherContainer")] 
		public inkWidgetReference WeaponizedVehicleMissileLauncherContainer
		{
			get => GetProperty(ref _weaponizedVehicleMissileLauncherContainer);
			set => SetProperty(ref _weaponizedVehicleMissileLauncherContainer, value);
		}

		[Ordinal(17)] 
		[RED("weaponizedVehicleMachinegunContainer")] 
		public inkWidgetReference WeaponizedVehicleMachinegunContainer
		{
			get => GetProperty(ref _weaponizedVehicleMachinegunContainer);
			set => SetProperty(ref _weaponizedVehicleMachinegunContainer, value);
		}

		[Ordinal(18)] 
		[RED("machinegunAmmo")] 
		public inkTextWidgetReference MachinegunAmmo
		{
			get => GetProperty(ref _machinegunAmmo);
			set => SetProperty(ref _machinegunAmmo, value);
		}

		[Ordinal(19)] 
		[RED("machinegunReloadingProgressBar")] 
		public inkWidgetReference MachinegunReloadingProgressBar
		{
			get => GetProperty(ref _machinegunReloadingProgressBar);
			set => SetProperty(ref _machinegunReloadingProgressBar, value);
		}

		[Ordinal(20)] 
		[RED("machinegunReloadingProgressBarFill")] 
		public inkWidgetReference MachinegunReloadingProgressBarFill
		{
			get => GetProperty(ref _machinegunReloadingProgressBarFill);
			set => SetProperty(ref _machinegunReloadingProgressBarFill, value);
		}

		[Ordinal(21)] 
		[RED("missileLauncherAmmo")] 
		public inkTextWidgetReference MissileLauncherAmmo
		{
			get => GetProperty(ref _missileLauncherAmmo);
			set => SetProperty(ref _missileLauncherAmmo, value);
		}

		[Ordinal(22)] 
		[RED("missileLauncherReloadingProgressBar")] 
		public inkWidgetReference MissileLauncherReloadingProgressBar
		{
			get => GetProperty(ref _missileLauncherReloadingProgressBar);
			set => SetProperty(ref _missileLauncherReloadingProgressBar, value);
		}

		[Ordinal(23)] 
		[RED("missileLauncherReloadingProgressBarFill")] 
		public inkWidgetReference MissileLauncherReloadingProgressBarFill
		{
			get => GetProperty(ref _missileLauncherReloadingProgressBarFill);
			set => SetProperty(ref _missileLauncherReloadingProgressBarFill, value);
		}

		[Ordinal(24)] 
		[RED("smartLinkFirmwareOnline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOnline
		{
			get => GetProperty(ref _smartLinkFirmwareOnline);
			set => SetProperty(ref _smartLinkFirmwareOnline, value);
		}

		[Ordinal(25)] 
		[RED("smartLinkFirmwareOffline")] 
		public inkCompoundWidgetReference SmartLinkFirmwareOffline
		{
			get => GetProperty(ref _smartLinkFirmwareOffline);
			set => SetProperty(ref _smartLinkFirmwareOffline, value);
		}

		[Ordinal(26)] 
		[RED("uiEquipmentDataBlackboard")] 
		public wCHandle<gameIBlackboard> UiEquipmentDataBlackboard
		{
			get => GetProperty(ref _uiEquipmentDataBlackboard);
			set => SetProperty(ref _uiEquipmentDataBlackboard, value);
		}

		[Ordinal(27)] 
		[RED("ammoHackedListenerId")] 
		public CHandle<redCallbackObject> AmmoHackedListenerId
		{
			get => GetProperty(ref _ammoHackedListenerId);
			set => SetProperty(ref _ammoHackedListenerId, value);
		}

		[Ordinal(28)] 
		[RED("BBWeaponList")] 
		public CHandle<redCallbackObject> BBWeaponList
		{
			get => GetProperty(ref _bBWeaponList);
			set => SetProperty(ref _bBWeaponList, value);
		}

		[Ordinal(29)] 
		[RED("BBAmmoLooted")] 
		public CHandle<redCallbackObject> BBAmmoLooted
		{
			get => GetProperty(ref _bBAmmoLooted);
			set => SetProperty(ref _bBAmmoLooted, value);
		}

		[Ordinal(30)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetProperty(ref _dataListenerId);
			set => SetProperty(ref _dataListenerId, value);
		}

		[Ordinal(31)] 
		[RED("onMagazineAmmoCount")] 
		public CHandle<redCallbackObject> OnMagazineAmmoCount
		{
			get => GetProperty(ref _onMagazineAmmoCount);
			set => SetProperty(ref _onMagazineAmmoCount, value);
		}

		[Ordinal(32)] 
		[RED("remoteControlledVehicleDataCallback")] 
		public CHandle<redCallbackObject> RemoteControlledVehicleDataCallback
		{
			get => GetProperty(ref _remoteControlledVehicleDataCallback);
			set => SetProperty(ref _remoteControlledVehicleDataCallback, value);
		}

		[Ordinal(33)] 
		[RED("psmWeaponStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmWeaponStateChangedCallback
		{
			get => GetProperty(ref _psmWeaponStateChangedCallback);
			set => SetProperty(ref _psmWeaponStateChangedCallback, value);
		}

		[Ordinal(34)] 
		[RED("VisionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		[Ordinal(35)] 
		[RED("weaponParamsListenerId")] 
		public CHandle<redCallbackObject> WeaponParamsListenerId
		{
			get => GetProperty(ref _weaponParamsListenerId);
			set => SetProperty(ref _weaponParamsListenerId, value);
		}

		[Ordinal(36)] 
		[RED("weaponizedVehicleMachineGunAmmoChangedCallback")] 
		public CHandle<redCallbackObject> WeaponizedVehicleMachineGunAmmoChangedCallback
		{
			get => GetProperty(ref _weaponizedVehicleMachineGunAmmoChangedCallback);
			set => SetProperty(ref _weaponizedVehicleMachineGunAmmoChangedCallback, value);
		}

		[Ordinal(37)] 
		[RED("weaponizedVehicleMissileLauncherChargesChangedCallback")] 
		public CHandle<redCallbackObject> WeaponizedVehicleMissileLauncherChargesChangedCallback
		{
			get => GetProperty(ref _weaponizedVehicleMissileLauncherChargesChangedCallback);
			set => SetProperty(ref _weaponizedVehicleMissileLauncherChargesChangedCallback, value);
		}

		[Ordinal(38)] 
		[RED("weaponRecord")] 
		public CHandle<gamedataWeaponItem_Record> WeaponRecord
		{
			get => GetProperty(ref _weaponRecord);
			set => SetProperty(ref _weaponRecord, value);
		}

		[Ordinal(39)] 
		[RED("activeWeapon")] 
		public gameSlotWeaponData ActiveWeapon
		{
			get => GetProperty(ref _activeWeapon);
			set => SetProperty(ref _activeWeapon, value);
		}

		[Ordinal(40)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(41)] 
		[RED("PlayerMuppet")] 
		public wCHandle<gameMuppet> PlayerMuppet
		{
			get => GetProperty(ref _playerMuppet);
			set => SetProperty(ref _playerMuppet, value);
		}

		[Ordinal(42)] 
		[RED("transitionAnimProxy")] 
		public CHandle<inkanimProxy> TransitionAnimProxy
		{
			get => GetProperty(ref _transitionAnimProxy);
			set => SetProperty(ref _transitionAnimProxy, value);
		}

		[Ordinal(43)] 
		[RED("outOfAmmoAnim")] 
		public CHandle<inkanimProxy> OutOfAmmoAnim
		{
			get => GetProperty(ref _outOfAmmoAnim);
			set => SetProperty(ref _outOfAmmoAnim, value);
		}

		[Ordinal(44)] 
		[RED("folded")] 
		public CBool Folded
		{
			get => GetProperty(ref _folded);
			set => SetProperty(ref _folded, value);
		}

		[Ordinal(45)] 
		[RED("isUnholstered")] 
		public CBool IsUnholstered
		{
			get => GetProperty(ref _isUnholstered);
			set => SetProperty(ref _isUnholstered, value);
		}

		[Ordinal(46)] 
		[RED("inVehicle")] 
		public CBool InVehicle
		{
			get => GetProperty(ref _inVehicle);
			set => SetProperty(ref _inVehicle, value);
		}

		[Ordinal(47)] 
		[RED("inWeaponizedVehicle")] 
		public CBool InWeaponizedVehicle
		{
			get => GetProperty(ref _inWeaponizedVehicle);
			set => SetProperty(ref _inWeaponizedVehicle, value);
		}

		[Ordinal(48)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(49)] 
		[RED("weaponItemData")] 
		public gameInventoryItemData WeaponItemData
		{
			get => GetProperty(ref _weaponItemData);
			set => SetProperty(ref _weaponItemData, value);
		}

		[Ordinal(50)] 
		[RED("weaponizedVehiclePowerWeaponReloadTime")] 
		public CFloat WeaponizedVehiclePowerWeaponReloadTime
		{
			get => GetProperty(ref _weaponizedVehiclePowerWeaponReloadTime);
			set => SetProperty(ref _weaponizedVehiclePowerWeaponReloadTime, value);
		}

		[Ordinal(51)] 
		[RED("weaponizedVehiclePowerWeaponReloadElapsedTime")] 
		public CFloat WeaponizedVehiclePowerWeaponReloadElapsedTime
		{
			get => GetProperty(ref _weaponizedVehiclePowerWeaponReloadElapsedTime);
			set => SetProperty(ref _weaponizedVehiclePowerWeaponReloadElapsedTime, value);
		}

		[Ordinal(52)] 
		[RED("weaponizedVehicleMissileLauncherMaxCharges")] 
		public CUInt32 WeaponizedVehicleMissileLauncherMaxCharges
		{
			get => GetProperty(ref _weaponizedVehicleMissileLauncherMaxCharges);
			set => SetProperty(ref _weaponizedVehicleMissileLauncherMaxCharges, value);
		}

		[Ordinal(53)] 
		[RED("weaponizedVehicleMissileLauncherRechargeTime")] 
		public CFloat WeaponizedVehicleMissileLauncherRechargeTime
		{
			get => GetProperty(ref _weaponizedVehicleMissileLauncherRechargeTime);
			set => SetProperty(ref _weaponizedVehicleMissileLauncherRechargeTime, value);
		}

		[Ordinal(54)] 
		[RED("weaponizedVehicleMissileLauncherRechargeElapsedTime")] 
		public CFloat WeaponizedVehicleMissileLauncherRechargeElapsedTime
		{
			get => GetProperty(ref _weaponizedVehicleMissileLauncherRechargeElapsedTime);
			set => SetProperty(ref _weaponizedVehicleMissileLauncherRechargeElapsedTime, value);
		}

		public gameuiWeaponRosterGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
