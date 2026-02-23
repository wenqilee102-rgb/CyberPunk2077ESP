using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CarryEvents : CarriedObjectEvents
	{
		private CHandle<gameStatModifierData_Deprecated> _knockdownImmunityModifier;

		[Ordinal(9)] 
		[RED("knockdownImmunityModifier")] 
		public CHandle<gameStatModifierData_Deprecated> KnockdownImmunityModifier
		{
			get => GetProperty(ref _knockdownImmunityModifier);
			set => SetProperty(ref _knockdownImmunityModifier, value);
		}

		public CarryEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
