using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PlayNewPerksSoundEvent : redEvent
	{
		private CName _soundName;
		private CEnum<inkRumbleStrength> _rumbleStrength;
		private CBool _stopIfPlaying;

		[Ordinal(0)] 
		[RED("soundName")] 
		public CName SoundName
		{
			get => GetProperty(ref _soundName);
			set => SetProperty(ref _soundName, value);
		}

		[Ordinal(1)] 
		[RED("rumbleStrength")] 
		public CEnum<inkRumbleStrength> RumbleStrength
		{
			get => GetProperty(ref _rumbleStrength);
			set => SetProperty(ref _rumbleStrength, value);
		}

		[Ordinal(2)] 
		[RED("stopIfPlaying")] 
		public CBool StopIfPlaying
		{
			get => GetProperty(ref _stopIfPlaying);
			set => SetProperty(ref _stopIfPlaying, value);
		}

		public PlayNewPerksSoundEvent(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
