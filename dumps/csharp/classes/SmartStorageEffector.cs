using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SmartStorageEffector : ModifyAttackEffector
	{
		private CFloat _baseRevengeChance;
		private CFloat _revengeChanceStep;
		private CFloat _revealDuration;
		private TweakDBID _statusEffectForTarget;
		private TweakDBID _statusEffectForSelf;
		private CFloat _currentChance;

		[Ordinal(0)] 
		[RED("baseRevengeChance")] 
		public CFloat BaseRevengeChance
		{
			get => GetProperty(ref _baseRevengeChance);
			set => SetProperty(ref _baseRevengeChance, value);
		}

		[Ordinal(1)] 
		[RED("revengeChanceStep")] 
		public CFloat RevengeChanceStep
		{
			get => GetProperty(ref _revengeChanceStep);
			set => SetProperty(ref _revengeChanceStep, value);
		}

		[Ordinal(2)] 
		[RED("revealDuration")] 
		public CFloat RevealDuration
		{
			get => GetProperty(ref _revealDuration);
			set => SetProperty(ref _revealDuration, value);
		}

		[Ordinal(3)] 
		[RED("statusEffectForTarget")] 
		public TweakDBID StatusEffectForTarget
		{
			get => GetProperty(ref _statusEffectForTarget);
			set => SetProperty(ref _statusEffectForTarget, value);
		}

		[Ordinal(4)] 
		[RED("statusEffectForSelf")] 
		public TweakDBID StatusEffectForSelf
		{
			get => GetProperty(ref _statusEffectForSelf);
			set => SetProperty(ref _statusEffectForSelf, value);
		}

		[Ordinal(5)] 
		[RED("currentChance")] 
		public CFloat CurrentChance
		{
			get => GetProperty(ref _currentChance);
			set => SetProperty(ref _currentChance, value);
		}

		public SmartStorageEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
