using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReflexesMasterPerk1Effector : ModifyAttackEffector
	{
		private CEnum<EMathOperator> _operationType;
		private CFloat _value;
		private CFloat _timeOut;
		private CArray<CHandle<gameeventsHitEvent>> _damageHistory;
		private CHandle<ReflexesMasterPerk1EffectorListener> _listener;
		private entEntityID _lastTargetID;

		[Ordinal(0)] 
		[RED("operationType")] 
		public CEnum<EMathOperator> OperationType
		{
			get => GetProperty(ref _operationType);
			set => SetProperty(ref _operationType, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("timeOut")] 
		public CFloat TimeOut
		{
			get => GetProperty(ref _timeOut);
			set => SetProperty(ref _timeOut, value);
		}

		[Ordinal(3)] 
		[RED("damageHistory")] 
		public CArray<CHandle<gameeventsHitEvent>> DamageHistory
		{
			get => GetProperty(ref _damageHistory);
			set => SetProperty(ref _damageHistory, value);
		}

		[Ordinal(4)] 
		[RED("listener")] 
		public CHandle<ReflexesMasterPerk1EffectorListener> Listener
		{
			get => GetProperty(ref _listener);
			set => SetProperty(ref _listener, value);
		}

		[Ordinal(5)] 
		[RED("lastTargetID")] 
		public entEntityID LastTargetID
		{
			get => GetProperty(ref _lastTargetID);
			set => SetProperty(ref _lastTargetID, value);
		}

		public ReflexesMasterPerk1Effector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
