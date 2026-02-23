using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioBreathingUnderwaterMetadata : audioAudioMetadata
	{
		private CName _inhaleSound;
		private CName _exhaleSound;
		private CName _emergenceSound;
		private CName _struggledEmergenceSound;
		private CName _divingSuitRTPC;
		private CFloat _bPM;
		private CFloat _lowOxygen;

		[Ordinal(1)] 
		[RED("inhaleSound")] 
		public CName InhaleSound
		{
			get => GetProperty(ref _inhaleSound);
			set => SetProperty(ref _inhaleSound, value);
		}

		[Ordinal(2)] 
		[RED("exhaleSound")] 
		public CName ExhaleSound
		{
			get => GetProperty(ref _exhaleSound);
			set => SetProperty(ref _exhaleSound, value);
		}

		[Ordinal(3)] 
		[RED("emergenceSound")] 
		public CName EmergenceSound
		{
			get => GetProperty(ref _emergenceSound);
			set => SetProperty(ref _emergenceSound, value);
		}

		[Ordinal(4)] 
		[RED("struggledEmergenceSound")] 
		public CName StruggledEmergenceSound
		{
			get => GetProperty(ref _struggledEmergenceSound);
			set => SetProperty(ref _struggledEmergenceSound, value);
		}

		[Ordinal(5)] 
		[RED("divingSuitRTPC")] 
		public CName DivingSuitRTPC
		{
			get => GetProperty(ref _divingSuitRTPC);
			set => SetProperty(ref _divingSuitRTPC, value);
		}

		[Ordinal(6)] 
		[RED("BPM")] 
		public CFloat BPM
		{
			get => GetProperty(ref _bPM);
			set => SetProperty(ref _bPM, value);
		}

		[Ordinal(7)] 
		[RED("lowOxygen")] 
		public CFloat LowOxygen
		{
			get => GetProperty(ref _lowOxygen);
			set => SetProperty(ref _lowOxygen, value);
		}

		public audioBreathingUnderwaterMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
