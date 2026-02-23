using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeArcadeScoreboardController : gameuiarcadeIArcadeScreenController
	{
		private inkWidgetReference _endingPanel;
		private inkTextWidgetReference _playerCurrentScore;
		private inkTextWidgetReference _playerHighestScore;
		private inkTextWidgetReference _playerHighestScoreAlert;
		private inkWidgetReference _pressToPlayAgainText;
		private CArray<inkTextWidgetReference> _scoreboardNameList;
		private CArray<inkTextWidgetReference> _scoreboardScoreList;

		[Ordinal(1)] 
		[RED("endingPanel")] 
		public inkWidgetReference EndingPanel
		{
			get => GetProperty(ref _endingPanel);
			set => SetProperty(ref _endingPanel, value);
		}

		[Ordinal(2)] 
		[RED("playerCurrentScore")] 
		public inkTextWidgetReference PlayerCurrentScore
		{
			get => GetProperty(ref _playerCurrentScore);
			set => SetProperty(ref _playerCurrentScore, value);
		}

		[Ordinal(3)] 
		[RED("playerHighestScore")] 
		public inkTextWidgetReference PlayerHighestScore
		{
			get => GetProperty(ref _playerHighestScore);
			set => SetProperty(ref _playerHighestScore, value);
		}

		[Ordinal(4)] 
		[RED("playerHighestScoreAlert")] 
		public inkTextWidgetReference PlayerHighestScoreAlert
		{
			get => GetProperty(ref _playerHighestScoreAlert);
			set => SetProperty(ref _playerHighestScoreAlert, value);
		}

		[Ordinal(5)] 
		[RED("pressToPlayAgainText")] 
		public inkWidgetReference PressToPlayAgainText
		{
			get => GetProperty(ref _pressToPlayAgainText);
			set => SetProperty(ref _pressToPlayAgainText, value);
		}

		[Ordinal(6)] 
		[RED("scoreboardNameList")] 
		public CArray<inkTextWidgetReference> ScoreboardNameList
		{
			get => GetProperty(ref _scoreboardNameList);
			set => SetProperty(ref _scoreboardNameList, value);
		}

		[Ordinal(7)] 
		[RED("scoreboardScoreList")] 
		public CArray<inkTextWidgetReference> ScoreboardScoreList
		{
			get => GetProperty(ref _scoreboardScoreList);
			set => SetProperty(ref _scoreboardScoreList, value);
		}

		public gameuiarcadeArcadeScoreboardController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
