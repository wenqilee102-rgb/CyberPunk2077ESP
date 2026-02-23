using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleBumpEvent : redEvent
	{
		private CFloat _impactVelocityChange;
		private CBool _isInTraffic;
		private wCHandle<vehicleBaseObject> _hitVehicle;
		private Vector3 _hitNormal;

		[Ordinal(0)] 
		[RED("impactVelocityChange")] 
		public CFloat ImpactVelocityChange
		{
			get => GetProperty(ref _impactVelocityChange);
			set => SetProperty(ref _impactVelocityChange, value);
		}

		[Ordinal(1)] 
		[RED("isInTraffic")] 
		public CBool IsInTraffic
		{
			get => GetProperty(ref _isInTraffic);
			set => SetProperty(ref _isInTraffic, value);
		}

		[Ordinal(2)] 
		[RED("hitVehicle")] 
		public wCHandle<vehicleBaseObject> HitVehicle
		{
			get => GetProperty(ref _hitVehicle);
			set => SetProperty(ref _hitVehicle, value);
		}

		[Ordinal(3)] 
		[RED("hitNormal")] 
		public Vector3 HitNormal
		{
			get => GetProperty(ref _hitNormal);
			set => SetProperty(ref _hitNormal, value);
		}

		public vehicleVehicleBumpEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
