using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		private CHandle<redCallbackObject> _weaponBBID;
		private CEnum<gamePSMMeleeWeapon> _meleeWeaponState;
		private inkWidgetReference _targetColorChange;
		private CHandle<inkanimProxy> _holdAnim;
		private CHandle<inkanimProxy> _aimAnim;
		private CBool _isInHoldState;
		private CHandle<MeleeLeapAttackObjectTagger> _meleeLeapAttackObjectTagger;

		[Ordinal(29)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetProperty(ref _weaponBBID);
			set => SetProperty(ref _weaponBBID, value);
		}

		[Ordinal(30)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetProperty(ref _meleeWeaponState);
			set => SetProperty(ref _meleeWeaponState, value);
		}

		[Ordinal(31)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(32)] 
		[RED("holdAnim")] 
		public CHandle<inkanimProxy> HoldAnim
		{
			get => GetProperty(ref _holdAnim);
			set => SetProperty(ref _holdAnim, value);
		}

		[Ordinal(33)] 
		[RED("aimAnim")] 
		public CHandle<inkanimProxy> AimAnim
		{
			get => GetProperty(ref _aimAnim);
			set => SetProperty(ref _aimAnim, value);
		}

		[Ordinal(34)] 
		[RED("isInHoldState")] 
		public CBool IsInHoldState
		{
			get => GetProperty(ref _isInHoldState);
			set => SetProperty(ref _isInHoldState, value);
		}

		[Ordinal(35)] 
		[RED("meleeLeapAttackObjectTagger")] 
		public CHandle<MeleeLeapAttackObjectTagger> MeleeLeapAttackObjectTagger
		{
			get => GetProperty(ref _meleeLeapAttackObjectTagger);
			set => SetProperty(ref _meleeLeapAttackObjectTagger, value);
		}

		public CrosshairGameController_Mantis_Blade(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
