using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BackpackEquipSlotChooserData : inkGameNotificationData
	{
		private wCHandle<UIInventoryItem> _item;
		private CHandle<UIInventoryScriptableSystem> _inventoryScriptableSystem;

		[Ordinal(7)] 
		[RED("item")] 
		public wCHandle<UIInventoryItem> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(8)] 
		[RED("inventoryScriptableSystem")] 
		public CHandle<UIInventoryScriptableSystem> InventoryScriptableSystem
		{
			get => GetProperty(ref _inventoryScriptableSystem);
			set => SetProperty(ref _inventoryScriptableSystem, value);
		}

		public BackpackEquipSlotChooserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
