using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MeleeHitAnimEventExecutor : gameEffectExecutor_Scripted
	{
		private CBool _ignoreWaterImpacts;

		[Ordinal(1)] 
		[RED("ignoreWaterImpacts")] 
		public CBool IgnoreWaterImpacts
		{
			get => GetProperty(ref _ignoreWaterImpacts);
			set => SetProperty(ref _ignoreWaterImpacts, value);
		}

		public MeleeHitAnimEventExecutor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
