using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GenericHitPrereq : gameIScriptablePrereq
	{
		private CBool _isSync;
		private CBool _processMiss;
		private CEnum<gameDamageCallbackType> _callbackType;
		private CEnum<gameDamagePipelineStage> _pipelineStage;
		private CEnum<gameDamageListenerPipelineType> _pipelineType;
		private CEnum<gamedataAttackType> _attackType;
		private CArray<CHandle<BaseHitPrereqCondition>> _conditions;
		private CBool _ignoreSelfInflictedPressureWave;

		[Ordinal(0)] 
		[RED("isSync")] 
		public CBool IsSync
		{
			get => GetProperty(ref _isSync);
			set => SetProperty(ref _isSync, value);
		}

		[Ordinal(1)] 
		[RED("processMiss")] 
		public CBool ProcessMiss
		{
			get => GetProperty(ref _processMiss);
			set => SetProperty(ref _processMiss, value);
		}

		[Ordinal(2)] 
		[RED("callbackType")] 
		public CEnum<gameDamageCallbackType> CallbackType
		{
			get => GetProperty(ref _callbackType);
			set => SetProperty(ref _callbackType, value);
		}

		[Ordinal(3)] 
		[RED("pipelineStage")] 
		public CEnum<gameDamagePipelineStage> PipelineStage
		{
			get => GetProperty(ref _pipelineStage);
			set => SetProperty(ref _pipelineStage, value);
		}

		[Ordinal(4)] 
		[RED("pipelineType")] 
		public CEnum<gameDamageListenerPipelineType> PipelineType
		{
			get => GetProperty(ref _pipelineType);
			set => SetProperty(ref _pipelineType, value);
		}

		[Ordinal(5)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetProperty(ref _attackType);
			set => SetProperty(ref _attackType, value);
		}

		[Ordinal(6)] 
		[RED("conditions")] 
		public CArray<CHandle<BaseHitPrereqCondition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		[Ordinal(7)] 
		[RED("ignoreSelfInflictedPressureWave")] 
		public CBool IgnoreSelfInflictedPressureWave
		{
			get => GetProperty(ref _ignoreSelfInflictedPressureWave);
			set => SetProperty(ref _ignoreSelfInflictedPressureWave, value);
		}

		public GenericHitPrereq(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
