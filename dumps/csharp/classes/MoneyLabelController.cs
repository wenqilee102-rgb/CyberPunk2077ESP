using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MoneyLabelController : inkTextValueProgressAnimationController
	{
		private CHandle<inkanimProxy> _animation;
		private CFloat _currentMoney;
		private CHandle<PulseAnimation> _pulse;

		[Ordinal(13)] 
		[RED("animation")] 
		public CHandle<inkanimProxy> Animation
		{
			get => GetProperty(ref _animation);
			set => SetProperty(ref _animation, value);
		}

		[Ordinal(14)] 
		[RED("currentMoney")] 
		public CFloat CurrentMoney
		{
			get => GetProperty(ref _currentMoney);
			set => SetProperty(ref _currentMoney, value);
		}

		[Ordinal(15)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		public MoneyLabelController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
