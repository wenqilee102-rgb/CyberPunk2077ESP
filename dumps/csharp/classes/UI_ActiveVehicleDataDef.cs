using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ActiveVehicleDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Variant _vehPlayerStateData;
		private gamebbScriptID_Bool _isPlayerMounted;
		private gamebbScriptID_Bool _isTPPCameraOn;
		private gamebbScriptID_Int32 _positionInRace;
		private gamebbScriptID_Bool _isFPPRearviewCameraActivated;
		private gamebbScriptID_Variant _remoteControlledVehicleData;
		private gamebbScriptID_Variant _mountedWeaponsTargets;
		private gamebbScriptID_Uint32 _mountedMissileLauncherAmmo;
		private gamebbScriptID_Uint32 _mountedPowerWeaponAmmo;

		[Ordinal(0)] 
		[RED("VehPlayerStateData")] 
		public gamebbScriptID_Variant VehPlayerStateData
		{
			get => GetProperty(ref _vehPlayerStateData);
			set => SetProperty(ref _vehPlayerStateData, value);
		}

		[Ordinal(1)] 
		[RED("IsPlayerMounted")] 
		public gamebbScriptID_Bool IsPlayerMounted
		{
			get => GetProperty(ref _isPlayerMounted);
			set => SetProperty(ref _isPlayerMounted, value);
		}

		[Ordinal(2)] 
		[RED("IsTPPCameraOn")] 
		public gamebbScriptID_Bool IsTPPCameraOn
		{
			get => GetProperty(ref _isTPPCameraOn);
			set => SetProperty(ref _isTPPCameraOn, value);
		}

		[Ordinal(3)] 
		[RED("PositionInRace")] 
		public gamebbScriptID_Int32 PositionInRace
		{
			get => GetProperty(ref _positionInRace);
			set => SetProperty(ref _positionInRace, value);
		}

		[Ordinal(4)] 
		[RED("IsFPPRearviewCameraActivated")] 
		public gamebbScriptID_Bool IsFPPRearviewCameraActivated
		{
			get => GetProperty(ref _isFPPRearviewCameraActivated);
			set => SetProperty(ref _isFPPRearviewCameraActivated, value);
		}

		[Ordinal(5)] 
		[RED("RemoteControlledVehicleData")] 
		public gamebbScriptID_Variant RemoteControlledVehicleData
		{
			get => GetProperty(ref _remoteControlledVehicleData);
			set => SetProperty(ref _remoteControlledVehicleData, value);
		}

		[Ordinal(6)] 
		[RED("MountedWeaponsTargets")] 
		public gamebbScriptID_Variant MountedWeaponsTargets
		{
			get => GetProperty(ref _mountedWeaponsTargets);
			set => SetProperty(ref _mountedWeaponsTargets, value);
		}

		[Ordinal(7)] 
		[RED("MountedMissileLauncherAmmo")] 
		public gamebbScriptID_Uint32 MountedMissileLauncherAmmo
		{
			get => GetProperty(ref _mountedMissileLauncherAmmo);
			set => SetProperty(ref _mountedMissileLauncherAmmo, value);
		}

		[Ordinal(8)] 
		[RED("MountedPowerWeaponAmmo")] 
		public gamebbScriptID_Uint32 MountedPowerWeaponAmmo
		{
			get => GetProperty(ref _mountedPowerWeaponAmmo);
			set => SetProperty(ref _mountedPowerWeaponAmmo, value);
		}

		public UI_ActiveVehicleDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
