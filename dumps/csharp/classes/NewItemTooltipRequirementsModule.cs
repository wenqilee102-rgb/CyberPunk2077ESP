using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipRequirementsModule : NewItemTooltipModuleController
	{
		private inkWidgetReference _smartlinkGunWrapper;
		private inkWidgetReference _line;

		[Ordinal(5)] 
		[RED("smartlinkGunWrapper")] 
		public inkWidgetReference SmartlinkGunWrapper
		{
			get => GetProperty(ref _smartlinkGunWrapper);
			set => SetProperty(ref _smartlinkGunWrapper, value);
		}

		[Ordinal(6)] 
		[RED("line")] 
		public inkWidgetReference Line
		{
			get => GetProperty(ref _line);
			set => SetProperty(ref _line, value);
		}

		public NewItemTooltipRequirementsModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
