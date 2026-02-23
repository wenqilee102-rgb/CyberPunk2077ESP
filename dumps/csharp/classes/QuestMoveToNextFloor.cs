using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class QuestMoveToNextFloor : ActionBool
	{
		private NodeRef _floor;

		[Ordinal(39)] 
		[RED("floor")] 
		public NodeRef Floor
		{
			get => GetProperty(ref _floor);
			set => SetProperty(ref _floor, value);
		}

		public QuestMoveToNextFloor(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
