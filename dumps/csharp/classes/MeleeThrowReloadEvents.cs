using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeThrowReloadEvents : MeleeEventsTransition
	{
		private CBool _isSwitchingWeapon;

		[Ordinal(2)] 
		[RED("isSwitchingWeapon")] 
		public CBool IsSwitchingWeapon
		{
			get => GetProperty(ref _isSwitchingWeapon);
			set => SetProperty(ref _isSwitchingWeapon, value);
		}

		public MeleeThrowReloadEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
