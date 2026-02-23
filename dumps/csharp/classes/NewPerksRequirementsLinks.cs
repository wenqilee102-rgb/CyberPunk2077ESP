using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksRequirementsLinks : IScriptable
	{
		private CEnum<gamedataNewPerkType> _perk;
		private CArray<CEnum<gamedataNewPerkType>> _linkedPerks;

		[Ordinal(0)] 
		[RED("perk")] 
		public CEnum<gamedataNewPerkType> Perk
		{
			get => GetProperty(ref _perk);
			set => SetProperty(ref _perk, value);
		}

		[Ordinal(1)] 
		[RED("linkedPerks")] 
		public CArray<CEnum<gamedataNewPerkType>> LinkedPerks
		{
			get => GetProperty(ref _linkedPerks);
			set => SetProperty(ref _linkedPerks, value);
		}

		public NewPerksRequirementsLinks(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
