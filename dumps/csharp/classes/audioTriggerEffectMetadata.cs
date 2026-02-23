using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioTriggerEffectMetadata : audioAudioMetadata
	{
		private CEnum<audioTriggerEffectMode> _mode;
		private CEnum<audioTriggerEffectTarget> _target;
		private CFloat _strength;
		private CFloat _startPosition;
		private CFloat _endPosition;
		private CFloat _frequency;

		[Ordinal(1)] 
		[RED("mode")] 
		public CEnum<audioTriggerEffectMode> Mode
		{
			get => GetProperty(ref _mode);
			set => SetProperty(ref _mode, value);
		}

		[Ordinal(2)] 
		[RED("target")] 
		public CEnum<audioTriggerEffectTarget> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(3)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(4)] 
		[RED("startPosition")] 
		public CFloat StartPosition
		{
			get => GetProperty(ref _startPosition);
			set => SetProperty(ref _startPosition, value);
		}

		[Ordinal(5)] 
		[RED("endPosition")] 
		public CFloat EndPosition
		{
			get => GetProperty(ref _endPosition);
			set => SetProperty(ref _endPosition, value);
		}

		[Ordinal(6)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get => GetProperty(ref _frequency);
			set => SetProperty(ref _frequency, value);
		}

		public audioTriggerEffectMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
