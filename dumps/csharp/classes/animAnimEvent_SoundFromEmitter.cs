using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimEvent_SoundFromEmitter : animAnimEvent
	{
		private CName _emitterName;

		[Ordinal(3)] 
		[RED("emitterName")] 
		public CName EmitterName
		{
			get => GetProperty(ref _emitterName);
			set => SetProperty(ref _emitterName, value);
		}

		public animAnimEvent_SoundFromEmitter(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
