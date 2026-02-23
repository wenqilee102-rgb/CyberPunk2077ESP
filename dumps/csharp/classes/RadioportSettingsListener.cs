using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioportSettingsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _player;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _settingsGroup;
		private CBool _syncToCarRadio;
		private CBool _cycleOnButtonPress;
		private CBool _saveStation;
		private CName _syncToCarRadioName;
		private CName _cycleOnButtonPressName;
		private CName _saveStationName;
		private CName _radioportSettingsPath;

		[Ordinal(0)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
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
		[RED("syncToCarRadio")] 
		public CBool SyncToCarRadio
		{
			get => GetProperty(ref _syncToCarRadio);
			set => SetProperty(ref _syncToCarRadio, value);
		}

		[Ordinal(4)] 
		[RED("cycleOnButtonPress")] 
		public CBool CycleOnButtonPress
		{
			get => GetProperty(ref _cycleOnButtonPress);
			set => SetProperty(ref _cycleOnButtonPress, value);
		}

		[Ordinal(5)] 
		[RED("saveStation")] 
		public CBool SaveStation
		{
			get => GetProperty(ref _saveStation);
			set => SetProperty(ref _saveStation, value);
		}

		[Ordinal(6)] 
		[RED("syncToCarRadioName")] 
		public CName SyncToCarRadioName
		{
			get => GetProperty(ref _syncToCarRadioName);
			set => SetProperty(ref _syncToCarRadioName, value);
		}

		[Ordinal(7)] 
		[RED("cycleOnButtonPressName")] 
		public CName CycleOnButtonPressName
		{
			get => GetProperty(ref _cycleOnButtonPressName);
			set => SetProperty(ref _cycleOnButtonPressName, value);
		}

		[Ordinal(8)] 
		[RED("saveStationName")] 
		public CName SaveStationName
		{
			get => GetProperty(ref _saveStationName);
			set => SetProperty(ref _saveStationName, value);
		}

		[Ordinal(9)] 
		[RED("radioportSettingsPath")] 
		public CName RadioportSettingsPath
		{
			get => GetProperty(ref _radioportSettingsPath);
			set => SetProperty(ref _radioportSettingsPath, value);
		}

		public RadioportSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
