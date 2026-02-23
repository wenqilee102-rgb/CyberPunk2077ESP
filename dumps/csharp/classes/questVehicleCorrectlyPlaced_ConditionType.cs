using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleCorrectlyPlaced_ConditionType : questIVehicleConditionType
	{
		private gameEntityReference _vehicleRef;
		private CFloat _timeInterval;
		private CBool _checkIsUpsideDown;
		private CBool _checkIsOnTheSide;
		private CBool _checkAreAllWheelsOnGround;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("timeInterval")] 
		public CFloat TimeInterval
		{
			get => GetProperty(ref _timeInterval);
			set => SetProperty(ref _timeInterval, value);
		}

		[Ordinal(2)] 
		[RED("checkIsUpsideDown")] 
		public CBool CheckIsUpsideDown
		{
			get => GetProperty(ref _checkIsUpsideDown);
			set => SetProperty(ref _checkIsUpsideDown, value);
		}

		[Ordinal(3)] 
		[RED("checkIsOnTheSide")] 
		public CBool CheckIsOnTheSide
		{
			get => GetProperty(ref _checkIsOnTheSide);
			set => SetProperty(ref _checkIsOnTheSide, value);
		}

		[Ordinal(4)] 
		[RED("checkAreAllWheelsOnGround")] 
		public CBool CheckAreAllWheelsOnGround
		{
			get => GetProperty(ref _checkAreAllWheelsOnGround);
			set => SetProperty(ref _checkAreAllWheelsOnGround, value);
		}

		[Ordinal(5)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questVehicleCorrectlyPlaced_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
