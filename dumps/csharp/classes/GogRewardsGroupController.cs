using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class GogRewardsGroupController : inkWidgetLogicController
	{
		private inkTextWidgetReference _label;
		private inkWidgetReference _containerWidget;

		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetProperty(ref _label);
			set => SetProperty(ref _label, value);
		}

		[Ordinal(2)] 
		[RED("containerWidget")] 
		public inkWidgetReference ContainerWidget
		{
			get => GetProperty(ref _containerWidget);
			set => SetProperty(ref _containerWidget, value);
		}

		public GogRewardsGroupController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
