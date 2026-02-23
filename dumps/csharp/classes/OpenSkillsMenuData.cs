using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class OpenSkillsMenuData : IScriptable
	{
		private CBool _openSkills;

		[Ordinal(0)] 
		[RED("openSkills")] 
		public CBool OpenSkills
		{
			get => GetProperty(ref _openSkills);
			set => SetProperty(ref _openSkills, value);
		}

		public OpenSkillsMenuData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
