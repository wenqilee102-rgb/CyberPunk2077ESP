using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyRadioStatusListener : gameScriptStatusEffectListener
	{
		private wCHandle<HotkeyConsumableWidgetController> _radioWidgetController;

		[Ordinal(0)] 
		[RED("radioWidgetController")] 
		public wCHandle<HotkeyConsumableWidgetController> RadioWidgetController
		{
			get => GetProperty(ref _radioWidgetController);
			set => SetProperty(ref _radioWidgetController, value);
		}

		public HotkeyRadioStatusListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
