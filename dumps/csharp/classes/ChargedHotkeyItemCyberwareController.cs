using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedHotkeyItemCyberwareController : ChargedHotkeyItemBaseController
	{
		private CEnum<gamedataStatPoolType> _currentStatPoolType;
		private CHandle<redCallbackObject> _psmBlackboardListener;
		private CEnum<gamedataNewPerkType> _c_cyberdeckOverclockPerkType;
		private CEnum<gamedataNewPerkType> _c_vehicleManeuversPerkType;
		private CName _c_berserkKey;
		private CName _c_cyberdeckKey;
		private CName _c_sandevistanKey;
		private CName _c_capacityBoosterKey;

		[Ordinal(45)] 
		[RED("currentStatPoolType")] 
		public CEnum<gamedataStatPoolType> CurrentStatPoolType
		{
			get => GetProperty(ref _currentStatPoolType);
			set => SetProperty(ref _currentStatPoolType, value);
		}

		[Ordinal(46)] 
		[RED("psmBlackboardListener")] 
		public CHandle<redCallbackObject> PsmBlackboardListener
		{
			get => GetProperty(ref _psmBlackboardListener);
			set => SetProperty(ref _psmBlackboardListener, value);
		}

		[Ordinal(47)] 
		[RED("c_cyberdeckOverclockPerkType")] 
		public CEnum<gamedataNewPerkType> C_cyberdeckOverclockPerkType
		{
			get => GetProperty(ref _c_cyberdeckOverclockPerkType);
			set => SetProperty(ref _c_cyberdeckOverclockPerkType, value);
		}

		[Ordinal(48)] 
		[RED("c_vehicleManeuversPerkType")] 
		public CEnum<gamedataNewPerkType> C_vehicleManeuversPerkType
		{
			get => GetProperty(ref _c_vehicleManeuversPerkType);
			set => SetProperty(ref _c_vehicleManeuversPerkType, value);
		}

		[Ordinal(49)] 
		[RED("c_berserkKey")] 
		public CName C_berserkKey
		{
			get => GetProperty(ref _c_berserkKey);
			set => SetProperty(ref _c_berserkKey, value);
		}

		[Ordinal(50)] 
		[RED("c_cyberdeckKey")] 
		public CName C_cyberdeckKey
		{
			get => GetProperty(ref _c_cyberdeckKey);
			set => SetProperty(ref _c_cyberdeckKey, value);
		}

		[Ordinal(51)] 
		[RED("c_sandevistanKey")] 
		public CName C_sandevistanKey
		{
			get => GetProperty(ref _c_sandevistanKey);
			set => SetProperty(ref _c_sandevistanKey, value);
		}

		[Ordinal(52)] 
		[RED("c_capacityBoosterKey")] 
		public CName C_capacityBoosterKey
		{
			get => GetProperty(ref _c_capacityBoosterKey);
			set => SetProperty(ref _c_capacityBoosterKey, value);
		}

		public ChargedHotkeyItemCyberwareController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
