using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ScannerVehicleCustomizationTemplate : ScannerChunk
	{
		private VehicleVisualCustomizationTemplate _vehicleCustomizationTemplate;
		private CBool _profileRestricted;
		private CName _modelName;

		[Ordinal(0)] 
		[RED("VehicleCustomizationTemplate")] 
		public VehicleVisualCustomizationTemplate VehicleCustomizationTemplate
		{
			get => GetProperty(ref _vehicleCustomizationTemplate);
			set => SetProperty(ref _vehicleCustomizationTemplate, value);
		}

		[Ordinal(1)] 
		[RED("ProfileRestricted")] 
		public CBool ProfileRestricted
		{
			get => GetProperty(ref _profileRestricted);
			set => SetProperty(ref _profileRestricted, value);
		}

		[Ordinal(2)] 
		[RED("ModelName")] 
		public CName ModelName
		{
			get => GetProperty(ref _modelName);
			set => SetProperty(ref _modelName, value);
		}

		public ScannerVehicleCustomizationTemplate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
