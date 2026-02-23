using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VideoCarouselController : inkWidgetLogicController
	{
		private inkTextWidgetReference _videoTitleRef;
		private inkTextWidgetReference _videoDescriptionRef;
		private inkVideoWidgetReference _videoWidgetRef;
		private inkWidgetReference _switchLeftArrow;
		private inkWidgetReference _switchRightArrow;
		private CArray<inkWidgetReference> _switchDotIndicators;
		private wCHandle<inkVideoWidget> _videoWidget;
		private wCHandle<inkButtonController> _videoSwitchLeftArrow;
		private wCHandle<inkButtonController> _videoSwitchRightArrow;
		private CArray<VideoCarouselData> _videos;
		private CInt32 _currentVideo;
		private CBool _isPaused;

		[Ordinal(1)] 
		[RED("videoTitleRef")] 
		public inkTextWidgetReference VideoTitleRef
		{
			get => GetProperty(ref _videoTitleRef);
			set => SetProperty(ref _videoTitleRef, value);
		}

		[Ordinal(2)] 
		[RED("videoDescriptionRef")] 
		public inkTextWidgetReference VideoDescriptionRef
		{
			get => GetProperty(ref _videoDescriptionRef);
			set => SetProperty(ref _videoDescriptionRef, value);
		}

		[Ordinal(3)] 
		[RED("videoWidgetRef")] 
		public inkVideoWidgetReference VideoWidgetRef
		{
			get => GetProperty(ref _videoWidgetRef);
			set => SetProperty(ref _videoWidgetRef, value);
		}

		[Ordinal(4)] 
		[RED("switchLeftArrow")] 
		public inkWidgetReference SwitchLeftArrow
		{
			get => GetProperty(ref _switchLeftArrow);
			set => SetProperty(ref _switchLeftArrow, value);
		}

		[Ordinal(5)] 
		[RED("switchRightArrow")] 
		public inkWidgetReference SwitchRightArrow
		{
			get => GetProperty(ref _switchRightArrow);
			set => SetProperty(ref _switchRightArrow, value);
		}

		[Ordinal(6)] 
		[RED("switchDotIndicators")] 
		public CArray<inkWidgetReference> SwitchDotIndicators
		{
			get => GetProperty(ref _switchDotIndicators);
			set => SetProperty(ref _switchDotIndicators, value);
		}

		[Ordinal(7)] 
		[RED("videoWidget")] 
		public wCHandle<inkVideoWidget> VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		[Ordinal(8)] 
		[RED("videoSwitchLeftArrow")] 
		public wCHandle<inkButtonController> VideoSwitchLeftArrow
		{
			get => GetProperty(ref _videoSwitchLeftArrow);
			set => SetProperty(ref _videoSwitchLeftArrow, value);
		}

		[Ordinal(9)] 
		[RED("videoSwitchRightArrow")] 
		public wCHandle<inkButtonController> VideoSwitchRightArrow
		{
			get => GetProperty(ref _videoSwitchRightArrow);
			set => SetProperty(ref _videoSwitchRightArrow, value);
		}

		[Ordinal(10)] 
		[RED("videos")] 
		public CArray<VideoCarouselData> Videos
		{
			get => GetProperty(ref _videos);
			set => SetProperty(ref _videos, value);
		}

		[Ordinal(11)] 
		[RED("currentVideo")] 
		public CInt32 CurrentVideo
		{
			get => GetProperty(ref _currentVideo);
			set => SetProperty(ref _currentVideo, value);
		}

		[Ordinal(12)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetProperty(ref _isPaused);
			set => SetProperty(ref _isPaused, value);
		}

		public VideoCarouselController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
