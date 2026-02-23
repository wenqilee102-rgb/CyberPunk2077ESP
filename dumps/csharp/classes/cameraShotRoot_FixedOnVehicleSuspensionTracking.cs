using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotRoot_FixedOnVehicleSuspensionTracking : cameraShotRoot_FixedOnVehicle
	{
		private Transform _offsetFromChassis;

		[Ordinal(6)] 
		[RED("offsetFromChassis")] 
		public Transform OffsetFromChassis
		{
			get => GetProperty(ref _offsetFromChassis);
			set => SetProperty(ref _offsetFromChassis, value);
		}

		public cameraShotRoot_FixedOnVehicleSuspensionTracking(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
