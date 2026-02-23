using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActionsNames : CVariable
	{
		private CName _buttonHold;
		private CName _buttonToggle;
		private CName _driverCombatButtonHold;
		private CName _driverCombatButtonActivate;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CName ButtonHold
		{
			get => GetProperty(ref _buttonHold);
			set => SetProperty(ref _buttonHold, value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CName ButtonToggle
		{
			get => GetProperty(ref _buttonToggle);
			set => SetProperty(ref _buttonToggle, value);
		}

		[Ordinal(2)] 
		[RED("driverCombatButtonHold")] 
		public CName DriverCombatButtonHold
		{
			get => GetProperty(ref _driverCombatButtonHold);
			set => SetProperty(ref _driverCombatButtonHold, value);
		}

		[Ordinal(3)] 
		[RED("driverCombatButtonActivate")] 
		public CName DriverCombatButtonActivate
		{
			get => GetProperty(ref _driverCombatButtonActivate);
			set => SetProperty(ref _driverCombatButtonActivate, value);
		}

		public PlayerVisionModeControllerInputActionsNames(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
