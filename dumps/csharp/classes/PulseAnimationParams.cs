using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PulseAnimationParams : CVariable
	{
		private CFloat _topOpacity;
		private CFloat _bottomOpacity;
		private CFloat _pulseRate;
		private CFloat _delay;

		[Ordinal(0)] 
		[RED("topOpacity")] 
		public CFloat TopOpacity
		{
			get => GetProperty(ref _topOpacity);
			set => SetProperty(ref _topOpacity, value);
		}

		[Ordinal(1)] 
		[RED("bottomOpacity")] 
		public CFloat BottomOpacity
		{
			get => GetProperty(ref _bottomOpacity);
			set => SetProperty(ref _bottomOpacity, value);
		}

		[Ordinal(2)] 
		[RED("pulseRate")] 
		public CFloat PulseRate
		{
			get => GetProperty(ref _pulseRate);
			set => SetProperty(ref _pulseRate, value);
		}

		[Ordinal(3)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetProperty(ref _delay);
			set => SetProperty(ref _delay, value);
		}

		public PulseAnimationParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
