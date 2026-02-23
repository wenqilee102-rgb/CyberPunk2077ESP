using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiDriverCombatMountedMissileLauncherCrosshairGameController : gameuiCrosshairBaseGameController
	{
		private inkWidgetReference _lockingAnimationWidget;
		private CHandle<inkanimProxy> _lockingAnimationProxy;
		private CHandle<redCallbackObject> _psmTrackedTargetChangedCallback;
		private wCHandle<entIPlacedComponent> _currentTarget;

		[Ordinal(29)] 
		[RED("lockingAnimationWidget")] 
		public inkWidgetReference LockingAnimationWidget
		{
			get => GetProperty(ref _lockingAnimationWidget);
			set => SetProperty(ref _lockingAnimationWidget, value);
		}

		[Ordinal(30)] 
		[RED("lockingAnimationProxy")] 
		public CHandle<inkanimProxy> LockingAnimationProxy
		{
			get => GetProperty(ref _lockingAnimationProxy);
			set => SetProperty(ref _lockingAnimationProxy, value);
		}

		[Ordinal(31)] 
		[RED("psmTrackedTargetChangedCallback")] 
		public CHandle<redCallbackObject> PsmTrackedTargetChangedCallback
		{
			get => GetProperty(ref _psmTrackedTargetChangedCallback);
			set => SetProperty(ref _psmTrackedTargetChangedCallback, value);
		}

		[Ordinal(32)] 
		[RED("currentTarget")] 
		public wCHandle<entIPlacedComponent> CurrentTarget
		{
			get => GetProperty(ref _currentTarget);
			set => SetProperty(ref _currentTarget, value);
		}

		public gameuiDriverCombatMountedMissileLauncherCrosshairGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
