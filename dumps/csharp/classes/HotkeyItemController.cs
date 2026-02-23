using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyItemController : GenericHotkeyController
	{
		private inkWidgetReference _hotkeyItemSlot;
		private wCHandle<inkWidget> _hotkeyItemWidget;
		private wCHandle<InventoryItemDisplayController> _hotkeyItemController;
		private gameInventoryItemData _currentItem;
		private wCHandle<gameIBlackboard> _hotkeyBlackboard;
		private CHandle<redCallbackObject> _hotkeyCallbackID;
		private CHandle<redCallbackObject> _holocallCallback;
		private wCHandle<EquipmentSystem> _equipmentSystem;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private CHandle<inkanimProxy> _dpadAnim;

		[Ordinal(25)] 
		[RED("hotkeyItemSlot")] 
		public inkWidgetReference HotkeyItemSlot
		{
			get => GetProperty(ref _hotkeyItemSlot);
			set => SetProperty(ref _hotkeyItemSlot, value);
		}

		[Ordinal(26)] 
		[RED("hotkeyItemWidget")] 
		public wCHandle<inkWidget> HotkeyItemWidget
		{
			get => GetProperty(ref _hotkeyItemWidget);
			set => SetProperty(ref _hotkeyItemWidget, value);
		}

		[Ordinal(27)] 
		[RED("hotkeyItemController")] 
		public wCHandle<InventoryItemDisplayController> HotkeyItemController_
		{
			get => GetProperty(ref _hotkeyItemController);
			set => SetProperty(ref _hotkeyItemController, value);
		}

		[Ordinal(28)] 
		[RED("currentItem")] 
		public gameInventoryItemData CurrentItem
		{
			get => GetProperty(ref _currentItem);
			set => SetProperty(ref _currentItem, value);
		}

		[Ordinal(29)] 
		[RED("hotkeyBlackboard")] 
		public wCHandle<gameIBlackboard> HotkeyBlackboard
		{
			get => GetProperty(ref _hotkeyBlackboard);
			set => SetProperty(ref _hotkeyBlackboard, value);
		}

		[Ordinal(30)] 
		[RED("hotkeyCallbackID")] 
		public CHandle<redCallbackObject> HotkeyCallbackID
		{
			get => GetProperty(ref _hotkeyCallbackID);
			set => SetProperty(ref _hotkeyCallbackID, value);
		}

		[Ordinal(31)] 
		[RED("holocallCallback")] 
		public CHandle<redCallbackObject> HolocallCallback
		{
			get => GetProperty(ref _holocallCallback);
			set => SetProperty(ref _holocallCallback, value);
		}

		[Ordinal(32)] 
		[RED("equipmentSystem")] 
		public wCHandle<EquipmentSystem> EquipmentSystem
		{
			get => GetProperty(ref _equipmentSystem);
			set => SetProperty(ref _equipmentSystem, value);
		}

		[Ordinal(33)] 
		[RED("inventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(34)] 
		[RED("dpadAnim")] 
		public CHandle<inkanimProxy> DpadAnim
		{
			get => GetProperty(ref _dpadAnim);
			set => SetProperty(ref _dpadAnim, value);
		}

		public HotkeyItemController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
