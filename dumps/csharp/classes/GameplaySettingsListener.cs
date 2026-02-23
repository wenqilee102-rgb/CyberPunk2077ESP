using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySettingsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<userSettingsUserSettings> _userSettings;
		private CHandle<userSettingsGroup> _diffSettingsGroup;
		private CHandle<userSettingsGroup> _miscSettingsGroup;
		private CHandle<userSettingsGroup> _controlsGroup;
		private CHandle<userSettingsGroup> _vehicleControlsGroup;
		private CHandle<userSettingsGroup> _hudGroup;
		private CFloat _additiveCameraMovements;
		private CBool _isFastForwardByLine;
		private CBool _inputHintsEnabled;
		private CBool _movementDodgeEnabled;
		private CBool _vehicleCombatHoldToShootEnabled;
		private CName _difficultyPath;
		private CName _miscPath;
		private CName _controlsPath;
		private CName _vehicleControlsPath;
		private CName _hudPath;
		private CName _additiveCameraOptionName;
		private CName _fastForwardOptionName;
		private CName _inputHintsOptionName;
		private CName _movementDodgeOptionName;
		private CName _vehicleCombatHoldToShootOptionName;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(1)] 
		[RED("userSettings")] 
		public CHandle<userSettingsUserSettings> UserSettings
		{
			get => GetProperty(ref _userSettings);
			set => SetProperty(ref _userSettings, value);
		}

		[Ordinal(2)] 
		[RED("diffSettingsGroup")] 
		public CHandle<userSettingsGroup> DiffSettingsGroup
		{
			get => GetProperty(ref _diffSettingsGroup);
			set => SetProperty(ref _diffSettingsGroup, value);
		}

		[Ordinal(3)] 
		[RED("miscSettingsGroup")] 
		public CHandle<userSettingsGroup> MiscSettingsGroup
		{
			get => GetProperty(ref _miscSettingsGroup);
			set => SetProperty(ref _miscSettingsGroup, value);
		}

		[Ordinal(4)] 
		[RED("controlsGroup")] 
		public CHandle<userSettingsGroup> ControlsGroup
		{
			get => GetProperty(ref _controlsGroup);
			set => SetProperty(ref _controlsGroup, value);
		}

		[Ordinal(5)] 
		[RED("vehicleControlsGroup")] 
		public CHandle<userSettingsGroup> VehicleControlsGroup
		{
			get => GetProperty(ref _vehicleControlsGroup);
			set => SetProperty(ref _vehicleControlsGroup, value);
		}

		[Ordinal(6)] 
		[RED("hudGroup")] 
		public CHandle<userSettingsGroup> HudGroup
		{
			get => GetProperty(ref _hudGroup);
			set => SetProperty(ref _hudGroup, value);
		}

		[Ordinal(7)] 
		[RED("additiveCameraMovements")] 
		public CFloat AdditiveCameraMovements
		{
			get => GetProperty(ref _additiveCameraMovements);
			set => SetProperty(ref _additiveCameraMovements, value);
		}

		[Ordinal(8)] 
		[RED("isFastForwardByLine")] 
		public CBool IsFastForwardByLine
		{
			get => GetProperty(ref _isFastForwardByLine);
			set => SetProperty(ref _isFastForwardByLine, value);
		}

		[Ordinal(9)] 
		[RED("InputHintsEnabled")] 
		public CBool InputHintsEnabled
		{
			get => GetProperty(ref _inputHintsEnabled);
			set => SetProperty(ref _inputHintsEnabled, value);
		}

		[Ordinal(10)] 
		[RED("movementDodgeEnabled")] 
		public CBool MovementDodgeEnabled
		{
			get => GetProperty(ref _movementDodgeEnabled);
			set => SetProperty(ref _movementDodgeEnabled, value);
		}

		[Ordinal(11)] 
		[RED("vehicleCombatHoldToShootEnabled")] 
		public CBool VehicleCombatHoldToShootEnabled
		{
			get => GetProperty(ref _vehicleCombatHoldToShootEnabled);
			set => SetProperty(ref _vehicleCombatHoldToShootEnabled, value);
		}

		[Ordinal(12)] 
		[RED("difficultyPath")] 
		public CName DifficultyPath
		{
			get => GetProperty(ref _difficultyPath);
			set => SetProperty(ref _difficultyPath, value);
		}

		[Ordinal(13)] 
		[RED("miscPath")] 
		public CName MiscPath
		{
			get => GetProperty(ref _miscPath);
			set => SetProperty(ref _miscPath, value);
		}

		[Ordinal(14)] 
		[RED("controlsPath")] 
		public CName ControlsPath
		{
			get => GetProperty(ref _controlsPath);
			set => SetProperty(ref _controlsPath, value);
		}

		[Ordinal(15)] 
		[RED("vehicleControlsPath")] 
		public CName VehicleControlsPath
		{
			get => GetProperty(ref _vehicleControlsPath);
			set => SetProperty(ref _vehicleControlsPath, value);
		}

		[Ordinal(16)] 
		[RED("hudPath")] 
		public CName HudPath
		{
			get => GetProperty(ref _hudPath);
			set => SetProperty(ref _hudPath, value);
		}

		[Ordinal(17)] 
		[RED("additiveCameraOptionName")] 
		public CName AdditiveCameraOptionName
		{
			get => GetProperty(ref _additiveCameraOptionName);
			set => SetProperty(ref _additiveCameraOptionName, value);
		}

		[Ordinal(18)] 
		[RED("fastForwardOptionName")] 
		public CName FastForwardOptionName
		{
			get => GetProperty(ref _fastForwardOptionName);
			set => SetProperty(ref _fastForwardOptionName, value);
		}

		[Ordinal(19)] 
		[RED("inputHintsOptionName")] 
		public CName InputHintsOptionName
		{
			get => GetProperty(ref _inputHintsOptionName);
			set => SetProperty(ref _inputHintsOptionName, value);
		}

		[Ordinal(20)] 
		[RED("movementDodgeOptionName")] 
		public CName MovementDodgeOptionName
		{
			get => GetProperty(ref _movementDodgeOptionName);
			set => SetProperty(ref _movementDodgeOptionName, value);
		}

		[Ordinal(21)] 
		[RED("vehicleCombatHoldToShootOptionName")] 
		public CName VehicleCombatHoldToShootOptionName
		{
			get => GetProperty(ref _vehicleCombatHoldToShootOptionName);
			set => SetProperty(ref _vehicleCombatHoldToShootOptionName, value);
		}

		public GameplaySettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
