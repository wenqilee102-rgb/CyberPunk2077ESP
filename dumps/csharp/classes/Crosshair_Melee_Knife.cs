using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class Crosshair_Melee_Knife : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _targetColorChange;
		private inkWidgetReference _leftPart;
		private inkWidgetReference _rightPart;
		private inkWidgetReference _topPart;
		private inkWidgetReference _botPart;
		private wCHandle<inkCanvasWidget> _chargeBar;
		private wCHandle<inkRectangleWidget> _chargeBarFG;
		private CHandle<ThrowingKnifeResourcePoolListener> _throwingKnifeResourcePoolListener;
		private entEntityID _weaponID;
		private CHandle<redCallbackObject> _weaponBBID;
		private CEnum<gamePSMMeleeWeapon> _meleeWeaponState;
		private CHandle<inkanimProxy> _animProxy;
		private inkanimPlaybackOptions _animOptions;
		private CBool _isCrosshairAnimationOpen;
		private wCHandle<inkImageWidget> _preloaderThinL;
		private wCHandle<inkImageWidget> _preloaderThinR;
		private wCHandle<inkImageWidget> _preloaderThickL;
		private wCHandle<inkImageWidget> _preloaderThickR;
		private wCHandle<inkCanvasWidget> _preloader;

		[Ordinal(29)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetProperty(ref _targetColorChange);
			set => SetProperty(ref _targetColorChange, value);
		}

		[Ordinal(30)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(31)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(32)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetProperty(ref _topPart);
			set => SetProperty(ref _topPart, value);
		}

		[Ordinal(33)] 
		[RED("botPart")] 
		public inkWidgetReference BotPart
		{
			get => GetProperty(ref _botPart);
			set => SetProperty(ref _botPart, value);
		}

		[Ordinal(34)] 
		[RED("chargeBar")] 
		public wCHandle<inkCanvasWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(35)] 
		[RED("chargeBarFG")] 
		public wCHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetProperty(ref _chargeBarFG);
			set => SetProperty(ref _chargeBarFG, value);
		}

		[Ordinal(36)] 
		[RED("throwingKnifeResourcePoolListener")] 
		public CHandle<ThrowingKnifeResourcePoolListener> ThrowingKnifeResourcePoolListener
		{
			get => GetProperty(ref _throwingKnifeResourcePoolListener);
			set => SetProperty(ref _throwingKnifeResourcePoolListener, value);
		}

		[Ordinal(37)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetProperty(ref _weaponID);
			set => SetProperty(ref _weaponID, value);
		}

		[Ordinal(38)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetProperty(ref _weaponBBID);
			set => SetProperty(ref _weaponBBID, value);
		}

		[Ordinal(39)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetProperty(ref _meleeWeaponState);
			set => SetProperty(ref _meleeWeaponState, value);
		}

		[Ordinal(40)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(41)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetProperty(ref _animOptions);
			set => SetProperty(ref _animOptions, value);
		}

		[Ordinal(42)] 
		[RED("isCrosshairAnimationOpen")] 
		public CBool IsCrosshairAnimationOpen
		{
			get => GetProperty(ref _isCrosshairAnimationOpen);
			set => SetProperty(ref _isCrosshairAnimationOpen, value);
		}

		[Ordinal(43)] 
		[RED("preloaderThinL")] 
		public wCHandle<inkImageWidget> PreloaderThinL
		{
			get => GetProperty(ref _preloaderThinL);
			set => SetProperty(ref _preloaderThinL, value);
		}

		[Ordinal(44)] 
		[RED("preloaderThinR")] 
		public wCHandle<inkImageWidget> PreloaderThinR
		{
			get => GetProperty(ref _preloaderThinR);
			set => SetProperty(ref _preloaderThinR, value);
		}

		[Ordinal(45)] 
		[RED("preloaderThickL")] 
		public wCHandle<inkImageWidget> PreloaderThickL
		{
			get => GetProperty(ref _preloaderThickL);
			set => SetProperty(ref _preloaderThickL, value);
		}

		[Ordinal(46)] 
		[RED("preloaderThickR")] 
		public wCHandle<inkImageWidget> PreloaderThickR
		{
			get => GetProperty(ref _preloaderThickR);
			set => SetProperty(ref _preloaderThickR, value);
		}

		[Ordinal(47)] 
		[RED("preloader")] 
		public wCHandle<inkCanvasWidget> Preloader
		{
			get => GetProperty(ref _preloader);
			set => SetProperty(ref _preloader, value);
		}

		public Crosshair_Melee_Knife(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
