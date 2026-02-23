using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDriveChaseTargetTreeNodeDefinition : AIbehaviorDriveTreeNodeDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CHandle<AIArgumentMapping> _distanceMin;
		private CHandle<AIArgumentMapping> _distanceMax;
		private CHandle<AIArgumentMapping> _forcedStartSpeed;
		private CHandle<AIArgumentMapping> _needDriver;
		private CHandle<AIArgumentMapping> _aggressiveRammingEnabled;
		private CHandle<AIArgumentMapping> _ignoreChaseVehiclesLimit;
		private CHandle<AIArgumentMapping> _boostDrivingStats;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("distanceMin")] 
		public CHandle<AIArgumentMapping> DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(3)] 
		[RED("distanceMax")] 
		public CHandle<AIArgumentMapping> DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(4)] 
		[RED("forcedStartSpeed")] 
		public CHandle<AIArgumentMapping> ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(5)] 
		[RED("needDriver")] 
		public CHandle<AIArgumentMapping> NeedDriver
		{
			get => GetProperty(ref _needDriver);
			set => SetProperty(ref _needDriver, value);
		}

		[Ordinal(6)] 
		[RED("aggressiveRammingEnabled")] 
		public CHandle<AIArgumentMapping> AggressiveRammingEnabled
		{
			get => GetProperty(ref _aggressiveRammingEnabled);
			set => SetProperty(ref _aggressiveRammingEnabled, value);
		}

		[Ordinal(7)] 
		[RED("ignoreChaseVehiclesLimit")] 
		public CHandle<AIArgumentMapping> IgnoreChaseVehiclesLimit
		{
			get => GetProperty(ref _ignoreChaseVehiclesLimit);
			set => SetProperty(ref _ignoreChaseVehiclesLimit, value);
		}

		[Ordinal(8)] 
		[RED("boostDrivingStats")] 
		public CHandle<AIArgumentMapping> BoostDrivingStats
		{
			get => GetProperty(ref _boostDrivingStats);
			set => SetProperty(ref _boostDrivingStats, value);
		}

		public AIbehaviorDriveChaseTargetTreeNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
