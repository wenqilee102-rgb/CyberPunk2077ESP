using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleVehicleContactEvent : redEvent
	{
		private wCHandle<gameObject> _otherVehicle;

		[Ordinal(0)] 
		[RED("otherVehicle")] 
		public wCHandle<gameObject> OtherVehicle
		{
			get => GetProperty(ref _otherVehicle);
			set => SetProperty(ref _otherVehicle, value);
		}

		public vehicleVehicleContactEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
