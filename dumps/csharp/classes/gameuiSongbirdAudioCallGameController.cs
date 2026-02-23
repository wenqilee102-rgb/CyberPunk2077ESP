using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiSongbirdAudioCallGameController : gameuiHUDGameController
	{
		private CBool _waveformEnabled;
		private CFloat _voLevelsUpdateTimer;
		private CFloat _intensityMultiplier;
		private CArray<inkWidgetReference> _targets;

		[Ordinal(9)] 
		[RED("waveformEnabled")] 
		public CBool WaveformEnabled
		{
			get => GetProperty(ref _waveformEnabled);
			set => SetProperty(ref _waveformEnabled, value);
		}

		[Ordinal(10)] 
		[RED("voLevelsUpdateTimer")] 
		public CFloat VoLevelsUpdateTimer
		{
			get => GetProperty(ref _voLevelsUpdateTimer);
			set => SetProperty(ref _voLevelsUpdateTimer, value);
		}

		[Ordinal(11)] 
		[RED("intensityMultiplier")] 
		public CFloat IntensityMultiplier
		{
			get => GetProperty(ref _intensityMultiplier);
			set => SetProperty(ref _intensityMultiplier, value);
		}

		[Ordinal(12)] 
		[RED("targets")] 
		public CArray<inkWidgetReference> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		public gameuiSongbirdAudioCallGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
