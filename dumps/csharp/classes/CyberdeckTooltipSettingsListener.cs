using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CyberdeckTooltipSettingsListener : userSettingsVarListener
	{
		private wCHandle<CyberdeckTooltip> _ctrl;
		private wCHandle<CyberdeckStatController> _statctrl;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<CyberdeckTooltip> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		[Ordinal(1)] 
		[RED("statctrl")] 
		public wCHandle<CyberdeckStatController> Statctrl
		{
			get => GetProperty(ref _statctrl);
			set => SetProperty(ref _statctrl, value);
		}

		public CyberdeckTooltipSettingsListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
