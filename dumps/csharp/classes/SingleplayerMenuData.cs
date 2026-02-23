using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SingleplayerMenuData : inkUserData
	{
		private CBool _mainMenuShownFirstTime;
		private CBool _showExpansionHint;

		[Ordinal(0)] 
		[RED("mainMenuShownFirstTime")] 
		public CBool MainMenuShownFirstTime
		{
			get => GetProperty(ref _mainMenuShownFirstTime);
			set => SetProperty(ref _mainMenuShownFirstTime, value);
		}

		[Ordinal(1)] 
		[RED("showExpansionHint")] 
		public CBool ShowExpansionHint
		{
			get => GetProperty(ref _showExpansionHint);
			set => SetProperty(ref _showExpansionHint, value);
		}

		public SingleplayerMenuData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
