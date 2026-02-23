using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreferredAreaItems : IScriptable
	{
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataItemType> _itemType;
		private CArray<wCHandle<UIInventoryItem>> _items;

		[Ordinal(0)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(1)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<wCHandle<UIInventoryItem>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public InventoryItemPreferredAreaItems(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
