using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeMenuController : gameuiarcadeIArcadeScreenController
	{
		private inkWidgetReference _startArrow;
		private inkWidgetReference _scoreboardArrow;

		[Ordinal(1)] 
		[RED("startArrow")] 
		public inkWidgetReference StartArrow
		{
			get => GetProperty(ref _startArrow);
			set => SetProperty(ref _startArrow, value);
		}

		[Ordinal(2)] 
		[RED("scoreboardArrow")] 
		public inkWidgetReference ScoreboardArrow
		{
			get => GetProperty(ref _scoreboardArrow);
			set => SetProperty(ref _scoreboardArrow, value);
		}

		public gameuiarcadeArcadeMenuController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
