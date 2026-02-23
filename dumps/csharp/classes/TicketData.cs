using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TicketData : CVariable
	{
		private CUInt32 _requestID;
		private CEnum<vehiclePoliceStrategy> _policeStrategy;
		private CEnum<gameDynamicVehicleType> _vehicleType;
		private CBool _isFallback;

		[Ordinal(0)] 
		[RED("requestID")] 
		public CUInt32 RequestID
		{
			get => GetProperty(ref _requestID);
			set => SetProperty(ref _requestID, value);
		}

		[Ordinal(1)] 
		[RED("policeStrategy")] 
		public CEnum<vehiclePoliceStrategy> PoliceStrategy
		{
			get => GetProperty(ref _policeStrategy);
			set => SetProperty(ref _policeStrategy, value);
		}

		[Ordinal(2)] 
		[RED("vehicleType")] 
		public CEnum<gameDynamicVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(3)] 
		[RED("isFallback")] 
		public CBool IsFallback
		{
			get => GetProperty(ref _isFallback);
			set => SetProperty(ref _isFallback, value);
		}

		public TicketData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
