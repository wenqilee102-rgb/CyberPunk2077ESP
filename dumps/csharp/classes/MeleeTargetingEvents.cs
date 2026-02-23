using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeTargetingEvents : MeleeEventsTransition
	{
		private CFloat _aimInTimeRemaining;

		[Ordinal(2)] 
		[RED("aimInTimeRemaining")] 
		public CFloat AimInTimeRemaining
		{
			get => GetProperty(ref _aimInTimeRemaining);
			set => SetProperty(ref _aimInTimeRemaining, value);
		}

		public MeleeTargetingEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
