using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleCustomTemplatePersistentData : CVariable
	{
		private TweakDBID _vehicleID;
		private SavedVehicleVisualCustomizationTemplate _template;

		[Ordinal(0)] 
		[RED("vehicleID")] 
		public TweakDBID VehicleID
		{
			get => GetProperty(ref _vehicleID);
			set => SetProperty(ref _vehicleID, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public SavedVehicleVisualCustomizationTemplate Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		public VehicleCustomTemplatePersistentData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
