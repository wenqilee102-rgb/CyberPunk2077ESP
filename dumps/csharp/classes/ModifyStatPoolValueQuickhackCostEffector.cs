using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyStatPoolValueQuickhackCostEffector : HitEventEffector
	{
		private CFloat _statPoolValue;
		private CEnum<gamedataStatPoolType> _statPoolType;
		private CFloat _recoverMemoryAmount;
		private CBool _skipLastCombatHack;

		[Ordinal(0)] 
		[RED("statPoolValue")] 
		public CFloat StatPoolValue
		{
			get => GetProperty(ref _statPoolValue);
			set => SetProperty(ref _statPoolValue, value);
		}

		[Ordinal(1)] 
		[RED("statPoolType")] 
		public CEnum<gamedataStatPoolType> StatPoolType
		{
			get => GetProperty(ref _statPoolType);
			set => SetProperty(ref _statPoolType, value);
		}

		[Ordinal(2)] 
		[RED("recoverMemoryAmount")] 
		public CFloat RecoverMemoryAmount
		{
			get => GetProperty(ref _recoverMemoryAmount);
			set => SetProperty(ref _recoverMemoryAmount, value);
		}

		[Ordinal(3)] 
		[RED("skipLastCombatHack")] 
		public CBool SkipLastCombatHack
		{
			get => GetProperty(ref _skipLastCombatHack);
			set => SetProperty(ref _skipLastCombatHack, value);
		}

		public ModifyStatPoolValueQuickhackCostEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
