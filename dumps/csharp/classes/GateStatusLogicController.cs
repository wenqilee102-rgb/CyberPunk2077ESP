using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GateStatusLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _textStatus;

		[Ordinal(1)] 
		[RED("textStatus")] 
		public inkTextWidgetReference TextStatus
		{
			get => GetProperty(ref _textStatus);
			set => SetProperty(ref _textStatus, value);
		}

		public GateStatusLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
