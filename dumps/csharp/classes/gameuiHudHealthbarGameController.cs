using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiHudHealthbarGameController : gameuiHUDGameController
	{
		private wCHandle<gameIBlackboard> _bbPlayerStats;
		private CHandle<redCallbackObject> _bbPlayerEventId;
		private wCHandle<gameIBlackboard> _bbMuppetStats;
		private CHandle<redCallbackObject> _bbMuppetEventId;
		private wCHandle<gameIBlackboard> _bbRightWeaponInfo;
		private CHandle<redCallbackObject> _bbRightWeaponEventId;
		private wCHandle<gameIBlackboard> _bbLeftWeaponInfo;
		private CHandle<redCallbackObject> _bbLeftWeaponEventId;
		private wCHandle<gameIBlackboard> _bbAutodrive;
		private CHandle<redCallbackObject> _bbAutodriveEnabledEventId;
		private CHandle<redCallbackObject> _bbPSceneTierEventId;
		private CHandle<redCallbackObject> _visionStateBlackboardId;
		private CHandle<redCallbackObject> _combatModeBlackboardId;
		private CHandle<redCallbackObject> _bbQuickhacksMemeoryEventId;
		private inkWidgetReference _healthBar;
		private inkWidgetReference _overshieldBarRef;
		private inkWidgetReference _expBar;
		private inkWidgetReference _expBarSpacer;
		private inkWidgetReference _levelUpArrow;
		private inkWidgetReference _levelUpFrame;
		private inkCompoundWidgetReference _barsLayoutPath;
		private inkCompoundWidgetReference _buffsHolder;
		private inkTextWidgetReference _invulnerableTextPath;
		private inkTextWidgetReference _levelTextPath;
		private inkTextWidgetReference _nextLevelTextPath;
		private inkTextWidgetReference _healthTextPath;
		private inkTextWidgetReference _maxHealthTextPath;
		private inkCompoundWidgetReference _quickhacksContainer;
		private inkTextWidgetReference _expText;
		private inkTextWidgetReference _expTextLabel;
		private inkWidgetReference _lostHealthAggregationBar;
		private inkWidgetReference _levelUpRectangle;
		private inkWidgetReference _damegePreview;
		private inkWidgetReference _fullBar;
		private wCHandle<NameplateBarLogicController> _healthController;
		private wCHandle<ProgressBarSimpleWidgetLogicController> _armorController;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkWidget> _buffWidget;
		private wCHandle<inkTextWidget> _invulnerableText;
		private CHandle<inkanimDefinition> _animHideTemp;
		private CHandle<inkanimDefinition> _animShortFade;
		private CHandle<inkanimDefinition> _animLongFade;
		private CHandle<inkanimProxy> _animHideHPProxy;
		private CHandle<inkanimDefinition> _delayAnimation;
		private CBool _animCreated;
		private CBool _aggregatingActive;
		private CInt32 _countingStartHealth;
		private CInt32 _currentHealth;
		private CInt32 _previousHealth;
		private CInt32 _maximumHealth;
		private CFloat _quickhacksMemoryPercent;
		private CInt32 _currentArmor;
		private CInt32 _maximumArmor;
		private CArray<wCHandle<inkWidget>> _quickhackBarArray;
		private CInt32 _spawnedMemoryCells;
		private CInt32 _usedQuickhacks;
		private CBool _buffsVisible;
		private CBool _isUnarmedRightHand;
		private CBool _isUnarmedLeftHand;
		private CBool _isAutodriveEnabled;
		private CBool _isControllingDevice;
		private CEnum<gamePSMVision> _currentVisionPSM;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CEnum<GameplayTier> _sceneTier;
		private CHandle<GodModeStatListener> _godModeStatListener;
		private CHandle<HealthbarMemoryStatListener> _memoryStatListener;
		private wCHandle<gameIBlackboard> _playerStatsBlackboard;
		private CHandle<redCallbackObject> _characterCurrentXPListener;
		private wCHandle<gameIBlackboard> _levelUpBlackboard;
		private CHandle<redCallbackObject> _playerLevelUpListener;
		private CInt32 _currentLevel;
		private wCHandle<gameObject> _playerObject;
		private CHandle<PlayerDevelopmentSystem> _playerDevelopmentSystem;
		private ScriptGameInstance _gameInstance;
		private CHandle<inkanimProxy> _foldingAnimProxy;
		private CFloat _memoryFillCells;
		private CInt32 _memoryMaxCells;
		private CInt32 _pendingRequests;
		private CArray<wCHandle<inkAsyncSpawnRequest>> _spawnTokens;
		private CHandle<OvershieldListener> _overshieldListener;
		private wCHandle<NameplateBarLogicController> _overshieldBarController;
		private CBool _useOevershield;
		private CInt32 _currentOvershieldValue;
		private CFloat _currentOvershieldValuePercent;
		private CHandle<OverclockListener> _overclockListener;
		private CBool _isInOverclockedState;
		private CHandle<PulseAnimation> _pulseBar;
		private CHandle<PulseAnimation> _pulseText;
		private CHandle<PulseAnimation> _pulse;
		private CHandle<inkanimProxy> _healthMemoryJumpAnim;
		private CHandle<inkanimProxy> _healthMemoryFlashAnim;

		[Ordinal(9)] 
		[RED("bbPlayerStats")] 
		public wCHandle<gameIBlackboard> BbPlayerStats
		{
			get => GetProperty(ref _bbPlayerStats);
			set => SetProperty(ref _bbPlayerStats, value);
		}

		[Ordinal(10)] 
		[RED("bbPlayerEventId")] 
		public CHandle<redCallbackObject> BbPlayerEventId
		{
			get => GetProperty(ref _bbPlayerEventId);
			set => SetProperty(ref _bbPlayerEventId, value);
		}

		[Ordinal(11)] 
		[RED("bbMuppetStats")] 
		public wCHandle<gameIBlackboard> BbMuppetStats
		{
			get => GetProperty(ref _bbMuppetStats);
			set => SetProperty(ref _bbMuppetStats, value);
		}

		[Ordinal(12)] 
		[RED("bbMuppetEventId")] 
		public CHandle<redCallbackObject> BbMuppetEventId
		{
			get => GetProperty(ref _bbMuppetEventId);
			set => SetProperty(ref _bbMuppetEventId, value);
		}

		[Ordinal(13)] 
		[RED("bbRightWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbRightWeaponInfo
		{
			get => GetProperty(ref _bbRightWeaponInfo);
			set => SetProperty(ref _bbRightWeaponInfo, value);
		}

		[Ordinal(14)] 
		[RED("bbRightWeaponEventId")] 
		public CHandle<redCallbackObject> BbRightWeaponEventId
		{
			get => GetProperty(ref _bbRightWeaponEventId);
			set => SetProperty(ref _bbRightWeaponEventId, value);
		}

		[Ordinal(15)] 
		[RED("bbLeftWeaponInfo")] 
		public wCHandle<gameIBlackboard> BbLeftWeaponInfo
		{
			get => GetProperty(ref _bbLeftWeaponInfo);
			set => SetProperty(ref _bbLeftWeaponInfo, value);
		}

		[Ordinal(16)] 
		[RED("bbLeftWeaponEventId")] 
		public CHandle<redCallbackObject> BbLeftWeaponEventId
		{
			get => GetProperty(ref _bbLeftWeaponEventId);
			set => SetProperty(ref _bbLeftWeaponEventId, value);
		}

		[Ordinal(17)] 
		[RED("bbAutodrive")] 
		public wCHandle<gameIBlackboard> BbAutodrive
		{
			get => GetProperty(ref _bbAutodrive);
			set => SetProperty(ref _bbAutodrive, value);
		}

		[Ordinal(18)] 
		[RED("bbAutodriveEnabledEventId")] 
		public CHandle<redCallbackObject> BbAutodriveEnabledEventId
		{
			get => GetProperty(ref _bbAutodriveEnabledEventId);
			set => SetProperty(ref _bbAutodriveEnabledEventId, value);
		}

		[Ordinal(19)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(20)] 
		[RED("visionStateBlackboardId")] 
		public CHandle<redCallbackObject> VisionStateBlackboardId
		{
			get => GetProperty(ref _visionStateBlackboardId);
			set => SetProperty(ref _visionStateBlackboardId, value);
		}

		[Ordinal(21)] 
		[RED("combatModeBlackboardId")] 
		public CHandle<redCallbackObject> CombatModeBlackboardId
		{
			get => GetProperty(ref _combatModeBlackboardId);
			set => SetProperty(ref _combatModeBlackboardId, value);
		}

		[Ordinal(22)] 
		[RED("bbQuickhacksMemeoryEventId")] 
		public CHandle<redCallbackObject> BbQuickhacksMemeoryEventId
		{
			get => GetProperty(ref _bbQuickhacksMemeoryEventId);
			set => SetProperty(ref _bbQuickhacksMemeoryEventId, value);
		}

		[Ordinal(23)] 
		[RED("healthBar")] 
		public inkWidgetReference HealthBar
		{
			get => GetProperty(ref _healthBar);
			set => SetProperty(ref _healthBar, value);
		}

		[Ordinal(24)] 
		[RED("overshieldBarRef")] 
		public inkWidgetReference OvershieldBarRef
		{
			get => GetProperty(ref _overshieldBarRef);
			set => SetProperty(ref _overshieldBarRef, value);
		}

		[Ordinal(25)] 
		[RED("expBar")] 
		public inkWidgetReference ExpBar
		{
			get => GetProperty(ref _expBar);
			set => SetProperty(ref _expBar, value);
		}

		[Ordinal(26)] 
		[RED("expBarSpacer")] 
		public inkWidgetReference ExpBarSpacer
		{
			get => GetProperty(ref _expBarSpacer);
			set => SetProperty(ref _expBarSpacer, value);
		}

		[Ordinal(27)] 
		[RED("levelUpArrow")] 
		public inkWidgetReference LevelUpArrow
		{
			get => GetProperty(ref _levelUpArrow);
			set => SetProperty(ref _levelUpArrow, value);
		}

		[Ordinal(28)] 
		[RED("levelUpFrame")] 
		public inkWidgetReference LevelUpFrame
		{
			get => GetProperty(ref _levelUpFrame);
			set => SetProperty(ref _levelUpFrame, value);
		}

		[Ordinal(29)] 
		[RED("barsLayoutPath")] 
		public inkCompoundWidgetReference BarsLayoutPath
		{
			get => GetProperty(ref _barsLayoutPath);
			set => SetProperty(ref _barsLayoutPath, value);
		}

		[Ordinal(30)] 
		[RED("buffsHolder")] 
		public inkCompoundWidgetReference BuffsHolder
		{
			get => GetProperty(ref _buffsHolder);
			set => SetProperty(ref _buffsHolder, value);
		}

		[Ordinal(31)] 
		[RED("invulnerableTextPath")] 
		public inkTextWidgetReference InvulnerableTextPath
		{
			get => GetProperty(ref _invulnerableTextPath);
			set => SetProperty(ref _invulnerableTextPath, value);
		}

		[Ordinal(32)] 
		[RED("levelTextPath")] 
		public inkTextWidgetReference LevelTextPath
		{
			get => GetProperty(ref _levelTextPath);
			set => SetProperty(ref _levelTextPath, value);
		}

		[Ordinal(33)] 
		[RED("nextLevelTextPath")] 
		public inkTextWidgetReference NextLevelTextPath
		{
			get => GetProperty(ref _nextLevelTextPath);
			set => SetProperty(ref _nextLevelTextPath, value);
		}

		[Ordinal(34)] 
		[RED("healthTextPath")] 
		public inkTextWidgetReference HealthTextPath
		{
			get => GetProperty(ref _healthTextPath);
			set => SetProperty(ref _healthTextPath, value);
		}

		[Ordinal(35)] 
		[RED("maxHealthTextPath")] 
		public inkTextWidgetReference MaxHealthTextPath
		{
			get => GetProperty(ref _maxHealthTextPath);
			set => SetProperty(ref _maxHealthTextPath, value);
		}

		[Ordinal(36)] 
		[RED("quickhacksContainer")] 
		public inkCompoundWidgetReference QuickhacksContainer
		{
			get => GetProperty(ref _quickhacksContainer);
			set => SetProperty(ref _quickhacksContainer, value);
		}

		[Ordinal(37)] 
		[RED("expText")] 
		public inkTextWidgetReference ExpText
		{
			get => GetProperty(ref _expText);
			set => SetProperty(ref _expText, value);
		}

		[Ordinal(38)] 
		[RED("expTextLabel")] 
		public inkTextWidgetReference ExpTextLabel
		{
			get => GetProperty(ref _expTextLabel);
			set => SetProperty(ref _expTextLabel, value);
		}

		[Ordinal(39)] 
		[RED("lostHealthAggregationBar")] 
		public inkWidgetReference LostHealthAggregationBar
		{
			get => GetProperty(ref _lostHealthAggregationBar);
			set => SetProperty(ref _lostHealthAggregationBar, value);
		}

		[Ordinal(40)] 
		[RED("levelUpRectangle")] 
		public inkWidgetReference LevelUpRectangle
		{
			get => GetProperty(ref _levelUpRectangle);
			set => SetProperty(ref _levelUpRectangle, value);
		}

		[Ordinal(41)] 
		[RED("damegePreview")] 
		public inkWidgetReference DamegePreview
		{
			get => GetProperty(ref _damegePreview);
			set => SetProperty(ref _damegePreview, value);
		}

		[Ordinal(42)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get => GetProperty(ref _fullBar);
			set => SetProperty(ref _fullBar, value);
		}

		[Ordinal(43)] 
		[RED("healthController")] 
		public wCHandle<NameplateBarLogicController> HealthController
		{
			get => GetProperty(ref _healthController);
			set => SetProperty(ref _healthController, value);
		}

		[Ordinal(44)] 
		[RED("armorController")] 
		public wCHandle<ProgressBarSimpleWidgetLogicController> ArmorController
		{
			get => GetProperty(ref _armorController);
			set => SetProperty(ref _armorController, value);
		}

		[Ordinal(45)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(46)] 
		[RED("buffWidget")] 
		public wCHandle<inkWidget> BuffWidget
		{
			get => GetProperty(ref _buffWidget);
			set => SetProperty(ref _buffWidget, value);
		}

		[Ordinal(47)] 
		[RED("invulnerableText")] 
		public wCHandle<inkTextWidget> InvulnerableText
		{
			get => GetProperty(ref _invulnerableText);
			set => SetProperty(ref _invulnerableText, value);
		}

		[Ordinal(48)] 
		[RED("animHideTemp")] 
		public CHandle<inkanimDefinition> AnimHideTemp
		{
			get => GetProperty(ref _animHideTemp);
			set => SetProperty(ref _animHideTemp, value);
		}

		[Ordinal(49)] 
		[RED("animShortFade")] 
		public CHandle<inkanimDefinition> AnimShortFade
		{
			get => GetProperty(ref _animShortFade);
			set => SetProperty(ref _animShortFade, value);
		}

		[Ordinal(50)] 
		[RED("animLongFade")] 
		public CHandle<inkanimDefinition> AnimLongFade
		{
			get => GetProperty(ref _animLongFade);
			set => SetProperty(ref _animLongFade, value);
		}

		[Ordinal(51)] 
		[RED("animHideHPProxy")] 
		public CHandle<inkanimProxy> AnimHideHPProxy
		{
			get => GetProperty(ref _animHideHPProxy);
			set => SetProperty(ref _animHideHPProxy, value);
		}

		[Ordinal(52)] 
		[RED("delayAnimation")] 
		public CHandle<inkanimDefinition> DelayAnimation
		{
			get => GetProperty(ref _delayAnimation);
			set => SetProperty(ref _delayAnimation, value);
		}

		[Ordinal(53)] 
		[RED("animCreated")] 
		public CBool AnimCreated
		{
			get => GetProperty(ref _animCreated);
			set => SetProperty(ref _animCreated, value);
		}

		[Ordinal(54)] 
		[RED("aggregatingActive")] 
		public CBool AggregatingActive
		{
			get => GetProperty(ref _aggregatingActive);
			set => SetProperty(ref _aggregatingActive, value);
		}

		[Ordinal(55)] 
		[RED("countingStartHealth")] 
		public CInt32 CountingStartHealth
		{
			get => GetProperty(ref _countingStartHealth);
			set => SetProperty(ref _countingStartHealth, value);
		}

		[Ordinal(56)] 
		[RED("currentHealth")] 
		public CInt32 CurrentHealth
		{
			get => GetProperty(ref _currentHealth);
			set => SetProperty(ref _currentHealth, value);
		}

		[Ordinal(57)] 
		[RED("previousHealth")] 
		public CInt32 PreviousHealth
		{
			get => GetProperty(ref _previousHealth);
			set => SetProperty(ref _previousHealth, value);
		}

		[Ordinal(58)] 
		[RED("maximumHealth")] 
		public CInt32 MaximumHealth
		{
			get => GetProperty(ref _maximumHealth);
			set => SetProperty(ref _maximumHealth, value);
		}

		[Ordinal(59)] 
		[RED("quickhacksMemoryPercent")] 
		public CFloat QuickhacksMemoryPercent
		{
			get => GetProperty(ref _quickhacksMemoryPercent);
			set => SetProperty(ref _quickhacksMemoryPercent, value);
		}

		[Ordinal(60)] 
		[RED("currentArmor")] 
		public CInt32 CurrentArmor
		{
			get => GetProperty(ref _currentArmor);
			set => SetProperty(ref _currentArmor, value);
		}

		[Ordinal(61)] 
		[RED("maximumArmor")] 
		public CInt32 MaximumArmor
		{
			get => GetProperty(ref _maximumArmor);
			set => SetProperty(ref _maximumArmor, value);
		}

		[Ordinal(62)] 
		[RED("quickhackBarArray")] 
		public CArray<wCHandle<inkWidget>> QuickhackBarArray
		{
			get => GetProperty(ref _quickhackBarArray);
			set => SetProperty(ref _quickhackBarArray, value);
		}

		[Ordinal(63)] 
		[RED("spawnedMemoryCells")] 
		public CInt32 SpawnedMemoryCells
		{
			get => GetProperty(ref _spawnedMemoryCells);
			set => SetProperty(ref _spawnedMemoryCells, value);
		}

		[Ordinal(64)] 
		[RED("usedQuickhacks")] 
		public CInt32 UsedQuickhacks
		{
			get => GetProperty(ref _usedQuickhacks);
			set => SetProperty(ref _usedQuickhacks, value);
		}

		[Ordinal(65)] 
		[RED("buffsVisible")] 
		public CBool BuffsVisible
		{
			get => GetProperty(ref _buffsVisible);
			set => SetProperty(ref _buffsVisible, value);
		}

		[Ordinal(66)] 
		[RED("isUnarmedRightHand")] 
		public CBool IsUnarmedRightHand
		{
			get => GetProperty(ref _isUnarmedRightHand);
			set => SetProperty(ref _isUnarmedRightHand, value);
		}

		[Ordinal(67)] 
		[RED("isUnarmedLeftHand")] 
		public CBool IsUnarmedLeftHand
		{
			get => GetProperty(ref _isUnarmedLeftHand);
			set => SetProperty(ref _isUnarmedLeftHand, value);
		}

		[Ordinal(68)] 
		[RED("isAutodriveEnabled")] 
		public CBool IsAutodriveEnabled
		{
			get => GetProperty(ref _isAutodriveEnabled);
			set => SetProperty(ref _isAutodriveEnabled, value);
		}

		[Ordinal(69)] 
		[RED("isControllingDevice")] 
		public CBool IsControllingDevice
		{
			get => GetProperty(ref _isControllingDevice);
			set => SetProperty(ref _isControllingDevice, value);
		}

		[Ordinal(70)] 
		[RED("currentVisionPSM")] 
		public CEnum<gamePSMVision> CurrentVisionPSM
		{
			get => GetProperty(ref _currentVisionPSM);
			set => SetProperty(ref _currentVisionPSM, value);
		}

		[Ordinal(71)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetProperty(ref _combatModePSM);
			set => SetProperty(ref _combatModePSM, value);
		}

		[Ordinal(72)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(73)] 
		[RED("godModeStatListener")] 
		public CHandle<GodModeStatListener> GodModeStatListener
		{
			get => GetProperty(ref _godModeStatListener);
			set => SetProperty(ref _godModeStatListener, value);
		}

		[Ordinal(74)] 
		[RED("memoryStatListener")] 
		public CHandle<HealthbarMemoryStatListener> MemoryStatListener
		{
			get => GetProperty(ref _memoryStatListener);
			set => SetProperty(ref _memoryStatListener, value);
		}

		[Ordinal(75)] 
		[RED("playerStatsBlackboard")] 
		public wCHandle<gameIBlackboard> PlayerStatsBlackboard
		{
			get => GetProperty(ref _playerStatsBlackboard);
			set => SetProperty(ref _playerStatsBlackboard, value);
		}

		[Ordinal(76)] 
		[RED("characterCurrentXPListener")] 
		public CHandle<redCallbackObject> CharacterCurrentXPListener
		{
			get => GetProperty(ref _characterCurrentXPListener);
			set => SetProperty(ref _characterCurrentXPListener, value);
		}

		[Ordinal(77)] 
		[RED("levelUpBlackboard")] 
		public wCHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetProperty(ref _levelUpBlackboard);
			set => SetProperty(ref _levelUpBlackboard, value);
		}

		[Ordinal(78)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetProperty(ref _playerLevelUpListener);
			set => SetProperty(ref _playerLevelUpListener, value);
		}

		[Ordinal(79)] 
		[RED("currentLevel")] 
		public CInt32 CurrentLevel
		{
			get => GetProperty(ref _currentLevel);
			set => SetProperty(ref _currentLevel, value);
		}

		[Ordinal(80)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(81)] 
		[RED("playerDevelopmentSystem")] 
		public CHandle<PlayerDevelopmentSystem> PlayerDevelopmentSystem
		{
			get => GetProperty(ref _playerDevelopmentSystem);
			set => SetProperty(ref _playerDevelopmentSystem, value);
		}

		[Ordinal(82)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(83)] 
		[RED("foldingAnimProxy")] 
		public CHandle<inkanimProxy> FoldingAnimProxy
		{
			get => GetProperty(ref _foldingAnimProxy);
			set => SetProperty(ref _foldingAnimProxy, value);
		}

		[Ordinal(84)] 
		[RED("memoryFillCells")] 
		public CFloat MemoryFillCells
		{
			get => GetProperty(ref _memoryFillCells);
			set => SetProperty(ref _memoryFillCells, value);
		}

		[Ordinal(85)] 
		[RED("memoryMaxCells")] 
		public CInt32 MemoryMaxCells
		{
			get => GetProperty(ref _memoryMaxCells);
			set => SetProperty(ref _memoryMaxCells, value);
		}

		[Ordinal(86)] 
		[RED("pendingRequests")] 
		public CInt32 PendingRequests
		{
			get => GetProperty(ref _pendingRequests);
			set => SetProperty(ref _pendingRequests, value);
		}

		[Ordinal(87)] 
		[RED("spawnTokens")] 
		public CArray<wCHandle<inkAsyncSpawnRequest>> SpawnTokens
		{
			get => GetProperty(ref _spawnTokens);
			set => SetProperty(ref _spawnTokens, value);
		}

		[Ordinal(88)] 
		[RED("overshieldListener")] 
		public CHandle<OvershieldListener> OvershieldListener
		{
			get => GetProperty(ref _overshieldListener);
			set => SetProperty(ref _overshieldListener, value);
		}

		[Ordinal(89)] 
		[RED("overshieldBarController")] 
		public wCHandle<NameplateBarLogicController> OvershieldBarController
		{
			get => GetProperty(ref _overshieldBarController);
			set => SetProperty(ref _overshieldBarController, value);
		}

		[Ordinal(90)] 
		[RED("useOevershield")] 
		public CBool UseOevershield
		{
			get => GetProperty(ref _useOevershield);
			set => SetProperty(ref _useOevershield, value);
		}

		[Ordinal(91)] 
		[RED("currentOvershieldValue")] 
		public CInt32 CurrentOvershieldValue
		{
			get => GetProperty(ref _currentOvershieldValue);
			set => SetProperty(ref _currentOvershieldValue, value);
		}

		[Ordinal(92)] 
		[RED("currentOvershieldValuePercent")] 
		public CFloat CurrentOvershieldValuePercent
		{
			get => GetProperty(ref _currentOvershieldValuePercent);
			set => SetProperty(ref _currentOvershieldValuePercent, value);
		}

		[Ordinal(93)] 
		[RED("overclockListener")] 
		public CHandle<OverclockListener> OverclockListener
		{
			get => GetProperty(ref _overclockListener);
			set => SetProperty(ref _overclockListener, value);
		}

		[Ordinal(94)] 
		[RED("isInOverclockedState")] 
		public CBool IsInOverclockedState
		{
			get => GetProperty(ref _isInOverclockedState);
			set => SetProperty(ref _isInOverclockedState, value);
		}

		[Ordinal(95)] 
		[RED("pulseBar")] 
		public CHandle<PulseAnimation> PulseBar
		{
			get => GetProperty(ref _pulseBar);
			set => SetProperty(ref _pulseBar, value);
		}

		[Ordinal(96)] 
		[RED("pulseText")] 
		public CHandle<PulseAnimation> PulseText
		{
			get => GetProperty(ref _pulseText);
			set => SetProperty(ref _pulseText, value);
		}

		[Ordinal(97)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		[Ordinal(98)] 
		[RED("healthMemoryJumpAnim")] 
		public CHandle<inkanimProxy> HealthMemoryJumpAnim
		{
			get => GetProperty(ref _healthMemoryJumpAnim);
			set => SetProperty(ref _healthMemoryJumpAnim, value);
		}

		[Ordinal(99)] 
		[RED("healthMemoryFlashAnim")] 
		public CHandle<inkanimProxy> HealthMemoryFlashAnim
		{
			get => GetProperty(ref _healthMemoryFlashAnim);
			set => SetProperty(ref _healthMemoryFlashAnim, value);
		}

		public gameuiHudHealthbarGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
