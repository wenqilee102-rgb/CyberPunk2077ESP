using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Vendor : IScriptable
	{
		private ScriptGameInstance _gameInstance;
		private wCHandle<gameObject> _vendorObject;
		private TweakDBID _tweakID;
		private CFloat _lastInteractionTime;
		private CArray<gameSItemStack> _stock;
		private CArray<TweakDBID> _newItems;
		private CHandle<SoldItemsCache> _soldItems;
		private CFloat _priceMultiplier;
		private gamePersistentID _vendorPersistentID;
		private CBool _stockInit;
		private CBool _playerHacksInit;
		private CBool _inventoryInit;
		private CBool _isAttached;
		private CBool _inventoryReinitWithPlayerStats;
		private wCHandle<gamedataVendor_Record> _vendorRecord;
		private CArray<gameItemID> _playerHacks;

		[Ordinal(0)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(1)] 
		[RED("vendorObject")] 
		public wCHandle<gameObject> VendorObject
		{
			get => GetProperty(ref _vendorObject);
			set => SetProperty(ref _vendorObject, value);
		}

		[Ordinal(2)] 
		[RED("tweakID")] 
		public TweakDBID TweakID
		{
			get => GetProperty(ref _tweakID);
			set => SetProperty(ref _tweakID, value);
		}

		[Ordinal(3)] 
		[RED("lastInteractionTime")] 
		public CFloat LastInteractionTime
		{
			get => GetProperty(ref _lastInteractionTime);
			set => SetProperty(ref _lastInteractionTime, value);
		}

		[Ordinal(4)] 
		[RED("stock")] 
		public CArray<gameSItemStack> Stock
		{
			get => GetProperty(ref _stock);
			set => SetProperty(ref _stock, value);
		}

		[Ordinal(5)] 
		[RED("newItems")] 
		public CArray<TweakDBID> NewItems
		{
			get => GetProperty(ref _newItems);
			set => SetProperty(ref _newItems, value);
		}

		[Ordinal(6)] 
		[RED("soldItems")] 
		public CHandle<SoldItemsCache> SoldItems
		{
			get => GetProperty(ref _soldItems);
			set => SetProperty(ref _soldItems, value);
		}

		[Ordinal(7)] 
		[RED("priceMultiplier")] 
		public CFloat PriceMultiplier
		{
			get => GetProperty(ref _priceMultiplier);
			set => SetProperty(ref _priceMultiplier, value);
		}

		[Ordinal(8)] 
		[RED("vendorPersistentID")] 
		public gamePersistentID VendorPersistentID
		{
			get => GetProperty(ref _vendorPersistentID);
			set => SetProperty(ref _vendorPersistentID, value);
		}

		[Ordinal(9)] 
		[RED("stockInit")] 
		public CBool StockInit
		{
			get => GetProperty(ref _stockInit);
			set => SetProperty(ref _stockInit, value);
		}

		[Ordinal(10)] 
		[RED("playerHacksInit")] 
		public CBool PlayerHacksInit
		{
			get => GetProperty(ref _playerHacksInit);
			set => SetProperty(ref _playerHacksInit, value);
		}

		[Ordinal(11)] 
		[RED("inventoryInit")] 
		public CBool InventoryInit
		{
			get => GetProperty(ref _inventoryInit);
			set => SetProperty(ref _inventoryInit, value);
		}

		[Ordinal(12)] 
		[RED("isAttached")] 
		public CBool IsAttached
		{
			get => GetProperty(ref _isAttached);
			set => SetProperty(ref _isAttached, value);
		}

		[Ordinal(13)] 
		[RED("inventoryReinitWithPlayerStats")] 
		public CBool InventoryReinitWithPlayerStats
		{
			get => GetProperty(ref _inventoryReinitWithPlayerStats);
			set => SetProperty(ref _inventoryReinitWithPlayerStats, value);
		}

		[Ordinal(14)] 
		[RED("vendorRecord")] 
		public wCHandle<gamedataVendor_Record> VendorRecord
		{
			get => GetProperty(ref _vendorRecord);
			set => SetProperty(ref _vendorRecord, value);
		}

		[Ordinal(15)] 
		[RED("playerHacks")] 
		public CArray<gameItemID> PlayerHacks
		{
			get => GetProperty(ref _playerHacks);
			set => SetProperty(ref _playerHacks, value);
		}

		public Vendor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
