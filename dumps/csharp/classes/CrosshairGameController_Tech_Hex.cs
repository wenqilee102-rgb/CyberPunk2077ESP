using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Tech_Hex : BaseTechCrosshairController
	{
		private wCHandle<inkImageWidget> _leftBracket;
		private wCHandle<inkImageWidget> _rightBracket;
		private wCHandle<inkWidget> _hori;
		private wCHandle<inkWidget> _chargeBar;
		private wCHandle<inkWidget> _chargeBoth;
		private wCHandle<inkRectangleWidget> _chargeLeftBar;
		private wCHandle<inkRectangleWidget> _chargeRightBar;
		private wCHandle<inkImageWidget> _centerPart;
		private wCHandle<inkWidget> _fluffCanvas;
		private CHandle<inkanimProxy> _chargeAnimationProxy;
		private Vector2 _bufferedSpread;
		private wCHandle<gameIBlackboard> _weaponlocalBB;
		private CHandle<redCallbackObject> _bbcharge;
		private CHandle<redCallbackObject> _bbcurrentFireMode;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private CHandle<redCallbackObject> _bbNPCStatsInfo;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;
		private CFloat _charge;
		private CFloat _spread;

		[Ordinal(35)] 
		[RED("leftBracket")] 
		public wCHandle<inkImageWidget> LeftBracket
		{
			get => GetProperty(ref _leftBracket);
			set => SetProperty(ref _leftBracket, value);
		}

		[Ordinal(36)] 
		[RED("rightBracket")] 
		public wCHandle<inkImageWidget> RightBracket
		{
			get => GetProperty(ref _rightBracket);
			set => SetProperty(ref _rightBracket, value);
		}

		[Ordinal(37)] 
		[RED("hori")] 
		public wCHandle<inkWidget> Hori
		{
			get => GetProperty(ref _hori);
			set => SetProperty(ref _hori, value);
		}

		[Ordinal(38)] 
		[RED("chargeBar")] 
		public wCHandle<inkWidget> ChargeBar
		{
			get => GetProperty(ref _chargeBar);
			set => SetProperty(ref _chargeBar, value);
		}

		[Ordinal(39)] 
		[RED("chargeBoth")] 
		public wCHandle<inkWidget> ChargeBoth
		{
			get => GetProperty(ref _chargeBoth);
			set => SetProperty(ref _chargeBoth, value);
		}

		[Ordinal(40)] 
		[RED("chargeLeftBar")] 
		public wCHandle<inkRectangleWidget> ChargeLeftBar
		{
			get => GetProperty(ref _chargeLeftBar);
			set => SetProperty(ref _chargeLeftBar, value);
		}

		[Ordinal(41)] 
		[RED("chargeRightBar")] 
		public wCHandle<inkRectangleWidget> ChargeRightBar
		{
			get => GetProperty(ref _chargeRightBar);
			set => SetProperty(ref _chargeRightBar, value);
		}

		[Ordinal(42)] 
		[RED("centerPart")] 
		public wCHandle<inkImageWidget> CenterPart
		{
			get => GetProperty(ref _centerPart);
			set => SetProperty(ref _centerPart, value);
		}

		[Ordinal(43)] 
		[RED("fluffCanvas")] 
		public wCHandle<inkWidget> FluffCanvas
		{
			get => GetProperty(ref _fluffCanvas);
			set => SetProperty(ref _fluffCanvas, value);
		}

		[Ordinal(44)] 
		[RED("chargeAnimationProxy")] 
		public CHandle<inkanimProxy> ChargeAnimationProxy
		{
			get => GetProperty(ref _chargeAnimationProxy);
			set => SetProperty(ref _chargeAnimationProxy, value);
		}

		[Ordinal(45)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(46)] 
		[RED("weaponlocalBB")] 
		public wCHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(47)] 
		[RED("bbcharge")] 
		public CHandle<redCallbackObject> Bbcharge
		{
			get => GetProperty(ref _bbcharge);
			set => SetProperty(ref _bbcharge, value);
		}

		[Ordinal(48)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetProperty(ref _bbcurrentFireMode);
			set => SetProperty(ref _bbcurrentFireMode, value);
		}

		[Ordinal(49)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetProperty(ref _currentFireMode);
			set => SetProperty(ref _currentFireMode, value);
		}

		[Ordinal(50)] 
		[RED("bbNPCStatsInfo")] 
		public CHandle<redCallbackObject> BbNPCStatsInfo
		{
			get => GetProperty(ref _bbNPCStatsInfo);
			set => SetProperty(ref _bbNPCStatsInfo, value);
		}

		[Ordinal(51)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetProperty(ref _horizontalMinSpread);
			set => SetProperty(ref _horizontalMinSpread, value);
		}

		[Ordinal(52)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetProperty(ref _verticalMinSpread);
			set => SetProperty(ref _verticalMinSpread, value);
		}

		[Ordinal(53)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		[Ordinal(54)] 
		[RED("charge")] 
		public CFloat Charge
		{
			get => GetProperty(ref _charge);
			set => SetProperty(ref _charge, value);
		}

		[Ordinal(55)] 
		[RED("spread")] 
		public CFloat Spread
		{
			get => GetProperty(ref _spread);
			set => SetProperty(ref _spread, value);
		}

		public CrosshairGameController_Tech_Hex(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
