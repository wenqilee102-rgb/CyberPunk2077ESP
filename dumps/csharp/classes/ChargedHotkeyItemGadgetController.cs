using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargedHotkeyItemGadgetController : ChargedHotkeyItemBaseController
	{
		private CEnum<gamedataStatPoolType> _currentStatPoolType;
		private CName _c_grenadeKey;
		private CName _c_projectileLauncherKey;
		private CName _c_opticalCamoKey;
		private CName _c_cwMaskKey;
		private CArray<CName> _opticalCamoTags;
		private CEnum<gamePSMCombat> _currentCombatState;
		private CHandle<redCallbackObject> _combatStateCallback;
		private CEnum<gamedataNewPerkType> _c_grenadeFlashSalePerkType;

		[Ordinal(45)] 
		[RED("currentStatPoolType")] 
		public CEnum<gamedataStatPoolType> CurrentStatPoolType
		{
			get => GetProperty(ref _currentStatPoolType);
			set => SetProperty(ref _currentStatPoolType, value);
		}

		[Ordinal(46)] 
		[RED("c_grenadeKey")] 
		public CName C_grenadeKey
		{
			get => GetProperty(ref _c_grenadeKey);
			set => SetProperty(ref _c_grenadeKey, value);
		}

		[Ordinal(47)] 
		[RED("c_projectileLauncherKey")] 
		public CName C_projectileLauncherKey
		{
			get => GetProperty(ref _c_projectileLauncherKey);
			set => SetProperty(ref _c_projectileLauncherKey, value);
		}

		[Ordinal(48)] 
		[RED("c_opticalCamoKey")] 
		public CName C_opticalCamoKey
		{
			get => GetProperty(ref _c_opticalCamoKey);
			set => SetProperty(ref _c_opticalCamoKey, value);
		}

		[Ordinal(49)] 
		[RED("c_cwMaskKey")] 
		public CName C_cwMaskKey
		{
			get => GetProperty(ref _c_cwMaskKey);
			set => SetProperty(ref _c_cwMaskKey, value);
		}

		[Ordinal(50)] 
		[RED("opticalCamoTags")] 
		public CArray<CName> OpticalCamoTags
		{
			get => GetProperty(ref _opticalCamoTags);
			set => SetProperty(ref _opticalCamoTags, value);
		}

		[Ordinal(51)] 
		[RED("currentCombatState")] 
		public CEnum<gamePSMCombat> CurrentCombatState
		{
			get => GetProperty(ref _currentCombatState);
			set => SetProperty(ref _currentCombatState, value);
		}

		[Ordinal(52)] 
		[RED("combatStateCallback")] 
		public CHandle<redCallbackObject> CombatStateCallback
		{
			get => GetProperty(ref _combatStateCallback);
			set => SetProperty(ref _combatStateCallback, value);
		}

		[Ordinal(53)] 
		[RED("c_grenadeFlashSalePerkType")] 
		public CEnum<gamedataNewPerkType> C_grenadeFlashSalePerkType
		{
			get => GetProperty(ref _c_grenadeFlashSalePerkType);
			set => SetProperty(ref _c_grenadeFlashSalePerkType, value);
		}

		public ChargedHotkeyItemGadgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
