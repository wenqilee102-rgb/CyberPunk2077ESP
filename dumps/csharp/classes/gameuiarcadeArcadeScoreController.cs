using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeScoreController : inkWidgetLogicController
	{
		private inkWidgetReference _scoreText;

		[Ordinal(1)] 
		[RED("scoreText")] 
		public inkWidgetReference ScoreText
		{
			get => GetProperty(ref _scoreText);
			set => SetProperty(ref _scoreText, value);
		}

		public gameuiarcadeArcadeScoreController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
