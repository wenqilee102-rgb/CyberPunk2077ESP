using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TwintoneOverrideData : inkGameNotificationData
	{
		private VehicleVisualCustomizationTemplate _template;
		private CName _modelName;

		[Ordinal(7)] 
		[RED("template")] 
		public VehicleVisualCustomizationTemplate Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		[Ordinal(8)] 
		[RED("modelName")] 
		public CName ModelName
		{
			get => GetProperty(ref _modelName);
			set => SetProperty(ref _modelName, value);
		}

		public TwintoneOverrideData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
