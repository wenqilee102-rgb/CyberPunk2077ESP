using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SignInPopupController : gameuiBaseGOGProfileController
	{
		private inkWidgetReference _qrCodeContainerRef;
		private inkImageWidgetReference _qrImageWidgetRef;
		private inkWidgetReference _hyperlinkButtonRef;
		private inkWidgetReference _closeButtonRef;
		private CName _introAnimationName;
		private CHandle<SignInPopupData> _data;
		private wCHandle<inkISystemRequestsHandler> _requestHandler;
		private CHandle<inkanimProxy> _introAnimProxy;
		private CString _signinUrl;
		private wCHandle<SignInQrCodeController> _signInQrCodeController;

		[Ordinal(2)] 
		[RED("qrCodeContainerRef")] 
		public inkWidgetReference QrCodeContainerRef
		{
			get => GetProperty(ref _qrCodeContainerRef);
			set => SetProperty(ref _qrCodeContainerRef, value);
		}

		[Ordinal(3)] 
		[RED("qrImageWidgetRef")] 
		public inkImageWidgetReference QrImageWidgetRef
		{
			get => GetProperty(ref _qrImageWidgetRef);
			set => SetProperty(ref _qrImageWidgetRef, value);
		}

		[Ordinal(4)] 
		[RED("hyperlinkButtonRef")] 
		public inkWidgetReference HyperlinkButtonRef
		{
			get => GetProperty(ref _hyperlinkButtonRef);
			set => SetProperty(ref _hyperlinkButtonRef, value);
		}

		[Ordinal(5)] 
		[RED("closeButtonRef")] 
		public inkWidgetReference CloseButtonRef
		{
			get => GetProperty(ref _closeButtonRef);
			set => SetProperty(ref _closeButtonRef, value);
		}

		[Ordinal(6)] 
		[RED("introAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetProperty(ref _introAnimationName);
			set => SetProperty(ref _introAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("data")] 
		public CHandle<SignInPopupData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(8)] 
		[RED("requestHandler")] 
		public wCHandle<inkISystemRequestsHandler> RequestHandler
		{
			get => GetProperty(ref _requestHandler);
			set => SetProperty(ref _requestHandler, value);
		}

		[Ordinal(9)] 
		[RED("introAnimProxy")] 
		public CHandle<inkanimProxy> IntroAnimProxy
		{
			get => GetProperty(ref _introAnimProxy);
			set => SetProperty(ref _introAnimProxy, value);
		}

		[Ordinal(10)] 
		[RED("signinUrl")] 
		public CString SigninUrl
		{
			get => GetProperty(ref _signinUrl);
			set => SetProperty(ref _signinUrl, value);
		}

		[Ordinal(11)] 
		[RED("signInQrCodeController")] 
		public wCHandle<SignInQrCodeController> SignInQrCodeController
		{
			get => GetProperty(ref _signInQrCodeController);
			set => SetProperty(ref _signInQrCodeController, value);
		}

		public SignInPopupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
