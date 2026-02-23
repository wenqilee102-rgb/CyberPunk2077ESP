using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleWheelPressureEvent : redEvent
	{
		private Vector3 _contactPoint;
		private Vector3 _impulse;

		[Ordinal(0)] 
		[RED("contactPoint")] 
		public Vector3 ContactPoint
		{
			get => GetProperty(ref _contactPoint);
			set => SetProperty(ref _contactPoint, value);
		}

		[Ordinal(1)] 
		[RED("impulse")] 
		public Vector3 Impulse
		{
			get => GetProperty(ref _impulse);
			set => SetProperty(ref _impulse, value);
		}

		public vehicleVehicleWheelPressureEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
