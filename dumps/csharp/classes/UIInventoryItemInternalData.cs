using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItemInternalData : IScriptable
	{
		private CString _name;
		private CEnum<gamedataQuality> _quality;
		private CEnum<gamedataItemType> _itemType;
		private CInt32 _quantity;
		private CString _description;
		private CString _iconPath;
		private CBool _isQuestItem;
		private CBool _isRecipeItem;
		private CBool _isIconicItem;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<ItemFilterCategory> _filterCategory;
		private CHandle<UIInventoryItemStat> _primaryStat;
		private CInt32 _itemTypeOrder;
		private CFloat _weight;
		private CFloat _itemPlus;
		private CHandle<UIInventoryItemStatsManager> _statsManager;
		private CHandle<UIInventoryItemModsManager> _modsManager;
		private CHandle<UIInventoryItemRequirementsManager> _requirementsManager;
		private CEnum<UIItemCategory> _uIItemCategory;
		private CFloat _comparisonQuality;
		private CString _qualityText;
		private CBool _isSellable;
		private CBool _isBroken;

		[Ordinal(0)] 
		[RED("Name")] 
		public CString Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("Quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(2)] 
		[RED("ItemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(3)] 
		[RED("Quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(4)] 
		[RED("Description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(5)] 
		[RED("IconPath")] 
		public CString IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(6)] 
		[RED("IsQuestItem")] 
		public CBool IsQuestItem
		{
			get => GetProperty(ref _isQuestItem);
			set => SetProperty(ref _isQuestItem, value);
		}

		[Ordinal(7)] 
		[RED("IsRecipeItem")] 
		public CBool IsRecipeItem
		{
			get => GetProperty(ref _isRecipeItem);
			set => SetProperty(ref _isRecipeItem, value);
		}

		[Ordinal(8)] 
		[RED("IsIconicItem")] 
		public CBool IsIconicItem
		{
			get => GetProperty(ref _isIconicItem);
			set => SetProperty(ref _isIconicItem, value);
		}

		[Ordinal(9)] 
		[RED("EquipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(10)] 
		[RED("FilterCategory")] 
		public CEnum<ItemFilterCategory> FilterCategory
		{
			get => GetProperty(ref _filterCategory);
			set => SetProperty(ref _filterCategory, value);
		}

		[Ordinal(11)] 
		[RED("PrimaryStat")] 
		public CHandle<UIInventoryItemStat> PrimaryStat
		{
			get => GetProperty(ref _primaryStat);
			set => SetProperty(ref _primaryStat, value);
		}

		[Ordinal(12)] 
		[RED("ItemTypeOrder")] 
		public CInt32 ItemTypeOrder
		{
			get => GetProperty(ref _itemTypeOrder);
			set => SetProperty(ref _itemTypeOrder, value);
		}

		[Ordinal(13)] 
		[RED("Weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(14)] 
		[RED("ItemPlus")] 
		public CFloat ItemPlus
		{
			get => GetProperty(ref _itemPlus);
			set => SetProperty(ref _itemPlus, value);
		}

		[Ordinal(15)] 
		[RED("StatsManager")] 
		public CHandle<UIInventoryItemStatsManager> StatsManager
		{
			get => GetProperty(ref _statsManager);
			set => SetProperty(ref _statsManager, value);
		}

		[Ordinal(16)] 
		[RED("ModsManager")] 
		public CHandle<UIInventoryItemModsManager> ModsManager
		{
			get => GetProperty(ref _modsManager);
			set => SetProperty(ref _modsManager, value);
		}

		[Ordinal(17)] 
		[RED("RequirementsManager")] 
		public CHandle<UIInventoryItemRequirementsManager> RequirementsManager
		{
			get => GetProperty(ref _requirementsManager);
			set => SetProperty(ref _requirementsManager, value);
		}

		[Ordinal(18)] 
		[RED("UIItemCategory")] 
		public CEnum<UIItemCategory> UIItemCategory
		{
			get => GetProperty(ref _uIItemCategory);
			set => SetProperty(ref _uIItemCategory, value);
		}

		[Ordinal(19)] 
		[RED("ComparisonQuality")] 
		public CFloat ComparisonQuality
		{
			get => GetProperty(ref _comparisonQuality);
			set => SetProperty(ref _comparisonQuality, value);
		}

		[Ordinal(20)] 
		[RED("QualityText")] 
		public CString QualityText
		{
			get => GetProperty(ref _qualityText);
			set => SetProperty(ref _qualityText, value);
		}

		[Ordinal(21)] 
		[RED("IsSellable")] 
		public CBool IsSellable
		{
			get => GetProperty(ref _isSellable);
			set => SetProperty(ref _isSellable, value);
		}

		[Ordinal(22)] 
		[RED("IsBroken")] 
		public CBool IsBroken
		{
			get => GetProperty(ref _isBroken);
			set => SetProperty(ref _isBroken, value);
		}

		public UIInventoryItemInternalData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
