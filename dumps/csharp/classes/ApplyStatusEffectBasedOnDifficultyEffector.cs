using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ApplyStatusEffectBasedOnDifficultyEffector : ApplyStatusEffectEffector
	{
		private TweakDBID _statusEffectOnStoryDifficulty;
		private TweakDBID _statusEffectOnEasyDifficulty;
		private TweakDBID _statusEffectOnHardDifficulty;
		private TweakDBID _statusEffectOnVeryHardDifficulty;

		[Ordinal(8)] 
		[RED("statusEffectOnStoryDifficulty")] 
		public TweakDBID StatusEffectOnStoryDifficulty
		{
			get => GetProperty(ref _statusEffectOnStoryDifficulty);
			set => SetProperty(ref _statusEffectOnStoryDifficulty, value);
		}

		[Ordinal(9)] 
		[RED("statusEffectOnEasyDifficulty")] 
		public TweakDBID StatusEffectOnEasyDifficulty
		{
			get => GetProperty(ref _statusEffectOnEasyDifficulty);
			set => SetProperty(ref _statusEffectOnEasyDifficulty, value);
		}

		[Ordinal(10)] 
		[RED("statusEffectOnHardDifficulty")] 
		public TweakDBID StatusEffectOnHardDifficulty
		{
			get => GetProperty(ref _statusEffectOnHardDifficulty);
			set => SetProperty(ref _statusEffectOnHardDifficulty, value);
		}

		[Ordinal(11)] 
		[RED("statusEffectOnVeryHardDifficulty")] 
		public TweakDBID StatusEffectOnVeryHardDifficulty
		{
			get => GetProperty(ref _statusEffectOnVeryHardDifficulty);
			set => SetProperty(ref _statusEffectOnVeryHardDifficulty, value);
		}

		public ApplyStatusEffectBasedOnDifficultyEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
