using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipDescriptionModule : NewItemTooltipModuleController
	{
		private inkTextWidgetReference _descriptionText;
		private inkMargin _defaultMargin;

		[Ordinal(5)] 
		[RED("descriptionText")] 
		public inkTextWidgetReference DescriptionText
		{
			get => GetProperty(ref _descriptionText);
			set => SetProperty(ref _descriptionText, value);
		}

		[Ordinal(6)] 
		[RED("defaultMargin")] 
		public inkMargin DefaultMargin
		{
			get => GetProperty(ref _defaultMargin);
			set => SetProperty(ref _defaultMargin, value);
		}

		public NewItemTooltipDescriptionModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
