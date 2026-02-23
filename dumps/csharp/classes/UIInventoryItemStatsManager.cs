using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemStatsManager : IScriptable
	{
		private CArray<CHandle<UIInventoryItemStat>> _stats;
		private CArray<CHandle<UIInventoryItemStat>> _tooltipStats;
		private CArray<CHandle<UIInventoryItemStat>> _additionalStats;
		private CArray<CHandle<UIInventoryItemStat>> _attributeAllocationStats;
		private wCHandle<UIInventoryItem> _item;
		private wCHandle<gameItemData> _gameItemData;
		private CEnum<gamedataItemType> _itemType;
		private wCHandle<UIInventoryItemsManager> _manager;
		private wCHandle<gamedataUIStatsMap_Record> _statMap;
		private CBool _statsFetched;
		private CBool _tooltipStatsFetched;
		private CHandle<UIInventoryItemWeaponBars> _weaponBars;
		private CBool _weaponBarsFetched;
		private CBool _useBareStats;

		[Ordinal(0)] 
		[RED("Stats")] 
		public CArray<CHandle<UIInventoryItemStat>> Stats
		{
			get => GetProperty(ref _stats);
			set => SetProperty(ref _stats, value);
		}

		[Ordinal(1)] 
		[RED("TooltipStats")] 
		public CArray<CHandle<UIInventoryItemStat>> TooltipStats
		{
			get => GetProperty(ref _tooltipStats);
			set => SetProperty(ref _tooltipStats, value);
		}

		[Ordinal(2)] 
		[RED("AdditionalStats")] 
		public CArray<CHandle<UIInventoryItemStat>> AdditionalStats
		{
			get => GetProperty(ref _additionalStats);
			set => SetProperty(ref _additionalStats, value);
		}

		[Ordinal(3)] 
		[RED("AttributeAllocationStats")] 
		public CArray<CHandle<UIInventoryItemStat>> AttributeAllocationStats
		{
			get => GetProperty(ref _attributeAllocationStats);
			set => SetProperty(ref _attributeAllocationStats, value);
		}

		[Ordinal(4)] 
		[RED("item")] 
		public wCHandle<UIInventoryItem> Item
		{
			get => GetProperty(ref _item);
			set => SetProperty(ref _item, value);
		}

		[Ordinal(5)] 
		[RED("gameItemData")] 
		public wCHandle<gameItemData> GameItemData
		{
			get => GetProperty(ref _gameItemData);
			set => SetProperty(ref _gameItemData, value);
		}

		[Ordinal(6)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(7)] 
		[RED("manager")] 
		public wCHandle<UIInventoryItemsManager> Manager
		{
			get => GetProperty(ref _manager);
			set => SetProperty(ref _manager, value);
		}

		[Ordinal(8)] 
		[RED("statMap")] 
		public wCHandle<gamedataUIStatsMap_Record> StatMap
		{
			get => GetProperty(ref _statMap);
			set => SetProperty(ref _statMap, value);
		}

		[Ordinal(9)] 
		[RED("statsFetched")] 
		public CBool StatsFetched
		{
			get => GetProperty(ref _statsFetched);
			set => SetProperty(ref _statsFetched, value);
		}

		[Ordinal(10)] 
		[RED("tooltipStatsFetched")] 
		public CBool TooltipStatsFetched
		{
			get => GetProperty(ref _tooltipStatsFetched);
			set => SetProperty(ref _tooltipStatsFetched, value);
		}

		[Ordinal(11)] 
		[RED("weaponBars")] 
		public CHandle<UIInventoryItemWeaponBars> WeaponBars
		{
			get => GetProperty(ref _weaponBars);
			set => SetProperty(ref _weaponBars, value);
		}

		[Ordinal(12)] 
		[RED("weaponBarsFetched")] 
		public CBool WeaponBarsFetched
		{
			get => GetProperty(ref _weaponBarsFetched);
			set => SetProperty(ref _weaponBarsFetched, value);
		}

		[Ordinal(13)] 
		[RED("useBareStats")] 
		public CBool UseBareStats
		{
			get => GetProperty(ref _useBareStats);
			set => SetProperty(ref _useBareStats, value);
		}

		public UIInventoryItemStatsManager(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
