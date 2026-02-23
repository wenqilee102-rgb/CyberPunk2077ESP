using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyCustomRadioWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		private inkCompoundWidgetReference _radioSlot;
		private inkWidgetLibraryReference _dpadHintLibraryPath;

		[Ordinal(15)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetProperty(ref _radioSlot);
			set => SetProperty(ref _radioSlot, value);
		}

		[Ordinal(16)] 
		[RED("DpadHintLibraryPath")] 
		public inkWidgetLibraryReference DpadHintLibraryPath
		{
			get => GetProperty(ref _dpadHintLibraryPath);
			set => SetProperty(ref _dpadHintLibraryPath, value);
		}

		public HotkeyCustomRadioWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
