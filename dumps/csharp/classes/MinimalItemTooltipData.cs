using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipData : ATooltipData
	{
		private gameItemID _itemID;
		private TweakDBID _itemTweakID;
		private wCHandle<gameItemData> _itemData;
		private gameItemID _transmogItem;
		private CString _itemName;
		private CEnum<gamedataQuality> _quality;
		private CInt32 _quantity;
		private CString _description;
		private CString _gameplayDescription;
		private CFloat _weight;
		private CFloat _price;
		private CFloat _dpsValue;
		private CFloat _dpsDiff;
		private CFloat _armorValue;
		private CFloat _armorDiff;
		private CBool _compareDPS;
		private CBool _compareArmor;
		private CEnum<gamedataQuality> _comparedQuality;
		private CFloat _qualityF;
		private CFloat _comparisonQualityF;
		private CFloat _attackSpeed;
		private CFloat _projectilesPerShot;
		private CHandle<InventoryTooltiData_GrenadeData> _grenadeData;
		private CInt32 _ammoCount;
		private CBool _hasSilencer;
		private CBool _hasScope;
		private CBool _isSilencerInstalled;
		private CBool _isScopeInstalled;
		private CHandle<MinimalItemTooltipDataRequirements> _requirements;
		private CHandle<MinimalItemTooltipRecipeData> _recipeData;
		private CArray<CHandle<MinimalItemTooltipStatData>> _attributeAllocationStats;
		private CArray<CHandle<MinimalItemTooltipStatData>> _stats;
		private CArray<CHandle<MinimalItemTooltipModData>> _mods;
		private CArray<CHandle<MinimalItemTooltipModAttachmentData>> _dedicatedMods;
		private CHandle<InventoryTooltiData_CyberwareUpgradeData> _cyberwareUpgradeData;
		private CEnum<gamedataItemType> _itemType;
		private CEnum<gamedataItemCategory> _itemCategory;
		private CEnum<gamedataEquipmentArea> _equipmentArea;
		private CEnum<gamedataWeaponEvolution> _itemEvolution;
		private CEnum<gamedataPerkWeaponGroupType> _itemPerkGroup;
		private CEnum<gameLootItemType> _lootItemType;
		private CString _iconPath;
		private CBool _useMaleIcon;
		private CBool _isIconic;
		private CFloat _isPlus;
		private CBool _isBroken;
		private CBool _isCrafted;
		private CBool _isEquipped;
		private CBool _hasRarity;
		private CHandle<ItemDisplayContextData> _displayContextData;
		private CEnum<InventoryTooltipDisplayContext> _displayContext;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;
		private CHandle<UIInventoryItemStatsManager> _statsManager;
		private CBool _statsManagerFetched;
		private wCHandle<UIInventoryItemsManager> _managerRef;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("itemTweakID")] 
		public TweakDBID ItemTweakID
		{
			get => GetProperty(ref _itemTweakID);
			set => SetProperty(ref _itemTweakID, value);
		}

		[Ordinal(2)] 
		[RED("itemData")] 
		public wCHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(3)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetProperty(ref _transmogItem);
			set => SetProperty(ref _transmogItem, value);
		}

		[Ordinal(4)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(5)] 
		[RED("quality")] 
		public CEnum<gamedataQuality> Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(6)] 
		[RED("quantity")] 
		public CInt32 Quantity
		{
			get => GetProperty(ref _quantity);
			set => SetProperty(ref _quantity, value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(8)] 
		[RED("gameplayDescription")] 
		public CString GameplayDescription
		{
			get => GetProperty(ref _gameplayDescription);
			set => SetProperty(ref _gameplayDescription, value);
		}

		[Ordinal(9)] 
		[RED("weight")] 
		public CFloat Weight
		{
			get => GetProperty(ref _weight);
			set => SetProperty(ref _weight, value);
		}

		[Ordinal(10)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(11)] 
		[RED("dpsValue")] 
		public CFloat DpsValue
		{
			get => GetProperty(ref _dpsValue);
			set => SetProperty(ref _dpsValue, value);
		}

		[Ordinal(12)] 
		[RED("dpsDiff")] 
		public CFloat DpsDiff
		{
			get => GetProperty(ref _dpsDiff);
			set => SetProperty(ref _dpsDiff, value);
		}

		[Ordinal(13)] 
		[RED("armorValue")] 
		public CFloat ArmorValue
		{
			get => GetProperty(ref _armorValue);
			set => SetProperty(ref _armorValue, value);
		}

		[Ordinal(14)] 
		[RED("armorDiff")] 
		public CFloat ArmorDiff
		{
			get => GetProperty(ref _armorDiff);
			set => SetProperty(ref _armorDiff, value);
		}

		[Ordinal(15)] 
		[RED("compareDPS")] 
		public CBool CompareDPS
		{
			get => GetProperty(ref _compareDPS);
			set => SetProperty(ref _compareDPS, value);
		}

		[Ordinal(16)] 
		[RED("compareArmor")] 
		public CBool CompareArmor
		{
			get => GetProperty(ref _compareArmor);
			set => SetProperty(ref _compareArmor, value);
		}

		[Ordinal(17)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetProperty(ref _comparedQuality);
			set => SetProperty(ref _comparedQuality, value);
		}

		[Ordinal(18)] 
		[RED("qualityF")] 
		public CFloat QualityF
		{
			get => GetProperty(ref _qualityF);
			set => SetProperty(ref _qualityF, value);
		}

		[Ordinal(19)] 
		[RED("comparisonQualityF")] 
		public CFloat ComparisonQualityF
		{
			get => GetProperty(ref _comparisonQualityF);
			set => SetProperty(ref _comparisonQualityF, value);
		}

		[Ordinal(20)] 
		[RED("attackSpeed")] 
		public CFloat AttackSpeed
		{
			get => GetProperty(ref _attackSpeed);
			set => SetProperty(ref _attackSpeed, value);
		}

		[Ordinal(21)] 
		[RED("projectilesPerShot")] 
		public CFloat ProjectilesPerShot
		{
			get => GetProperty(ref _projectilesPerShot);
			set => SetProperty(ref _projectilesPerShot, value);
		}

		[Ordinal(22)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetProperty(ref _grenadeData);
			set => SetProperty(ref _grenadeData, value);
		}

		[Ordinal(23)] 
		[RED("ammoCount")] 
		public CInt32 AmmoCount
		{
			get => GetProperty(ref _ammoCount);
			set => SetProperty(ref _ammoCount, value);
		}

		[Ordinal(24)] 
		[RED("hasSilencer")] 
		public CBool HasSilencer
		{
			get => GetProperty(ref _hasSilencer);
			set => SetProperty(ref _hasSilencer, value);
		}

		[Ordinal(25)] 
		[RED("hasScope")] 
		public CBool HasScope
		{
			get => GetProperty(ref _hasScope);
			set => SetProperty(ref _hasScope, value);
		}

		[Ordinal(26)] 
		[RED("isSilencerInstalled")] 
		public CBool IsSilencerInstalled
		{
			get => GetProperty(ref _isSilencerInstalled);
			set => SetProperty(ref _isSilencerInstalled, value);
		}

		[Ordinal(27)] 
		[RED("isScopeInstalled")] 
		public CBool IsScopeInstalled
		{
			get => GetProperty(ref _isScopeInstalled);
			set => SetProperty(ref _isScopeInstalled, value);
		}

		[Ordinal(28)] 
		[RED("requirements")] 
		public CHandle<MinimalItemTooltipDataRequirements> Requirements
		{
			get => GetProperty(ref _requirements);
			set => SetProperty(ref _requirements, value);
		}

		[Ordinal(29)] 
		[RED("recipeData")] 
		public CHandle<MinimalItemTooltipRecipeData> RecipeData
		{
			get => GetProperty(ref _recipeData);
			set => SetProperty(ref _recipeData, value);
		}

		[Ordinal(30)] 
		[RED("attributeAllocationStats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> AttributeAllocationStats
		{
			get => GetProperty(ref _attributeAllocationStats);
			set => SetProperty(ref _attributeAllocationStats, value);
		}

		[Ordinal(31)] 
		[RED("stats")] 
		public CArray<CHandle<MinimalItemTooltipStatData>> Stats
		{
			get => GetProperty(ref _stats);
			set => SetProperty(ref _stats, value);
		}

		[Ordinal(32)] 
		[RED("mods")] 
		public CArray<CHandle<MinimalItemTooltipModData>> Mods
		{
			get => GetProperty(ref _mods);
			set => SetProperty(ref _mods, value);
		}

		[Ordinal(33)] 
		[RED("dedicatedMods")] 
		public CArray<CHandle<MinimalItemTooltipModAttachmentData>> DedicatedMods
		{
			get => GetProperty(ref _dedicatedMods);
			set => SetProperty(ref _dedicatedMods, value);
		}

		[Ordinal(34)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetProperty(ref _cyberwareUpgradeData);
			set => SetProperty(ref _cyberwareUpgradeData, value);
		}

		[Ordinal(35)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(36)] 
		[RED("itemCategory")] 
		public CEnum<gamedataItemCategory> ItemCategory
		{
			get => GetProperty(ref _itemCategory);
			set => SetProperty(ref _itemCategory, value);
		}

		[Ordinal(37)] 
		[RED("equipmentArea")] 
		public CEnum<gamedataEquipmentArea> EquipmentArea
		{
			get => GetProperty(ref _equipmentArea);
			set => SetProperty(ref _equipmentArea, value);
		}

		[Ordinal(38)] 
		[RED("itemEvolution")] 
		public CEnum<gamedataWeaponEvolution> ItemEvolution
		{
			get => GetProperty(ref _itemEvolution);
			set => SetProperty(ref _itemEvolution, value);
		}

		[Ordinal(39)] 
		[RED("itemPerkGroup")] 
		public CEnum<gamedataPerkWeaponGroupType> ItemPerkGroup
		{
			get => GetProperty(ref _itemPerkGroup);
			set => SetProperty(ref _itemPerkGroup, value);
		}

		[Ordinal(40)] 
		[RED("lootItemType")] 
		public CEnum<gameLootItemType> LootItemType
		{
			get => GetProperty(ref _lootItemType);
			set => SetProperty(ref _lootItemType, value);
		}

		[Ordinal(41)] 
		[RED("iconPath")] 
		public CString IconPath
		{
			get => GetProperty(ref _iconPath);
			set => SetProperty(ref _iconPath, value);
		}

		[Ordinal(42)] 
		[RED("useMaleIcon")] 
		public CBool UseMaleIcon
		{
			get => GetProperty(ref _useMaleIcon);
			set => SetProperty(ref _useMaleIcon, value);
		}

		[Ordinal(43)] 
		[RED("isIconic")] 
		public CBool IsIconic
		{
			get => GetProperty(ref _isIconic);
			set => SetProperty(ref _isIconic, value);
		}

		[Ordinal(44)] 
		[RED("isPlus")] 
		public CFloat IsPlus
		{
			get => GetProperty(ref _isPlus);
			set => SetProperty(ref _isPlus, value);
		}

		[Ordinal(45)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetProperty(ref _isBroken);
			set => SetProperty(ref _isBroken, value);
		}

		[Ordinal(46)] 
		[RED("isCrafted")] 
		public CBool IsCrafted
		{
			get => GetProperty(ref _isCrafted);
			set => SetProperty(ref _isCrafted, value);
		}

		[Ordinal(47)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetProperty(ref _isEquipped);
			set => SetProperty(ref _isEquipped, value);
		}

		[Ordinal(48)] 
		[RED("hasRarity")] 
		public CBool HasRarity
		{
			get => GetProperty(ref _hasRarity);
			set => SetProperty(ref _hasRarity, value);
		}

		[Ordinal(49)] 
		[RED("displayContextData")] 
		public CHandle<ItemDisplayContextData> DisplayContextData
		{
			get => GetProperty(ref _displayContextData);
			set => SetProperty(ref _displayContextData, value);
		}

		[Ordinal(50)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(51)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetProperty(ref _dEBUG_iconErrorInfo);
			set => SetProperty(ref _dEBUG_iconErrorInfo, value);
		}

		[Ordinal(52)] 
		[RED("statsManager")] 
		public CHandle<UIInventoryItemStatsManager> StatsManager
		{
			get => GetProperty(ref _statsManager);
			set => SetProperty(ref _statsManager, value);
		}

		[Ordinal(53)] 
		[RED("statsManagerFetched")] 
		public CBool StatsManagerFetched
		{
			get => GetProperty(ref _statsManagerFetched);
			set => SetProperty(ref _statsManagerFetched, value);
		}

		[Ordinal(54)] 
		[RED("managerRef")] 
		public wCHandle<UIInventoryItemsManager> ManagerRef
		{
			get => GetProperty(ref _managerRef);
			set => SetProperty(ref _managerRef, value);
		}

		public MinimalItemTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
