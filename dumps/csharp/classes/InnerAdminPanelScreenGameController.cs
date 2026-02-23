using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InnerAdminPanelScreenGameController : BaseInnerBunkerComputerGameController
	{
		private CName _introAnimName;
		private CName _loopAnimName;
		private CArrayFixedSize<CName> _buttonAnimName;
		private CArrayFixedSize<CName> _commandAnimName;
		private CArrayFixedSize<CName> _successAnimName;
		private CName _successPopupAnimName;
		private CName _attemptAnimName;
		private CName _instantAttemptAnimName;
		private CName _instantAttemptPopupAnimName;
		private inkWidgetReference _shutdownButton;
		private CInt32 _subsystemIndex;
		private CHandle<inkanimProxy> _animProxyFull1;
		private CHandle<inkanimProxy> _animProxyFull2;
		private CHandle<inkanimProxy> _animProxySuccess;
		private CHandle<inkanimProxy> _animProxySuccessPopup;
		private CHandle<inkanimProxy> _animProxyAttempt;
		private CHandle<inkanimProxy> _animProxyAttemptPopup;
		private CHandle<redCallbackObject> _zoomUICallbackHandle;
		private CBool _isUIZoomDevice;

		[Ordinal(2)] 
		[RED("introAnimName")] 
		public CName IntroAnimName
		{
			get => GetProperty(ref _introAnimName);
			set => SetProperty(ref _introAnimName, value);
		}

		[Ordinal(3)] 
		[RED("loopAnimName")] 
		public CName LoopAnimName
		{
			get => GetProperty(ref _loopAnimName);
			set => SetProperty(ref _loopAnimName, value);
		}

		[Ordinal(4)] 
		[RED("buttonAnimName", 3)] 
		public CArrayFixedSize<CName> ButtonAnimName
		{
			get => GetProperty(ref _buttonAnimName);
			set => SetProperty(ref _buttonAnimName, value);
		}

		[Ordinal(5)] 
		[RED("commandAnimName", 3)] 
		public CArrayFixedSize<CName> CommandAnimName
		{
			get => GetProperty(ref _commandAnimName);
			set => SetProperty(ref _commandAnimName, value);
		}

		[Ordinal(6)] 
		[RED("successAnimName", 3)] 
		public CArrayFixedSize<CName> SuccessAnimName
		{
			get => GetProperty(ref _successAnimName);
			set => SetProperty(ref _successAnimName, value);
		}

		[Ordinal(7)] 
		[RED("successPopupAnimName")] 
		public CName SuccessPopupAnimName
		{
			get => GetProperty(ref _successPopupAnimName);
			set => SetProperty(ref _successPopupAnimName, value);
		}

		[Ordinal(8)] 
		[RED("attemptAnimName")] 
		public CName AttemptAnimName
		{
			get => GetProperty(ref _attemptAnimName);
			set => SetProperty(ref _attemptAnimName, value);
		}

		[Ordinal(9)] 
		[RED("instantAttemptAnimName")] 
		public CName InstantAttemptAnimName
		{
			get => GetProperty(ref _instantAttemptAnimName);
			set => SetProperty(ref _instantAttemptAnimName, value);
		}

		[Ordinal(10)] 
		[RED("instantAttemptPopupAnimName")] 
		public CName InstantAttemptPopupAnimName
		{
			get => GetProperty(ref _instantAttemptPopupAnimName);
			set => SetProperty(ref _instantAttemptPopupAnimName, value);
		}

		[Ordinal(11)] 
		[RED("shutdownButton")] 
		public inkWidgetReference ShutdownButton
		{
			get => GetProperty(ref _shutdownButton);
			set => SetProperty(ref _shutdownButton, value);
		}

		[Ordinal(12)] 
		[RED("subsystemIndex")] 
		public CInt32 SubsystemIndex
		{
			get => GetProperty(ref _subsystemIndex);
			set => SetProperty(ref _subsystemIndex, value);
		}

		[Ordinal(13)] 
		[RED("animProxyFull1")] 
		public CHandle<inkanimProxy> AnimProxyFull1
		{
			get => GetProperty(ref _animProxyFull1);
			set => SetProperty(ref _animProxyFull1, value);
		}

		[Ordinal(14)] 
		[RED("animProxyFull2")] 
		public CHandle<inkanimProxy> AnimProxyFull2
		{
			get => GetProperty(ref _animProxyFull2);
			set => SetProperty(ref _animProxyFull2, value);
		}

		[Ordinal(15)] 
		[RED("animProxySuccess")] 
		public CHandle<inkanimProxy> AnimProxySuccess
		{
			get => GetProperty(ref _animProxySuccess);
			set => SetProperty(ref _animProxySuccess, value);
		}

		[Ordinal(16)] 
		[RED("animProxySuccessPopup")] 
		public CHandle<inkanimProxy> AnimProxySuccessPopup
		{
			get => GetProperty(ref _animProxySuccessPopup);
			set => SetProperty(ref _animProxySuccessPopup, value);
		}

		[Ordinal(17)] 
		[RED("animProxyAttempt")] 
		public CHandle<inkanimProxy> AnimProxyAttempt
		{
			get => GetProperty(ref _animProxyAttempt);
			set => SetProperty(ref _animProxyAttempt, value);
		}

		[Ordinal(18)] 
		[RED("animProxyAttemptPopup")] 
		public CHandle<inkanimProxy> AnimProxyAttemptPopup
		{
			get => GetProperty(ref _animProxyAttemptPopup);
			set => SetProperty(ref _animProxyAttemptPopup, value);
		}

		[Ordinal(19)] 
		[RED("zoomUICallbackHandle")] 
		public CHandle<redCallbackObject> ZoomUICallbackHandle
		{
			get => GetProperty(ref _zoomUICallbackHandle);
			set => SetProperty(ref _zoomUICallbackHandle, value);
		}

		[Ordinal(20)] 
		[RED("isUIZoomDevice")] 
		public CBool IsUIZoomDevice
		{
			get => GetProperty(ref _isUIZoomDevice);
			set => SetProperty(ref _isUIZoomDevice, value);
		}

		public InnerAdminPanelScreenGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
