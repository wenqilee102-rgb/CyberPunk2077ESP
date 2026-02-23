using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TweakAIActionAbstract : AIbehaviortaskScript
	{
		private wCHandle<gamedataAIAction_Record> _actionRecord;
		private CString _actionDebugName;
		private CFloat _actionActivationTimeStamp;
		private CFloat _startActionTimeStamp;
		private CBool _hasGracefulInterruptionConditions;
		private CFloat _gracefulInterruptionCheckRandomizedInterval;
		private CBool _gracefullyInterrupted;
		private CEnum<EAIActionPhase> _actionPhase;
		private wCHandle<gamedataAIActionPhase_Record> _phaseRecord;
		private CInt32 _nextPhaseConditionCount;
		private CInt32 _repeatPhaseConditionCount;
		private CFloat _phaseActivationTimeStamp;
		private CFloat _phaseConditionSuccessfulCheckTimeStamp;
		private CFloat _phaseConditionCheckTimeStamp;
		private CFloat _phaseConditionCheckRandomizedInterval;
		private CUInt32 _phaseIteration;
		private CFloat _phaseDuration;
		private CFloat _phaseAnimationDuration;
		private CArray<CHandle<entLookAtAddEvent>> _lookatEvents;
		private CHandle<movePolicies> _movePolicy;
		private CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> _generalSubActionsResults;
		private CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> _phaseSubActionsResults;
		private CInt32 _phaseSubActionsCount;
		private CBool _phaseForceZeroUpdateInterval;
		private CInt32 _generalSubActionsCount;
		private CInt32 _repeatPhaseConditionsCount;
		private CBool _tickForActionDurationOnly;
		private CEnum<EAIActionPhase> _tickForActionDurationActivePhase;
		private CBool _hasTicketDeactivationConditions;
		private CBool _isActionImmediate;
		private CBool _lookatActivated;
		private CBool _ticketsCommited;
		private CBool _ticketsAcknowledged;
		private CBool _failureStatus;
		private CBool _animationLoaded;
		private CBool _initializedAfterActivation;
		private CBool _shouldCallGetActionRecordAgain;

		[Ordinal(0)] 
		[RED("actionRecord")] 
		public wCHandle<gamedataAIAction_Record> ActionRecord
		{
			get => GetProperty(ref _actionRecord);
			set => SetProperty(ref _actionRecord, value);
		}

		[Ordinal(1)] 
		[RED("actionDebugName")] 
		public CString ActionDebugName
		{
			get => GetProperty(ref _actionDebugName);
			set => SetProperty(ref _actionDebugName, value);
		}

		[Ordinal(2)] 
		[RED("actionActivationTimeStamp")] 
		public CFloat ActionActivationTimeStamp
		{
			get => GetProperty(ref _actionActivationTimeStamp);
			set => SetProperty(ref _actionActivationTimeStamp, value);
		}

		[Ordinal(3)] 
		[RED("startActionTimeStamp")] 
		public CFloat StartActionTimeStamp
		{
			get => GetProperty(ref _startActionTimeStamp);
			set => SetProperty(ref _startActionTimeStamp, value);
		}

		[Ordinal(4)] 
		[RED("hasGracefulInterruptionConditions")] 
		public CBool HasGracefulInterruptionConditions
		{
			get => GetProperty(ref _hasGracefulInterruptionConditions);
			set => SetProperty(ref _hasGracefulInterruptionConditions, value);
		}

		[Ordinal(5)] 
		[RED("gracefulInterruptionCheckRandomizedInterval")] 
		public CFloat GracefulInterruptionCheckRandomizedInterval
		{
			get => GetProperty(ref _gracefulInterruptionCheckRandomizedInterval);
			set => SetProperty(ref _gracefulInterruptionCheckRandomizedInterval, value);
		}

		[Ordinal(6)] 
		[RED("gracefullyInterrupted")] 
		public CBool GracefullyInterrupted
		{
			get => GetProperty(ref _gracefullyInterrupted);
			set => SetProperty(ref _gracefullyInterrupted, value);
		}

		[Ordinal(7)] 
		[RED("actionPhase")] 
		public CEnum<EAIActionPhase> ActionPhase
		{
			get => GetProperty(ref _actionPhase);
			set => SetProperty(ref _actionPhase, value);
		}

		[Ordinal(8)] 
		[RED("phaseRecord")] 
		public wCHandle<gamedataAIActionPhase_Record> PhaseRecord
		{
			get => GetProperty(ref _phaseRecord);
			set => SetProperty(ref _phaseRecord, value);
		}

		[Ordinal(9)] 
		[RED("nextPhaseConditionCount")] 
		public CInt32 NextPhaseConditionCount
		{
			get => GetProperty(ref _nextPhaseConditionCount);
			set => SetProperty(ref _nextPhaseConditionCount, value);
		}

		[Ordinal(10)] 
		[RED("repeatPhaseConditionCount")] 
		public CInt32 RepeatPhaseConditionCount
		{
			get => GetProperty(ref _repeatPhaseConditionCount);
			set => SetProperty(ref _repeatPhaseConditionCount, value);
		}

		[Ordinal(11)] 
		[RED("phaseActivationTimeStamp")] 
		public CFloat PhaseActivationTimeStamp
		{
			get => GetProperty(ref _phaseActivationTimeStamp);
			set => SetProperty(ref _phaseActivationTimeStamp, value);
		}

		[Ordinal(12)] 
		[RED("phaseConditionSuccessfulCheckTimeStamp")] 
		public CFloat PhaseConditionSuccessfulCheckTimeStamp
		{
			get => GetProperty(ref _phaseConditionSuccessfulCheckTimeStamp);
			set => SetProperty(ref _phaseConditionSuccessfulCheckTimeStamp, value);
		}

		[Ordinal(13)] 
		[RED("phaseConditionCheckTimeStamp")] 
		public CFloat PhaseConditionCheckTimeStamp
		{
			get => GetProperty(ref _phaseConditionCheckTimeStamp);
			set => SetProperty(ref _phaseConditionCheckTimeStamp, value);
		}

		[Ordinal(14)] 
		[RED("phaseConditionCheckRandomizedInterval")] 
		public CFloat PhaseConditionCheckRandomizedInterval
		{
			get => GetProperty(ref _phaseConditionCheckRandomizedInterval);
			set => SetProperty(ref _phaseConditionCheckRandomizedInterval, value);
		}

		[Ordinal(15)] 
		[RED("phaseIteration")] 
		public CUInt32 PhaseIteration
		{
			get => GetProperty(ref _phaseIteration);
			set => SetProperty(ref _phaseIteration, value);
		}

		[Ordinal(16)] 
		[RED("phaseDuration")] 
		public CFloat PhaseDuration
		{
			get => GetProperty(ref _phaseDuration);
			set => SetProperty(ref _phaseDuration, value);
		}

		[Ordinal(17)] 
		[RED("phaseAnimationDuration")] 
		public CFloat PhaseAnimationDuration
		{
			get => GetProperty(ref _phaseAnimationDuration);
			set => SetProperty(ref _phaseAnimationDuration, value);
		}

		[Ordinal(18)] 
		[RED("lookatEvents")] 
		public CArray<CHandle<entLookAtAddEvent>> LookatEvents
		{
			get => GetProperty(ref _lookatEvents);
			set => SetProperty(ref _lookatEvents, value);
		}

		[Ordinal(19)] 
		[RED("movePolicy")] 
		public CHandle<movePolicies> MovePolicy
		{
			get => GetProperty(ref _movePolicy);
			set => SetProperty(ref _movePolicy, value);
		}

		[Ordinal(20)] 
		[RED("generalSubActionsResults", 8)] 
		public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> GeneralSubActionsResults
		{
			get => GetProperty(ref _generalSubActionsResults);
			set => SetProperty(ref _generalSubActionsResults, value);
		}

		[Ordinal(21)] 
		[RED("phaseSubActionsResults", 8)] 
		public CArrayFixedSize<CEnum<AIbehaviorUpdateOutcome>> PhaseSubActionsResults
		{
			get => GetProperty(ref _phaseSubActionsResults);
			set => SetProperty(ref _phaseSubActionsResults, value);
		}

		[Ordinal(22)] 
		[RED("phaseSubActionsCount")] 
		public CInt32 PhaseSubActionsCount
		{
			get => GetProperty(ref _phaseSubActionsCount);
			set => SetProperty(ref _phaseSubActionsCount, value);
		}

		[Ordinal(23)] 
		[RED("phaseForceZeroUpdateInterval")] 
		public CBool PhaseForceZeroUpdateInterval
		{
			get => GetProperty(ref _phaseForceZeroUpdateInterval);
			set => SetProperty(ref _phaseForceZeroUpdateInterval, value);
		}

		[Ordinal(24)] 
		[RED("generalSubActionsCount")] 
		public CInt32 GeneralSubActionsCount
		{
			get => GetProperty(ref _generalSubActionsCount);
			set => SetProperty(ref _generalSubActionsCount, value);
		}

		[Ordinal(25)] 
		[RED("repeatPhaseConditionsCount")] 
		public CInt32 RepeatPhaseConditionsCount
		{
			get => GetProperty(ref _repeatPhaseConditionsCount);
			set => SetProperty(ref _repeatPhaseConditionsCount, value);
		}

		[Ordinal(26)] 
		[RED("tickForActionDurationOnly")] 
		public CBool TickForActionDurationOnly
		{
			get => GetProperty(ref _tickForActionDurationOnly);
			set => SetProperty(ref _tickForActionDurationOnly, value);
		}

		[Ordinal(27)] 
		[RED("tickForActionDurationActivePhase")] 
		public CEnum<EAIActionPhase> TickForActionDurationActivePhase
		{
			get => GetProperty(ref _tickForActionDurationActivePhase);
			set => SetProperty(ref _tickForActionDurationActivePhase, value);
		}

		[Ordinal(28)] 
		[RED("hasTicketDeactivationConditions")] 
		public CBool HasTicketDeactivationConditions
		{
			get => GetProperty(ref _hasTicketDeactivationConditions);
			set => SetProperty(ref _hasTicketDeactivationConditions, value);
		}

		[Ordinal(29)] 
		[RED("isActionImmediate")] 
		public CBool IsActionImmediate
		{
			get => GetProperty(ref _isActionImmediate);
			set => SetProperty(ref _isActionImmediate, value);
		}

		[Ordinal(30)] 
		[RED("lookatActivated")] 
		public CBool LookatActivated
		{
			get => GetProperty(ref _lookatActivated);
			set => SetProperty(ref _lookatActivated, value);
		}

		[Ordinal(31)] 
		[RED("ticketsCommited")] 
		public CBool TicketsCommited
		{
			get => GetProperty(ref _ticketsCommited);
			set => SetProperty(ref _ticketsCommited, value);
		}

		[Ordinal(32)] 
		[RED("ticketsAcknowledged")] 
		public CBool TicketsAcknowledged
		{
			get => GetProperty(ref _ticketsAcknowledged);
			set => SetProperty(ref _ticketsAcknowledged, value);
		}

		[Ordinal(33)] 
		[RED("failureStatus")] 
		public CBool FailureStatus
		{
			get => GetProperty(ref _failureStatus);
			set => SetProperty(ref _failureStatus, value);
		}

		[Ordinal(34)] 
		[RED("animationLoaded")] 
		public CBool AnimationLoaded
		{
			get => GetProperty(ref _animationLoaded);
			set => SetProperty(ref _animationLoaded, value);
		}

		[Ordinal(35)] 
		[RED("initializedAfterActivation")] 
		public CBool InitializedAfterActivation
		{
			get => GetProperty(ref _initializedAfterActivation);
			set => SetProperty(ref _initializedAfterActivation, value);
		}

		[Ordinal(36)] 
		[RED("shouldCallGetActionRecordAgain")] 
		public CBool ShouldCallGetActionRecordAgain
		{
			get => GetProperty(ref _shouldCallGetActionRecordAgain);
			set => SetProperty(ref _shouldCallGetActionRecordAgain, value);
		}

		public TweakAIActionAbstract(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
