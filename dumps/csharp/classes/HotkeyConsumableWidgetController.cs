using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HotkeyConsumableWidgetController : gameuiNewPhoneRelatedHUDGameController
	{
		private inkCompoundWidgetReference _radioSlot;
		private inkCompoundWidgetReference _vehicleCustomizationSlot;
		private inkCompoundWidgetReference _autodriveSlot;
		private inkCompoundWidgetReference _container;
		private inkWidgetLibraryReference _dpadHintLibraryPath;
		private inkWidgetLibraryReference _autodriveLibraryPath;
		private CBool _isInDriverCombat;
		private CBool _isPoliceVehicle;
		private CBool _isRadioBlocked;
		private CBool _isInVehicleScene;
		private CBool _isQuestBlocked;
		private CUInt32 _carHudListenerId;
		private CHandle<HotkeyRadioStatusListener> _statusListener;
		private CHandle<redCallbackObject> _playerEnteredVehicleListener;
		private CHandle<redCallbackObject> _autodriveToggledListener;
		private CHandle<inkanimProxy> _containerAnimProxy;
		private CBool _containerVisibility;

		[Ordinal(15)] 
		[RED("radioSlot")] 
		public inkCompoundWidgetReference RadioSlot
		{
			get => GetProperty(ref _radioSlot);
			set => SetProperty(ref _radioSlot, value);
		}

		[Ordinal(16)] 
		[RED("vehicleCustomizationSlot")] 
		public inkCompoundWidgetReference VehicleCustomizationSlot
		{
			get => GetProperty(ref _vehicleCustomizationSlot);
			set => SetProperty(ref _vehicleCustomizationSlot, value);
		}

		[Ordinal(17)] 
		[RED("autodriveSlot")] 
		public inkCompoundWidgetReference AutodriveSlot
		{
			get => GetProperty(ref _autodriveSlot);
			set => SetProperty(ref _autodriveSlot, value);
		}

		[Ordinal(18)] 
		[RED("container")] 
		public inkCompoundWidgetReference Container
		{
			get => GetProperty(ref _container);
			set => SetProperty(ref _container, value);
		}

		[Ordinal(19)] 
		[RED("DpadHintLibraryPath")] 
		public inkWidgetLibraryReference DpadHintLibraryPath
		{
			get => GetProperty(ref _dpadHintLibraryPath);
			set => SetProperty(ref _dpadHintLibraryPath, value);
		}

		[Ordinal(20)] 
		[RED("autodriveLibraryPath")] 
		public inkWidgetLibraryReference AutodriveLibraryPath
		{
			get => GetProperty(ref _autodriveLibraryPath);
			set => SetProperty(ref _autodriveLibraryPath, value);
		}

		[Ordinal(21)] 
		[RED("IsInDriverCombat")] 
		public CBool IsInDriverCombat
		{
			get => GetProperty(ref _isInDriverCombat);
			set => SetProperty(ref _isInDriverCombat, value);
		}

		[Ordinal(22)] 
		[RED("IsPoliceVehicle")] 
		public CBool IsPoliceVehicle
		{
			get => GetProperty(ref _isPoliceVehicle);
			set => SetProperty(ref _isPoliceVehicle, value);
		}

		[Ordinal(23)] 
		[RED("isRadioBlocked")] 
		public CBool IsRadioBlocked
		{
			get => GetProperty(ref _isRadioBlocked);
			set => SetProperty(ref _isRadioBlocked, value);
		}

		[Ordinal(24)] 
		[RED("isInVehicleScene")] 
		public CBool IsInVehicleScene
		{
			get => GetProperty(ref _isInVehicleScene);
			set => SetProperty(ref _isInVehicleScene, value);
		}

		[Ordinal(25)] 
		[RED("isQuestBlocked")] 
		public CBool IsQuestBlocked
		{
			get => GetProperty(ref _isQuestBlocked);
			set => SetProperty(ref _isQuestBlocked, value);
		}

		[Ordinal(26)] 
		[RED("carHudListenerId")] 
		public CUInt32 CarHudListenerId
		{
			get => GetProperty(ref _carHudListenerId);
			set => SetProperty(ref _carHudListenerId, value);
		}

		[Ordinal(27)] 
		[RED("statusListener")] 
		public CHandle<HotkeyRadioStatusListener> StatusListener
		{
			get => GetProperty(ref _statusListener);
			set => SetProperty(ref _statusListener, value);
		}

		[Ordinal(28)] 
		[RED("PlayerEnteredVehicleListener")] 
		public CHandle<redCallbackObject> PlayerEnteredVehicleListener
		{
			get => GetProperty(ref _playerEnteredVehicleListener);
			set => SetProperty(ref _playerEnteredVehicleListener, value);
		}

		[Ordinal(29)] 
		[RED("autodriveToggledListener")] 
		public CHandle<redCallbackObject> AutodriveToggledListener
		{
			get => GetProperty(ref _autodriveToggledListener);
			set => SetProperty(ref _autodriveToggledListener, value);
		}

		[Ordinal(30)] 
		[RED("containerAnimProxy")] 
		public CHandle<inkanimProxy> ContainerAnimProxy
		{
			get => GetProperty(ref _containerAnimProxy);
			set => SetProperty(ref _containerAnimProxy, value);
		}

		[Ordinal(31)] 
		[RED("containerVisibility")] 
		public CBool ContainerVisibility
		{
			get => GetProperty(ref _containerVisibility);
			set => SetProperty(ref _containerVisibility, value);
		}

		public HotkeyConsumableWidgetController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
