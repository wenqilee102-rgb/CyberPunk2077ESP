using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DriverCombatMountedWeaponsEvents : DriverCombatEvents
	{
		private CArray<wCHandle<gameweaponObject>> _activeWeapons;

		[Ordinal(20)] 
		[RED("activeWeapons")] 
		public CArray<wCHandle<gameweaponObject>> ActiveWeapons
		{
			get => GetProperty(ref _activeWeapons);
			set => SetProperty(ref _activeWeapons, value);
		}

		public DriverCombatMountedWeaponsEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
