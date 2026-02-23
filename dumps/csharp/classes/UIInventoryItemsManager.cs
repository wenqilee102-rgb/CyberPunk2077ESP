using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemsManager : IScriptable
	{
		private CHandle<gameuiIconsNameResolver> _iconsNameResolver;
		private CBool _useMaleIcons;
		private CHandle<inkScriptIntHashMap> _ammoTypeCache;
		private CHandle<inkScriptWeakHashMap> _statsMapCache;
		private CHandle<inkScriptHashMap> _statsPropertiesCache;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<gameTransactionSystem> _transactionSystem;
		private CHandle<gameStatsDataSystem> _statsDataSystem;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<gameInventoryManager> _inventoryManager;
		private CBool _equippedItemsFetched;
		private CArray<gameItemID> _equippedItems;
		private CBool _transmogItemsFetched;
		private CArray<gameItemID> _transmogItems;
		private CArray<CHandle<WeaponMaxStatValueData>> _maxStatValuesData;
		private CArray<CName> _notSellableTags;
		private CBool _tEMP_cuverBarsEnabled;
		private CBool _tEMP_separatorBarsEnabled;

		[Ordinal(0)] 
		[RED("iconsNameResolver")] 
		public CHandle<gameuiIconsNameResolver> IconsNameResolver
		{
			get => GetProperty(ref _iconsNameResolver);
			set => SetProperty(ref _iconsNameResolver, value);
		}

		[Ordinal(1)] 
		[RED("useMaleIcons")] 
		public CBool UseMaleIcons
		{
			get => GetProperty(ref _useMaleIcons);
			set => SetProperty(ref _useMaleIcons, value);
		}

		[Ordinal(2)] 
		[RED("ammoTypeCache")] 
		public CHandle<inkScriptIntHashMap> AmmoTypeCache
		{
			get => GetProperty(ref _ammoTypeCache);
			set => SetProperty(ref _ammoTypeCache, value);
		}

		[Ordinal(3)] 
		[RED("statsMapCache")] 
		public CHandle<inkScriptWeakHashMap> StatsMapCache
		{
			get => GetProperty(ref _statsMapCache);
			set => SetProperty(ref _statsMapCache, value);
		}

		[Ordinal(4)] 
		[RED("statsPropertiesCache")] 
		public CHandle<inkScriptHashMap> StatsPropertiesCache
		{
			get => GetProperty(ref _statsPropertiesCache);
			set => SetProperty(ref _statsPropertiesCache, value);
		}

		[Ordinal(5)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(6)] 
		[RED("transactionSystem")] 
		public CHandle<gameTransactionSystem> TransactionSystem
		{
			get => GetProperty(ref _transactionSystem);
			set => SetProperty(ref _transactionSystem, value);
		}

		[Ordinal(7)] 
		[RED("statsDataSystem")] 
		public CHandle<gameStatsDataSystem> StatsDataSystem
		{
			get => GetProperty(ref _statsDataSystem);
			set => SetProperty(ref _statsDataSystem, value);
		}

		[Ordinal(8)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(9)] 
		[RED("inventoryManager")] 
		public wCHandle<gameInventoryManager> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(10)] 
		[RED("equippedItemsFetched")] 
		public CBool EquippedItemsFetched
		{
			get => GetProperty(ref _equippedItemsFetched);
			set => SetProperty(ref _equippedItemsFetched, value);
		}

		[Ordinal(11)] 
		[RED("equippedItems")] 
		public CArray<gameItemID> EquippedItems
		{
			get => GetProperty(ref _equippedItems);
			set => SetProperty(ref _equippedItems, value);
		}

		[Ordinal(12)] 
		[RED("transmogItemsFetched")] 
		public CBool TransmogItemsFetched
		{
			get => GetProperty(ref _transmogItemsFetched);
			set => SetProperty(ref _transmogItemsFetched, value);
		}

		[Ordinal(13)] 
		[RED("transmogItems")] 
		public CArray<gameItemID> TransmogItems
		{
			get => GetProperty(ref _transmogItems);
			set => SetProperty(ref _transmogItems, value);
		}

		[Ordinal(14)] 
		[RED("maxStatValuesData")] 
		public CArray<CHandle<WeaponMaxStatValueData>> MaxStatValuesData
		{
			get => GetProperty(ref _maxStatValuesData);
			set => SetProperty(ref _maxStatValuesData, value);
		}

		[Ordinal(15)] 
		[RED("notSellableTags")] 
		public CArray<CName> NotSellableTags
		{
			get => GetProperty(ref _notSellableTags);
			set => SetProperty(ref _notSellableTags, value);
		}

		[Ordinal(16)] 
		[RED("TEMP_cuverBarsEnabled")] 
		public CBool TEMP_cuverBarsEnabled
		{
			get => GetProperty(ref _tEMP_cuverBarsEnabled);
			set => SetProperty(ref _tEMP_cuverBarsEnabled, value);
		}

		[Ordinal(17)] 
		[RED("TEMP_separatorBarsEnabled")] 
		public CBool TEMP_separatorBarsEnabled
		{
			get => GetProperty(ref _tEMP_separatorBarsEnabled);
			set => SetProperty(ref _tEMP_separatorBarsEnabled, value);
		}

		public UIInventoryItemsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
