using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInGameMenuGameController : gameuiBaseMenuGameController
	{
		private CArray<gameuiInGameMenuGameControllerItemSceneInfo> _itemSceneInfos;
		private CArray<gameuiGarmentSwitchEffectController> _garmentSwitchEffectControllers;
		private CBool _quickSaveInProgress;
		private CBool _wasHoldingMapHotKey;
		private CBool _controllerDisconnected;
		private CHandle<redCallbackObject> _showDeathScreenBBID;
		private CHandle<redCallbackObject> _breachingNetworkBBID;
		private CHandle<redCallbackObject> _triggerMenuEventBBID;
		private CHandle<redCallbackObject> _openStorageBBID;
		private CHandle<redCallbackObject> _controllerDisconnectedBBID;
		private CHandle<redCallbackObject> _bbOnEquipmentChangedID;
		private CHandle<redCallbackObject> _inputSchemesBBID;
		private CHandle<gameAttachmentSlotsScriptListener> _inventoryListener;
		private CHandle<inGameMenuAnimContainer> _animContainer;
		private CEnum<UIInGameNotificationType> _lastInGameNotificationType;
		private gameDelayID _loadSaveDelayID;
		private wCHandle<gameObject> _player;

		[Ordinal(3)] 
		[RED("itemSceneInfos")] 
		public CArray<gameuiInGameMenuGameControllerItemSceneInfo> ItemSceneInfos
		{
			get => GetProperty(ref _itemSceneInfos);
			set => SetProperty(ref _itemSceneInfos, value);
		}

		[Ordinal(4)] 
		[RED("garmentSwitchEffectControllers")] 
		public CArray<gameuiGarmentSwitchEffectController> GarmentSwitchEffectControllers
		{
			get => GetProperty(ref _garmentSwitchEffectControllers);
			set => SetProperty(ref _garmentSwitchEffectControllers, value);
		}

		[Ordinal(5)] 
		[RED("quickSaveInProgress")] 
		public CBool QuickSaveInProgress
		{
			get => GetProperty(ref _quickSaveInProgress);
			set => SetProperty(ref _quickSaveInProgress, value);
		}

		[Ordinal(6)] 
		[RED("wasHoldingMapHotKey")] 
		public CBool WasHoldingMapHotKey
		{
			get => GetProperty(ref _wasHoldingMapHotKey);
			set => SetProperty(ref _wasHoldingMapHotKey, value);
		}

		[Ordinal(7)] 
		[RED("controllerDisconnected")] 
		public CBool ControllerDisconnected
		{
			get => GetProperty(ref _controllerDisconnected);
			set => SetProperty(ref _controllerDisconnected, value);
		}

		[Ordinal(8)] 
		[RED("showDeathScreenBBID")] 
		public CHandle<redCallbackObject> ShowDeathScreenBBID
		{
			get => GetProperty(ref _showDeathScreenBBID);
			set => SetProperty(ref _showDeathScreenBBID, value);
		}

		[Ordinal(9)] 
		[RED("breachingNetworkBBID")] 
		public CHandle<redCallbackObject> BreachingNetworkBBID
		{
			get => GetProperty(ref _breachingNetworkBBID);
			set => SetProperty(ref _breachingNetworkBBID, value);
		}

		[Ordinal(10)] 
		[RED("triggerMenuEventBBID")] 
		public CHandle<redCallbackObject> TriggerMenuEventBBID
		{
			get => GetProperty(ref _triggerMenuEventBBID);
			set => SetProperty(ref _triggerMenuEventBBID, value);
		}

		[Ordinal(11)] 
		[RED("openStorageBBID")] 
		public CHandle<redCallbackObject> OpenStorageBBID
		{
			get => GetProperty(ref _openStorageBBID);
			set => SetProperty(ref _openStorageBBID, value);
		}

		[Ordinal(12)] 
		[RED("controllerDisconnectedBBID")] 
		public CHandle<redCallbackObject> ControllerDisconnectedBBID
		{
			get => GetProperty(ref _controllerDisconnectedBBID);
			set => SetProperty(ref _controllerDisconnectedBBID, value);
		}

		[Ordinal(13)] 
		[RED("bbOnEquipmentChangedID")] 
		public CHandle<redCallbackObject> BbOnEquipmentChangedID
		{
			get => GetProperty(ref _bbOnEquipmentChangedID);
			set => SetProperty(ref _bbOnEquipmentChangedID, value);
		}

		[Ordinal(14)] 
		[RED("inputSchemesBBID")] 
		public CHandle<redCallbackObject> InputSchemesBBID
		{
			get => GetProperty(ref _inputSchemesBBID);
			set => SetProperty(ref _inputSchemesBBID, value);
		}

		[Ordinal(15)] 
		[RED("inventoryListener")] 
		public CHandle<gameAttachmentSlotsScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(16)] 
		[RED("animContainer")] 
		public CHandle<inGameMenuAnimContainer> AnimContainer
		{
			get => GetProperty(ref _animContainer);
			set => SetProperty(ref _animContainer, value);
		}

		[Ordinal(17)] 
		[RED("lastInGameNotificationType")] 
		public CEnum<UIInGameNotificationType> LastInGameNotificationType
		{
			get => GetProperty(ref _lastInGameNotificationType);
			set => SetProperty(ref _lastInGameNotificationType, value);
		}

		[Ordinal(18)] 
		[RED("loadSaveDelayID")] 
		public gameDelayID LoadSaveDelayID
		{
			get => GetProperty(ref _loadSaveDelayID);
			set => SetProperty(ref _loadSaveDelayID, value);
		}

		[Ordinal(19)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		public gameuiInGameMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
