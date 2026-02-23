using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CreditsGameController : gameuiCreditsController
	{
		private inkCompoundWidgetReference _videoContainer;
		private inkImageWidgetReference _sceneTexture;
		private inkVideoWidgetReference _backgroundVideo;
		private inkVideoWidgetReference _binkVideo;
		private CArray<gameuiBinkResource> _binkVideos;
		private inkTextWidgetReference _fastForward;
		private CFloat _timerUntilFadeEp1;
		private inkVideoWidgetReference _musicVideoEp1;
		private inkCompoundWidgetReference _creditsAnimEp1;
		private CInt32 _currentBinkVideo;
		private inkVideoWidgetSummary _videoSummary;
		private CBool _isDataSet;
		private CFloat _accumulatedTime;
		private CBool _isCounting;

		[Ordinal(28)] 
		[RED("videoContainer")] 
		public inkCompoundWidgetReference VideoContainer
		{
			get => GetProperty(ref _videoContainer);
			set => SetProperty(ref _videoContainer, value);
		}

		[Ordinal(29)] 
		[RED("sceneTexture")] 
		public inkImageWidgetReference SceneTexture
		{
			get => GetProperty(ref _sceneTexture);
			set => SetProperty(ref _sceneTexture, value);
		}

		[Ordinal(30)] 
		[RED("backgroundVideo")] 
		public inkVideoWidgetReference BackgroundVideo
		{
			get => GetProperty(ref _backgroundVideo);
			set => SetProperty(ref _backgroundVideo, value);
		}

		[Ordinal(31)] 
		[RED("binkVideo")] 
		public inkVideoWidgetReference BinkVideo
		{
			get => GetProperty(ref _binkVideo);
			set => SetProperty(ref _binkVideo, value);
		}

		[Ordinal(32)] 
		[RED("binkVideos")] 
		public CArray<gameuiBinkResource> BinkVideos
		{
			get => GetProperty(ref _binkVideos);
			set => SetProperty(ref _binkVideos, value);
		}

		[Ordinal(33)] 
		[RED("fastForward")] 
		public inkTextWidgetReference FastForward
		{
			get => GetProperty(ref _fastForward);
			set => SetProperty(ref _fastForward, value);
		}

		[Ordinal(34)] 
		[RED("timerUntilFadeEp1")] 
		public CFloat TimerUntilFadeEp1
		{
			get => GetProperty(ref _timerUntilFadeEp1);
			set => SetProperty(ref _timerUntilFadeEp1, value);
		}

		[Ordinal(35)] 
		[RED("musicVideoEp1")] 
		public inkVideoWidgetReference MusicVideoEp1
		{
			get => GetProperty(ref _musicVideoEp1);
			set => SetProperty(ref _musicVideoEp1, value);
		}

		[Ordinal(36)] 
		[RED("creditsAnimEp1")] 
		public inkCompoundWidgetReference CreditsAnimEp1
		{
			get => GetProperty(ref _creditsAnimEp1);
			set => SetProperty(ref _creditsAnimEp1, value);
		}

		[Ordinal(37)] 
		[RED("currentBinkVideo")] 
		public CInt32 CurrentBinkVideo
		{
			get => GetProperty(ref _currentBinkVideo);
			set => SetProperty(ref _currentBinkVideo, value);
		}

		[Ordinal(38)] 
		[RED("videoSummary")] 
		public inkVideoWidgetSummary VideoSummary
		{
			get => GetProperty(ref _videoSummary);
			set => SetProperty(ref _videoSummary, value);
		}

		[Ordinal(39)] 
		[RED("isDataSet")] 
		public CBool IsDataSet
		{
			get => GetProperty(ref _isDataSet);
			set => SetProperty(ref _isDataSet, value);
		}

		[Ordinal(40)] 
		[RED("accumulatedTime")] 
		public CFloat AccumulatedTime
		{
			get => GetProperty(ref _accumulatedTime);
			set => SetProperty(ref _accumulatedTime, value);
		}

		[Ordinal(41)] 
		[RED("isCounting")] 
		public CBool IsCounting
		{
			get => GetProperty(ref _isCounting);
			set => SetProperty(ref _isCounting, value);
		}

		public CreditsGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
