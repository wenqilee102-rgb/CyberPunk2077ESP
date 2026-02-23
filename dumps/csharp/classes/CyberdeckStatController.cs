using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckStatController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<CyberdeckTooltipSettingsListener> _settingsListener;
		private CName _groupPath;
		private inkWidgetReference _minWidth;
		private CBool _bigFontEnabled;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(3)] 
		[RED("settingsListener")] 
		public CHandle<CyberdeckTooltipSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(4)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(5)] 
		[RED("minWidth")] 
		public inkWidgetReference MinWidth
		{
			get => GetProperty(ref _minWidth);
			set => SetProperty(ref _minWidth, value);
		}

		[Ordinal(6)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		public CyberdeckStatController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
