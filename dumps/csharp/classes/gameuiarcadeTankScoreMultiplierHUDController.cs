using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeTankScoreMultiplierHUDController : inkWidgetLogicController
	{
		private inkImageWidgetReference _scoreMultiplierBarFill;

		[Ordinal(1)] 
		[RED("scoreMultiplierBarFill")] 
		public inkImageWidgetReference ScoreMultiplierBarFill
		{
			get => GetProperty(ref _scoreMultiplierBarFill);
			set => SetProperty(ref _scoreMultiplierBarFill, value);
		}

		public gameuiarcadeTankScoreMultiplierHUDController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
