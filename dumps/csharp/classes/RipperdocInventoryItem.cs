using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperdocInventoryItem : inkVirtualCompoundItemController
	{
		private inkWidgetReference _root;
		private CHandle<RipperdocWrappedUIInventoryItem> _data;
		private wCHandle<InventoryItemDisplayController> _widget;

		[Ordinal(18)] 
		[RED("root")] 
		public inkWidgetReference Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(19)] 
		[RED("data")] 
		public CHandle<RipperdocWrappedUIInventoryItem> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(20)] 
		[RED("widget")] 
		public wCHandle<InventoryItemDisplayController> Widget
		{
			get => GetProperty(ref _widget);
			set => SetProperty(ref _widget, value);
		}

		public RipperdocInventoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
