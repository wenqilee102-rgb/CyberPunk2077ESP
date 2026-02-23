using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehiclePartsClearCoatOverrides : CVariable
	{
		private CArray<CName> _partsName;
		private vehicleVehicleClearCoatOverrides _overrides;

		[Ordinal(0)] 
		[RED("partsName")] 
		public CArray<CName> PartsName
		{
			get => GetProperty(ref _partsName);
			set => SetProperty(ref _partsName, value);
		}

		[Ordinal(1)] 
		[RED("overrides")] 
		public vehicleVehicleClearCoatOverrides Overrides
		{
			get => GetProperty(ref _overrides);
			set => SetProperty(ref _overrides, value);
		}

		public vehicleVehiclePartsClearCoatOverrides(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
