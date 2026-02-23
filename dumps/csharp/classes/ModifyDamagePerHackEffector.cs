using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ModifyDamagePerHackEffector : ModifyDamageEffector
	{
		private CBool _countOnlyUnique;

		[Ordinal(6)] 
		[RED("countOnlyUnique")] 
		public CBool CountOnlyUnique
		{
			get => GetProperty(ref _countOnlyUnique);
			set => SetProperty(ref _countOnlyUnique, value);
		}

		public ModifyDamagePerHackEffector(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
