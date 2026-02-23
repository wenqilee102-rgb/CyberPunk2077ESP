using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksSkillLevelLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _levelText;
		private CHandle<LevelRewardDisplayData> _levelData;
		private CBool _active;
		private CBool _hovered;

		[Ordinal(1)] 
		[RED("levelText")] 
		public inkTextWidgetReference LevelText
		{
			get => GetProperty(ref _levelText);
			set => SetProperty(ref _levelText, value);
		}

		[Ordinal(2)] 
		[RED("levelData")] 
		public CHandle<LevelRewardDisplayData> LevelData
		{
			get => GetProperty(ref _levelData);
			set => SetProperty(ref _levelData, value);
		}

		[Ordinal(3)] 
		[RED("active")] 
		public CBool Active
		{
			get => GetProperty(ref _active);
			set => SetProperty(ref _active, value);
		}

		[Ordinal(4)] 
		[RED("hovered")] 
		public CBool Hovered
		{
			get => GetProperty(ref _hovered);
			set => SetProperty(ref _hovered, value);
		}

		public NewPerksSkillLevelLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
