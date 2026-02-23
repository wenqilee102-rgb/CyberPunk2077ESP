using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessibilityControlsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _ctrl;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _settingsGroup;
		private CBool _allowCycleToFistCyberware;
		private CName _accessibilityControlsPath;

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
		[RED("allowCycleToFistCyberware")] 
		public CBool AllowCycleToFistCyberware
		{
			get => GetProperty(ref _allowCycleToFistCyberware);
			set => SetProperty(ref _allowCycleToFistCyberware, value);
		}

		[Ordinal(4)] 
		[RED("accessibilityControlsPath")] 
		public CName AccessibilityControlsPath
		{
			get => GetProperty(ref _accessibilityControlsPath);
			set => SetProperty(ref _accessibilityControlsPath, value);
		}

		public AccessibilityControlsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
