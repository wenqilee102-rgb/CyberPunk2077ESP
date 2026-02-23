using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeTransition : DefaultTransition
	{
		private CString _stateNameString;
		private CHandle<DriverCombatListener> _driverCombatListener;

		[Ordinal(0)] 
		[RED("stateNameString")] 
		public CString StateNameString
		{
			get => GetProperty(ref _stateNameString);
			set => SetProperty(ref _stateNameString, value);
		}

		[Ordinal(1)] 
		[RED("driverCombatListener")] 
		public CHandle<DriverCombatListener> DriverCombatListener
		{
			get => GetProperty(ref _driverCombatListener);
			set => SetProperty(ref _driverCombatListener, value);
		}

		public MeleeTransition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
