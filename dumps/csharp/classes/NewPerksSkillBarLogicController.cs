using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewPerksSkillBarLogicController : inkVirtualCompoundItemController
	{
		private inkWidgetReference _statsProgressWidget;
		private inkCompoundWidgetReference _levelsContainer;
		private CHandle<ProficiencyDisplayData> _data;
		private CInt32 _requestedSkills;
		private wCHandle<StatsProgressController> _statsProgressController;
		private CArray<wCHandle<NewPerksSkillLevelLogicController>> _levelsControllers;

		[Ordinal(18)] 
		[RED("statsProgressWidget")] 
		public inkWidgetReference StatsProgressWidget
		{
			get => GetProperty(ref _statsProgressWidget);
			set => SetProperty(ref _statsProgressWidget, value);
		}

		[Ordinal(19)] 
		[RED("levelsContainer")] 
		public inkCompoundWidgetReference LevelsContainer
		{
			get => GetProperty(ref _levelsContainer);
			set => SetProperty(ref _levelsContainer, value);
		}

		[Ordinal(20)] 
		[RED("data")] 
		public CHandle<ProficiencyDisplayData> Data
		{
			get => GetProperty(ref _data);
			set => SetProperty(ref _data, value);
		}

		[Ordinal(21)] 
		[RED("requestedSkills")] 
		public CInt32 RequestedSkills
		{
			get => GetProperty(ref _requestedSkills);
			set => SetProperty(ref _requestedSkills, value);
		}

		[Ordinal(22)] 
		[RED("statsProgressController")] 
		public wCHandle<StatsProgressController> StatsProgressController
		{
			get => GetProperty(ref _statsProgressController);
			set => SetProperty(ref _statsProgressController, value);
		}

		[Ordinal(23)] 
		[RED("levelsControllers")] 
		public CArray<wCHandle<NewPerksSkillLevelLogicController>> LevelsControllers
		{
			get => GetProperty(ref _levelsControllers);
			set => SetProperty(ref _levelsControllers, value);
		}

		public NewPerksSkillBarLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
