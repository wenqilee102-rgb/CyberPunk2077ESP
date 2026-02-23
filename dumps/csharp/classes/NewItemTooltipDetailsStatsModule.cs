using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NewItemTooltipDetailsStatsModule : NewItemTooltipModuleController
	{
		private inkCompoundWidgetReference _statsContainer;
		private CBool _isCrafting;

		[Ordinal(5)] 
		[RED("statsContainer")] 
		public inkCompoundWidgetReference StatsContainer
		{
			get => GetProperty(ref _statsContainer);
			set => SetProperty(ref _statsContainer, value);
		}

		[Ordinal(6)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetProperty(ref _isCrafting);
			set => SetProperty(ref _isCrafting, value);
		}

		public NewItemTooltipDetailsStatsModule(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
