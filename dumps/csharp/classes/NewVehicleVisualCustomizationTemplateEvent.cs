using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewVehicleVisualCustomizationTemplateEvent : redEvent
	{
		private VehicleVisualCustomizationTemplate _template;
		private CBool _isInstant;

		[Ordinal(0)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		[Ordinal(1)] 
		[RED("isInstant")] 
		public CBool IsInstant
		{
			get => GetProperty(ref _isInstant);
			set => SetProperty(ref _isInstant, value);
		}

		public NewVehicleVisualCustomizationTemplateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
