using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FramePS : gameObjectPS
	{
		private CUInt32 _screenshotHash;
		private CInt32 _screenshotID;
		private CFloat _screenshotUVLeft;
		private CFloat _screenshotUVRight;
		private CFloat _screenshotUVTop;
		private CFloat _screenshotUVBottom;

		[Ordinal(0)] 
		[RED("screenshotHash")] 
		public CUInt32 ScreenshotHash
		{
			get => GetProperty(ref _screenshotHash);
			set => SetProperty(ref _screenshotHash, value);
		}

		[Ordinal(1)] 
		[RED("screenshotID")] 
		public CInt32 ScreenshotID
		{
			get => GetProperty(ref _screenshotID);
			set => SetProperty(ref _screenshotID, value);
		}

		[Ordinal(2)] 
		[RED("screenshotUVLeft")] 
		public CFloat ScreenshotUVLeft
		{
			get => GetProperty(ref _screenshotUVLeft);
			set => SetProperty(ref _screenshotUVLeft, value);
		}

		[Ordinal(3)] 
		[RED("screenshotUVRight")] 
		public CFloat ScreenshotUVRight
		{
			get => GetProperty(ref _screenshotUVRight);
			set => SetProperty(ref _screenshotUVRight, value);
		}

		[Ordinal(4)] 
		[RED("screenshotUVTop")] 
		public CFloat ScreenshotUVTop
		{
			get => GetProperty(ref _screenshotUVTop);
			set => SetProperty(ref _screenshotUVTop, value);
		}

		[Ordinal(5)] 
		[RED("screenshotUVBottom")] 
		public CFloat ScreenshotUVBottom
		{
			get => GetProperty(ref _screenshotUVBottom);
			set => SetProperty(ref _screenshotUVBottom, value);
		}

		public FramePS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
