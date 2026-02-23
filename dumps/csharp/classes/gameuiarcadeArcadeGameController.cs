using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeGameController : gameuiWidgetGameController
	{
		private CEnum<gameuiarcadeArcadeMinigame> _minigame;
		private CFloat _defaultScreenTransitionTotalTime;
		private inkImageWidgetReference _screenTransitionWidget;
		private inkWidgetReference _menu;
		private inkWidgetReference _gameplay;
		private inkWidgetReference _scoreboard;

		[Ordinal(2)] 
		[RED("minigame")] 
		public CEnum<gameuiarcadeArcadeMinigame> Minigame
		{
			get => GetProperty(ref _minigame);
			set => SetProperty(ref _minigame, value);
		}

		[Ordinal(3)] 
		[RED("defaultScreenTransitionTotalTime")] 
		public CFloat DefaultScreenTransitionTotalTime
		{
			get => GetProperty(ref _defaultScreenTransitionTotalTime);
			set => SetProperty(ref _defaultScreenTransitionTotalTime, value);
		}

		[Ordinal(4)] 
		[RED("screenTransitionWidget")] 
		public inkImageWidgetReference ScreenTransitionWidget
		{
			get => GetProperty(ref _screenTransitionWidget);
			set => SetProperty(ref _screenTransitionWidget, value);
		}

		[Ordinal(5)] 
		[RED("menu")] 
		public inkWidgetReference Menu
		{
			get => GetProperty(ref _menu);
			set => SetProperty(ref _menu, value);
		}

		[Ordinal(6)] 
		[RED("gameplay")] 
		public inkWidgetReference Gameplay
		{
			get => GetProperty(ref _gameplay);
			set => SetProperty(ref _gameplay, value);
		}

		[Ordinal(7)] 
		[RED("scoreboard")] 
		public inkWidgetReference Scoreboard
		{
			get => GetProperty(ref _scoreboard);
			set => SetProperty(ref _scoreboard, value);
		}

		public gameuiarcadeArcadeGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
