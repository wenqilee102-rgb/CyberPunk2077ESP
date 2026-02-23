using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_LookAtPose360 : animAnimNode_Base
	{
		private CFloat _speedInDegreesPerSecond;
		private animFloatLink _angleOffsetNode;
		private animFloatLink _targetAngleOffsetNode;
		private animFloatLink _weightNode;
		private CName _animEndEventName;
		private CName _animation;
		private CFloat _durationCut;

		[Ordinal(11)] 
		[RED("speedInDegreesPerSecond")] 
		public CFloat SpeedInDegreesPerSecond
		{
			get => GetProperty(ref _speedInDegreesPerSecond);
			set => SetProperty(ref _speedInDegreesPerSecond, value);
		}

		[Ordinal(12)] 
		[RED("angleOffsetNode")] 
		public animFloatLink AngleOffsetNode
		{
			get => GetProperty(ref _angleOffsetNode);
			set => SetProperty(ref _angleOffsetNode, value);
		}

		[Ordinal(13)] 
		[RED("targetAngleOffsetNode")] 
		public animFloatLink TargetAngleOffsetNode
		{
			get => GetProperty(ref _targetAngleOffsetNode);
			set => SetProperty(ref _targetAngleOffsetNode, value);
		}

		[Ordinal(14)] 
		[RED("weightNode")] 
		public animFloatLink WeightNode
		{
			get => GetProperty(ref _weightNode);
			set => SetProperty(ref _weightNode, value);
		}

		[Ordinal(15)] 
		[RED("animEndEventName")] 
		public CName AnimEndEventName
		{
			get => GetProperty(ref _animEndEventName);
			set => SetProperty(ref _animEndEventName, value);
		}

		[Ordinal(16)] 
		[RED("animation")] 
		public CName Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(17)] 
		[RED("durationCut")] 
		public CFloat DurationCut
		{
			get => GetProperty(ref _durationCut);
			set => SetProperty(ref _durationCut, value);
		}

		public animAnimNode_LookAtPose360(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
