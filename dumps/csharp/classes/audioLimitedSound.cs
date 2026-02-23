using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLimitedSound : CVariable
	{
		private CEnum<audioLimitedSoundType> _soundType;
		private CFloat _attenuationDistance;

		[Ordinal(0)] 
		[RED("soundType")] 
		public CEnum<audioLimitedSoundType> SoundType
		{
			get => GetProperty(ref _soundType);
			set => SetProperty(ref _soundType, value);
		}

		[Ordinal(1)] 
		[RED("attenuationDistance")] 
		public CFloat AttenuationDistance
		{
			get => GetProperty(ref _attenuationDistance);
			set => SetProperty(ref _attenuationDistance, value);
		}

		public audioLimitedSound(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
