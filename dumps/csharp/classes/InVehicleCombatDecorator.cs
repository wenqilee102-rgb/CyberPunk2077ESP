using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InVehicleCombatDecorator : AIVehicleTaskAbstract
	{
		private wCHandle<gameObject> _targetToChase;
		private CHandle<AIVehicleChaseCommand> _vehCommand;

		[Ordinal(0)] 
		[RED("targetToChase")] 
		public wCHandle<gameObject> TargetToChase
		{
			get => GetProperty(ref _targetToChase);
			set => SetProperty(ref _targetToChase, value);
		}

		[Ordinal(1)] 
		[RED("vehCommand")] 
		public CHandle<AIVehicleChaseCommand> VehCommand
		{
			get => GetProperty(ref _vehCommand);
			set => SetProperty(ref _vehCommand, value);
		}

		public InVehicleCombatDecorator(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
