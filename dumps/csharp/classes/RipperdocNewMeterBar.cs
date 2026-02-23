using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocNewMeterBar : inkWidgetLogicController
	{
		private inkWidgetReference _bar;
		private inkWidgetReference _overchargeHighlight;
		private wCHandle<inkWidget> _root;
		private CHandle<inkanimProxy> _sizeAnimation;
		private CFloat _meterWidth;
		private CHandle<PulseAnimation> _pulse;

		[Ordinal(1)] 
		[RED("bar")] 
		public inkWidgetReference Bar
		{
			get => GetProperty(ref _bar);
			set => SetProperty(ref _bar, value);
		}

		[Ordinal(2)] 
		[RED("overchargeHighlight")] 
		public inkWidgetReference OverchargeHighlight
		{
			get => GetProperty(ref _overchargeHighlight);
			set => SetProperty(ref _overchargeHighlight, value);
		}

		[Ordinal(3)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(4)] 
		[RED("sizeAnimation")] 
		public CHandle<inkanimProxy> SizeAnimation
		{
			get => GetProperty(ref _sizeAnimation);
			set => SetProperty(ref _sizeAnimation, value);
		}

		[Ordinal(5)] 
		[RED("meterWidth")] 
		public CFloat MeterWidth
		{
			get => GetProperty(ref _meterWidth);
			set => SetProperty(ref _meterWidth, value);
		}

		[Ordinal(6)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		public RipperdocNewMeterBar(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
