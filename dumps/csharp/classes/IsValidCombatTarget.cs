using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsValidCombatTarget : AIbehaviorconditionScript
	{
		private CBool _considerSourceAVehicleDriver;

		[Ordinal(0)] 
		[RED("considerSourceAVehicleDriver")] 
		public CBool ConsiderSourceAVehicleDriver
		{
			get => GetProperty(ref _considerSourceAVehicleDriver);
			set => SetProperty(ref _considerSourceAVehicleDriver, value);
		}

		public IsValidCombatTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
