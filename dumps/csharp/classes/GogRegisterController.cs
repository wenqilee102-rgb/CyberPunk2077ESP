using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRegisterController : gameuiBaseGOGRegisterController
	{
		private inkWidgetReference _linkWidget;
		private inkWidgetReference _qrImageWidget;
		private inkTextWidgetReference _textDescription;

		[Ordinal(1)] 
		[RED("linkWidget")] 
		public inkWidgetReference LinkWidget
		{
			get => GetProperty(ref _linkWidget);
			set => SetProperty(ref _linkWidget, value);
		}

		[Ordinal(2)] 
		[RED("qrImageWidget")] 
		public inkWidgetReference QrImageWidget
		{
			get => GetProperty(ref _qrImageWidget);
			set => SetProperty(ref _qrImageWidget, value);
		}

		[Ordinal(3)] 
		[RED("textDescription")] 
		public inkTextWidgetReference TextDescription
		{
			get => GetProperty(ref _textDescription);
			set => SetProperty(ref _textDescription, value);
		}

		public GogRegisterController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
