using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTypeComparableItemsCache : IScriptable
	{
		private CEnum<gamedataItemType> _itemType;
		private CHandle<InventoryItemComparableTypesCache> _cache;
		private CArray<wCHandle<UIInventoryItem>> _items;

		[Ordinal(0)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(1)] 
		[RED("cache")] 
		public CHandle<InventoryItemComparableTypesCache> Cache
		{
			get => GetProperty(ref _cache);
			set => SetProperty(ref _cache, value);
		}

		[Ordinal(2)] 
		[RED("items")] 
		public CArray<wCHandle<UIInventoryItem>> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public InventoryTypeComparableItemsCache(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
