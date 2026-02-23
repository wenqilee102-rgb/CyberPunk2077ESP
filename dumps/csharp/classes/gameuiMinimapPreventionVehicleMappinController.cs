using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapPreventionVehicleMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _pulseWidget;
		private inkWidgetReference _visionWidget;
		private inkImageWidgetReference _outerIcon;
		private inkImageWidgetReference _maxTackIcon;
		private CName _fadeInAnimName;
		private CName _fadeOutAnimName;
		private CHandle<inkanimProxy> _fadeAnimProxy;
		private wCHandle<gameIBlackboard> _uIWantedBarBB;
		private CHandle<UI_WantedBarDef> _uIWantedBarDef;
		private CHandle<redCallbackObject> _currentWantedStateCallback;
		private CBool _playerEscapingPursuit;
		private CBool _playerWanted;
		private CName _mappinState;
		private CBool _keepIconOnClamping;
		private CFloat _maxVisibilityDistance;
		private CName _currentChaseState;
		private CFloat _detectionDropThreshold;
		private CBool _wasMaxDetectionReached;
		private wCHandle<vehicleBaseObject> _vehicle;
		private CBool _isMaxTacAV;

		[Ordinal(14)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetProperty(ref _pulseWidget);
			set => SetProperty(ref _pulseWidget, value);
		}

		[Ordinal(15)] 
		[RED("visionWidget")] 
		public inkWidgetReference VisionWidget
		{
			get => GetProperty(ref _visionWidget);
			set => SetProperty(ref _visionWidget, value);
		}

		[Ordinal(16)] 
		[RED("outerIcon")] 
		public inkImageWidgetReference OuterIcon
		{
			get => GetProperty(ref _outerIcon);
			set => SetProperty(ref _outerIcon, value);
		}

		[Ordinal(17)] 
		[RED("maxTackIcon")] 
		public inkImageWidgetReference MaxTackIcon
		{
			get => GetProperty(ref _maxTackIcon);
			set => SetProperty(ref _maxTackIcon, value);
		}

		[Ordinal(18)] 
		[RED("fadeInAnimName")] 
		public CName FadeInAnimName
		{
			get => GetProperty(ref _fadeInAnimName);
			set => SetProperty(ref _fadeInAnimName, value);
		}

		[Ordinal(19)] 
		[RED("fadeOutAnimName")] 
		public CName FadeOutAnimName
		{
			get => GetProperty(ref _fadeOutAnimName);
			set => SetProperty(ref _fadeOutAnimName, value);
		}

		[Ordinal(20)] 
		[RED("fadeAnimProxy")] 
		public CHandle<inkanimProxy> FadeAnimProxy
		{
			get => GetProperty(ref _fadeAnimProxy);
			set => SetProperty(ref _fadeAnimProxy, value);
		}

		[Ordinal(21)] 
		[RED("UIWantedBarBB")] 
		public wCHandle<gameIBlackboard> UIWantedBarBB
		{
			get => GetProperty(ref _uIWantedBarBB);
			set => SetProperty(ref _uIWantedBarBB, value);
		}

		[Ordinal(22)] 
		[RED("UIWantedBarDef")] 
		public CHandle<UI_WantedBarDef> UIWantedBarDef
		{
			get => GetProperty(ref _uIWantedBarDef);
			set => SetProperty(ref _uIWantedBarDef, value);
		}

		[Ordinal(23)] 
		[RED("currentWantedStateCallback")] 
		public CHandle<redCallbackObject> CurrentWantedStateCallback
		{
			get => GetProperty(ref _currentWantedStateCallback);
			set => SetProperty(ref _currentWantedStateCallback, value);
		}

		[Ordinal(24)] 
		[RED("playerEscapingPursuit")] 
		public CBool PlayerEscapingPursuit
		{
			get => GetProperty(ref _playerEscapingPursuit);
			set => SetProperty(ref _playerEscapingPursuit, value);
		}

		[Ordinal(25)] 
		[RED("playerWanted")] 
		public CBool PlayerWanted
		{
			get => GetProperty(ref _playerWanted);
			set => SetProperty(ref _playerWanted, value);
		}

		[Ordinal(26)] 
		[RED("mappinState")] 
		public CName MappinState
		{
			get => GetProperty(ref _mappinState);
			set => SetProperty(ref _mappinState, value);
		}

		[Ordinal(27)] 
		[RED("keepIconOnClamping")] 
		public CBool KeepIconOnClamping
		{
			get => GetProperty(ref _keepIconOnClamping);
			set => SetProperty(ref _keepIconOnClamping, value);
		}

		[Ordinal(28)] 
		[RED("maxVisibilityDistance")] 
		public CFloat MaxVisibilityDistance
		{
			get => GetProperty(ref _maxVisibilityDistance);
			set => SetProperty(ref _maxVisibilityDistance, value);
		}

		[Ordinal(29)] 
		[RED("currentChaseState")] 
		public CName CurrentChaseState
		{
			get => GetProperty(ref _currentChaseState);
			set => SetProperty(ref _currentChaseState, value);
		}

		[Ordinal(30)] 
		[RED("detectionDropThreshold")] 
		public CFloat DetectionDropThreshold
		{
			get => GetProperty(ref _detectionDropThreshold);
			set => SetProperty(ref _detectionDropThreshold, value);
		}

		[Ordinal(31)] 
		[RED("wasMaxDetectionReached")] 
		public CBool WasMaxDetectionReached
		{
			get => GetProperty(ref _wasMaxDetectionReached);
			set => SetProperty(ref _wasMaxDetectionReached, value);
		}

		[Ordinal(32)] 
		[RED("vehicle")] 
		public wCHandle<vehicleBaseObject> Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(33)] 
		[RED("isMaxTacAV")] 
		public CBool IsMaxTacAV
		{
			get => GetProperty(ref _isMaxTacAV);
			set => SetProperty(ref _isMaxTacAV, value);
		}

		public gameuiMinimapPreventionVehicleMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
