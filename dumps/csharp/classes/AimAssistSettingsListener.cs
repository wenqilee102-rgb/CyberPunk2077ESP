using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimAssistSettingsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _ctrl;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _settingsGroup;
		private CEnum<EAimAssistLevel> _aimAssistLevel;
		private CEnum<EAimAssistLevel> _aimAssistMeleeLevel;
		private CBool _aimAssistDriverCombatEnabled;
		private CBool _aimAssistSnapEnabled;
		private CName _difficultySettingsPath;
		private CEnum<AimAssistSettingConfig> _currentConfig;
		private CArray<wCHandle<gamedataAimAssistSettings_Record>> _settingsRecords;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<PlayerPuppet> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		[Ordinal(1)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(2)] 
		[RED("settingsGroup")] 
		public CHandle<userSettingsGroup> SettingsGroup
		{
			get => GetProperty(ref _settingsGroup);
			set => SetProperty(ref _settingsGroup, value);
		}

		[Ordinal(3)] 
		[RED("aimAssistLevel")] 
		public CEnum<EAimAssistLevel> AimAssistLevel
		{
			get => GetProperty(ref _aimAssistLevel);
			set => SetProperty(ref _aimAssistLevel, value);
		}

		[Ordinal(4)] 
		[RED("aimAssistMeleeLevel")] 
		public CEnum<EAimAssistLevel> AimAssistMeleeLevel
		{
			get => GetProperty(ref _aimAssistMeleeLevel);
			set => SetProperty(ref _aimAssistMeleeLevel, value);
		}

		[Ordinal(5)] 
		[RED("aimAssistDriverCombatEnabled")] 
		public CBool AimAssistDriverCombatEnabled
		{
			get => GetProperty(ref _aimAssistDriverCombatEnabled);
			set => SetProperty(ref _aimAssistDriverCombatEnabled, value);
		}

		[Ordinal(6)] 
		[RED("aimAssistSnapEnabled")] 
		public CBool AimAssistSnapEnabled
		{
			get => GetProperty(ref _aimAssistSnapEnabled);
			set => SetProperty(ref _aimAssistSnapEnabled, value);
		}

		[Ordinal(7)] 
		[RED("difficultySettingsPath")] 
		public CName DifficultySettingsPath
		{
			get => GetProperty(ref _difficultySettingsPath);
			set => SetProperty(ref _difficultySettingsPath, value);
		}

		[Ordinal(8)] 
		[RED("currentConfig")] 
		public CEnum<AimAssistSettingConfig> CurrentConfig
		{
			get => GetProperty(ref _currentConfig);
			set => SetProperty(ref _currentConfig, value);
		}

		[Ordinal(9)] 
		[RED("settingsRecords")] 
		public CArray<wCHandle<gamedataAimAssistSettings_Record>> SettingsRecords
		{
			get => GetProperty(ref _settingsRecords);
			set => SetProperty(ref _settingsRecords, value);
		}

		public AimAssistSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
