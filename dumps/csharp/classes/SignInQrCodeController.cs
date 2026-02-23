using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SignInQrCodeController : gameuiBaseGOGRegisterController
	{
		private inkImageWidgetReference _qrImageWidgetRef;
		private wCHandle<inkImageWidget> _qrImageWidget;

		[Ordinal(1)] 
		[RED("qrImageWidgetRef")] 
		public inkImageWidgetReference QrImageWidgetRef
		{
			get => GetProperty(ref _qrImageWidgetRef);
			set => SetProperty(ref _qrImageWidgetRef, value);
		}

		[Ordinal(2)] 
		[RED("qrImageWidget")] 
		public wCHandle<inkImageWidget> QrImageWidget
		{
			get => GetProperty(ref _qrImageWidget);
			set => SetProperty(ref _qrImageWidget, value);
		}

		public SignInQrCodeController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
