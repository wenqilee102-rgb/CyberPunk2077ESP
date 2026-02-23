using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverclockHudListener : gameScriptStatusEffectListener
	{
		private wCHandle<gameuiHUDGameController> _hudController;

		[Ordinal(0)] 
		[RED("hudController")] 
		public wCHandle<gameuiHUDGameController> HudController
		{
			get => GetProperty(ref _hudController);
			set => SetProperty(ref _hudController, value);
		}

		public OverclockHudListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
