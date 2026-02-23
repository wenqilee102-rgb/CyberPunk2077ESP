using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class StrikeFilterSingle_NPC : gameEffectObjectSingleFilter_Scripted
	{
		private CBool _onlyAlive;
		private CBool _onlyEnemies;

		[Ordinal(0)] 
		[RED("onlyAlive")] 
		public CBool OnlyAlive
		{
			get => GetProperty(ref _onlyAlive);
			set => SetProperty(ref _onlyAlive, value);
		}

		[Ordinal(1)] 
		[RED("onlyEnemies")] 
		public CBool OnlyEnemies
		{
			get => GetProperty(ref _onlyEnemies);
			set => SetProperty(ref _onlyEnemies, value);
		}

		public StrikeFilterSingle_NPC(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
