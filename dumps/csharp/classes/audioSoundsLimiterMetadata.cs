using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioSoundsLimiterMetadata : audioAudioMetadata
	{
		private CArray<audioLimitedSound> _tooManyPlayingGruntsAndVOsLimitation;
		private CArray<audioLimitedSound> _gunsAreLoudAndMusicIsActiveLimitation;
		private CArray<audioLimitedSound> _gunsAreLoudLimitation;
		private CArray<audioLimitedSound> _tooManyPlayingSoundsLimitation;

		[Ordinal(1)] 
		[RED("tooManyPlayingGruntsAndVOsLimitation")] 
		public CArray<audioLimitedSound> TooManyPlayingGruntsAndVOsLimitation
		{
			get => GetProperty(ref _tooManyPlayingGruntsAndVOsLimitation);
			set => SetProperty(ref _tooManyPlayingGruntsAndVOsLimitation, value);
		}

		[Ordinal(2)] 
		[RED("gunsAreLoudAndMusicIsActiveLimitation")] 
		public CArray<audioLimitedSound> GunsAreLoudAndMusicIsActiveLimitation
		{
			get => GetProperty(ref _gunsAreLoudAndMusicIsActiveLimitation);
			set => SetProperty(ref _gunsAreLoudAndMusicIsActiveLimitation, value);
		}

		[Ordinal(3)] 
		[RED("gunsAreLoudLimitation")] 
		public CArray<audioLimitedSound> GunsAreLoudLimitation
		{
			get => GetProperty(ref _gunsAreLoudLimitation);
			set => SetProperty(ref _gunsAreLoudLimitation, value);
		}

		[Ordinal(4)] 
		[RED("tooManyPlayingSoundsLimitation")] 
		public CArray<audioLimitedSound> TooManyPlayingSoundsLimitation
		{
			get => GetProperty(ref _tooManyPlayingSoundsLimitation);
			set => SetProperty(ref _tooManyPlayingSoundsLimitation, value);
		}

		public audioSoundsLimiterMetadata(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
