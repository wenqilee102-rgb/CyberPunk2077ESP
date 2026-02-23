using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatPoolBasedStatusEffectEffector : gameEffector
	{
		private CEnum<gamedataStatPoolType> _statPool;
		private TweakDBID _statusEffectID;
		private CFloat _statPoolStep;
		private CBool _stepUsesPercent;
		private CFloat _startingThreshold;
		private CBool _thresholdUsesPercent;
		private CInt32 _minStacks;
		private CInt32 _maxStacks;
		private CBool _inverted;
		private CBool _roundUpwards;
		private CBool _dontRemoveStacks;
		private CString _targetOfStatPoolCheck;
		private CHandle<StatPoolBasedStatusEffectEffectorListener> _listener;
		private CInt32 _currentStacks;
		private CInt32 _realMaxStacks;
		private TweakDBID _statPoolRecordID;
		private ScriptGameInstance _gameInstance;
		private entEntityID _ownerID;
		private CBool _checkStatPoolOnWeapon;
		private entEntityID _ownerWeaponID;

		[Ordinal(0)] 
		[RED("statPool")] 
		public CEnum<gamedataStatPoolType> StatPool
		{
			get => GetProperty(ref _statPool);
			set => SetProperty(ref _statPool, value);
		}

		[Ordinal(1)] 
		[RED("statusEffectID")] 
		public TweakDBID StatusEffectID
		{
			get => GetProperty(ref _statusEffectID);
			set => SetProperty(ref _statusEffectID, value);
		}

		[Ordinal(2)] 
		[RED("statPoolStep")] 
		public CFloat StatPoolStep
		{
			get => GetProperty(ref _statPoolStep);
			set => SetProperty(ref _statPoolStep, value);
		}

		[Ordinal(3)] 
		[RED("stepUsesPercent")] 
		public CBool StepUsesPercent
		{
			get => GetProperty(ref _stepUsesPercent);
			set => SetProperty(ref _stepUsesPercent, value);
		}

		[Ordinal(4)] 
		[RED("startingThreshold")] 
		public CFloat StartingThreshold
		{
			get => GetProperty(ref _startingThreshold);
			set => SetProperty(ref _startingThreshold, value);
		}

		[Ordinal(5)] 
		[RED("thresholdUsesPercent")] 
		public CBool ThresholdUsesPercent
		{
			get => GetProperty(ref _thresholdUsesPercent);
			set => SetProperty(ref _thresholdUsesPercent, value);
		}

		[Ordinal(6)] 
		[RED("minStacks")] 
		public CInt32 MinStacks
		{
			get => GetProperty(ref _minStacks);
			set => SetProperty(ref _minStacks, value);
		}

		[Ordinal(7)] 
		[RED("maxStacks")] 
		public CInt32 MaxStacks
		{
			get => GetProperty(ref _maxStacks);
			set => SetProperty(ref _maxStacks, value);
		}

		[Ordinal(8)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(9)] 
		[RED("roundUpwards")] 
		public CBool RoundUpwards
		{
			get => GetProperty(ref _roundUpwards);
			set => SetProperty(ref _roundUpwards, value);
		}

		[Ordinal(10)] 
		[RED("dontRemoveStacks")] 
		public CBool DontRemoveStacks
		{
			get => GetProperty(ref _dontRemoveStacks);
			set => SetProperty(ref _dontRemoveStacks, value);
		}

		[Ordinal(11)] 
		[RED("targetOfStatPoolCheck")] 
		public CString TargetOfStatPoolCheck
		{
			get => GetProperty(ref _targetOfStatPoolCheck);
			set => SetProperty(ref _targetOfStatPoolCheck, value);
		}

		[Ordinal(12)] 
		[RED("listener")] 
		public CHandle<StatPoolBasedStatusEffectEffectorListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(13)] 
		[RED("currentStacks")] 
		public CInt32 CurrentStacks
		{
			get => GetProperty(ref _currentStacks);
			set => SetProperty(ref _currentStacks, value);
		}

		[Ordinal(14)] 
		[RED("realMaxStacks")] 
		public CInt32 RealMaxStacks
		{
			get => GetProperty(ref _realMaxStacks);
			set => SetProperty(ref _realMaxStacks, value);
		}

		[Ordinal(15)] 
		[RED("statPoolRecordID")] 
		public TweakDBID StatPoolRecordID
		{
			get => GetProperty(ref _statPoolRecordID);
			set => SetProperty(ref _statPoolRecordID, value);
		}

		[Ordinal(16)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetProperty(ref _gameInstance);
			set => SetProperty(ref _gameInstance, value);
		}

		[Ordinal(17)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetProperty(ref _ownerID);
			set => SetProperty(ref _ownerID, value);
		}

		[Ordinal(18)] 
		[RED("checkStatPoolOnWeapon")] 
		public CBool CheckStatPoolOnWeapon
		{
			get => GetProperty(ref _checkStatPoolOnWeapon);
			set => SetProperty(ref _checkStatPoolOnWeapon, value);
		}

		[Ordinal(19)] 
		[RED("ownerWeaponID")] 
		public entEntityID OwnerWeaponID
		{
			get => GetProperty(ref _ownerWeaponID);
			set => SetProperty(ref _ownerWeaponID, value);
		}

		public StatPoolBasedStatusEffectEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
