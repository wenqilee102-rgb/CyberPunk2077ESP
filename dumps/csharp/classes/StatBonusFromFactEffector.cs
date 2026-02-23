using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StatBonusFromFactEffector : gameEffector
	{
		private CName _applicationTarget;
		private CHandle<gamedataStat_Record> _stat;
		private CFloat _bonusPerStack;
		private CName _fact;
		private CHandle<gameConstantStatModifierData_Deprecated> _modifier;

		[Ordinal(0)] 
		[RED("applicationTarget")] 
		public CName ApplicationTarget
		{
			get => GetProperty(ref _applicationTarget);
			set => SetProperty(ref _applicationTarget, value);
		}

		[Ordinal(1)] 
		[RED("stat")] 
		public CHandle<gamedataStat_Record> Stat
		{
			get => GetProperty(ref _stat);
			set => SetProperty(ref _stat, value);
		}

		[Ordinal(2)] 
		[RED("bonusPerStack")] 
		public CFloat BonusPerStack
		{
			get => GetProperty(ref _bonusPerStack);
			set => SetProperty(ref _bonusPerStack, value);
		}

		[Ordinal(3)] 
		[RED("fact")] 
		public CName Fact
		{
			get => GetProperty(ref _fact);
			set => SetProperty(ref _fact, value);
		}

		[Ordinal(4)] 
		[RED("modifier")] 
		public CHandle<gameConstantStatModifierData_Deprecated> Modifier
		{
			get => GetProperty(ref _modifier);
			set => SetProperty(ref _modifier, value);
		}

		public StatBonusFromFactEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
