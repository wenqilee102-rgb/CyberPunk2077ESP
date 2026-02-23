using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RipperDocGameController : gameuiMenuGameController
	{
		private inkWidgetReference _tooltipsManagerRef;
		private inkWidgetReference _buttonHintsManagerRef;
		private inkWidgetReference _animationControllerContainer;
		private inkCompoundWidgetReference _armsAnchor;
		private inkCompoundWidgetReference _legsAnchor;
		private inkCompoundWidgetReference _handsAnchor;
		private inkCompoundWidgetReference _systemAnchor;
		private inkCompoundWidgetReference _nervousAnchor;
		private inkCompoundWidgetReference _skeletonAnchor;
		private inkCompoundWidgetReference _ocularCortexAnchor;
		private inkCompoundWidgetReference _integumentaryAnchor;
		private inkCompoundWidgetReference _frontalCortexAnchor;
		private inkCompoundWidgetReference _cardiovascularAnchor;
		private inkCompoundWidgetReference _minigridTargetAnchor;
		private inkMargin _minigridTargetAnchorMargin;
		private inkCompoundWidgetReference _minigridSelectorLeftAnchor;
		private inkCompoundWidgetReference _minigridSelectorRightAnchor;
		private inkMargin _minigridSelectorLeftAnchorMargin;
		private inkMargin _minigridSelectorRightAnchorMargin;
		private inkWidgetReference _tooltipLeftAnchor;
		private inkWidgetReference _tooltipRightAnchor;
		private inkCompoundWidgetReference _upgradeResourcesAnchor;
		private CName _upgradeCWInputName;
		private CFloat _upgradeResourcesContainerMaxWidth;
		private inkCompoundWidgetReference _allocationPointContainerDefault;
		private inkCompoundWidgetReference _inventoryViewAnchor;
		private inkCompoundWidgetReference _selectorAnchor;
		private inkWidgetReference _inventoryWarnning;
		private inkVideoWidgetReference _maleEyeAndMaskBinkAnimation;
		private inkVideoWidgetReference _femaleEyeAndMaskBinkAnimation;
		private redResourceReferenceScriptToken _c_maleOcular;
		private redResourceReferenceScriptToken _c_femaleOcular;
		private redResourceReferenceScriptToken _c_maleMask;
		private redResourceReferenceScriptToken _c_femaleMask;
		private CFloat _minigridSetPositionAnimationSpeed;
		private CEnum<inkanimInterpolationType> _minigridSetPositionAnimInterpolationType;
		private CEnum<inkanimInterpolationMode> _minigridSetPositionAnimInterpolationMode;
		private CFloat _minigridIntroAnimationSpeed;
		private CEnum<inkanimInterpolationType> _minigridIntroAnimInterpolationType;
		private CEnum<inkanimInterpolationMode> _minigridIntroAnimInterpolationMode;
		private inkWidgetReference _capacityTutorialAnchor;
		private inkWidgetReference _armorTutorialAnchor;
		private inkWidgetReference _slotsTutorialAnchor;
		private CBool _vikTutorial;
		private CBool _isTutorial;
		private CBool _ep1StandaloneTutorial;
		private CBool _mq048TutorialFact;
		private CBool _isReturningPlayer;
		private TweakDBID _tutorialEyesCW;
		private TweakDBID _tutorialHandsCW;
		private TweakDBID _tutorialArmorCW;
		private CHandle<gameStatModifierData_Deprecated> _tutorialZeroCapacityModifier;
		private CEnum<gamedataNewPerkType> _perkBarCapacity;
		private CEnum<gamedataNewPerkType> _perkBarArmor;
		private CEnum<gamedataNewPerkType> _perkSlotSkeleton;
		private CEnum<gamedataNewPerkType> _perkSlotHands;
		private CEnum<RipperdocHoverState> _ripperdocHoverState;
		private CEnum<CyberwareScreenType> _screen;
		private CEnum<RipperdocModes> _filterMode;
		private wCHandle<PlayerPuppet> _player;
		private wCHandle<gameGameAudioSystem> _audioSystem;
		private wCHandle<gameuiGameSystemUI> _uiSystem;
		private wCHandle<questQuestsSystem> _questSystem;
		private entEntityID _playerID;
		private CHandle<InventoryDataManagerV2> _inventoryManager;
		private wCHandle<UIScriptableSystem> _uiScriptableSystem;
		private wCHandle<UIInventoryScriptableSystem> _uiInventorySystem;
		private wCHandle<inkMenuEventDispatcher> _menuEventDispatcher;
		private CHandle<RipperdocTokenManager> _ripperdocTokenManager;
		private CArray<RipperdocCategory> _categories;
		private wCHandle<gameuiTooltipsManager> _tooltipsManager;
		private inkMargin _defaultTooltipsMargin;
		private CFloat _defaultTooltipGap;
		private wCHandle<gameIBlackboard> _vendorBlackboard;
		private wCHandle<gameIBlackboard> _equipmentBlackboard;
		private CHandle<redCallbackObject> _equipmentBlackboardCallback;
		private wCHandle<gameIBlackboard> _tokenBlackboard;
		private CHandle<redCallbackObject> _tokenBlackboardCallback;
		private wCHandle<RipperdocInventoryController> _inventoryView;
		private wCHandle<RipperdocSelectorController> _selector;
		private CEnum<gamedataEquipmentArea> _dollHoverArea;
		private CBool _dollSelected;
		private CEnum<gamedataEquipmentArea> _hoverArea;
		private CEnum<gamedataEquipmentArea> _filterArea;
		private CEnum<gamedataEquipmentArea> _lastAreaVisited;
		private CBool _filteringByArea;
		private CBool _isInEquipPopup;
		private CBool _isInventoryOpen;
		private CArray<CEnum<gamedataEquipmentArea>> _allFilters;
		private CArray<CInt32> _cachedAvailableItemsCounters;
		private CArray<CInt32> _cachedVendorItemsCounters;
		private CArray<CInt32> _cachedPlayerItemsCounters;
		private CArrayFixedSize<CArray<wCHandle<UIInventoryItem>>> _cachedPlayerItems;
		private CArrayFixedSize<CArray<wCHandle<WrappedUIInventoryItem>>> _cachedVendorItems;
		private CHandle<inkScriptHashMap> _vendorItems;
		private CHandle<inkScriptHashMap> _vendorWrappedItems;
		private CHandle<SoldItemsCache> _soldItemsCache;
		private CArray<wCHandle<CrafringMaterialItemController>> _craftingMaterialsListItems;
		private CBool _upgradeHoldFinished;
		private CArray<CHandle<CachedCraftingMaterial>> _commonCraftingMaterials;
		private CArray<wCHandle<CyberwareInventoryMiniGrid>> _equipmentMinigrids;
		private CArrayFixedSize<CEnum<gamedataEquipmentArea>> _minigridsMap;
		private CBool _isActivePanel;
		private CBool _hasEquipEventTriggered;
		private CBool _hasUnequipEventTriggered;
		private wCHandle<gameStatsSystem> _statsSystem;
		private wCHandle<gameStatsDataSystem> _statsDataSystem;
		private wCHandle<gameStatusEffectSystem> _statusEffectSystem;
		private wCHandle<gameInventoryManager> _inventorySystem;
		private CBool _isPurchased;
		private CBool _isPurchasing;
		private CBool _isPurchaseEquip;
		private CBool _isUpgrading;
		private wCHandle<CyberwareInventoryMiniGrid> _previewMinigrid;
		private CInt32 _equippedSlotIndex;
		private CBool _isMusculoskeletalUpgrade3Unlocked;
		private CBool _handleItemEquippedNextFrameRequested;
		private TweakDBID _handleItemEquippedOnItemAdded;
		private CHandle<gameInventoryScriptListener> _inventoryListener;
		private CHandle<inkGameNotificationToken> _tokenPopup;
		private CHandle<ItemDisplayContextData> _playerItemDisplayContext;
		private CHandle<ItemDisplayContextData> _vendorItemDisplayContext;
		private CBool _inventoryRefreshRequested;
		private CBool _invalidateMinigridsRequested;
		private CHandle<RipperdocTokenPopupData> _upgradeData;
		private CHandle<VendorUserData> _vendorUserData;
		private CHandle<VendorDataManager> _vendorDataManager;
		private wCHandle<ButtonHints> _buttonHintsController;
		private CBool _soldItemsFetched;
		private wCHandle<RipperdocScreenAnimationController> _animationController;
		private CBool _isHoveringOverUpgradableSlot;
		private CEnum<gamedataQuality> _upgradeQuality;
		private CyberwareUpgradeCostData _upgradeCostData;
		private CHandle<gamedataItem_Record> _upgradeItem;
		private wCHandle<UIInventoryItem> _hoveredItem;
		private wCHandle<InventoryItemDisplayController> _hoveredItemDisplay;
		private CHandle<PulseAnimation> _pulse;
		private CHandle<inkanimProxy> _anim;
		private CHandle<PlayerDevelopmentDataManager> _developmentDataManager;
		private CHandle<RipperdocMeterCapacityHoverEvent> _capacityHoverEvent;
		private CHandle<RipperdocMeterCapacityApplyEvent> _capacityApplyEvent;
		private CHandle<RipperdocMeterArmorHoverEvent> _armorHoverEvent;
		private CHandle<RipperdocMeterArmorApplyEvent> _armorApplyEvent;
		private CFloat _maxCapacityPossible;
		private CHandle<inkanimProxy> _capacityBarintroAnimProxy;
		private CHandle<inkanimProxy> _armorBarintroAnimProxy;
		private CString _armorAttunemendDescription;
		private CString _armorAttunemendDescription2;
		private CString _armorMultBonusDescription;
		private CBool _isArmorBarReady;
		private CBool _isCapacityBarReady;
		private CBool _capacityPerk1Bought;
		private CBool _capacityPerk2Bought;
		private CBool _armorPerk1Bought;
		private CInt32 _armorCWEquipedNum;
		private CBool _cameFromInventoryMenu;
		private CEnum<ScreenDisplayContext> _screenDisplayContext;

		[Ordinal(3)] 
		[RED("TooltipsManagerRef")] 
		public inkWidgetReference TooltipsManagerRef
		{
			get => GetProperty(ref _tooltipsManagerRef);
			set => SetProperty(ref _tooltipsManagerRef, value);
		}

		[Ordinal(4)] 
		[RED("buttonHintsManagerRef")] 
		public inkWidgetReference ButtonHintsManagerRef
		{
			get => GetProperty(ref _buttonHintsManagerRef);
			set => SetProperty(ref _buttonHintsManagerRef, value);
		}

		[Ordinal(5)] 
		[RED("animationControllerContainer")] 
		public inkWidgetReference AnimationControllerContainer
		{
			get => GetProperty(ref _animationControllerContainer);
			set => SetProperty(ref _animationControllerContainer, value);
		}

		[Ordinal(6)] 
		[RED("armsAnchor")] 
		public inkCompoundWidgetReference ArmsAnchor
		{
			get => GetProperty(ref _armsAnchor);
			set => SetProperty(ref _armsAnchor, value);
		}

		[Ordinal(7)] 
		[RED("legsAnchor")] 
		public inkCompoundWidgetReference LegsAnchor
		{
			get => GetProperty(ref _legsAnchor);
			set => SetProperty(ref _legsAnchor, value);
		}

		[Ordinal(8)] 
		[RED("handsAnchor")] 
		public inkCompoundWidgetReference HandsAnchor
		{
			get => GetProperty(ref _handsAnchor);
			set => SetProperty(ref _handsAnchor, value);
		}

		[Ordinal(9)] 
		[RED("systemAnchor")] 
		public inkCompoundWidgetReference SystemAnchor
		{
			get => GetProperty(ref _systemAnchor);
			set => SetProperty(ref _systemAnchor, value);
		}

		[Ordinal(10)] 
		[RED("nervousAnchor")] 
		public inkCompoundWidgetReference NervousAnchor
		{
			get => GetProperty(ref _nervousAnchor);
			set => SetProperty(ref _nervousAnchor, value);
		}

		[Ordinal(11)] 
		[RED("skeletonAnchor")] 
		public inkCompoundWidgetReference SkeletonAnchor
		{
			get => GetProperty(ref _skeletonAnchor);
			set => SetProperty(ref _skeletonAnchor, value);
		}

		[Ordinal(12)] 
		[RED("ocularCortexAnchor")] 
		public inkCompoundWidgetReference OcularCortexAnchor
		{
			get => GetProperty(ref _ocularCortexAnchor);
			set => SetProperty(ref _ocularCortexAnchor, value);
		}

		[Ordinal(13)] 
		[RED("integumentaryAnchor")] 
		public inkCompoundWidgetReference IntegumentaryAnchor
		{
			get => GetProperty(ref _integumentaryAnchor);
			set => SetProperty(ref _integumentaryAnchor, value);
		}

		[Ordinal(14)] 
		[RED("frontalCortexAnchor")] 
		public inkCompoundWidgetReference FrontalCortexAnchor
		{
			get => GetProperty(ref _frontalCortexAnchor);
			set => SetProperty(ref _frontalCortexAnchor, value);
		}

		[Ordinal(15)] 
		[RED("cardiovascularAnchor")] 
		public inkCompoundWidgetReference CardiovascularAnchor
		{
			get => GetProperty(ref _cardiovascularAnchor);
			set => SetProperty(ref _cardiovascularAnchor, value);
		}

		[Ordinal(16)] 
		[RED("minigridTargetAnchor")] 
		public inkCompoundWidgetReference MinigridTargetAnchor
		{
			get => GetProperty(ref _minigridTargetAnchor);
			set => SetProperty(ref _minigridTargetAnchor, value);
		}

		[Ordinal(17)] 
		[RED("minigridTargetAnchorMargin")] 
		public inkMargin MinigridTargetAnchorMargin
		{
			get => GetProperty(ref _minigridTargetAnchorMargin);
			set => SetProperty(ref _minigridTargetAnchorMargin, value);
		}

		[Ordinal(18)] 
		[RED("minigridSelectorLeftAnchor")] 
		public inkCompoundWidgetReference MinigridSelectorLeftAnchor
		{
			get => GetProperty(ref _minigridSelectorLeftAnchor);
			set => SetProperty(ref _minigridSelectorLeftAnchor, value);
		}

		[Ordinal(19)] 
		[RED("minigridSelectorRightAnchor")] 
		public inkCompoundWidgetReference MinigridSelectorRightAnchor
		{
			get => GetProperty(ref _minigridSelectorRightAnchor);
			set => SetProperty(ref _minigridSelectorRightAnchor, value);
		}

		[Ordinal(20)] 
		[RED("minigridSelectorLeftAnchorMargin")] 
		public inkMargin MinigridSelectorLeftAnchorMargin
		{
			get => GetProperty(ref _minigridSelectorLeftAnchorMargin);
			set => SetProperty(ref _minigridSelectorLeftAnchorMargin, value);
		}

		[Ordinal(21)] 
		[RED("minigridSelectorRightAnchorMargin")] 
		public inkMargin MinigridSelectorRightAnchorMargin
		{
			get => GetProperty(ref _minigridSelectorRightAnchorMargin);
			set => SetProperty(ref _minigridSelectorRightAnchorMargin, value);
		}

		[Ordinal(22)] 
		[RED("tooltipLeftAnchor")] 
		public inkWidgetReference TooltipLeftAnchor
		{
			get => GetProperty(ref _tooltipLeftAnchor);
			set => SetProperty(ref _tooltipLeftAnchor, value);
		}

		[Ordinal(23)] 
		[RED("tooltipRightAnchor")] 
		public inkWidgetReference TooltipRightAnchor
		{
			get => GetProperty(ref _tooltipRightAnchor);
			set => SetProperty(ref _tooltipRightAnchor, value);
		}

		[Ordinal(24)] 
		[RED("upgradeResourcesAnchor")] 
		public inkCompoundWidgetReference UpgradeResourcesAnchor
		{
			get => GetProperty(ref _upgradeResourcesAnchor);
			set => SetProperty(ref _upgradeResourcesAnchor, value);
		}

		[Ordinal(25)] 
		[RED("upgradeCWInputName")] 
		public CName UpgradeCWInputName
		{
			get => GetProperty(ref _upgradeCWInputName);
			set => SetProperty(ref _upgradeCWInputName, value);
		}

		[Ordinal(26)] 
		[RED("upgradeResourcesContainerMaxWidth")] 
		public CFloat UpgradeResourcesContainerMaxWidth
		{
			get => GetProperty(ref _upgradeResourcesContainerMaxWidth);
			set => SetProperty(ref _upgradeResourcesContainerMaxWidth, value);
		}

		[Ordinal(27)] 
		[RED("allocationPointContainerDefault")] 
		public inkCompoundWidgetReference AllocationPointContainerDefault
		{
			get => GetProperty(ref _allocationPointContainerDefault);
			set => SetProperty(ref _allocationPointContainerDefault, value);
		}

		[Ordinal(28)] 
		[RED("inventoryViewAnchor")] 
		public inkCompoundWidgetReference InventoryViewAnchor
		{
			get => GetProperty(ref _inventoryViewAnchor);
			set => SetProperty(ref _inventoryViewAnchor, value);
		}

		[Ordinal(29)] 
		[RED("selectorAnchor")] 
		public inkCompoundWidgetReference SelectorAnchor
		{
			get => GetProperty(ref _selectorAnchor);
			set => SetProperty(ref _selectorAnchor, value);
		}

		[Ordinal(30)] 
		[RED("inventoryWarnning")] 
		public inkWidgetReference InventoryWarnning
		{
			get => GetProperty(ref _inventoryWarnning);
			set => SetProperty(ref _inventoryWarnning, value);
		}

		[Ordinal(31)] 
		[RED("maleEyeAndMaskBinkAnimation")] 
		public inkVideoWidgetReference MaleEyeAndMaskBinkAnimation
		{
			get => GetProperty(ref _maleEyeAndMaskBinkAnimation);
			set => SetProperty(ref _maleEyeAndMaskBinkAnimation, value);
		}

		[Ordinal(32)] 
		[RED("femaleEyeAndMaskBinkAnimation")] 
		public inkVideoWidgetReference FemaleEyeAndMaskBinkAnimation
		{
			get => GetProperty(ref _femaleEyeAndMaskBinkAnimation);
			set => SetProperty(ref _femaleEyeAndMaskBinkAnimation, value);
		}

		[Ordinal(33)] 
		[RED("c_maleOcular")] 
		public redResourceReferenceScriptToken C_maleOcular
		{
			get => GetProperty(ref _c_maleOcular);
			set => SetProperty(ref _c_maleOcular, value);
		}

		[Ordinal(34)] 
		[RED("c_femaleOcular")] 
		public redResourceReferenceScriptToken C_femaleOcular
		{
			get => GetProperty(ref _c_femaleOcular);
			set => SetProperty(ref _c_femaleOcular, value);
		}

		[Ordinal(35)] 
		[RED("c_maleMask")] 
		public redResourceReferenceScriptToken C_maleMask
		{
			get => GetProperty(ref _c_maleMask);
			set => SetProperty(ref _c_maleMask, value);
		}

		[Ordinal(36)] 
		[RED("c_femaleMask")] 
		public redResourceReferenceScriptToken C_femaleMask
		{
			get => GetProperty(ref _c_femaleMask);
			set => SetProperty(ref _c_femaleMask, value);
		}

		[Ordinal(37)] 
		[RED("minigridSetPositionAnimationSpeed")] 
		public CFloat MinigridSetPositionAnimationSpeed
		{
			get => GetProperty(ref _minigridSetPositionAnimationSpeed);
			set => SetProperty(ref _minigridSetPositionAnimationSpeed, value);
		}

		[Ordinal(38)] 
		[RED("minigridSetPositionAnimInterpolationType")] 
		public CEnum<inkanimInterpolationType> MinigridSetPositionAnimInterpolationType
		{
			get => GetProperty(ref _minigridSetPositionAnimInterpolationType);
			set => SetProperty(ref _minigridSetPositionAnimInterpolationType, value);
		}

		[Ordinal(39)] 
		[RED("minigridSetPositionAnimInterpolationMode")] 
		public CEnum<inkanimInterpolationMode> MinigridSetPositionAnimInterpolationMode
		{
			get => GetProperty(ref _minigridSetPositionAnimInterpolationMode);
			set => SetProperty(ref _minigridSetPositionAnimInterpolationMode, value);
		}

		[Ordinal(40)] 
		[RED("minigridIntroAnimationSpeed")] 
		public CFloat MinigridIntroAnimationSpeed
		{
			get => GetProperty(ref _minigridIntroAnimationSpeed);
			set => SetProperty(ref _minigridIntroAnimationSpeed, value);
		}

		[Ordinal(41)] 
		[RED("minigridIntroAnimInterpolationType")] 
		public CEnum<inkanimInterpolationType> MinigridIntroAnimInterpolationType
		{
			get => GetProperty(ref _minigridIntroAnimInterpolationType);
			set => SetProperty(ref _minigridIntroAnimInterpolationType, value);
		}

		[Ordinal(42)] 
		[RED("minigridIntroAnimInterpolationMode")] 
		public CEnum<inkanimInterpolationMode> MinigridIntroAnimInterpolationMode
		{
			get => GetProperty(ref _minigridIntroAnimInterpolationMode);
			set => SetProperty(ref _minigridIntroAnimInterpolationMode, value);
		}

		[Ordinal(43)] 
		[RED("capacityTutorialAnchor")] 
		public inkWidgetReference CapacityTutorialAnchor
		{
			get => GetProperty(ref _capacityTutorialAnchor);
			set => SetProperty(ref _capacityTutorialAnchor, value);
		}

		[Ordinal(44)] 
		[RED("armorTutorialAnchor")] 
		public inkWidgetReference ArmorTutorialAnchor
		{
			get => GetProperty(ref _armorTutorialAnchor);
			set => SetProperty(ref _armorTutorialAnchor, value);
		}

		[Ordinal(45)] 
		[RED("slotsTutorialAnchor")] 
		public inkWidgetReference SlotsTutorialAnchor
		{
			get => GetProperty(ref _slotsTutorialAnchor);
			set => SetProperty(ref _slotsTutorialAnchor, value);
		}

		[Ordinal(46)] 
		[RED("vikTutorial")] 
		public CBool VikTutorial
		{
			get => GetProperty(ref _vikTutorial);
			set => SetProperty(ref _vikTutorial, value);
		}

		[Ordinal(47)] 
		[RED("isTutorial")] 
		public CBool IsTutorial
		{
			get => GetProperty(ref _isTutorial);
			set => SetProperty(ref _isTutorial, value);
		}

		[Ordinal(48)] 
		[RED("ep1StandaloneTutorial")] 
		public CBool Ep1StandaloneTutorial
		{
			get => GetProperty(ref _ep1StandaloneTutorial);
			set => SetProperty(ref _ep1StandaloneTutorial, value);
		}

		[Ordinal(49)] 
		[RED("mq048TutorialFact")] 
		public CBool Mq048TutorialFact
		{
			get => GetProperty(ref _mq048TutorialFact);
			set => SetProperty(ref _mq048TutorialFact, value);
		}

		[Ordinal(50)] 
		[RED("isReturningPlayer")] 
		public CBool IsReturningPlayer
		{
			get => GetProperty(ref _isReturningPlayer);
			set => SetProperty(ref _isReturningPlayer, value);
		}

		[Ordinal(51)] 
		[RED("tutorialEyesCW")] 
		public TweakDBID TutorialEyesCW
		{
			get => GetProperty(ref _tutorialEyesCW);
			set => SetProperty(ref _tutorialEyesCW, value);
		}

		[Ordinal(52)] 
		[RED("tutorialHandsCW")] 
		public TweakDBID TutorialHandsCW
		{
			get => GetProperty(ref _tutorialHandsCW);
			set => SetProperty(ref _tutorialHandsCW, value);
		}

		[Ordinal(53)] 
		[RED("tutorialArmorCW")] 
		public TweakDBID TutorialArmorCW
		{
			get => GetProperty(ref _tutorialArmorCW);
			set => SetProperty(ref _tutorialArmorCW, value);
		}

		[Ordinal(54)] 
		[RED("tutorialZeroCapacityModifier")] 
		public CHandle<gameStatModifierData_Deprecated> TutorialZeroCapacityModifier
		{
			get => GetProperty(ref _tutorialZeroCapacityModifier);
			set => SetProperty(ref _tutorialZeroCapacityModifier, value);
		}

		[Ordinal(55)] 
		[RED("perkBarCapacity")] 
		public CEnum<gamedataNewPerkType> PerkBarCapacity
		{
			get => GetProperty(ref _perkBarCapacity);
			set => SetProperty(ref _perkBarCapacity, value);
		}

		[Ordinal(56)] 
		[RED("perkBarArmor")] 
		public CEnum<gamedataNewPerkType> PerkBarArmor
		{
			get => GetProperty(ref _perkBarArmor);
			set => SetProperty(ref _perkBarArmor, value);
		}

		[Ordinal(57)] 
		[RED("perkSlotSkeleton")] 
		public CEnum<gamedataNewPerkType> PerkSlotSkeleton
		{
			get => GetProperty(ref _perkSlotSkeleton);
			set => SetProperty(ref _perkSlotSkeleton, value);
		}

		[Ordinal(58)] 
		[RED("perkSlotHands")] 
		public CEnum<gamedataNewPerkType> PerkSlotHands
		{
			get => GetProperty(ref _perkSlotHands);
			set => SetProperty(ref _perkSlotHands, value);
		}

		[Ordinal(59)] 
		[RED("ripperdocHoverState")] 
		public CEnum<RipperdocHoverState> RipperdocHoverState
		{
			get => GetProperty(ref _ripperdocHoverState);
			set => SetProperty(ref _ripperdocHoverState, value);
		}

		[Ordinal(60)] 
		[RED("screen")] 
		public CEnum<CyberwareScreenType> Screen
		{
			get => GetProperty(ref _screen);
			set => SetProperty(ref _screen, value);
		}

		[Ordinal(61)] 
		[RED("filterMode")] 
		public CEnum<RipperdocModes> FilterMode
		{
			get => GetProperty(ref _filterMode);
			set => SetProperty(ref _filterMode, value);
		}

		[Ordinal(62)] 
		[RED("player")] 
		public wCHandle<PlayerPuppet> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(63)] 
		[RED("audioSystem")] 
		public wCHandle<gameGameAudioSystem> AudioSystem
		{
			get => GetProperty(ref _audioSystem);
			set => SetProperty(ref _audioSystem, value);
		}

		[Ordinal(64)] 
		[RED("uiSystem")] 
		public wCHandle<gameuiGameSystemUI> UiSystem
		{
			get => GetProperty(ref _uiSystem);
			set => SetProperty(ref _uiSystem, value);
		}

		[Ordinal(65)] 
		[RED("questSystem")] 
		public wCHandle<questQuestsSystem> QuestSystem
		{
			get => GetProperty(ref _questSystem);
			set => SetProperty(ref _questSystem, value);
		}

		[Ordinal(66)] 
		[RED("playerID")] 
		public entEntityID PlayerID
		{
			get => GetProperty(ref _playerID);
			set => SetProperty(ref _playerID, value);
		}

		[Ordinal(67)] 
		[RED("InventoryManager")] 
		public CHandle<InventoryDataManagerV2> InventoryManager
		{
			get => GetProperty(ref _inventoryManager);
			set => SetProperty(ref _inventoryManager, value);
		}

		[Ordinal(68)] 
		[RED("uiScriptableSystem")] 
		public wCHandle<UIScriptableSystem> UiScriptableSystem
		{
			get => GetProperty(ref _uiScriptableSystem);
			set => SetProperty(ref _uiScriptableSystem, value);
		}

		[Ordinal(69)] 
		[RED("uiInventorySystem")] 
		public wCHandle<UIInventoryScriptableSystem> UiInventorySystem
		{
			get => GetProperty(ref _uiInventorySystem);
			set => SetProperty(ref _uiInventorySystem, value);
		}

		[Ordinal(70)] 
		[RED("menuEventDispatcher")] 
		public wCHandle<inkMenuEventDispatcher> MenuEventDispatcher
		{
			get => GetProperty(ref _menuEventDispatcher);
			set => SetProperty(ref _menuEventDispatcher, value);
		}

		[Ordinal(71)] 
		[RED("ripperdocTokenManager")] 
		public CHandle<RipperdocTokenManager> RipperdocTokenManager
		{
			get => GetProperty(ref _ripperdocTokenManager);
			set => SetProperty(ref _ripperdocTokenManager, value);
		}

		[Ordinal(72)] 
		[RED("categories")] 
		public CArray<RipperdocCategory> Categories
		{
			get => GetProperty(ref _categories);
			set => SetProperty(ref _categories, value);
		}

		[Ordinal(73)] 
		[RED("TooltipsManager")] 
		public wCHandle<gameuiTooltipsManager> TooltipsManager
		{
			get => GetProperty(ref _tooltipsManager);
			set => SetProperty(ref _tooltipsManager, value);
		}

		[Ordinal(74)] 
		[RED("defaultTooltipsMargin")] 
		public inkMargin DefaultTooltipsMargin
		{
			get => GetProperty(ref _defaultTooltipsMargin);
			set => SetProperty(ref _defaultTooltipsMargin, value);
		}

		[Ordinal(75)] 
		[RED("defaultTooltipGap")] 
		public CFloat DefaultTooltipGap
		{
			get => GetProperty(ref _defaultTooltipGap);
			set => SetProperty(ref _defaultTooltipGap, value);
		}

		[Ordinal(76)] 
		[RED("VendorBlackboard")] 
		public wCHandle<gameIBlackboard> VendorBlackboard
		{
			get => GetProperty(ref _vendorBlackboard);
			set => SetProperty(ref _vendorBlackboard, value);
		}

		[Ordinal(77)] 
		[RED("equipmentBlackboard")] 
		public wCHandle<gameIBlackboard> EquipmentBlackboard
		{
			get => GetProperty(ref _equipmentBlackboard);
			set => SetProperty(ref _equipmentBlackboard, value);
		}

		[Ordinal(78)] 
		[RED("equipmentBlackboardCallback")] 
		public CHandle<redCallbackObject> EquipmentBlackboardCallback
		{
			get => GetProperty(ref _equipmentBlackboardCallback);
			set => SetProperty(ref _equipmentBlackboardCallback, value);
		}

		[Ordinal(79)] 
		[RED("tokenBlackboard")] 
		public wCHandle<gameIBlackboard> TokenBlackboard
		{
			get => GetProperty(ref _tokenBlackboard);
			set => SetProperty(ref _tokenBlackboard, value);
		}

		[Ordinal(80)] 
		[RED("tokenBlackboardCallback")] 
		public CHandle<redCallbackObject> TokenBlackboardCallback
		{
			get => GetProperty(ref _tokenBlackboardCallback);
			set => SetProperty(ref _tokenBlackboardCallback, value);
		}

		[Ordinal(81)] 
		[RED("inventoryView")] 
		public wCHandle<RipperdocInventoryController> InventoryView
		{
			get => GetProperty(ref _inventoryView);
			set => SetProperty(ref _inventoryView, value);
		}

		[Ordinal(82)] 
		[RED("selector")] 
		public wCHandle<RipperdocSelectorController> Selector
		{
			get => GetProperty(ref _selector);
			set => SetProperty(ref _selector, value);
		}

		[Ordinal(83)] 
		[RED("dollHoverArea")] 
		public CEnum<gamedataEquipmentArea> DollHoverArea
		{
			get => GetProperty(ref _dollHoverArea);
			set => SetProperty(ref _dollHoverArea, value);
		}

		[Ordinal(84)] 
		[RED("dollSelected")] 
		public CBool DollSelected
		{
			get => GetProperty(ref _dollSelected);
			set => SetProperty(ref _dollSelected, value);
		}

		[Ordinal(85)] 
		[RED("hoverArea")] 
		public CEnum<gamedataEquipmentArea> HoverArea
		{
			get => GetProperty(ref _hoverArea);
			set => SetProperty(ref _hoverArea, value);
		}

		[Ordinal(86)] 
		[RED("filterArea")] 
		public CEnum<gamedataEquipmentArea> FilterArea
		{
			get => GetProperty(ref _filterArea);
			set => SetProperty(ref _filterArea, value);
		}

		[Ordinal(87)] 
		[RED("lastAreaVisited")] 
		public CEnum<gamedataEquipmentArea> LastAreaVisited
		{
			get => GetProperty(ref _lastAreaVisited);
			set => SetProperty(ref _lastAreaVisited, value);
		}

		[Ordinal(88)] 
		[RED("filteringByArea")] 
		public CBool FilteringByArea
		{
			get => GetProperty(ref _filteringByArea);
			set => SetProperty(ref _filteringByArea, value);
		}

		[Ordinal(89)] 
		[RED("isInEquipPopup")] 
		public CBool IsInEquipPopup
		{
			get => GetProperty(ref _isInEquipPopup);
			set => SetProperty(ref _isInEquipPopup, value);
		}

		[Ordinal(90)] 
		[RED("isInventoryOpen")] 
		public CBool IsInventoryOpen
		{
			get => GetProperty(ref _isInventoryOpen);
			set => SetProperty(ref _isInventoryOpen, value);
		}

		[Ordinal(91)] 
		[RED("allFilters")] 
		public CArray<CEnum<gamedataEquipmentArea>> AllFilters
		{
			get => GetProperty(ref _allFilters);
			set => SetProperty(ref _allFilters, value);
		}

		[Ordinal(92)] 
		[RED("cachedAvailableItemsCounters")] 
		public CArray<CInt32> CachedAvailableItemsCounters
		{
			get => GetProperty(ref _cachedAvailableItemsCounters);
			set => SetProperty(ref _cachedAvailableItemsCounters, value);
		}

		[Ordinal(93)] 
		[RED("cachedVendorItemsCounters")] 
		public CArray<CInt32> CachedVendorItemsCounters
		{
			get => GetProperty(ref _cachedVendorItemsCounters);
			set => SetProperty(ref _cachedVendorItemsCounters, value);
		}

		[Ordinal(94)] 
		[RED("cachedPlayerItemsCounters")] 
		public CArray<CInt32> CachedPlayerItemsCounters
		{
			get => GetProperty(ref _cachedPlayerItemsCounters);
			set => SetProperty(ref _cachedPlayerItemsCounters, value);
		}

		[Ordinal(95)] 
		[RED("cachedPlayerItems", 10)] 
		public CArrayFixedSize<CArray<wCHandle<UIInventoryItem>>> CachedPlayerItems
		{
			get => GetProperty(ref _cachedPlayerItems);
			set => SetProperty(ref _cachedPlayerItems, value);
		}

		[Ordinal(96)] 
		[RED("cachedVendorItems", 10)] 
		public CArrayFixedSize<CArray<wCHandle<WrappedUIInventoryItem>>> CachedVendorItems
		{
			get => GetProperty(ref _cachedVendorItems);
			set => SetProperty(ref _cachedVendorItems, value);
		}

		[Ordinal(97)] 
		[RED("vendorItems")] 
		public CHandle<inkScriptHashMap> VendorItems
		{
			get => GetProperty(ref _vendorItems);
			set => SetProperty(ref _vendorItems, value);
		}

		[Ordinal(98)] 
		[RED("vendorWrappedItems")] 
		public CHandle<inkScriptHashMap> VendorWrappedItems
		{
			get => GetProperty(ref _vendorWrappedItems);
			set => SetProperty(ref _vendorWrappedItems, value);
		}

		[Ordinal(99)] 
		[RED("soldItemsCache")] 
		public CHandle<SoldItemsCache> SoldItemsCache
		{
			get => GetProperty(ref _soldItemsCache);
			set => SetProperty(ref _soldItemsCache, value);
		}

		[Ordinal(100)] 
		[RED("craftingMaterialsListItems")] 
		public CArray<wCHandle<CrafringMaterialItemController>> CraftingMaterialsListItems
		{
			get => GetProperty(ref _craftingMaterialsListItems);
			set => SetProperty(ref _craftingMaterialsListItems, value);
		}

		[Ordinal(101)] 
		[RED("upgradeHoldFinished")] 
		public CBool UpgradeHoldFinished
		{
			get => GetProperty(ref _upgradeHoldFinished);
			set => SetProperty(ref _upgradeHoldFinished, value);
		}

		[Ordinal(102)] 
		[RED("commonCraftingMaterials")] 
		public CArray<CHandle<CachedCraftingMaterial>> CommonCraftingMaterials
		{
			get => GetProperty(ref _commonCraftingMaterials);
			set => SetProperty(ref _commonCraftingMaterials, value);
		}

		[Ordinal(103)] 
		[RED("equipmentMinigrids")] 
		public CArray<wCHandle<CyberwareInventoryMiniGrid>> EquipmentMinigrids
		{
			get => GetProperty(ref _equipmentMinigrids);
			set => SetProperty(ref _equipmentMinigrids, value);
		}

		[Ordinal(104)] 
		[RED("minigridsMap", 10)] 
		public CArrayFixedSize<CEnum<gamedataEquipmentArea>> MinigridsMap
		{
			get => GetProperty(ref _minigridsMap);
			set => SetProperty(ref _minigridsMap, value);
		}

		[Ordinal(105)] 
		[RED("isActivePanel")] 
		public CBool IsActivePanel
		{
			get => GetProperty(ref _isActivePanel);
			set => SetProperty(ref _isActivePanel, value);
		}

		[Ordinal(106)] 
		[RED("hasEquipEventTriggered")] 
		public CBool HasEquipEventTriggered
		{
			get => GetProperty(ref _hasEquipEventTriggered);
			set => SetProperty(ref _hasEquipEventTriggered, value);
		}

		[Ordinal(107)] 
		[RED("hasUnequipEventTriggered")] 
		public CBool HasUnequipEventTriggered
		{
			get => GetProperty(ref _hasUnequipEventTriggered);
			set => SetProperty(ref _hasUnequipEventTriggered, value);
		}

		[Ordinal(108)] 
		[RED("statsSystem")] 
		public wCHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(109)] 
		[RED("statsDataSystem")] 
		public wCHandle<gameStatsDataSystem> StatsDataSystem
		{
			get => GetProperty(ref _statsDataSystem);
			set => SetProperty(ref _statsDataSystem, value);
		}

		[Ordinal(110)] 
		[RED("statusEffectSystem")] 
		public wCHandle<gameStatusEffectSystem> StatusEffectSystem
		{
			get => GetProperty(ref _statusEffectSystem);
			set => SetProperty(ref _statusEffectSystem, value);
		}

		[Ordinal(111)] 
		[RED("inventorySystem")] 
		public wCHandle<gameInventoryManager> InventorySystem
		{
			get => GetProperty(ref _inventorySystem);
			set => SetProperty(ref _inventorySystem, value);
		}

		[Ordinal(112)] 
		[RED("isPurchased")] 
		public CBool IsPurchased
		{
			get => GetProperty(ref _isPurchased);
			set => SetProperty(ref _isPurchased, value);
		}

		[Ordinal(113)] 
		[RED("isPurchasing")] 
		public CBool IsPurchasing
		{
			get => GetProperty(ref _isPurchasing);
			set => SetProperty(ref _isPurchasing, value);
		}

		[Ordinal(114)] 
		[RED("isPurchaseEquip")] 
		public CBool IsPurchaseEquip
		{
			get => GetProperty(ref _isPurchaseEquip);
			set => SetProperty(ref _isPurchaseEquip, value);
		}

		[Ordinal(115)] 
		[RED("isUpgrading")] 
		public CBool IsUpgrading
		{
			get => GetProperty(ref _isUpgrading);
			set => SetProperty(ref _isUpgrading, value);
		}

		[Ordinal(116)] 
		[RED("previewMinigrid")] 
		public wCHandle<CyberwareInventoryMiniGrid> PreviewMinigrid
		{
			get => GetProperty(ref _previewMinigrid);
			set => SetProperty(ref _previewMinigrid, value);
		}

		[Ordinal(117)] 
		[RED("equippedSlotIndex")] 
		public CInt32 EquippedSlotIndex
		{
			get => GetProperty(ref _equippedSlotIndex);
			set => SetProperty(ref _equippedSlotIndex, value);
		}

		[Ordinal(118)] 
		[RED("isMusculoskeletalUpgrade3Unlocked")] 
		public CBool IsMusculoskeletalUpgrade3Unlocked
		{
			get => GetProperty(ref _isMusculoskeletalUpgrade3Unlocked);
			set => SetProperty(ref _isMusculoskeletalUpgrade3Unlocked, value);
		}

		[Ordinal(119)] 
		[RED("handleItemEquippedNextFrameRequested")] 
		public CBool HandleItemEquippedNextFrameRequested
		{
			get => GetProperty(ref _handleItemEquippedNextFrameRequested);
			set => SetProperty(ref _handleItemEquippedNextFrameRequested, value);
		}

		[Ordinal(120)] 
		[RED("handleItemEquippedOnItemAdded")] 
		public TweakDBID HandleItemEquippedOnItemAdded
		{
			get => GetProperty(ref _handleItemEquippedOnItemAdded);
			set => SetProperty(ref _handleItemEquippedOnItemAdded, value);
		}

		[Ordinal(121)] 
		[RED("inventoryListener")] 
		public CHandle<gameInventoryScriptListener> InventoryListener
		{
			get => GetProperty(ref _inventoryListener);
			set => SetProperty(ref _inventoryListener, value);
		}

		[Ordinal(122)] 
		[RED("tokenPopup")] 
		public CHandle<inkGameNotificationToken> TokenPopup
		{
			get => GetProperty(ref _tokenPopup);
			set => SetProperty(ref _tokenPopup, value);
		}

		[Ordinal(123)] 
		[RED("playerItemDisplayContext")] 
		public CHandle<ItemDisplayContextData> PlayerItemDisplayContext
		{
			get => GetProperty(ref _playerItemDisplayContext);
			set => SetProperty(ref _playerItemDisplayContext, value);
		}

		[Ordinal(124)] 
		[RED("vendorItemDisplayContext")] 
		public CHandle<ItemDisplayContextData> VendorItemDisplayContext
		{
			get => GetProperty(ref _vendorItemDisplayContext);
			set => SetProperty(ref _vendorItemDisplayContext, value);
		}

		[Ordinal(125)] 
		[RED("inventoryRefreshRequested")] 
		public CBool InventoryRefreshRequested
		{
			get => GetProperty(ref _inventoryRefreshRequested);
			set => SetProperty(ref _inventoryRefreshRequested, value);
		}

		[Ordinal(126)] 
		[RED("invalidateMinigridsRequested")] 
		public CBool InvalidateMinigridsRequested
		{
			get => GetProperty(ref _invalidateMinigridsRequested);
			set => SetProperty(ref _invalidateMinigridsRequested, value);
		}

		[Ordinal(127)] 
		[RED("upgradeData")] 
		public CHandle<RipperdocTokenPopupData> UpgradeData
		{
			get => GetProperty(ref _upgradeData);
			set => SetProperty(ref _upgradeData, value);
		}

		[Ordinal(128)] 
		[RED("vendorUserData")] 
		public CHandle<VendorUserData> VendorUserData
		{
			get => GetProperty(ref _vendorUserData);
			set => SetProperty(ref _vendorUserData, value);
		}

		[Ordinal(129)] 
		[RED("VendorDataManager")] 
		public CHandle<VendorDataManager> VendorDataManager
		{
			get => GetProperty(ref _vendorDataManager);
			set => SetProperty(ref _vendorDataManager, value);
		}

		[Ordinal(130)] 
		[RED("buttonHintsController")] 
		public wCHandle<ButtonHints> ButtonHintsController
		{
			get => GetProperty(ref _buttonHintsController);
			set => SetProperty(ref _buttonHintsController, value);
		}

		[Ordinal(131)] 
		[RED("soldItemsFetched")] 
		public CBool SoldItemsFetched
		{
			get => GetProperty(ref _soldItemsFetched);
			set => SetProperty(ref _soldItemsFetched, value);
		}

		[Ordinal(132)] 
		[RED("animationController")] 
		public wCHandle<RipperdocScreenAnimationController> AnimationController
		{
			get => GetProperty(ref _animationController);
			set => SetProperty(ref _animationController, value);
		}

		[Ordinal(133)] 
		[RED("isHoveringOverUpgradableSlot")] 
		public CBool IsHoveringOverUpgradableSlot
		{
			get => GetProperty(ref _isHoveringOverUpgradableSlot);
			set => SetProperty(ref _isHoveringOverUpgradableSlot, value);
		}

		[Ordinal(134)] 
		[RED("upgradeQuality")] 
		public CEnum<gamedataQuality> UpgradeQuality
		{
			get => GetProperty(ref _upgradeQuality);
			set => SetProperty(ref _upgradeQuality, value);
		}

		[Ordinal(135)] 
		[RED("upgradeCostData")] 
		public CyberwareUpgradeCostData UpgradeCostData
		{
			get => GetProperty(ref _upgradeCostData);
			set => SetProperty(ref _upgradeCostData, value);
		}

		[Ordinal(136)] 
		[RED("upgradeItem")] 
		public CHandle<gamedataItem_Record> UpgradeItem
		{
			get => GetProperty(ref _upgradeItem);
			set => SetProperty(ref _upgradeItem, value);
		}

		[Ordinal(137)] 
		[RED("hoveredItem")] 
		public wCHandle<UIInventoryItem> HoveredItem
		{
			get => GetProperty(ref _hoveredItem);
			set => SetProperty(ref _hoveredItem, value);
		}

		[Ordinal(138)] 
		[RED("hoveredItemDisplay")] 
		public wCHandle<InventoryItemDisplayController> HoveredItemDisplay
		{
			get => GetProperty(ref _hoveredItemDisplay);
			set => SetProperty(ref _hoveredItemDisplay, value);
		}

		[Ordinal(139)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		[Ordinal(140)] 
		[RED("anim")] 
		public CHandle<inkanimProxy> Anim
		{
			get => GetProperty(ref _anim);
			set => SetProperty(ref _anim, value);
		}

		[Ordinal(141)] 
		[RED("developmentDataManager")] 
		public CHandle<PlayerDevelopmentDataManager> DevelopmentDataManager
		{
			get => GetProperty(ref _developmentDataManager);
			set => SetProperty(ref _developmentDataManager, value);
		}

		[Ordinal(142)] 
		[RED("capacityHoverEvent")] 
		public CHandle<RipperdocMeterCapacityHoverEvent> CapacityHoverEvent
		{
			get => GetProperty(ref _capacityHoverEvent);
			set => SetProperty(ref _capacityHoverEvent, value);
		}

		[Ordinal(143)] 
		[RED("capacityApplyEvent")] 
		public CHandle<RipperdocMeterCapacityApplyEvent> CapacityApplyEvent
		{
			get => GetProperty(ref _capacityApplyEvent);
			set => SetProperty(ref _capacityApplyEvent, value);
		}

		[Ordinal(144)] 
		[RED("armorHoverEvent")] 
		public CHandle<RipperdocMeterArmorHoverEvent> ArmorHoverEvent
		{
			get => GetProperty(ref _armorHoverEvent);
			set => SetProperty(ref _armorHoverEvent, value);
		}

		[Ordinal(145)] 
		[RED("armorApplyEvent")] 
		public CHandle<RipperdocMeterArmorApplyEvent> ArmorApplyEvent
		{
			get => GetProperty(ref _armorApplyEvent);
			set => SetProperty(ref _armorApplyEvent, value);
		}

		[Ordinal(146)] 
		[RED("maxCapacityPossible")] 
		public CFloat MaxCapacityPossible
		{
			get => GetProperty(ref _maxCapacityPossible);
			set => SetProperty(ref _maxCapacityPossible, value);
		}

		[Ordinal(147)] 
		[RED("capacityBarintroAnimProxy")] 
		public CHandle<inkanimProxy> CapacityBarintroAnimProxy
		{
			get => GetProperty(ref _capacityBarintroAnimProxy);
			set => SetProperty(ref _capacityBarintroAnimProxy, value);
		}

		[Ordinal(148)] 
		[RED("armorBarintroAnimProxy")] 
		public CHandle<inkanimProxy> ArmorBarintroAnimProxy
		{
			get => GetProperty(ref _armorBarintroAnimProxy);
			set => SetProperty(ref _armorBarintroAnimProxy, value);
		}

		[Ordinal(149)] 
		[RED("armorAttunemendDescription")] 
		public CString ArmorAttunemendDescription
		{
			get => GetProperty(ref _armorAttunemendDescription);
			set => SetProperty(ref _armorAttunemendDescription, value);
		}

		[Ordinal(150)] 
		[RED("armorAttunemendDescription2")] 
		public CString ArmorAttunemendDescription2
		{
			get => GetProperty(ref _armorAttunemendDescription2);
			set => SetProperty(ref _armorAttunemendDescription2, value);
		}

		[Ordinal(151)] 
		[RED("armorMultBonusDescription")] 
		public CString ArmorMultBonusDescription
		{
			get => GetProperty(ref _armorMultBonusDescription);
			set => SetProperty(ref _armorMultBonusDescription, value);
		}

		[Ordinal(152)] 
		[RED("isArmorBarReady")] 
		public CBool IsArmorBarReady
		{
			get => GetProperty(ref _isArmorBarReady);
			set => SetProperty(ref _isArmorBarReady, value);
		}

		[Ordinal(153)] 
		[RED("isCapacityBarReady")] 
		public CBool IsCapacityBarReady
		{
			get => GetProperty(ref _isCapacityBarReady);
			set => SetProperty(ref _isCapacityBarReady, value);
		}

		[Ordinal(154)] 
		[RED("capacityPerk1Bought")] 
		public CBool CapacityPerk1Bought
		{
			get => GetProperty(ref _capacityPerk1Bought);
			set => SetProperty(ref _capacityPerk1Bought, value);
		}

		[Ordinal(155)] 
		[RED("capacityPerk2Bought")] 
		public CBool CapacityPerk2Bought
		{
			get => GetProperty(ref _capacityPerk2Bought);
			set => SetProperty(ref _capacityPerk2Bought, value);
		}

		[Ordinal(156)] 
		[RED("armorPerk1Bought")] 
		public CBool ArmorPerk1Bought
		{
			get => GetProperty(ref _armorPerk1Bought);
			set => SetProperty(ref _armorPerk1Bought, value);
		}

		[Ordinal(157)] 
		[RED("armorCWEquipedNum")] 
		public CInt32 ArmorCWEquipedNum
		{
			get => GetProperty(ref _armorCWEquipedNum);
			set => SetProperty(ref _armorCWEquipedNum, value);
		}

		[Ordinal(158)] 
		[RED("cameFromInventoryMenu")] 
		public CBool CameFromInventoryMenu
		{
			get => GetProperty(ref _cameFromInventoryMenu);
			set => SetProperty(ref _cameFromInventoryMenu, value);
		}

		[Ordinal(159)] 
		[RED("screenDisplayContext")] 
		public CEnum<ScreenDisplayContext> ScreenDisplayContext
		{
			get => GetProperty(ref _screenDisplayContext);
			set => SetProperty(ref _screenDisplayContext, value);
		}

		public RipperDocGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
