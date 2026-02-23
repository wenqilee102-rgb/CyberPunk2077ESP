using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VideoCarouselData : CVariable
	{
		private CName _videoTitleKey;
		private CName _videoDescriptionKey;
		private redResourceReferenceScriptToken _videoResPath;

		[Ordinal(0)] 
		[RED("videoTitleKey")] 
		public CName VideoTitleKey
		{
			get => GetProperty(ref _videoTitleKey);
			set => SetProperty(ref _videoTitleKey, value);
		}

		[Ordinal(1)] 
		[RED("videoDescriptionKey")] 
		public CName VideoDescriptionKey
		{
			get => GetProperty(ref _videoDescriptionKey);
			set => SetProperty(ref _videoDescriptionKey, value);
		}

		[Ordinal(2)] 
		[RED("videoResPath")] 
		public redResourceReferenceScriptToken VideoResPath
		{
			get => GetProperty(ref _videoResPath);
			set => SetProperty(ref _videoResPath, value);
		}

		public VideoCarouselData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
