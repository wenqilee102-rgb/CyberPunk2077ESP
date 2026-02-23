using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipModuleController : inkWidgetLogicController
	{
		private inkWidgetReference _lineWidget;
		private CHandle<ItemDisplayContextData> _displayContext;
		private CEnum<InventoryTooltipDisplayContext> _tooltipDisplayContext;
		private CEnum<gameItemDisplayContext> _itemDisplayContext;

		[Ordinal(1)] 
		[RED("lineWidget")] 
		public inkWidgetReference LineWidget
		{
			get => GetProperty(ref _lineWidget);
			set => SetProperty(ref _lineWidget, value);
		}

		[Ordinal(2)] 
		[RED("displayContext")] 
		public CHandle<ItemDisplayContextData> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(3)] 
		[RED("tooltipDisplayContext")] 
		public CEnum<InventoryTooltipDisplayContext> TooltipDisplayContext
		{
			get => GetProperty(ref _tooltipDisplayContext);
			set => SetProperty(ref _tooltipDisplayContext, value);
		}

		[Ordinal(4)] 
		[RED("itemDisplayContext")] 
		public CEnum<gameItemDisplayContext> ItemDisplayContext
		{
			get => GetProperty(ref _itemDisplayContext);
			set => SetProperty(ref _itemDisplayContext, value);
		}

		public NewItemTooltipModuleController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
