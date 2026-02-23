using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDriverCombatMountedPowerWeaponCrosshairGameController : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _reticleLeft;
		private inkWidgetReference _reticleRight;
		private CFloat _reticleStartingRange;
		private CFloat _defaultOpacity;
		private CFloat _reducedOpacity;
		private CArray<wCHandle<gameweaponObject>> _weaponList;
		private CBool _isTPP;
		private wCHandle<gameIBlackboard> _uiActiveVehicleDataBlackboard;
		private CHandle<redCallbackObject> _psmCombatStateChangedCallback;
		private CHandle<redCallbackObject> _uiActiveVehicleCameraChangedCallback;

		[Ordinal(29)] 
		[RED("reticleLeft")] 
		public inkWidgetReference ReticleLeft
		{
			get => GetProperty(ref _reticleLeft);
			set => SetProperty(ref _reticleLeft, value);
		}

		[Ordinal(30)] 
		[RED("reticleRight")] 
		public inkWidgetReference ReticleRight
		{
			get => GetProperty(ref _reticleRight);
			set => SetProperty(ref _reticleRight, value);
		}

		[Ordinal(31)] 
		[RED("reticleStartingRange")] 
		public CFloat ReticleStartingRange
		{
			get => GetProperty(ref _reticleStartingRange);
			set => SetProperty(ref _reticleStartingRange, value);
		}

		[Ordinal(32)] 
		[RED("defaultOpacity")] 
		public CFloat DefaultOpacity
		{
			get => GetProperty(ref _defaultOpacity);
			set => SetProperty(ref _defaultOpacity, value);
		}

		[Ordinal(33)] 
		[RED("reducedOpacity")] 
		public CFloat ReducedOpacity
		{
			get => GetProperty(ref _reducedOpacity);
			set => SetProperty(ref _reducedOpacity, value);
		}

		[Ordinal(34)] 
		[RED("weaponList")] 
		public CArray<wCHandle<gameweaponObject>> WeaponList
		{
			get => GetProperty(ref _weaponList);
			set => SetProperty(ref _weaponList, value);
		}

		[Ordinal(35)] 
		[RED("isTPP")] 
		public CBool IsTPP
		{
			get => GetProperty(ref _isTPP);
			set => SetProperty(ref _isTPP, value);
		}

		[Ordinal(36)] 
		[RED("uiActiveVehicleDataBlackboard")] 
		public wCHandle<gameIBlackboard> UiActiveVehicleDataBlackboard
		{
			get => GetProperty(ref _uiActiveVehicleDataBlackboard);
			set => SetProperty(ref _uiActiveVehicleDataBlackboard, value);
		}

		[Ordinal(37)] 
		[RED("psmCombatStateChangedCallback")] 
		public CHandle<redCallbackObject> PsmCombatStateChangedCallback
		{
			get => GetProperty(ref _psmCombatStateChangedCallback);
			set => SetProperty(ref _psmCombatStateChangedCallback, value);
		}

		[Ordinal(38)] 
		[RED("uiActiveVehicleCameraChangedCallback")] 
		public CHandle<redCallbackObject> UiActiveVehicleCameraChangedCallback
		{
			get => GetProperty(ref _uiActiveVehicleCameraChangedCallback);
			set => SetProperty(ref _uiActiveVehicleCameraChangedCallback, value);
		}

		public gameuiDriverCombatMountedPowerWeaponCrosshairGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
