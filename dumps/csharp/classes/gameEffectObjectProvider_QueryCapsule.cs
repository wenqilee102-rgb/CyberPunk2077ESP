using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectObjectProvider_QueryCapsule : gameEffectObjectProvider
	{
		private CBool _gatherOnlyPuppets;
		private physicsQueryPreset _queryPreset;

		[Ordinal(0)] 
		[RED("gatherOnlyPuppets")] 
		public CBool GatherOnlyPuppets
		{
			get => GetProperty(ref _gatherOnlyPuppets);
			set => SetProperty(ref _gatherOnlyPuppets, value);
		}

		[Ordinal(1)] 
		[RED("queryPreset")] 
		public physicsQueryPreset QueryPreset
		{
			get => GetProperty(ref _queryPreset);
			set => SetProperty(ref _queryPreset, value);
		}

		public gameEffectObjectProvider_QueryCapsule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
