using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyAttackCritChanceEffector : ModifyAttackEffector
	{
		private CArray<wCHandle<gamedataStatModifier_Record>> _applicationChanceMods;

		[Ordinal(0)] 
		[RED("applicationChanceMods")] 
		public CArray<wCHandle<gamedataStatModifier_Record>> ApplicationChanceMods
		{
			get => GetProperty(ref _applicationChanceMods);
			set => SetProperty(ref _applicationChanceMods, value);
		}

		public ModifyAttackCritChanceEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
