using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BunkerDoor : Door
	{
		private CName _loudAnnouncementOpenSoundName;
		private CName _halfOpenSoundName;
		private CName _glitchingSoundName;
		private CName _fastOpenSoundName;

		[Ordinal(143)] 
		[RED("loudAnnouncementOpenSoundName")] 
		public CName LoudAnnouncementOpenSoundName
		{
			get => GetProperty(ref _loudAnnouncementOpenSoundName);
			set => SetProperty(ref _loudAnnouncementOpenSoundName, value);
		}

		[Ordinal(144)] 
		[RED("halfOpenSoundName")] 
		public CName HalfOpenSoundName
		{
			get => GetProperty(ref _halfOpenSoundName);
			set => SetProperty(ref _halfOpenSoundName, value);
		}

		[Ordinal(145)] 
		[RED("glitchingSoundName")] 
		public CName GlitchingSoundName
		{
			get => GetProperty(ref _glitchingSoundName);
			set => SetProperty(ref _glitchingSoundName, value);
		}

		[Ordinal(146)] 
		[RED("fastOpenSoundName")] 
		public CName FastOpenSoundName
		{
			get => GetProperty(ref _fastOpenSoundName);
			set => SetProperty(ref _fastOpenSoundName, value);
		}

		public BunkerDoor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
