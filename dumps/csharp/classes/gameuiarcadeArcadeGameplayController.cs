using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeGameplayController : gameuiarcadeIArcadeScreenController
	{
		private inkWidgetReference _score;
		private inkWidgetReference _pauseText;

		[Ordinal(1)] 
		[RED("score")] 
		public inkWidgetReference Score
		{
			get => GetProperty(ref _score);
			set => SetProperty(ref _score, value);
		}

		[Ordinal(2)] 
		[RED("pauseText")] 
		public inkWidgetReference PauseText
		{
			get => GetProperty(ref _pauseText);
			set => SetProperty(ref _pauseText, value);
		}

		public gameuiarcadeArcadeGameplayController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
