using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleHijackEvent : redEvent
	{
		private CBool _driverAllowedToGetAggressive;

		[Ordinal(0)] 
		[RED("driverAllowedToGetAggressive")] 
		public CBool DriverAllowedToGetAggressive
		{
			get => GetProperty(ref _driverAllowedToGetAggressive);
			set => SetProperty(ref _driverAllowedToGetAggressive, value);
		}

		public VehicleHijackEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
