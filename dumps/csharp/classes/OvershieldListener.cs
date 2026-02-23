using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OvershieldListener : gameScriptStatPoolsListener
	{
		private wCHandle<gameuiHudHealthbarGameController> _healthBar;

		[Ordinal(0)] 
		[RED("healthBar")] 
		public wCHandle<gameuiHudHealthbarGameController> HealthBar
		{
			get => GetProperty(ref _healthBar);
			set => SetProperty(ref _healthBar, value);
		}

		public OvershieldListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
