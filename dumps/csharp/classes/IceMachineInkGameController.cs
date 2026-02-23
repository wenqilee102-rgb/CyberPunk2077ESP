using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IceMachineInkGameController : DeviceInkGameControllerBase
	{
		private inkWidgetReference _buttonContainer;
		private inkTextWidgetReference _soldOutText;

		[Ordinal(16)] 
		[RED("buttonContainer")] 
		public inkWidgetReference ButtonContainer
		{
			get => GetProperty(ref _buttonContainer);
			set => SetProperty(ref _buttonContainer, value);
		}

		[Ordinal(17)] 
		[RED("soldOutText")] 
		public inkTextWidgetReference SoldOutText
		{
			get => GetProperty(ref _soldOutText);
			set => SetProperty(ref _soldOutText, value);
		}

		public IceMachineInkGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
