using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ArcadeMinigameUserData : inkUserData
	{
		private CEnum<ArcadeMinigame> _minigame;

		[Ordinal(0)] 
		[RED("minigame")] 
		public CEnum<ArcadeMinigame> Minigame
		{
			get => GetProperty(ref _minigame);
			set => SetProperty(ref _minigame, value);
		}

		public ArcadeMinigameUserData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
