using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemDisplayPressEvent : redEvent
	{
		private wCHandle<InventoryItemDisplayController> _display;
		private CHandle<inkActionName> _actionName;

		[Ordinal(0)] 
		[RED("display")] 
		public wCHandle<InventoryItemDisplayController> Display
		{
			get => GetProperty(ref _display);
			set => SetProperty(ref _display, value);
		}

		[Ordinal(1)] 
		[RED("actionName")] 
		public CHandle<inkActionName> ActionName
		{
			get => GetProperty(ref _actionName);
			set => SetProperty(ref _actionName, value);
		}

		public ItemDisplayPressEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
