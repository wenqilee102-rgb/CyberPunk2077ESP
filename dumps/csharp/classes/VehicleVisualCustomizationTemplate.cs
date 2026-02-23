using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleVisualCustomizationTemplate : CVariable
	{
		private CBool _hasUniqueTemplate;
		private GenericTemplatePersistentData _genericData;
		private UniqueTemplateData _uniqueData;

		[Ordinal(0)] 
		[RED("hasUniqueTemplate")] 
		public CBool HasUniqueTemplate
		{
			get => GetProperty(ref _hasUniqueTemplate);
			set => SetProperty(ref _hasUniqueTemplate, value);
		}

		[Ordinal(1)] 
		[RED("genericData")] 
		public GenericTemplatePersistentData GenericData
		{
			get => GetProperty(ref _genericData);
			set => SetProperty(ref _genericData, value);
		}

		[Ordinal(2)] 
		[RED("uniqueData")] 
		public UniqueTemplateData UniqueData
		{
			get => GetProperty(ref _uniqueData);
			set => SetProperty(ref _uniqueData, value);
		}

		public VehicleVisualCustomizationTemplate(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
