using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryItemPreferredComparisonResolver : IScriptable
	{
		private CArray<CHandle<InventoryItemPreferredAreaItems>> _cacheadAreaItems;
		private CArray<CHandle<InventoryItemComparableTypesCache>> _cachedComparableTypes;
		private CArray<CHandle<InventoryTypeComparableItemsCache>> _typeComparableItemsCache;
		private CHandle<UIInventoryScriptableSystem> _inventoryScriptableSystem;
		private wCHandle<UIInventoryItem> _forcedCompareItem;
		private CBool _useForceCompare;

		[Ordinal(0)] 
		[RED("cacheadAreaItems")] 
		public CArray<CHandle<InventoryItemPreferredAreaItems>> CacheadAreaItems
		{
			get => GetProperty(ref _cacheadAreaItems);
			set => SetProperty(ref _cacheadAreaItems, value);
		}

		[Ordinal(1)] 
		[RED("cachedComparableTypes")] 
		public CArray<CHandle<InventoryItemComparableTypesCache>> CachedComparableTypes
		{
			get => GetProperty(ref _cachedComparableTypes);
			set => SetProperty(ref _cachedComparableTypes, value);
		}

		[Ordinal(2)] 
		[RED("typeComparableItemsCache")] 
		public CArray<CHandle<InventoryTypeComparableItemsCache>> TypeComparableItemsCache
		{
			get => GetProperty(ref _typeComparableItemsCache);
			set => SetProperty(ref _typeComparableItemsCache, value);
		}

		[Ordinal(3)] 
		[RED("inventoryScriptableSystem")] 
		public CHandle<UIInventoryScriptableSystem> InventoryScriptableSystem
		{
			get => GetProperty(ref _inventoryScriptableSystem);
			set => SetProperty(ref _inventoryScriptableSystem, value);
		}

		[Ordinal(4)] 
		[RED("forcedCompareItem")] 
		public wCHandle<UIInventoryItem> ForcedCompareItem
		{
			get => GetProperty(ref _forcedCompareItem);
			set => SetProperty(ref _forcedCompareItem, value);
		}

		[Ordinal(5)] 
		[RED("useForceCompare")] 
		public CBool UseForceCompare
		{
			get => GetProperty(ref _useForceCompare);
			set => SetProperty(ref _useForceCompare, value);
		}

		public InventoryItemPreferredComparisonResolver(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
