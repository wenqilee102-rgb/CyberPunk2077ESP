using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DelayReactionToMissingPassengersEvent : redEvent
	{
		private CHandle<senseStimuliEvent> _stimEvent;
		private CBool _delayedAlready;

		[Ordinal(0)] 
		[RED("stimEvent")] 
		public CHandle<senseStimuliEvent> StimEvent
		{
			get => GetProperty(ref _stimEvent);
			set => SetProperty(ref _stimEvent, value);
		}

		[Ordinal(1)] 
		[RED("delayedAlready")] 
		public CBool DelayedAlready
		{
			get => GetProperty(ref _delayedAlready);
			set => SetProperty(ref _delayedAlready, value);
		}

		public DelayReactionToMissingPassengersEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
