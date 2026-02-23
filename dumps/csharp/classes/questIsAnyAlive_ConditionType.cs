using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questIsAnyAlive_ConditionType : questIDynamicSpawnSystemConditionType
	{
		private CName _waveTag;
		private CBool _inverted;

		[Ordinal(0)] 
		[RED("waveTag")] 
		public CName WaveTag
		{
			get => GetProperty(ref _waveTag);
			set => SetProperty(ref _waveTag, value);
		}

		[Ordinal(1)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		public questIsAnyAlive_ConditionType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
