using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendorHubMenuGameController : gameuiMenuGameController
	{
		private inkWidgetReference _notificationRoot;
		private inkWidgetReference _tabRootContainer;
		private inkWidgetReference _tabRootRef;
		private inkWidgetReference _playerCredits;
		private inkTextWidgetReference _playerCreditsValue;
		private inkWidgetReference _playerWeight;
		private inkTextWidgetReference _playerWeightValue;
		private inkTextWidgetReference _vendorShopLabel;
		private inkTextWidgetReference _levelValue;
		private inkTextWidgetReference _streetCredLabel;
		private inkWidgetReference _levelBarProgress;
		private inkWidgetReference _levelBarSpacer;
		private inkWidgetReference _streetCredBarProgress;
		private inkWidgetReference _streetCredBarSpacer;
		private CHandle<VendorDataManager> _vendorDataManager;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<questVendorPanelData> _vendorPanelData;
		private CHandle<StorageUserData> _storageUserData;
		private CHandle<PlayerDevelopmentSystem> _pDS;
		private wCHandle<inkWidget> _root;
		private wCHandle<TabRadioGroup> _tabRoot;
		private wCHandle<MoneyLabelController> _playerMoneyAnimator;
		private CBool _isRipperdoc;
		private CBool _isRipperdocViktorTutorial;
		private wCHandle<gameStatusEffectSystem> _statusEffectSystem;
		private wCHandle<questQuestsSystem> _questSystem;
		private CHandle<RipperdocTimeDilationCallback> _ripperdocTimeDilationCallback;
		private CBool _timeDilationEnabling;
		private CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>> _equipAnimationCategories;
		private wCHandle<gameIBlackboard> _vendorBlackboard;
		private wCHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<UI_VendorDef> _vendorBlackboardDef;
		private CHandle<redCallbackObject> _vendorUpdatedCallbackID;
		private CHandle<redCallbackObject> _weightListener;
		private CHandle<redCallbackObject> _characterLevelListener;
		private CHandle<redCallbackObject> _characterCurrentXPListener;
		private CHandle<redCallbackObject> _characterCredListener;
		private CHandle<redCallbackObject> _characterCredPointsListener;
		private CHandle<redCallbackObject> _characterCurrentHealthListener;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private wCHandle<PlayerPuppet> _player;
		private CArray<MenuData> _menuData;
		private CInt32 _activeMenu;
		private CBool _isChangedManually;
		private CBool _cameFromRipperdoc;
		private CHandle<StorageBlackboardDef> _storageDef;
		private wCHandle<gameIBlackboard> _storageBlackboard;

		[Ordinal(3)] 
		[RED("notificationRoot")] 
		public inkWidgetReference NotificationRoot
		{
			get => GetProperty(ref _notificationRoot);
			set => SetProperty(ref _notificationRoot, value);
		}

		[Ordinal(4)] 
		[RED("tabRootContainer")] 
		public inkWidgetReference TabRootContainer
		{
			get => GetProperty(ref _tabRootContainer);
			set => SetProperty(ref _tabRootContainer, value);
		}

		[Ordinal(5)] 
		[RED("tabRootRef")] 
		public inkWidgetReference TabRootRef
		{
			get => GetProperty(ref _tabRootRef);
			set => SetProperty(ref _tabRootRef, value);
		}

		[Ordinal(6)] 
		[RED("playerCredits")] 
		public inkWidgetReference PlayerCredits
		{
			get => GetProperty(ref _playerCredits);
			set => SetProperty(ref _playerCredits, value);
		}

		[Ordinal(7)] 
		[RED("playerCreditsValue")] 
		public inkTextWidgetReference PlayerCreditsValue
		{
			get => GetProperty(ref _playerCreditsValue);
			set => SetProperty(ref _playerCreditsValue, value);
		}

		[Ordinal(8)] 
		[RED("playerWeight")] 
		public inkWidgetReference PlayerWeight
		{
			get => GetProperty(ref _playerWeight);
			set => SetProperty(ref _playerWeight, value);
		}

		[Ordinal(9)] 
		[RED("playerWeightValue")] 
		public inkTextWidgetReference PlayerWeightValue
		{
			get => GetProperty(ref _playerWeightValue);
			set => SetProperty(ref _playerWeightValue, value);
		}

		[Ordinal(10)] 
		[RED("vendorShopLabel")] 
		public inkTextWidgetReference VendorShopLabel
		{
			get => GetProperty(ref _vendorShopLabel);
			set => SetProperty(ref _vendorShopLabel, value);
		}

		[Ordinal(11)] 
		[RED("levelValue")] 
		public inkTextWidgetReference LevelValue
		{
			get => GetProperty(ref _levelValue);
			set => SetProperty(ref _levelValue, value);
		}

		[Ordinal(12)] 
		[RED("streetCredLabel")] 
		public inkTextWidgetReference StreetCredLabel
		{
			get => GetProperty(ref _streetCredLabel);
			set => SetProperty(ref _streetCredLabel, value);
		}

		[Ordinal(13)] 
		[RED("levelBarProgress")] 
		public inkWidgetReference LevelBarProgress
		{
			get => GetProperty(ref _levelBarProgress);
			set => SetProperty(ref _levelBarProgress, value);
		}

		[Ordinal(14)] 
		[RED("levelBarSpacer")] 
		public inkWidgetReference LevelBarSpacer
		{
			get => GetProperty(ref _levelBarSpacer);
			set => SetProperty(ref _levelBarSpacer, value);
		}

		[Ordinal(15)] 
		[RED("streetCredBarProgress")] 
		public inkWidgetReference StreetCredBarProgress
		{
			get => GetProperty(ref _streetCredBarProgress);
			set => SetProperty(ref _streetCredBarProgress, value);
		}

		[Ordinal(16)] 
		[RED("streetCredBarSpacer")] 
		public inkWidgetReference StreetCredBarSpacer
		{
			get => GetProperty(ref _streetCredBarSpacer);
			set => SetProperty(ref _streetCredBarSpacer, value);
		}

		[Ordinal(17)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(18)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetProperty(ref _vendorUserData);
			set => SetProperty(ref _vendorUserData, value);
		}

		[Ordinal(19)] 
		[RED("vendorPanelData")] 
		public CHandle<questVendorPanelData> VendorPanelData
		{
			get => GetProperty(ref _vendorPanelData);
			set => SetProperty(ref _vendorPanelData, value);
		}

		[Ordinal(20)] 
		[RED("storageUserData")] 
		public CHandle<StorageUserData> StorageUserData
		{
			get => GetProperty(ref _storageUserData);
			set => SetProperty(ref _storageUserData, value);
		}

		[Ordinal(21)] 
		[RED("PDS")] 
		public CHandle<PlayerDevelopmentSystem> PDS
		{
			get => GetProperty(ref _pDS);
			set => SetProperty(ref _pDS, value);
		}

		[Ordinal(22)] 
		[RED("root")] 
		public wCHandle<inkWidget> Root
		{
			get => GetProperty(ref _root);
			set => SetProperty(ref _root, value);
		}

		[Ordinal(23)] 
		[RED("tabRoot")] 
		public wCHandle<TabRadioGroup> TabRoot
		{
			get => GetProperty(ref _tabRoot);
			set => SetProperty(ref _tabRoot, value);
		}

		[Ordinal(24)] 
		[RED("playerMoneyAnimator")] 
		public wCHandle<MoneyLabelController> PlayerMoneyAnimator
		{
			get => GetProperty(ref _playerMoneyAnimator);
			set => SetProperty(ref _playerMoneyAnimator, value);
		}

		[Ordinal(25)] 
		[RED("isRipperdoc")] 
		public CBool IsRipperdoc
		{
			get => GetProperty(ref _isRipperdoc);
			set => SetProperty(ref _isRipperdoc, value);
		}

		[Ordinal(26)] 
		[RED("isRipperdocViktorTutorial")] 
		public CBool IsRipperdocViktorTutorial
		{
			get => GetProperty(ref _isRipperdocViktorTutorial);
			set => SetProperty(ref _isRipperdocViktorTutorial, value);
		}

		[Ordinal(27)] 
		[RED("statusEffectSystem")] 
		public wCHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetProperty(ref _statusEffectSystem);
			set => SetProperty(ref _statusEffectSystem, value);
		}

		[Ordinal(28)] 
		[RED("questSystem")] 
		public wCHandle<questQuestsSystem> QuestSystem
		{
			get => GetProperty(ref _questSystem);
			set => SetProperty(ref _questSystem, value);
		}

		[Ordinal(29)] 
		[RED("ripperdocTimeDilationCallback")] 
		public CHandle<RipperdocTimeDilationCallback> RipperdocTimeDilationCallback
		{
			get => GetProperty(ref _ripperdocTimeDilationCallback);
			set => SetProperty(ref _ripperdocTimeDilationCallback, value);
		}

		[Ordinal(30)] 
		[RED("timeDilationEnabling")] 
		public CBool TimeDilationEnabling
		{
			get => GetProperty(ref _timeDilationEnabling);
			set => SetProperty(ref _timeDilationEnabling, value);
		}

		[Ordinal(31)] 
		[RED("equipAnimationCategories")] 
		public CArray<CHandle<RipperdocCyberwareEquipAnimationCategory>> EquipAnimationCategories
		{
			get => GetProperty(ref _equipAnimationCategories);
			set => SetProperty(ref _equipAnimationCategories, value);
		}

		[Ordinal(32)] 
		[RED("VendorBlackboard")] 
		public wCHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(33)] 
		[RED("playerStatsBlackboard")] 
		public wCHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(34)] 
		[RED("VendorBlackboardDef")] 
		public CHandle<UI_VendorDef> VendorBlackboardDef
		{
			get => GetProperty(ref _vendorBlackboardDef);
			set => SetProperty(ref _vendorBlackboardDef, value);
		}

		[Ordinal(35)] 
		[RED("VendorUpdatedCallbackID")] 
		public CHandle<redCallbackObject> VendorUpdatedCallbackID
		{
			get => GetProperty(ref _vendorUpdatedCallbackID);
			set => SetProperty(ref _vendorUpdatedCallbackID, value);
		}

		[Ordinal(36)] 
		[RED("weightListener")] 
		public CHandle<redCallbackObject> WeightListener
		{
			get => GetProperty(ref _weightListener);
			set => SetProperty(ref _weightListener, value);
		}

		[Ordinal(37)] 
		[RED("characterLevelListener")] 
		public CHandle<redCallbackObject> CharacterLevelListener
		{
			get => GetProperty(ref _characterLevelListener);
			set => SetProperty(ref _characterLevelListener, value);
		}

		[Ordinal(38)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(39)] 
		[RED("characterCredListener")] 
		public CHandle<redCallbackObject> CharacterCredListener
		{
			get => GetProperty(ref _characterCredListener);
			set => SetProperty(ref _characterCredListener, value);
		}

		[Ordinal(40)] 
		[RED("characterCredPointsListener")] 
		public CHandle<redCallbackObject> CharacterCredPointsListener
		{
			get => GetProperty(ref _characterCredPointsListener);
			set => SetProperty(ref _characterCredPointsListener, value);
		}

		[Ordinal(41)] 
		[RED("characterCurrentHealthListener")] 
		public CHandle<redCallbackObject> CharacterCurrentHealthListener
		{
			get => GetProperty(ref _characterCurrentHealthListener);
			set => SetProperty(ref _characterCurrentHealthListener, value);
		}

		[Ordinal(42)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(43)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(44)] 
		[RED("menuData")] 
		public CArray<MenuData> MenuData
		{
			get => GetProperty(ref _menuData);
			set => SetProperty(ref _menuData, value);
		}

		[Ordinal(45)] 
		[RED("activeMenu")] 
		public CInt32 ActiveMenu
		{
			get => GetProperty(ref _activeMenu);
			set => SetProperty(ref _activeMenu, value);
		}

		[Ordinal(46)] 
		[RED("isChangedManually")] 
		public CBool IsChangedManually
		{
			get => GetProperty(ref _isChangedManually);
			set => SetProperty(ref _isChangedManually, value);
		}

		[Ordinal(47)] 
		[RED("cameFromRipperdoc")] 
		public CBool CameFromRipperdoc
		{
			get => GetProperty(ref _cameFromRipperdoc);
			set => SetProperty(ref _cameFromRipperdoc, value);
		}

		[Ordinal(48)] 
		[RED("storageDef")] 
		public CHandle<StorageBlackboardDef> StorageDef
		{
			get => GetProperty(ref _storageDef);
			set => SetProperty(ref _storageDef, value);
		}

		[Ordinal(49)] 
		[RED("storageBlackboard")] 
		public wCHandle<gameIBlackboard> StorageBlackboard
		{
			get => GetProperty(ref _storageBlackboard);
			set => SetProperty(ref _storageBlackboard, value);
		}

		public VendorHubMenuGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
