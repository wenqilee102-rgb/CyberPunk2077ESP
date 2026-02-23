using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InputSettingsVarListener : userSettingsVarListener
	{
		private wCHandle<gameuiControllerSettingsGameController> _ctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<gameuiControllerSettingsGameController> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		public InputSettingsVarListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
