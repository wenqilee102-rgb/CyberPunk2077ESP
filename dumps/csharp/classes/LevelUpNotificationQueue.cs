using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LevelUpNotificationQueue : gameuiGenericNotificationGameController
	{
		private CFloat _duration;
		private wCHandle<gameIBlackboard> _levelUpBlackboard;
		private CHandle<redCallbackObject> _playerLevelUpListener;
		private wCHandle<gameObject> _playerObject;
		private CEnum<gamePSMCombat> _combatModePSM;
		private CHandle<redCallbackObject> _combatModeListener;
		private CInt32 _lastEspionageLevel;
		private wCHandle<gameIBlackboard> _warningBlackboard;
		private CHandle<UI_NotificationsDef> _warningBlackboardDef;
		private CHandle<redCallbackObject> _warningMessageCallbackId;

		[Ordinal(4)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetProperty(ref _duration);
			set => SetProperty(ref _duration, value);
		}

		[Ordinal(5)] 
		[RED("levelUpBlackboard")] 
		public wCHandle<gameIBlackboard> LevelUpBlackboard
		{
			get => GetProperty(ref _levelUpBlackboard);
			set => SetProperty(ref _levelUpBlackboard, value);
		}

		[Ordinal(6)] 
		[RED("playerLevelUpListener")] 
		public CHandle<redCallbackObject> PlayerLevelUpListener
		{
			get => GetProperty(ref _playerLevelUpListener);
			set => SetProperty(ref _playerLevelUpListener, value);
		}

		[Ordinal(7)] 
		[RED("playerObject")] 
		public wCHandle<gameObject> PlayerObject
		{
			get => GetProperty(ref _playerObject);
			set => SetProperty(ref _playerObject, value);
		}

		[Ordinal(8)] 
		[RED("combatModePSM")] 
		public CEnum<gamePSMCombat> CombatModePSM
		{
			get => GetProperty(ref _combatModePSM);
			set => SetProperty(ref _combatModePSM, value);
		}

		[Ordinal(9)] 
		[RED("combatModeListener")] 
		public CHandle<redCallbackObject> CombatModeListener
		{
			get => GetProperty(ref _combatModeListener);
			set => SetProperty(ref _combatModeListener, value);
		}

		[Ordinal(10)] 
		[RED("lastEspionageLevel")] 
		public CInt32 LastEspionageLevel
		{
			get => GetProperty(ref _lastEspionageLevel);
			set => SetProperty(ref _lastEspionageLevel, value);
		}

		[Ordinal(11)] 
		[RED("warningBlackboard")] 
		public wCHandle<gameIBlackboard> WarningBlackboard
		{
			get => GetProperty(ref _warningBlackboard);
			set => SetProperty(ref _warningBlackboard, value);
		}

		[Ordinal(12)] 
		[RED("warningBlackboardDef")] 
		public CHandle<UI_NotificationsDef> WarningBlackboardDef
		{
			get => GetProperty(ref _warningBlackboardDef);
			set => SetProperty(ref _warningBlackboardDef, value);
		}

		[Ordinal(13)] 
		[RED("warningMessageCallbackId")] 
		public CHandle<redCallbackObject> WarningMessageCallbackId
		{
			get => GetProperty(ref _warningMessageCallbackId);
			set => SetProperty(ref _warningMessageCallbackId, value);
		}

		public LevelUpNotificationQueue(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
