using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_AutodriveDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Bool _autoDriveAvailable;
		private gamebbScriptID_Bool _autoDriveEnabled;
		private gamebbScriptID_Bool _autoDriveDelamain;
		private gamebbScriptID_Bool _freeRoamEnabled;
		private gamebbScriptID_Float _destinationRemainingLength;
		private gamebbScriptID_Float _destinationRemainingTime;
		private gamebbScriptID_Bool _cinematicCameraActive;

		[Ordinal(0)] 
		[RED("AutoDriveAvailable")] 
		public gamebbScriptID_Bool AutoDriveAvailable
		{
			get => GetProperty(ref _autoDriveAvailable);
			set => SetProperty(ref _autoDriveAvailable, value);
		}

		[Ordinal(1)] 
		[RED("AutoDriveEnabled")] 
		public gamebbScriptID_Bool AutoDriveEnabled
		{
			get => GetProperty(ref _autoDriveEnabled);
			set => SetProperty(ref _autoDriveEnabled, value);
		}

		[Ordinal(2)] 
		[RED("AutoDriveDelamain")] 
		public gamebbScriptID_Bool AutoDriveDelamain
		{
			get => GetProperty(ref _autoDriveDelamain);
			set => SetProperty(ref _autoDriveDelamain, value);
		}

		[Ordinal(3)] 
		[RED("FreeRoamEnabled")] 
		public gamebbScriptID_Bool FreeRoamEnabled
		{
			get => GetProperty(ref _freeRoamEnabled);
			set => SetProperty(ref _freeRoamEnabled, value);
		}

		[Ordinal(4)] 
		[RED("DestinationRemainingLength")] 
		public gamebbScriptID_Float DestinationRemainingLength
		{
			get => GetProperty(ref _destinationRemainingLength);
			set => SetProperty(ref _destinationRemainingLength, value);
		}

		[Ordinal(5)] 
		[RED("DestinationRemainingTime")] 
		public gamebbScriptID_Float DestinationRemainingTime
		{
			get => GetProperty(ref _destinationRemainingTime);
			set => SetProperty(ref _destinationRemainingTime, value);
		}

		[Ordinal(6)] 
		[RED("CinematicCameraActive")] 
		public gamebbScriptID_Bool CinematicCameraActive
		{
			get => GetProperty(ref _cinematicCameraActive);
			set => SetProperty(ref _cinematicCameraActive, value);
		}

		public UI_AutodriveDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
