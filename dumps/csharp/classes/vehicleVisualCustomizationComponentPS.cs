using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVisualCustomizationComponentPS : gameComponentPS
	{
		private CArray<VehicleCustomTemplatePersistentData> _storedAppliedVisualCustomization;
		private CArray<GenericTemplatePersistentData> _storedGenericVisualCustomizationTemplates;
		private CArray<VehicleUniqueTemplatePersistentData> _storedUniqueVisualCustomizationTemplates;
		private CArray<vehicleVisualCustomizationPersistentData> _storedVisualCustomizationData;

		[Ordinal(0)] 
		[RED("storedAppliedVisualCustomization")] 
		public CArray<VehicleCustomTemplatePersistentData> StoredAppliedVisualCustomization
		{
			get => GetProperty(ref _storedAppliedVisualCustomization);
			set => SetProperty(ref _storedAppliedVisualCustomization, value);
		}

		[Ordinal(1)] 
		[RED("storedGenericVisualCustomizationTemplates")] 
		public CArray<GenericTemplatePersistentData> StoredGenericVisualCustomizationTemplates
		{
			get => GetProperty(ref _storedGenericVisualCustomizationTemplates);
			set => SetProperty(ref _storedGenericVisualCustomizationTemplates, value);
		}

		[Ordinal(2)] 
		[RED("storedUniqueVisualCustomizationTemplates")] 
		public CArray<VehicleUniqueTemplatePersistentData> StoredUniqueVisualCustomizationTemplates
		{
			get => GetProperty(ref _storedUniqueVisualCustomizationTemplates);
			set => SetProperty(ref _storedUniqueVisualCustomizationTemplates, value);
		}

		[Ordinal(3)] 
		[RED("storedVisualCustomizationData")] 
		public CArray<vehicleVisualCustomizationPersistentData> StoredVisualCustomizationData
		{
			get => GetProperty(ref _storedVisualCustomizationData);
			set => SetProperty(ref _storedVisualCustomizationData, value);
		}

		public vehicleVisualCustomizationComponentPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
