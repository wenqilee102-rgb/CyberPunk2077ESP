using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayerVisionModeControllerInputListeners : CVariable
	{
		private CUInt32 _buttonHold;
		private CUInt32 _buttonToggle;
		private CUInt32 _driverCombatButtonHold;
		private CUInt32 _driverCombatButtonActivate;

		[Ordinal(0)] 
		[RED("buttonHold")] 
		public CUInt32 ButtonHold
		{
			get => GetProperty(ref _buttonHold);
			set => SetProperty(ref _buttonHold, value);
		}

		[Ordinal(1)] 
		[RED("buttonToggle")] 
		public CUInt32 ButtonToggle
		{
			get => GetProperty(ref _buttonToggle);
			set => SetProperty(ref _buttonToggle, value);
		}

		[Ordinal(2)] 
		[RED("driverCombatButtonHold")] 
		public CUInt32 DriverCombatButtonHold
		{
			get => GetProperty(ref _driverCombatButtonHold);
			set => SetProperty(ref _driverCombatButtonHold, value);
		}

		[Ordinal(3)] 
		[RED("driverCombatButtonActivate")] 
		public CUInt32 DriverCombatButtonActivate
		{
			get => GetProperty(ref _driverCombatButtonActivate);
			set => SetProperty(ref _driverCombatButtonActivate, value);
		}

		public PlayerVisionModeControllerInputListeners(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
