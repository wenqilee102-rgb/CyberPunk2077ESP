using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSetAchievementProgressRequest : gamePlayerScriptableSystemRequest
	{
		private CInt32 _currentValue;
		private CInt32 _customTarget;
		private CEnum<gamedataAchievement> _achievement;

		[Ordinal(1)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		[Ordinal(2)] 
		[RED("customTarget")] 
		public CInt32 CustomTarget
		{
			get => GetProperty(ref _customTarget);
			set => SetProperty(ref _customTarget, value);
		}

		[Ordinal(3)] 
		[RED("achievement")] 
		public CEnum<gamedataAchievement> Achievement
		{
			get => GetProperty(ref _achievement);
			set => SetProperty(ref _achievement, value);
		}

		public questSetAchievementProgressRequest(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
