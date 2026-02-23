using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAreaControllerPS : MasterControllerPS
	{
		private CHandle<SecuritySystemControllerPS> _system;
		private CArray<AreaEntry> _usersInPerimeter;
		private CBool _isPlayerInside;
		private CEnum<ESecurityAccessLevel> _securityAccessLevel;
		private CEnum<ESecurityAreaType> _securityAreaType;
		private EventsFilters _eventsFilters;
		private CArray<AreaTypeTransition> _areaTransitions;
		private CArray<AreaTypeTransition> _runtimeTransitions;
		private CBool _pendingDisableRequest;
		private OutputPersistentData _lastOutput;
		private CBool _questPlayerHasTriggeredCombat;
		private CBool _hasThisAreaReceivedCombatNotification;
		private CBool _pendingNotifyPlayerAboutTransition;

		[Ordinal(108)] 
		[RED("system")] 
		public CHandle<SecuritySystemControllerPS> System
		{
			get => GetProperty(ref _system);
			set => SetProperty(ref _system, value);
		}

		[Ordinal(109)] 
		[RED("usersInPerimeter")] 
		public CArray<AreaEntry> UsersInPerimeter
		{
			get => GetProperty(ref _usersInPerimeter);
			set => SetProperty(ref _usersInPerimeter, value);
		}

		[Ordinal(110)] 
		[RED("isPlayerInside")] 
		public CBool IsPlayerInside
		{
			get => GetProperty(ref _isPlayerInside);
			set => SetProperty(ref _isPlayerInside, value);
		}

		[Ordinal(111)] 
		[RED("securityAccessLevel")] 
		public CEnum<ESecurityAccessLevel> SecurityAccessLevel
		{
			get => GetProperty(ref _securityAccessLevel);
			set => SetProperty(ref _securityAccessLevel, value);
		}

		[Ordinal(112)] 
		[RED("securityAreaType")] 
		public CEnum<ESecurityAreaType> SecurityAreaType
		{
			get => GetProperty(ref _securityAreaType);
			set => SetProperty(ref _securityAreaType, value);
		}

		[Ordinal(113)] 
		[RED("eventsFilters")] 
		public EventsFilters EventsFilters
		{
			get => GetProperty(ref _eventsFilters);
			set => SetProperty(ref _eventsFilters, value);
		}

		[Ordinal(114)] 
		[RED("areaTransitions")] 
		public CArray<AreaTypeTransition> AreaTransitions
		{
			get => GetProperty(ref _areaTransitions);
			set => SetProperty(ref _areaTransitions, value);
		}

		[Ordinal(115)] 
		[RED("runtimeTransitions")] 
		public CArray<AreaTypeTransition> RuntimeTransitions
		{
			get => GetProperty(ref _runtimeTransitions);
			set => SetProperty(ref _runtimeTransitions, value);
		}

		[Ordinal(116)] 
		[RED("pendingDisableRequest")] 
		public CBool PendingDisableRequest
		{
			get => GetProperty(ref _pendingDisableRequest);
			set => SetProperty(ref _pendingDisableRequest, value);
		}

		[Ordinal(117)] 
		[RED("lastOutput")] 
		public OutputPersistentData LastOutput
		{
			get => GetProperty(ref _lastOutput);
			set => SetProperty(ref _lastOutput, value);
		}

		[Ordinal(118)] 
		[RED("questPlayerHasTriggeredCombat")] 
		public CBool QuestPlayerHasTriggeredCombat
		{
			get => GetProperty(ref _questPlayerHasTriggeredCombat);
			set => SetProperty(ref _questPlayerHasTriggeredCombat, value);
		}

		[Ordinal(119)] 
		[RED("hasThisAreaReceivedCombatNotification")] 
		public CBool HasThisAreaReceivedCombatNotification
		{
			get => GetProperty(ref _hasThisAreaReceivedCombatNotification);
			set => SetProperty(ref _hasThisAreaReceivedCombatNotification, value);
		}

		[Ordinal(120)] 
		[RED("pendingNotifyPlayerAboutTransition")] 
		public CBool PendingNotifyPlayerAboutTransition
		{
			get => GetProperty(ref _pendingNotifyPlayerAboutTransition);
			set => SetProperty(ref _pendingNotifyPlayerAboutTransition, value);
		}

		public SecurityAreaControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
