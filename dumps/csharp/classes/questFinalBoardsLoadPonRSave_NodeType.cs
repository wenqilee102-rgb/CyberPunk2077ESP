using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questFinalBoardsLoadPonRSave_NodeType : questIUIManagerNodeType
	{
		private CBool _loadPointOfNoReturnSave;

		[Ordinal(0)] 
		[RED("loadPointOfNoReturnSave")] 
		public CBool LoadPointOfNoReturnSave
		{
			get => GetProperty(ref _loadPointOfNoReturnSave);
			set => SetProperty(ref _loadPointOfNoReturnSave, value);
		}

		public questFinalBoardsLoadPonRSave_NodeType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
