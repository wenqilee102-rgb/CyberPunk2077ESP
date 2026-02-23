using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetScanningAngleThreshold_NodeType : questIVisionModeNodeType
	{
		private CFloat _angleThreshold;
		private CName _debugSource;

		[Ordinal(0)] 
		[RED("angleThreshold")] 
		public CFloat AngleThreshold
		{
			get => GetProperty(ref _angleThreshold);
			set => SetProperty(ref _angleThreshold, value);
		}

		[Ordinal(1)] 
		[RED("debugSource")] 
		public CName DebugSource
		{
			get => GetProperty(ref _debugSource);
			set => SetProperty(ref _debugSource, value);
		}

		public questSetScanningAngleThreshold_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
