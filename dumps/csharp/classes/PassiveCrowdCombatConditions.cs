using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PassiveCrowdCombatConditions : PassiveAutonomousCondition
	{
		private CUInt32 _threatCbId;
		private CUInt32 _delayEvaluationCbId;
		private CUInt32 _onItemAddedToSlotCbId;
		private CUInt32 _crowdCombatConditionCbId;

		[Ordinal(0)] 
		[RED("threatCbId")] 
		public CUInt32 ThreatCbId
		{
			get => GetProperty(ref _threatCbId);
			set => SetProperty(ref _threatCbId, value);
		}

		[Ordinal(1)] 
		[RED("delayEvaluationCbId")] 
		public CUInt32 DelayEvaluationCbId
		{
			get => GetProperty(ref _delayEvaluationCbId);
			set => SetProperty(ref _delayEvaluationCbId, value);
		}

		[Ordinal(2)] 
		[RED("onItemAddedToSlotCbId")] 
		public CUInt32 OnItemAddedToSlotCbId
		{
			get => GetProperty(ref _onItemAddedToSlotCbId);
			set => SetProperty(ref _onItemAddedToSlotCbId, value);
		}

		[Ordinal(3)] 
		[RED("crowdCombatConditionCbId")] 
		public CUInt32 CrowdCombatConditionCbId
		{
			get => GetProperty(ref _crowdCombatConditionCbId);
			set => SetProperty(ref _crowdCombatConditionCbId, value);
		}

		public PassiveCrowdCombatConditions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
