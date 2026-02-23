using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StoreVisualCustomizationDataForIDEvent : redEvent
	{
		private TweakDBID _vehicleID;
		private VehicleVisualCustomizationTemplate _template;

		[Ordinal(0)] 
		[RED("vehicleID")] 
		public TweakDBID VehicleID
		{
			get => GetProperty(ref _vehicleID);
			set => SetProperty(ref _vehicleID, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		public StoreVisualCustomizationDataForIDEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
