using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DetermineInteractionStateTaskData : gameScriptTaskData
	{
		private gameGetActionsContext _context;

		[Ordinal(0)] 
		[RED("context")] 
		public gameGetActionsContext Context
		{
			get => GetProperty(ref _context);
			set => SetProperty(ref _context, value);
		}

		public DetermineInteractionStateTaskData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
