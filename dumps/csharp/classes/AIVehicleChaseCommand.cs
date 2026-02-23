using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIVehicleChaseCommand : AIVehicleCommand
	{
		private wCHandle<gameObject> _target;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CFloat _forcedStartSpeed;
		private CBool _aggressiveRamming;
		private CBool _ignoreChaseVehiclesLimit;
		private CBool _boostDrivingStats;

		[Ordinal(6)] 
		[RED("target")] 
		public wCHandle<gameObject> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(7)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(8)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(9)] 
		[RED("forcedStartSpeed")] 
		public CFloat ForcedStartSpeed
		{
			get => GetProperty(ref _forcedStartSpeed);
			set => SetProperty(ref _forcedStartSpeed, value);
		}

		[Ordinal(10)] 
		[RED("aggressiveRamming")] 
		public CBool AggressiveRamming
		{
			get => GetProperty(ref _aggressiveRamming);
			set => SetProperty(ref _aggressiveRamming, value);
		}

		[Ordinal(11)] 
		[RED("ignoreChaseVehiclesLimit")] 
		public CBool IgnoreChaseVehiclesLimit
		{
			get => GetProperty(ref _ignoreChaseVehiclesLimit);
			set => SetProperty(ref _ignoreChaseVehiclesLimit, value);
		}

		[Ordinal(12)] 
		[RED("boostDrivingStats")] 
		public CBool BoostDrivingStats
		{
			get => GetProperty(ref _boostDrivingStats);
			set => SetProperty(ref _boostDrivingStats, value);
		}

		public AIVehicleChaseCommand(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
