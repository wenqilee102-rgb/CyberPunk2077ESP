using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIInventoryItem : IScriptable
	{
		private gameItemID _iD;
		private CUInt64 _hash;
		private CHandle<DEBUG_IconErrorInfo> _dEBUG_iconErrorInfo;
		private wCHandle<UIInventoryItemsManager> _manager;
		private wCHandle<gameObject> _owner;
		private wCHandle<gameItemData> _itemData;
		private wCHandle<gameItemData> _realItemData;
		private CHandle<gameItemData> _recipeItemData;
		private wCHandle<gamedataItem_Record> _itemRecord;
		private wCHandle<gamedataItem_Record> _realItemRecord;
		private TweakDBID _itemTweakID;
		private TweakDBID _realItemTweakID;
		private CHandle<UIInventoryItemInternalData> _data;
		private CHandle<UIInventoryWeaponInternalData> _weaponData;
		private CHandle<UIInventoryItemProgramData> _programData;
		private CHandle<UIInventoryItemGrenadeData> _grenadeData;
		private CHandle<InventoryTooltiData_CyberwareUpgradeData> _cyberwareUpgradeData;
		private wCHandle<gameItemData> _parentItem;
		private TweakDBID _slotID;
		private CInt32 _fetchedFlags;
		private CBool _isQuantityDirty;
		private wCHandle<gamedataCraftingResult_Record> _craftingResult;
		private CBool _tEMP_isEquippedPrefetched;
		private CBool _tEMP_isEquipped;

		[Ordinal(0)] 
		[RED("ID")] 
		public gameItemID ID
		{
			get => GetProperty(ref _iD);
			set => SetProperty(ref _iD, value);
		}

		[Ordinal(1)] 
		[RED("Hash")] 
		public CUInt64 Hash
		{
			get => GetProperty(ref _hash);
			set => SetProperty(ref _hash, value);
		}

		[Ordinal(2)] 
		[RED("DEBUG_iconErrorInfo")] 
		public CHandle<DEBUG_IconErrorInfo> DEBUG_iconErrorInfo
		{
			get => GetProperty(ref _dEBUG_iconErrorInfo);
			set => SetProperty(ref _dEBUG_iconErrorInfo, value);
		}

		[Ordinal(3)] 
		[RED("manager")] 
		public wCHandle<UIInventoryItemsManager> Manager
		{
			get => GetProperty(ref _manager);
			set => SetProperty(ref _manager, value);
		}

		[Ordinal(4)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(5)] 
		[RED("itemData")] 
		public wCHandle<gameItemData> ItemData
		{
			get => GetProperty(ref _itemData);
			set => SetProperty(ref _itemData, value);
		}

		[Ordinal(6)] 
		[RED("realItemData")] 
		public wCHandle<gameItemData> RealItemData
		{
			get => GetProperty(ref _realItemData);
			set => SetProperty(ref _realItemData, value);
		}

		[Ordinal(7)] 
		[RED("recipeItemData")] 
		public CHandle<gameItemData> RecipeItemData
		{
			get => GetProperty(ref _recipeItemData);
			set => SetProperty(ref _recipeItemData, value);
		}

		[Ordinal(8)] 
		[RED("itemRecord")] 
		public wCHandle<gamedataItem_Record> ItemRecord
		{
			get => GetProperty(ref _itemRecord);
			set => SetProperty(ref _itemRecord, value);
		}

		[Ordinal(9)] 
		[RED("realItemRecord")] 
		public wCHandle<gamedataItem_Record> RealItemRecord
		{
			get => GetProperty(ref _realItemRecord);
			set => SetProperty(ref _realItemRecord, value);
		}

		[Ordinal(10)] 
		[RED("itemTweakID")] 
		public TweakDBID ItemTweakID
		{
			get => GetProperty(ref _itemTweakID);
			set => SetProperty(ref _itemTweakID, value);
		}

		[Ordinal(11)] 
		[RED("realItemTweakID")] 
		public TweakDBID RealItemTweakID
		{
			get => GetProperty(ref _realItemTweakID);
			set => SetProperty(ref _realItemTweakID, value);
		}

		[Ordinal(12)] 
		[RED("data")] 
		public CHandle<UIInventoryItemInternalData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(13)] 
		[RED("weaponData")] 
		public CHandle<UIInventoryWeaponInternalData> WeaponData
		{
			get => GetProperty(ref _weaponData);
			set => SetProperty(ref _weaponData, value);
		}

		[Ordinal(14)] 
		[RED("programData")] 
		public CHandle<UIInventoryItemProgramData> ProgramData
		{
			get => GetProperty(ref _programData);
			set => SetProperty(ref _programData, value);
		}

		[Ordinal(15)] 
		[RED("grenadeData")] 
		public CHandle<UIInventoryItemGrenadeData> GrenadeData
		{
			get => GetProperty(ref _grenadeData);
			set => SetProperty(ref _grenadeData, value);
		}

		[Ordinal(16)] 
		[RED("cyberwareUpgradeData")] 
		public CHandle<InventoryTooltiData_CyberwareUpgradeData> CyberwareUpgradeData
		{
			get => GetProperty(ref _cyberwareUpgradeData);
			set => SetProperty(ref _cyberwareUpgradeData, value);
		}

		[Ordinal(17)] 
		[RED("parentItem")] 
		public wCHandle<gameItemData> ParentItem
		{
			get => GetProperty(ref _parentItem);
			set => SetProperty(ref _parentItem, value);
		}

		[Ordinal(18)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetProperty(ref _slotID);
			set => SetProperty(ref _slotID, value);
		}

		[Ordinal(19)] 
		[RED("fetchedFlags")] 
		public CInt32 FetchedFlags
		{
			get => GetProperty(ref _fetchedFlags);
			set => SetProperty(ref _fetchedFlags, value);
		}

		[Ordinal(20)] 
		[RED("isQuantityDirty")] 
		public CBool IsQuantityDirty
		{
			get => GetProperty(ref _isQuantityDirty);
			set => SetProperty(ref _isQuantityDirty, value);
		}

		[Ordinal(21)] 
		[RED("craftingResult")] 
		public wCHandle<gamedataCraftingResult_Record> CraftingResult
		{
			get => GetProperty(ref _craftingResult);
			set => SetProperty(ref _craftingResult, value);
		}

		[Ordinal(22)] 
		[RED("TEMP_isEquippedPrefetched")] 
		public CBool TEMP_isEquippedPrefetched
		{
			get => GetProperty(ref _tEMP_isEquippedPrefetched);
			set => SetProperty(ref _tEMP_isEquippedPrefetched, value);
		}

		[Ordinal(23)] 
		[RED("TEMP_isEquipped")] 
		public CBool TEMP_isEquipped
		{
			get => GetProperty(ref _tEMP_isEquipped);
			set => SetProperty(ref _tEMP_isEquipped, value);
		}

		public UIInventoryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
