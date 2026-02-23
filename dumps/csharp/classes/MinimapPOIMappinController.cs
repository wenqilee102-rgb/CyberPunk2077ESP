using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MinimapPOIMappinController : gameuiBaseMinimapMappinController
	{
		private inkWidgetReference _pulseWidget;
		private CBool _pingAnimationOnStateChange;
		private wCHandle<gamemappinsPointOfInterestMappin> _poiMappin;
		private wCHandle<gamemappinsQuestMappin> _questMappin;
		private CBool _isCompletedPhase;
		private CEnum<gamedataMappinPhase> _mappinPhase;
		private CHandle<inkanimProxy> _pingAnim;
		private CEnum<gamedataMappinVariant> _mappinVariant;
		private CUInt32 _c_pingAnimCount;
		private CBool _isNcpdScanner;
		private CHandle<VehicleMinimapMappinComponent> _vehicleMinimapMappinComponent;
		private CBool _keepIconOnClamping;

		[Ordinal(14)] 
		[RED("pulseWidget")] 
		public inkWidgetReference PulseWidget
		{
			get => GetProperty(ref _pulseWidget);
			set => SetProperty(ref _pulseWidget, value);
		}

		[Ordinal(15)] 
		[RED("pingAnimationOnStateChange")] 
		public CBool PingAnimationOnStateChange
		{
			get => GetProperty(ref _pingAnimationOnStateChange);
			set => SetProperty(ref _pingAnimationOnStateChange, value);
		}

		[Ordinal(16)] 
		[RED("poiMappin")] 
		public wCHandle<gamemappinsPointOfInterestMappin> PoiMappin
		{
			get => GetProperty(ref _poiMappin);
			set => SetProperty(ref _poiMappin, value);
		}

		[Ordinal(17)] 
		[RED("questMappin")] 
		public wCHandle<gamemappinsQuestMappin> QuestMappin
		{
			get => GetProperty(ref _questMappin);
			set => SetProperty(ref _questMappin, value);
		}

		[Ordinal(18)] 
		[RED("isCompletedPhase")] 
		public CBool IsCompletedPhase
		{
			get => GetProperty(ref _isCompletedPhase);
			set => SetProperty(ref _isCompletedPhase, value);
		}

		[Ordinal(19)] 
		[RED("mappinPhase")] 
		public CEnum<gamedataMappinPhase> MappinPhase
		{
			get => GetProperty(ref _mappinPhase);
			set => SetProperty(ref _mappinPhase, value);
		}

		[Ordinal(20)] 
		[RED("pingAnim")] 
		public CHandle<inkanimProxy> PingAnim
		{
			get => GetProperty(ref _pingAnim);
			set => SetProperty(ref _pingAnim, value);
		}

		[Ordinal(21)] 
		[RED("mappinVariant")] 
		public CEnum<gamedataMappinVariant> MappinVariant
		{
			get => GetProperty(ref _mappinVariant);
			set => SetProperty(ref _mappinVariant, value);
		}

		[Ordinal(22)] 
		[RED("c_pingAnimCount")] 
		public CUInt32 C_pingAnimCount
		{
			get => GetProperty(ref _c_pingAnimCount);
			set => SetProperty(ref _c_pingAnimCount, value);
		}

		[Ordinal(23)] 
		[RED("isNcpdScanner")] 
		public CBool IsNcpdScanner
		{
			get => GetProperty(ref _isNcpdScanner);
			set => SetProperty(ref _isNcpdScanner, value);
		}

		[Ordinal(24)] 
		[RED("vehicleMinimapMappinComponent")] 
		public CHandle<VehicleMinimapMappinComponent> VehicleMinimapMappinComponent
		{
			get => GetProperty(ref _vehicleMinimapMappinComponent);
			set => SetProperty(ref _vehicleMinimapMappinComponent, value);
		}

		[Ordinal(25)] 
		[RED("keepIconOnClamping")] 
		public CBool KeepIconOnClamping
		{
			get => GetProperty(ref _keepIconOnClamping);
			set => SetProperty(ref _keepIconOnClamping, value);
		}

		public MinimapPOIMappinController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
