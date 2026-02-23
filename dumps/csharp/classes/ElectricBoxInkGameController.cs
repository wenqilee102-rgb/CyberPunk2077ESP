using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricBoxInkGameController : DeviceInkGameControllerBase
	{
		private CHandle<redCallbackObject> _onOverrideListener;

		[Ordinal(16)] 
		[RED("onOverrideListener")] 
		public CHandle<redCallbackObject> OnOverrideListener
		{
			get => GetProperty(ref _onOverrideListener);
			set => SetProperty(ref _onOverrideListener, value);
		}

		public ElectricBoxInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
