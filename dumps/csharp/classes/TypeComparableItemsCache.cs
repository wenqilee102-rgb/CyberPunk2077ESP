using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TypeComparableItemsCache : IScriptable
	{
		private CHandle<ItemComparableTypesCache> _cache;
		private CArray<gameInventoryItemData> _items;

		[Ordinal(0)] 
		[RED("cache")] 
		public CHandle<ItemComparableTypesCache> Cache
		{
			get => GetProperty(ref _cache);
			set => SetProperty(ref _cache, value);
		}

		[Ordinal(1)] 
		[RED("items")] 
		public CArray<gameInventoryItemData> Items
		{
			get => GetProperty(ref _items);
			set => SetProperty(ref _items, value);
		}

		public TypeComparableItemsCache(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
