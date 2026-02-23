using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Rasetsu : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _hipFire;
		private inkWidgetReference _aimFire;
		private CName _showAdsAnimName;
		private CName _hideAdsAnimName;
		private CName _loopAdsAnimName;
		private CName _targetHitAnimationName;
		private CName _shootAnimationName;
		private wCHandle<CrosshairLogicController_RasetsuHipFire> _hipFireLogicController;
		private wCHandle<CrosshairLogicController_RasetsuAimFire> _aimFireLogicController;
		private wCHandle<gameIBlackboard> _weaponLocalBB;
		private wCHandle<gameIBlackboard> _uiGameDataBB;
		private CHandle<redCallbackObject> _onChargeChangeBBID;
		private CHandle<redCallbackObject> _onChargeTriggerModeBBID;
		private CHandle<redCallbackObject> _weaponDataTargetHitBBID;
		private CHandle<redCallbackObject> _weaponDataShootBBID;
		private CHandle<inkanimProxy> _targetHitAnimation;
		private CHandle<inkanimProxy> _shootAnimation;
		private CHandle<inkanimProxy> _visibilityAnimProxy;
		private CHandle<inkanimProxy> _rootAnimProxy;
		private CBool _isRootVisible;

		[Ordinal(29)] 
		[RED("hipFire")] 
		public inkWidgetReference HipFire
		{
			get => GetProperty(ref _hipFire);
			set => SetProperty(ref _hipFire, value);
		}

		[Ordinal(30)] 
		[RED("aimFire")] 
		public inkWidgetReference AimFire
		{
			get => GetProperty(ref _aimFire);
			set => SetProperty(ref _aimFire, value);
		}

		[Ordinal(31)] 
		[RED("showAdsAnimName")] 
		public CName ShowAdsAnimName
		{
			get => GetProperty(ref _showAdsAnimName);
			set => SetProperty(ref _showAdsAnimName, value);
		}

		[Ordinal(32)] 
		[RED("hideAdsAnimName")] 
		public CName HideAdsAnimName
		{
			get => GetProperty(ref _hideAdsAnimName);
			set => SetProperty(ref _hideAdsAnimName, value);
		}

		[Ordinal(33)] 
		[RED("loopAdsAnimName")] 
		public CName LoopAdsAnimName
		{
			get => GetProperty(ref _loopAdsAnimName);
			set => SetProperty(ref _loopAdsAnimName, value);
		}

		[Ordinal(34)] 
		[RED("targetHitAnimationName")] 
		public CName TargetHitAnimationName
		{
			get => GetProperty(ref _targetHitAnimationName);
			set => SetProperty(ref _targetHitAnimationName, value);
		}

		[Ordinal(35)] 
		[RED("shootAnimationName")] 
		public CName ShootAnimationName
		{
			get => GetProperty(ref _shootAnimationName);
			set => SetProperty(ref _shootAnimationName, value);
		}

		[Ordinal(36)] 
		[RED("hipFireLogicController")] 
		public wCHandle<CrosshairLogicController_RasetsuHipFire> HipFireLogicController
		{
			get => GetProperty(ref _hipFireLogicController);
			set => SetProperty(ref _hipFireLogicController, value);
		}

		[Ordinal(37)] 
		[RED("aimFireLogicController")] 
		public wCHandle<CrosshairLogicController_RasetsuAimFire> AimFireLogicController
		{
			get => GetProperty(ref _aimFireLogicController);
			set => SetProperty(ref _aimFireLogicController, value);
		}

		[Ordinal(38)] 
		[RED("weaponLocalBB")] 
		public wCHandle<gameIBlackboard> WeaponLocalBB
		{
			get => GetProperty(ref _weaponLocalBB);
			set => SetProperty(ref _weaponLocalBB, value);
		}

		[Ordinal(39)] 
		[RED("uiGameDataBB")] 
		public wCHandle<gameIBlackboard> UiGameDataBB
		{
			get => GetProperty(ref _uiGameDataBB);
			set => SetProperty(ref _uiGameDataBB, value);
		}

		[Ordinal(40)] 
		[RED("onChargeChangeBBID")] 
		public CHandle<redCallbackObject> OnChargeChangeBBID
		{
			get => GetProperty(ref _onChargeChangeBBID);
			set => SetProperty(ref _onChargeChangeBBID, value);
		}

		[Ordinal(41)] 
		[RED("onChargeTriggerModeBBID")] 
		public CHandle<redCallbackObject> OnChargeTriggerModeBBID
		{
			get => GetProperty(ref _onChargeTriggerModeBBID);
			set => SetProperty(ref _onChargeTriggerModeBBID, value);
		}

		[Ordinal(42)] 
		[RED("weaponDataTargetHitBBID")] 
		public CHandle<redCallbackObject> WeaponDataTargetHitBBID
		{
			get => GetProperty(ref _weaponDataTargetHitBBID);
			set => SetProperty(ref _weaponDataTargetHitBBID, value);
		}

		[Ordinal(43)] 
		[RED("weaponDataShootBBID")] 
		public CHandle<redCallbackObject> WeaponDataShootBBID
		{
			get => GetProperty(ref _weaponDataShootBBID);
			set => SetProperty(ref _weaponDataShootBBID, value);
		}

		[Ordinal(44)] 
		[RED("targetHitAnimation")] 
		public CHandle<inkanimProxy> TargetHitAnimation
		{
			get => GetProperty(ref _targetHitAnimation);
			set => SetProperty(ref _targetHitAnimation, value);
		}

		[Ordinal(45)] 
		[RED("shootAnimation")] 
		public CHandle<inkanimProxy> ShootAnimation
		{
			get => GetProperty(ref _shootAnimation);
			set => SetProperty(ref _shootAnimation, value);
		}

		[Ordinal(46)] 
		[RED("visibilityAnimProxy")] 
		public CHandle<inkanimProxy> VisibilityAnimProxy
		{
			get => GetProperty(ref _visibilityAnimProxy);
			set => SetProperty(ref _visibilityAnimProxy, value);
		}

		[Ordinal(47)] 
		[RED("rootAnimProxy")] 
		public CHandle<inkanimProxy> RootAnimProxy
		{
			get => GetProperty(ref _rootAnimProxy);
			set => SetProperty(ref _rootAnimProxy, value);
		}

		[Ordinal(48)] 
		[RED("isRootVisible")] 
		public CBool IsRootVisible
		{
			get => GetProperty(ref _isRootVisible);
			set => SetProperty(ref _isRootVisible, value);
		}

		public CrosshairGameController_Rasetsu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
