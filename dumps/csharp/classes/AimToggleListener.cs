using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimToggleListener : userSettingsVarListener
	{
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _settingsGroup;
		private CBool _toggleAim;
		private CBool _isADS;
		private CName _accessibilityControlsPath;

		[Ordinal(0)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(1)] 
		[RED("settingsGroup")] 
		public CHandle<userSettingsGroup> SettingsGroup
		{
			get => GetProperty(ref _settingsGroup);
			set => SetProperty(ref _settingsGroup, value);
		}

		[Ordinal(2)] 
		[RED("toggleAim")] 
		public CBool ToggleAim
		{
			get => GetProperty(ref _toggleAim);
			set => SetProperty(ref _toggleAim, value);
		}

		[Ordinal(3)] 
		[RED("isADS")] 
		public CBool IsADS
		{
			get => GetProperty(ref _isADS);
			set => SetProperty(ref _isADS, value);
		}

		[Ordinal(4)] 
		[RED("accessibilityControlsPath")] 
		public CName AccessibilityControlsPath
		{
			get => GetProperty(ref _accessibilityControlsPath);
			set => SetProperty(ref _accessibilityControlsPath, value);
		}

		public AimToggleListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
