using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterGameplayController : gameuiarcadeArcadeGameplayController
	{
		private inkWidgetReference _player;
		private inkWidgetReference _hud;
		private inkWidgetReference _levelContainer;

		[Ordinal(3)] 
		[RED("player")] 
		public inkWidgetReference Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(4)] 
		[RED("hud")] 
		public inkWidgetReference Hud
		{
			get => GetProperty(ref _hud);
			set => SetProperty(ref _hud, value);
		}

		[Ordinal(5)] 
		[RED("levelContainer")] 
		public inkWidgetReference LevelContainer
		{
			get => GetProperty(ref _levelContainer);
			set => SetProperty(ref _levelContainer, value);
		}

		public gameuiarcadeShooterGameplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
