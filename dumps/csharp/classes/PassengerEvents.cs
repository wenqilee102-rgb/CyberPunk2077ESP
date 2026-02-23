using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassengerEvents : VehicleEventsTransition
	{
		private CBool _noWeaponsRestrictionApplied;

		[Ordinal(4)] 
		[RED("noWeaponsRestrictionApplied")] 
		public CBool NoWeaponsRestrictionApplied
		{
			get => GetProperty(ref _noWeaponsRestrictionApplied);
			set => SetProperty(ref _noWeaponsRestrictionApplied, value);
		}

		public PassengerEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
