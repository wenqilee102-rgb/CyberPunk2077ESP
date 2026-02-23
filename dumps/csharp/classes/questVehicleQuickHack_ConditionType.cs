using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleQuickHack_ConditionType : questIVehicleConditionType
	{
		private gameEntityReference _vehicleRef;
		private CBool _checkAccelerate;
		private CBool _checkForceBrakes;
		private CBool _checkRemoteControl;

		[Ordinal(0)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(1)] 
		[RED("checkAccelerate")] 
		public CBool CheckAccelerate
		{
			get => GetProperty(ref _checkAccelerate);
			set => SetProperty(ref _checkAccelerate, value);
		}

		[Ordinal(2)] 
		[RED("checkForceBrakes")] 
		public CBool CheckForceBrakes
		{
			get => GetProperty(ref _checkForceBrakes);
			set => SetProperty(ref _checkForceBrakes, value);
		}

		[Ordinal(3)] 
		[RED("checkRemoteControl")] 
		public CBool CheckRemoteControl
		{
			get => GetProperty(ref _checkRemoteControl);
			set => SetProperty(ref _checkRemoteControl, value);
		}

		public questVehicleQuickHack_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
