using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class minimapLayerHighlightRequestData : CVariable
	{
		private HDRColor _highlightColor;
		private CFloat _highlightDuration;
		private CFloat _blinkCount;

		[Ordinal(0)] 
		[RED("highlightColor")] 
		public HDRColor HighlightColor
		{
			get => GetProperty(ref _highlightColor);
			set => SetProperty(ref _highlightColor, value);
		}

		[Ordinal(1)] 
		[RED("highlightDuration")] 
		public CFloat HighlightDuration
		{
			get => GetProperty(ref _highlightDuration);
			set => SetProperty(ref _highlightDuration, value);
		}

		[Ordinal(2)] 
		[RED("blinkCount")] 
		public CFloat BlinkCount
		{
			get => GetProperty(ref _blinkCount);
			set => SetProperty(ref _blinkCount, value);
		}

		public minimapLayerHighlightRequestData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
