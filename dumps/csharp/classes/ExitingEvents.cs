using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ExitingEvents : ExitingEventsBase
	{
		private CBool _fromDriverCombat;

		[Ordinal(4)] 
		[RED("fromDriverCombat")] 
		public CBool FromDriverCombat
		{
			get => GetProperty(ref _fromDriverCombat);
			set => SetProperty(ref _fromDriverCombat, value);
		}

		public ExitingEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
