using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		private CHandle<redCallbackObject> _weaponBBID;
		private CHandle<inkanimProxy> _animationProxy;
		private inkCanvasWidgetReference _cori_S;
		private inkCanvasWidgetReference _cori_M;
		private CFloat _rightStickX;
		private CFloat _rightStickY;
		private CEnum<gamePSMLeftHandCyberware> _currentState;

		[Ordinal(29)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetProperty(ref _weaponBBID);
			set => SetProperty(ref _weaponBBID, value);
		}

		[Ordinal(30)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetProperty(ref _animationProxy);
			set => SetProperty(ref _animationProxy, value);
		}

		[Ordinal(31)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get => GetProperty(ref _cori_S);
			set => SetProperty(ref _cori_S, value);
		}

		[Ordinal(32)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get => GetProperty(ref _cori_M);
			set => SetProperty(ref _cori_M, value);
		}

		[Ordinal(33)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get => GetProperty(ref _rightStickX);
			set => SetProperty(ref _rightStickX, value);
		}

		[Ordinal(34)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get => GetProperty(ref _rightStickY);
			set => SetProperty(ref _rightStickY, value);
		}

		[Ordinal(35)] 
		[RED("currentState")] 
		public CEnum<gamePSMLeftHandCyberware> CurrentState
		{
			get => GetProperty(ref _currentState);
			set => SetProperty(ref _currentState, value);
		}

		public CrosshairGameController_Launcher(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
