using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questVehicleWater_ConditionType : questIVehicleConditionType
	{
		private CBool _anyVehicle;
		private gameEntityReference _vehicleRef;
		private CBool _submergedOnly;
		private CBool _onEnter;

		[Ordinal(0)] 
		[RED("anyVehicle")] 
		public CBool AnyVehicle
		{
			get => GetProperty(ref _anyVehicle);
			set => SetProperty(ref _anyVehicle, value);
		}

		[Ordinal(1)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(2)] 
		[RED("submergedOnly")] 
		public CBool SubmergedOnly
		{
			get => GetProperty(ref _submergedOnly);
			set => SetProperty(ref _submergedOnly, value);
		}

		[Ordinal(3)] 
		[RED("onEnter")] 
		public CBool OnEnter
		{
			get => GetProperty(ref _onEnter);
			set => SetProperty(ref _onEnter, value);
		}

		public questVehicleWater_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
