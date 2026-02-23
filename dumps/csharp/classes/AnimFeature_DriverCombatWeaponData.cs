using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_DriverCombatWeaponData : animAnimFeature
	{
		private CInt32 _weaponType;

		[Ordinal(0)] 
		[RED("weaponType")] 
		public CInt32 WeaponType
		{
			get => GetProperty(ref _weaponType);
			set => SetProperty(ref _weaponType, value);
		}

		public AnimFeature_DriverCombatWeaponData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
