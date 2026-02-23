using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OverrideRangedAttackPackageEffector : gameEffector
	{
		private CHandle<gamedataRangedAttackPackage_Record> _attackPackage;

		[Ordinal(0)] 
		[RED("attackPackage")] 
		public CHandle<gamedataRangedAttackPackage_Record> AttackPackage
		{
			get => GetProperty(ref _attackPackage);
			set => SetProperty(ref _attackPackage, value);
		}

		public OverrideRangedAttackPackageEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
