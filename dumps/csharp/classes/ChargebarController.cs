using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ChargebarController : inkWidgetLogicController
	{
		private inkWidgetReference _foreground;
		private inkWidgetReference _midground;
		private inkWidgetReference _background;
		private CName _maxChargeAnimationName;
		private CName _maxChargeResetAnimationName;
		private CName _staticChargeAnimationName;
		private CName _chargedShootAnimationName;
		private CBool _radialWipe;
		private CBool _verticalChargeBar;
		private CBool _playStaticChargeAnimationInstead;
		private wCHandle<gameObject> _player;
		private CHandle<gameStatsSystem> _statsSystem;
		private CBool _canFullyCharge;
		private CBool _canOvercharge;
		private CHandle<ChargebarStatsListener> _listenerFullCharge;
		private CHandle<ChargebarStatsListener> _listenerOvercharge;
		private CHandle<inkanimProxy> _animationMaxCharge;
		private CHandle<inkanimProxy> _animationStaticCharge;
		private CHandle<inkanimProxy> _animationChargedShoot;
		private CBool _animationStaticChargePlayed;
		private CBool _isCharged;

		[Ordinal(1)] 
		[RED("foreground")] 
		public inkWidgetReference Foreground
		{
			get => GetProperty(ref _foreground);
			set => SetProperty(ref _foreground, value);
		}

		[Ordinal(2)] 
		[RED("midground")] 
		public inkWidgetReference Midground
		{
			get => GetProperty(ref _midground);
			set => SetProperty(ref _midground, value);
		}

		[Ordinal(3)] 
		[RED("background")] 
		public inkWidgetReference Background
		{
			get => GetProperty(ref _background);
			set => SetProperty(ref _background, value);
		}

		[Ordinal(4)] 
		[RED("maxChargeAnimationName")] 
		public CName MaxChargeAnimationName
		{
			get => GetProperty(ref _maxChargeAnimationName);
			set => SetProperty(ref _maxChargeAnimationName, value);
		}

		[Ordinal(5)] 
		[RED("maxChargeResetAnimationName")] 
		public CName MaxChargeResetAnimationName
		{
			get => GetProperty(ref _maxChargeResetAnimationName);
			set => SetProperty(ref _maxChargeResetAnimationName, value);
		}

		[Ordinal(6)] 
		[RED("staticChargeAnimationName")] 
		public CName StaticChargeAnimationName
		{
			get => GetProperty(ref _staticChargeAnimationName);
			set => SetProperty(ref _staticChargeAnimationName, value);
		}

		[Ordinal(7)] 
		[RED("chargedShootAnimationName")] 
		public CName ChargedShootAnimationName
		{
			get => GetProperty(ref _chargedShootAnimationName);
			set => SetProperty(ref _chargedShootAnimationName, value);
		}

		[Ordinal(8)] 
		[RED("radialWipe")] 
		public CBool RadialWipe
		{
			get => GetProperty(ref _radialWipe);
			set => SetProperty(ref _radialWipe, value);
		}

		[Ordinal(9)] 
		[RED("verticalChargeBar")] 
		public CBool VerticalChargeBar
		{
			get => GetProperty(ref _verticalChargeBar);
			set => SetProperty(ref _verticalChargeBar, value);
		}

		[Ordinal(10)] 
		[RED("playStaticChargeAnimationInstead")] 
		public CBool PlayStaticChargeAnimationInstead
		{
			get => GetProperty(ref _playStaticChargeAnimationInstead);
			set => SetProperty(ref _playStaticChargeAnimationInstead, value);
		}

		[Ordinal(11)] 
		[RED("player")] 
		public wCHandle<gameObject> Player
		{
			get => GetProperty(ref _player);
			set => SetProperty(ref _player, value);
		}

		[Ordinal(12)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetProperty(ref _statsSystem);
			set => SetProperty(ref _statsSystem, value);
		}

		[Ordinal(13)] 
		[RED("canFullyCharge")] 
		public CBool CanFullyCharge
		{
			get => GetProperty(ref _canFullyCharge);
			set => SetProperty(ref _canFullyCharge, value);
		}

		[Ordinal(14)] 
		[RED("canOvercharge")] 
		public CBool CanOvercharge
		{
			get => GetProperty(ref _canOvercharge);
			set => SetProperty(ref _canOvercharge, value);
		}

		[Ordinal(15)] 
		[RED("listenerFullCharge")] 
		public CHandle<ChargebarStatsListener> ListenerFullCharge
		{
			get => GetProperty(ref _listenerFullCharge);
			set => SetProperty(ref _listenerFullCharge, value);
		}

		[Ordinal(16)] 
		[RED("listenerOvercharge")] 
		public CHandle<ChargebarStatsListener> ListenerOvercharge
		{
			get => GetProperty(ref _listenerOvercharge);
			set => SetProperty(ref _listenerOvercharge, value);
		}

		[Ordinal(17)] 
		[RED("animationMaxCharge")] 
		public CHandle<inkanimProxy> AnimationMaxCharge
		{
			get => GetProperty(ref _animationMaxCharge);
			set => SetProperty(ref _animationMaxCharge, value);
		}

		[Ordinal(18)] 
		[RED("animationStaticCharge")] 
		public CHandle<inkanimProxy> AnimationStaticCharge
		{
			get => GetProperty(ref _animationStaticCharge);
			set => SetProperty(ref _animationStaticCharge, value);
		}

		[Ordinal(19)] 
		[RED("animationChargedShoot")] 
		public CHandle<inkanimProxy> AnimationChargedShoot
		{
			get => GetProperty(ref _animationChargedShoot);
			set => SetProperty(ref _animationChargedShoot, value);
		}

		[Ordinal(20)] 
		[RED("animationStaticChargePlayed")] 
		public CBool AnimationStaticChargePlayed
		{
			get => GetProperty(ref _animationStaticChargePlayed);
			set => SetProperty(ref _animationStaticChargePlayed, value);
		}

		[Ordinal(21)] 
		[RED("isCharged")] 
		public CBool IsCharged
		{
			get => GetProperty(ref _isCharged);
			set => SetProperty(ref _isCharged, value);
		}

		public ChargebarController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
