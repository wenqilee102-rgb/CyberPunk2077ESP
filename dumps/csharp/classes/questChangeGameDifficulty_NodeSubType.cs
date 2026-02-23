using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questChangeGameDifficulty_NodeSubType : questIGameManagerNonSignalStoppingNodeType
	{
		private CEnum<gameDifficulty> _difficulty;

		[Ordinal(0)] 
		[RED("difficulty")] 
		public CEnum<gameDifficulty> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		public questChangeGameDifficulty_NodeSubType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
