using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiarcadeShooterArcadeScoreboardController : gameuiarcadeArcadeScoreboardController
	{
		private inkWidgetReference _scoreBackground;
		private inkWidgetReference _endingScoreBackground;
		private inkWidgetReference _playerNames;
		private inkWidgetReference _ranks;
		private inkWidgetReference _scores;
		private inkWidgetReference _highestScoreText;
		private inkWidgetReference _highScoreText;
		private inkImageWidgetReference _gameOverImage;
		private Vector2 _highestScoreOriginalOffset;
		private Vector2 _highestScoreEndingOffset;
		private Vector2 _highScoreTextOriginalOffset;
		private Vector2 _highScoreTextEndingOffset;
		private Vector2 _rankScoreOriginalOffset;
		private Vector2 _rankScoreEndingOffset;
		private Vector2 _namesOriginalOffset;
		private Vector2 _namesEndingOffset;

		[Ordinal(8)] 
		[RED("scoreBackground")] 
		public inkWidgetReference ScoreBackground
		{
			get => GetProperty(ref _scoreBackground);
			set => SetProperty(ref _scoreBackground, value);
		}

		[Ordinal(9)] 
		[RED("endingScoreBackground")] 
		public inkWidgetReference EndingScoreBackground
		{
			get => GetProperty(ref _endingScoreBackground);
			set => SetProperty(ref _endingScoreBackground, value);
		}

		[Ordinal(10)] 
		[RED("playerNames")] 
		public inkWidgetReference PlayerNames
		{
			get => GetProperty(ref _playerNames);
			set => SetProperty(ref _playerNames, value);
		}

		[Ordinal(11)] 
		[RED("ranks")] 
		public inkWidgetReference Ranks
		{
			get => GetProperty(ref _ranks);
			set => SetProperty(ref _ranks, value);
		}

		[Ordinal(12)] 
		[RED("scores")] 
		public inkWidgetReference Scores
		{
			get => GetProperty(ref _scores);
			set => SetProperty(ref _scores, value);
		}

		[Ordinal(13)] 
		[RED("highestScoreText")] 
		public inkWidgetReference HighestScoreText
		{
			get => GetProperty(ref _highestScoreText);
			set => SetProperty(ref _highestScoreText, value);
		}

		[Ordinal(14)] 
		[RED("highScoreText")] 
		public inkWidgetReference HighScoreText
		{
			get => GetProperty(ref _highScoreText);
			set => SetProperty(ref _highScoreText, value);
		}

		[Ordinal(15)] 
		[RED("gameOverImage")] 
		public inkImageWidgetReference GameOverImage
		{
			get => GetProperty(ref _gameOverImage);
			set => SetProperty(ref _gameOverImage, value);
		}

		[Ordinal(16)] 
		[RED("highestScoreOriginalOffset")] 
		public Vector2 HighestScoreOriginalOffset
		{
			get => GetProperty(ref _highestScoreOriginalOffset);
			set => SetProperty(ref _highestScoreOriginalOffset, value);
		}

		[Ordinal(17)] 
		[RED("highestScoreEndingOffset")] 
		public Vector2 HighestScoreEndingOffset
		{
			get => GetProperty(ref _highestScoreEndingOffset);
			set => SetProperty(ref _highestScoreEndingOffset, value);
		}

		[Ordinal(18)] 
		[RED("highScoreTextOriginalOffset")] 
		public Vector2 HighScoreTextOriginalOffset
		{
			get => GetProperty(ref _highScoreTextOriginalOffset);
			set => SetProperty(ref _highScoreTextOriginalOffset, value);
		}

		[Ordinal(19)] 
		[RED("highScoreTextEndingOffset")] 
		public Vector2 HighScoreTextEndingOffset
		{
			get => GetProperty(ref _highScoreTextEndingOffset);
			set => SetProperty(ref _highScoreTextEndingOffset, value);
		}

		[Ordinal(20)] 
		[RED("rankScoreOriginalOffset")] 
		public Vector2 RankScoreOriginalOffset
		{
			get => GetProperty(ref _rankScoreOriginalOffset);
			set => SetProperty(ref _rankScoreOriginalOffset, value);
		}

		[Ordinal(21)] 
		[RED("rankScoreEndingOffset")] 
		public Vector2 RankScoreEndingOffset
		{
			get => GetProperty(ref _rankScoreEndingOffset);
			set => SetProperty(ref _rankScoreEndingOffset, value);
		}

		[Ordinal(22)] 
		[RED("namesOriginalOffset")] 
		public Vector2 NamesOriginalOffset
		{
			get => GetProperty(ref _namesOriginalOffset);
			set => SetProperty(ref _namesOriginalOffset, value);
		}

		[Ordinal(23)] 
		[RED("namesEndingOffset")] 
		public Vector2 NamesEndingOffset
		{
			get => GetProperty(ref _namesEndingOffset);
			set => SetProperty(ref _namesEndingOffset, value);
		}

		public gameuiarcadeShooterArcadeScoreboardController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
