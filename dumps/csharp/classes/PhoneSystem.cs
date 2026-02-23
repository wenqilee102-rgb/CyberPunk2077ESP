using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PhoneSystem : gameScriptableSystem
	{
		private CHandle<gameBlackboardSystem> _blackboardSystem;
		private wCHandle<gameIBlackboard> _blackboard;
		private wCHandle<gameIBlackboard> _psmBlackboard;
		private questPhoneCallInformation _lastCallInformation;
		private CHandle<PhoneStatusEffectListener> _statusEffectsListener;
		private CHandle<PhoneStatsListener> _statsListener;
		private CBool _contactsOpen;
		private CHandle<redCallbackObject> _phoneVisibilityBBId;
		private CHandle<redCallbackObject> _contactsOpenBBId;
		private CHandle<redCallbackObject> _highLevelBBId;
		private CHandle<redCallbackObject> _combatBBId;
		private CHandle<redCallbackObject> _swimmingBBId;
		private CHandle<redCallbackObject> _isContrDeviceBBId;
		private CHandle<redCallbackObject> _isUIZoomDeviceBBId;
		private CUInt32 _playerAttachedCallbackID;
		private CUInt32 _playerDetachedCallbackID;

		[Ordinal(0)] 
		[RED("BlackboardSystem")] 
		public CHandle<gameBlackboardSystem> BlackboardSystem
		{
			get => GetProperty(ref _blackboardSystem);
			set => SetProperty(ref _blackboardSystem, value);
		}

		[Ordinal(1)] 
		[RED("Blackboard")] 
		public wCHandle<gameIBlackboard> Blackboard
		{
			get => GetProperty(ref _blackboard);
			set => SetProperty(ref _blackboard, value);
		}

		[Ordinal(2)] 
		[RED("PsmBlackboard")] 
		public wCHandle<gameIBlackboard> PsmBlackboard
		{
			get => GetProperty(ref _psmBlackboard);
			set => SetProperty(ref _psmBlackboard, value);
		}

		[Ordinal(3)] 
		[RED("LastCallInformation")] 
		public questPhoneCallInformation LastCallInformation
		{
			get => GetProperty(ref _lastCallInformation);
			set => SetProperty(ref _lastCallInformation, value);
		}

		[Ordinal(4)] 
		[RED("StatusEffectsListener")] 
		public CHandle<PhoneStatusEffectListener> StatusEffectsListener
		{
			get => GetProperty(ref _statusEffectsListener);
			set => SetProperty(ref _statusEffectsListener, value);
		}

		[Ordinal(5)] 
		[RED("StatsListener")] 
		public CHandle<PhoneStatsListener> StatsListener
		{
			get => GetProperty(ref _statsListener);
			set => SetProperty(ref _statsListener, value);
		}

		[Ordinal(6)] 
		[RED("ContactsOpen")] 
		public CBool ContactsOpen
		{
			get => GetProperty(ref _contactsOpen);
			set => SetProperty(ref _contactsOpen, value);
		}

		[Ordinal(7)] 
		[RED("PhoneVisibilityBBId")] 
		public CHandle<redCallbackObject> PhoneVisibilityBBId
		{
			get => GetProperty(ref _phoneVisibilityBBId);
			set => SetProperty(ref _phoneVisibilityBBId, value);
		}

		[Ordinal(8)] 
		[RED("ContactsOpenBBId")] 
		public CHandle<redCallbackObject> ContactsOpenBBId
		{
			get => GetProperty(ref _contactsOpenBBId);
			set => SetProperty(ref _contactsOpenBBId, value);
		}

		[Ordinal(9)] 
		[RED("HighLevelBBId")] 
		public CHandle<redCallbackObject> HighLevelBBId
		{
			get => GetProperty(ref _highLevelBBId);
			set => SetProperty(ref _highLevelBBId, value);
		}

		[Ordinal(10)] 
		[RED("CombatBBId")] 
		public CHandle<redCallbackObject> CombatBBId
		{
			get => GetProperty(ref _combatBBId);
			set => SetProperty(ref _combatBBId, value);
		}

		[Ordinal(11)] 
		[RED("SwimmingBBId")] 
		public CHandle<redCallbackObject> SwimmingBBId
		{
			get => GetProperty(ref _swimmingBBId);
			set => SetProperty(ref _swimmingBBId, value);
		}

		[Ordinal(12)] 
		[RED("IsContrDeviceBBId")] 
		public CHandle<redCallbackObject> IsContrDeviceBBId
		{
			get => GetProperty(ref _isContrDeviceBBId);
			set => SetProperty(ref _isContrDeviceBBId, value);
		}

		[Ordinal(13)] 
		[RED("IsUIZoomDeviceBBId")] 
		public CHandle<redCallbackObject> IsUIZoomDeviceBBId
		{
			get => GetProperty(ref _isUIZoomDeviceBBId);
			set => SetProperty(ref _isUIZoomDeviceBBId, value);
		}

		[Ordinal(14)] 
		[RED("PlayerAttachedCallbackID")] 
		public CUInt32 PlayerAttachedCallbackID
		{
			get => GetProperty(ref _playerAttachedCallbackID);
			set => SetProperty(ref _playerAttachedCallbackID, value);
		}

		[Ordinal(15)] 
		[RED("PlayerDetachedCallbackID")] 
		public CUInt32 PlayerDetachedCallbackID
		{
			get => GetProperty(ref _playerDetachedCallbackID);
			set => SetProperty(ref _playerDetachedCallbackID, value);
		}

		public PhoneSystem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
