using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputActiveFlags : CVariable
	{
		private CBool _buttonHold;
		private CBool _buttonToggle;
		private CBool _driverCombatButtonHold;
		private CBool _driverCombatButtonActivate;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CBool ButtonHold
		{
			get => GetProperty(ref _buttonHold);
			set => SetProperty(ref _buttonHold, value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CBool ButtonToggle
		{
			get => GetProperty(ref _buttonToggle);
			set => SetProperty(ref _buttonToggle, value);
		}

		[Ordinal(2)] 
		[RED("driverCombatButtonHold")] 
		public CBool DriverCombatButtonHold
		{
			get => GetProperty(ref _driverCombatButtonHold);
			set => SetProperty(ref _driverCombatButtonHold, value);
		}

		[Ordinal(3)] 
		[RED("driverCombatButtonActivate")] 
		public CBool DriverCombatButtonActivate
		{
			get => GetProperty(ref _driverCombatButtonActivate);
			set => SetProperty(ref _driverCombatButtonActivate, value);
		}

		public PlayerVisionModeControllerInputActiveFlags(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
