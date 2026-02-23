using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StaminabarWidgetGameController : gameuiHUDGameController
	{
		private inkWidgetReference _staminaControllerRef;
		private inkTextWidgetReference _staminaPercTextPath;
		private inkTextWidgetReference _staminaStatusTextPath;
		private CHandle<redCallbackObject> _bbPSceneTierEventId;
		private CHandle<redCallbackObject> _bbPStaminaPSMEventId;
		private CHandle<redCallbackObject> _bbAreaZoneEventId;
		private CHandle<redCallbackObject> _combatModeListener;
		private wCHandle<NameplateBarLogicController> _staminaController;
		private wCHandle<inkWidget> _rootWidget;
		private CFloat _currentBarValue;
		private CEnum<gamedataStatPoolType> _currentStatPool;
		private CEnum<GameplayTier> _sceneTier;
		private CEnum<gamePSMStamina> _staminaState;
		private CEnum<gamePSMZones> _zoneState;
		private CHandle<StaminaPoolListener> _staminaPoolListener;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _forceHidden;
		private CFloat _staminaRatioEnterCondition;
		private CHandle<PulseAnimation> _pulse;
		private wCHandle<gameObject> _playerPuppet;

		[Ordinal(9)] 
		[RED("staminaControllerRef")] 
		public inkWidgetReference StaminaControllerRef
		{
			get => GetProperty(ref _staminaControllerRef);
			set => SetProperty(ref _staminaControllerRef, value);
		}

		[Ordinal(10)] 
		[RED("staminaPercTextPath")] 
		public inkTextWidgetReference StaminaPercTextPath
		{
			get => GetProperty(ref _staminaPercTextPath);
			set => SetProperty(ref _staminaPercTextPath, value);
		}

		[Ordinal(11)] 
		[RED("staminaStatusTextPath")] 
		public inkTextWidgetReference StaminaStatusTextPath
		{
			get => GetProperty(ref _staminaStatusTextPath);
			set => SetProperty(ref _staminaStatusTextPath, value);
		}

		[Ordinal(12)] 
		[RED("bbPSceneTierEventId")] 
		public CHandle<redCallbackObject> BbPSceneTierEventId
		{
			get => GetProperty(ref _bbPSceneTierEventId);
			set => SetProperty(ref _bbPSceneTierEventId, value);
		}

		[Ordinal(13)] 
		[RED("bbPStaminaPSMEventId")] 
		public CHandle<redCallbackObject> BbPStaminaPSMEventId
		{
			get => GetProperty(ref _bbPStaminaPSMEventId);
			set => SetProperty(ref _bbPStaminaPSMEventId, value);
		}

		[Ordinal(14)] 
		[RED("bbAreaZoneEventId")] 
		public CHandle<redCallbackObject> BbAreaZoneEventId
		{
			get => GetProperty(ref _bbAreaZoneEventId);
			set => SetProperty(ref _bbAreaZoneEventId, value);
		}

		[Ordinal(15)] 
		[RED("combatModeListener")] 
		public CHandle<redCallbackObject> CombatModeListener
		{
			get => GetProperty(ref _combatModeListener);
			set => SetProperty(ref _combatModeListener, value);
		}

		[Ordinal(16)] 
		[RED("staminaController")] 
		public wCHandle<NameplateBarLogicController> StaminaController
		{
			get => GetProperty(ref _staminaController);
			set => SetProperty(ref _staminaController, value);
		}

		[Ordinal(17)] 
		[RED("RootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(18)] 
		[RED("currentBarValue")] 
		public CFloat CurrentBarValue
		{
			get => GetProperty(ref _currentBarValue);
			set => SetProperty(ref _currentBarValue, value);
		}

		[Ordinal(19)] 
		[RED("currentStatPool")] 
		public CEnum<gamedataStatPoolType> CurrentStatPool
		{
			get => GetProperty(ref _currentStatPool);
			set => SetProperty(ref _currentStatPool, value);
		}

		[Ordinal(20)] 
		[RED("sceneTier")] 
		public CEnum<GameplayTier> SceneTier
		{
			get => GetProperty(ref _sceneTier);
			set => SetProperty(ref _sceneTier, value);
		}

		[Ordinal(21)] 
		[RED("staminaState")] 
		public CEnum<gamePSMStamina> StaminaState
		{
			get => GetProperty(ref _staminaState);
			set => SetProperty(ref _staminaState, value);
		}

		[Ordinal(22)] 
		[RED("zoneState")] 
		public CEnum<gamePSMZones> ZoneState
		{
			get => GetProperty(ref _zoneState);
			set => SetProperty(ref _zoneState, value);
		}

		[Ordinal(23)] 
		[RED("staminaPoolListener")] 
		public CHandle<StaminaPoolListener> StaminaPoolListener
		{
			get => GetProperty(ref _staminaPoolListener);
			set => SetProperty(ref _staminaPoolListener, value);
		}

		[Ordinal(24)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(25)] 
		[RED("forceHidden")] 
		public CBool ForceHidden
		{
			get => GetProperty(ref _forceHidden);
			set => SetProperty(ref _forceHidden, value);
		}

		[Ordinal(26)] 
		[RED("staminaRatioEnterCondition")] 
		public CFloat StaminaRatioEnterCondition
		{
			get => GetProperty(ref _staminaRatioEnterCondition);
			set => SetProperty(ref _staminaRatioEnterCondition, value);
		}

		[Ordinal(27)] 
		[RED("pulse")] 
		public CHandle<PulseAnimation> Pulse
		{
			get => GetProperty(ref _pulse);
			set => SetProperty(ref _pulse, value);
		}

		[Ordinal(28)] 
		[RED("playerPuppet")] 
		public wCHandle<gameObject> PlayerPuppet
		{
			get => GetProperty(ref _playerPuppet);
			set => SetProperty(ref _playerPuppet, value);
		}

		public StaminabarWidgetGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
