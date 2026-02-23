using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class cameraShotRoot_FixedOnVehicle : vehicleCinematicCameraShotRoot
	{
		private CFloat _deccelerationAmount;
		private CFloat _detachToVehicleTime;
		private CBool _detachedFromVehicle;
		private Vector4 _detachedDirection;
		private CFloat _detachedSpeed;
		private WorldTransform _detachedTransform;

		[Ordinal(0)] 
		[RED("deccelerationAmount")] 
		public CFloat DeccelerationAmount
		{
			get => GetProperty(ref _deccelerationAmount);
			set => SetProperty(ref _deccelerationAmount, value);
		}

		[Ordinal(1)] 
		[RED("detachToVehicleTime")] 
		public CFloat DetachToVehicleTime
		{
			get => GetProperty(ref _detachToVehicleTime);
			set => SetProperty(ref _detachToVehicleTime, value);
		}

		[Ordinal(2)] 
		[RED("detachedFromVehicle")] 
		public CBool DetachedFromVehicle
		{
			get => GetProperty(ref _detachedFromVehicle);
			set => SetProperty(ref _detachedFromVehicle, value);
		}

		[Ordinal(3)] 
		[RED("detachedDirection")] 
		public Vector4 DetachedDirection
		{
			get => GetProperty(ref _detachedDirection);
			set => SetProperty(ref _detachedDirection, value);
		}

		[Ordinal(4)] 
		[RED("detachedSpeed")] 
		public CFloat DetachedSpeed
		{
			get => GetProperty(ref _detachedSpeed);
			set => SetProperty(ref _detachedSpeed, value);
		}

		[Ordinal(5)] 
		[RED("detachedTransform")] 
		public WorldTransform DetachedTransform
		{
			get => GetProperty(ref _detachedTransform);
			set => SetProperty(ref _detachedTransform, value);
		}

		public cameraShotRoot_FixedOnVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
