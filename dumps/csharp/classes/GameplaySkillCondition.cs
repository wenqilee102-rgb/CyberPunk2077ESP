using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplaySkillCondition : GameplayConditionBase
	{
		private TweakDBID _skillToCheck;
		private CEnum<EGameplayChallengeLevel> _difficulty;
		private TweakDBID _skillBonus;
		private CInt32 _requiredLevel;

		[Ordinal(1)] 
		[RED("skillToCheck")] 
		public TweakDBID SkillToCheck
		{
			get => GetProperty(ref _skillToCheck);
			set => SetProperty(ref _skillToCheck, value);
		}

		[Ordinal(2)] 
		[RED("difficulty")] 
		public CEnum<EGameplayChallengeLevel> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		[Ordinal(3)] 
		[RED("skillBonus")] 
		public TweakDBID SkillBonus
		{
			get => GetProperty(ref _skillBonus);
			set => SetProperty(ref _skillBonus, value);
		}

		[Ordinal(4)] 
		[RED("requiredLevel")] 
		public CInt32 RequiredLevel
		{
			get => GetProperty(ref _requiredLevel);
			set => SetProperty(ref _requiredLevel, value);
		}

		public GameplaySkillCondition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
