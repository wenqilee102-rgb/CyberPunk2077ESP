using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiBriefingGameController : gameuiWidgetGameController
	{
		private CEnum<questBriefingPlayerType> _briefingPlayerType;

		[Ordinal(2)] 
		[RED("briefingPlayerType")] 
		public CEnum<questBriefingPlayerType> BriefingPlayerType
		{
			get => GetProperty(ref _briefingPlayerType);
			set => SetProperty(ref _briefingPlayerType, value);
		}

		public gameuiBriefingGameController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
