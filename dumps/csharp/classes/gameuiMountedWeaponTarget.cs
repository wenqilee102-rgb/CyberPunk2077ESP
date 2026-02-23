using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMountedWeaponTarget : CVariable
	{
		private CInt32 _weaponIndex;
		private Vector4 _targetLocation;

		[Ordinal(0)] 
		[RED("weaponIndex")] 
		public CInt32 WeaponIndex
		{
			get => GetProperty(ref _weaponIndex);
			set => SetProperty(ref _weaponIndex, value);
		}

		[Ordinal(1)] 
		[RED("targetLocation")] 
		public Vector4 TargetLocation
		{
			get => GetProperty(ref _targetLocation);
			set => SetProperty(ref _targetLocation, value);
		}

		public gameuiMountedWeaponTarget(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
