using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InnerSubsystemScreenGameController : BaseInnerBunkerComputerGameController
	{
		private CArrayFixedSize<CName> _loopAnimName;
		private CName _adminAccessPopupAnimName;
		private CName _unrecognizedPopupAnimName;
		private CName _preAuthorizingPopupAnimName;
		private CName _postAuthorizingPopupAnimName;
		private CName _deniedPopupAnimName;
		private CName _successPopupAnimName;
		private CName _errorPopupAnimName;
		private CName _icePopupAnimName;
		private CArrayFixedSize<inkWidgetReference> _shutdownButton;
		private CArrayFixedSize<inkWidgetReference> _adminPanelButton;
		private inkWidgetReference _adminPanelPopupButton;
		private inkWidgetReference _transitionToAuthorization;
		private inkWidgetReference _transitionToMinigame;
		private inkWidgetReference _transitionToAdminPanel;
		private CInt32 _subsystemIndex;
		private CHandle<inkanimProxy> _adminAccessPopupAnimProxy;
		private CHandle<inkanimProxy> _successPopupAnimProxy;
		private CHandle<inkanimProxy> _errorPopupAnimProxy;

		[Ordinal(2)] 
		[RED("loopAnimName", 3)] 
		public CArrayFixedSize<CName> LoopAnimName
		{
			get => GetProperty(ref _loopAnimName);
			set => SetProperty(ref _loopAnimName, value);
		}

		[Ordinal(3)] 
		[RED("adminAccessPopupAnimName")] 
		public CName AdminAccessPopupAnimName
		{
			get => GetProperty(ref _adminAccessPopupAnimName);
			set => SetProperty(ref _adminAccessPopupAnimName, value);
		}

		[Ordinal(4)] 
		[RED("unrecognizedPopupAnimName")] 
		public CName UnrecognizedPopupAnimName
		{
			get => GetProperty(ref _unrecognizedPopupAnimName);
			set => SetProperty(ref _unrecognizedPopupAnimName, value);
		}

		[Ordinal(5)] 
		[RED("preAuthorizingPopupAnimName")] 
		public CName PreAuthorizingPopupAnimName
		{
			get => GetProperty(ref _preAuthorizingPopupAnimName);
			set => SetProperty(ref _preAuthorizingPopupAnimName, value);
		}

		[Ordinal(6)] 
		[RED("postAuthorizingPopupAnimName")] 
		public CName PostAuthorizingPopupAnimName
		{
			get => GetProperty(ref _postAuthorizingPopupAnimName);
			set => SetProperty(ref _postAuthorizingPopupAnimName, value);
		}

		[Ordinal(7)] 
		[RED("deniedPopupAnimName")] 
		public CName DeniedPopupAnimName
		{
			get => GetProperty(ref _deniedPopupAnimName);
			set => SetProperty(ref _deniedPopupAnimName, value);
		}

		[Ordinal(8)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetProperty(ref _successPopupAnimName);
			set => SetProperty(ref _successPopupAnimName, value);
		}

		[Ordinal(9)] 
		[RED("errorPopupAnimName")] 
		public CName ErrorPopupAnimName
		{
			get => GetProperty(ref _errorPopupAnimName);
			set => SetProperty(ref _errorPopupAnimName, value);
		}

		[Ordinal(10)] 
		[RED("icePopupAnimName")] 
		public CName IcePopupAnimName
		{
			get => GetProperty(ref _icePopupAnimName);
			set => SetProperty(ref _icePopupAnimName, value);
		}

		[Ordinal(11)] 
		[RED("shutdownButton", 3)] 
		public CArrayFixedSize<inkWidgetReference> ShutdownButton
		{
			get => GetProperty(ref _shutdownButton);
			set => SetProperty(ref _shutdownButton, value);
		}

		[Ordinal(12)] 
		[RED("adminPanelButton", 3)] 
		public CArrayFixedSize<inkWidgetReference> AdminPanelButton
		{
			get => GetProperty(ref _adminPanelButton);
			set => SetProperty(ref _adminPanelButton, value);
		}

		[Ordinal(13)] 
		[RED("adminPanelPopupButton")] 
		public inkWidgetReference AdminPanelPopupButton
		{
			get => GetProperty(ref _adminPanelPopupButton);
			set => SetProperty(ref _adminPanelPopupButton, value);
		}

		[Ordinal(14)] 
		[RED("transitionToAuthorization")] 
		public inkWidgetReference TransitionToAuthorization
		{
			get => GetProperty(ref _transitionToAuthorization);
			set => SetProperty(ref _transitionToAuthorization, value);
		}

		[Ordinal(15)] 
		[RED("transitionToMinigame")] 
		public inkWidgetReference TransitionToMinigame
		{
			get => GetProperty(ref _transitionToMinigame);
			set => SetProperty(ref _transitionToMinigame, value);
		}

		[Ordinal(16)] 
		[RED("transitionToAdminPanel")] 
		public inkWidgetReference TransitionToAdminPanel
		{
			get => GetProperty(ref _transitionToAdminPanel);
			set => SetProperty(ref _transitionToAdminPanel, value);
		}

		[Ordinal(17)] 
		[RED("subsystemIndex")] 
		public CInt32 SubsystemIndex
		{
			get => GetProperty(ref _subsystemIndex);
			set => SetProperty(ref _subsystemIndex, value);
		}

		[Ordinal(18)] 
		[RED("adminAccessPopupAnimProxy")] 
		public CHandle<inkanimProxy> AdminAccessPopupAnimProxy
		{
			get => GetProperty(ref _adminAccessPopupAnimProxy);
			set => SetProperty(ref _adminAccessPopupAnimProxy, value);
		}

		[Ordinal(19)] 
		[RED("successPopupAnimProxy")] 
		public CHandle<inkanimProxy> SuccessPopupAnimProxy
		{
			get => GetProperty(ref _successPopupAnimProxy);
			set => SetProperty(ref _successPopupAnimProxy, value);
		}

		[Ordinal(20)] 
		[RED("errorPopupAnimProxy")] 
		public CHandle<inkanimProxy> ErrorPopupAnimProxy
		{
			get => GetProperty(ref _errorPopupAnimProxy);
			set => SetProperty(ref _errorPopupAnimProxy, value);
		}

		public InnerSubsystemScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
