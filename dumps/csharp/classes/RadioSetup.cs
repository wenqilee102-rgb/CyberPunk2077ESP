using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RadioSetup : CVariable
	{
		private CBool _randomizeStartingStation;
		private CEnum<ERadioStationList> _startingStation;
		private CBool _isInteractive;
		private CName _glitchSFX;
		private CBool _enableHighPitchNoiseQuickHack;
		private CName _highPitchNoiseSFX;
		private gameFxResource _hithPitchNoiseVFX;
		private CFloat _hithPitchNoiseRadius;
		private CBool _enableAoeDamageQuickHack;
		private CName _aoeDamageSFX;
		private gameFxResource _aoeDamageVFX;

		[Ordinal(0)] 
		[RED("randomizeStartingStation")] 
		public CBool RandomizeStartingStation
		{
			get => GetProperty(ref _randomizeStartingStation);
			set => SetProperty(ref _randomizeStartingStation, value);
		}

		[Ordinal(1)] 
		[RED("startingStation")] 
		public CEnum<ERadioStationList> StartingStation
		{
			get => GetProperty(ref _startingStation);
			set => SetProperty(ref _startingStation, value);
		}

		[Ordinal(2)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get => GetProperty(ref _isInteractive);
			set => SetProperty(ref _isInteractive, value);
		}

		[Ordinal(3)] 
		[RED("glitchSFX")] 
		public CName GlitchSFX
		{
			get => GetProperty(ref _glitchSFX);
			set => SetProperty(ref _glitchSFX, value);
		}

		[Ordinal(4)] 
		[RED("enableHighPitchNoiseQuickHack")] 
		public CBool EnableHighPitchNoiseQuickHack
		{
			get => GetProperty(ref _enableHighPitchNoiseQuickHack);
			set => SetProperty(ref _enableHighPitchNoiseQuickHack, value);
		}

		[Ordinal(5)] 
		[RED("highPitchNoiseSFX")] 
		public CName HighPitchNoiseSFX
		{
			get => GetProperty(ref _highPitchNoiseSFX);
			set => SetProperty(ref _highPitchNoiseSFX, value);
		}

		[Ordinal(6)] 
		[RED("hithPitchNoiseVFX")] 
		public gameFxResource HithPitchNoiseVFX
		{
			get => GetProperty(ref _hithPitchNoiseVFX);
			set => SetProperty(ref _hithPitchNoiseVFX, value);
		}

		[Ordinal(7)] 
		[RED("hithPitchNoiseRadius")] 
		public CFloat HithPitchNoiseRadius
		{
			get => GetProperty(ref _hithPitchNoiseRadius);
			set => SetProperty(ref _hithPitchNoiseRadius, value);
		}

		[Ordinal(8)] 
		[RED("enableAoeDamageQuickHack")] 
		public CBool EnableAoeDamageQuickHack
		{
			get => GetProperty(ref _enableAoeDamageQuickHack);
			set => SetProperty(ref _enableAoeDamageQuickHack, value);
		}

		[Ordinal(9)] 
		[RED("AoeDamageSFX")] 
		public CName AoeDamageSFX
		{
			get => GetProperty(ref _aoeDamageSFX);
			set => SetProperty(ref _aoeDamageSFX, value);
		}

		[Ordinal(10)] 
		[RED("AoeDamageVFX")] 
		public gameFxResource AoeDamageVFX
		{
			get => GetProperty(ref _aoeDamageVFX);
			set => SetProperty(ref _aoeDamageVFX, value);
		}

		public RadioSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
