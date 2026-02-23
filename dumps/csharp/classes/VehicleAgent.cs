using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleAgent : AgentBase
	{
		private wCHandle<vehicleBaseObject> _unit;
		private CInt32 _passangers;
		private CInt32 _slotsTotal;
		private CInt32 _slotsReserved;
		private CInt32 _slotsAvailable;
		private CBool _everHadPassengers;
		private CFloat _distanceToPlayerSquared;
		private CEnum<LifetimeStatus> _lifetimeStatus;
		private CFloat _nearTimeStamp;

		[Ordinal(3)] 
		[RED("unit")] 
		public wCHandle<vehicleBaseObject> Unit
		{
			get => GetProperty(ref _unit);
			set => SetProperty(ref _unit, value);
		}

		[Ordinal(4)] 
		[RED("passangers")] 
		public CInt32 Passangers
		{
			get => GetProperty(ref _passangers);
			set => SetProperty(ref _passangers, value);
		}

		[Ordinal(5)] 
		[RED("slotsTotal")] 
		public CInt32 SlotsTotal
		{
			get => GetProperty(ref _slotsTotal);
			set => SetProperty(ref _slotsTotal, value);
		}

		[Ordinal(6)] 
		[RED("slotsReserved")] 
		public CInt32 SlotsReserved
		{
			get => GetProperty(ref _slotsReserved);
			set => SetProperty(ref _slotsReserved, value);
		}

		[Ordinal(7)] 
		[RED("slotsAvailable")] 
		public CInt32 SlotsAvailable
		{
			get => GetProperty(ref _slotsAvailable);
			set => SetProperty(ref _slotsAvailable, value);
		}

		[Ordinal(8)] 
		[RED("everHadPassengers")] 
		public CBool EverHadPassengers
		{
			get => GetProperty(ref _everHadPassengers);
			set => SetProperty(ref _everHadPassengers, value);
		}

		[Ordinal(9)] 
		[RED("distanceToPlayerSquared")] 
		public CFloat DistanceToPlayerSquared
		{
			get => GetProperty(ref _distanceToPlayerSquared);
			set => SetProperty(ref _distanceToPlayerSquared, value);
		}

		[Ordinal(10)] 
		[RED("lifetimeStatus")] 
		public CEnum<LifetimeStatus> LifetimeStatus
		{
			get => GetProperty(ref _lifetimeStatus);
			set => SetProperty(ref _lifetimeStatus, value);
		}

		[Ordinal(11)] 
		[RED("nearTimeStamp")] 
		public CFloat NearTimeStamp
		{
			get => GetProperty(ref _nearTimeStamp);
			set => SetProperty(ref _nearTimeStamp, value);
		}

		public VehicleAgent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
