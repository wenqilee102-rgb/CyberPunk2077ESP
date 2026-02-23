using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipAttributeRequirement : inkWidgetLogicController
	{
		private inkTextWidgetReference _labelRef;

		[Ordinal(1)] 
		[RED("labelRef")] 
		public inkTextWidgetReference LabelRef
		{
			get => GetProperty(ref _labelRef);
			set => SetProperty(ref _labelRef, value);
		}

		public ItemTooltipAttributeRequirement(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
