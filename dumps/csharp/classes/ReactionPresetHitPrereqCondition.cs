using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ReactionPresetHitPrereqCondition : BaseHitPrereqCondition
	{
		private CString _reactionPreset;

		[Ordinal(3)] 
		[RED("reactionPreset")] 
		public CString ReactionPreset
		{
			get => GetProperty(ref _reactionPreset);
			set => SetProperty(ref _reactionPreset, value);
		}

		public ReactionPresetHitPrereqCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
