using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleUnableToStartPanicDriving : redEvent
	{
		private CBool _forceExitVehicle;

		[Ordinal(0)] 
		[RED("forceExitVehicle")] 
		public CBool ForceExitVehicle
		{
			get => GetProperty(ref _forceExitVehicle);
			set => SetProperty(ref _forceExitVehicle, value);
		}

		public vehicleUnableToStartPanicDriving(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
