using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questvehicleChaseParams : questVehicleSpecificCommandParams
	{
		private gameEntityReference _targetEntRef;
		private CBool _isPlayer;
		private CFloat _distanceMin;
		private CFloat _distanceMax;
		private CFloat _forceStartSpeed;
		private CBool _aggressiveRammingEnabled;
		private CBool _ignoreChaseVehiclesLimit;
		private CBool _boostDrivingStats;

		[Ordinal(3)] 
		[RED("targetEntRef")] 
		public gameEntityReference TargetEntRef
		{
			get => GetProperty(ref _targetEntRef);
			set => SetProperty(ref _targetEntRef, value);
		}

		[Ordinal(4)] 
		[RED("isPlayer")] 
		public CBool IsPlayer
		{
			get => GetProperty(ref _isPlayer);
			set => SetProperty(ref _isPlayer, value);
		}

		[Ordinal(5)] 
		[RED("distanceMin")] 
		public CFloat DistanceMin
		{
			get => GetProperty(ref _distanceMin);
			set => SetProperty(ref _distanceMin, value);
		}

		[Ordinal(6)] 
		[RED("distanceMax")] 
		public CFloat DistanceMax
		{
			get => GetProperty(ref _distanceMax);
			set => SetProperty(ref _distanceMax, value);
		}

		[Ordinal(7)] 
		[RED("forceStartSpeed")] 
		public CFloat ForceStartSpeed
		{
			get => GetProperty(ref _forceStartSpeed);
			set => SetProperty(ref _forceStartSpeed, value);
		}

		[Ordinal(8)] 
		[RED("aggressiveRammingEnabled")] 
		public CBool AggressiveRammingEnabled
		{
			get => GetProperty(ref _aggressiveRammingEnabled);
			set => SetProperty(ref _aggressiveRammingEnabled, value);
		}

		[Ordinal(9)] 
		[RED("ignoreChaseVehiclesLimit")] 
		public CBool IgnoreChaseVehiclesLimit
		{
			get => GetProperty(ref _ignoreChaseVehiclesLimit);
			set => SetProperty(ref _ignoreChaseVehiclesLimit, value);
		}

		[Ordinal(10)] 
		[RED("boostDrivingStats")] 
		public CBool BoostDrivingStats
		{
			get => GetProperty(ref _boostDrivingStats);
			set => SetProperty(ref _boostDrivingStats, value);
		}

		public questvehicleChaseParams(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
