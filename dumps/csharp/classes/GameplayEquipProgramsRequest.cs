using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GameplayEquipProgramsRequest : gamePlayerScriptableSystemRequest
	{
		private CArray<gameItemID> _programIDs;

		[Ordinal(1)] 
		[RED("programIDs")] 
		public CArray<gameItemID> ProgramIDs
		{
			get => GetProperty(ref _programIDs);
			set => SetProperty(ref _programIDs, value);
		}

		public GameplayEquipProgramsRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
