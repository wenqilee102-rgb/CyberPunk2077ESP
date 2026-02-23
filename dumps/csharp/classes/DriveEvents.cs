using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DriveEvents : VehicleEventsTransition
	{
		private CBool _inCombatBlockingForbiddenZone;

		[Ordinal(4)] 
		[RED("inCombatBlockingForbiddenZone")] 
		public CBool InCombatBlockingForbiddenZone
		{
			get => GetProperty(ref _inCombatBlockingForbiddenZone);
			set => SetProperty(ref _inCombatBlockingForbiddenZone, value);
		}

		public DriveEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
