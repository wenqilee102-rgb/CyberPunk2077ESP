using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipModEntryController : inkWidgetLogicController
	{
		private inkTextWidgetReference _modName;
		private inkWidgetReference _attunementContainer;
		private inkTextWidgetReference _attunementText;
		private inkImageWidgetReference _attunementIcon;
		private inkWidgetReference _attunementLine;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<ItemTooltipModSettingsListener> _settingsListener;
		private CName _groupPath;
		private CBool _bigFontEnabled;
		private CBool _isCrafting;

		[Ordinal(1)] 
		[RED("modName")] 
		public inkTextWidgetReference ModName
		{
			get => GetProperty(ref _modName);
			set => SetProperty(ref _modName, value);
		}

		[Ordinal(2)] 
		[RED("attunementContainer")] 
		public inkWidgetReference AttunementContainer
		{
			get => GetProperty(ref _attunementContainer);
			set => SetProperty(ref _attunementContainer, value);
		}

		[Ordinal(3)] 
		[RED("attunementText")] 
		public inkTextWidgetReference AttunementText
		{
			get => GetProperty(ref _attunementText);
			set => SetProperty(ref _attunementText, value);
		}

		[Ordinal(4)] 
		[RED("attunementIcon")] 
		public inkImageWidgetReference AttunementIcon
		{
			get => GetProperty(ref _attunementIcon);
			set => SetProperty(ref _attunementIcon, value);
		}

		[Ordinal(5)] 
		[RED("attunementLine")] 
		public inkWidgetReference AttunementLine
		{
			get => GetProperty(ref _attunementLine);
			set => SetProperty(ref _attunementLine, value);
		}

		[Ordinal(6)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(7)] 
		[RED("settingsListener")] 
		public CHandle<ItemTooltipModSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(8)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(9)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(10)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public ItemTooltipModEntryController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
