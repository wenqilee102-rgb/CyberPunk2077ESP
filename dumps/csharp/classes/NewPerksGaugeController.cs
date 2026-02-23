using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksGaugeController : inkWidgetLogicController
	{
		private inkWidgetReference _bar;
		private inkWidgetReference _possibleBar;
		private inkWidgetReference _currentLevelIndicator;
		private inkWidgetReference _possibleLevelIndicator;
		private inkTextWidgetReference _levelText;
		private CArray<NewPerksGaugePointDetails> _levels;

		[Ordinal(1)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(2)] 
		[RED("possibleBar")] 
		public inkWidgetReference PossibleBar
		{
			get => GetProperty(ref _possibleBar);
			set => SetProperty(ref _possibleBar, value);
		}

		[Ordinal(3)] 
		[RED("currentLevelIndicator")] 
		public inkWidgetReference CurrentLevelIndicator
		{
			get => GetProperty(ref _currentLevelIndicator);
			set => SetProperty(ref _currentLevelIndicator, value);
		}

		[Ordinal(4)] 
		[RED("possibleLevelIndicator")] 
		public inkWidgetReference PossibleLevelIndicator
		{
			get => GetProperty(ref _possibleLevelIndicator);
			set => SetProperty(ref _possibleLevelIndicator, value);
		}

		[Ordinal(5)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(6)] 
		[RED("levels")] 
		public CArray<NewPerksGaugePointDetails> Levels
		{
			get => GetProperty(ref _levels);
			set => SetProperty(ref _levels, value);
		}

		public NewPerksGaugeController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
