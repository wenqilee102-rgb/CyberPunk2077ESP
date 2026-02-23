using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleForceBrakesQuickhackEvent : gameActionEvent
	{
		private CFloat _alarmDuration;
		private CBool _active;

		[Ordinal(4)] 
		[RED("alarmDuration")] 
		public CFloat AlarmDuration
		{
			get => GetProperty(ref _alarmDuration);
			set => SetProperty(ref _alarmDuration, value);
		}

		[Ordinal(5)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		public vehicleForceBrakesQuickhackEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
