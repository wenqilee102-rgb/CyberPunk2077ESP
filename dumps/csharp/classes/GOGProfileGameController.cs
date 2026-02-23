using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GOGProfileGameController : gameuiBaseGOGProfileController
	{
		private inkWidgetReference _retryButton;
		private inkWidgetReference _parentContainerWidget;
		private CBool _isFirstLogin;
		private CBool _showingFirstLogin;
		private CBool _canRetry;
		private CEnum<GogPopupScreenType> _currentScreenType;
		private wCHandle<inkWidget> _currentWidget;
		private CArray<CHandle<GogRewardEntryData>> _gogRewardsList;
		private CHandle<gameuiGameSystemUI> _uiSystem;

		[Ordinal(2)] 
		[RED("retryButton")] 
		public inkWidgetReference RetryButton
		{
			get => GetProperty(ref _retryButton);
			set => SetProperty(ref _retryButton, value);
		}

		[Ordinal(3)] 
		[RED("parentContainerWidget")] 
		public inkWidgetReference ParentContainerWidget
		{
			get => GetProperty(ref _parentContainerWidget);
			set => SetProperty(ref _parentContainerWidget, value);
		}

		[Ordinal(4)] 
		[RED("isFirstLogin")] 
		public CBool IsFirstLogin
		{
			get => GetProperty(ref _isFirstLogin);
			set => SetProperty(ref _isFirstLogin, value);
		}

		[Ordinal(5)] 
		[RED("showingFirstLogin")] 
		public CBool ShowingFirstLogin
		{
			get => GetProperty(ref _showingFirstLogin);
			set => SetProperty(ref _showingFirstLogin, value);
		}

		[Ordinal(6)] 
		[RED("canRetry")] 
		public CBool CanRetry
		{
			get => GetProperty(ref _canRetry);
			set => SetProperty(ref _canRetry, value);
		}

		[Ordinal(7)] 
		[RED("currentScreenType")] 
		public CEnum<GogPopupScreenType> CurrentScreenType
		{
			get => GetProperty(ref _currentScreenType);
			set => SetProperty(ref _currentScreenType, value);
		}

		[Ordinal(8)] 
		[RED("currentWidget")] 
		public wCHandle<inkWidget> CurrentWidget
		{
			get => GetProperty(ref _currentWidget);
			set => SetProperty(ref _currentWidget, value);
		}

		[Ordinal(9)] 
		[RED("gogRewardsList")] 
		public CArray<CHandle<GogRewardEntryData>> GogRewardsList
		{
			get => GetProperty(ref _gogRewardsList);
			set => SetProperty(ref _gogRewardsList, value);
		}

		[Ordinal(10)] 
		[RED("uiSystem")] 
		public CHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		public GOGProfileGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
