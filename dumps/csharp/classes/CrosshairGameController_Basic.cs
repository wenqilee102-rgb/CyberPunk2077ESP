using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Basic : gameuiCrosshairBaseGameController
	{
		private inkImageWidgetReference _leftPart;
		private inkImageWidgetReference _rightPart;
		private inkImageWidgetReference _upPart;
		private inkImageWidgetReference _downPart;
		private inkImageWidgetReference _centerPart;
		private Vector2 _bufferedSpread;
		private CEnum<gamedataTriggerMode> _currentFireMode;
		private wCHandle<gameIBlackboard> _weaponlocalBB;
		private CHandle<redCallbackObject> _bbcurrentFireMode;
		private CUInt32 _ricochetModeActive;
		private CUInt32 _ricochetChance;
		private CFloat _horizontalMinSpread;
		private CFloat _verticalMinSpread;
		private CFloat _gameplaySpreadMultiplier;

		[Ordinal(29)] 
		[RED("leftPart")] 
		public inkImageWidgetReference LeftPart
		{
			get => GetProperty(ref _leftPart);
			set => SetProperty(ref _leftPart, value);
		}

		[Ordinal(30)] 
		[RED("rightPart")] 
		public inkImageWidgetReference RightPart
		{
			get => GetProperty(ref _rightPart);
			set => SetProperty(ref _rightPart, value);
		}

		[Ordinal(31)] 
		[RED("upPart")] 
		public inkImageWidgetReference UpPart
		{
			get => GetProperty(ref _upPart);
			set => SetProperty(ref _upPart, value);
		}

		[Ordinal(32)] 
		[RED("downPart")] 
		public inkImageWidgetReference DownPart
		{
			get => GetProperty(ref _downPart);
			set => SetProperty(ref _downPart, value);
		}

		[Ordinal(33)] 
		[RED("centerPart")] 
		public inkImageWidgetReference CenterPart
		{
			get => GetProperty(ref _centerPart);
			set => SetProperty(ref _centerPart, value);
		}

		[Ordinal(34)] 
		[RED("bufferedSpread")] 
		public Vector2 BufferedSpread
		{
			get => GetProperty(ref _bufferedSpread);
			set => SetProperty(ref _bufferedSpread, value);
		}

		[Ordinal(35)] 
		[RED("currentFireMode")] 
		public CEnum<gamedataTriggerMode> CurrentFireMode
		{
			get => GetProperty(ref _currentFireMode);
			set => SetProperty(ref _currentFireMode, value);
		}

		[Ordinal(36)] 
		[RED("weaponlocalBB")] 
		public wCHandle<gameIBlackboard> WeaponlocalBB
		{
			get => GetProperty(ref _weaponlocalBB);
			set => SetProperty(ref _weaponlocalBB, value);
		}

		[Ordinal(37)] 
		[RED("bbcurrentFireMode")] 
		public CHandle<redCallbackObject> BbcurrentFireMode
		{
			get => GetProperty(ref _bbcurrentFireMode);
			set => SetProperty(ref _bbcurrentFireMode, value);
		}

		[Ordinal(38)] 
		[RED("ricochetModeActive")] 
		public CUInt32 RicochetModeActive
		{
			get => GetProperty(ref _ricochetModeActive);
			set => SetProperty(ref _ricochetModeActive, value);
		}

		[Ordinal(39)] 
		[RED("RicochetChance")] 
		public CUInt32 RicochetChance
		{
			get => GetProperty(ref _ricochetChance);
			set => SetProperty(ref _ricochetChance, value);
		}

		[Ordinal(40)] 
		[RED("horizontalMinSpread")] 
		public CFloat HorizontalMinSpread
		{
			get => GetProperty(ref _horizontalMinSpread);
			set => SetProperty(ref _horizontalMinSpread, value);
		}

		[Ordinal(41)] 
		[RED("verticalMinSpread")] 
		public CFloat VerticalMinSpread
		{
			get => GetProperty(ref _verticalMinSpread);
			set => SetProperty(ref _verticalMinSpread, value);
		}

		[Ordinal(42)] 
		[RED("gameplaySpreadMultiplier")] 
		public CFloat GameplaySpreadMultiplier
		{
			get => GetProperty(ref _gameplaySpreadMultiplier);
			set => SetProperty(ref _gameplaySpreadMultiplier, value);
		}

		public CrosshairGameController_Basic(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
