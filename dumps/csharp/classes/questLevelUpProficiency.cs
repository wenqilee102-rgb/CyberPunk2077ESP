using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questLevelUpProficiency : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataProficiencyType> _proficiencyType;

		[Ordinal(1)] 
		[RED("proficiencyType")] 
		public CEnum<gamedataProficiencyType> ProficiencyType
		{
			get => GetProperty(ref _proficiencyType);
			set => SetProperty(ref _proficiencyType, value);
		}

		public questLevelUpProficiency(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
