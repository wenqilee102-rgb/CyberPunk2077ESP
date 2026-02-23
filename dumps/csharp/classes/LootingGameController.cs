using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LootingGameController : gameuiWidgetGameController
	{
		private CHandle<InventoryDataManagerV2> _dataManager;
		private wCHandle<UIInventoryScriptableSystem> _uiInventorySystem;
		private wCHandle<gameIBlackboard> _bbInteractions;
		private wCHandle<gameIBlackboard> _bbEquipmentData;
		private wCHandle<gameIBlackboard> _bbEquipment;
		private CHandle<UIInteractionsDef> _bbInteractionsDefinition;
		private CHandle<UI_EquipmentDataDef> _bbEquipmentDataDefinition;
		private CHandle<UI_EquipmentDef> _bbEquipmentDefinition;
		private CHandle<redCallbackObject> _dataListenerId;
		private CHandle<redCallbackObject> _activeListenerId;
		private CHandle<redCallbackObject> _activeHubListenerId;
		private CHandle<redCallbackObject> _weaponDataListenerId;
		private CHandle<redCallbackObject> _itemEquippedListenerId;
		private wCHandle<LootingController> _controller;
		private wCHandle<PlayerPuppet> _player;
		private CHandle<inkanimProxy> _introAnim;
		private CHandle<inkanimProxy> _outroAnim;
		private gameSlotWeaponData _lastActiveWeapon;
		private gameItemID _lastActiveWeaponID;
		private gameinteractionsvisLootData _previousData;
		private entEntityID _lastActiveOwnerId;

		[Ordinal(2)] 
		[RED("dataManager")] 
		public CHandle<InventoryDataManagerV2> DataManager
		{
			get => GetProperty(ref _dataManager);
			set => SetProperty(ref _dataManager, value);
		}

		[Ordinal(3)] 
		[RED("uiInventorySystem")] 
		public wCHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetProperty(ref _uiInventorySystem);
			set => SetProperty(ref _uiInventorySystem, value);
		}

		[Ordinal(4)] 
		[RED("bbInteractions")] 
		public wCHandle<gameIBlackboard> BbInteractions
		{
			get => GetProperty(ref _bbInteractions);
			set => SetProperty(ref _bbInteractions, value);
		}

		[Ordinal(5)] 
		[RED("bbEquipmentData")] 
		public wCHandle<gameIBlackboard> BbEquipmentData
		{
			get => GetProperty(ref _bbEquipmentData);
			set => SetProperty(ref _bbEquipmentData, value);
		}

		[Ordinal(6)] 
		[RED("bbEquipment")] 
		public wCHandle<gameIBlackboard> BbEquipment
		{
			get => GetProperty(ref _bbEquipment);
			set => SetProperty(ref _bbEquipment, value);
		}

		[Ordinal(7)] 
		[RED("bbInteractionsDefinition")] 
		public CHandle<UIInteractionsDef> BbInteractionsDefinition
		{
			get => GetProperty(ref _bbInteractionsDefinition);
			set => SetProperty(ref _bbInteractionsDefinition, value);
		}

		[Ordinal(8)] 
		[RED("bbEquipmentDataDefinition")] 
		public CHandle<UI_EquipmentDataDef> BbEquipmentDataDefinition
		{
			get => GetProperty(ref _bbEquipmentDataDefinition);
			set => SetProperty(ref _bbEquipmentDataDefinition, value);
		}

		[Ordinal(9)] 
		[RED("bbEquipmentDefinition")] 
		public CHandle<UI_EquipmentDef> BbEquipmentDefinition
		{
			get => GetProperty(ref _bbEquipmentDefinition);
			set => SetProperty(ref _bbEquipmentDefinition, value);
		}

		[Ordinal(10)] 
		[RED("dataListenerId")] 
		public CHandle<redCallbackObject> DataListenerId
		{
			get => GetProperty(ref _dataListenerId);
			set => SetProperty(ref _dataListenerId, value);
		}

		[Ordinal(11)] 
		[RED("activeListenerId")] 
		public CHandle<redCallbackObject> ActiveListenerId
		{
			get => GetProperty(ref _activeListenerId);
			set => SetProperty(ref _activeListenerId, value);
		}

		[Ordinal(12)] 
		[RED("activeHubListenerId")] 
		public CHandle<redCallbackObject> ActiveHubListenerId
		{
			get => GetProperty(ref _activeHubListenerId);
			set => SetProperty(ref _activeHubListenerId, value);
		}

		[Ordinal(13)] 
		[RED("weaponDataListenerId")] 
		public CHandle<redCallbackObject> WeaponDataListenerId
		{
			get => GetProperty(ref _weaponDataListenerId);
			set => SetProperty(ref _weaponDataListenerId, value);
		}

		[Ordinal(14)] 
		[RED("itemEquippedListenerId")] 
		public CHandle<redCallbackObject> ItemEquippedListenerId
		{
			get => GetProperty(ref _itemEquippedListenerId);
			set => SetProperty(ref _itemEquippedListenerId, value);
		}

		[Ordinal(15)] 
		[RED("controller")] 
		public wCHandle<LootingController> Controller
		{
			get => GetProperty(ref _controller);
			set => SetProperty(ref _controller, value);
		}

		[Ordinal(16)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(17)] 
		[RED("introAnim")] 
		public CHandle<inkanimProxy> IntroAnim
		{
			get => GetProperty(ref _introAnim);
			set => SetProperty(ref _introAnim, value);
		}

		[Ordinal(18)] 
		[RED("outroAnim")] 
		public CHandle<inkanimProxy> OutroAnim
		{
			get => GetProperty(ref _outroAnim);
			set => SetProperty(ref _outroAnim, value);
		}

		[Ordinal(19)] 
		[RED("lastActiveWeapon")] 
		public gameSlotWeaponData LastActiveWeapon
		{
			get => GetProperty(ref _lastActiveWeapon);
			set => SetProperty(ref _lastActiveWeapon, value);
		}

		[Ordinal(20)] 
		[RED("lastActiveWeaponID")] 
		public gameItemID LastActiveWeaponID
		{
			get => GetProperty(ref _lastActiveWeaponID);
			set => SetProperty(ref _lastActiveWeaponID, value);
		}

		[Ordinal(21)] 
		[RED("previousData")] 
		public gameinteractionsvisLootData PreviousData
		{
			get => GetProperty(ref _previousData);
			set => SetProperty(ref _previousData, value);
		}

		[Ordinal(22)] 
		[RED("lastActiveOwnerId")] 
		public entEntityID LastActiveOwnerId
		{
			get => GetProperty(ref _lastActiveOwnerId);
			set => SetProperty(ref _lastActiveOwnerId, value);
		}

		public LootingGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
