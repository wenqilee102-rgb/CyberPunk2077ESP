using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FuseControllerPS : MasterControllerPS
	{
		private CHandle<DeviceTimeTableManager> _timeTableSetup;
		private CInt32 _maxLightsSwitchedAtOnce;
		private CFloat _timeToNextSwitch;
		private CEnum<ELightSwitchRandomizerType> _lightSwitchRandomizerType;
		private TweakDBID _alternativeNameForON;
		private TweakDBID _alternativeNameForOFF;
		private TweakDBID _alternativeNameForPower;
		private TweakDBID _alternativeNameForUnpower;
		private CBool _isCLSInitialized;

		[Ordinal(108)] 
		[RED("timeTableSetup")] 
		public CHandle<DeviceTimeTableManager> TimeTableSetup
		{
			get => GetProperty(ref _timeTableSetup);
			set => SetProperty(ref _timeTableSetup, value);
		}

		[Ordinal(109)] 
		[RED("maxLightsSwitchedAtOnce")] 
		public CInt32 MaxLightsSwitchedAtOnce
		{
			get => GetProperty(ref _maxLightsSwitchedAtOnce);
			set => SetProperty(ref _maxLightsSwitchedAtOnce, value);
		}

		[Ordinal(110)] 
		[RED("timeToNextSwitch")] 
		public CFloat TimeToNextSwitch
		{
			get => GetProperty(ref _timeToNextSwitch);
			set => SetProperty(ref _timeToNextSwitch, value);
		}

		[Ordinal(111)] 
		[RED("lightSwitchRandomizerType")] 
		public CEnum<ELightSwitchRandomizerType> LightSwitchRandomizerType
		{
			get => GetProperty(ref _lightSwitchRandomizerType);
			set => SetProperty(ref _lightSwitchRandomizerType, value);
		}

		[Ordinal(112)] 
		[RED("alternativeNameForON")] 
		public TweakDBID AlternativeNameForON
		{
			get => GetProperty(ref _alternativeNameForON);
			set => SetProperty(ref _alternativeNameForON, value);
		}

		[Ordinal(113)] 
		[RED("alternativeNameForOFF")] 
		public TweakDBID AlternativeNameForOFF
		{
			get => GetProperty(ref _alternativeNameForOFF);
			set => SetProperty(ref _alternativeNameForOFF, value);
		}

		[Ordinal(114)] 
		[RED("alternativeNameForPower")] 
		public TweakDBID AlternativeNameForPower
		{
			get => GetProperty(ref _alternativeNameForPower);
			set => SetProperty(ref _alternativeNameForPower, value);
		}

		[Ordinal(115)] 
		[RED("alternativeNameForUnpower")] 
		public TweakDBID AlternativeNameForUnpower
		{
			get => GetProperty(ref _alternativeNameForUnpower);
			set => SetProperty(ref _alternativeNameForUnpower, value);
		}

		[Ordinal(116)] 
		[RED("isCLSInitialized")] 
		public CBool IsCLSInitialized
		{
			get => GetProperty(ref _isCLSInitialized);
			set => SetProperty(ref _isCLSInitialized, value);
		}

		public FuseControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
