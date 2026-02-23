using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorInstantJoinTrafficConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _joinTrafficSettings;
		private CHandle<AIArgumentMapping> _closestPointOnPath;
		private CHandle<AIArgumentMapping> _pathDirection;
		private CHandle<AIArgumentMapping> _runOnTraffic;

		[Ordinal(1)] 
		[RED("joinTrafficSettings")] 
		public CHandle<AIArgumentMapping> JoinTrafficSettings
		{
			get => GetProperty(ref _joinTrafficSettings);
			set => SetProperty(ref _joinTrafficSettings, value);
		}

		[Ordinal(2)] 
		[RED("closestPointOnPath")] 
		public CHandle<AIArgumentMapping> ClosestPointOnPath
		{
			get => GetProperty(ref _closestPointOnPath);
			set => SetProperty(ref _closestPointOnPath, value);
		}

		[Ordinal(3)] 
		[RED("pathDirection")] 
		public CHandle<AIArgumentMapping> PathDirection
		{
			get => GetProperty(ref _pathDirection);
			set => SetProperty(ref _pathDirection, value);
		}

		[Ordinal(4)] 
		[RED("runOnTraffic")] 
		public CHandle<AIArgumentMapping> RunOnTraffic
		{
			get => GetProperty(ref _runOnTraffic);
			set => SetProperty(ref _runOnTraffic, value);
		}

		public AIbehaviorInstantJoinTrafficConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
