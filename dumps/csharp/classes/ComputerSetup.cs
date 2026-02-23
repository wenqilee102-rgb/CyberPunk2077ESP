using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerSetup : TerminalSetup
	{
		private CEnum<EComputerMenuType> _startingMenu;
		private CBool _mailsMenu;
		private CBool _filesMenu;
		private CBool _systemMenu;
		private CBool _internetMenu;
		private CBool _newsFeedMenu;
		private TweakDBID _stylePreset;
		private CBool _hideTopNavigationBar;
		private CArray<gamedeviceGenericDataContent> _mailsStructure;
		private CArray<gamedeviceGenericDataContent> _filesStructure;
		private CArray<SNewsFeedElementData> _newsFeed;
		private CFloat _newsFeedInterval;
		private SInternetData _internetSubnet;
		private CEnum<EComputerAnimationState> _animationState;
		private CName _animationStateSetFactName;
		private CBool _ignoreSleepMode;

		[Ordinal(5)] 
		[RED("startingMenu")] 
		public CEnum<EComputerMenuType> StartingMenu
		{
			get => GetProperty(ref _startingMenu);
			set => SetProperty(ref _startingMenu, value);
		}

		[Ordinal(6)] 
		[RED("mailsMenu")] 
		public CBool MailsMenu
		{
			get => GetProperty(ref _mailsMenu);
			set => SetProperty(ref _mailsMenu, value);
		}

		[Ordinal(7)] 
		[RED("filesMenu")] 
		public CBool FilesMenu
		{
			get => GetProperty(ref _filesMenu);
			set => SetProperty(ref _filesMenu, value);
		}

		[Ordinal(8)] 
		[RED("systemMenu")] 
		public CBool SystemMenu
		{
			get => GetProperty(ref _systemMenu);
			set => SetProperty(ref _systemMenu, value);
		}

		[Ordinal(9)] 
		[RED("internetMenu")] 
		public CBool InternetMenu
		{
			get => GetProperty(ref _internetMenu);
			set => SetProperty(ref _internetMenu, value);
		}

		[Ordinal(10)] 
		[RED("newsFeedMenu")] 
		public CBool NewsFeedMenu
		{
			get => GetProperty(ref _newsFeedMenu);
			set => SetProperty(ref _newsFeedMenu, value);
		}

		[Ordinal(11)] 
		[RED("stylePreset")] 
		public TweakDBID StylePreset
		{
			get => GetProperty(ref _stylePreset);
			set => SetProperty(ref _stylePreset, value);
		}

		[Ordinal(12)] 
		[RED("hideTopNavigationBar")] 
		public CBool HideTopNavigationBar
		{
			get => GetProperty(ref _hideTopNavigationBar);
			set => SetProperty(ref _hideTopNavigationBar, value);
		}

		[Ordinal(13)] 
		[RED("mailsStructure")] 
		public CArray<gamedeviceGenericDataContent> MailsStructure
		{
			get => GetProperty(ref _mailsStructure);
			set => SetProperty(ref _mailsStructure, value);
		}

		[Ordinal(14)] 
		[RED("filesStructure")] 
		public CArray<gamedeviceGenericDataContent> FilesStructure
		{
			get => GetProperty(ref _filesStructure);
			set => SetProperty(ref _filesStructure, value);
		}

		[Ordinal(15)] 
		[RED("newsFeed")] 
		public CArray<SNewsFeedElementData> NewsFeed
		{
			get => GetProperty(ref _newsFeed);
			set => SetProperty(ref _newsFeed, value);
		}

		[Ordinal(16)] 
		[RED("newsFeedInterval")] 
		public CFloat NewsFeedInterval
		{
			get => GetProperty(ref _newsFeedInterval);
			set => SetProperty(ref _newsFeedInterval, value);
		}

		[Ordinal(17)] 
		[RED("internetSubnet")] 
		public SInternetData InternetSubnet
		{
			get => GetProperty(ref _internetSubnet);
			set => SetProperty(ref _internetSubnet, value);
		}

		[Ordinal(18)] 
		[RED("animationState")] 
		public CEnum<EComputerAnimationState> AnimationState
		{
			get => GetProperty(ref _animationState);
			set => SetProperty(ref _animationState, value);
		}

		[Ordinal(19)] 
		[RED("animationStateSetFactName")] 
		public CName AnimationStateSetFactName
		{
			get => GetProperty(ref _animationStateSetFactName);
			set => SetProperty(ref _animationStateSetFactName, value);
		}

		[Ordinal(20)] 
		[RED("ignoreSleepMode")] 
		public CBool IgnoreSleepMode
		{
			get => GetProperty(ref _ignoreSleepMode);
			set => SetProperty(ref _ignoreSleepMode, value);
		}

		public ComputerSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
