using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MenuScenario_SingleplayerMenu : MenuScenario_PreGameSubMenu
	{
		private CBool _expansionHintShown;

		[Ordinal(2)] 
		[RED("expansionHintShown")] 
		public CBool ExpansionHintShown
		{
			get => GetProperty(ref _expansionHintShown);
			set => SetProperty(ref _expansionHintShown, value);
		}

		public MenuScenario_SingleplayerMenu(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
