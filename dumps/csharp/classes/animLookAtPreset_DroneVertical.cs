using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animLookAtPreset_DroneVertical : animLookAtPreset
	{
		private CFloat _softLimitDegrees;
		private CFloat _hardLimitDegrees;
		private CFloat _hardLimitDistance;
		private CFloat _backLimitDegrees;
		private CFloat _suppress;
		private CInt32 _mode;

		[Ordinal(0)] 
		[RED("softLimitDegrees")] 
		public CFloat SoftLimitDegrees
		{
			get => GetProperty(ref _softLimitDegrees);
			set => SetProperty(ref _softLimitDegrees, value);
		}

		[Ordinal(1)] 
		[RED("hardLimitDegrees")] 
		public CFloat HardLimitDegrees
		{
			get => GetProperty(ref _hardLimitDegrees);
			set => SetProperty(ref _hardLimitDegrees, value);
		}

		[Ordinal(2)] 
		[RED("hardLimitDistance")] 
		public CFloat HardLimitDistance
		{
			get => GetProperty(ref _hardLimitDistance);
			set => SetProperty(ref _hardLimitDistance, value);
		}

		[Ordinal(3)] 
		[RED("backLimitDegrees")] 
		public CFloat BackLimitDegrees
		{
			get => GetProperty(ref _backLimitDegrees);
			set => SetProperty(ref _backLimitDegrees, value);
		}

		[Ordinal(4)] 
		[RED("suppress")] 
		public CFloat Suppress
		{
			get => GetProperty(ref _suppress);
			set => SetProperty(ref _suppress, value);
		}

		[Ordinal(5)] 
		[RED("mode")] 
		public CInt32 Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		public animLookAtPreset_DroneVertical(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
