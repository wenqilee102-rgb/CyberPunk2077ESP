using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DriverCombatEvents : VehicleEventsTransition
	{
		private wCHandle<gameObject> _executionOwner;
		private wCHandle<gameObject> _owner;
		private CBool _newTargetComponent;
		private wCHandle<entIPlacedComponent> _targetComponent;
		private CBool _vehicleInTPP;
		private CBool _driverCombatInTPP;
		private CHandle<redCallbackObject> _targetComponentCallback;
		private CHandle<redCallbackObject> _vehicleInTPPCallback;
		private CHandle<redCallbackObject> _driverCombatInTPPCallback;
		private wCHandle<gameObject> _curTarget;
		private CBool _curTargetHostile;
		private CHandle<FocusForcedHighlightData> _highlightData;
		private CBool _requirePerspectiveUpdate;
		private CBool _aimPressed;
		private CFloat _vehicleManeuversTime;
		private CFloat _exitReleasedTime;

		[Ordinal(4)] 
		[RED("executionOwner")] 
		public wCHandle<gameObject> ExecutionOwner
		{
			get => GetProperty(ref _executionOwner);
			set => SetProperty(ref _executionOwner, value);
		}

		[Ordinal(5)] 
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get => GetProperty(ref _owner);
			set => SetProperty(ref _owner, value);
		}

		[Ordinal(6)] 
		[RED("newTargetComponent")] 
		public CBool NewTargetComponent
		{
			get => GetProperty(ref _newTargetComponent);
			set => SetProperty(ref _newTargetComponent, value);
		}

		[Ordinal(7)] 
		[RED("targetComponent")] 
		public wCHandle<entIPlacedComponent> TargetComponent
		{
			get => GetProperty(ref _targetComponent);
			set => SetProperty(ref _targetComponent, value);
		}

		[Ordinal(8)] 
		[RED("vehicleInTPP")] 
		public CBool VehicleInTPP
		{
			get => GetProperty(ref _vehicleInTPP);
			set => SetProperty(ref _vehicleInTPP, value);
		}

		[Ordinal(9)] 
		[RED("driverCombatInTPP")] 
		public CBool DriverCombatInTPP
		{
			get => GetProperty(ref _driverCombatInTPP);
			set => SetProperty(ref _driverCombatInTPP, value);
		}

		[Ordinal(10)] 
		[RED("targetComponentCallback")] 
		public CHandle<redCallbackObject> TargetComponentCallback
		{
			get => GetProperty(ref _targetComponentCallback);
			set => SetProperty(ref _targetComponentCallback, value);
		}

		[Ordinal(11)] 
		[RED("vehicleInTPPCallback")] 
		public CHandle<redCallbackObject> VehicleInTPPCallback
		{
			get => GetProperty(ref _vehicleInTPPCallback);
			set => SetProperty(ref _vehicleInTPPCallback, value);
		}

		[Ordinal(12)] 
		[RED("driverCombatInTPPCallback")] 
		public CHandle<redCallbackObject> DriverCombatInTPPCallback
		{
			get => GetProperty(ref _driverCombatInTPPCallback);
			set => SetProperty(ref _driverCombatInTPPCallback, value);
		}

		[Ordinal(13)] 
		[RED("curTarget")] 
		public wCHandle<gameObject> CurTarget
		{
			get => GetProperty(ref _curTarget);
			set => SetProperty(ref _curTarget, value);
		}

		[Ordinal(14)] 
		[RED("curTargetHostile")] 
		public CBool CurTargetHostile
		{
			get => GetProperty(ref _curTargetHostile);
			set => SetProperty(ref _curTargetHostile, value);
		}

		[Ordinal(15)] 
		[RED("highlightData")] 
		public CHandle<FocusForcedHighlightData> HighlightData
		{
			get => GetProperty(ref _highlightData);
			set => SetProperty(ref _highlightData, value);
		}

		[Ordinal(16)] 
		[RED("requirePerspectiveUpdate")] 
		public CBool RequirePerspectiveUpdate
		{
			get => GetProperty(ref _requirePerspectiveUpdate);
			set => SetProperty(ref _requirePerspectiveUpdate, value);
		}

		[Ordinal(17)] 
		[RED("aimPressed")] 
		public CBool AimPressed
		{
			get => GetProperty(ref _aimPressed);
			set => SetProperty(ref _aimPressed, value);
		}

		[Ordinal(18)] 
		[RED("vehicleManeuversTime")] 
		public CFloat VehicleManeuversTime
		{
			get => GetProperty(ref _vehicleManeuversTime);
			set => SetProperty(ref _vehicleManeuversTime, value);
		}

		[Ordinal(19)] 
		[RED("exitReleasedTime")] 
		public CFloat ExitReleasedTime
		{
			get => GetProperty(ref _exitReleasedTime);
			set => SetProperty(ref _exitReleasedTime, value);
		}

		public DriverCombatEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
