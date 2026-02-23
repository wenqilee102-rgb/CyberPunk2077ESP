using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PaginationArrowController : inkWidgetLogicController
	{
		private inkWidgetReference _arrowFilled;

		[Ordinal(1)] 
		[RED("arrowFilled")] 
		public inkWidgetReference ArrowFilled
		{
			get => GetProperty(ref _arrowFilled);
			set => SetProperty(ref _arrowFilled, value);
		}

		public PaginationArrowController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
