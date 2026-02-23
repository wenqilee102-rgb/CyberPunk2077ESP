using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryScriptableEquipmentListener : IScriptable
	{
		private wCHandle<UIInventoryScriptableSystem> _uiInventoryScriptableSystem;
		private wCHandle<gameIBlackboard> _equipmentBlackboard;
		private CHandle<redCallbackObject> _itemEquippedListener;

		[Ordinal(0)] 
		[RED("uiInventoryScriptableSystem")] 
		public wCHandle<UIInventoryScriptableSystem> UiInventoryScriptableSystem
		{
			get => GetProperty(ref _uiInventoryScriptableSystem);
			set => SetProperty(ref _uiInventoryScriptableSystem, value);
		}

		[Ordinal(1)] 
		[RED("EquipmentBlackboard")] 
		public wCHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetProperty(ref _equipmentBlackboard);
			set => SetProperty(ref _equipmentBlackboard, value);
		}

		[Ordinal(2)] 
		[RED("itemEquippedListener")] 
		public CHandle<redCallbackObject> ItemEquippedListener
		{
			get => GetProperty(ref _itemEquippedListener);
			set => SetProperty(ref _itemEquippedListener, value);
		}

		public UIInventoryScriptableEquipmentListener(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
