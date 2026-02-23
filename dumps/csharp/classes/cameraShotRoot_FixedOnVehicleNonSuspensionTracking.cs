using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotRoot_FixedOnVehicleNonSuspensionTracking : cameraShotRoot_FixedOnVehicle
	{
		private Transform _offsetFromCar;

		[Ordinal(6)] 
		[RED("offsetFromCar")] 
		public Transform OffsetFromCar
		{
			get => GetProperty(ref _offsetFromCar);
			set => SetProperty(ref _offsetFromCar, value);
		}

		public cameraShotRoot_FixedOnVehicleNonSuspensionTracking(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
