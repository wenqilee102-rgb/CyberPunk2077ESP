using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipAttachmentEntryController : inkWidgetLogicController
	{
		private inkTextWidgetReference _text;
		private inkWidgetReference _attunementContainer;
		private inkTextWidgetReference _attunementText;
		private inkImageWidgetReference _attunementIcon;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<NewItemTooltipAttachmentEntrySettingsListener> _settingsListener;
		private CName _groupPath;
		private CBool _bigFontEnabled;
		private CBool _isCrafting;

		[Ordinal(1)] 
		[RED("text")] 
		public inkTextWidgetReference Text
		{
			get => GetProperty(ref _text);
			set => SetProperty(ref _text, value);
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
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(6)] 
		[RED("settingsListener")] 
		public CHandle<NewItemTooltipAttachmentEntrySettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(7)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(8)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(9)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public NewItemTooltipAttachmentEntryController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
