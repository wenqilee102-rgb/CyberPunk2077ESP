using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FakePhoneContactItemVirtualController : PhoneContactItemVirtualController
	{
		private inkWidgetReference _dots;

		[Ordinal(36)] 
		[RED("dots")] 
		public inkWidgetReference Dots
		{
			get => GetProperty(ref _dots);
			set => SetProperty(ref _dots, value);
		}

		public FakePhoneContactItemVirtualController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
