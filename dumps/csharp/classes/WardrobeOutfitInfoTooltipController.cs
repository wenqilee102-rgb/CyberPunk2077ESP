using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WardrobeOutfitInfoTooltipController : AGenericTooltipController
	{
		private inkVideoWidgetReference _videoWidget;

		[Ordinal(2)] 
		[RED("videoWidget")] 
		public inkVideoWidgetReference VideoWidget
		{
			get => GetProperty(ref _videoWidget);
			set => SetProperty(ref _videoWidget, value);
		}

		public WardrobeOutfitInfoTooltipController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
