using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleCustomization : entIComponent
	{
		private CArray<vehicleVehicleAppearanceToDecalsName> _defaultDecalsPerAppearance;

		[Ordinal(3)] 
		[RED("defaultDecalsPerAppearance")] 
		public CArray<vehicleVehicleAppearanceToDecalsName> DefaultDecalsPerAppearance
		{
			get => GetProperty(ref _defaultDecalsPerAppearance);
			set => SetProperty(ref _defaultDecalsPerAppearance, value);
		}

		public vehicleVehicleCustomization(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
