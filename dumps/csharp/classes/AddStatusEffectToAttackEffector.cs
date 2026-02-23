using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddStatusEffectToAttackEffector : ModifyAttackEffector
	{
		private CBool _isRandom;
		private CArray<wCHandle<gamedataStatModifier_Record>> _applicationChanceMods;
		private SHitStatusEffect _statusEffect;
		private CFloat _stacks;

		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetProperty(ref _isRandom);
			set => SetProperty(ref _isRandom, value);
		}

		[Ordinal(1)] 
		[RED("applicationChanceMods")] 
		public CArray<wCHandle<gamedataStatModifier_Record>> ApplicationChanceMods
		{
			get => GetProperty(ref _applicationChanceMods);
			set => SetProperty(ref _applicationChanceMods, value);
		}

		[Ordinal(2)] 
		[RED("statusEffect")] 
		public SHitStatusEffect StatusEffect
		{
			get => GetProperty(ref _statusEffect);
			set => SetProperty(ref _statusEffect, value);
		}

		[Ordinal(3)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get => GetProperty(ref _stacks);
			set => SetProperty(ref _stacks, value);
		}

		public AddStatusEffectToAttackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
