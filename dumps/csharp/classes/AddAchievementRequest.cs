using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AddAchievementRequest : gamePlayerScriptableSystemRequest
	{
		private CEnum<gamedataAchievement> _achievement;

		[Ordinal(1)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetProperty(ref _achievement);
			set => SetProperty(ref _achievement, value);
		}

		public AddAchievementRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
