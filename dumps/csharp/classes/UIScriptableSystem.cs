using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UIScriptableSystem : gameScriptableSystem
	{
		private CInt32 _backpackActiveSorting;
		private CInt32 _backpackActiveFilter;
		private CBool _isBackpackActiveFilterSaved;
		private CInt32 _vendorPanelPlayerActiveSorting;
		private CInt32 _vendorPanelVendorActiveSorting;
		private CArray<gameItemID> _playerFavouriteItems;
		private CArray<gameItemID> _newItems;
		private CArray<TweakDBID> _dLCAddedItems;
		private CArray<CEnum<gameWardrobeClothingSetIndex>> _newWardrobeSets;
		private CArray<gameItemID> _newWardrobeItems;
		private CArray<CName> _availableCars;
		private CArray<UIScriptableSystemAttributeLevel> _previousAttributeLevels;
		private CBool _comparisionTooltipDisabled;
		private wCHandle<PlayerPuppet> _attachedPlayer;
		private CHandle<UIScriptableInventoryListenerCallback> _inventoryListenerCallback;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CBool _dEV_useNewTooltips;
		private CBool _dEV_useLongScanTooltips;

		[Ordinal(0)] 
		[RED("backpackActiveSorting")] 
		public CInt32 BackpackActiveSorting
		{
			get => GetProperty(ref _backpackActiveSorting);
			set => SetProperty(ref _backpackActiveSorting, value);
		}

		[Ordinal(1)] 
		[RED("backpackActiveFilter")] 
		public CInt32 BackpackActiveFilter
		{
			get => GetProperty(ref _backpackActiveFilter);
			set => SetProperty(ref _backpackActiveFilter, value);
		}

		[Ordinal(2)] 
		[RED("isBackpackActiveFilterSaved")] 
		public CBool IsBackpackActiveFilterSaved
		{
			get => GetProperty(ref _isBackpackActiveFilterSaved);
			set => SetProperty(ref _isBackpackActiveFilterSaved, value);
		}

		[Ordinal(3)] 
		[RED("vendorPanelPlayerActiveSorting")] 
		public CInt32 VendorPanelPlayerActiveSorting
		{
			get => GetProperty(ref _vendorPanelPlayerActiveSorting);
			set => SetProperty(ref _vendorPanelPlayerActiveSorting, value);
		}

		[Ordinal(4)] 
		[RED("vendorPanelVendorActiveSorting")] 
		public CInt32 VendorPanelVendorActiveSorting
		{
			get => GetProperty(ref _vendorPanelVendorActiveSorting);
			set => SetProperty(ref _vendorPanelVendorActiveSorting, value);
		}

		[Ordinal(5)] 
		[RED("playerFavouriteItems")] 
		public CArray<gameItemID> PlayerFavouriteItems
		{
			get => GetProperty(ref _playerFavouriteItems);
			set => SetProperty(ref _playerFavouriteItems, value);
		}

		[Ordinal(6)] 
		[RED("newItems")] 
		public CArray<gameItemID> NewItems
		{
			get => GetProperty(ref _newItems);
			set => SetProperty(ref _newItems, value);
		}

		[Ordinal(7)] 
		[RED("DLCAddedItems")] 
		public CArray<TweakDBID> DLCAddedItems
		{
			get => GetProperty(ref _dLCAddedItems);
			set => SetProperty(ref _dLCAddedItems, value);
		}

		[Ordinal(8)] 
		[RED("newWardrobeSets")] 
		public CArray<CEnum<gameWardrobeClothingSetIndex>> NewWardrobeSets
		{
			get => GetProperty(ref _newWardrobeSets);
			set => SetProperty(ref _newWardrobeSets, value);
		}

		[Ordinal(9)] 
		[RED("newWardrobeItems")] 
		public CArray<gameItemID> NewWardrobeItems
		{
			get => GetProperty(ref _newWardrobeItems);
			set => SetProperty(ref _newWardrobeItems, value);
		}

		[Ordinal(10)] 
		[RED("availableCars")] 
		public CArray<CName> AvailableCars
		{
			get => GetProperty(ref _availableCars);
			set => SetProperty(ref _availableCars, value);
		}

		[Ordinal(11)] 
		[RED("previousAttributeLevels")] 
		public CArray<UIScriptableSystemAttributeLevel> PreviousAttributeLevels
		{
			get => GetProperty(ref _previousAttributeLevels);
			set => SetProperty(ref _previousAttributeLevels, value);
		}

		[Ordinal(12)] 
		[RED("comparisionTooltipDisabled")] 
		public CBool ComparisionTooltipDisabled
		{
			get => GetProperty(ref _comparisionTooltipDisabled);
			set => SetProperty(ref _comparisionTooltipDisabled, value);
		}

		[Ordinal(13)] 
		[RED("attachedPlayer")] 
		public wCHandle<PlayerPuppet> AttachedPlayer
		{
			get => GetProperty(ref _attachedPlayer);
			set => SetProperty(ref _attachedPlayer, value);
		}

		[Ordinal(14)] 
		[RED("inventoryListenerCallback")] 
		public CHandle<UIScriptableInventoryListenerCallback> InventoryListenerCallback
		{
			get => GetProperty(ref _inventoryListenerCallback);
			set => SetProperty(ref _inventoryListenerCallback, value);
		}

		[Ordinal(15)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(16)] 
		[RED("DEV_useNewTooltips")] 
		public CBool DEV_useNewTooltips
		{
			get => GetProperty(ref _dEV_useNewTooltips);
			set => SetProperty(ref _dEV_useNewTooltips, value);
		}

		[Ordinal(17)] 
		[RED("DEV_useLongScanTooltips")] 
		public CBool DEV_useLongScanTooltips
		{
			get => GetProperty(ref _dEV_useLongScanTooltips);
			set => SetProperty(ref _dEV_useLongScanTooltips, value);
		}

		public UIScriptableSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
