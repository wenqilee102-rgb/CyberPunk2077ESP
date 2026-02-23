using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiTrialPeriodTimerController : inkGenericSystemNotificationLogicController
	{
		private inkTextWidgetReference _timerText;

		[Ordinal(9)] 
		[RED("timerText")] 
		public inkTextWidgetReference TimerText
		{
			get => GetProperty(ref _timerText);
			set => SetProperty(ref _timerText, value);
		}

		public gameuiTrialPeriodTimerController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
