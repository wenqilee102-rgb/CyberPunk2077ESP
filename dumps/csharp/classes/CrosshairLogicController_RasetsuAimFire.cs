using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairLogicController_RasetsuAimFire : inkWidgetLogicController
	{
		private inkWidgetReference _chargebarContainer;
		private inkWidgetReference _perfectChargeIndicator;
		private wCHandle<ChargebarController> _chargeBar;
		private CHandle<inkanimProxy> _animPerfectCharge;

		[Ordinal(1)] 
		[RED("chargebarContainer")] 
		public inkWidgetReference ChargebarContainer
		{
			get => GetProperty(ref _chargebarContainer);
			set => SetProperty(ref _chargebarContainer, value);
		}

		[Ordinal(2)] 
		[RED("perfectChargeIndicator")] 
		public inkWidgetReference PerfectChargeIndicator
		{
			get => GetProperty(ref _perfectChargeIndicator);
			set => SetProperty(ref _perfectChargeIndicator, value);
		}

		[Ordinal(3)] 
		[RED("chargeBar")] 
		public wCHandle<ChargebarController> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(4)] 
		[RED("animPerfectCharge")] 
		public CHandle<inkanimProxy> AnimPerfectCharge
		{
			get => GetProperty(ref _animPerfectCharge);
			set => SetProperty(ref _animPerfectCharge, value);
		}

		public CrosshairLogicController_RasetsuAimFire(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
