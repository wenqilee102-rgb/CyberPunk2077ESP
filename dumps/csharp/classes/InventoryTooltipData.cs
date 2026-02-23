using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData : ATooltipData
	{
		private gameItemID _itemID;
		private CBool _isEquipped;
		private CBool _isLocked;
		private CBool _isVendorItem;
		private CBool _isCraftable;
		private CBool _isPerkRequired;
		private CName _qualityStateName;
		private CString _description;
		private CString _additionalDescription;
		private CString _gameplayDescription;
		private CString _category;
		private CString _quality;
		private CString _itemName;
		private CString _perkRequiredName;
		private CFloat _price;
		private CFloat _buyPrice;
		private CFloat _unlockProgress;
		private CArray<InventoryTooltipData_StatData> _primaryStats;
		private CArray<InventoryTooltipData_StatData> _comparedStats;
		private CArray<InventoryTooltipData_StatData> _additionalStats;
		private CArray<InventoryTooltipData_StatData> _randomDamageTypes;
		private CArray<InventoryTooltipData_StatData> _recipeAdditionalStats;
		private CEnum<gamedataDamageType> _damageType;
		private CBool _isBroken;
		private CInt32 _levelRequired;
		private CArray<CName> _attachments;
		private CArray<gameInventoryItemAbility> _specialAbilities;
		private CEnum<gamedataEquipmentArea> _equipArea;
		private CBool _showCyclingDots;
		private CInt32 _numberOfCyclingDots;
		private CInt32 _selectedCyclingDot;
		private CEnum<gamedataQuality> _comparedQuality;
		private CFloat _qualityF;
		private CFloat _comparisonQualityF;
		private CBool _showIcon;
		private CInt32 _randomizedStatQuantity;
		private CEnum<gamedataItemType> _itemType;
		private CBool _hasPlayerSmartGunLink;
		private CInt32 _playerLevel;
		private CInt32 _playerStrenght;
		private CInt32 _playerReflexes;
		private CInt32 _playerStreetCred;
		private CArray<CHandle<gameInventoryItemAttachments>> _itemAttachments;
		private gameInventoryItemData _inventoryItemData;
		private CBool _overrideRarity;
		private InventoryTooltipData_QuickhackData _quickhackData;
		private CHandle<InventoryTooltiData_GrenadeData> _grenadeData;
		private CHandle<InventoryTooltipData_CyberdeckData> _cyberdeckData;
		private CHandle<InventoryTooltiData_CyberwareUpgradeData> _cyberwareUpgradeData;
		private CEnum<InventoryTooltipDisplayContext> _displayContext;
		private wCHandle<gameItemData> _parentItemData;
		private TweakDBID _slotID;
		private gameItemID _transmogItem;
		private wCHandle<UIInventoryItemsManager> _managerRef;
		private CHandle<UIInventoryItemStatsManager> _statsManager;
		private CBool _statsManagerFetched;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;

		[Ordinal(0)] 
		[RED("itemID")] 
		public gameItemID ItemID
		{
			get => GetProperty(ref _itemID);
			set => SetProperty(ref _itemID, value);
		}

		[Ordinal(1)] 
		[RED("isEquipped")] 
		public CBool IsEquipped
		{
			get => GetProperty(ref _isEquipped);
			set => SetProperty(ref _isEquipped, value);
		}

		[Ordinal(2)] 
		[RED("isLocked")] 
		public CBool IsLocked
		{
			get => GetProperty(ref _isLocked);
			set => SetProperty(ref _isLocked, value);
		}

		[Ordinal(3)] 
		[RED("isVendorItem")] 
		public CBool IsVendorItem
		{
			get => GetProperty(ref _isVendorItem);
			set => SetProperty(ref _isVendorItem, value);
		}

		[Ordinal(4)] 
		[RED("isCraftable")] 
		public CBool IsCraftable
		{
			get => GetProperty(ref _isCraftable);
			set => SetProperty(ref _isCraftable, value);
		}

		[Ordinal(5)] 
		[RED("isPerkRequired")] 
		public CBool IsPerkRequired
		{
			get => GetProperty(ref _isPerkRequired);
			set => SetProperty(ref _isPerkRequired, value);
		}

		[Ordinal(6)] 
		[RED("qualityStateName")] 
		public CName QualityStateName
		{
			get => GetProperty(ref _qualityStateName);
			set => SetProperty(ref _qualityStateName, value);
		}

		[Ordinal(7)] 
		[RED("description")] 
		public CString Description
		{
			get => GetProperty(ref _description);
			set => SetProperty(ref _description, value);
		}

		[Ordinal(8)] 
		[RED("additionalDescription")] 
		public CString AdditionalDescription
		{
			get => GetProperty(ref _additionalDescription);
			set => SetProperty(ref _additionalDescription, value);
		}

		[Ordinal(9)] 
		[RED("gameplayDescription")] 
		public CString GameplayDescription
		{
			get => GetProperty(ref _gameplayDescription);
			set => SetProperty(ref _gameplayDescription, value);
		}

		[Ordinal(10)] 
		[RED("category")] 
		public CString Category
		{
			get => GetProperty(ref _category);
			set => SetProperty(ref _category, value);
		}

		[Ordinal(11)] 
		[RED("quality")] 
		public CString Quality
		{
			get => GetProperty(ref _quality);
			set => SetProperty(ref _quality, value);
		}

		[Ordinal(12)] 
		[RED("itemName")] 
		public CString ItemName
		{
			get => GetProperty(ref _itemName);
			set => SetProperty(ref _itemName, value);
		}

		[Ordinal(13)] 
		[RED("perkRequiredName")] 
		public CString PerkRequiredName
		{
			get => GetProperty(ref _perkRequiredName);
			set => SetProperty(ref _perkRequiredName, value);
		}

		[Ordinal(14)] 
		[RED("price")] 
		public CFloat Price
		{
			get => GetProperty(ref _price);
			set => SetProperty(ref _price, value);
		}

		[Ordinal(15)] 
		[RED("buyPrice")] 
		public CFloat BuyPrice
		{
			get => GetProperty(ref _buyPrice);
			set => SetProperty(ref _buyPrice, value);
		}

		[Ordinal(16)] 
		[RED("unlockProgress")] 
		public CFloat UnlockProgress
		{
			get => GetProperty(ref _unlockProgress);
			set => SetProperty(ref _unlockProgress, value);
		}

		[Ordinal(17)] 
		[RED("primaryStats")] 
		public CArray<InventoryTooltipData_StatData> PrimaryStats
		{
			get => GetProperty(ref _primaryStats);
			set => SetProperty(ref _primaryStats, value);
		}

		[Ordinal(18)] 
		[RED("comparedStats")] 
		public CArray<InventoryTooltipData_StatData> ComparedStats
		{
			get => GetProperty(ref _comparedStats);
			set => SetProperty(ref _comparedStats, value);
		}

		[Ordinal(19)] 
		[RED("additionalStats")] 
		public CArray<InventoryTooltipData_StatData> AdditionalStats
		{
			get => GetProperty(ref _additionalStats);
			set => SetProperty(ref _additionalStats, value);
		}

		[Ordinal(20)] 
		[RED("randomDamageTypes")] 
		public CArray<InventoryTooltipData_StatData> RandomDamageTypes
		{
			get => GetProperty(ref _randomDamageTypes);
			set => SetProperty(ref _randomDamageTypes, value);
		}

		[Ordinal(21)] 
		[RED("recipeAdditionalStats")] 
		public CArray<InventoryTooltipData_StatData> RecipeAdditionalStats
		{
			get => GetProperty(ref _recipeAdditionalStats);
			set => SetProperty(ref _recipeAdditionalStats, value);
		}

		[Ordinal(22)] 
		[RED("damageType")] 
		public CEnum<gamedataDamageType> DamageType
		{
			get => GetProperty(ref _damageType);
			set => SetProperty(ref _damageType, value);
		}

		[Ordinal(23)] 
		[RED("isBroken")] 
		public CBool IsBroken
		{
			get => GetProperty(ref _isBroken);
			set => SetProperty(ref _isBroken, value);
		}

		[Ordinal(24)] 
		[RED("levelRequired")] 
		public CInt32 LevelRequired
		{
			get => GetProperty(ref _levelRequired);
			set => SetProperty(ref _levelRequired, value);
		}

		[Ordinal(25)] 
		[RED("attachments")] 
		public CArray<CName> Attachments
		{
			get => GetProperty(ref _attachments);
			set => SetProperty(ref _attachments, value);
		}

		[Ordinal(26)] 
		[RED("specialAbilities")] 
		public CArray<gameInventoryItemAbility> SpecialAbilities
		{
			get => GetProperty(ref _specialAbilities);
			set => SetProperty(ref _specialAbilities, value);
		}

		[Ordinal(27)] 
		[RED("equipArea")] 
		public CEnum<gamedataEquipmentArea> EquipArea
		{
			get => GetProperty(ref _equipArea);
			set => SetProperty(ref _equipArea, value);
		}

		[Ordinal(28)] 
		[RED("showCyclingDots")] 
		public CBool ShowCyclingDots
		{
			get => GetProperty(ref _showCyclingDots);
			set => SetProperty(ref _showCyclingDots, value);
		}

		[Ordinal(29)] 
		[RED("numberOfCyclingDots")] 
		public CInt32 NumberOfCyclingDots
		{
			get => GetProperty(ref _numberOfCyclingDots);
			set => SetProperty(ref _numberOfCyclingDots, value);
		}

		[Ordinal(30)] 
		[RED("selectedCyclingDot")] 
		public CInt32 SelectedCyclingDot
		{
			get => GetProperty(ref _selectedCyclingDot);
			set => SetProperty(ref _selectedCyclingDot, value);
		}

		[Ordinal(31)] 
		[RED("comparedQuality")] 
		public CEnum<gamedataQuality> ComparedQuality
		{
			get => GetProperty(ref _comparedQuality);
			set => SetProperty(ref _comparedQuality, value);
		}

		[Ordinal(32)] 
		[RED("qualityF")] 
		public CFloat QualityF
		{
			get => GetProperty(ref _qualityF);
			set => SetProperty(ref _qualityF, value);
		}

		[Ordinal(33)] 
		[RED("comparisonQualityF")] 
		public CFloat ComparisonQualityF
		{
			get => GetProperty(ref _comparisonQualityF);
			set => SetProperty(ref _comparisonQualityF, value);
		}

		[Ordinal(34)] 
		[RED("showIcon")] 
		public CBool ShowIcon
		{
			get => GetProperty(ref _showIcon);
			set => SetProperty(ref _showIcon, value);
		}

		[Ordinal(35)] 
		[RED("randomizedStatQuantity")] 
		public CInt32 RandomizedStatQuantity
		{
			get => GetProperty(ref _randomizedStatQuantity);
			set => SetProperty(ref _randomizedStatQuantity, value);
		}

		[Ordinal(36)] 
		[RED("itemType")] 
		public CEnum<gamedataItemType> ItemType
		{
			get => GetProperty(ref _itemType);
			set => SetProperty(ref _itemType, value);
		}

		[Ordinal(37)] 
		[RED("HasPlayerSmartGunLink")] 
		public CBool HasPlayerSmartGunLink
		{
			get => GetProperty(ref _hasPlayerSmartGunLink);
			set => SetProperty(ref _hasPlayerSmartGunLink, value);
		}

		[Ordinal(38)] 
		[RED("PlayerLevel")] 
		public CInt32 PlayerLevel
		{
			get => GetProperty(ref _playerLevel);
			set => SetProperty(ref _playerLevel, value);
		}

		[Ordinal(39)] 
		[RED("PlayerStrenght")] 
		public CInt32 PlayerStrenght
		{
			get => GetProperty(ref _playerStrenght);
			set => SetProperty(ref _playerStrenght, value);
		}

		[Ordinal(40)] 
		[RED("PlayerReflexes")] 
		public CInt32 PlayerReflexes
		{
			get => GetProperty(ref _playerReflexes);
			set => SetProperty(ref _playerReflexes, value);
		}

		[Ordinal(41)] 
		[RED("PlayerStreetCred")] 
		public CInt32 PlayerStreetCred
		{
			get => GetProperty(ref _playerStreetCred);
			set => SetProperty(ref _playerStreetCred, value);
		}

		[Ordinal(42)] 
		[RED("itemAttachments")] 
		public CArray<CHandle<gameInventoryItemAttachments>> ItemAttachments
		{
			get => GetProperty(ref _itemAttachments);
			set => SetProperty(ref _itemAttachments, value);
		}

		[Ordinal(43)] 
		[RED("inventoryItemData")] 
		public gameInventoryItemData InventoryItemData
		{
			get => GetProperty(ref _inventoryItemData);
			set => SetProperty(ref _inventoryItemData, value);
		}

		[Ordinal(44)] 
		[RED("overrideRarity")] 
		public CBool OverrideRarity
		{
			get => GetProperty(ref _overrideRarity);
			set => SetProperty(ref _overrideRarity, value);
		}

		[Ordinal(45)] 
		[RED("quickhackData")] 
		public InventoryTooltipData_QuickhackData QuickhackData
		{
			get => GetProperty(ref _quickhackData);
			set => SetProperty(ref _quickhackData, value);
		}

		[Ordinal(46)] 
		[RED("grenadeData")] 
		public CHandle<InventoryTooltiData_GrenadeData> GrenadeData
		{
			get => GetProperty(ref _grenadeData);
			set => SetProperty(ref _grenadeData, value);
		}

		[Ordinal(47)] 
		[RED("cyberdeckData")] 
		public CHandle<InventoryTooltipData_CyberdeckData> CyberdeckData
		{
			get => GetProperty(ref _cyberdeckData);
			set => SetProperty(ref _cyberdeckData, value);
		}

		[Ordinal(48)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetProperty(ref _cyberwareUpgradeData);
			set => SetProperty(ref _cyberwareUpgradeData, value);
		}

		[Ordinal(49)] 
		[RED("displayContext")] 
		public CEnum<InventoryTooltipDisplayContext> DisplayContext
		{
			get => GetProperty(ref _displayContext);
			set => SetProperty(ref _displayContext, value);
		}

		[Ordinal(50)] 
		[RED("parentItemData")] 
		public wCHandle<gameItemData> ParentItemData
		{
			get => GetProperty(ref _parentItemData);
			set => SetProperty(ref _parentItemData, value);
		}

		[Ordinal(51)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(52)] 
		[RED("transmogItem")] 
		public gameItemID TransmogItem
		{
			get => GetProperty(ref _transmogItem);
			set => SetProperty(ref _transmogItem, value);
		}

		[Ordinal(53)] 
		[RED("managerRef")] 
		public wCHandle<UIInventoryItemsManager> ManagerRef
		{
			get => GetProperty(ref _managerRef);
			set => SetProperty(ref _managerRef, value);
		}

		[Ordinal(54)] 
		[RED("statsManager")] 
		public CHandle<UIInventoryItemStatsManager> StatsManager
		{
			get => GetProperty(ref _statsManager);
			set => SetProperty(ref _statsManager, value);
		}

		[Ordinal(55)] 
		[RED("statsManagerFetched")] 
		public CBool StatsManagerFetched
		{
			get => GetProperty(ref _statsManagerFetched);
			set => SetProperty(ref _statsManagerFetched, value);
		}

		[Ordinal(56)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetProperty(ref _dEBUG_iconErrorInfo);
			set => SetProperty(ref _dEBUG_iconErrorInfo, value);
		}

		public InventoryTooltipData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
