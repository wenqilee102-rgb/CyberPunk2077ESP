using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendScreenshotBatchData : CVariable
	{
		private AbsolutePathSerializable _batchPositionsPath;
		private CFloat _delayTime;
		private CUInt32 _numberOfCoordinatesToDump;
		private CBool _mergeScreenshots;
		private CEnum<rendEStreamingObserverMode> _streamingObserverMode;

		[Ordinal(0)] 
		[RED("batchPositionsPath")] 
		public AbsolutePathSerializable BatchPositionsPath
		{
			get => GetProperty(ref _batchPositionsPath);
			set => SetProperty(ref _batchPositionsPath, value);
		}

		[Ordinal(1)] 
		[RED("delayTime")] 
		public CFloat DelayTime
		{
			get => GetProperty(ref _delayTime);
			set => SetProperty(ref _delayTime, value);
		}

		[Ordinal(2)] 
		[RED("numberOfCoordinatesToDump")] 
		public CUInt32 NumberOfCoordinatesToDump
		{
			get => GetProperty(ref _numberOfCoordinatesToDump);
			set => SetProperty(ref _numberOfCoordinatesToDump, value);
		}

		[Ordinal(3)] 
		[RED("mergeScreenshots")] 
		public CBool MergeScreenshots
		{
			get => GetProperty(ref _mergeScreenshots);
			set => SetProperty(ref _mergeScreenshots, value);
		}

		[Ordinal(4)] 
		[RED("streamingObserverMode")] 
		public CEnum<rendEStreamingObserverMode> StreamingObserverMode
		{
			get => GetProperty(ref _streamingObserverMode);
			set => SetProperty(ref _streamingObserverMode, value);
		}

		public rendScreenshotBatchData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
