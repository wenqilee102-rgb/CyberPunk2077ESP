using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestChangeDoorStateEvent : redEvent
	{
		private CEnum<vehicleEVehicleDoor> _door;
		private CEnum<vehicleEQuestVehicleDoorState> _newState;
		private CBool _forceScene;

		[Ordinal(0)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetProperty(ref _door);
			set => SetProperty(ref _door, value);
		}

		[Ordinal(1)] 
		[RED("newState")] 
		public CEnum<vehicleEQuestVehicleDoorState> NewState
		{
			get => GetProperty(ref _newState);
			set => SetProperty(ref _newState, value);
		}

		[Ordinal(2)] 
		[RED("forceScene")] 
		public CBool ForceScene
		{
			get => GetProperty(ref _forceScene);
			set => SetProperty(ref _forceScene, value);
		}

		public VehicleQuestChangeDoorStateEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
