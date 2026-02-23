using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksCyberwareTooltipController : AGenericTooltipController
	{
		private inkTextWidgetReference _title;
		private inkTextWidgetReference _subTitle;
		private inkTextWidgetReference _description;
		private inkTextWidgetReference _subDescription;
		private inkVideoWidgetReference _videoWidget;
		private inkWidgetReference _cornerContainer;
		private inkWidgetReference _relicCost;
		private CArray<inkWidgetReference> _bars;
		private inkWidgetReference _inputHints;
		private inkWidgetReference _buyHint;
		private inkWidgetReference _sellHint;
		private CEnum<NewPerksCyberwareDetailsMenu> _currentEntry;
		private CHandle<inkanimProxy> _swipeOutAnim;
		private CHandle<inkanimProxy> _swipeInAnim;
		private CHandle<NewPerkTooltipData> _data;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<EspionageTooltipSettingsListener> _settingsListener;
		private CName _groupPath;
		private CBool _bigFontEnabled;
		private inkWidgetReference _wrapper;
		private CName _c_swipeLeftOut;
		private CName _c_swipeLeftIn;
		private CName _c_swipeRightOut;
		private CName _c_swipeRightIn;

		[Ordinal(2)] 
		[RED("title")] 
		public inkTextWidgetReference Title
		{
			get => GetProperty(ref _title);
			set => SetProperty(ref _title, value);
		}

		[Ordinal(3)] 
		[RED("subTitle")] 
		public inkTextWidgetReference SubTitle
		{
			get => GetProperty(ref _subTitle);
			set => SetProperty(ref _subTitle, value);
		}

		[Ordinal(4)] 
		[RED("description")] 
		public inkTextWidgetReference Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(5)] 
		[RED("subDescription")] 
		public inkTextWidgetReference SubDescription
		{
			get => GetProperty(ref _subDescription);
			set => SetProperty(ref _subDescription, value);
		}

		[Ordinal(6)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(7)] 
		[RED("cornerContainer")] 
		public inkWidgetReference CornerContainer
		{
			get => GetProperty(ref _cornerContainer);
			set => SetProperty(ref _cornerContainer, value);
		}

		[Ordinal(8)] 
		[RED("relicCost")] 
		public inkWidgetReference RelicCost
		{
			get => GetProperty(ref _relicCost);
			set => SetProperty(ref _relicCost, value);
		}

		[Ordinal(9)] 
		[RED("bars")] 
		public CArray<inkWidgetReference> Bars
		{
			get => GetProperty(ref _bars);
			set => SetProperty(ref _bars, value);
		}

		[Ordinal(10)] 
		[RED("inputHints")] 
		public inkWidgetReference InputHints
		{
			get => GetProperty(ref _inputHints);
			set => SetProperty(ref _inputHints, value);
		}

		[Ordinal(11)] 
		[RED("buyHint")] 
		public inkWidgetReference BuyHint
		{
			get => GetProperty(ref _buyHint);
			set => SetProperty(ref _buyHint, value);
		}

		[Ordinal(12)] 
		[RED("sellHint")] 
		public inkWidgetReference SellHint
		{
			get => GetProperty(ref _sellHint);
			set => SetProperty(ref _sellHint, value);
		}

		[Ordinal(13)] 
		[RED("currentEntry")] 
		public CEnum<NewPerksCyberwareDetailsMenu> CurrentEntry
		{
			get => GetProperty(ref _currentEntry);
			set => SetProperty(ref _currentEntry, value);
		}

		[Ordinal(14)] 
		[RED("swipeOutAnim")] 
		public CHandle<inkanimProxy> SwipeOutAnim
		{
			get => GetProperty(ref _swipeOutAnim);
			set => SetProperty(ref _swipeOutAnim, value);
		}

		[Ordinal(15)] 
		[RED("swipeInAnim")] 
		public CHandle<inkanimProxy> SwipeInAnim
		{
			get => GetProperty(ref _swipeInAnim);
			set => SetProperty(ref _swipeInAnim, value);
		}

		[Ordinal(16)] 
		[RED("data")] 
		public CHandle<NewPerkTooltipData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(17)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(18)] 
		[RED("settingsListener")] 
		public CHandle<EspionageTooltipSettingsListener> SettingsListener
		{
			get => GetProperty(ref _settingsListener);
			set => SetProperty(ref _settingsListener, value);
		}

		[Ordinal(19)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetProperty(ref _groupPath);
			set => SetProperty(ref _groupPath, value);
		}

		[Ordinal(20)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetProperty(ref _bigFontEnabled);
			set => SetProperty(ref _bigFontEnabled, value);
		}

		[Ordinal(21)] 
		[RED("wrapper")] 
		public inkWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(22)] 
		[RED("c_swipeLeftOut")] 
		public CName C_swipeLeftOut
		{
			get => GetProperty(ref _c_swipeLeftOut);
			set => SetProperty(ref _c_swipeLeftOut, value);
		}

		[Ordinal(23)] 
		[RED("c_swipeLeftIn")] 
		public CName C_swipeLeftIn
		{
			get => GetProperty(ref _c_swipeLeftIn);
			set => SetProperty(ref _c_swipeLeftIn, value);
		}

		[Ordinal(24)] 
		[RED("c_swipeRightOut")] 
		public CName C_swipeRightOut
		{
			get => GetProperty(ref _c_swipeRightOut);
			set => SetProperty(ref _c_swipeRightOut, value);
		}

		[Ordinal(25)] 
		[RED("c_swipeRightIn")] 
		public CName C_swipeRightIn
		{
			get => GetProperty(ref _c_swipeRightIn);
			set => SetProperty(ref _c_swipeRightIn, value);
		}

		public NewPerksCyberwareTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
